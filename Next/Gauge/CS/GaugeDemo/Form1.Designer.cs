namespace GaugeDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.samplesTree = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "C1Gauge Capabilities";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.samplesTree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(260, 468);
            this.panel2.TabIndex = 1;
            // 
            // samplesTree
            // 
            this.samplesTree.BackColor = System.Drawing.SystemColors.Window;
            this.samplesTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.samplesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesTree.HideSelection = false;
            this.samplesTree.Location = new System.Drawing.Point(4, 4);
            this.samplesTree.Name = "samplesTree";
            this.samplesTree.Size = new System.Drawing.Size(152, 460);
            this.samplesTree.TabIndex = 0;
            this.samplesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.samplesTree_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SteelBlue;
            this.splitter1.Location = new System.Drawing.Point(160, 42);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 468);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(164, 42);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Padding = new System.Windows.Forms.Padding(4);
            this.hostPanel.Size = new System.Drawing.Size(620, 468);
            this.hostPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(784, 4);
            this.label2.TabIndex = 4;
            // 
            // hsButton
            // 
            this.hsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hsButton.BackColor = System.Drawing.SystemColors.Control;
            this.hsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hsButton.Location = new System.Drawing.Point(1088, 45);
            this.hsButton.Name = "hsButton";
            this.hsButton.Size = new System.Drawing.Size(58, 30);
            this.hsButton.TabIndex = 0;
            this.hsButton.TabStop = false;
            this.hsButton.Text = "hide";
            this.hsButton.UseVisualStyleBackColor = false;
            this.hsButton.Visible = false;
            this.hsButton.Click += new System.EventHandler(this.hsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1150, 810);
            this.Controls.Add(this.hsButton);
            this.Controls.Add(this.hostPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(535, 370);
            this.Name = "Form1";
            this.Text = "C1Gauge Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel hostPanel;
        private System.Windows.Forms.TreeView samplesTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hsButton;
    }
}

