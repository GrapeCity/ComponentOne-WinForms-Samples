// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Models;
using Microsoft.Extensions.Logging;

namespace BuildKit.Helpers;

/// <summary>
/// Service to search for files with a specific extension within a directory and its subdirectories.
/// </summary>
public class FileSearcherHelper
{
    private readonly ILogger<FileSearcherHelper> _logger;

    public FileSearcherHelper(ILogger<FileSearcherHelper> logger)
    {
        _logger = logger;
    }

    public List<FileMeta> FindAllFiles(string rootDirectory, string fileExtension = "csproj")
    {
        _logger.LogInformation("Searching for *.{FileExtension} files in {RootDirectory}", fileExtension, rootDirectory);

        if (!Directory.Exists(rootDirectory))
        {
            _logger.LogWarning("Directory not found: {RootDirectory}", rootDirectory);
            throw new DirectoryNotFoundException($"Directory not found: {rootDirectory}");
        }

        List<FileMeta> projects = Directory
            .GetFiles(rootDirectory, $"*.{fileExtension}", SearchOption.AllDirectories)
            .Select(path => new FileMeta
            {
                FilePath = path,
                ParentPath = Path.GetDirectoryName(path) ?? throw new Exception($"Could not determine directory for the given path: {path}")
            })
            .ToList();

        _logger.LogInformation("Found {Count} *.{FileExtension} files", projects.Count, fileExtension);
        return projects;
    }
}
