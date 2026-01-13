namespace BuildKit.Helpers;

/// <summary>
/// Injects an icon into a .resx file.
/// </summary>
internal interface IResxIconInjector
{
    /// <summary>
    /// Injects an icon into a .resx file.
    /// </summary>
    /// <param name="resxFilePath">The path to the .resx file.</param>
    /// <param name="injectionType">The type of injection.</param>
    /// <param name="iconPath">The path to the icon file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public void Inject(string resxFilePath, string injectionType, string iconPath, CancellationToken cancellationToken);
}