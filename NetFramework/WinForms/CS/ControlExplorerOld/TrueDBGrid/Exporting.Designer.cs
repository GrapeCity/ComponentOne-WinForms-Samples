namespace ControlExplorer.TrueDBGrid
{
    partial class Exporting
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exporting));
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1CommandExportPDF = new C1.Win.C1Command.C1Command();
            this.c1CommandExportHtml = new C1.Win.C1Command.C1Command();
            this.c1CommandExportRTF = new C1.Win.C1Command.C1Command();
            this.c1CommandExportExcel = new C1.Win.C1Command.C1Command();
            this.c1CommandPrintPreview = new C1.Win.C1Command.C1Command();
            this.c1CommandExport = new C1.Win.C1Command.C1Command();
            this.c1CommandExportCSV = new C1.Win.C1Command.C1Command();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink7});
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(592, 24);
            this.c1ToolBar1.Text = "c1ToolBar1";
            this.c1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1CommandExportPDF);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExportHtml);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExportRTF);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExportExcel);
            this.c1CommandHolder1.Commands.Add(this.c1CommandPrintPreview);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExport);
            this.c1CommandHolder1.Commands.Add(this.c1CommandExportCSV);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // c1CommandExportPDF
            // 
            this.c1CommandExportPDF.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExportPDF.Image")));
            this.c1CommandExportPDF.Name = "c1CommandExportPDF";
            this.c1CommandExportPDF.Text = "PDF";
            // 
            // c1CommandExportHtml
            // 
            this.c1CommandExportHtml.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExportHtml.Image")));
            this.c1CommandExportHtml.Name = "c1CommandExportHtml";
            this.c1CommandExportHtml.Text = "Html";
            // 
            // c1CommandExportRTF
            // 
            this.c1CommandExportRTF.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExportRTF.Image")));
            this.c1CommandExportRTF.Name = "c1CommandExportRTF";
            this.c1CommandExportRTF.Text = "Rich Text";
            // 
            // c1CommandExportExcel
            // 
            this.c1CommandExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExportExcel.Image")));
            this.c1CommandExportExcel.Name = "c1CommandExportExcel";
            this.c1CommandExportExcel.Text = "Excel";
            // 
            // c1CommandPrintPreview
            // 
            this.c1CommandPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandPrintPreview.Image")));
            this.c1CommandPrintPreview.Name = "c1CommandPrintPreview";
            this.c1CommandPrintPreview.Text = "Print Preview";
            // 
            // c1CommandExport
            // 
            this.c1CommandExport.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExport.Image")));
            this.c1CommandExport.Name = "c1CommandExport";
            this.c1CommandExport.Text = "Export Options";
            // 
            // c1CommandExportCSV
            // 
            this.c1CommandExportCSV.Image = ((System.Drawing.Image)(resources.GetObject("c1CommandExportCSV.Image")));
            this.c1CommandExportCSV.Name = "c1CommandExportCSV";
            this.c1CommandExportCSV.Text = "Delimited Text";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink5.Command = this.c1CommandPrintPreview;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink6.Command = this.c1CommandExport;
            this.c1CommandLink6.Delimiter = true;
            this.c1CommandLink6.SortOrder = 1;
            this.c1CommandLink6.Text = "Export To...";
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink1.Command = this.c1CommandExportPDF;
            this.c1CommandLink1.SortOrder = 2;
            this.c1CommandLink1.Text = "PDF";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink2.Command = this.c1CommandExportHtml;
            this.c1CommandLink2.SortOrder = 3;
            this.c1CommandLink2.Text = "Html";
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink3.Command = this.c1CommandExportRTF;
            this.c1CommandLink3.SortOrder = 4;
            this.c1CommandLink3.Text = "Rich Text";
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink4.Command = this.c1CommandExportExcel;
            this.c1CommandLink4.SortOrder = 5;
            this.c1CommandLink4.Text = "Excel";
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.ButtonLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1CommandLink7.Command = this.c1CommandExportCSV;
            this.c1CommandLink7.SortOrder = 6;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 24);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RecordSelectorWidth = 20;
            this.c1TrueDBGrid1.RowHeight = 20;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(592, 422);
            this.c1TrueDBGrid1.TabIndex = 5;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            // 
            // Exporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.c1ToolBar1);
            this.Name = "Exporting";
            this.Text = "Exporting";
            this.Load += new System.EventHandler(this.Exporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1Command c1CommandExportPDF;
        private C1.Win.C1Command.C1Command c1CommandExportHtml;
        private C1.Win.C1Command.C1Command c1CommandExportRTF;
        private C1.Win.C1Command.C1Command c1CommandExportExcel;
        private C1.Win.C1Command.C1Command c1CommandPrintPreview;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
        private C1.Win.C1Command.C1Command c1CommandExport;
        private C1.Win.C1Command.C1CommandLink c1CommandLink6;
        private C1.Win.C1Command.C1Command c1CommandExportCSV;
        private C1.Win.C1Command.C1CommandLink c1CommandLink7;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;

    }
}