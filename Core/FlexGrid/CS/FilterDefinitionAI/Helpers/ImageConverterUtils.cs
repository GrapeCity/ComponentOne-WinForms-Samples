// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Helpers
{
    public static class ImageConverterUtils
    {
        /// <summary>
        /// Converts a Base64-encoded string into an Image object.
        /// </summary>
        /// <param name="base64String">The Base64-encoded image string.</param>
        /// <returns>An Image object.</returns>
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                return Image.FromStream(ms, true);
            }
        }
    }
}
