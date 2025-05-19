namespace FlexGridAi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelTop = new TableLayoutPanel();
            customTxtBoxSendPrompt = new FlexGridAi.Controls.CustomTextBox();
            pnlBtns = new Panel();
            btnClearText = new C1.Win.Input.C1Button();
            btnManageApiKey = new C1.Win.Input.C1Button();
            btnResetGrid = new C1.Win.Input.C1Button();
            pnlResponse = new Panel();
            picBoxLoading = new C1.Win.Input.C1PictureBox();
            txtBoxGetResponse = new C1.Win.Input.C1TextBox();
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            pnlBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClearText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnManageApiKey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnResetGrid).BeginInit();
            pnlResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBoxGetResponse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.BackColor = Color.FromArgb(228, 231, 237);
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelTop, 0, 0);
            tableLayoutPanelMain.Controls.Add(flexGrid, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(1469, 1042);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.ColumnCount = 3;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanelTop.Controls.Add(customTxtBoxSendPrompt, 0, 0);
            tableLayoutPanelTop.Controls.Add(pnlBtns, 2, 0);
            tableLayoutPanelTop.Controls.Add(pnlResponse, 1, 0);
            tableLayoutPanelTop.Dock = DockStyle.Fill;
            tableLayoutPanelTop.Location = new Point(0, 0);
            tableLayoutPanelTop.Margin = new Padding(0);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 1;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.Size = new Size(1469, 250);
            tableLayoutPanelTop.TabIndex = 0;
            // 
            // customTxtBoxSendPrompt
            // 
            customTxtBoxSendPrompt.AskButtonEnabled = true;
            customTxtBoxSendPrompt.BackColor = Color.White;
            customTxtBoxSendPrompt.Dock = DockStyle.Fill;
            customTxtBoxSendPrompt.InputText = "";
            customTxtBoxSendPrompt.Location = new Point(20, 20);
            customTxtBoxSendPrompt.Margin = new Padding(20, 20, 10, 10);
            customTxtBoxSendPrompt.Name = "customTxtBoxSendPrompt";
            customTxtBoxSendPrompt.Padding = new Padding(10);
            customTxtBoxSendPrompt.PlaceholderText = "Ask something about the table...";
            customTxtBoxSendPrompt.Size = new Size(623, 220);
            customTxtBoxSendPrompt.TabIndex = 3;
            customTxtBoxSendPrompt.AskButtonClicked += CustomTxtBox_AskBtnClick;
            // 
            // pnlBtns
            // 
            pnlBtns.Controls.Add(btnClearText);
            pnlBtns.Controls.Add(btnManageApiKey);
            pnlBtns.Controls.Add(btnResetGrid);
            pnlBtns.Dock = DockStyle.Fill;
            pnlBtns.Location = new Point(1306, 0);
            pnlBtns.Margin = new Padding(0);
            pnlBtns.Name = "pnlBtns";
            pnlBtns.Size = new Size(163, 250);
            pnlBtns.TabIndex = 2;
            // 
            // btnClearText
            // 
            btnClearText.Cursor = Cursors.Hand;
            btnClearText.Font = new Font("Segoe UI Variable Text", 9F);
            btnClearText.Location = new Point(12, 160);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(131, 50);
            btnClearText.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnClearText.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            btnClearText.Styles.Default.BackColor = Color.FromArgb(247, 248, 250);
            btnClearText.Styles.Default.BorderColor = Color.FromArgb(214, 214, 214);
            btnClearText.Styles.Disabled.BackColor = Color.FromArgb(254, 254, 254);
            btnClearText.Styles.Disabled.BorderColor = SystemColors.ButtonFace;
            btnClearText.Styles.Disabled.ForeColor = Color.FromArgb(162, 162, 162);
            btnClearText.Styles.Hot.BackColor = SystemColors.ButtonFace;
            btnClearText.Styles.Hot.BorderColor = Color.FromArgb(214, 214, 214);
            btnClearText.Styles.HotPressed.BackColor = Color.FromArgb(254, 254, 254);
            btnClearText.Styles.HotPressed.BorderColor = SystemColors.ButtonFace;
            btnClearText.Styles.HotPressed.ForeColor = SystemColors.WindowFrame;
            btnClearText.TabIndex = 2;
            btnClearText.Text = "Clear Text";
            btnClearText.Click += BtnClearText_Click;
            // 
            // btnManageApiKey
            // 
            btnManageApiKey.Cursor = Cursors.Hand;
            btnManageApiKey.Font = new Font("Segoe UI Variable Text", 9F);
            btnManageApiKey.Location = new Point(12, 20);
            btnManageApiKey.Name = "btnManageApiKey";
            btnManageApiKey.Size = new Size(131, 50);
            btnManageApiKey.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnManageApiKey.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            btnManageApiKey.Styles.Default.BackColor = Color.FromArgb(247, 248, 250);
            btnManageApiKey.Styles.Default.BorderColor = Color.FromArgb(214, 214, 214);
            btnManageApiKey.Styles.Disabled.BackColor = Color.FromArgb(254, 254, 254);
            btnManageApiKey.Styles.Disabled.BorderColor = SystemColors.ButtonFace;
            btnManageApiKey.Styles.Disabled.ForeColor = Color.FromArgb(162, 162, 162);
            btnManageApiKey.Styles.Hot.BackColor = SystemColors.ButtonFace;
            btnManageApiKey.Styles.Hot.BorderColor = Color.FromArgb(214, 214, 214);
            btnManageApiKey.Styles.HotPressed.BackColor = Color.FromArgb(254, 254, 254);
            btnManageApiKey.Styles.HotPressed.BorderColor = SystemColors.ButtonFace;
            btnManageApiKey.Styles.HotPressed.ForeColor = SystemColors.WindowFrame;
            btnManageApiKey.TabIndex = 0;
            btnManageApiKey.Text = "Set API Key";
            btnManageApiKey.Click += BtnManageApiKey_Click;
            // 
            // btnResetGrid
            // 
            btnResetGrid.Cursor = Cursors.Hand;
            btnResetGrid.Font = new Font("Segoe UI Variable Text", 9F);
            btnResetGrid.Location = new Point(12, 90);
            btnResetGrid.Name = "btnResetGrid";
            btnResetGrid.Size = new Size(131, 50);
            btnResetGrid.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            btnResetGrid.Styles.Corners = new C1.Framework.Corners(3, 3, 3, 3);
            btnResetGrid.Styles.Default.BackColor = Color.FromArgb(247, 248, 250);
            btnResetGrid.Styles.Default.BorderColor = Color.FromArgb(214, 214, 214);
            btnResetGrid.Styles.Disabled.BackColor = Color.FromArgb(254, 254, 254);
            btnResetGrid.Styles.Disabled.BorderColor = SystemColors.ButtonFace;
            btnResetGrid.Styles.Disabled.ForeColor = Color.FromArgb(162, 162, 162);
            btnResetGrid.Styles.Hot.BackColor = SystemColors.ButtonFace;
            btnResetGrid.Styles.Hot.BorderColor = Color.FromArgb(214, 214, 214);
            btnResetGrid.Styles.HotPressed.BackColor = Color.FromArgb(254, 254, 254);
            btnResetGrid.Styles.HotPressed.BorderColor = SystemColors.ButtonFace;
            btnResetGrid.Styles.HotPressed.ForeColor = SystemColors.WindowFrame;
            btnResetGrid.TabIndex = 1;
            btnResetGrid.Text = "Reset Table";
            btnResetGrid.Click += BtnResetGrid_Click;
            // 
            // pnlResponse
            // 
            pnlResponse.Controls.Add(picBoxLoading);
            pnlResponse.Controls.Add(txtBoxGetResponse);
            pnlResponse.Dock = DockStyle.Fill;
            pnlResponse.Location = new Point(653, 0);
            pnlResponse.Margin = new Padding(0);
            pnlResponse.Name = "pnlResponse";
            pnlResponse.Padding = new Padding(10, 20, 10, 10);
            pnlResponse.Size = new Size(653, 250);
            pnlResponse.TabIndex = 4;
            // 
            // picBoxLoading
            // 
            picBoxLoading.BackColor = Color.FromArgb(246, 247, 249);
            picBoxLoading.Image = Properties.Resources.Loading_Spinner;
            picBoxLoading.Location = new Point(292, 102);
            picBoxLoading.Name = "picBoxLoading";
            picBoxLoading.Size = new Size(50, 50);
            picBoxLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxLoading.TabIndex = 2;
            picBoxLoading.TabStop = false;
            picBoxLoading.Visible = false;
            // 
            // txtBoxGetResponse
            // 
            txtBoxGetResponse.AutoSize = false;
            txtBoxGetResponse.Dock = DockStyle.Fill;
            txtBoxGetResponse.Enabled = false;
            txtBoxGetResponse.Font = new Font("Segoe UI Variable Text", 10F);
            txtBoxGetResponse.Location = new Point(10, 20);
            txtBoxGetResponse.Multiline = true;
            txtBoxGetResponse.Name = "txtBoxGetResponse";
            txtBoxGetResponse.Placeholder = "AI response will appear here";
            txtBoxGetResponse.Size = new Size(633, 220);
            txtBoxGetResponse.Styles.Corners = new C1.Framework.Corners(10, 10, 10, 10);
            txtBoxGetResponse.Styles.Disabled.BackColor = Color.FromArgb(246, 247, 249);
            txtBoxGetResponse.Styles.Disabled.ForeColor = Color.FromArgb(98, 99, 100);
            txtBoxGetResponse.Styles.Padding = new C1.Framework.Thickness(20, 20, 20, 20);
            txtBoxGetResponse.TabIndex = 0;
            txtBoxGetResponse.Value = "";
            // 
            // flexGrid
            // 
            flexGrid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.Dock = DockStyle.Fill;
            flexGrid.Location = new Point(20, 260);
            flexGrid.Margin = new Padding(20, 10, 20, 20);
            flexGrid.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            flexGrid.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            flexGrid.Name = "flexGrid";
            flexGrid.Size = new Size(1429, 762);
            flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            flexGrid.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 1042);
            Controls.Add(tableLayoutPanelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1435, 1019);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gemini AI Grid Assistant";
            Load += Form1_Load;
            Resize += Form1_Resize;
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelTop.ResumeLayout(false);
            pnlBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClearText).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnManageApiKey).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnResetGrid).EndInit();
            pnlResponse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBoxGetResponse).EndInit();
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelTop;
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private Panel pnlBtns;
        private C1.Win.Input.C1Button btnManageApiKey;
        private C1.Win.Input.C1Button btnResetGrid;
        private Controls.CustomTextBox customTxtBoxSendPrompt;
        private C1.Win.Input.C1PictureBox picBoxLoading;
        private Panel pnlResponse;
        private C1.Win.Input.C1TextBox txtBoxGetResponse;
        private C1.Win.Input.C1Button btnClearText;
    }
}
