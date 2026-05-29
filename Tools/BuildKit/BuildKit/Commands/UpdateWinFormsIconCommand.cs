// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Helpers.WinForms;
using BuildKit.Models;
using BuildKit.Services;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace BuildKit.Commands;

public class UpdateWinFormsIconCommand(IServiceScopeFactory scopeFactory, IServiceProvider globalServiceProvider) : Command<UpdateWinFormsIconCommandArgs>
{
    public override int Execute(CommandContext context, UpdateWinFormsIconCommandArgs args, CancellationToken cancellationToken)
    {
        var fileSearcher = globalServiceProvider.GetRequiredService<FileSearcherHelper>();
        List<FileMeta> csprojFileMetas = fileSearcher.FindAllFiles(args.WorkingDir);

        if (!csprojFileMetas.Any())
        {
            AnsiConsole.MarkupLine("[red]No projects found.[/]");
            return -1;
        }

        WriteTableHeaders();

        AnsiConsole.Live(_table)
            .AutoClear(false)
            .Overflow(VerticalOverflow.Ellipsis)
            .Cropping(VerticalOverflowCropping.Bottom)
            .Start(ctx => Run(ctx, csprojFileMetas, args, cancellationToken));

        return 0;
    }

    private void Run(LiveDisplayContext ctx, List<FileMeta> csprojFileMetas, UpdateWinFormsIconCommandArgs args, CancellationToken cancellationToken)
    {
        foreach (var fileMeta in csprojFileMetas)
        {
            using IServiceScope scope = scopeFactory.CreateScope();

            var iconUpdateService =
                scope.ServiceProvider.GetRequiredKeyedService<UpdateWinFormsIconService>("WinForms");

            var projectAnalyzer =
                scope.ServiceProvider.GetRequiredKeyedService<WinFormsProjectAnalyzer>("WinForms");

            WinFormsProjectMeta projectMeta =
                projectAnalyzer.Analyze(fileMeta.FilePath, cancellationToken);

            int rowIndex = _table.Rows.Count;
            WriteProcessingRow(ctx, projectMeta);

            try
            {

                if (args.NewIcon is not null)
                {
                    File.Copy(
                        args.NewIcon,
                        Path.Combine(projectMeta.ProjectDir, args.IconPath),
                        overwrite: true
                    );
                }

                iconUpdateService.Run(
                    projectMeta,
                    args.IconPath,
                    args.ResxInjectionType,
                    cancellationToken
                );

                WriteSuccess(ctx, rowIndex);
            }
            catch (Exception ex)
            {
                WriteError(ctx, rowIndex, ex);
            }

            ctx.Refresh();
        }
    }

    #region TUI
    private readonly Table _table = new Table()
        .Border(TableBorder.Rounded)
        .Expand();

    private void WriteTableHeaders()
    {
        _table.AddColumn("[bold]Project[/]");
        _table.AddColumn("[bold]Directory[/]");
        _table.AddColumn("[bold]Status[/]");
        _table.AddColumn("[bold]Icon[/]");
        _table.AddColumn("[bold]Error[/]");
    }

    private void WriteProcessingRow(LiveDisplayContext ctx, WinFormsProjectMeta projectMeta)
    {
        _table.AddRow(
            Path.GetFileNameWithoutExtension(projectMeta.ProjectDir),
            projectMeta.ProjectDir,
            "[yellow]Processing...[/]",
            "[grey]—[/]",
            string.Empty
        );
        ctx.Refresh();
    }

    private void WriteSuccess(LiveDisplayContext ctx, int rowIndex)
    {
        _table.UpdateCell(rowIndex, 2, "[green]✔[/]");
        _table.UpdateCell(rowIndex, 3, "[green]✔[/]");
        _table.UpdateCell(rowIndex, 3, "[green]-[/]");
        ctx.Refresh();
    }

    private void WriteError(LiveDisplayContext ctx, int rowIndex, Exception exception)
    {
        _table.UpdateCell(rowIndex, 2, "[red]✖[/]");
        _table.UpdateCell(rowIndex, 3, "[red]—[/]");
        _table.UpdateCell(
            rowIndex,
            4,
            exception.Message.EscapeMarkup()
        );
        ctx.Refresh();
    }
    #endregion

    #region Validation
    public override ValidationResult Validate(CommandContext context, UpdateWinFormsIconCommandArgs args)
    {
        if (!Directory.Exists(args.WorkingDir))
            return ValidationResult.Error($"Working directory not found - {args.WorkingDir}");

        if (Path.IsPathRooted(args.IconPath))
        {
            return ValidationResult.Error($"Icon Path has to be relative");
        }

        if(args.IconPath.Split(".").Last() != "ico")
        {
            return ValidationResult.Error($"Icon Path has to have an extension of .ico");
        }

        bool isValidInjectionType = Enum.TryParse(
            typeof(WinFormsResxIconInjectorType),
            args.ResxInjectionType,
            ignoreCase: true,
            out var _
        );

        if (!isValidInjectionType)
        {
            return ValidationResult.Error($"\"{args.ResxInjectionType}\" is a not a valid WinFormsIconResxUpdationType type");
        }

        if(args.NewIcon is not null && !File.Exists(args.NewIcon))
        {
            if (args.NewIcon.Split(".").Last() != "ico")
            {
                return ValidationResult.Error($"Icon Path has to have an extension of .ico");
            }

            return ValidationResult.Error($"Logo file doesn't exist at \"{args.IconPath}\"");
        }


        return base.Validate(context, args);
    }
    #endregion
}

public class UpdateWinFormsIconCommandArgs : CommandSettings
{
    [Description("The directory of projects you want to update the logo in")]
    [CommandArgument(0, "<WorkingDir>")]
    public string WorkingDir { get; set; } = string.Empty;

    [Description("The path of the logo to be used. Has to be relative eg \"C1.ico\"")]
    [CommandOption("--icon-path")]
    [DefaultValue("C1.ico")]
    public string IconPath { get; set; } = string.Empty;

    [Description("The path of the new logo to be used. Cannot be relative")]
    [CommandOption("--new-icon")]
    public string? NewIcon { get; set; }

    [CommandOption("--resx-inject-type")]
    public string ResxInjectionType { get; set; } = nameof(WinFormsResxIconInjectorType.Base64);
}