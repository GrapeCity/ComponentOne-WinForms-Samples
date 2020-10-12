namespace TaskDialogDemo
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
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton1 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton2 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton3 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton4 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton5 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton1 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton6 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton7 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton8 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton2 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton3 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton4 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton5 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton6 = new C1.Win.C1Win7Pack.C1RadioButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dialogCommonButtons = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.linkCommonButtons = new System.Windows.Forms.LinkLabel();
            this.linkCustomButtons = new System.Windows.Forms.LinkLabel();
            this.linkEnableDisable = new System.Windows.Forms.LinkLabel();
            this.linkElevation = new System.Windows.Forms.LinkLabel();
            this.linkError = new System.Windows.Forms.LinkLabel();
            this.linkIcons = new System.Windows.Forms.LinkLabel();
            this.linkProgress1 = new System.Windows.Forms.LinkLabel();
            this.linkProgress2 = new System.Windows.Forms.LinkLabel();
            this.linkTimer = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dialogCustomButtons = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogEnableDisable = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogElevation = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogError = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogIcons = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogProgress1 = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogProgress2 = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.dialogTimer = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.SuspendLayout();
            // 
            // dialogCommonButtons
            // 
            this.dialogCommonButtons.CommonButtons = ((C1.Win.C1Win7Pack.TaskDialogCommonButtons)((((((C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok | C1.Win.C1Win7Pack.TaskDialogCommonButtons.Yes)
                        | C1.Win.C1Win7Pack.TaskDialogCommonButtons.No)
                        | C1.Win.C1Win7Pack.TaskDialogCommonButtons.Cancel)
                        | C1.Win.C1Win7Pack.TaskDialogCommonButtons.Retry)
                        | C1.Win.C1Win7Pack.TaskDialogCommonButtons.Close)));
            this.dialogCommonButtons.MainInstruction = "Click on any of the buttons below to get a specific message box.";
            this.dialogCommonButtons.WindowTitle = "Common Buttons Sample";
            // 
            // linkCommonButtons
            // 
            this.linkCommonButtons.AutoSize = true;
            this.linkCommonButtons.Location = new System.Drawing.Point(21, 18);
            this.linkCommonButtons.Name = "linkCommonButtons";
            this.linkCommonButtons.Size = new System.Drawing.Size(137, 13);
            this.linkCommonButtons.TabIndex = 0;
            this.linkCommonButtons.TabStop = true;
            this.linkCommonButtons.Text = "Common Buttons Sample";
            this.linkCommonButtons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCommonButtons_LinkClicked);
            // 
            // linkCustomButtons
            // 
            this.linkCustomButtons.AutoSize = true;
            this.linkCustomButtons.Location = new System.Drawing.Point(21, 43);
            this.linkCustomButtons.Name = "linkCustomButtons";
            this.linkCustomButtons.Size = new System.Drawing.Size(130, 13);
            this.linkCustomButtons.TabIndex = 1;
            this.linkCustomButtons.TabStop = true;
            this.linkCustomButtons.Text = "Custom Buttons Sample";
            this.linkCustomButtons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCustomButtons_LinkClicked);
            // 
            // linkEnableDisable
            // 
            this.linkEnableDisable.AutoSize = true;
            this.linkEnableDisable.Location = new System.Drawing.Point(21, 68);
            this.linkEnableDisable.Name = "linkEnableDisable";
            this.linkEnableDisable.Size = new System.Drawing.Size(124, 13);
            this.linkEnableDisable.TabIndex = 2;
            this.linkEnableDisable.TabStop = true;
            this.linkEnableDisable.Text = "Enable/Disable Sample";
            this.linkEnableDisable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEnableDisable_LinkClicked);
            // 
            // linkElevation
            // 
            this.linkElevation.AutoSize = true;
            this.linkElevation.Location = new System.Drawing.Point(21, 93);
            this.linkElevation.Name = "linkElevation";
            this.linkElevation.Size = new System.Drawing.Size(144, 13);
            this.linkElevation.TabIndex = 3;
            this.linkElevation.TabStop = true;
            this.linkElevation.Text = "Elevation Required Sample";
            this.linkElevation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkElevation_LinkClicked);
            // 
            // linkError
            // 
            this.linkError.AutoSize = true;
            this.linkError.Location = new System.Drawing.Point(21, 118);
            this.linkError.Name = "linkError";
            this.linkError.Size = new System.Drawing.Size(72, 13);
            this.linkError.TabIndex = 4;
            this.linkError.TabStop = true;
            this.linkError.Text = "Error Sample";
            this.linkError.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkError_LinkClicked);
            // 
            // linkIcons
            // 
            this.linkIcons.AutoSize = true;
            this.linkIcons.Location = new System.Drawing.Point(21, 143);
            this.linkIcons.Name = "linkIcons";
            this.linkIcons.Size = new System.Drawing.Size(74, 13);
            this.linkIcons.TabIndex = 5;
            this.linkIcons.TabStop = true;
            this.linkIcons.Text = "Icons Sample";
            this.linkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIcons_LinkClicked);
            // 
            // linkProgress1
            // 
            this.linkProgress1.AutoSize = true;
            this.linkProgress1.Location = new System.Drawing.Point(21, 168);
            this.linkProgress1.Name = "linkProgress1";
            this.linkProgress1.Size = new System.Drawing.Size(91, 13);
            this.linkProgress1.TabIndex = 6;
            this.linkProgress1.TabStop = true;
            this.linkProgress1.Text = "Progress Sample";
            this.linkProgress1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProgress1_LinkClicked);
            // 
            // linkProgress2
            // 
            this.linkProgress2.AutoSize = true;
            this.linkProgress2.Location = new System.Drawing.Point(21, 193);
            this.linkProgress2.Name = "linkProgress2";
            this.linkProgress2.Size = new System.Drawing.Size(128, 13);
            this.linkProgress2.TabIndex = 7;
            this.linkProgress2.TabStop = true;
            this.linkProgress2.Text = "Progress Effects Sample";
            this.linkProgress2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProgress2_LinkClicked);
            // 
            // linkTimer
            // 
            this.linkTimer.AutoSize = true;
            this.linkTimer.Location = new System.Drawing.Point(21, 218);
            this.linkTimer.Name = "linkTimer";
            this.linkTimer.Size = new System.Drawing.Size(74, 13);
            this.linkTimer.TabIndex = 8;
            this.linkTimer.TabStop = true;
            this.linkTimer.Text = "Timer Sample";
            this.linkTimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTimer_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dialogCustomButtons
            // 
            c1CustomButton1.ID = 9;
            c1CustomButton1.Name = "Button1";
            c1CustomButton1.Text = "Custom Button 1";
            c1CustomButton2.ID = 10;
            c1CustomButton2.Name = "Button2";
            c1CustomButton2.Text = "Custom Button 2";
            c1CustomButton3.ID = 11;
            c1CustomButton3.Name = "Button3";
            c1CustomButton3.Text = "Custom Close Button";
            this.dialogCustomButtons.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton1,
            c1CustomButton2,
            c1CustomButton3});
            this.dialogCustomButtons.MainInstruction = "Click on any of the following buttons to display a specific message box.";
            this.dialogCustomButtons.NextID = 12;
            this.dialogCustomButtons.WindowTitle = "Custom Buttons Sample";
            this.dialogCustomButtons.ButtonClick += new C1.Win.C1Win7Pack.TaskDialogButtonClickEventHandler(this.dialogCustomButtons_ButtonClick);
            // 
            // dialogEnableDisable
            // 
            c1CustomButton4.ID = 9;
            c1CustomButton4.Name = "enableButton";
            c1CustomButton4.Text = "Enable";
            c1CustomButton5.Enabled = false;
            c1CustomButton5.ID = 10;
            c1CustomButton5.Name = "disableButton";
            c1CustomButton5.Text = "Disable";
            this.dialogEnableDisable.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton4,
            c1CustomButton5});
            this.dialogEnableDisable.MainInstruction = "Click on the buttons below to enable or disable the radio button.";
            this.dialogEnableDisable.NextID = 12;
            c1RadioButton1.Enabled = false;
            c1RadioButton1.ID = 11;
            c1RadioButton1.Name = "Radio1";
            c1RadioButton1.Text = "Sample Radio button";
            this.dialogEnableDisable.RadioButtons.AddRange(new C1.Win.C1Win7Pack.C1RadioButton[] {
            c1RadioButton1});
            this.dialogEnableDisable.UseCommandLinks = false;
            this.dialogEnableDisable.WindowTitle = "Enable/Disable Sample";
            this.dialogEnableDisable.ButtonClick += new C1.Win.C1Win7Pack.TaskDialogButtonClickEventHandler(this.dialogEnableDisable_ButtonClick);
            // 
            // dialogElevation
            // 
            this.dialogElevation.Content = "Click the Admin Stuff button to close the dialog box.";
            c1CustomButton6.ID = 9;
            c1CustomButton6.Name = "adminTaskButton";
            c1CustomButton6.Note = "Run some admin tasks";
            c1CustomButton6.ShowElevationIcon = true;
            c1CustomButton6.Text = "Admin stuff";
            this.dialogElevation.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton6});
            this.dialogElevation.NextID = 10;
            this.dialogElevation.WindowTitle = "Elevated task example";
            // 
            // dialogError
            // 
            this.dialogError.CheckBoxText = "Don\'t ask me again";
            this.dialogError.CheckedByDefault = true;
            this.dialogError.CollapsedControlText = "Show details";
            this.dialogError.Content = "Error message goes here...";
            c1CustomButton7.ID = 9;
            c1CustomButton7.Name = "sendButton";
            c1CustomButton7.Note = "I\'m in a giving mood.";
            c1CustomButton7.Text = "Send Feedback";
            c1CustomButton8.ID = 10;
            c1CustomButton8.Name = "dontSendButton";
            c1CustomButton8.Note = "I don\'t feel like being helpful.";
            c1CustomButton8.Text = "No Thanks";
            this.dialogError.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton7,
            c1CustomButton8});
            this.dialogError.ExpandedControlText = "Hide details";
            this.dialogError.ExpandedInformation = "Stack trace goes here...";
            this.dialogError.ExpandFooterArea = true;
            this.dialogError.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Error;
            this.dialogError.MainInstruction = "An unexpected error occurred. Please send feedback now!";
            this.dialogError.NextID = 11;
            this.dialogError.WindowTitle = "Error Sample";
            this.dialogError.ButtonClick += new C1.Win.C1Win7Pack.TaskDialogButtonClickEventHandler(this.dialogError_ButtonClick);
            // 
            // dialogIcons
            // 
            this.dialogIcons.FooterText = "Footer Text";
            this.dialogIcons.MainInstruction = "Select one of the following radio buttons to change the main and footer icons.";
            this.dialogIcons.NextID = 14;
            c1RadioButton2.ID = 9;
            c1RadioButton2.Name = "radioNone";
            c1RadioButton2.Text = "None";
            c1RadioButton3.ID = 10;
            c1RadioButton3.Name = "radioError";
            c1RadioButton3.Text = "Error";
            c1RadioButton4.ID = 11;
            c1RadioButton4.Name = "radioWarning";
            c1RadioButton4.Text = "Warning";
            c1RadioButton5.ID = 12;
            c1RadioButton5.Name = "radioInformation";
            c1RadioButton5.Text = "Information";
            c1RadioButton6.ID = 13;
            c1RadioButton6.Name = "radioShield";
            c1RadioButton6.Text = "Shield";
            this.dialogIcons.RadioButtons.AddRange(new C1.Win.C1Win7Pack.C1RadioButton[] {
            c1RadioButton2,
            c1RadioButton3,
            c1RadioButton4,
            c1RadioButton5,
            c1RadioButton6});
            this.dialogIcons.WindowTitle = "Icons Sample";
            this.dialogIcons.RadioButtonClick += new System.EventHandler(this.dialogIcons_RadioButtonClick);
            // 
            // dialogProgress1
            // 
            this.dialogProgress1.EnableTimer = true;
            this.dialogProgress1.ProgressBar.Maximum = 5000;
            this.dialogProgress1.ProgressBar.Visible = true;
            this.dialogProgress1.WindowTitle = "Progress Sample";
            this.dialogProgress1.TimerTick += new C1.Win.C1Win7Pack.TaskDialogTimerTickEventHandler(this.dialogProgress1_TimerTick);
            // 
            // dialogProgress2
            // 
            this.dialogProgress2.MainInstruction = "A marquee-style progress indicator:";
            this.dialogProgress2.ProgressBar.State = C1.Win.C1Win7Pack.TaskDialogProgressBarState.Indeterminate;
            this.dialogProgress2.ProgressBar.Visible = true;
            this.dialogProgress2.WindowTitle = "Progress Effects Sample";
            // 
            // dialogTimer
            // 
            this.dialogTimer.EnableTimer = true;
            this.dialogTimer.WindowTitle = "Timer Sample";
            this.dialogTimer.TimerTick += new C1.Win.C1Win7Pack.TaskDialogTimerTickEventHandler(this.dialogTimer_TimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkTimer);
            this.Controls.Add(this.linkProgress2);
            this.Controls.Add(this.linkProgress1);
            this.Controls.Add(this.linkIcons);
            this.Controls.Add(this.linkError);
            this.Controls.Add(this.linkElevation);
            this.Controls.Add(this.linkEnableDisable);
            this.Controls.Add(this.linkCustomButtons);
            this.Controls.Add(this.linkCommonButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1TaskDialog Samples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Win7Pack.C1TaskDialog dialogCommonButtons;
        private System.Windows.Forms.LinkLabel linkCommonButtons;
        private System.Windows.Forms.LinkLabel linkCustomButtons;
        private System.Windows.Forms.LinkLabel linkEnableDisable;
        private System.Windows.Forms.LinkLabel linkElevation;
        private System.Windows.Forms.LinkLabel linkError;
        private System.Windows.Forms.LinkLabel linkIcons;
        private System.Windows.Forms.LinkLabel linkProgress1;
        private System.Windows.Forms.LinkLabel linkProgress2;
        private System.Windows.Forms.LinkLabel linkTimer;
        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogCustomButtons;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogEnableDisable;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogElevation;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogError;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogIcons;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogProgress1;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogProgress2;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogTimer;
    }
}

