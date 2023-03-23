namespace CustomData
{
	partial class ExerciseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseForm));
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
			this.cmbExercise = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.cmbInstructor = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnTime.SuspendLayout();
			this.pnProps.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.pnSubject.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbLabel
			// 
			this.cmbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLabel.FormattingEnabled = true;
			this.cmbLabel.Location = new System.Drawing.Point(91, 181);
			this.cmbLabel.Margin = new System.Windows.Forms.Padding(4);
			this.cmbLabel.Name = "cmbLabel";
			this.cmbLabel.Size = new System.Drawing.Size(304, 25);
			this.cmbLabel.TabIndex = 9;
			// 
			// cmbLocation
			// 
			this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLocation.FormattingEnabled = true;
			this.cmbLocation.Location = new System.Drawing.Point(91, 52);
			this.cmbLocation.Margin = new System.Windows.Forms.Padding(4);
			this.cmbLocation.Name = "cmbLocation";
			this.cmbLocation.Size = new System.Drawing.Size(304, 25);
			this.cmbLocation.TabIndex = 3;
			// 
			// lblLabel
			// 
			this.lblLabel.AutoSize = true;
			this.lblLabel.Location = new System.Drawing.Point(10, 184);
			this.lblLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLabel.Name = "lblLabel";
			this.lblLabel.Size = new System.Drawing.Size(44, 17);
			this.lblLabel.TabIndex = 8;
			this.lblLabel.Text = "Le&vel:";
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(10, 55);
			this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(65, 17);
			this.lblLocation.TabIndex = 2;
			this.lblLocation.Text = "&Location:";
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(10, 12);
			this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(70, 17);
			this.lblSubject.TabIndex = 0;
			this.lblSubject.Text = "&Exercise:";
			// 
			// pnTime
			// 
			this.pnTime.Controls.Add(this.tpEnd);
			this.pnTime.Controls.Add(this.tpStart);
			this.pnTime.Controls.Add(this.dpEnd);
			this.pnTime.Controls.Add(this.dpStart);
			this.pnTime.Controls.Add(this.lblEnd);
			this.pnTime.Controls.Add(this.lblStart);
			this.pnTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnTime.Location = new System.Drawing.Point(0, 245);
			this.pnTime.Margin = new System.Windows.Forms.Padding(4);
			this.pnTime.Name = "pnTime";
			this.pnTime.Size = new System.Drawing.Size(408, 77);
			this.pnTime.TabIndex = 2;
			// 
			// tpEnd
			// 
			this.tpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.tpEnd.Location = new System.Drawing.Point(286, 45);
			this.tpEnd.Margin = new System.Windows.Forms.Padding(4);
			this.tpEnd.Name = "tpEnd";
			this.tpEnd.ShowUpDown = true;
			this.tpEnd.Size = new System.Drawing.Size(109, 24);
			this.tpEnd.TabIndex = 5;
			// 
			// tpStart
			// 
			this.tpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.tpStart.Location = new System.Drawing.Point(286, 11);
			this.tpStart.Margin = new System.Windows.Forms.Padding(4);
			this.tpStart.Name = "tpStart";
			this.tpStart.ShowUpDown = true;
			this.tpStart.Size = new System.Drawing.Size(109, 24);
			this.tpStart.TabIndex = 2;
			// 
			// dpEnd
			// 
			this.dpEnd.CustomFormat = "MM/dd/yyy";
			this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpEnd.Location = new System.Drawing.Point(90, 45);
			this.dpEnd.Margin = new System.Windows.Forms.Padding(4);
			this.dpEnd.Name = "dpEnd";
			this.dpEnd.Size = new System.Drawing.Size(188, 24);
			this.dpEnd.TabIndex = 4;
			// 
			// dpStart
			// 
			this.dpStart.CustomFormat = "MM/dd/yyy";
			this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpStart.Location = new System.Drawing.Point(90, 11);
			this.dpStart.Margin = new System.Windows.Forms.Padding(4);
			this.dpStart.Name = "dpStart";
			this.dpStart.Size = new System.Drawing.Size(188, 24);
			this.dpStart.TabIndex = 1;
			// 
			// lblEnd
			// 
			this.lblEnd.AutoSize = true;
			this.lblEnd.Location = new System.Drawing.Point(10, 50);
			this.lblEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblEnd.Name = "lblEnd";
			this.lblEnd.Size = new System.Drawing.Size(67, 17);
			this.lblEnd.TabIndex = 3;
			this.lblEnd.Text = "En&d time:";
			// 
			// lblStart
			// 
			this.lblStart.AutoSize = true;
			this.lblStart.Location = new System.Drawing.Point(10, 16);
			this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(73, 17);
			this.lblStart.TabIndex = 0;
			this.lblStart.Text = "Start &time:";
			// 
			// pnProps
			// 
			this.pnProps.Controls.Add(this.txtBody);
			this.pnProps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnProps.Location = new System.Drawing.Point(0, 322);
			this.pnProps.Margin = new System.Windows.Forms.Padding(4);
			this.pnProps.Name = "pnProps";
			this.pnProps.Size = new System.Drawing.Size(408, 115);
			this.pnProps.TabIndex = 4;
			// 
			// txtBody
			// 
			this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBody.Location = new System.Drawing.Point(0, 0);
			this.txtBody.Margin = new System.Windows.Forms.Padding(4);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(408, 115);
			this.txtBody.TabIndex = 3;
			this.txtBody.Text = "";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(408, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnSave
			// 
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 22);
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
			this.btnDelete.Size = new System.Drawing.Size(53, 22);
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// pnSubject
			// 
			this.pnSubject.Controls.Add(this.cmbExercise);
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
			this.pnSubject.Location = new System.Drawing.Point(0, 25);
			this.pnSubject.Margin = new System.Windows.Forms.Padding(4);
			this.pnSubject.Name = "pnSubject";
			this.pnSubject.Size = new System.Drawing.Size(408, 220);
			this.pnSubject.TabIndex = 1;
			// 
			// cmbExercise
			// 
			this.cmbExercise.FormattingEnabled = true;
			this.cmbExercise.Items.AddRange(new object[] {
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
			this.cmbExercise.Location = new System.Drawing.Point(91, 9);
			this.cmbExercise.Margin = new System.Windows.Forms.Padding(4);
			this.cmbExercise.Name = "cmbExercise";
			this.cmbExercise.Size = new System.Drawing.Size(304, 25);
			this.cmbExercise.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 141);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "&Category:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 98);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "&Instructor:";
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(91, 138);
			this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(304, 25);
			this.cmbCategory.TabIndex = 7;
			// 
			// cmbInstructor
			// 
			this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInstructor.FormattingEnabled = true;
			this.cmbInstructor.Location = new System.Drawing.Point(91, 95);
			this.cmbInstructor.Margin = new System.Windows.Forms.Padding(4);
			this.cmbInstructor.Name = "cmbInstructor";
			this.cmbInstructor.Size = new System.Drawing.Size(304, 25);
			this.cmbInstructor.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 218);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(408, 2);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// ExerciseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(408, 437);
			this.Controls.Add(this.pnProps);
			this.Controls.Add(this.pnTime);
			this.Controls.Add(this.pnSubject);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "ExerciseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Exercise";
			this.pnTime.ResumeLayout(false);
			this.pnTime.PerformLayout();
			this.pnProps.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.pnSubject.ResumeLayout(false);
			this.pnSubject.PerformLayout();
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
		private System.Windows.Forms.ComboBox cmbExercise;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.ComboBox cmbInstructor;
	}
}