//----------------------------------------------------------------------------
// PictureAlignControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    /// <summary>
    /// Summary description for PictureAlignControl.
    /// </summary>
    partial class PictureAlignControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PictureAlignControl));
            this.part = new System.Windows.Forms.Button();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            this.palb = new System.Windows.Forms.Button();
            this.paclip = new System.Windows.Forms.Button();
            this.parb = new System.Windows.Forms.Button();
            this.pact = new System.Windows.Forms.Button();
            this.pastretch = new System.Windows.Forms.Button();
            this.pazoom = new System.Windows.Forms.Button();
            this.parm = new System.Windows.Forms.Button();
            this.palm = new System.Windows.Forms.Button();
            this.pacb = new System.Windows.Forms.Button();
            this.palt = new System.Windows.Forms.Button();
            this.pacm = new System.Windows.Forms.Button();
            this.patile = new System.Windows.Forms.Button();
            this._tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // part
            // 
            this.part.BackColor = System.Drawing.SystemColors.Control;
            this.part.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.part.Image = ((System.Drawing.Bitmap)(resources.GetObject("part.Image")));
            this.part.ImageIndex = 2;
            this.part.ImageList = this._imgList;
            this.part.Location = new System.Drawing.Point(80, 0);
            this.part.Name = "part";
            this.part.Size = new System.Drawing.Size(32, 32);
            this.part.TabIndex = 2;
            this.part.Tag = "2";
            this._tip.SetToolTip(this.part, Strings.PictureAlignControl.ToolTipRightTop);
            this.part.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.part.Click += new System.EventHandler(this.button_Click);
            // 
            // _imgList
            // 
            this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this._imgList.ImageSize = new System.Drawing.Size(16, 16);
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Red;
            // 
            // palb
            // 
            this.palb.BackColor = System.Drawing.SystemColors.Control;
            this.palb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.palb.Image = ((System.Drawing.Bitmap)(resources.GetObject("palb.Image")));
            this.palb.ImageIndex = 3;
            this.palb.ImageList = this._imgList;
            this.palb.Location = new System.Drawing.Point(0, 80);
            this.palb.Name = "palb";
            this.palb.Size = new System.Drawing.Size(32, 32);
            this.palb.TabIndex = 6;
            this.palb.Tag = "3";
            this._tip.SetToolTip(this.palb, Strings.PictureAlignControl.ToolTipLeftBottom);
            this.palb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.palb.Click += new System.EventHandler(this.button_Click);
            // 
            // paclip
            // 
            this.paclip.BackColor = System.Drawing.SystemColors.Control;
            this.paclip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paclip.Image = ((System.Drawing.Bitmap)(resources.GetObject("paclip.Image")));
            this.paclip.ImageIndex = 9;
            this.paclip.ImageList = this._imgList;
            this.paclip.Location = new System.Drawing.Point(48, 128);
            this.paclip.Name = "paclip";
            this.paclip.Size = new System.Drawing.Size(24, 24);
            this.paclip.TabIndex = 11;
            this.paclip.Tag = "9";
            this._tip.SetToolTip(this.paclip, Strings.PictureAlignControl.ToolTipClip);
            this.paclip.Visible = false;
            this.paclip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.paclip.Click += new System.EventHandler(this.button_Click);
            // 
            // parb
            // 
            this.parb.BackColor = System.Drawing.SystemColors.Control;
            this.parb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parb.Image = ((System.Drawing.Bitmap)(resources.GetObject("parb.Image")));
            this.parb.ImageIndex = 5;
            this.parb.ImageList = this._imgList;
            this.parb.Location = new System.Drawing.Point(80, 80);
            this.parb.Name = "parb";
            this.parb.Size = new System.Drawing.Size(32, 32);
            this.parb.TabIndex = 8;
            this.parb.Tag = "5";
            this._tip.SetToolTip(this.parb, Strings.PictureAlignControl.ToolTipRightbottom);
            this.parb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.parb.Click += new System.EventHandler(this.button_Click);
            // 
            // pact
            // 
            this.pact.BackColor = System.Drawing.SystemColors.Control;
            this.pact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pact.Image = ((System.Drawing.Bitmap)(resources.GetObject("pact.Image")));
            this.pact.ImageIndex = 1;
            this.pact.ImageList = this._imgList;
            this.pact.Location = new System.Drawing.Point(40, 0);
            this.pact.Name = "pact";
            this.pact.Size = new System.Drawing.Size(32, 32);
            this.pact.TabIndex = 1;
            this.pact.Tag = "1";
            this._tip.SetToolTip(this.pact, Strings.PictureAlignControl.ToolTipCenterTop);
            this.pact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.pact.Click += new System.EventHandler(this.button_Click);
            // 
            // pastretch
            // 
            this.pastretch.BackColor = System.Drawing.SystemColors.Control;
            this.pastretch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pastretch.Image = ((System.Drawing.Bitmap)(resources.GetObject("pastretch.Image")));
            this.pastretch.ImageIndex = 11;
            this.pastretch.ImageList = this._imgList;
            this.pastretch.Location = new System.Drawing.Point(24, 128);
            this.pastretch.Name = "pastretch";
            this.pastretch.Size = new System.Drawing.Size(24, 24);
            this.pastretch.TabIndex = 10;
            this.pastretch.Tag = "11";
            this._tip.SetToolTip(this.pastretch, Strings.PictureAlignControl.ToolTipStretch);
            this.pastretch.Visible = false;
            this.pastretch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.pastretch.Click += new System.EventHandler(this.button_Click);
            // 
            // pazoom
            // 
            this.pazoom.BackColor = System.Drawing.SystemColors.Control;
            this.pazoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pazoom.Image = ((System.Drawing.Bitmap)(resources.GetObject("pazoom.Image")));
            this.pazoom.ImageIndex = 10;
            this.pazoom.ImageList = this._imgList;
            this.pazoom.Location = new System.Drawing.Point(0, 128);
            this.pazoom.Name = "pazoom";
            this.pazoom.Size = new System.Drawing.Size(24, 24);
            this.pazoom.TabIndex = 9;
            this.pazoom.Tag = "10";
            this._tip.SetToolTip(this.pazoom, Strings.PictureAlignControl.ToolTipZoom);
            this.pazoom.Visible = false;
            this.pazoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.pazoom.Click += new System.EventHandler(this.button_Click);
            // 
            // parm
            // 
            this.parm.BackColor = System.Drawing.SystemColors.Control;
            this.parm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parm.Image = ((System.Drawing.Bitmap)(resources.GetObject("parm.Image")));
            this.parm.ImageIndex = 8;
            this.parm.ImageList = this._imgList;
            this.parm.Location = new System.Drawing.Point(80, 40);
            this.parm.Name = "parm";
            this.parm.Size = new System.Drawing.Size(32, 32);
            this.parm.TabIndex = 5;
            this.parm.Tag = "8";
            this._tip.SetToolTip(this.parm, Strings.PictureAlignControl.ToolTipRightMiddle);
            this.parm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.parm.Click += new System.EventHandler(this.button_Click);
            // 
            // palm
            // 
            this.palm.BackColor = System.Drawing.SystemColors.Control;
            this.palm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.palm.Image = ((System.Drawing.Bitmap)(resources.GetObject("palm.Image")));
            this.palm.ImageIndex = 6;
            this.palm.ImageList = this._imgList;
            this.palm.Location = new System.Drawing.Point(0, 40);
            this.palm.Name = "palm";
            this.palm.Size = new System.Drawing.Size(32, 32);
            this.palm.TabIndex = 3;
            this.palm.Tag = "6";
            this._tip.SetToolTip(this.palm, Strings.PictureAlignControl.ToolTipLeftMiddle);
            this.palm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.palm.Click += new System.EventHandler(this.button_Click);
            // 
            // pacb
            // 
            this.pacb.BackColor = System.Drawing.SystemColors.Control;
            this.pacb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pacb.Image = ((System.Drawing.Bitmap)(resources.GetObject("pacb.Image")));
            this.pacb.ImageIndex = 4;
            this.pacb.ImageList = this._imgList;
            this.pacb.Location = new System.Drawing.Point(40, 80);
            this.pacb.Name = "pacb";
            this.pacb.Size = new System.Drawing.Size(32, 32);
            this.pacb.TabIndex = 7;
            this.pacb.Tag = "4";
            this._tip.SetToolTip(this.pacb, Strings.PictureAlignControl.ToolTipCenterbottom);
            this.pacb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.pacb.Click += new System.EventHandler(this.button_Click);
            // 
            // palt
            // 
            this.palt.BackColor = System.Drawing.SystemColors.Control;
            this.palt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.palt.Image = ((System.Drawing.Bitmap)(resources.GetObject("palt.Image")));
            this.palt.ImageIndex = 0;
            this.palt.ImageList = this._imgList;
            this.palt.Name = "palt";
            this.palt.Size = new System.Drawing.Size(32, 32);
            this.palt.TabIndex = 0;
            this.palt.Tag = "0";
            this._tip.SetToolTip(this.palt, Strings.PictureAlignControl.ToolTipLeftTop);
            this.palt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.palt.Click += new System.EventHandler(this.button_Click);
            // 
            // pacm
            // 
            this.pacm.BackColor = System.Drawing.SystemColors.Control;
            this.pacm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pacm.Image = ((System.Drawing.Bitmap)(resources.GetObject("pacm.Image")));
            this.pacm.ImageIndex = 7;
            this.pacm.ImageList = this._imgList;
            this.pacm.Location = new System.Drawing.Point(40, 40);
            this.pacm.Name = "pacm";
            this.pacm.Size = new System.Drawing.Size(32, 32);
            this.pacm.TabIndex = 4;
            this.pacm.Tag = "7";
            this._tip.SetToolTip(this.pacm, Strings.PictureAlignControl.ToolTipCenterMiddle);
            this.pacm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.pacm.Click += new System.EventHandler(this.button_Click);
            // 
            // patile
            // 
            this.patile.BackColor = System.Drawing.SystemColors.Control;
            this.patile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patile.Image = ((System.Drawing.Bitmap)(resources.GetObject("patile.Image")));
            this.patile.ImageIndex = 12;
            this.patile.ImageList = this._imgList;
            this.patile.Location = new System.Drawing.Point(72, 128);
            this.patile.Name = "patile";
            this.patile.Size = new System.Drawing.Size(24, 24);
            this.patile.TabIndex = 12;
            this.patile.Tag = "12";
            this._tip.SetToolTip(this.patile, Strings.PictureAlignControl.ToolTipTile);
            this.patile.Visible = false;
            this.patile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            this.patile.Click += new System.EventHandler(this.button_Click);
            // 
            // PictureAlignControl
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.part,
                                                                          this.palb,
                                                                          this.paclip,
                                                                          this.parb,
                                                                          this.pact,
                                                                          this.pastretch,
                                                                          this.pazoom,
                                                                          this.parm,
                                                                          this.palm,
                                                                          this.pacb,
                                                                          this.palt,
                                                                          this.pacm,
                                                                          this.patile});
            this.Name = "PictureAlignControl";
            this.Size = new System.Drawing.Size(112, 112);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button part;
        private System.Windows.Forms.Button palb;
        private System.Windows.Forms.Button paclip;
        private System.Windows.Forms.Button parb;
        private System.Windows.Forms.Button pact;
        private System.Windows.Forms.Button pastretch;
        private System.Windows.Forms.Button pazoom;
        private System.Windows.Forms.Button parm;
        private System.Windows.Forms.Button palm;
        private System.Windows.Forms.Button pacb;
        private System.Windows.Forms.Button palt;
        private System.Windows.Forms.Button pacm;
        private System.Windows.Forms.Button patile;
        private System.Windows.Forms.ImageList _imgList;
        private System.Windows.Forms.ToolTip _tip;
    }
}
