namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Specifies the strategy used for embedding icons into Windows Forms resource (.resx) files.
/// </summary>
public enum WinFormsResxIconInjectorType
{
    /// <summary>
    /// Embeds the icon as a Base64 encoded string in the resource file.
    /// </summary>
    Base64,
    /// <summary>
    /// Embeds the icon as a reference to an external file in the resource file.
    /// </summary>
    Reference
}
