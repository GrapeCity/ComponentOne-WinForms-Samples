namespace ControlExplorer.FlexGrid
{
    partial class ColumnContextMenu
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
            this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.pageRules = new C1.Win.C1Command.C1DockingTabPage();
            this.c1RulesManager1 = new C1.Win.RulesManager.C1RulesManager();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRulesClear = new C1.Win.C1Input.C1Button();
            this.btnRulesOk = new C1.Win.C1Input.C1Button();
            this.btnRulesCancel = new C1.Win.C1Input.C1Button();
            this.pageFilter = new C1.Win.C1Command.C1DockingTabPage();
            this.c1FilterEditor1 = new C1.Win.DataFilter.C1FilterEditor();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFilterClear = new C1.Win.C1Input.C1Button();
            this.btnFilterOk = new C1.Win.C1Input.C1Button();
            this.btnFilterCancel = new C1.Win.C1Input.C1Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.pageRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1RulesManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesCancel)).BeginInit();
            this.pageFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterCancel)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.AllowFloat = false;
            this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
            this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1CommandDock1.Id = 1;
            this.c1CommandDock1.Location = new System.Drawing.Point(692, 0);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(300, 567);
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab1.CanCloseTabs = true;
            this.c1DockingTab1.Controls.Add(this.pageRules);
            this.c1DockingTab1.Controls.Add(this.pageFilter);
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.SelectedIndex = 1;
            this.c1DockingTab1.ShowCaption = true;
            this.c1DockingTab1.ShowSingleTab = false;
            this.c1DockingTab1.ShowTabs = false;
            this.c1DockingTab1.Size = new System.Drawing.Size(300, 567);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.c1DockingTab1.TabsShowFocusCues = false;
            this.c1DockingTab1.Visible = false;
            // 
            // pageRules
            // 
            this.pageRules.CaptionVisible = true;
            this.pageRules.CloseTabBehavior = C1.Win.C1Command.CloseTabBehavior.Hide;
            this.pageRules.Controls.Add(this.c1RulesManager1);
            this.pageRules.Controls.Add(this.panel1);
            this.pageRules.Location = new System.Drawing.Point(3, 0);
            this.pageRules.Name = "pageRules";
            this.pageRules.Size = new System.Drawing.Size(297, 566);
            this.pageRules.TabIndex = 0;
            this.pageRules.Text = "Edit Rules";
            // 
            // c1RulesManager1
            // 
            this.c1RulesManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1RulesManager1.Location = new System.Drawing.Point(0, 24);
            this.c1RulesManager1.Name = "c1RulesManager1";
            this.c1RulesManager1.Size = new System.Drawing.Size(297, 512);
            this.c1RulesManager1.TabIndex = 1;
            this.c1RulesManager1.Text = "c1RulesManager1";
            // 
            // c1FlexGrid1
            // 
            this.c1RulesManager1.SetC1RulesManager(this.c1FlexGrid1, this.c1RulesManager1);
            this.c1FlexGrid1.ColumnContextMenuEnabled = true;
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 29);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(692, 538);
            this.c1FlexGrid1.TabIndex = 4;
            this.c1FlexGrid1.ColumnContextMenuOpening += new System.EventHandler<C1.Win.C1FlexGrid.ColumnContextMenuOpeningEventArgs>(this.c1FlexGrid1_ColumnContextMenuOpening);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRulesClear);
            this.panel1.Controls.Add(this.btnRulesOk);
            this.panel1.Controls.Add(this.btnRulesCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnRulesClear
            // 
            this.btnRulesClear.Location = new System.Drawing.Point(3, 3);
            this.btnRulesClear.Name = "btnRulesClear";
            this.btnRulesClear.Size = new System.Drawing.Size(75, 23);
            this.btnRulesClear.TabIndex = 2;
            this.btnRulesClear.Text = "Clear";
            this.btnRulesClear.UseVisualStyleBackColor = true;
            this.btnRulesClear.Click += new System.EventHandler(this.btnRulesClear_Click);
            // 
            // btnRulesOk
            // 
            this.btnRulesOk.Location = new System.Drawing.Point(138, 3);
            this.btnRulesOk.Name = "btnRulesOk";
            this.btnRulesOk.Size = new System.Drawing.Size(75, 23);
            this.btnRulesOk.TabIndex = 1;
            this.btnRulesOk.Text = "Ok";
            this.btnRulesOk.UseVisualStyleBackColor = true;
            this.btnRulesOk.Click += new System.EventHandler(this.btnRulesOk_Click);
            // 
            // btnRulesCancel
            // 
            this.btnRulesCancel.Location = new System.Drawing.Point(219, 3);
            this.btnRulesCancel.Name = "btnRulesCancel";
            this.btnRulesCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRulesCancel.TabIndex = 0;
            this.btnRulesCancel.Text = "Cancel";
            this.btnRulesCancel.UseVisualStyleBackColor = true;
            this.btnRulesCancel.Click += new System.EventHandler(this.btnRulesCancel_Click);
            // 
            // pageFilter
            // 
            this.pageFilter.CaptionVisible = true;
            this.pageFilter.CloseTabBehavior = C1.Win.C1Command.CloseTabBehavior.Hide;
            this.pageFilter.Controls.Add(this.c1FilterEditor1);
            this.pageFilter.Controls.Add(this.panel2);
            this.pageFilter.Location = new System.Drawing.Point(3, 0);
            this.pageFilter.Name = "pageFilter";
            this.pageFilter.Size = new System.Drawing.Size(297, 566);
            this.pageFilter.TabIndex = 1;
            this.pageFilter.Text = "Edit Filter";
            // 
            // c1FilterEditor1
            // 
            this.c1FilterEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FilterEditor1.Location = new System.Drawing.Point(0, 24);
            this.c1FilterEditor1.Name = "c1FilterEditor1";
            this.c1FilterEditor1.Size = new System.Drawing.Size(297, 512);
            this.c1FilterEditor1.TabIndex = 2;
            this.c1FilterEditor1.Text = "c1FilterEditor1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFilterClear);
            this.panel2.Controls.Add(this.btnFilterOk);
            this.panel2.Controls.Add(this.btnFilterCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 30);
            this.panel2.TabIndex = 1;
            // 
            // btnFilterClear
            // 
            this.btnFilterClear.Location = new System.Drawing.Point(3, 3);
            this.btnFilterClear.Name = "btnFilterClear";
            this.btnFilterClear.Size = new System.Drawing.Size(75, 23);
            this.btnFilterClear.TabIndex = 2;
            this.btnFilterClear.Text = "Clear";
            this.btnFilterClear.UseVisualStyleBackColor = true;
            this.btnFilterClear.Click += new System.EventHandler(this.btnFilterClear_Click);
            // 
            // btnFilterOk
            // 
            this.btnFilterOk.Location = new System.Drawing.Point(138, 3);
            this.btnFilterOk.Name = "btnFilterOk";
            this.btnFilterOk.Size = new System.Drawing.Size(75, 23);
            this.btnFilterOk.TabIndex = 1;
            this.btnFilterOk.Text = "Ok";
            this.btnFilterOk.UseVisualStyleBackColor = true;
            this.btnFilterOk.Click += new System.EventHandler(this.btnFilterOk_Click);
            // 
            // btnFilterCancel
            // 
            this.btnFilterCancel.Location = new System.Drawing.Point(219, 3);
            this.btnFilterCancel.Name = "btnFilterCancel";
            this.btnFilterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFilterCancel.TabIndex = 0;
            this.btnFilterCancel.Text = "Cancel";
            this.btnFilterCancel.UseVisualStyleBackColor = true;
            this.btnFilterCancel.Click += new System.EventHandler(this.btnFilterCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.c1Label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 29);
            this.panel3.TabIndex = 3;
            // 
            // c1Label1
            // 
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c1Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1Label1.Location = new System.Drawing.Point(0, 0);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Padding = new System.Windows.Forms.Padding(3);
            this.c1Label1.Size = new System.Drawing.Size(692, 29);
            this.c1Label1.TabIndex = 1;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Right-click on the column header to open the context menu.";
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1Label1.TextDetached = true;
            // 
            // ColumnContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 567);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.c1CommandDock1);
            this.Name = "ColumnContextMenu";
            this.Text = "ColumnContextMenu";
            this.Load += new System.EventHandler(this.ColumnContextMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.pageRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1RulesManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRulesCancel)).EndInit();
            this.pageFilter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilterCancel)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1CommandDock c1CommandDock1;
        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage pageRules;
        private C1.Win.C1Command.C1DockingTabPage pageFilter;
        private C1.Win.RulesManager.C1RulesManager c1RulesManager1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Button btnRulesClear;
        private C1.Win.C1Input.C1Button btnRulesOk;
        private C1.Win.C1Input.C1Button btnRulesCancel;
        private C1.Win.DataFilter.C1FilterEditor c1FilterEditor1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1Input.C1Button btnFilterClear;
        private C1.Win.C1Input.C1Button btnFilterOk;
        private C1.Win.C1Input.C1Button btnFilterCancel;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1Input.C1Label c1Label1;
    }
}