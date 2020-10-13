namespace QuickStart
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowErrors = new System.Windows.Forms.Button();
            this.btnSpellDialog = new System.Windows.Forms.Button();
            this.btnAsYouType = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRichTextBox = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZoom = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAsYouTypeRich = new System.Windows.Forms.CheckBox();
            this.btnSpellDialogRich = new System.Windows.Forms.Button();
            this.btnShowErrorsRich = new System.Windows.Forms.Button();
            this.tpTextBox = new System.Windows.Forms.TabPage();
            this.btnFont = new System.Windows.Forms.Button();
            this.tpGrid = new System.Windows.Forms.TabPage();
            this.btnSpellDialogGrid = new System.Windows.Forms.Button();
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._spell = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tpRichTextBox.SuspendLayout();
            this.tpTextBox.SuspendLayout();
            this.tpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spell)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(720, 465);
            this.textBox1.TabIndex = 4;
            // 
            // btnShowErrors
            // 
            this.btnShowErrors.Location = new System.Drawing.Point(326, 9);
            this.btnShowErrors.Name = "btnShowErrors";
            this.btnShowErrors.Size = new System.Drawing.Size(154, 30);
            this.btnShowErrors.TabIndex = 2;
            this.btnShowErrors.Text = "Show Error List";
            this.toolTip1.SetToolTip(this.btnShowErrors, "Use the CheckText method to collect all errors, then show them in a grid.");
            this.btnShowErrors.UseVisualStyleBackColor = true;
            this.btnShowErrors.Click += new System.EventHandler(this.btnShowErrors_Click);
            // 
            // btnSpellDialog
            // 
            this.btnSpellDialog.Location = new System.Drawing.Point(166, 9);
            this.btnSpellDialog.Name = "btnSpellDialog";
            this.btnSpellDialog.Size = new System.Drawing.Size(154, 30);
            this.btnSpellDialog.TabIndex = 1;
            this.btnSpellDialog.Text = "Check with Dialog";
            this.toolTip1.SetToolTip(this.btnSpellDialog, "Spell-check the entire control using a modal dialog.");
            this.btnSpellDialog.UseVisualStyleBackColor = true;
            this.btnSpellDialog.Click += new System.EventHandler(this.btnSpellDialog_Click);
            // 
            // btnAsYouType
            // 
            this.btnAsYouType.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAsYouType.Location = new System.Drawing.Point(6, 9);
            this.btnAsYouType.Name = "btnAsYouType";
            this.btnAsYouType.Size = new System.Drawing.Size(154, 30);
            this.btnAsYouType.TabIndex = 0;
            this.btnAsYouType.Text = "Check As You Type";
            this.btnAsYouType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnAsYouType, "Toggle \'as-you-type\' spell checking (underline errors and provide suggestions in " +
                    "context menu)");
            this.btnAsYouType.UseVisualStyleBackColor = true;
            this.btnAsYouType.CheckedChanged += new System.EventHandler(this.btnAsYouType_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRichTextBox);
            this.tabControl1.Controls.Add(this.tpTextBox);
            this.tabControl1.Controls.Add(this.tpGrid);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tpRichTextBox
            // 
            this.tpRichTextBox.Controls.Add(this.label1);
            this.tpRichTextBox.Controls.Add(this.cmbZoom);
            this.tpRichTextBox.Controls.Add(this.richTextBox1);
            this.tpRichTextBox.Controls.Add(this.btnAsYouTypeRich);
            this.tpRichTextBox.Controls.Add(this.btnSpellDialogRich);
            this.tpRichTextBox.Controls.Add(this.btnShowErrorsRich);
            this.tpRichTextBox.Location = new System.Drawing.Point(4, 22);
            this.tpRichTextBox.Name = "tpRichTextBox";
            this.tpRichTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.tpRichTextBox.Size = new System.Drawing.Size(730, 518);
            this.tpRichTextBox.TabIndex = 1;
            this.tpRichTextBox.Text = "RichTextBox";
            this.tpRichTextBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Zoom";
            // 
            // cmbZoom
            // 
            this.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZoom.FormattingEnabled = true;
            this.cmbZoom.Items.AddRange(new object[] {
            "50%",
            "75%",
            "100%",
            "150%",
            "200%"});
            this.cmbZoom.Location = new System.Drawing.Point(548, 15);
            this.cmbZoom.Name = "cmbZoom";
            this.cmbZoom.Size = new System.Drawing.Size(108, 21);
            this.cmbZoom.TabIndex = 4;
            this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(715, 465);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnAsYouTypeRich
            // 
            this.btnAsYouTypeRich.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAsYouTypeRich.Location = new System.Drawing.Point(8, 9);
            this.btnAsYouTypeRich.Name = "btnAsYouTypeRich";
            this.btnAsYouTypeRich.Size = new System.Drawing.Size(154, 30);
            this.btnAsYouTypeRich.TabIndex = 0;
            this.btnAsYouTypeRich.Text = "Check As You Type";
            this.btnAsYouTypeRich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.btnAsYouTypeRich, "Toggle \'as-you-type\' spell checking (underline errors and provide suggestions in " +
                    "context menu)");
            this.btnAsYouTypeRich.UseVisualStyleBackColor = true;
            this.btnAsYouTypeRich.CheckedChanged += new System.EventHandler(this.btnAsYouTypeRich_CheckedChanged);
            // 
            // btnSpellDialogRich
            // 
            this.btnSpellDialogRich.Location = new System.Drawing.Point(167, 9);
            this.btnSpellDialogRich.Name = "btnSpellDialogRich";
            this.btnSpellDialogRich.Size = new System.Drawing.Size(154, 30);
            this.btnSpellDialogRich.TabIndex = 1;
            this.btnSpellDialogRich.Text = "Check with Dialog";
            this.toolTip1.SetToolTip(this.btnSpellDialogRich, "Spell-check the entire control using a modal dialog.");
            this.btnSpellDialogRich.UseVisualStyleBackColor = true;
            this.btnSpellDialogRich.Click += new System.EventHandler(this.btnSpellDialogRich_Click);
            // 
            // btnShowErrorsRich
            // 
            this.btnShowErrorsRich.Location = new System.Drawing.Point(327, 9);
            this.btnShowErrorsRich.Name = "btnShowErrorsRich";
            this.btnShowErrorsRich.Size = new System.Drawing.Size(154, 30);
            this.btnShowErrorsRich.TabIndex = 2;
            this.btnShowErrorsRich.Text = "Show Error List";
            this.toolTip1.SetToolTip(this.btnShowErrorsRich, "Use the CheckText method to collect all errors, then show them in a grid.");
            this.btnShowErrorsRich.UseVisualStyleBackColor = true;
            this.btnShowErrorsRich.Click += new System.EventHandler(this.btnShowErrorsRich_Click);
            // 
            // tpTextBox
            // 
            this.tpTextBox.Controls.Add(this.btnAsYouType);
            this.tpTextBox.Controls.Add(this.textBox1);
            this.tpTextBox.Controls.Add(this.btnFont);
            this.tpTextBox.Controls.Add(this.btnSpellDialog);
            this.tpTextBox.Controls.Add(this.btnShowErrors);
            this.tpTextBox.Location = new System.Drawing.Point(4, 22);
            this.tpTextBox.Name = "tpTextBox";
            this.tpTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.tpTextBox.Size = new System.Drawing.Size(735, 518);
            this.tpTextBox.TabIndex = 0;
            this.tpTextBox.Text = "TextBox";
            this.tpTextBox.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(510, 9);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(104, 30);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // tpGrid
            // 
            this.tpGrid.Controls.Add(this.btnSpellDialogGrid);
            this.tpGrid.Controls.Add(this._flex);
            this.tpGrid.Location = new System.Drawing.Point(4, 22);
            this.tpGrid.Name = "tpGrid";
            this.tpGrid.Size = new System.Drawing.Size(735, 518);
            this.tpGrid.TabIndex = 2;
            this.tpGrid.Text = "C1FlexGrid";
            this.tpGrid.UseVisualStyleBackColor = true;
            // 
            // btnSpellDialogGrid
            // 
            this.btnSpellDialogGrid.Location = new System.Drawing.Point(8, 9);
            this.btnSpellDialogGrid.Name = "btnSpellDialogGrid";
            this.btnSpellDialogGrid.Size = new System.Drawing.Size(154, 30);
            this.btnSpellDialogGrid.TabIndex = 2;
            this.btnSpellDialogGrid.Text = "Check with Dialog";
            this.toolTip1.SetToolTip(this.btnSpellDialogGrid, "Spell-check the entire control using a modal dialog.");
            this.btnSpellDialogGrid.UseVisualStyleBackColor = true;
            this.btnSpellDialogGrid.Click += new System.EventHandler(this.btnSpellDialogGrid_Click);
            // 
            // _flex
            // 
            this._flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            this._flex.Location = new System.Drawing.Point(5, 45);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(722, 465);
            this._flex.TabIndex = 0;
            this._flex.UseCompatibleTextRendering = false;
            // 
            // _spell
            // 
            this._spell.MainDictionary.Password = "foozebar";
            this._spell.UserDictionary.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SpellChecker: QuickStart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRichTextBox.ResumeLayout(false);
            this.tpRichTextBox.PerformLayout();
            this.tpTextBox.ResumeLayout(false);
            this.tpTextBox.PerformLayout();
            this.tpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SpellChecker.C1SpellChecker _spell;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowErrors;
        private System.Windows.Forms.Button btnSpellDialog;
        private System.Windows.Forms.CheckBox btnAsYouType;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTextBox;
        private System.Windows.Forms.TabPage tpRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox btnAsYouTypeRich;
        private System.Windows.Forms.Button btnSpellDialogRich;
        private System.Windows.Forms.Button btnShowErrorsRich;
        private System.Windows.Forms.ComboBox cmbZoom;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpGrid;
        private System.Windows.Forms.Button btnSpellDialogGrid;
        private C1.Win.C1FlexGrid.C1FlexGrid _flex;
    }
}

