using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Localization.Services
{
    public class DirectoryManager
    {
        public static string GetProjectRoot()
        {
            //AppDomain.CurrentDomain.BaseDirectory gives Root/bin/net8.0/debug/ and the root is the 3 levels before, we loop 3 times.
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo? dir = new DirectoryInfo(baseDir);

            for (int i = 0; i < 3; i++)
            {
                dir = dir?.Parent;
                if (dir == null)
                    return string.Empty;
            }

            return dir.FullName;
        }
    }
}
