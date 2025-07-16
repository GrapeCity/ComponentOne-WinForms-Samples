namespace ControlExplorer
{
    partial class C1DemoViewer
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
            this.panelDemo = new System.Windows.Forms.Panel();
            this.panelProperties = new System.Windows.Forms.Panel();
            this.c1CommandDock2 = new C1.Win.Command.C1CommandDock();
            this.c1DockingTab_Properties = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage_Properties = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTab_Demo = new C1.Win.Command.C1DockingTab();
            this.c1DockingTabPage_Demo = new C1.Win.Command.C1DockingTabPage();
            this.c1DockingTabPage_Code = new C1.Win.Command.C1DockingTabPage();
            this.c1CodeViewer1 = new ControlExplorer.Main.C1CodeViewer();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).BeginInit();
            this.c1CommandDock2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Properties)).BeginInit();
            this.c1DockingTab_Properties.SuspendLayout();
            this.c1DockingTabPage_Properties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Demo)).BeginInit();
            this.c1DockingTab_Demo.SuspendLayout();
            this.c1DockingTabPage_Demo.SuspendLayout();
            this.c1DockingTabPage_Code.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDemo
            // 
            this.panelDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDemo.Location = new System.Drawing.Point(0, 0);
            this.panelDemo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelDemo.Name = "panelDemo";
            this.panelDemo.Size = new System.Drawing.Size(321, 375);
            this.panelDemo.TabIndex = 1;
            // 
            // panelProperties
            // 
            this.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelProperties.Location = new System.Drawing.Point(0, 26);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(213, 375);
            this.panelProperties.TabIndex = 0;
            // 
            // c1CommandDock2
            // 
            this.c1CommandDock2.Controls.Add(this.c1DockingTab_Properties);
            this.c1CommandDock2.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1CommandDock2.DockingStyle = C1.Win.Command.DockingStyle.VS2012;
            this.c1CommandDock2.Id = 3;
            this.c1CommandDock2.Location = new System.Drawing.Point(321, 0);
            this.c1CommandDock2.Name = "c1CommandDock2";
            this.c1CommandDock2.Size = new System.Drawing.Size(216, 402);
            // 
            // c1DockingTab_Properties
            // 
            this.c1DockingTab_Properties.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab_Properties.AutoHiding = true;
            this.c1DockingTab_Properties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab_Properties.CanAutoHide = true;
            this.c1DockingTab_Properties.Controls.Add(this.c1DockingTabPage_Properties);
            this.c1DockingTab_Properties.HotTrack = true;
            this.c1DockingTab_Properties.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab_Properties.Name = "c1DockingTab_Properties";
            this.c1DockingTab_Properties.ShowCaption = true;
            this.c1DockingTab_Properties.ShowSingleTab = false;
            this.c1DockingTab_Properties.Size = new System.Drawing.Size(216, 402);
            this.c1DockingTab_Properties.TabIndex = 0;
            this.c1DockingTab_Properties.TabLook = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this.c1DockingTab_Properties.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            // 
            // c1DockingTabPage_Properties
            // 
            this.c1DockingTabPage_Properties.CaptionVisible = true;
            this.c1DockingTabPage_Properties.Controls.Add(this.panelProperties);
            this.c1DockingTabPage_Properties.Image = global::ControlExplorer.Properties.Resources.Properties;
            this.c1DockingTabPage_Properties.Location = new System.Drawing.Point(3, 0);
            this.c1DockingTabPage_Properties.Name = "c1DockingTabPage_Properties";
            this.c1DockingTabPage_Properties.Size = new System.Drawing.Size(213, 401);
            this.c1DockingTabPage_Properties.TabIndex = 0;
            this.c1DockingTabPage_Properties.Text = "Properties";
            // 
            // c1DockingTab_Demo
            // 
            this.c1DockingTab_Demo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab_Demo.Controls.Add(this.c1DockingTabPage_Demo);
            this.c1DockingTab_Demo.Controls.Add(this.c1DockingTabPage_Code);
            this.c1DockingTab_Demo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DockingTab_Demo.HotTrack = true;
            this.c1DockingTab_Demo.Indent = 6;
            this.c1DockingTab_Demo.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab_Demo.Name = "c1DockingTab_Demo";
            this.c1DockingTab_Demo.Padding = new System.Drawing.Point(2, 2);
            this.c1DockingTab_Demo.Size = new System.Drawing.Size(321, 402);
            this.c1DockingTab_Demo.SplitterWidth = 5;
            this.c1DockingTab_Demo.TabAreaSpacing = 5;
            this.c1DockingTab_Demo.TabIndex = 4;
            this.c1DockingTab_Demo.TabLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1DockingTab_Demo.TabStyle = C1.Win.Command.TabStyleEnum.Office2010;
            this.c1DockingTab_Demo.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            this.c1DockingTab_Demo.SelectedIndexChanged += new System.EventHandler(this.c1DockingTab1_SelectedIndexChanged);
            // 
            // c1DockingTabPage_Demo
            // 
            this.c1DockingTabPage_Demo.Controls.Add(this.panelDemo);
            this.c1DockingTabPage_Demo.Location = new System.Drawing.Point(0, 27);
            this.c1DockingTabPage_Demo.Name = "c1DockingTabPage_Demo";
            this.c1DockingTabPage_Demo.Size = new System.Drawing.Size(321, 375);
            this.c1DockingTabPage_Demo.TabIndex = 0;
            this.c1DockingTabPage_Demo.Text = "View Demo";
            // 
            // c1DockingTabPage_Code
            // 
            this.c1DockingTabPage_Code.Controls.Add(this.c1CodeViewer1);
            this.c1DockingTabPage_Code.Location = new System.Drawing.Point(0, 27);
            this.c1DockingTabPage_Code.Name = "c1DockingTabPage_Code";
            this.c1DockingTabPage_Code.Size = new System.Drawing.Size(321, 375);
            this.c1DockingTabPage_Code.TabIndex = 1;
            this.c1DockingTabPage_Code.Text = "View Code";
            // 
            // c1CodeViewer1
            // 
            this.c1CodeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1CodeViewer1.Location = new System.Drawing.Point(0, 0);
            this.c1CodeViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.c1CodeViewer1.Name = "c1CodeViewer1";
            this.c1CodeViewer1.Size = new System.Drawing.Size(321, 375);
            this.c1CodeViewer1.TabIndex = 0;
            // 
            // C1DemoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.c1DockingTab_Demo);
            this.Controls.Add(this.c1CommandDock2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "C1DemoViewer";
            this.Size = new System.Drawing.Size(537, 402);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).EndInit();
            this.c1CommandDock2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Properties)).EndInit();
            this.c1DockingTab_Properties.ResumeLayout(false);
            this.c1DockingTabPage_Properties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab_Demo)).EndInit();
            this.c1DockingTab_Demo.ResumeLayout(false);
            this.c1DockingTabPage_Demo.ResumeLayout(false);
            this.c1DockingTabPage_Code.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDemo;
        private System.Windows.Forms.Panel panelProperties;
        private C1.Win.Command.C1CommandDock c1CommandDock2;
        private C1.Win.Command.C1DockingTab c1DockingTab_Properties;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage_Properties;
        private Main.C1CodeViewer c1CodeViewer1;
        private C1.Win.Command.C1DockingTab c1DockingTab_Demo;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage_Demo;
        private C1.Win.Command.C1DockingTabPage c1DockingTabPage_Code;

    }
}
