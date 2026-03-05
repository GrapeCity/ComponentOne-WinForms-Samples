// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Commands;
using BuildKit.Helpers;
using BuildKit.Helpers.WinForms;
using BuildKit.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Spectre.Console.Cli;
using Spectre.Console.Cli.Extensions.DependencyInjection;

namespace BuildKit;

public static class Program
{
    public static void Main(string[] args)
    {

        var services = new ServiceCollection();
        services.AddSingleton<FileSearcherHelper>();

        services.AddKeyedScoped<MainMethodFileFinder>("MainMethodFileFinder");
        services.AddKeyedScoped<UpdateWinFormsIconService>("WinForms");
        services.AddKeyedScoped<WinFormsProjectAnalyzer>("WinForms");
        services.AddKeyedScoped<WinFormsDesignerIconInjector>("WinForms");
        services.AddKeyedScoped<WinFormsResxIconInjector>("WinForms");

        services.AddKeyedScoped<WinFormsMainWindowTypeFinder>("WinForms");
        services.AddKeyedScoped<FilesWithClassFinder>("FilesWithClassFinder");
        services.AddScoped<SyntaxRootManager>();
        services.AddKeyedScoped<ImageToBase64Convertor>("ImageToBase64Convertor");

        services.AddSingleton<ProcessRunner>();
        services.AddSingleton<ProjectRunnerService>();
        services.AddSingleton<LicenseFileCheckerService>();
        services.AddSingleton<ProjectPrepService>();
        services.AddSingleton<ProjectScreenshotService>();
        services.AddLogging(builder =>
        {
            builder.ClearProviders();
            //builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Information);
        });
        var registrar = new DependencyInjectionRegistrar(services);

        var app = new CommandApp(registrar);
        app.Configure(config =>
        {
            config.SetApplicationName("buildkit");
            config.SetApplicationVersion(typeof(Program).Assembly.GetName().Version?.ToString() ?? "unknown");

            config.AddCommand<CleanCommand>("clean")
             .WithDescription("Cleans the build artifacts and temporary files of the specified project.");

            config.AddCommand<LicenseCheckerCommand>("license-check")
             .WithDescription("Check whether license file ir present or not");

            config.AddCommand<BuildCommand>("build")
             .WithDescription("Builds the specified project, compiling source code into executable binaries.");

            config.AddCommand<RestoreCommand>("restore")
             .WithDescription("Restores all NuGet packages and project dependencies.");

            config.AddCommand<RunCommand>("run")
             .WithDescription("Runs the specified project with optional parameters such as delay and fullscreen mode.");

            config.AddCommand<ScreenshotCommand>("screenshot")
             .WithDescription("Runs the specified project with optional parameters such as delay and fullscreen mode.");

            config.AddBranch("update-icon", updateIcon =>
            {
                updateIcon.SetDescription("Updates or replaces the application’s icon file");
                updateIcon.AddCommand<UpdateWinFormsIconCommand>("winforms");
            });
        });
        app.Run(args);
    }
}