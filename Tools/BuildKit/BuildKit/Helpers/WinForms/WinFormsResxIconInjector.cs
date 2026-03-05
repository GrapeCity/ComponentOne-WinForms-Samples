using BuildKit.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Provides functionality to inject icon resources into Windows Forms .resx files by converting images 
/// to Base64 encoded strings and updating the underlying XML structure.
/// </summary>
public class WinFormsResxIconInjector : IResxIconInjector
{
    #region Fields
    private ImageToBase64Convertor _imageConvertor;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="WinFormsResxIconInjector"/> class.
    /// </summary>
    /// <param name="serviceProvider">The service provider to use for dependency injection.</param>
    public WinFormsResxIconInjector(IServiceProvider serviceProvider)
    {
        _imageConvertor = serviceProvider.GetRequiredKeyedService<ImageToBase64Convertor>("ImageToBase64Convertor");
    }

    #region Constants
    #region Tag and attribute names
    private const string ICON_ELEMENT_NAME = "$this.Icon";
    private const string DATA_TAG_NAME = "data";
    private const string ASSEMBLY_TAG_NAME = "assembly";
    private const string VALUE_TAG_NAME = "value";
    private const string ALIAS_ATTR_KEY = "alias";
    private const string NAME_ATTR_KEY = "name";
    private const string TYPE_ATTR_KEY = "type";
    private const string MIMETYPE_ATTR_KEY = "mimetype";
    #endregion

    #region Values
    private const string RESX_FILE_REF_TYPE = "System.Resources.ResXFileRef";
    private const string BASE_64_MIME_TYPE = "application/x-microsoft.net.object.bytearray.base64";
    private static readonly string[] ASSEMBLY_ALIASES = ["System.Drawing", "System.Windows.Forms"];
    #endregion

    #region System.Drawing.Icon
    private const string SYSTEM_DRAWING_ICON_TYPE = "System.Drawing.Icon";
    private const string SYSTEM_DRAWING_ASSEMBLY_NAME = "System.Drawing";
    private const string SYSTEM_DRAWING_VERSION = "4.0.0.0";
    private const string SYSTEM_DRAWING_PUBLIC_KEY_TOKEN = "b03f5f7f11d50a3a";
    private const string SYSTEM_DRAWING_FULL_NAME = $"{SYSTEM_DRAWING_ASSEMBLY_NAME}, Version={SYSTEM_DRAWING_VERSION}, Culture=neutral, PublicKeyToken={SYSTEM_DRAWING_PUBLIC_KEY_TOKEN}";
    #endregion

    #region System.Windows.Forms
    private const string WIN_FORMS_ASSEMBLY_NAME = "System.Windows.Forms";
    private const string WIN_FORMS_VERSION = "4.0.0.0";
    private const string WIN_FORMS_PUBLIC_KEY_TOKEN = "b77a5c561934e089";
    private const string WIN_FORMS_FULL_NAME = $"{WIN_FORMS_ASSEMBLY_NAME}, Version={WIN_FORMS_VERSION}, Culture=neutral, PublicKeyToken={WIN_FORMS_PUBLIC_KEY_TOKEN}";
    #endregion

    #endregion

    #region Public Methods
    public void Inject(string resxFilePath, string injectionType, string iconPath, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(resxFilePath);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(iconPath);

        var injectorType = Enum.Parse<WinFormsResxIconInjectorType>(injectionType);

        if (!File.Exists(resxFilePath))
            throw new FileNotFoundException($"Resx File not found at {resxFilePath}");

        XDocument resxDoc = XDocument.Load(resxFilePath);

        // check if root exists
        XElement? root = resxDoc.Root;
        if (root is null)
            throw new Exception($"Resx file(\"{resxFilePath}\") doesn't contain any root element.");

        FindAndRemoveIconElements(root, cancellationToken);
        FindAndRemoveAliasElements(root, cancellationToken);

        XElement[] newElems = injectorType switch
        {
            WinFormsResxIconInjectorType.Base64 => GetBase64IconElements(iconPath, cancellationToken),
            WinFormsResxIconInjectorType.Reference => GetReferencedIconElements(iconPath),
            _ => throw new NotImplementedException("Cannot handle IconResxInjectionType other than Base64 and Reference")
        };
        root.Add(newElems);

        resxDoc.Save(resxFilePath);
    }
    #endregion

