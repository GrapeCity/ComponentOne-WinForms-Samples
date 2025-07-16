using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.Command;

namespace SimpleMenusInCode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        // keep track of all opened forms
        private static ArrayList s_forms = new ArrayList();

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            s_forms.Add(this);
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 293);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 293);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "New document";
            this.Load += new System.EventHandler(this.Form1_Load);
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            C1CommandHolder ch = C1CommandHolder.CreateCommandHolder(this);
            // In this sample, we use a single event handler for all commands,
            // and use a switch statement inside that handler to select the specific
            // action. Alternatively, each command can be assigned its own Click
            // event handler. Or, a mix of the two approaches is possible.
            ch.CommandClick += new CommandClickEventHandler(CommandClickHandler);
            // use the image list for command images
            ch.ImageList = this.imageList1;

            C1MainMenu mm = new C1MainMenu();
            this.Controls.Add(mm);
            // For the main menu, its CommandHolder property should be set
            // (this is not required for builds 1.0.20041.47 or later of C1Command).
            mm.CommandHolder = ch;

            // Main menu - File
            C1CommandMenu mFile = (C1CommandMenu)ch.CreateCommand(typeof(C1CommandMenu));
            mFile.Text = "&File";
            mm.CommandLinks.Add(new C1CommandLink(mFile));

            // create commands for file ops
            C1Command cNew = ch.CreateCommand();
            cNew.Text = "&New";
            // UserData is arbitrary data associated with commands;
            // In this example we use text labels to recognize specific commands
            // in the single command handler. Alternatively, we could have commands
            // as members of our class, and compare objects to recognize commands.
            cNew.UserData = "file_new";
            cNew.Shortcut = Shortcut.CtrlN;
            cNew.ImageIndex = 1;
            C1Command cOpen = ch.CreateCommand();
            cOpen.Text = "&Open";
            cOpen.UserData = "file_open";
            cOpen.Shortcut = Shortcut.CtrlO;
            cOpen.ImageIndex = 0;
            C1Command cExit = ch.CreateCommand();
            cExit.Text = "E&xit";
            cExit.UserData = "exit";
            cExit.Shortcut = Shortcut.CtrlX;

            mFile.CommandLinks.Add(new C1CommandLink(cNew));
            mFile.CommandLinks.Add(new C1CommandLink(cOpen));
            mFile.CommandLinks.Add(new C1CommandLink());
            mFile.CommandLinks[mFile.CommandLinks.Count - 1].Text = "-";
            mFile.CommandLinks.Add(new C1CommandLink(cExit));

            // Main menu - Window
            C1CommandMenu mWindow = (C1CommandMenu)ch.CreateCommand(typeof(C1CommandMenu));
            mWindow.Text = "&Window";
            mm.CommandLinks.Add(new C1CommandLink(mWindow));

            C1Command cNewWindow = ch.CreateCommand();
            cNewWindow.Text = "New &Window";
            cNewWindow.UserData = "window_new";
            cNewWindow.Shortcut = Shortcut.CtrlW;
            cNewWindow.ImageIndex = 2;

            mWindow.CommandLinks.Add(new C1CommandLink(cNewWindow));

            // For toolbars to be dockable/floatable, we must put them
            // in a C1CommandDock:
            C1CommandDock dock = new C1CommandDock();
            this.Controls.Add(dock);
            dock.Dock = DockStyle.Top;
            // Add a toolbar, link it to the (already existing) commands:
            C1ToolBar tb = new C1ToolBar();
            // add file commands and the window menu to the toolbar
            tb.CommandLinks.Add(new C1CommandLink(cNew));
            tb.CommandLinks.Add(new C1CommandLink(cOpen));
            C1CommandLink cl;
            tb.CommandLinks.Add(cl = new C1CommandLink(mWindow));
            // because we did not provide an image for the window menu,
            // make it show as text
            cl.ButtonLook = ButtonLookFlags.Text;
            tb.CommandLinks.Add(cl = new C1CommandLink(cExit));
            // ditto for the exit command
            cl.ButtonLook = ButtonLookFlags.Text;
            // add the new toolbar to the dock
            dock.Controls.Add(tb);
        }

        private void CommandClickHandler(object sender, CommandClickEventArgs e)
        {
            string cmdData = e.Command.UserData as string;
            switch (cmdData)
            {
                case "file_new":
                    this.richTextBox1.Text = string.Empty;
                    this.Text = "New document";
                    break;
                case "file_open":
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text files|*.txt|Rich text files|*.rtf|All files|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        switch (ofd.FilterIndex)
                        {
                            case 1:
                                this.richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                                break;
                            case 2:
                                this.richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                                break;
                            default:
                                this.richTextBox1.LoadFile(ofd.FileName);
                                break;
                        }
                        this.Text = ofd.FileName;
                    }
                    break;
                case "exit":
                    foreach (Form f in s_forms)
                        f.Close();
                    break;
                case "window_new":
                    (new Form1()).Show();
                    break;
                default:
                    break;
            }
        }
	}
}

