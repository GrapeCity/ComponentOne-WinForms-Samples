using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XlsToJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void _btnConvert_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        var str = Convert(dlg.FileName);
                        textBox1.Text = str;
                        _buttonCopy.Enabled = true;
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Error: {0}", x.Message);
                    }
                }
            }
        }
        void _buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox1.Text);
        }

        string Convert(string fileName)
        {
            // load excel file
            var book = new C1.C1Excel.C1XLBook();
            book.Load(fileName);
            var sheet = book.Sheets[0];

            // get column names
            var columnNames = new Dictionary<int, string>();
            for (int c = 0; c < sheet.Columns.Count; c++)
            {
                var name = sheet[0, c].Value;
                if (name == null)
                {
                    break;
                }
                var colName = new StringBuilder();
                foreach (var chr in name.ToString().Trim().ToLower())
                {
                    if (char.IsLetterOrDigit(chr) || chr == '_')
                    {
                        colName.Append(chr);
                    }
                }
                columnNames[c] = colName.ToString();
            }

            // build JSON array for all items in the sheet
            var sbArr = new StringBuilder();
            for (int r = 1; r < sheet.Rows.Count; r++)
            {
                // build Json for this item
                var sbItem = new StringBuilder();
                foreach (var kn in columnNames)
                {
                    var value = sheet[r, kn.Key].Value;
                    if (value != null)
                    {
                        if (sbItem.Length > 0)
                        {
                            sbItem.Append(", ");
                        }
                        if (value is string)
                        {
                            var str = value.ToString().Trim().Replace('\"', '\'');
                            sbItem.AppendFormat("\"{0}\": \"{1}\"", kn.Value, str);
                        }
                        else
                        {
                            sbItem.AppendFormat("\"{0}\": {1}", kn.Value, value);
                        }
                    }
                }

                // empty item? exit
                if (sbItem.Length == 0)
                {
                    break;
                }

                // append this item to array
                sbArr.Append(sbArr.Length == 0 ? "[\r\n  { " : ",\r\n  { ");
                sbArr.Append(sbItem.ToString());
                sbArr.Append(" }");
            }
            if (sbArr.Length > 0)
            {
                sbArr.Append("\r\n]");
            }

            // return result
            return sbArr.ToString();
        }
    }
}
