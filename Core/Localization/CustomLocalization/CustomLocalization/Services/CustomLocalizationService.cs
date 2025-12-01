using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Custom_Localization.Services
{
    public class CustomLocalizationService
    {
        private static readonly string[] _preSupportedCultureNames = new[]
        {
            "de", "ja", "en", "zh", "ko"
        };

        /// <summary>
        /// Returns all pre-defined supported cultures.
        /// </summary>
        public List<CultureInfo> GetPreSupportedCultures()
        {
            List<string> allCulturesCode = GetAllCulturesCode(Path.Combine(DirectoryManager.GetProjectRoot(), "CustomResources"));

            List<string> overridenCultures = _preSupportedCultureNames
                .Where(code => allCulturesCode.Contains(code) == false)
                .ToList();


            return overridenCultures
                .Select(name => new CultureInfo(name))
                .ToList();
        }

        /// <summary>
        /// Reads all unique culture codes from .resx resource files in the given folder.
        /// </summary>
        public List<CultureInfo> GetCustomCultures()
        {
            string baseFolderPath = DirectoryManager.GetProjectRoot();
            string folderPath = Path.Combine(baseFolderPath, "CustomResources");

            List<string> cultureCodes = GetCultureCodesFromResx(folderPath);

            return cultureCodes
                .Select(code =>
                {
                    try { return new CultureInfo(code); }
                    catch { return null; }
                }) 
                .Where(culture => culture != null)
                .ToList()!;
        }

        /// <summary>
        /// Reads all the overriden cultures.
        /// </summary>
        /// <returns></returns>
        public List<CultureInfo> GetOverridenCultures()
        {
            string baseFolderPath = DirectoryManager.GetProjectRoot();
            string folderPath = Path.Combine(baseFolderPath, "CustomResources");

            List<string> cultureCodes = GetOverridenCulturesFromResx(folderPath);

            return cultureCodes
                .Select(code =>
                {
                    try { return new CultureInfo(code); }
                    catch { return null; }
                })
                .Where(culture => culture != null)
                .ToList()!;
        }

        /// <summary>
        /// Sets the current thread's culture and UI culture.
        /// </summary>
        public void SetCulture(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private List<string> GetAllCulturesCode(string resxFolderPath)
        {
            if (!Directory.Exists(resxFolderPath))
                return new List<string>();
            string[] resxFiles = Directory.GetFiles(resxFolderPath, "*.*.resx", SearchOption.TopDirectoryOnly);

            return resxFiles
                .Select(file => Path.GetFileNameWithoutExtension(file))
                .Where(name => name.Contains('.'))
                .Select(name => name.Substring(name.LastIndexOf('.') + 1))
                .Distinct()
                .OrderBy(code => code)
                .ToList();
        }

        /// <summary>
        /// Extracts all unique culture codes from .resx filenames within a folder.
        /// Example: "Messages.fr.resx" → "fr"
        /// </summary>
        private List<string> GetCultureCodesFromResx(string resxFolderPath)
        {
            if (!Directory.Exists(resxFolderPath))
                return new List<string>();

            string[] resxFiles = Directory.GetFiles(resxFolderPath, "*.*.resx", SearchOption.TopDirectoryOnly);

            return resxFiles
                .Select(file => Path.GetFileNameWithoutExtension(file))
                .Where(name => name.Contains('.'))
                .Select(name => name.Substring(name.LastIndexOf('.') + 1))
                .Where(name => _preSupportedCultureNames.Contains(name) == false)
                .Distinct()
                .OrderBy(code => code)
                .ToList();
        }

        private List<string> GetOverridenCulturesFromResx(string resxFolderPath)
        {
            if (!Directory.Exists(resxFolderPath))
                return new List<string>();

            string[] resxFiles = Directory.GetFiles(resxFolderPath, "*.*.resx", SearchOption.TopDirectoryOnly);

            List<string> overridenCultures = resxFiles.Select(file => Path.GetFileNameWithoutExtension(file))
                .Where(name => name.Contains('.'))
                .Select(name => name.Substring(name.LastIndexOf('.') + 1))
                .Where(name => _preSupportedCultureNames.Contains(name) == true)
                .Distinct()
                .OrderBy(code => code)
                .ToList();

            return overridenCultures;
        }

    }
}
