// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.
 
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Spectre.Console;
 
namespace BuildKit.Services;
 
public class ProcessRunner
{
    private readonly ILogger<ProcessRunner> _logger;
 
    public ProcessRunner(ILogger<ProcessRunner> logger)
    {
        _logger = logger;
    }
    /// <summary>
    /// Runs a shell command in the specified working directory.
    /// Optionally waits for completion or returns immediately.
    /// Logs process start, completion, and errors.
    /// </summary>
    public Process RunCommand(
        string command,
        string workingDirectory,
        bool wait = true,
        string debugName = "Subprocess")
    {
        _logger.LogInformation("Starting process {DebugName} [{Command}] in {WorkingDirectory}", debugName, command, workingDirectory);
        try
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c {command}",
                WorkingDirectory = workingDirectory,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
 
            Process process = new Process { StartInfo = psi };
 
            process.Start();
 
            if (!wait)
            {
                _logger.LogInformation("{DebugName}[{Command}] started with PID: {PID}", debugName, command, process.Id);
                return process;
            }
 
            string stdout = process.StandardOutput.ReadToEnd();
            string stderr = process.StandardError.ReadToEnd();
 
            process.WaitForExit();
 
            if (process.ExitCode != 0)
            {
                if (string.IsNullOrEmpty(stderr))
                {
                    if (string.IsNullOrEmpty(stdout))
                    {
                        throw new Exception($"Exited with ExitCode {process.ExitCode}");
                    }
 
                    throw new Exception($"An Error occured and this was the output:\n{stdout}");
                }
 
                throw new Exception($"Exited with error message {stderr}");
            } 
 
            _logger.LogInformation("{DebugName}[{Command}] completed successfully", debugName, command);
 
            return process;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{DebugName}[{Command}] error occurred", debugName, command);
            throw;
        }
    }
 
    public static void KillProcessTree(int pid, ILogger? logger = null)
    {
        try
        {
            var process = Process.GetProcessById(pid);
            process.Kill(true);
            process.WaitForExit(3000);
            logger?.LogInformation("Killed process tree with PID: {PID}", pid);
        }
        catch (ArgumentException)
        {
            logger?.LogWarning("Process with PID {PID} already exited", pid);
        }
        catch (Exception ex)
        {
            logger?.LogError(ex, "Failed to kill process tree with PID: {PID}", pid);
        }
    }
}