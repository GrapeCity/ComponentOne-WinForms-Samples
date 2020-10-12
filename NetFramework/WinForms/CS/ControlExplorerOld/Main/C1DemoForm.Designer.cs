namespace ControlExplorer
{
    partial class C1DemoForm
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
            DeleteTempFile();
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
            this.components = new System.ComponentModel.Container();
            C1.Win.TouchToolKit.ComboBoxZoomPolicy comboBoxZoomPolicy1 = new C1.Win.TouchToolKit.ComboBoxZoomPolicy();
            C1.Win.TouchToolKit.DataGridViewZoomPolicy dataGridViewZoomPolicy1 = new C1.Win.TouchToolKit.DataGridViewZoomPolicy();
            C1.Win.TouchToolKit.FlowLayoutPanelZoomPolicy flowLayoutPanelZoomPolicy1 = new C1.Win.TouchToolKit.FlowLayoutPanelZoomPolicy();
            C1.Win.TouchToolKit.ListBoxZoomPolicy listBoxZoomPolicy1 = new C1.Win.TouchToolKit.ListBoxZoomPolicy();
            C1.Win.TouchToolKit.ListViewZoomPolicy listViewZoomPolicy1 = new C1.Win.TouchToolKit.ListViewZoomPolicy();
            C1.Win.TouchToolKit.MonthCalendarZoomPolicy monthCalendarZoomPolicy1 = new C1.Win.TouchToolKit.MonthCalendarZoomPolicy();
            C1.Win.TouchToolKit.PictureBoxZoomPolicy pictureBoxZoomPolicy1 = new C1.Win.TouchToolKit.PictureBoxZoomPolicy();
            C1.Win.TouchToolKit.PropertyGridZoomPolicy propertyGridZoomPolicy1 = new C1.Win.TouchToolKit.PropertyGridZoomPolicy();
            C1.Win.TouchToolKit.ScrollableControlZoomPolicy scrollableControlZoomPolicy1 = new C1.Win.TouchToolKit.ScrollableControlZoomPolicy();
            C1.Win.TouchToolKit.SplitContainerZoomPolicy splitContainerZoomPolicy1 = new C1.Win.TouchToolKit.SplitContainerZoomPolicy();
            C1.Win.TouchToolKit.TableLayoutPanelZoomPolicy tableLayoutPanelZoomPolicy1 = new C1.Win.TouchToolKit.TableLayoutPanelZoomPolicy();
            C1.Win.TouchToolKit.ToolStripZoomPolicy toolStripZoomPolicy1 = new C1.Win.TouchToolKit.ToolStripZoomPolicy();
            C1.Win.TouchToolKit.TreeViewZoomPolicy treeViewZoomPolicy1 = new C1.Win.TouchToolKit.TreeViewZoomPolicy();
            ControlExplorer.ZoomPolicies.C1CalendarZoomPolicy c1CalendarZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1CalendarZoomPolicy();
            ControlExplorer.ZoomPolicies.C1Chart3DZoomPolicy c1Chart3DZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1Chart3DZoomPolicy();
            ControlExplorer.ZoomPolicies.C1ChartZoomPolicy c1ChartZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1ChartZoomPolicy();
            ControlExplorer.ZoomPolicies.C1DockingTabZoomPolicy c1DockingTabZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1DockingTabZoomPolicy();
            ControlExplorer.ZoomPolicies.C1FlexGridZoomPolicy c1FlexGridZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1FlexGridZoomPolicy();
            ControlExplorer.ZoomPolicies.C1InputPanelZoomPolicy c1InputPanelZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1InputPanelZoomPolicy();
            ControlExplorer.ZoomPolicies.C1MainMenuZoomPolicy c1MainMenuZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1MainMenuZoomPolicy();
            ControlExplorer.ZoomPolicies.C1NavBarZoomPolicy c1NavBarZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1NavBarZoomPolicy();
            ControlExplorer.ZoomPolicies.C1OutBarZoomPolicy c1OutBarZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1OutBarZoomPolicy();
            ControlExplorer.ZoomPolicies.C1PreviewPaneZoomPolicy c1PreviewPaneZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1PreviewPaneZoomPolicy();
            ControlExplorer.ZoomPolicies.C1PrintPreviewControlZoomPolicy c1PrintPreviewControlZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1PrintPreviewControlZoomPolicy();
            ControlExplorer.ZoomPolicies.C1ScheduleZoomPolicy c1ScheduleZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1ScheduleZoomPolicy();
            ControlExplorer.ZoomPolicies.C1TileControlZoomPolicy c1TileControlZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1TileControlZoomPolicy();
            ControlExplorer.ZoomPolicies.C1TDBDropDownZoomPolicy c1TDBDropDownZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1TDBDropDownZoomPolicy();
            ControlExplorer.ZoomPolicies.C1TrueDBGridZoomPolicy c1TrueDBGridZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1TrueDBGridZoomPolicy();
            ControlExplorer.ZoomPolicies.C1BarcodeZoomPolicy c1BarCodeZoomPolicy1 = new ControlExplorer.ZoomPolicies.C1BarcodeZoomPolicy();
            this.c1Zoom1 = new C1.Win.TouchToolKit.C1Zoom(this.components);
            this.SuspendLayout();
            // 
            // c1Zoom1
            // 
            this.c1Zoom1.AllowDoubleTapZoom = true;
            this.c1Zoom1.AllowMouseWheelZoom = true;
            this.c1Zoom1.Target = this;
            this.c1Zoom1.ZoomFactor = 1F;
            this.c1Zoom1.ZoomPolicies.Add(comboBoxZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(dataGridViewZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(flowLayoutPanelZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(listBoxZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(listViewZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(monthCalendarZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(pictureBoxZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(propertyGridZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(scrollableControlZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(splitContainerZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(tableLayoutPanelZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(toolStripZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(treeViewZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1CalendarZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1Chart3DZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1ChartZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1DockingTabZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1FlexGridZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1InputPanelZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1MainMenuZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1NavBarZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1OutBarZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1PreviewPaneZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1PrintPreviewControlZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1ScheduleZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1TileControlZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1TDBDropDownZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1BarCodeZoomPolicy1);
            this.c1Zoom1.ZoomPolicies.Add(c1TrueDBGridZoomPolicy1);
            // 
            // C1DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 549);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "C1DemoForm";
            this.Text = "C1DemoForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected C1.Win.TouchToolKit.C1Zoom c1Zoom1;

    }
}