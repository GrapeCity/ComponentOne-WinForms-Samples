using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.Command;

namespace MdiTabs
{
	/// <summary>
	/// A single windowed editor
	/// </summary>
	public class Editor
	{
        // owner
        private MainForm m_mainForm;
        // the textbox used for the actual editing
        private RichTextBox m_textbox;
        // the file name
        private string m_filename;
        // the dirty flag
        private bool m_dirty = false;
        // misc
        private const string nofile = "<new file>";

		public Editor(MainForm mainForm, string fileName)
		{
            m_mainForm = mainForm;
            // text editor
			m_textbox = new RichTextBox();
            m_textbox.Dock = DockStyle.Fill;
            m_textbox.BackColor = Color.White;
            m_textbox.TextChanged += new EventHandler(TextChanged);
            if (fileName == null || fileName.Length == 0)
            {
                m_filename = nofile;
                m_mainForm.Log("New file opened.");
            }
            else
            {
                bool newFile = false;
                try
                {
                    m_textbox.LoadFile(fileName);
                }
                catch (System.IO.FileNotFoundException ex)
                {
                    DialogResult dr = MessageBox.Show(
                        "File " + ex.FileName + " not found. Create?",
                        "File not found",
                        MessageBoxButtons.YesNoCancel);
                    if (dr != DialogResult.Yes)
                        throw;
                    newFile = true;
                }
                m_dirty = false;
                m_filename = fileName;
                if (newFile)
                    m_mainForm.Log("Created new file :" + fileName);
                else
                    m_mainForm.Log("Opened file :" + fileName);
            }
		}

        private void TextChanged(object sender, EventArgs e)
        {
            m_dirty = true;
        }

        public string FileName { get { return m_filename; } }

        public RichTextBox TextBox { get { return m_textbox; } }

        public bool Dirty
        {
            get { return m_dirty; }
            set { m_dirty = value; }
        }

        public bool Closing()
        {
            if (m_dirty)
            {
                DialogResult dr = MessageBox.Show(
                    "File " + m_filename + " has changed. Save?",
                    "File not saved",
                    MessageBoxButtons.YesNoCancel);
                if (dr == DialogResult.Cancel)
                    return false;
                else if (dr == DialogResult.Yes)
                    Save();
            }
            m_mainForm.Log("Closed window: " + m_filename);
            return true;
        }

        public void SaveAs()
        {
            SaveFileDialog sfd = m_mainForm.SaveFileDialog;
            if (sfd.ShowDialog(m_mainForm) != DialogResult.OK)
                return;
            try
            {
                if (sfd.FilterIndex == 2)
                    m_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                else
                    m_textbox.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);
                m_filename = sfd.FileName;
            }
            catch
            {
                MessageBox.Show("Could not save file " + sfd.FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save()
        {
            if (m_filename == nofile)
                SaveAs();
            else
                m_textbox.SaveFile(m_filename);
        }
	}
}
