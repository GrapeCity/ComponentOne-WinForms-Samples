namespace ControlExplorer.Chart
{
    partial class ChartEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartEditor));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.categorySales1 = new ControlExplorer.Chart.CategorySales();
            this.c1ToolBar1 = new C1.Win.C1Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1Command_ChartWizard = new C1.Win.C1Command.C1Command();
            this.c1Command_ChartType = new C1.Win.C1Command.C1Command();
            this.c1Command_ChartProperties = new C1.Win.C1Command.C1Command();
            this.c1Command_DataBinding = new C1.Win.C1Command.C1Command();
            this.c1Command_VisualEffects = new C1.Win.C1Command.C1Command();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.DataSource = this.categorySales1;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(0, 24);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(592, 422);
            this.c1Chart1.TabIndex = 1;
            // 
            // categorySales1
            // 
            this.categorySales1.Position = 0;
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.ButtonLookHorz = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink2,
            this.c1CommandLink1,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5});
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
            this.c1CommandHolder1.Commands.Add(this.c1Command_ChartWizard);
            this.c1CommandHolder1.Commands.Add(this.c1Command_ChartType);
            this.c1CommandHolder1.Commands.Add(this.c1Command_ChartProperties);
            this.c1CommandHolder1.Commands.Add(this.c1Command_DataBinding);
            this.c1CommandHolder1.Commands.Add(this.c1Command_VisualEffects);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // c1Command_ChartWizard
            // 
            this.c1Command_ChartWizard.Image = global::ControlExplorer.Properties.Resources.ChartWizard;
            this.c1Command_ChartWizard.Name = "c1Command_ChartWizard";
            this.c1Command_ChartWizard.Text = "Wizard...";
            // 
            // c1Command_ChartType
            // 
            this.c1Command_ChartType.Image = global::ControlExplorer.Properties.Resources.Chart;
            this.c1Command_ChartType.Name = "c1Command_ChartType";
            this.c1Command_ChartType.Text = "Chart Type...";
            // 
            // c1Command_ChartProperties
            // 
            this.c1Command_ChartProperties.Image = global::ControlExplorer.Properties.Resources.Properties;
            this.c1Command_ChartProperties.Name = "c1Command_ChartProperties";
            this.c1Command_ChartProperties.Text = "Chart Properties...";
            // 
            // c1Command_DataBinding
            // 
            this.c1Command_DataBinding.Image = global::ControlExplorer.Properties.Resources.Database;
            this.c1Command_DataBinding.Name = "c1Command_DataBinding";
            this.c1Command_DataBinding.Text = "Data Binding...";
            // 
            // c1Command_VisualEffects
            // 
            this.c1Command_VisualEffects.Image = global::ControlExplorer.Properties.Resources.ColorGallery1;
            this.c1Command_VisualEffects.Name = "c1Command_VisualEffects";
            this.c1Command_VisualEffects.Text = "Visual Effects...";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.c1Command_ChartWizard;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.c1Command_ChartType;
            this.c1CommandLink1.SortOrder = 1;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.c1Command_ChartProperties;
            this.c1CommandLink3.SortOrder = 2;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command_DataBinding;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1Command_VisualEffects;
            this.c1CommandLink5.SortOrder = 4;
            // 
            // ChartEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.c1ToolBar1);
            this.Name = "ChartEditor";
            this.Text = "ChartEditor";
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySales1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Chart.C1Chart c1Chart1;
        private CategorySales categorySales1;
        private C1.Win.C1Command.C1ToolBar c1ToolBar1;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1Command c1Command_ChartWizard;
        private C1.Win.C1Command.C1Command c1Command_ChartType;
        private C1.Win.C1Command.C1Command c1Command_ChartProperties;
        private C1.Win.C1Command.C1Command c1Command_DataBinding;
        private C1.Win.C1Command.C1Command c1Command_VisualEffects;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
    }
}