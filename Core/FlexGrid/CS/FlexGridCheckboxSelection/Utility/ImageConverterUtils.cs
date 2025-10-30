namespace FlexGridCheckboxSelection.Utility
{
    /// <summary>
    /// Provides utilities for converting Base64-encoded strings into <see cref="Image"/> objects.
    /// </summary>
    public static class ImageConverterUtils
    {
        /// <summary>
        /// Converts a Base64-encoded string into an Image object.
        /// </summary>
        /// <param name="base64String">The Base64-encoded image string.</param>
        /// <returns>An Image object.</returns>
        /// 
        #region Public Methods
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(ms, true);
            }
        } 
        #endregion
    }
}
