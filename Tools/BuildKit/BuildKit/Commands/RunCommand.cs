// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Models;
using BuildKit.Services;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace BuildKit.Commands;

public sealed class RunCommand : Command<RunCommand.Settings>
{
    private readonly ILogger<RunCommand> _logger;
    private readonly CleanCommand _cleanCommand;
    private readonly RestoreCommand _restoreCommand;
    private readonly BuildCommand _buildCommand;
    private readonly FileSearcherHelper _fileSearcher;
    private readonly ProjectRunnerService _projectRunner;
    private readonly ProjectPrepService _projectPrepService;
    public RunCommand(
        ILogger<RunCommand> logger,
        CleanCommand cleanCommand,
        RestoreCommand restoreCommand,
        BuildCommand buildCommand,
        FileSearcherHelper fileSearcher,
        ProjectRunnerService projectRunner,
        ProjectPrepService projectPrepService)
    {
        _logger = logger;
        _cleanCommand = cleanCommand;
        _restoreCommand = restoreCommand;
        _buildCommand = buildCommand;
        _fileSearcher = fileSearcher;
        _projectRunner = projectRunner;
        _projectPrepService = projectPrepService;
    }

    public sealed class Settings : CommandSettings
    {
        [Description("Directory path")]
        [CommandArgument(0, "<path>")]
        public string[]? Path { get; init; }

        [Description("Delay in milliseconds before executing the project command.")]
        [CommandOption("--delay")]
        [DefaultValue(3000)]
        public int Delay { get; init; } = 3000;

        [Description("Run the project in fullscreen mode")]
        [CommandOption("--fullscreen")]
        [DefaultValue(false)]
        public bool FullScreen { get; init; }

        [Description("Skip clean step")]
        [CommandOption("--no-clean")]
        [DefaultValue(false)]
        public bool NoClean { get; init; }

        [Description("Skip restore step")]
        [CommandOption("--no-restore")]
        [DefaultValue(false)]
        public bool NoRestore { get; init; }

        [Description("Skip build step")]
        [CommandOption("--no-build")]
        [DefaultValue(false)]
        public bool NoBuild { get; init; }

        [Description("Maximum windows retry")]
        [CommandOption("--win-max-retry")]
        [DefaultValue(250)]
        public int MaxRetry { get; init; }

        [Description("Keep Window alive after running")]
        [CommandOption("--keep-alive")]
        [DefaultValue(false)]
        public bool KeepAlive { get; init; }

        [Description("Filename of screenshot image (Only apply when screenshot)")]
        [CommandOption("--filename")]
        [DefaultValue("screenshot")]
        public string? FileName { get; init; }

        public bool Screenshot { get; set; }

        public override ValidationResult Validate()
        {
            if (Path is null || Path.Length == 0)
            {
                return ValidationResult.Error("Missing required argument path of the directory");
            }

            if (!Directory.Exists(Path[0]))
            {
                return ValidationResult.Error(
                    $"Working directory not found, {Path[0]}"
                );
            }
            return ValidationResult.Success();
        }
    }

    public override int Execute(
    CommandContext context,
    Settings settings,
    CancellationToken cancellationToken)
{
    _logger.LogInformation("Run command started");

    try
    {
        var rootDir = settings.Path![0];
        var csProjPaths = _fileSearcher.FindAllFiles(rootDir);

        var table = new Table();
        table.Border = TableBorder.Rounded;

        table.AddColumn("[green]Project[/]");
        table.AddColumn("[blue]Clean[/]");
        table.AddColumn("[blue]Restore[/]");
        table.AddColumn("[blue]Build[/]");
        table.AddColumn("[blue]Run[/]");

        // Seed rows
        foreach (var csproj in csProjPaths)
        {
            table.AddRow(
                csproj.FilePath,
                "[grey]Pending[/]",
                "[grey]Pending[/]",
                "[grey]Pending[/]",
                "[grey]Pending[/]"
            );
        }

        AnsiConsole.Live(table)
            .Start(ctx =>
            {
            for (int i = 0; i < csProjPaths.Count; i++)
            {
                var csproj = csProjPaths[i];

                // CLEAN
                table.UpdateCell(i, 1, "[yellow]Cleaning[/]");
                ctx.Refresh();

                try
                {
                    _projectPrepService.RunCommand(
                        command: "dotnet clean",
                        csproj: csproj,
                        wait: true,
                        debugName: "Clean"
                    );

                    table.UpdateCell(i, 1, "[green]Success[/]");
                }
                catch
                {
                    table.UpdateCell(i, 1, "[red]Failed[/]");
                    ctx.Refresh();
                    continue;
                }
                ctx.Refresh();

                // RESTORE
                table.UpdateCell(i, 2, "[yellow]Restoring[/]");
                ctx.Refresh();

                try
                {
                    _projectPrepService.RunCommand(
                        command: "dotnet restore",
                        csproj: csproj,
                        wait: true,
                        debugName: "Restore"
                    );

                    table.UpdateCell(i, 2, "[green]Success[/]");
                }
                catch
                {
                    table.UpdateCell(i, 2, "[red]Failed[/]");
                    ctx.Refresh();
                    continue;
                }
                ctx.Refresh();

                // BUILD
                table.UpdateCell(i, 3, "[yellow]Building[/]");
                ctx.Refresh();

                try
                {
                    _projectPrepService.RunCommand(
                        command: "msbuild",
                        csproj: csproj,
                        wait: true,
                        debugName: "Build"
                    );

                    table.UpdateCell(i, 3, "[green]Success[/]");
                }
                catch
                {
                    table.UpdateCell(i, 3, "[red]Failed[/]");
                    ctx.Refresh();
                    continue;
                }
                ctx.Refresh();

                // RUN
                table.UpdateCell(i, 4, "[yellow]Running[/]");
                ctx.Refresh();

                try
                {
                    _projectRunner.RunCommand(
                        command: "dotnet run",
                        csproj: csproj,
                        wait: settings.KeepAlive,
                        delay: settings.Delay,
                        fullscreen: settings.FullScreen,
                        maxRetires: settings.MaxRetry
                    );

                    table.UpdateCell(i, 4, "[green]Completed[/]");
                }
                catch
                {
                    table.UpdateCell(i, 4, "[red]Failed[/]");
                }

                ctx.Refresh();
            }
        });

        return 0;
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Run command failed");

        AnsiConsole.MarkupLine(
            "[bold red]Run failed[/], {0}",
            ex.Message);

        return 1;
    }
}

}
