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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new System.Windows.Forms.TextBox();
            btnShowErrors = new System.Windows.Forms.Button();
            btnSpellDialog = new System.Windows.Forms.Button();
            btnAsYouType = new System.Windows.Forms.CheckBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tpRichTextBox = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            cmbZoom = new System.Windows.Forms.ComboBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            btnAsYouTypeRich = new System.Windows.Forms.CheckBox();
            btnSpellDialogRich = new System.Windows.Forms.Button();
            btnShowErrorsRich = new System.Windows.Forms.Button();
            tpTextBox = new System.Windows.Forms.TabPage();
            btnFont = new System.Windows.Forms.Button();
            tpGrid = new System.Windows.Forms.TabPage();
            btnSpellDialogGrid = new System.Windows.Forms.Button();
            _flex = new C1.Win.FlexGrid.C1FlexGrid();
            _spell = new C1.Win.SpellChecker.C1SpellChecker(components);
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tabControl1.SuspendLayout();
            tpRichTextBox.SuspendLayout();
            tpTextBox.SuspendLayout();
            tpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_flex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_spell).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox1.Location = new System.Drawing.Point(6, 52);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox1.Size = new System.Drawing.Size(839, 536);
            textBox1.TabIndex = 4;
            // 
            // btnShowErrors
            // 
            btnShowErrors.Location = new System.Drawing.Point(380, 10);
            btnShowErrors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShowErrors.Name = "btnShowErrors";
            btnShowErrors.Size = new System.Drawing.Size(180, 35);
            btnShowErrors.TabIndex = 2;
            btnShowErrors.Text = "Show Error List";
            toolTip1.SetToolTip(btnShowErrors, "Use the CheckText method to collect all errors, then show them in a grid.");
            btnShowErrors.UseVisualStyleBackColor = true;
            btnShowErrors.Click += btnShowErrors_Click;
            // 
            // btnSpellDialog
            // 
            btnSpellDialog.Location = new System.Drawing.Point(194, 10);
            btnSpellDialog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSpellDialog.Name = "btnSpellDialog";
            btnSpellDialog.Size = new System.Drawing.Size(180, 35);
            btnSpellDialog.TabIndex = 1;
            btnSpellDialog.Text = "Check with Dialog";
            toolTip1.SetToolTip(btnSpellDialog, "Spell-check the entire control using a modal dialog.");
            btnSpellDialog.UseVisualStyleBackColor = true;
            btnSpellDialog.Click += btnSpellDialog_Click;
            // 
            // btnAsYouType
            // 
            btnAsYouType.Appearance = System.Windows.Forms.Appearance.Button;
            btnAsYouType.Location = new System.Drawing.Point(7, 10);
            btnAsYouType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAsYouType.Name = "btnAsYouType";
            btnAsYouType.Size = new System.Drawing.Size(180, 35);
            btnAsYouType.TabIndex = 0;
            btnAsYouType.Text = "Check As You Type";
            btnAsYouType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(btnAsYouType, "Toggle 'as-you-type' spell checking (underline errors and provide suggestions in context menu)");
            btnAsYouType.UseVisualStyleBackColor = true;
            btnAsYouType.CheckedChanged += btnAsYouType_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpRichTextBox);
            tabControl1.Controls.Add(tpTextBox);
            tabControl1.Controls.Add(tpGrid);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(861, 628);
            tabControl1.TabIndex = 0;
            // 
            // tpRichTextBox
            // 
            tpRichTextBox.Controls.Add(label1);
            tpRichTextBox.Controls.Add(cmbZoom);
            tpRichTextBox.Controls.Add(richTextBox1);
            tpRichTextBox.Controls.Add(btnAsYouTypeRich);
            tpRichTextBox.Controls.Add(btnSpellDialogRich);
            tpRichTextBox.Controls.Add(btnShowErrorsRich);
            tpRichTextBox.Location = new System.Drawing.Point(4, 24);
            tpRichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpRichTextBox.Name = "tpRichTextBox";
            tpRichTextBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpRichTextBox.Size = new System.Drawing.Size(853, 600);
            tpRichTextBox.TabIndex = 1;
            tpRichTextBox.Text = "RichTextBox";
            tpRichTextBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(592, 21);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "&Zoom";
            // 
            // cmbZoom
            // 
            cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbZoom.FormattingEnabled = true;
            cmbZoom.Items.AddRange(new object[] { "50%", "75%", "100%", "150%", "200%" });
            cmbZoom.Location = new System.Drawing.Point(639, 17);
            cmbZoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbZoom.Name = "cmbZoom";
            cmbZoom.Size = new System.Drawing.Size(125, 23);
            cmbZoom.TabIndex = 4;
            cmbZoom.SelectedIndexChanged += cmbZoom_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(6, 52);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(834, 536);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // btnAsYouTypeRich
            // 
            btnAsYouTypeRich.Appearance = System.Windows.Forms.Appearance.Button;
            btnAsYouTypeRich.Location = new System.Drawing.Point(9, 10);
            btnAsYouTypeRich.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAsYouTypeRich.Name = "btnAsYouTypeRich";
            btnAsYouTypeRich.Size = new System.Drawing.Size(180, 35);
            btnAsYouTypeRich.TabIndex = 0;
            btnAsYouTypeRich.Text = "Check As You Type";
            btnAsYouTypeRich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(btnAsYouTypeRich, "Toggle 'as-you-type' spell checking (underline errors and provide suggestions in context menu)");
            btnAsYouTypeRich.UseVisualStyleBackColor = true;
            btnAsYouTypeRich.CheckedChanged += btnAsYouTypeRich_CheckedChanged;
            // 
            // btnSpellDialogRich
            // 
            btnSpellDialogRich.Location = new System.Drawing.Point(195, 10);
            btnSpellDialogRich.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSpellDialogRich.Name = "btnSpellDialogRich";
            btnSpellDialogRich.Size = new System.Drawing.Size(180, 35);
            btnSpellDialogRich.TabIndex = 1;
            btnSpellDialogRich.Text = "Check with Dialog";
            toolTip1.SetToolTip(btnSpellDialogRich, "Spell-check the entire control using a modal dialog.");
            btnSpellDialogRich.UseVisualStyleBackColor = true;
            btnSpellDialogRich.Click += btnSpellDialogRich_Click;
            // 
            // btnShowErrorsRich
            // 
            btnShowErrorsRich.Location = new System.Drawing.Point(382, 10);
            btnShowErrorsRich.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShowErrorsRich.Name = "btnShowErrorsRich";
            btnShowErrorsRich.Size = new System.Drawing.Size(180, 35);
            btnShowErrorsRich.TabIndex = 2;
            btnShowErrorsRich.Text = "Show Error List";
            toolTip1.SetToolTip(btnShowErrorsRich, "Use the CheckText method to collect all errors, then show them in a grid.");
            btnShowErrorsRich.UseVisualStyleBackColor = true;
            btnShowErrorsRich.Click += btnShowErrorsRich_Click;
            // 
            // tpTextBox
            // 
            tpTextBox.Controls.Add(btnAsYouType);
            tpTextBox.Controls.Add(textBox1);
            tpTextBox.Controls.Add(btnFont);
            tpTextBox.Controls.Add(btnSpellDialog);
            tpTextBox.Controls.Add(btnShowErrors);
            tpTextBox.Location = new System.Drawing.Point(4, 24);
            tpTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpTextBox.Name = "tpTextBox";
            tpTextBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpTextBox.Size = new System.Drawing.Size(853, 600);
            tpTextBox.TabIndex = 0;
            tpTextBox.Text = "TextBox";
            tpTextBox.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            btnFont.Location = new System.Drawing.Point(595, 10);
            btnFont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFont.Name = "btnFont";
            btnFont.Size = new System.Drawing.Size(121, 35);
            btnFont.TabIndex = 3;
            btnFont.Text = "Font...";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // tpGrid
            // 
            tpGrid.Controls.Add(btnSpellDialogGrid);
            tpGrid.Controls.Add(_flex);
            tpGrid.Location = new System.Drawing.Point(4, 24);
            tpGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpGrid.Name = "tpGrid";
            tpGrid.Size = new System.Drawing.Size(853, 600);
            tpGrid.TabIndex = 2;
            tpGrid.Text = "C1FlexGrid";
            tpGrid.UseVisualStyleBackColor = true;
            // 
            // btnSpellDialogGrid
            // 
            btnSpellDialogGrid.Location = new System.Drawing.Point(9, 10);
            btnSpellDialogGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSpellDialogGrid.Name = "btnSpellDialogGrid";
            btnSpellDialogGrid.Size = new System.Drawing.Size(180, 35);
            btnSpellDialogGrid.TabIndex = 2;
            btnSpellDialogGrid.Text = "Check with Dialog";
            toolTip1.SetToolTip(btnSpellDialogGrid, "Spell-check the entire control using a modal dialog.");
            btnSpellDialogGrid.UseVisualStyleBackColor = true;
            btnSpellDialogGrid.Click += btnSpellDialogGrid_Click;
            // 
            // _flex
            // 
            _flex.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            _flex.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            _flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            _flex.Location = new System.Drawing.Point(6, 52);
            _flex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _flex.Name = "_flex";
            _flex.Rows.DefaultSize = 17;
            _flex.Size = new System.Drawing.Size(842, 536);
            _flex.TabIndex = 0;
            // 
            // _spell
            // 
            _spell.MainDictionary.Password = "foozebar";
            // 
            // 
            // 
            _spell.UserDictionary.Enabled = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(861, 628);
            Controls.Add(tabControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "C1SpellChecker: QuickStart";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tpRichTextBox.ResumeLayout(false);
            tpRichTextBox.PerformLayout();
            tpTextBox.ResumeLayout(false);
            tpTextBox.PerformLayout();
            tpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_flex).EndInit();
            ((System.ComponentModel.ISupportInitialize)_spell).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.SpellChecker.C1SpellChecker _spell;
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
        private C1.Win.FlexGrid.C1FlexGrid _flex;
    }
}

