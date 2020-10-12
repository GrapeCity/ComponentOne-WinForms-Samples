using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitCustomDialogs();
        }

        /// <summary>
        /// Initializes custom forms for using in the control
        /// </summary>
        private void InitCustomDialogs()
        {
            editor.CustomDialogs.BookmarkDialog = new BookmarkEditorForm();
            editor.CustomDialogs.FindReplaceDialog = new FindReplaceForm();
            editor.CustomDialogs.FormattingDialog = new FormattingForm();
            editor.CustomDialogs.HyperlinkDialog = new HyperlinkEditorForm();
            editor.CustomDialogs.ImageDialog = new ImageEditorForm();
            editor.CustomDialogs.FlashMovieDialog = new ObjectEditorForm();
            editor.CustomDialogs.TableCellDialog = new CellEditorForm();
            editor.CustomDialogs.TableColumnDialog = new ColumnEditorForm();
            editor.CustomDialogs.TableDialog = new TableEditorForm();
            editor.CustomDialogs.TableRowDialog = new RowEditorForm();
            editor.CustomDialogs.MessageBox = new ShowMessageBox();
        }

        /// <summary>
        /// Displays a dialog of the appropriate type
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">A <see cref="ToolStripItemClickedEventArgs"/> that contains the event data.</param>
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsBookmark)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Bookmark);
            else if (e.ClickedItem == tsFind)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Find);
            else if (e.ClickedItem == tsFormatting)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Format);
            else if (e.ClickedItem == tsHyperlink)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Hyperlink);
            else if (e.ClickedItem == tsPicture)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Image);
            else if (e.ClickedItem == tsTable)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.NewTable);
            else if (e.ClickedItem == this.tsFlash)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.FlashMovie);
            else if (e.ClickedItem == tsReplace)
                editor.ShowDialog(C1.Win.C1Editor.DialogType.Replace);
        }
    }
}