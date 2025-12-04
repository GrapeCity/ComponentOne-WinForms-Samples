using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.Command;

namespace WindowsApplication8
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "textBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 16);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "C1 Menu";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "On form load, the text box below has default system context menu. Press the \"C1 M" +
                "enu\" button to create a C1ContextMenu and associate it with the text box.";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(376, 163);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label1,
                                                                          this.button1,
                                                                          this.textBox1});
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Create the command holder. This is essential for all C1Command operation
                C1CommandHolder ch = C1CommandHolder.CreateCommandHolder(this);
                // Use the pre-built image list
                ch.ImageList = this.imageList1;

                // Create and set up the Cut command
                C1Command cmdCut = ch.CreateCommand();
                cmdCut.Text = "C&ut";
                cmdCut.Shortcut = Shortcut.CtrlX;
                cmdCut.ImageIndex = 0;
                cmdCut.Click += new C1.Win.Command.ClickEventHandler(clickCut);
                cmdCut.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(queryCut);

                // Create and set up the Copy command
                C1Command cmdCopy = ch.CreateCommand();
                cmdCopy.Text = "&Copy";
                cmdCopy.Shortcut = Shortcut.CtrlC;
                cmdCopy.ImageIndex = 1;
                cmdCopy.Click += new C1.Win.Command.ClickEventHandler(clickCopy);
                cmdCopy.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(queryCopy);

                // Create and set up the Paste command
                C1Command cmdPaste = ch.CreateCommand();
                cmdPaste.Text = "&Paste";
                cmdPaste.Shortcut = Shortcut.CtrlV;
                cmdPaste.ImageIndex = 2;
                cmdPaste.Click += new C1.Win.Command.ClickEventHandler(clickPaste);
                cmdPaste.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(queryPaste);

                // Create and set up the Undo command
                C1Command cmdUndo = ch.CreateCommand();
                cmdUndo.Text = "&Undo";
                cmdUndo.Shortcut = Shortcut.CtrlZ;
                cmdUndo.ImageIndex = -1;
                cmdUndo.Click += new C1.Win.Command.ClickEventHandler(clickUndo);
                cmdUndo.CommandStateQuery += new C1.Win.Command.CommandStateQueryEventHandler(queryUndo);

                // Create the context menu to hold other commands
                C1ContextMenu cm = ch.CreateCommand(typeof(C1ContextMenu)) as C1ContextMenu;
                // Fill it with the links to the commands
                cm.CommandLinks.Add(new C1CommandLink(cmdCut));
                cm.CommandLinks.Add(new C1CommandLink(cmdCopy));
                cm.CommandLinks.Add(new C1CommandLink(cmdPaste));
                C1CommandLink cl = new C1CommandLink(cmdUndo);
                // This will show a delimiter before the Undo link.
                // Another option is to create a separate empty link with the text "-".
                cl.Delimiter = true;
                cm.CommandLinks.Add(cl);

                // Assign the new context menu to the text box
                ch.SetC1ContextMenu(textBox1, cm);
            }
            catch
            {
                // Not the best way to code, but used here to illustrate a point:
                // It is impossible to create more than one command holder for a form.
                // The 2nd attempt will fail with an exception. Here we catch and ignore
                // it...
            }
        }

        // The click* methods handle corresponding command actions
        private void clickCut(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.textBox1.Cut();
        }

        // The query methods are automatically called to provide the current state of
        // corresponding commnads.
        private void queryCut(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            e.Enabled = this.textBox1.SelectionLength > 0;
        }

        private void clickCopy(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.textBox1.Copy();
        }

        private void queryCopy(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            e.Enabled = this.textBox1.SelectionLength > 0;
        }

        private void clickPaste(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.textBox1.Paste();
        }

        private void queryPaste(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            e.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
        }

        private void clickUndo(object sender, C1.Win.Command.ClickEventArgs e)
        {
            this.textBox1.Undo();
        }

        private void queryUndo(object sender, C1.Win.Command.CommandStateQueryEventArgs e)
        {
            e.Enabled = this.textBox1.CanUndo;
        }
    }
}
