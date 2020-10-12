namespace JumpTaskDemo
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
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask1 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask2 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask3 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask4 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask5 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1JumpTask c1JumpTask6 = new C1.Win.C1Win7Pack.C1JumpTask();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton1 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton2 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton3 = new C1.Win.C1Win7Pack.C1RadioButton();
            C1.Win.C1Win7Pack.C1RadioButton c1RadioButton4 = new C1.Win.C1Win7Pack.C1RadioButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskbarButton = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.signInDialog = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.SuspendLayout();
            // 
            // taskbarButton
            // 
            this.taskbarButton.ContainerForm = this;
            this.taskbarButton.JumpList.RefreshOnStartup = true;
            c1JumpTask1.Arguments = "1";
            c1JumpTask1.IconIndex = 1;
            c1JumpTask1.Title = "Available";
            c1JumpTask2.Arguments = "2";
            c1JumpTask2.IconIndex = 1;
            c1JumpTask2.Title = "Busy";
            c1JumpTask3.Arguments = "3";
            c1JumpTask3.IconIndex = 1;
            c1JumpTask3.Title = "Away";
            c1JumpTask4.Arguments = "4";
            c1JumpTask4.IconIndex = 1;
            c1JumpTask4.Title = "Appear offline";
            c1JumpTask6.Arguments = "5";
            c1JumpTask6.IconIndex = 1;
            c1JumpTask6.Title = "Sign in...";
            this.taskbarButton.JumpList.Tasks.AddRange(new C1.Win.C1Win7Pack.C1JumpTask[] {
            c1JumpTask1,
            c1JumpTask2,
            c1JumpTask3,
            c1JumpTask4,
            c1JumpTask5,
            c1JumpTask6});
            this.taskbarButton.WindowAppID = "C1JumpTaskDemo";
            this.taskbarButton.ApplyingJumpListChanges += new System.ComponentModel.CancelEventHandler(this.tm_ApplyingJumpListChanges);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear Tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // signInDialog
            // 
            this.signInDialog.CheckBoxText = "Don\'t ask me again";
            this.signInDialog.CommonButtons = ((C1.Win.C1Win7Pack.TaskDialogCommonButtons)((C1.Win.C1Win7Pack.TaskDialogCommonButtons.Yes | C1.Win.C1Win7Pack.TaskDialogCommonButtons.No)));
            this.signInDialog.Content = "Select the initial status";
            this.signInDialog.MainCustomIcon = ((System.Drawing.Icon)(resources.GetObject("signInDialog.MainCustomIcon")));
            this.signInDialog.MainInstruction = "Are you sure you want to Sign In?";
            this.signInDialog.NextID = 13;
            c1RadioButton1.ID = 9;
            c1RadioButton1.Name = "1";
            c1RadioButton1.Text = "Available";
            c1RadioButton2.ID = 10;
            c1RadioButton2.Name = "2";
            c1RadioButton2.Text = "Busy";
            c1RadioButton3.ID = 11;
            c1RadioButton3.Name = "3";
            c1RadioButton3.Text = "Away";
            c1RadioButton4.ID = 12;
            c1RadioButton4.Name = "4";
            c1RadioButton4.Text = "Appear offline";
            this.signInDialog.RadioButtons.AddRange(new C1.Win.C1Win7Pack.C1RadioButton[] {
            c1RadioButton1,
            c1RadioButton2,
            c1RadioButton3,
            c1RadioButton4});
            this.signInDialog.WindowTitle = "Sign In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 139);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1JumpTask Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Win7Pack.C1TaskbarButton taskbarButton;
        private System.Windows.Forms.Button button1;
        private C1.Win.C1Win7Pack.C1TaskDialog signInDialog;
    }
}

