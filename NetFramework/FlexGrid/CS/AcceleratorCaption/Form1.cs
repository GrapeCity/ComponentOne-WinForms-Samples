using C1.Win.FlexGrid;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AcceleratorCaption
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.Size = new System.Drawing.Size(464, 224);
			this._flex.TabIndex = 0;
			this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// button1
			// 
			this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button1.Location = new System.Drawing.Point(8, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "Button &1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button2.Location = new System.Drawing.Point(168, 240);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 48);
			this.button2.TabIndex = 1;
			this.button2.Text = "Button &2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex,
																		  this.button2});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Captions with Accelerators";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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
			// use owner-draw to show accelerators
			_flex.DrawMode = DrawModeEnum.OwnerDraw;

			// add some captions with accelerators
			_flex.Cols[1].Caption = "&Name";
			_flex.Cols[2].Caption = "&Address";
			_flex.Cols[3].Caption = "&Phone";

			// create one 'proxy' button per accelerator
			CreateAcceleratorButtons();
		}

		// draw accelerators
		private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (e.Row < _flex.Rows.Fixed && e.Text.IndexOf("&") > -1)
			{
				e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);

				StringFormat fmt = new StringFormat();
				fmt.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
				e.Graphics.DrawString(e.Text, e.Style.Font, Brushes.Black, e.Bounds, fmt);
			}
		}

		// create proxy buttons to activate accelerators
		private void CreateAcceleratorButtons()
		{
			foreach (Column col in _flex.Cols)
			{
				int index = col.Caption.IndexOf("&");
				if (index > -1)
				{
					Button btn = new Button();
					btn.Text = col.Caption;
					btn.Tag = col;
					btn.Click += new EventHandler(_btnClick);
					btn.Bounds = new Rectangle(-10, -10, 0, 0);
					btn.TabStop = false;
					Controls.Add(btn);
				}
			}
		}

		// transfer focus to grid column when a proxy button is activated
		private void _btnClick(object sender, System.EventArgs e)
		{
			Button btn = sender as Button;
			Column col = btn.Tag as Column;
			_flex.Col = col.Index;
			_flex.Focus();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Console.WriteLine("Button1 clicked");		
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			Console.WriteLine("Button2 clicked");		
		}
	}
}
