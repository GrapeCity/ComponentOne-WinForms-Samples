namespace ControlExplorer.Schedule
{
	partial class ExcerciseForm
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
            System.Drawing.Drawing2D.Blend blend1 = new System.Drawing.Drawing2D.Blend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcerciseForm));
            this.cmbLabel = new System.Windows.Forms.ComboBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.tpEnd = new System.Windows.Forms.DateTimePicker();
            this.tpStart = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pnProps = new System.Windows.Forms.Panel();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.pnSubject = new System.Windows.Forms.Panel();
            this.cmbExcercise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnTime.SuspendLayout();
            this.pnProps.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLabel
            // 
            this.cmbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabel.FormattingEnabled = true;
            this.cmbLabel.Location = new System.Drawing.Point(73, 145);
            this.cmbLabel.Name = "cmbLabel";
            this.cmbLabel.Size = new System.Drawing.Size(244, 21);
            this.cmbLabel.TabIndex = 9;
            // 
            // cmbLocation
            // 
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(73, 42);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(244, 21);
            this.cmbLocation.TabIndex = 3;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(8, 147);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.TabIndex = 8;
            this.lblLabel.Text = "Le&vel:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(8, 44);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "&Location:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(8, 10);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "&Exercise:";
            // 
            // pnTime
            // 
            this.pnTime.BackColor = System.Drawing.Color.Transparent;
            this.pnTime.Controls.Add(this.tpEnd);
            this.pnTime.Controls.Add(this.tpStart);
            this.pnTime.Controls.Add(this.dpEnd);
            this.pnTime.Controls.Add(this.dpStart);
            this.pnTime.Controls.Add(this.lblEnd);
            this.pnTime.Controls.Add(this.lblStart);
            this.pnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTime.Location = new System.Drawing.Point(0, 0);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(326, 62);
            this.pnTime.TabIndex = 2;
            // 
            // tpEnd
            // 
            this.tpEnd.CustomFormat = "hh:mm";
            this.tpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpEnd.Location = new System.Drawing.Point(229, 36);
            this.tpEnd.Name = "tpEnd";
            this.tpEnd.ShowUpDown = true;
            this.tpEnd.Size = new System.Drawing.Size(88, 21);
            this.tpEnd.TabIndex = 5;
            // 
            // tpStart
            // 
            this.tpStart.CustomFormat = "hh:mm";
            this.tpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpStart.Location = new System.Drawing.Point(229, 9);
            this.tpStart.Name = "tpStart";
            this.tpStart.ShowUpDown = true;
            this.tpStart.Size = new System.Drawing.Size(88, 21);
            this.tpStart.TabIndex = 2;
            // 
            // dpEnd
            // 
            this.dpEnd.CustomFormat = "MM/dd/yyy";
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpEnd.Location = new System.Drawing.Point(72, 36);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(151, 21);
            this.dpEnd.TabIndex = 4;
            // 
            // dpStart
            // 
            this.dpStart.CustomFormat = "MM/dd/yyy";
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpStart.Location = new System.Drawing.Point(72, 9);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(151, 21);
            this.dpStart.TabIndex = 1;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(8, 40);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(52, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "En&d time:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(8, 13);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start &time:";
            // 
            // pnProps
            // 
            this.pnProps.BackColor = System.Drawing.Color.Transparent;
            this.pnProps.Controls.Add(this.txtBody);
            this.pnProps.Controls.Add(this.pnTime);
            this.pnProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProps.Location = new System.Drawing.Point(0, 176);
            this.pnProps.Name = "pnProps";
            this.pnProps.Size = new System.Drawing.Size(326, 149);
            this.pnProps.TabIndex = 4;
            // 
            // txtBody
            // 
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(0, 62);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(326, 87);
            this.txtBody.TabIndex = 3;
            this.txtBody.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(326, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 22);
            this.btnSave.Text = "&Save and Close";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnSubject
            // 
            this.pnSubject.BackColor = System.Drawing.Color.Transparent;
            this.pnSubject.Controls.Add(this.cmbExcercise);
            this.pnSubject.Controls.Add(this.label2);
            this.pnSubject.Controls.Add(this.label1);
            this.pnSubject.Controls.Add(this.cmbCategory);
            this.pnSubject.Controls.Add(this.cmbInstructor);
            this.pnSubject.Controls.Add(this.cmbLabel);
            this.pnSubject.Controls.Add(this.groupBox1);
            this.pnSubject.Controls.Add(this.lblSubject);
            this.pnSubject.Controls.Add(this.lblLocation);
            this.pnSubject.Controls.Add(this.cmbLocation);
            this.pnSubject.Controls.Add(this.lblLabel);
            this.pnSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubject.Location = new System.Drawing.Point(0, 0);
            this.pnSubject.Name = "pnSubject";
            this.pnSubject.Size = new System.Drawing.Size(326, 176);
            this.pnSubject.TabIndex = 1;
            // 
            // cmbExcercise
            // 
            this.cmbExcercise.FormattingEnabled = true;
            this.cmbExcercise.Items.AddRange(new object[] {
            "LA Spin ",
            "Aerobics",
            "Yoga ",
            "Body Pump",
            "Pilates",
            "Abs and Back Workout",
            "Combat Kickboxing",
            "Kids Parties",
            "Swimming Lessons",
            "Dance Cardio Funk",
            "Swim Time",
            "Yoga Kundalini",
            "Swimming",
            "Step",
            "Aerobics",
            "Yoga Fusion",
            "LA Water Aerobics",
            "Dance Salsa",
            "Tai Chi",
            "Combat Fight",
            "Body Combat",
            "Circuit",
            "Synergize",
            "LA Core Stability",
            "Combat Tae Kwon Do"});
            this.cmbExcercise.Location = new System.Drawing.Point(73, 7);
            this.cmbExcercise.Name = "cmbExcercise";
            this.cmbExcercise.Size = new System.Drawing.Size(244, 21);
            this.cmbExcercise.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Instructor:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(73, 110);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(244, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(73, 76);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(244, 21);
            this.cmbInstructor.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 2);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.BackColor = System.Drawing.Color.LightGray;
            this.c1Sizer1.Controls.Add(this.pnProps);
            this.c1Sizer1.Controls.Add(this.pnSubject);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.Gradient.BackColor2 = System.Drawing.SystemColors.ControlDark;
            blend1.Factors = new float[] {
        0F,
        1F};
            blend1.Positions = new float[] {
        0F,
        1F};
            this.c1Sizer1.Gradient.Blend = blend1;
            this.c1Sizer1.Gradient.Mode = C1.Win.C1Sizer.GradientMode.Vertical;
            this.c1Sizer1.GridDefinition = "97.5384615384615:False:False;\t97.5460122699387:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 25);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(326, 325);
            this.c1Sizer1.TabIndex = 14;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // ExcerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(326, 350);
            this.Controls.Add(this.c1Sizer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(241, 245);
            this.Name = "ExcerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercise";
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.pnProps.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnSubject.ResumeLayout(false);
            this.pnSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ComboBox cmbLabel;
		private System.Windows.Forms.ComboBox cmbLocation;
		private System.Windows.Forms.Label lblLabel;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Panel pnTime;
		private System.Windows.Forms.DateTimePicker tpEnd;
		private System.Windows.Forms.DateTimePicker tpStart;
		private System.Windows.Forms.DateTimePicker dpEnd;
		private System.Windows.Forms.DateTimePicker dpStart;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.Label lblStart;
		private System.Windows.Forms.Panel pnProps;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.Panel pnSubject;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbExcercise;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbInstructor;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
	}
}