using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlexGridGeminiAI.Helpers
{
    public static class DataBaseFileLocator
    {
        public static List<string?> GetDabatBaseFiles(string folderPath, bool includeSubdirs = false)
        {
            if (!Directory.Exists(folderPath))
                return new List<string?>();

            var option = includeSubdirs ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            return Directory
                .GetFiles(folderPath, "*.db", option)
                .Select(Path.GetFileName)
                .ToList();
        }
    }
}
