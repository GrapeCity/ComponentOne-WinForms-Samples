namespace TouchToolkitExplorer.C1MagnifyPages
{
    partial class C1MagnifyCommon
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
            C1Magnify1 = new C1.Win.TouchToolKit.C1Magnify();
            selectTextBox = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            moveRadioButton = new System.Windows.Forms.RadioButton();
            moveLeftDownRadioButton = new System.Windows.Forms.RadioButton();
            moveNoneRadioButton = new System.Windows.Forms.RadioButton();
            splitter1 = new System.Windows.Forms.Splitter();
            panel3 = new System.Windows.Forms.Panel();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox5 = new System.Windows.Forms.GroupBox();
            closeRightRadioButton = new System.Windows.Forms.RadioButton();
            closeLeftRadioButton = new System.Windows.Forms.RadioButton();
            closeNoneRadioButton = new System.Windows.Forms.RadioButton();
            popupDelayLabel = new System.Windows.Forms.Label();
            PopupDelayTrackBar = new System.Windows.Forms.TrackBar();
            IsHorizontalRailEnabledCheckBox = new System.Windows.Forms.CheckBox();
            IsVerticalRailEnalbedCheckBox = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            roundedRectangleRadioButton = new System.Windows.Forms.RadioButton();
            rectangleRadioButton = new System.Windows.Forms.RadioButton();
            circleRadioButton = new System.Windows.Forms.RadioButton();
            ShowCursorCheckbox = new System.Windows.Forms.CheckBox();
            zoomfactorTrackBar = new System.Windows.Forms.TrackBar();
            sizeLabel = new System.Windows.Forms.Label();
            zoomFactorLabel = new System.Windows.Forms.Label();
            sizeTrackBar = new System.Windows.Forms.TrackBar();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tabPage3 = new System.Windows.Forms.TabPage();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            customRadioButton = new System.Windows.Forms.RadioButton();
            darkRadioButton = new System.Windows.Forms.RadioButton();
            lightRadioButton = new System.Windows.Forms.RadioButton();
            panel5 = new System.Windows.Forms.Panel();
            borderWidthlabel = new System.Windows.Forms.Label();
            borderWidthTrackBar = new System.Windows.Forms.TrackBar();
            label5 = new System.Windows.Forms.Label();
            customBackgroundSetting = new System.Windows.Forms.GroupBox();
            label13 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            SelectImageButton = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PopupDelayTrackBar).BeginInit();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)zoomfactorTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeTrackBar).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borderWidthTrackBar).BeginInit();
            customBackgroundSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(panel2);
            // 
            // selectTextBox
            // 
            C1Magnify1.SetEnableMagnifier(selectTextBox, true);
            selectTextBox.Location = new System.Drawing.Point(19, 113);
            selectTextBox.Multiline = true;
            selectTextBox.Name = "selectTextBox";
            selectTextBox.Size = new System.Drawing.Size(253, 60);
            selectTextBox.TabIndex = 28;
            selectTextBox.Text = "Try to select a part of string to copy by C1Magnify component";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(selectTextBox);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(294, 499);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(19, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(253, 60);
            textBox1.TabIndex = 30;
            textBox1.Text = "Try to select a part of string to copy typically.";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(moveRadioButton);
            groupBox4.Controls.Add(moveLeftDownRadioButton);
            groupBox4.Controls.Add(moveNoneRadioButton);
            groupBox4.Location = new System.Drawing.Point(12, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(386, 68);
            groupBox4.TabIndex = 30;
            groupBox4.TabStop = false;
            groupBox4.Text = "Message When Move Magnifier";
            // 
            // moveRadioButton
            // 
            moveRadioButton.AutoSize = true;
            moveRadioButton.Checked = true;
            moveRadioButton.Location = new System.Drawing.Point(159, 27);
            moveRadioButton.Name = "moveRadioButton";
            moveRadioButton.Size = new System.Drawing.Size(55, 19);
            moveRadioButton.TabIndex = 2;
            moveRadioButton.TabStop = true;
            moveRadioButton.Text = "Move";
            moveRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveLeftDownRadioButton
            // 
            moveLeftDownRadioButton.AutoSize = true;
            moveLeftDownRadioButton.Location = new System.Drawing.Point(250, 27);
            moveLeftDownRadioButton.Name = "moveLeftDownRadioButton";
            moveLeftDownRadioButton.Size = new System.Drawing.Size(79, 19);
            moveLeftDownRadioButton.TabIndex = 1;
            moveLeftDownRadioButton.Text = "Left Down";
            moveLeftDownRadioButton.UseVisualStyleBackColor = true;
            // 
            // moveNoneRadioButton
            // 
            moveNoneRadioButton.AutoSize = true;
            moveNoneRadioButton.Location = new System.Drawing.Point(17, 25);
            moveNoneRadioButton.Name = "moveNoneRadioButton";
            moveNoneRadioButton.Size = new System.Drawing.Size(90, 19);
            moveNoneRadioButton.TabIndex = 0;
            moveNoneRadioButton.Text = "No Message";
            moveNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.BackColor = System.Drawing.Color.LightGray;
            splitter1.Enabled = false;
            splitter1.Location = new System.Drawing.Point(294, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(3, 499);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(297, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(427, 499);
            panel3.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(427, 499);
            tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(popupDelayLabel);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(PopupDelayTrackBar);
            tabPage1.Controls.Add(IsHorizontalRailEnabledCheckBox);
            tabPage1.Controls.Add(IsVerticalRailEnalbedCheckBox);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(419, 471);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Behavior";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(closeRightRadioButton);
            groupBox5.Controls.Add(closeLeftRadioButton);
            groupBox5.Controls.Add(closeNoneRadioButton);
            groupBox5.Location = new System.Drawing.Point(12, 86);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(384, 68);
            groupBox5.TabIndex = 31;
            groupBox5.TabStop = false;
            groupBox5.Text = "Message When Close Magnifier";
            // 
            // closeRightRadioButton
            // 
            closeRightRadioButton.AutoSize = true;
            closeRightRadioButton.Location = new System.Drawing.Point(156, 30);
            closeRightRadioButton.Name = "closeRightRadioButton";
            closeRightRadioButton.Size = new System.Drawing.Size(82, 19);
            closeRightRadioButton.TabIndex = 2;
            closeRightRadioButton.Text = "Right Click";
            closeRightRadioButton.UseVisualStyleBackColor = true;
            // 
            // closeLeftRadioButton
            // 
            closeLeftRadioButton.AutoSize = true;
            closeLeftRadioButton.Location = new System.Drawing.Point(279, 30);
            closeLeftRadioButton.Margin = new System.Windows.Forms.Padding(0);
            closeLeftRadioButton.Name = "closeLeftRadioButton";
            closeLeftRadioButton.Size = new System.Drawing.Size(74, 19);
            closeLeftRadioButton.TabIndex = 1;
            closeLeftRadioButton.Text = "Left Click";
            closeLeftRadioButton.UseVisualStyleBackColor = true;
            // 
            // closeNoneRadioButton
            // 
            closeNoneRadioButton.AutoSize = true;
            closeNoneRadioButton.Checked = true;
            closeNoneRadioButton.Location = new System.Drawing.Point(17, 30);
            closeNoneRadioButton.Name = "closeNoneRadioButton";
            closeNoneRadioButton.Size = new System.Drawing.Size(90, 19);
            closeNoneRadioButton.TabIndex = 0;
            closeNoneRadioButton.TabStop = true;
            closeNoneRadioButton.Text = "No Message";
            closeNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // popupDelayLabel
            // 
            popupDelayLabel.AutoSize = true;
            popupDelayLabel.Location = new System.Drawing.Point(149, 176);
            popupDelayLabel.Name = "popupDelayLabel";
            popupDelayLabel.Size = new System.Drawing.Size(41, 15);
            popupDelayLabel.TabIndex = 55;
            popupDelayLabel.Text = "500ms";
            // 
            // PopupDelayTrackBar
            // 
            PopupDelayTrackBar.BackColor = System.Drawing.Color.White;
            PopupDelayTrackBar.LargeChange = 100;
            PopupDelayTrackBar.Location = new System.Drawing.Point(198, 172);
            PopupDelayTrackBar.Maximum = 1000;
            PopupDelayTrackBar.Minimum = 1;
            PopupDelayTrackBar.Name = "PopupDelayTrackBar";
            PopupDelayTrackBar.Size = new System.Drawing.Size(167, 45);
            PopupDelayTrackBar.SmallChange = 100;
            PopupDelayTrackBar.TabIndex = 54;
            PopupDelayTrackBar.TickFrequency = 100;
            PopupDelayTrackBar.Value = 500;
            // 
            // IsHorizontalRailEnabledCheckBox
            // 
            IsHorizontalRailEnabledCheckBox.AutoSize = true;
            IsHorizontalRailEnabledCheckBox.Location = new System.Drawing.Point(33, 280);
            IsHorizontalRailEnabledCheckBox.Name = "IsHorizontalRailEnabledCheckBox";
            IsHorizontalRailEnabledCheckBox.Size = new System.Drawing.Size(150, 19);
            IsHorizontalRailEnabledCheckBox.TabIndex = 52;
            IsHorizontalRailEnabledCheckBox.Text = "IsHorizontalRailEnabled";
            IsHorizontalRailEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsVerticalRailEnalbedCheckBox
            // 
            IsVerticalRailEnalbedCheckBox.AutoSize = true;
            IsVerticalRailEnalbedCheckBox.Location = new System.Drawing.Point(33, 245);
            IsVerticalRailEnalbedCheckBox.Name = "IsVerticalRailEnalbedCheckBox";
            IsVerticalRailEnalbedCheckBox.Size = new System.Drawing.Size(133, 19);
            IsVerticalRailEnalbedCheckBox.TabIndex = 53;
            IsVerticalRailEnalbedCheckBox.Text = "IsVerticalRailEnalbed";
            IsVerticalRailEnalbedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(30, 176);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 15);
            label8.TabIndex = 50;
            label8.Text = "PopupDelay:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(ShowCursorCheckbox);
            tabPage2.Controls.Add(zoomfactorTrackBar);
            tabPage2.Controls.Add(sizeLabel);
            tabPage2.Controls.Add(zoomFactorLabel);
            tabPage2.Controls.Add(sizeTrackBar);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(419, 471);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Shape";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(roundedRectangleRadioButton);
            groupBox3.Controls.Add(rectangleRadioButton);
            groupBox3.Controls.Add(circleRadioButton);
            groupBox3.Location = new System.Drawing.Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(413, 155);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "Magnifier Shape";
            // 
            // roundedRectangleRadioButton
            // 
            roundedRectangleRadioButton.BackgroundImage = Properties.Resources.MagnifierRoundedRectangle;
            roundedRectangleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            roundedRectangleRadioButton.Location = new System.Drawing.Point(266, 35);
            roundedRectangleRadioButton.Name = "roundedRectangleRadioButton";
            roundedRectangleRadioButton.Size = new System.Drawing.Size(131, 99);
            roundedRectangleRadioButton.TabIndex = 2;
            roundedRectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // rectangleRadioButton
            // 
            rectangleRadioButton.BackgroundImage = Properties.Resources.MagnifierRectangle;
            rectangleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            rectangleRadioButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            rectangleRadioButton.Location = new System.Drawing.Point(143, 35);
            rectangleRadioButton.Name = "rectangleRadioButton";
            rectangleRadioButton.Size = new System.Drawing.Size(131, 99);
            rectangleRadioButton.TabIndex = 1;
            rectangleRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            rectangleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            rectangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // circleRadioButton
            // 
            circleRadioButton.BackgroundImage = Properties.Resources.MagnifierCircle;
            circleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            circleRadioButton.Checked = true;
            circleRadioButton.Location = new System.Drawing.Point(23, 35);
            circleRadioButton.Name = "circleRadioButton";
            circleRadioButton.Size = new System.Drawing.Size(131, 99);
            circleRadioButton.TabIndex = 0;
            circleRadioButton.TabStop = true;
            circleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShowCursorCheckbox
            // 
            ShowCursorCheckbox.AutoSize = true;
            ShowCursorCheckbox.Location = new System.Drawing.Point(13, 304);
            ShowCursorCheckbox.Name = "ShowCursorCheckbox";
            ShowCursorCheckbox.Size = new System.Drawing.Size(90, 19);
            ShowCursorCheckbox.TabIndex = 55;
            ShowCursorCheckbox.Text = "ShowCursor";
            ShowCursorCheckbox.UseVisualStyleBackColor = true;
            // 
            // zoomfactorTrackBar
            // 
            zoomfactorTrackBar.AutoSize = false;
            zoomfactorTrackBar.BackColor = System.Drawing.Color.White;
            zoomfactorTrackBar.LargeChange = 1;
            zoomfactorTrackBar.Location = new System.Drawing.Point(204, 245);
            zoomfactorTrackBar.Maximum = 4;
            zoomfactorTrackBar.Minimum = 1;
            zoomfactorTrackBar.Name = "zoomfactorTrackBar";
            zoomfactorTrackBar.Size = new System.Drawing.Size(156, 31);
            zoomfactorTrackBar.TabIndex = 53;
            zoomfactorTrackBar.Value = 2;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(115, 187);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(54, 15);
            sizeLabel.TabIndex = 52;
            sizeLabel.Text = "(100,100)";
            // 
            // zoomFactorLabel
            // 
            zoomFactorLabel.AutoSize = true;
            zoomFactorLabel.Location = new System.Drawing.Point(146, 245);
            zoomFactorLabel.Name = "zoomFactorLabel";
            zoomFactorLabel.Size = new System.Drawing.Size(35, 15);
            zoomFactorLabel.TabIndex = 50;
            zoomFactorLabel.Text = "200%";
            // 
            // sizeTrackBar
            // 
            sizeTrackBar.AutoSize = false;
            sizeTrackBar.BackColor = System.Drawing.Color.White;
            sizeTrackBar.LargeChange = 1;
            sizeTrackBar.Location = new System.Drawing.Point(204, 183);
            sizeTrackBar.Maximum = 4;
            sizeTrackBar.Minimum = 1;
            sizeTrackBar.Name = "sizeTrackBar";
            sizeTrackBar.Size = new System.Drawing.Size(156, 31);
            sizeTrackBar.TabIndex = 49;
            sizeTrackBar.Value = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(10, 187);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(30, 15);
            label9.TabIndex = 36;
            label9.Text = "Size:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(10, 247);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(75, 15);
            label11.TabIndex = 21;
            label11.Text = "ZoomFactor:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel1);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(419, 471);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "C1Magnify Border";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 2);
            tableLayoutPanel1.Controls.Add(customBackgroundSetting, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(413, 465);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customRadioButton);
            groupBox1.Controls.Add(darkRadioButton);
            groupBox1.Controls.Add(lightRadioButton);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(407, 157);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Magnifier Border Background Mode";
            // 
            // customRadioButton
            // 
            customRadioButton.BackgroundImage = Properties.Resources.MagnifierCustom;
            customRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            customRadioButton.Location = new System.Drawing.Point(261, 34);
            customRadioButton.Name = "customRadioButton";
            customRadioButton.Size = new System.Drawing.Size(131, 99);
            customRadioButton.TabIndex = 2;
            customRadioButton.UseVisualStyleBackColor = true;
            // 
            // darkRadioButton
            // 
            darkRadioButton.BackgroundImage = Properties.Resources.MagnifierDark;
            darkRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            darkRadioButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            darkRadioButton.Location = new System.Drawing.Point(145, 34);
            darkRadioButton.Name = "darkRadioButton";
            darkRadioButton.Size = new System.Drawing.Size(131, 99);
            darkRadioButton.TabIndex = 1;
            darkRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            darkRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            darkRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightRadioButton
            // 
            lightRadioButton.BackgroundImage = Properties.Resources.MagnifierCircle;
            lightRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            lightRadioButton.Checked = true;
            lightRadioButton.Location = new System.Drawing.Point(26, 34);
            lightRadioButton.Name = "lightRadioButton";
            lightRadioButton.Size = new System.Drawing.Size(131, 99);
            lightRadioButton.TabIndex = 0;
            lightRadioButton.TabStop = true;
            lightRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(borderWidthlabel);
            panel5.Controls.Add(borderWidthTrackBar);
            panel5.Controls.Add(label5);
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.Location = new System.Drawing.Point(3, 300);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(407, 162);
            panel5.TabIndex = 65;
            // 
            // borderWidthlabel
            // 
            borderWidthlabel.AutoSize = true;
            borderWidthlabel.Location = new System.Drawing.Point(165, 12);
            borderWidthlabel.Name = "borderWidthlabel";
            borderWidthlabel.Size = new System.Drawing.Size(13, 15);
            borderWidthlabel.TabIndex = 57;
            borderWidthlabel.Text = "5";
            // 
            // borderWidthTrackBar
            // 
            borderWidthTrackBar.AutoSize = false;
            borderWidthTrackBar.BackColor = System.Drawing.Color.White;
            borderWidthTrackBar.LargeChange = 1;
            borderWidthTrackBar.Location = new System.Drawing.Point(186, 8);
            borderWidthTrackBar.Minimum = 1;
            borderWidthTrackBar.Name = "borderWidthTrackBar";
            borderWidthTrackBar.Size = new System.Drawing.Size(169, 31);
            borderWidthTrackBar.TabIndex = 56;
            borderWidthTrackBar.Value = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(77, 15);
            label5.TabIndex = 55;
            label5.Text = "BorderWidth:";
            // 
            // customBackgroundSetting
            // 
            customBackgroundSetting.Controls.Add(label13);
            customBackgroundSetting.Controls.Add(pictureBox1);
            customBackgroundSetting.Controls.Add(SelectImageButton);
            customBackgroundSetting.Location = new System.Drawing.Point(3, 166);
            customBackgroundSetting.Name = "customBackgroundSetting";
            customBackgroundSetting.Size = new System.Drawing.Size(367, 128);
            customBackgroundSetting.TabIndex = 66;
            customBackgroundSetting.TabStop = false;
            customBackgroundSetting.Text = "Magnifier Border Background";
            customBackgroundSetting.Visible = false;
            // 
            // label13
            // 
            label13.Location = new System.Drawing.Point(126, 60);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(241, 65);
            label13.TabIndex = 46;
            label13.Text = "BorderBackground property only take effect when BorderBackgroundMode property is custom.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MagnifierBorderBackground;
            pictureBox1.Location = new System.Drawing.Point(7, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(103, 87);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // SelectImageButton
            // 
            SelectImageButton.Location = new System.Drawing.Point(128, 24);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.Size = new System.Drawing.Size(164, 30);
            SelectImageButton.TabIndex = 49;
            SelectImageButton.Text = "Select Image ...";
            SelectImageButton.UseVisualStyleBackColor = true;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // C1MagnifyCommon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "C1MagnifyCommon";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PopupDelayTrackBar).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)zoomfactorTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeTrackBar).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borderWidthTrackBar).EndInit();
            customBackgroundSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.TouchToolKit.C1Magnify C1Magnify1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox selectTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label popupDelayLabel;
        private System.Windows.Forms.TrackBar PopupDelayTrackBar;
        private System.Windows.Forms.CheckBox IsHorizontalRailEnabledCheckBox;
        private System.Windows.Forms.CheckBox IsVerticalRailEnalbedCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ShowCursorCheckbox;
        private System.Windows.Forms.TrackBar zoomfactorTrackBar;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label zoomFactorLabel;
        private System.Windows.Forms.TrackBar sizeTrackBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.RadioButton darkRadioButton;
        private System.Windows.Forms.RadioButton lightRadioButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label borderWidthlabel;
        private System.Windows.Forms.TrackBar borderWidthTrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton roundedRectangleRadioButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton closeRightRadioButton;
        private System.Windows.Forms.RadioButton closeLeftRadioButton;
        private System.Windows.Forms.RadioButton closeNoneRadioButton;
        private System.Windows.Forms.RadioButton moveRadioButton;
        private System.Windows.Forms.RadioButton moveLeftDownRadioButton;
        private System.Windows.Forms.RadioButton moveNoneRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox customBackgroundSetting;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectImageButton;
    }
}
