using BuildKit.Helpers.WinForms;
using BuildKit.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BuildKit.Services;

/// <summary>
/// Updates the icon of a WinForms project.
/// </summary>
public class UpdateWinFormsIconService(IServiceScopeFactory serviceScopeFactory)
{
    /// <summary>
    /// Updates the icon of a WinForms project.
    /// </summary>
    /// <param name="projectMeta">The project metadata.</param>
    /// <param name="iconPath">The path to the icon file.</param>
    /// <param name="injectorType">The type of injector to use.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public void Run(WinFormsProjectMeta projectMeta, string iconPath, string injectorType, CancellationToken cancellationToken)
    {
        InjectIconInResx(projectMeta, iconPath, injectorType, cancellationToken);
        if (cancellationToken.IsCancellationRequested) return;
        InjectIconInDesignerFile(projectMeta, cancellationToken);
    }

    #region Private methods
    private void InjectIconInResx(WinFormsProjectMeta projectMeta, string iconPath, string injectorType, CancellationToken cancellationToken)
    {
        ResxIconInjector.Inject(projectMeta.MainFormResxFilePath, injectorType, GetFullIconPath(projectMeta, iconPath), cancellationToken);
    }

    private static string GetFullIconPath(WinFormsProjectMeta projectMeta, string iconPath)
    {
        if (Path.IsPathRooted(iconPath)) return iconPath;

        return Path.Combine(projectMeta.ProjectDir, iconPath);
    }

    private void InjectIconInDesignerFile(WinFormsProjectMeta projectMeta, CancellationToken cancellationToken)
    {
        DesignerIconInjector.Inject(projectMeta.MainFormDesignerFilePath, projectMeta.MainFormClassName, cancellationToken);
    }
    #endregion

    #region Service Scope and Services
    private readonly IServiceScope serviceScope = serviceScopeFactory.CreateScope();

    private WinFormsResxIconInjector ResxIconInjector => serviceScope.ServiceProvider
        .GetRequiredKeyedService<WinFormsResxIconInjector>("WinForms");

    private WinFormsDesignerIconInjector DesignerIconInjector => serviceScope.ServiceProvider
        .GetRequiredKeyedService<WinFormsDesignerIconInjector>("WinForms");
    #endregion
}