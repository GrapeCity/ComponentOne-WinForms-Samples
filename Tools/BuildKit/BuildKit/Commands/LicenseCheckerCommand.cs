// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Services;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;

namespace BuildKit.Commands;

public sealed class LicenseCheckerCommand : Command<LicenseCheckerCommand.Settings>
{
    private readonly ILogger<LicenseCheckerCommand> _logger;
    private readonly FileSearcherHelper _fileSearcher;
    private readonly ProjectRunnerService _projectRunner;
    private readonly LicenseFileCheckerService _licenseFileCheckerService;

    public LicenseCheckerCommand(
        ILogger<LicenseCheckerCommand> logger,
        FileSearcherHelper fileSearcher,
        ProjectRunnerService projectRunner,
        LicenseFileCheckerService licenseFileCheckerService)
    {
        _logger = logger;
        _fileSearcher = fileSearcher;
        _projectRunner = projectRunner;
        _licenseFileCheckerService = licenseFileCheckerService;
    }

    public sealed class Settings : CommandSettings
    {
        [Description("Directory path to check licenses in.")]
        [CommandArgument(0, "<path>")]
        public string[]? Path { get; init; }

        public override ValidationResult Validate()
        {
            if (Path is null || Path.Length == 0)
            {
                return ValidationResult.Error("Missing required argument path");
            }

            return ValidationResult.Success();
        }
    }

    public override int Execute(
        CommandContext context,
        Settings settings,
        CancellationToken cancellationToken)
    {
        _logger.LogInformation("License Checker command started");

        try
        {
            var rootDir = settings.Path![0];

            if (string.IsNullOrWhiteSpace(rootDir))
            {
                _logger.LogError("License Checker command failed, path argument missing");
                throw new ArgumentException("Path is missing");
            }

            AnsiConsole.MarkupLine(
                "[bold green]License check started[/], scanning directory [cyan]{0}[/]",
                rootDir);

            _logger.LogInformation(
                "Searching for projects in {RootDir}",
                rootDir);

            var csProjPaths = _fileSearcher.FindAllFiles(rootDir);

            _logger.LogInformation(
                "Found {ProjectCount} projects",
                csProjPaths.Count);

            AnsiConsole.MarkupLine(
                "[bold]Found[/] [yellow]{0}[/] projects",
                csProjPaths.Count);

            if (csProjPaths.Count > 0)
            {
                AnsiConsole.MarkupLine("[bold]Projects:[/]");

                foreach (var project in csProjPaths)
                {
                    AnsiConsole.MarkupLine(
                        "  • [grey]{0}[/]",
                        project.ParentPath);
                }
            }

            AnsiConsole.MarkupLine(
                "[bold green]Checking license files[/]");

            _licenseFileCheckerService.CheckLicenseFiles(csProjPaths);

            _logger.LogInformation("License Checker command completed successfully");

            AnsiConsole.MarkupLine(
                "[bold green]License check completed successfully[/]");

            return 0;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "License Checker command failed");

            AnsiConsole.MarkupLine(
                "[bold red]License check failed[/], {0}",
                ex.Message);

            return 1;
        }
    }
}
