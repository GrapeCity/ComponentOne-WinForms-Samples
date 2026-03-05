// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System.Text;

namespace BuildKit.Helpers;

/// <summary>
/// Converts an image to a base64 string.
/// </summary>
public class ImageToBase64Convertor
{
    #region Fields
    private readonly int _chunkSize;
    #endregion

    #region Constructors
    public ImageToBase64Convertor(int chunkSize = 80)
    {
        _chunkSize = chunkSize;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Converts an image file to a base64 string.
    /// </summary>
    /// <param name="iconPath">The path to the image file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A base64 string representation of the image.</returns>
    public static string ImageFileToBase64(string iconPath, CancellationToken cancellationToken)
    {
        byte[] imageBytes = File.ReadAllBytesAsync(iconPath, cancellationToken).GetAwaiter().GetResult();

        return Convert.ToBase64String(imageBytes);
    }

    /// <summary>
    /// Gets a chunked base64 icon.
    /// </summary>
    /// <param name="iconPath">The path to the icon file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A chunked base64 icon.</returns>
    public string GetChunkedBase64Icon(string iconPath, CancellationToken cancellationToken)
    {
        var chunkedStrBuilder = new StringBuilder();
        var base64Icon = ImageFileToBase64(iconPath, cancellationToken);
        var base64Len = base64Icon.Length;
        for (int i = 0; i < base64Len; i += _chunkSize)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (i + _chunkSize > base64Len)
            {
                chunkedStrBuilder.AppendLine($"        {base64Icon.AsSpan(i, base64Len % _chunkSize)}");
            }
            else
            {
                chunkedStrBuilder.AppendLine($"        {base64Icon.AsSpan(i, _chunkSize)}");
            }
        }
        return chunkedStrBuilder.ToString();
    }
    #endregion
}