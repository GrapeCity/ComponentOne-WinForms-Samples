using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LocalizedSpellMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // works for TextBox, not for RichTextBox
            //this.textBox1.ContextMenuStripChanged += new EventHandler(textBox_ContextMenuStripChanged);
            //this.richTextBox1.ContextMenuChanged += new EventHandler(textBox_ContextMenuStripChanged);

            // less elegant, but works for both
            this.textBox1.MouseDown += new MouseEventHandler(textBox_MouseDown);
            this.richTextBox1.MouseDown += new MouseEventHandler(textBox_MouseDown);
        }

        void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control textBox = sender as Control;
                if (textBox.ContextMenuStrip != null)
                {
                    textBox.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
                }
            }
        }

        void textBox_ContextMenuStripChanged(object sender, EventArgs e)
        {
            Control textBox = sender as Control;
            if (textBox.ContextMenuStrip != null)
            {
                textBox.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
            }
        }

        // translate spell menu to Portuguese
        void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            ContextMenuStrip menu = sender as ContextMenuStrip;
            foreach (ToolStripItem item in menu.Items)
            {
                switch (item.Text)
                {
                    case "(no spelling suggestions)":
                        item.Text = "(sem sugestões)";
                        break;
                    case "&Ignore All":
                        item.Text = "&Ignorar todas as ocorrências";
                        break;
                    case "&Add to Dictionary":
                        item.Text = "&Adicionar ao dicionário";
                        break;
                    case "&Spell":
                        item.Text = "&Corrigir ortografia";
                        break;
                }
            }
        }
    }
}