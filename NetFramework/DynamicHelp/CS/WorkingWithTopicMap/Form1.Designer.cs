namespace WorkingWithTopicMap
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
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadFrom = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnLoadFromRes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.HelpSource = "C1Sample.chm";
            this.c1DynamicHelp1.Location = new System.Drawing.Point(381, 0);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(250, 382);
            this.c1DynamicHelp1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 64);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(244, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load topic map from the default location";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoadFrom
            // 
            this.btnLoadFrom.Location = new System.Drawing.Point(6, 93);
            this.btnLoadFrom.Name = "btnLoadFrom";
            this.btnLoadFrom.Size = new System.Drawing.Size(244, 23);
            this.btnLoadFrom.TabIndex = 2;
            this.btnLoadFrom.Text = "Load topic map from file...";
            this.btnLoadFrom.UseVisualStyleBackColor = true;
            this.btnLoadFrom.Click += new System.EventHandler(this.btnLoadFrom_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save topic map to the default location";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(6, 113);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(244, 23);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "Save topic map to a file...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnLoadFromRes
            // 
            this.btnLoadFromRes.Location = new System.Drawing.Point(6, 124);
            this.btnLoadFromRes.Name = "btnLoadFromRes";
            this.btnLoadFromRes.Size = new System.Drawing.Size(244, 23);
            this.btnLoadFromRes.TabIndex = 5;
            this.btnLoadFromRes.Text = "Load topic map from resources";
            this.btnLoadFromRes.UseVisualStyleBackColor = true;
            this.btnLoadFromRes.Click += new System.EventHandler(this.btnLoadFromRes_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loading different topic maps, note that different topics will be displayed when y" +
                "ou move the mouse over the form surface.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 64);
            this.label2.TabIndex = 7;
            this.label2.Text = "Activate authoring mode by pressing Ctrl+Shift+A, then you will be able to change" +
                " the currently loaded topic map. Then you can save it to a file and load it back" +
                ".";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnLoadFrom);
            this.groupBox1.Controls.Add(this.btnLoadFromRes);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load topic map";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSaveAs);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(27, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 149);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify and save topic map";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1DynamicHelp1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoadFrom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnLoadFromRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

