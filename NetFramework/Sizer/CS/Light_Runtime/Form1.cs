using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Simple
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.Sizer.C1SizerLight _sizerLight;
        private System.Windows.Forms.Button _btnAddChildGroupBox;
        private System.Windows.Forms.Button _btnMoveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnResizeForm;
        private System.Windows.Forms.Button _btnAddChildForm;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
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
            checkBox1.Checked = _sizerLight.Enabled;
            checkBox2.Checked = _sizerLight.ResizeFonts;
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
			this.components = new System.ComponentModel.Container();
			this._sizerLight = new C1.Win.Sizer.C1SizerLight(this.components);
			this._btnAddChildGroupBox = new System.Windows.Forms.Button();
			this._btnMoveButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._btnResizeForm = new System.Windows.Forms.Button();
			this._btnAddChildForm = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _sizerLight
			// 
			this._sizerLight.ResizingFont += new C1.Win.Sizer.C1SizerLightEventHandler(this._sizerLight_ResizingFont);
			// 
			// _btnAddChildGroupBox
			// 
			this._btnAddChildGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._btnAddChildGroupBox.Location = new System.Drawing.Point(8, 16);
			this._btnAddChildGroupBox.Name = "_btnAddChildGroupBox";
			this._btnAddChildGroupBox.Size = new System.Drawing.Size(224, 24);
			this._btnAddChildGroupBox.TabIndex = 0;
			this._btnAddChildGroupBox.Text = "Add button to group box";
			this._btnAddChildGroupBox.Click += new System.EventHandler(this._btnAddChildGroupBox_Click);
			// 
			// _btnMoveButton
			// 
			this._btnMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._btnMoveButton.Location = new System.Drawing.Point(344, 224);
			this._btnMoveButton.Name = "_btnMoveButton";
			this._btnMoveButton.Size = new System.Drawing.Size(192, 24);
			this._btnMoveButton.TabIndex = 0;
			this._btnMoveButton.Text = "Move This Button";
			this._btnMoveButton.Click += new System.EventHandler(this._btnMoveButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this._btnAddChildGroupBox});
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 224);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 128);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Group Box";
			// 
			// _btnResizeForm
			// 
			this._btnResizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._btnResizeForm.Location = new System.Drawing.Point(344, 200);
			this._btnResizeForm.Name = "_btnResizeForm";
			this._btnResizeForm.Size = new System.Drawing.Size(192, 24);
			this._btnResizeForm.TabIndex = 0;
			this._btnResizeForm.Text = "Resize Form";
			this._btnResizeForm.Click += new System.EventHandler(this._btnResizeForm_Click);
			// 
			// _btnAddChildForm
			// 
			this._btnAddChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._btnAddChildForm.Location = new System.Drawing.Point(344, 176);
			this._btnAddChildForm.Name = "_btnAddChildForm";
			this._btnAddChildForm.Size = new System.Drawing.Size(192, 24);
			this._btnAddChildForm.TabIndex = 0;
			this._btnAddChildForm.Text = "Add button to form";
			this._btnAddChildForm.Click += new System.EventHandler(this._btnAddChildForm_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(528, 160);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = @"Using C1SizerLight i seasy: just add one to a form, set the Enabled property to true, and all controls on the form will be resized automatically with the form.

Fonts are also resized, depending on the setting of the C1SizerLigth.ResizeFonts property. 

If you want to prevent certain controls (e.g. this one) from having their fonts resized, use the ""ResizingFont"" event and set the Cancel property to true.

When you add or resize controls at runtime, using code, remember to set the C1SizerLigth.Enabled property to false before the changes, then back to true after the changes. This will force the component to update its internal layout information.";
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(8, 176);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(152, 16);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "C1SizerLight Enabled";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(8, 200);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(152, 16);
			this.checkBox2.TabIndex = 4;
			this.checkBox2.Text = "Resize Fonts";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// Form1
			// 
			this._sizerLight.SetAutoResize(this, true);
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(544, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBox1,
																		  this.richTextBox1,
																		  this.groupBox1,
																		  this._btnMoveButton,
																		  this._btnResizeForm,
																		  this._btnAddChildForm,
																		  this.checkBox2});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1SizerLight: Add and manage controls at runtime";
			((System.ComponentModel.ISupportInitialize)(this._sizerLight)).EndInit();
			this.groupBox1.ResumeLayout(false);
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
        
		// enable/disable the C1SizerLight
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			_sizerLight.Enabled = checkBox1.Checked;
		}

		// enable/disable font resizing
		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			_sizerLight.ResizeFonts = checkBox2.Checked;
		}

		// disable font resizing for specific controls on the form
		private void _sizerLight_ResizingFont(object sender, C1.Win.Sizer.C1SizerLightEventArgs e)
		{
			// do not resize the font for the rich text box
			if (e.Control == richTextBox1)
				e.Cancel = true;
		}

		// resize the form 50 times just to see the C1SizerLight in action
		private void _btnResizeForm_Click(object sender, System.EventArgs e)
		{
			Random rnd = new Random();
			Rectangle rc = Bounds;
			for (int i = 0; i < 50; i++)
			{
				int dx = (int)(0.50 * Width);
				int dy = (int)(0.50 * Height);
				Width  += rnd.Next(-dx, dx);
				Height += rnd.Next(-dy, dy);
				Update();
			}
			Bounds = rc;
		}

		// move a button on the form
		private int _offset = 200;
        private void _btnMoveButton_Click(object sender, System.EventArgs e)
        {
            Point pt = _btnMoveButton.Location;
			pt.X = pt.X - _offset;
            _btnMoveButton.Location = pt;
			_offset = -_offset;
		}

		// add a button to the form at run time:
		//
		// disable the C1SizerLight first, 
		// then add the control, 
		// then re-enable the C1SizerLight 
		//
		private System.Windows.Forms.Button _newChild = null;
        private void _btnAddChildForm_Click(object sender, System.EventArgs e)
        {
            // disable sizer light before changes
            _sizerLight.Enabled = false;

            if (_newChild == null)
            {
                // add button
                Rectangle rc = _btnMoveButton.Bounds;
                rc.Offset(0, _btnMoveButton.Height + 3);
                _newChild = new System.Windows.Forms.Button();
                _newChild.Font = _btnAddChildForm.Font;
                _newChild.Bounds = rc;
                _newChild.BackColor = Color.Red;
                _newChild.Text = "Button added to the form";
                Controls.Add(_newChild);
                _btnAddChildForm.Tag = _btnAddChildForm.Text;
                _btnAddChildForm.Text = "Remove red button";
            }
            else
            {
                // remove button
                Controls.Remove(_newChild);
                _newChild.Dispose();
                _newChild = null;
                _btnAddChildForm.Text = (string)_btnAddChildForm.Tag;
            }

            // re-enable sizer light after the changes
            _sizerLight.Enabled = checkBox1.Checked;
        }

		// add a button to a container control at run time:
		//
		// disable the C1SizerLight first, 
		// then add the control, 
		// then re-enable the C1SizerLight 
		//
		private System.Windows.Forms.Button _newGrandChild = null;
		private void _btnAddChildGroupBox_Click(object sender, System.EventArgs e)
		{
			// disable sizer light before changes
			_sizerLight.Enabled = false;

			if (_newGrandChild == null)
			{
				// add new button
				_newGrandChild = new System.Windows.Forms.Button();
				_newGrandChild.Font = _btnAddChildGroupBox.Font;
				Rectangle rc = _btnAddChildGroupBox.Bounds;
				rc.Offset(0, rc.Height + 4);
				_newGrandChild.Bounds = rc;
				_newGrandChild.Name = "_btnAddChildGroupBox";
				_newGrandChild.Text = "New Grand-child (in a container)";
				groupBox1.Controls.Add(_newGrandChild);
				_btnAddChildGroupBox.Text = "Remove Grand-child";
			}
			else
			{
				// remove button
				groupBox1.Controls.Remove(_newGrandChild);
				_newGrandChild.Dispose();
				_newGrandChild = null;
				_btnAddChildGroupBox.Text = "Add New Grand-child";
			}

			// re-enable sizer light after the changes
			_sizerLight.Enabled = checkBox1.Checked;
		}
	}
}
