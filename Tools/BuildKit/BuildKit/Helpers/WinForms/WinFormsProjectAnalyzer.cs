// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using BuildKit.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Provides functionality to analyze Windows Forms projects, identifying key components such as the entry point, 
/// main form class, and associated designer and resource files.
/// </summary>
public sealed class WinFormsProjectAnalyzer
{
    #region Constants
    private const string RESX_EXTENSION = ".resx";
    private const string DESIGNER_FILE_PREFIX = ".Designer.cs";
    #endregion

    #region Private Fields
    private readonly FileSearcherHelper _fileSearcherHelper;
    private readonly MainMethodFileFinder _mainMethodFinder;
    private readonly FilesWithClassFinder _mainWindowsFileFinder;
    private readonly WinFormsMainWindowTypeFinder _mainWindowTypeFinder;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="WinFormsProjectAnalyzer"/> class.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    public WinFormsProjectAnalyzer(IServiceProvider serviceProvider)
    {
        _fileSearcherHelper = serviceProvider.GetRequiredService<FileSearcherHelper>();
        _mainMethodFinder = serviceProvider.GetRequiredKeyedService<MainMethodFileFinder>("MainMethodFileFinder");
        _mainWindowsFileFinder = serviceProvider.GetRequiredKeyedService<FilesWithClassFinder>("FilesWithClassFinder");
        _mainWindowTypeFinder = serviceProvider.GetRequiredKeyedService<WinFormsMainWindowTypeFinder>("WinForms");
    }

    /// <summary>
    /// Analyzes the specified Windows Forms project.
    /// </summary>
    /// <param name="csProjPath">The path to the .csproj file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The <see cref="WinFormsProjectMeta"/> object containing information about the project.</returns>
    public WinFormsProjectMeta Analyze(string csProjPath, CancellationToken cancellationToken)
    {
        string projectDir = Path.GetDirectoryName(csProjPath) ?? throw new Exception($"Project directory could not be determined from the csproj file path(\"{csProjPath}\"");

        List<string> allCsFilePaths = GetAllCsFilesInProjectDir(projectDir);
        cancellationToken.ThrowIfCancellationRequested();
        string entryFilePath = GetEntryFilePath(allCsFilePaths, cancellationToken);
        string mainFormClassName = GetMainFormClassName(entryFilePath, cancellationToken);
        List<string> mainFormFiles = GetMainFormFilePaths(allCsFilePaths, mainFormClassName, cancellationToken);
        string mainFormDesignerFilePath = GetMainFormDesignerFilePath(mainFormFiles, cancellationToken);
        string mainFormFilePrefix = GetMainFormFilePrefix(mainFormDesignerFilePath);
        string mainFormResxFilePath = GetMainFormResxFilePath(projectDir, mainFormFilePrefix);

        return new WinFormsProjectMeta
        {
            CsProjPath = csProjPath,
            ProjectDir = projectDir,
            EntryFilePath = entryFilePath,
            MainFormClassName = mainFormClassName,
            MainFormFilePaths = mainFormFiles,
            MainFormDesignerFilePath = mainFormDesignerFilePath,
            MainFormResxFilePath = mainFormResxFilePath
        };
    }

    #region Private Methods
    /// <summary>
    /// Gets the entry point file path of the project.
    /// </summary>
    /// <param name="csFilePaths">The list of .cs file paths in the project directory.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The entry point file path.</returns>
    /// <exception cref="Exception"></exception>
    private string GetEntryFilePath(List<string> csFilePaths, CancellationToken cancellationToken)
    {

        string? result = _mainMethodFinder.Find(csFilePaths, cancellationToken);
        if (string.IsNullOrEmpty(result))
        {
            throw new Exception("No main method found in this project");
        }
        return result!;
    }

    /// <summary>
    /// Gets all the .cs file paths in the project directory. It is only expensive at first.
    /// </summary>
    /// <returns>A list of .cs file paths</returns>
    /// <exception cref="Exception"></exception>
    private List<string> GetAllCsFilesInProjectDir(string dir)
    {
        List<FileMeta> result = _fileSearcherHelper.FindAllFiles(dir, "cs");
        if (result.Count == 0)
        {
            throw new Exception("No cs files found in this project");
        }
        return [.. result.Select(m => m.FilePath)];
    }

    /// <summary>
    /// Gets the main form class name from the entry point file.
    /// </summary>
    /// <param name="entryFilePath">The entry point file path.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The main form class name.</returns>
    /// <exception cref="Exception"></exception>
    private string GetMainFormClassName(string entryFilePath, CancellationToken cancellationToken)
    {
        string? result = _mainWindowTypeFinder.Find(entryFilePath, cancellationToken);
        if (string.IsNullOrEmpty(result))
        {
            throw new Exception("Could not determine Main window class name");
        }
        return result;
    }

    /// <summary>
    /// Gets the main form file paths from the list of .cs file paths. Finds the file that contains the main form class.
    /// </summary>
    /// <param name="csFilePaths">The list of .cs file paths.</param>
    /// <param name="mainFormClassName">The main form class name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A list of main form file paths.</returns>
    /// <exception cref="Exception"></exception>
    private List<string> GetMainFormFilePaths(List<string> csFilePaths, string mainFormClassName, CancellationToken cancellationToken)
    {
        List<string> result = _mainWindowsFileFinder.FindFiles(csFilePaths, mainFormClassName, cancellationToken);
        if (result.Count == 0)
        {
            throw new Exception($"Main Form\'s cs files were not found with the class name {mainFormClassName}");
        }
        return result;
    }

    /// <summary>
    /// Gets the main form designer file path from the list of main form file paths.
    /// </summary>
    /// <param name="mainWindowClassFiles">The list of main form file paths.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The main form designer file path.</returns>
    /// <exception cref="Exception"></exception>
    private static string GetMainFormDesignerFilePath(List<string> mainWindowClassFiles, CancellationToken cancellationToken)
    {
        string? result = mainWindowClassFiles.FirstOrDefault((f) =>
        {
            cancellationToken.ThrowIfCancellationRequested();
            return f.Contains(DESIGNER_FILE_PREFIX);
        });

        if (string.IsNullOrEmpty(result))
        {
            throw new Exception("No designer File found");
        }
        return result;
    }

    /// <summary>
    /// Gets the main form file prefix from the designer file path.
    /// </summary>
    /// <param name="designerFilePath">The designer file path.</param>
    /// <returns>The main form file prefix.</returns>
    /// <exception cref="Exception"></exception>
    private static string GetMainFormFilePrefix(string designerFilePath)
    {
        string? result = Path.GetFileName(designerFilePath).Split(".").FirstOrDefault();
        if (string.IsNullOrEmpty(result))
        {
            throw new Exception("Could not get file name");
        }
        return result;
    }

    /// <summary>
    /// Gets the main form resx file path from the project directory and the main form file prefix.
    /// </summary>
    /// <param name="projectDir">The project directory.</param>
    /// <param name="mainFormFilePrefix">The main form file prefix.</param>
    /// <returns>The main form resx file path.</returns>
    /// <exception cref="Exception"></exception>
    private static string GetMainFormResxFilePath(string projectDir, string mainFormFilePrefix)
    {
        string filePath = Path.Combine(projectDir, mainFormFilePrefix + RESX_EXTENSION);
        if (!File.Exists(filePath))
        {
            throw new Exception("Could not find resx file");
        }

        return filePath;
    }
    #endregion
}