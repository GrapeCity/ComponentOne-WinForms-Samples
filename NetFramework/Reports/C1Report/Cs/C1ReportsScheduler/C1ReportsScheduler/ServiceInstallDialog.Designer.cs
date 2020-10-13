namespace C1ReportsScheduler
{
    partial class ServiceInstallDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWcfEndpointBaseAddress = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWcfEndpointRelAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC1rsconfFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnC1rsconfFilePath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtStartupManual = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtStartupAuto = new System.Windows.Forms.RadioButton();
            this.chkLogTasks = new System.Windows.Forms.CheckBox();
            this.chkLogActions = new System.Windows.Forms.CheckBox();
            this.chkLogProgramOutput = new System.Windows.Forms.CheckBox();
            this.chkEnableMex = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WCF endpoint base address:";
            // 
            // txtWcfEndpointBaseAddress
            // 
            this.txtWcfEndpointBaseAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWcfEndpointBaseAddress.Location = new System.Drawing.Point(180, 12);
            this.txtWcfEndpointBaseAddress.Name = "txtWcfEndpointBaseAddress";
            this.txtWcfEndpointBaseAddress.Size = new System.Drawing.Size(485, 20);
            this.txtWcfEndpointBaseAddress.TabIndex = 1;
            this.txtWcfEndpointBaseAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtWcfEndpointBaseAddress_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(509, 284);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(590, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ".c1rsconf configuration file path:";
            // 
            // txtWcfEndpointRelAddress
            // 
            this.txtWcfEndpointRelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWcfEndpointRelAddress.Location = new System.Drawing.Point(180, 62);
            this.txtWcfEndpointRelAddress.Name = "txtWcfEndpointRelAddress";
            this.txtWcfEndpointRelAddress.Size = new System.Drawing.Size(485, 20);
            this.txtWcfEndpointRelAddress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(e.g. \"C1ReportsSchedulerService\")";
            // 
            // txtC1rsconfFilePath
            // 
            this.txtC1rsconfFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtC1rsconfFilePath.Location = new System.Drawing.Point(180, 112);
            this.txtC1rsconfFilePath.Name = "txtC1rsconfFilePath";
            this.txtC1rsconfFilePath.Size = new System.Drawing.Size(462, 20);
            this.txtC1rsconfFilePath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "(e.g. \"net.tcp://localhost:8012/ComponentOneLLC\")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "WCF endpoint relative address:";
            // 
            // btnC1rsconfFilePath
            // 
            this.btnC1rsconfFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC1rsconfFilePath.AutoSize = true;
            this.btnC1rsconfFilePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnC1rsconfFilePath.Location = new System.Drawing.Point(642, 110);
            this.btnC1rsconfFilePath.Name = "btnC1rsconfFilePath";
            this.btnC1rsconfFilePath.Size = new System.Drawing.Size(23, 23);
            this.btnC1rsconfFilePath.TabIndex = 8;
            this.btnC1rsconfFilePath.Text = "…";
            this.btnC1rsconfFilePath.UseVisualStyleBackColor = true;
            this.btnC1rsconfFilePath.Click += new System.EventHandler(this.btnC1rsconfFilePath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "(e.g. \"c:\\tasklilst.c1rsconf\")";
            // 
            // rbtStartupManual
            // 
            this.rbtStartupManual.AutoSize = true;
            this.rbtStartupManual.Checked = true;
            this.rbtStartupManual.Location = new System.Drawing.Point(180, 163);
            this.rbtStartupManual.Name = "rbtStartupManual";
            this.rbtStartupManual.Size = new System.Drawing.Size(60, 17);
            this.rbtStartupManual.TabIndex = 11;
            this.rbtStartupManual.TabStop = true;
            this.rbtStartupManual.Text = "Manual";
            this.rbtStartupManual.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Service startup type:";
            // 
            // rbtStartupAuto
            // 
            this.rbtStartupAuto.AutoSize = true;
            this.rbtStartupAuto.Location = new System.Drawing.Point(277, 163);
            this.rbtStartupAuto.Name = "rbtStartupAuto";
            this.rbtStartupAuto.Size = new System.Drawing.Size(72, 17);
            this.rbtStartupAuto.TabIndex = 12;
            this.rbtStartupAuto.Text = "Automatic";
            this.rbtStartupAuto.UseVisualStyleBackColor = true;
            // 
            // chkLogTasks
            // 
            this.chkLogTasks.AutoSize = true;
            this.chkLogTasks.Location = new System.Drawing.Point(180, 186);
            this.chkLogTasks.Name = "chkLogTasks";
            this.chkLogTasks.Size = new System.Drawing.Size(283, 17);
            this.chkLogTasks.TabIndex = 13;
            this.chkLogTasks.Text = "Log scheduled tasks (may generate a lot of log entries)";
            this.chkLogTasks.UseVisualStyleBackColor = true;
            // 
            // chkLogActions
            // 
            this.chkLogActions.AutoSize = true;
            this.chkLogActions.Location = new System.Drawing.Point(180, 209);
            this.chkLogActions.Name = "chkLogActions";
            this.chkLogActions.Size = new System.Drawing.Size(340, 17);
            this.chkLogActions.TabIndex = 14;
            this.chkLogActions.Text = "Log scheduled tasks\' actions (may generate even more log entries)";
            this.chkLogActions.UseVisualStyleBackColor = true;
            // 
            // chkLogProgramOutput
            // 
            this.chkLogProgramOutput.AutoSize = true;
            this.chkLogProgramOutput.Location = new System.Drawing.Point(180, 232);
            this.chkLogProgramOutput.Name = "chkLogProgramOutput";
            this.chkLogProgramOutput.Size = new System.Drawing.Size(317, 17);
            this.chkLogProgramOutput.TabIndex = 15;
            this.chkLogProgramOutput.Text = "Log scheduled \"external program\" type tasks\' program output.";
            this.chkLogProgramOutput.UseVisualStyleBackColor = true;
            // 
            // chkEnableMex
            // 
            this.chkEnableMex.AutoSize = true;
            this.chkEnableMex.Location = new System.Drawing.Point(180, 255);
            this.chkEnableMex.Name = "chkEnableMex";
            this.chkEnableMex.Size = new System.Drawing.Size(355, 17);
            this.chkEnableMex.TabIndex = 16;
            this.chkEnableMex.Text = "Enable metadata exchange (leave this unchecked unless you need it)";
            this.chkEnableMex.UseVisualStyleBackColor = true;
            // 
            // ServiceInstallDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(677, 319);
            this.ControlBox = false;
            this.Controls.Add(this.chkEnableMex);
            this.Controls.Add(this.chkLogProgramOutput);
            this.Controls.Add(this.chkLogActions);
            this.Controls.Add(this.chkLogTasks);
            this.Controls.Add(this.rbtStartupAuto);
            this.Controls.Add(this.rbtStartupManual);
            this.Controls.Add(this.btnC1rsconfFilePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtC1rsconfFilePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWcfEndpointRelAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWcfEndpointBaseAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ServiceInstallDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ServiceInstallDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWcfEndpointBaseAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWcfEndpointRelAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC1rsconfFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnC1rsconfFilePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtStartupManual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtStartupAuto;
        private System.Windows.Forms.CheckBox chkLogTasks;
        private System.Windows.Forms.CheckBox chkLogActions;
        private System.Windows.Forms.CheckBox chkLogProgramOutput;
        private System.Windows.Forms.CheckBox chkEnableMex;
    }
}