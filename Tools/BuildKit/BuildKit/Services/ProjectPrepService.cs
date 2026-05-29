// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Models;
using Microsoft.Extensions.Logging;

namespace BuildKit.Services;

public class ProjectPrepService
{
    private readonly ILogger<ProjectPrepService> _logger;
    private readonly ProcessRunner _processRunner;

    public ProjectPrepService(
        ILogger<ProjectPrepService> logger,
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
    /// <param name="debugName">Debug name used in logs for identifying the process.</param>
    public void RunCommand(
        string command,
        FileMeta csproj,
        bool wait,
        string debugName)
    {
        if (string.IsNullOrWhiteSpace(command))
        {
            _logger.LogError("Command cannot be null or empty");
            throw new ArgumentException("Command cannot be null or empty", nameof(command));
        }

        try
        {
            _logger.LogInformation("Running command '{Command}' for project: {Project}", command, csproj.ParentPath);
            _processRunner.RunCommand($"{command} \"{csproj.FilePath}\"", csproj.ParentPath, wait, debugName);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error for project {Project}", csproj.ParentPath);
            throw;
        }
    }
}

