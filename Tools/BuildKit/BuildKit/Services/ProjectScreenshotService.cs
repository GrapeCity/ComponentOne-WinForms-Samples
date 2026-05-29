// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Helpers;
using BuildKit.Models;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace BuildKit.Services;

public class ProjectScreenshotService
{
    private readonly ILogger<ProjectScreenshotService> _logger;
    private readonly ProcessRunner _processRunner;

    public ProjectScreenshotService(
        ILogger<ProjectScreenshotService> logger,
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
    /// <param name="csproj">project file metadata to run the command against.</param>
    /// <param name="wait">Whether to wait for the process to exit before continuing.</param>
    /// <param name="delay">Optional delay in milliseconds after running each command.</param>
    /// <param name="fullscreen">Whether to bring the application window to fullscreen.</param>
    /// <param name="maxRetires">Maximum attempts to detect a new window for focus or screenshot.</param>
    /// <param name="fileName">File name to save the screenshot, if enabled.</param>
    public void RunCommand(
        string command,
        FileMeta csproj,
        bool wait,
        int delay = 100,
        bool fullscreen = false,
        int maxRetires = 250,
        string fileName = "screenshot")
    {
        if (string.IsNullOrWhiteSpace(command))
        {
            _logger.LogError("Command cannot be null or empty");
            throw new ArgumentException("Command cannot be null or empty", nameof(command));
        }

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

                    string screenshotPath = Path.Combine(csproj.ParentPath, $"{fileName}.png");
                    CaptureWindow(targetWindow, screenshotPath);
                }

           
                Thread.Sleep(delay);

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

    /// <summary>
    /// Captures a screenshot of the specified window and saves it as a PNG file.
    /// Uses the Win32 PrintWindow API to capture the window contents.
    /// </summary>
    /// <param name="hWnd">Handle of the window to capture.</param>
    /// <param name="savePath">Full file path to save the screenshot PNG.</param>
    public void CaptureWindow(IntPtr hWnd, string savePath)
    {
        if (hWnd == IntPtr.Zero)
        {
            _logger.LogWarning("Cannot capture screenshot: window handle is zero");
            return;
        }

        try
        {
            // Get the window rectangle
            WindowsHelper.GetWindowRect(hWnd, out var rect);

            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;

            if (width <= 0 || height <= 0)
            {
                _logger.LogWarning("Window dimensions invalid: width={Width}, height={Height}", width, height);
                return;
            }

#pragma warning disable CA1416 // Validate platform compatibility
            using var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
#pragma warning restore CA1416
#pragma warning disable CA1416
            using var graphics = Graphics.FromImage(bitmap);
#pragma warning restore CA1416

#pragma warning disable CA1416
            IntPtr hdc = graphics.GetHdc();
#pragma warning restore CA1416

            // Capture window contents using PrintWindow API
            bool success = WindowsHelper.PrintWindow(hWnd, hdc, 0);

#pragma warning disable CA1416
            graphics.ReleaseHdc(hdc);
#pragma warning restore CA1416

            if (!success)
            {
                _logger.LogError("PrintWindow API failed for handle {Handle}", hWnd);
                return;
            }

#pragma warning disable CA1416
            bitmap.Save(savePath, ImageFormat.Png);
#pragma warning restore CA1416

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to capture screenshot for window handle {Handle}", hWnd);
        }
    }
}
