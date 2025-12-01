using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Resources;
using System.Text;

namespace Custom_Localization.Services
{
    public class ResourceFileReader
    {

        /// <summary>
        /// Reads the currently configured resource (.resx) file and returns its contents
        /// as a <see cref="DataTable"/> containing keys, values, and comments.
        /// </summary>
        /// <returns>
        /// A <see cref="DataTable"/> containing resource key-value pairs and comments,
        /// or <c>default</c> if the file does not exist.
        /// </returns>
        public DataTable ReadResourceFiles(string directoryName, string fileName)
        {
            var projectRoot = DirectoryManager.GetProjectRoot();
            var currentResxFilePath = Path.Combine(projectRoot, directoryName, fileName);

            if (!File.Exists(currentResxFilePath))
            {
                MessageBox.Show($"Directory not found:\n{currentResxFilePath}",
                    "Missing Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return default!;
            }
            return ReadResxToDataTable(currentResxFilePath);
        }

        /// <summary>
        /// Reads the specified .resx file and converts its contents into a
        /// <see cref="DataTable"/> with columns for Key, Value, and Comment.
        /// </summary>
        /// <param name="filePath">The full path of the .resx file to read.</param>
        /// <returns>
        /// A <see cref="DataTable"/> containing all resource entries
        /// from the specified .resx file.
        /// </returns>
        private DataTable ReadResxToDataTable(string filePath)
        {
            DataTable dataTable = new DataTable("ResourceStrings");

            // Define columns
            dataTable.Columns.Add("Key", typeof(string));
            dataTable.Columns.Add("Value", typeof(string));
            dataTable.Columns.Add("Comment", typeof(string));

            using (var reader = new ResXResourceReader(filePath))
            {
                reader.UseResXDataNodes = true;

                foreach (DictionaryEntry entry in reader)
                {
                    if (entry.Value is ResXDataNode dataNode)
                    {
                        dataTable.Rows.Add(
                            dataNode.Name,
                            dataNode.GetValue((ITypeResolutionService)null)?.ToString(),
                            dataNode.Comment
                        );
                    }
                }
            }

            return dataTable;
        }
    }
}
