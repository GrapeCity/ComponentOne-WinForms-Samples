//----------------------------------------------------------------------------
// ErrorList.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls
{
    partial class ErrorList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorList));
            this._list = new System.Windows.Forms.ListView();
            this._colSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._colMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this._colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _list
            // 
            this._list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colSeverity,
            this._colMessage,
            this._colCount});
            this._list.Dock = System.Windows.Forms.DockStyle.Fill;
            this._list.Location = new System.Drawing.Point(0, 0);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(396, 230);
            this._list.SmallImageList = this.imageList1;
            this._list.TabIndex = 0;
            this._list.UseCompatibleStateImageBehavior = false;
            this._list.View = System.Windows.Forms.View.Details;
            // 
            // _colSeverity
            // 
            this._colSeverity.Text = "Severity";
            this._colSeverity.Width = 64;
            // 
            // _colMessage
            // 
            this._colMessage.Text = "Message";
            this._colMessage.Width = 256;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Error");
            this.imageList1.Images.SetKeyName(1, "Cancelled");
            this.imageList1.Images.SetKeyName(2, "Critical");
            this.imageList1.Images.SetKeyName(3, "Info");
            this.imageList1.Images.SetKeyName(4, "Warning");
            // 
            // _colCount
            // 
            this._colCount.Text = "Count";
            this._colCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._colCount.Width = 64;
            // 
            // ErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._list);
            this.Name = "ErrorList";
            this.Size = new System.Drawing.Size(396, 230);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _list;
        private System.Windows.Forms.ColumnHeader _colSeverity;
        private System.Windows.Forms.ColumnHeader _colMessage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader _colCount;
    }
}
