//----------------------------------------------------------------------------
// TextAlignControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
	partial class TextAlignControl
	{
		private System.ComponentModel.IContainer components;

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TextAlignControl));
			this.tatl = new System.Windows.Forms.Button();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			this.tatm = new System.Windows.Forms.Button();
			this.tatr = new System.Windows.Forms.Button();
			this.tajt = new System.Windows.Forms.Button();
			this.tamr = new System.Windows.Forms.Button();
			this.tajm = new System.Windows.Forms.Button();
			this.tamc = new System.Windows.Forms.Button();
			this.taml = new System.Windows.Forms.Button();
			this.tamb = new System.Windows.Forms.Button();
			this.tabl = new System.Windows.Forms.Button();
			this.tarb = new System.Windows.Forms.Button();
			this.tajb = new System.Windows.Forms.Button();
			this.tageneral = new System.Windows.Forms.Button();
			this._tip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// tatl
			// 
			this.tatl.BackColor = System.Drawing.SystemColors.Control;
			this.tatl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tatl.Image = ((System.Drawing.Bitmap)(resources.GetObject("tatl.Image")));
			this.tatl.ImageIndex = 0;
			this.tatl.ImageList = this._imgList;
			this.tatl.Name = "tatl";
			this.tatl.Size = new System.Drawing.Size(24, 24);
			this.tatl.TabIndex = 0;
			this.tatl.Tag = "0";
			this._tip.SetToolTip(this.tatl, Strings.TextAlignControl.ToolTipLeftTop);
			this.tatl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tatl.Click += new System.EventHandler(this.button_Clicked);
			// 
			// _imgList
			// 
			this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._imgList.ImageSize = new System.Drawing.Size(16, 16);
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Red;
			// 
			// tatm
			// 
			this.tatm.BackColor = System.Drawing.SystemColors.Control;
			this.tatm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tatm.Image = ((System.Drawing.Bitmap)(resources.GetObject("tatm.Image")));
			this.tatm.ImageIndex = 1;
			this.tatm.ImageList = this._imgList;
			this.tatm.Location = new System.Drawing.Point(24, 0);
			this.tatm.Name = "tatm";
			this.tatm.Size = new System.Drawing.Size(24, 24);
			this.tatm.TabIndex = 1;
			this.tatm.Tag = "1";
			this._tip.SetToolTip(this.tatm, Strings.TextAlignControl.ToolTipCenterTop);
			this.tatm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tatm.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tatr
			// 
			this.tatr.BackColor = System.Drawing.SystemColors.Control;
			this.tatr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tatr.Image = ((System.Drawing.Bitmap)(resources.GetObject("tatr.Image")));
			this.tatr.ImageIndex = 2;
			this.tatr.ImageList = this._imgList;
			this.tatr.Location = new System.Drawing.Point(48, 0);
			this.tatr.Name = "tatr";
			this.tatr.Size = new System.Drawing.Size(24, 24);
			this.tatr.TabIndex = 2;
			this.tatr.Tag = "2";
			this._tip.SetToolTip(this.tatr, Strings.TextAlignControl.ToolTipRightTop);
			this.tatr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tatr.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tajt
			// 
			this.tajt.BackColor = System.Drawing.SystemColors.Control;
			this.tajt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tajt.Image = ((System.Drawing.Bitmap)(resources.GetObject("tajt.Image")));
			this.tajt.ImageIndex = 9;
			this.tajt.ImageList = this._imgList;
			this.tajt.Location = new System.Drawing.Point(80, 0);
			this.tajt.Name = "tajt";
			this.tajt.Size = new System.Drawing.Size(24, 24);
			this.tajt.TabIndex = 3;
			this.tajt.Tag = "9";
            this._tip.SetToolTip(this.tajt, Strings.TextAlignControl.ToolTipJustifyTop);
			this.tajt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tajt.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tamr
			// 
			this.tamr.BackColor = System.Drawing.SystemColors.Control;
			this.tamr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tamr.Image = ((System.Drawing.Bitmap)(resources.GetObject("tamr.Image")));
			this.tamr.ImageIndex = 8;
			this.tamr.ImageList = this._imgList;
			this.tamr.Location = new System.Drawing.Point(48, 24);
			this.tamr.Name = "tamr";
			this.tamr.Size = new System.Drawing.Size(24, 24);
			this.tamr.TabIndex = 6;
			this.tamr.Tag = "8";
			this._tip.SetToolTip(this.tamr, Strings.TextAlignControl.ToolTipRightMiddle);
			this.tamr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tamr.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tajm
			// 
			this.tajm.BackColor = System.Drawing.SystemColors.Control;
			this.tajm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tajm.Image = ((System.Drawing.Bitmap)(resources.GetObject("tajm.Image")));
			this.tajm.ImageIndex = 11;
			this.tajm.ImageList = this._imgList;
			this.tajm.Location = new System.Drawing.Point(80, 24);
			this.tajm.Name = "tajm";
			this.tajm.Size = new System.Drawing.Size(24, 24);
			this.tajm.TabIndex = 7;
			this.tajm.Tag = "11";
            this._tip.SetToolTip(this.tajm, Strings.TextAlignControl.ToolTipJustifyMiddle);
			this.tajm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tajm.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tamc
			// 
			this.tamc.BackColor = System.Drawing.SystemColors.Control;
			this.tamc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tamc.Image = ((System.Drawing.Bitmap)(resources.GetObject("tamc.Image")));
			this.tamc.ImageIndex = 7;
			this.tamc.ImageList = this._imgList;
			this.tamc.Location = new System.Drawing.Point(24, 24);
			this.tamc.Name = "tamc";
			this.tamc.Size = new System.Drawing.Size(24, 24);
			this.tamc.TabIndex = 5;
			this.tamc.Tag = "7";
			this._tip.SetToolTip(this.tamc, Strings.TextAlignControl.ToolTipCenterMiddle);
			this.tamc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tamc.Click += new System.EventHandler(this.button_Clicked);
			// 
			// taml
			// 
			this.taml.BackColor = System.Drawing.SystemColors.Control;
			this.taml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.taml.Image = ((System.Drawing.Bitmap)(resources.GetObject("taml.Image")));
			this.taml.ImageIndex = 6;
			this.taml.ImageList = this._imgList;
			this.taml.Location = new System.Drawing.Point(0, 24);
			this.taml.Name = "taml";
			this.taml.Size = new System.Drawing.Size(24, 24);
			this.taml.TabIndex = 4;
			this.taml.Tag = "6";
			this._tip.SetToolTip(this.taml, Strings.TextAlignControl.ToolTipLeftMiddle);
			this.taml.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.taml.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tamb
			// 
			this.tamb.BackColor = System.Drawing.SystemColors.Control;
			this.tamb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tamb.Image = ((System.Drawing.Bitmap)(resources.GetObject("tamb.Image")));
			this.tamb.ImageIndex = 4;
			this.tamb.ImageList = this._imgList;
			this.tamb.Location = new System.Drawing.Point(24, 48);
			this.tamb.Name = "tamb";
			this.tamb.Size = new System.Drawing.Size(24, 24);
			this.tamb.TabIndex = 9;
			this.tamb.Tag = "4";
			this._tip.SetToolTip(this.tamb, Strings.TextAlignControl.ToolTipCenterbottom);
			this.tamb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tamb.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tabl
			// 
			this.tabl.BackColor = System.Drawing.SystemColors.Control;
			this.tabl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tabl.Image = ((System.Drawing.Bitmap)(resources.GetObject("tabl.Image")));
			this.tabl.ImageIndex = 3;
			this.tabl.ImageList = this._imgList;
			this.tabl.Location = new System.Drawing.Point(0, 48);
			this.tabl.Name = "tabl";
			this.tabl.Size = new System.Drawing.Size(24, 24);
			this.tabl.TabIndex = 8;
			this.tabl.Tag = "3";
			this._tip.SetToolTip(this.tabl, Strings.TextAlignControl.ToolTipLeftBottom);
			this.tabl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tabl.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tarb
			// 
			this.tarb.BackColor = System.Drawing.SystemColors.Control;
			this.tarb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tarb.Image = ((System.Drawing.Bitmap)(resources.GetObject("tarb.Image")));
			this.tarb.ImageIndex = 5;
			this.tarb.ImageList = this._imgList;
			this.tarb.Location = new System.Drawing.Point(48, 48);
			this.tarb.Name = "tarb";
			this.tarb.Size = new System.Drawing.Size(24, 24);
			this.tarb.TabIndex = 10;
			this.tarb.Tag = "5";
			this._tip.SetToolTip(this.tarb, Strings.TextAlignControl.ToolTipRightbottom);
			this.tarb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tarb.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tajb
			// 
			this.tajb.BackColor = System.Drawing.SystemColors.Control;
			this.tajb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tajb.Image = ((System.Drawing.Bitmap)(resources.GetObject("tajb.Image")));
			this.tajb.ImageIndex = 10;
			this.tajb.ImageList = this._imgList;
			this.tajb.Location = new System.Drawing.Point(80, 48);
			this.tajb.Name = "tajb";
			this.tajb.Size = new System.Drawing.Size(24, 24);
			this.tajb.TabIndex = 11;
			this.tajb.Tag = "10";
            this._tip.SetToolTip(this.tajb, Strings.TextAlignControl.ToolTipJustifyBottom);
			this.tajb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tajb.Click += new System.EventHandler(this.button_Clicked);
			// 
			// tageneral
			// 
			this.tageneral.BackColor = System.Drawing.SystemColors.Control;
			this.tageneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tageneral.Image = ((System.Drawing.Bitmap)(resources.GetObject("tageneral.Image")));
			this.tageneral.ImageIndex = 12;
			this.tageneral.ImageList = this._imgList;
			this.tageneral.Location = new System.Drawing.Point(0, 80);
			this.tageneral.Name = "tageneral";
			this.tageneral.TabIndex = 12;
			this.tageneral.Tag = "-1";
            this._tip.SetToolTip(this.tageneral, Strings.TextAlignControl.ToolTipGeneral);
			this.tageneral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
			this.tageneral.Click += new System.EventHandler(this.button_Clicked);
			// 
			// TextAlignControl
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tatl,
																		  this.tatm,
																		  this.tatr,
																		  this.tajt,
																		  this.tamr,
																		  this.tajm,
																		  this.tamc,
																		  this.taml,
																		  this.tamb,
																		  this.tabl,
																		  this.tarb,
																		  this.tajb,
																		  this.tageneral});
			this.Name = "TextAlignControl";
			this.Size = new System.Drawing.Size(104, 104);
			this.ResumeLayout(false);

		}
        #endregion

        private System.Windows.Forms.Button tatl;
        private System.Windows.Forms.Button tatm;
        private System.Windows.Forms.Button tatr;
        private System.Windows.Forms.Button tajt;
        private System.Windows.Forms.Button tamr;
        private System.Windows.Forms.Button tajm;
        private System.Windows.Forms.Button tamc;
        private System.Windows.Forms.Button taml;
        private System.Windows.Forms.Button tamb;
        private System.Windows.Forms.Button tabl;
        private System.Windows.Forms.Button tarb;
        private System.Windows.Forms.Button tajb;
        private System.Windows.Forms.Button tageneral;
        private System.Windows.Forms.ImageList _imgList;
        private System.Windows.Forms.ToolTip _tip;
    }
}
