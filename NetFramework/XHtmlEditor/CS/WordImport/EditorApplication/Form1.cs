using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1Editor;
using C1.Win.C1Editor.Import;
using C1.Win.C1Editor.ToolStrips;

namespace EditorApplication
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			c1Editor1.LoadWord("testrtffile.rtf");
			Text = Path.GetFullPath("testrtffile.rtf");
			SetupOpenCommand();

		}

		void SetupOpenCommand()
		{
			c1EditorToolStripMain1.Items[0].Visible = false;
			c1EditorToolStripMain1.Items[1].Visible = false;
			var item = new ToolStripButton("", EditorApplication.Properties.Resources.word);
			item.ToolTipText = "Open Word Document";
			item.Click += OpenWordDocument;
			c1EditorToolStripMain1.Items.Insert(0, item);
		}

		private void OpenWordDocument(object sender, EventArgs e)
		{
			var d = new OpenFileDialog
			{
				DefaultExt = ".docx",
				InitialDirectory = Environment.CurrentDirectory,
				Multiselect = false,
				Filter =
					"Rich Text Format (*.rtf)|*.rtf|Office Word (*.doc)|*.doc|Office Open Xml (*.docx)|*.docx|Open Document (*.odt)|*.odt"
			};
			
			d.FilterIndex = 2;
			if (d.ShowDialog() == DialogResult.OK)
			{
				Cursor = Cursors.WaitCursor;
				c1Editor1.LoadWord(d.FileName);
				Text = Path.GetFullPath(d.FileName);
				Cursor = Cursors.Default;
			}
		}
	}
}