    #region Icon File Related private methods

    #endregion

    #region Xml related private methods
    private void FindAndRemoveIconElements(XElement root, CancellationToken cancellationToken)
    {
        foreach (XElement element in root.Elements())
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (element.Name == DATA_TAG_NAME && element.Attribute(NAME_ATTR_KEY)?.Value == ICON_ELEMENT_NAME)
            {
                element.Remove();
            }
        }
    }

    private void FindAndRemoveAliasElements(XElement root, CancellationToken cancellationToken)
    {
        foreach (XElement element in root.Elements())
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (element.Name == ASSEMBLY_TAG_NAME && ASSEMBLY_ALIASES.Any((a) => element.Attribute(ALIAS_ATTR_KEY)?.Value == a))
            {
                element.Remove();
            }
        }
    }

    // probably take this to other class
    private XElement[] GetBase64IconElements(string iconPath, CancellationToken cancellationToken)
    {
        // <assembly alias = "System.Drawing" name="System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"/>
        XElement assemblyAlias = new(ASSEMBLY_TAG_NAME);
        assemblyAlias.SetAttributeValue(ALIAS_ATTR_KEY, SYSTEM_DRAWING_ASSEMBLY_NAME);
        assemblyAlias.SetAttributeValue(NAME_ATTR_KEY, SYSTEM_DRAWING_FULL_NAME);

        // <data name="<IconElemName>" type="System.Drawing.Icon, System.Drawing" "mimetype"="application/x-microsoft.net.object.bytearray.base64">
        //  <value>
        //      <Chunked Base64 Icon>
        //  </value>
        // </data>
        XElement newData = new(DATA_TAG_NAME);
        newData.SetAttributeValue(NAME_ATTR_KEY, ICON_ELEMENT_NAME);
        newData.SetAttributeValue(TYPE_ATTR_KEY, $"{SYSTEM_DRAWING_ICON_TYPE}, {SYSTEM_DRAWING_ASSEMBLY_NAME}");
        newData.SetAttributeValue(MIMETYPE_ATTR_KEY, BASE_64_MIME_TYPE);

        XElement newValue = new(VALUE_TAG_NAME);
        var chunkedImage = _imageConvertor.GetChunkedBase64Icon(iconPath, cancellationToken);
        newValue.SetValue(chunkedImage);

        newData.Add(newValue);

        return [assemblyAlias, newData];
    }

    // probably take this to other class
    private XElement[] GetReferencedIconElements(string iconPath)
    {
        // <assembly alias = "System.Windows.Forms" name = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
        XElement assemblyAlias = new(ASSEMBLY_TAG_NAME);
        assemblyAlias.SetAttributeValue(ALIAS_ATTR_KEY, WIN_FORMS_ASSEMBLY_NAME);
        assemblyAlias.SetAttributeValue(NAME_ATTR_KEY, WIN_FORMS_FULL_NAME);

        // <data name = "$this.Icon" type = "System.Resources.ResXFileRef, System.Windows.Forms" >
        //   <value> C1.ico; System.Drawing.Icon, System.Drawing, Version = 4.0.0.0, Culture = neutral, PublicKeyToken = b03f5f7f11d50a3a </value>
        // </data>
        XElement newData = new(DATA_TAG_NAME);
        newData.SetAttributeValue(NAME_ATTR_KEY, ICON_ELEMENT_NAME);
        newData.SetAttributeValue(TYPE_ATTR_KEY, $"{RESX_FILE_REF_TYPE}, {WIN_FORMS_ASSEMBLY_NAME}");

        XElement newValue = new(VALUE_TAG_NAME);
        newValue.SetValue($"{Path.GetRelativePath(Path.GetDirectoryName(iconPath)!, iconPath)}; {SYSTEM_DRAWING_ICON_TYPE}, {SYSTEM_DRAWING_FULL_NAME}");
        newData.Add(newValue);

        return [assemblyAlias, newData];
    }
    #endregion
}