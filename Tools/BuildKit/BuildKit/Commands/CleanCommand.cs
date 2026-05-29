// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Models;
using BuildKit.Services;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace BuildKit.Commands;

public sealed class CleanCommand : Command<CleanCommand.Settings>
{
    private readonly ILogger<CleanCommand> _logger;
    private readonly FileSearcherHelper _fileSearcher;
    private readonly ProjectPrepService _projectPrepService;
    public CleanCommand(
        ILogger<CleanCommand> logger,
        FileSearcherHelper fileSearcher,
        ProjectPrepService projectPrepService)
    {
        _logger = logger;
        _fileSearcher = fileSearcher;
        _projectPrepService = projectPrepService;
    }

    public sealed class Settings : CommandSettings
    {
        [Description("Directory path to clean.")]
        [CommandArgument(0, "<path>")]
        public string[]? Path { get; init; }

        public override ValidationResult Validate()
        {
            if (Path is null || Path.Length == 0)
            {
                return ValidationResult.Error("Missing required argument path");
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
    _logger.LogInformation("Clean command started");

    try
    {
        var rootDir = settings.Path![0];
        var csProjPaths = _fileSearcher.FindAllFiles(rootDir);

        var table = new Table();
        table.Border = TableBorder.Rounded;

        table.AddColumn("[yellow]#[/]");
        table.AddColumn("[green]Project[/]");
        table.AddColumn("[blue]Status[/]");

        // Initial rows
        for (int i = 0; i < csProjPaths.Count; i++)
        {
            table.AddRow(
                (i + 1).ToString(),
                csProjPaths[i].FilePath,
                "[grey]Pending[/]"
            );
        }

        AnsiConsole.Live(table)
            .Start(ctx =>
            {
                for (int i = 0; i < csProjPaths.Count; i++)
                {
                    var csproj = csProjPaths[i];

                    // Mark as cleaning
                    table.UpdateCell(i, 2, "[yellow]Cleaning[/]");
                    ctx.Refresh();

                    try
                    {
                        _projectPrepService.RunCommand(
                            command: "dotnet clean",
                            csproj: csproj,
                            wait: true,
                            debugName: "Clean"
                        );

                        table.UpdateCell(i, 2, "[green]Success[/]");
                    }
                    catch
                    {
                        table.UpdateCell(i, 2, "[red]Failed[/]");
                    }

                    ctx.Refresh();
                }
            });

        return 0;
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Clean command failed");

        AnsiConsole.MarkupLine(
            "[bold red]Clean failed[/], {0}",
            ex.Message);

        return 1;
    }
}

}
