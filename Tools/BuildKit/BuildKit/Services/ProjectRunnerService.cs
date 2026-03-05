// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Models;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using System.Diagnostics;

namespace BuildKit.Services;

public class ProjectRunnerService
{
    private readonly ILogger<ProjectRunnerService> _logger;
    private readonly ProcessRunner _processRunner;

    public ProjectRunnerService(
        ILogger<ProjectRunnerService> logger,
        ProcessRunner processRunner)
    {
        _logger = logger;
        _processRunner = processRunner;
    }

    /// <summary>
    /// Runs a specified command for a list of project files.
    /// Handles process start, optional waiting, window focus, fullscreen mode, and screenshot capture.
    /// Also manages cleanup of processes to prevent stray processes.
    /// </summary>
    /// <param name="command">The command to execute for each project.</param>
    /// <param name="csproj">List of project file metadata to run the command against.</param>
    /// <param name="wait">Whether to wait for the process to exit before continuing.</param>
    /// <param name="delay">Optional delay in milliseconds after running each command.</param>
    /// <param name="fullscreen">Whether to bring the application window to fullscreen.</param>
    /// <param name="maxRetires">Maximum attempts to detect a new window for focus or screenshot.</param>
    public void RunCommand(
        string command,
        FileMeta csproj,
        bool wait,
        int delay = 100,
        bool fullscreen = false,
        int maxRetires = 250)
    {
        // Track existing windows to detect new windows opened by the command
        var existingTitles = new HashSet<string>(WindowsHelper.GetAllWindowTitles());

            Process? appProcess = null;

            try
            {
                // Start the command process
                appProcess = _processRunner.RunCommand($"{command} \"{csproj.FilePath}\"", csproj.ParentPath, wait, "Run");

                // Wait for process exit if requested
                if (wait && appProcess != null)
                {                    
                    appProcess.WaitForExit();
                }

            if (!wait)
            {
                IntPtr targetWindow = WindowsHelper.DetectNewWindow(existingTitles, maxRetires);
                    if(fullscreen)
                        WindowsHelper.BringToFrontAndMaximize(targetWindow);
                    else
                        WindowsHelper.BringToFront(targetWindow);

            }

                Thread.Sleep(delay);

                _logger.LogInformation("Attempting to close application for project: {Project}", csproj.ParentPath);

                // Attempt to close the main window gracefully
                if (appProcess != null && !appProcess.HasExited)
                {
                    appProcess.CloseMainWindow();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error for project {Project}", csproj.ParentPath);
            }
            finally
            {

                // Ensure any remaining process is killed
                if (appProcess != null && !appProcess.HasExited)
                {
                    try
                    {
                        ProcessRunner.KillProcessTree(appProcess.Id, _logger);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "Failed to kill process tree for project: {Project}", csproj.ParentPath);
                    }
                }
            }    
    }
}
