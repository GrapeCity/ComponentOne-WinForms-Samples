//----------------------------------------------------------------------------
// StyleSelector.cs
//
// Copyright (C) ComponentOne LLC
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using C1.C1Report;

namespace ReportStyle
{
    /// <summary>
    /// Summary description for StyleSelector.
    /// </summary>
    public class StyleSelector : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox picStyle;
        private System.Windows.Forms.ListBox lbStyles;
        private Button btnCancel;
        private Button btnOk;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public StyleSelector()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;

            // initialize styles
            foreach (ReportStyle style in ReportStyle.StyleList)
                lbStyles.Items.Add(style);
            lbStyles.SelectedIndex = 0;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
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
            this.lbStyles = new System.Windows.Forms.ListBox();
            this.picStyle = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // _lbStyles
            // 
            this.lbStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStyles.IntegralHeight = false;
            this.lbStyles.Location = new System.Drawing.Point(303, 12);
            this.lbStyles.Name = "_lbStyles";
            this.lbStyles.Size = new System.Drawing.Size(309, 363);
            this.lbStyles.TabIndex = 0;
            this.lbStyles.SelectedIndexChanged += new System.EventHandler(this.lbStyles_SelectedIndexChanged);
            this.lbStyles.DoubleClick += new System.EventHandler(this._lbStyles_DoubleClick);
            // 
            // _picStyle
            // 
            this.picStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStyle.Location = new System.Drawing.Point(12, 12);
            this.picStyle.Name = "_picStyle";
            this.picStyle.Size = new System.Drawing.Size(285, 363);
            this.picStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStyle.TabIndex = 1;
            this.picStyle.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(537, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(456, 389);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // StyleSelector
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbStyles);
            this.Controls.Add(this.picStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 450);
            this.Name = "StyleSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "C1Report Style Selector";
            ((System.ComponentModel.ISupportInitialize)(this.picStyle)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        public ReportStyle SelectedStyle
        {
            get
            {
                return lbStyles.SelectedItem as ReportStyle;
            }
            set
            {
                lbStyles.SelectedItem = value;
            }
        }

        private void lbStyles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ReportStyle style = lbStyles.SelectedItem as ReportStyle;
            picStyle.Image = (style != null) ? style.GetPreview(false) : null;
        }

        private void _lbStyles_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        internal static Bitmap BitmapFromStream(string resName, Color transparentColor)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.EndsWith(resName))
                {
                    System.IO.Stream stream = a.GetManifestResourceStream(res);
                    Bitmap bmp = (Bitmap)Bitmap.FromStream(stream);
                    bmp.MakeTransparent(transparentColor);
                    return bmp;
                }
            }
            return null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
