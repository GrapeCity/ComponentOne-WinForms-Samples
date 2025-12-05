namespace InputDateRange
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
                try
                {
                    components.Dispose();
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    // Suppress COM exceptions during disposal - this is a known issue with ComponentOne controls
                    // The resources are still cleaned up properly by the .NET garbage collector
                }
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelCalendar = new Panel();
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            resetLabel = new Label();
            listBoxRanges = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnApply = new C1.Win.Input.C1Button();
            labelTotalDays = new C1.Win.Input.C1Label();
            btnCancel = new C1.Win.Input.C1Button();
            panel2 = new Panel();
            c1CalendarView1 = new C1.Win.Calendar.C1CalendarView();
            samplesTitle = new C1.Win.Input.C1Label();
            sampleDescriptionLabel = new C1.Win.Input.C1Label();
            dropDownPanel = new Panel();
            dateSelectedLabel = new C1.Win.Input.C1Label();
            featurePanel = new Panel();
            splitContainer2 = new SplitContainer();
            panel3 = new Panel();
            startDateLabel = new C1.Win.Input.C1Label();
            endDateTextLabel = new C1.Win.Input.C1Label();
            endDateLabel = new C1.Win.Input.C1Label();
            startDateTextLabel = new C1.Win.Input.C1Label();
            yourDateSelectionLabel = new C1.Win.Input.C1Label();
            c1PictureBox3 = new C1.Win.Input.C1PictureBox();
            c1PictureBox2 = new C1.Win.Input.C1PictureBox();
            c1PictureBox1 = new C1.Win.Input.C1PictureBox();
            jpRadioButton = new C1.Win.Input.C1RadioButton();
            krRadioButton = new C1.Win.Input.C1RadioButton();
            usRadioButton = new C1.Win.Input.C1RadioButton();
            rangeLimitNumericEditEx = new InputDateRange.CustomControl.C1NumericEditEx();
            rangeLimitLabel = new C1.Win.Input.C1Label();
            maxDateLabel = new C1.Win.Input.C1Label();
            minDateLabel = new C1.Win.Input.C1Label();
            maxDateDateEdit = new C1.Win.Calendar.C1DateEdit();
            minDateDateEdit = new C1.Win.Calendar.C1DateEdit();
            DateLimitLabel = new C1.Win.Input.C1Label();
            cultureSelectionLabel = new C1.Win.Input.C1Label();
            featureLabel = new Label();
            borderPanel = new Panel();
            toolTip1 = new ToolTip(components);
            panelCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnApply).BeginInit();
            ((System.ComponentModel.ISupportInitialize)labelTotalDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1CalendarView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)samplesTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampleDescriptionLabel).BeginInit();
            dropDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateSelectedLabel).BeginInit();
            featurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)startDateLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endDateTextLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endDateLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startDateTextLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yourDateSelectionLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jpRadioButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)krRadioButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usRadioButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rangeLimitNumericEditEx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rangeLimitLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxDateLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minDateLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxDateDateEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minDateDateEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateLimitLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cultureSelectionLabel).BeginInit();
            borderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelCalendar
            // 
            panelCalendar.BackColor = Color.FromArgb(229, 229, 229);
            panelCalendar.Controls.Add(splitContainer1);
            panelCalendar.Location = new Point(206, 330);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Padding = new Padding(1);
            panelCalendar.Size = new Size(1112, 458);
            panelCalendar.TabIndex = 1;
            panelCalendar.Paint += Panel1_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ControlLight;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(2, 2);
            splitContainer1.Margin = new Padding(5, 5, 5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(1110, 456);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            splitContainer1.Paint += Panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(resetLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(listBoxRanges, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.Size = new Size(219, 456);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // resetLabel
            // 
            resetLabel.Anchor = AnchorStyles.None;
            resetLabel.BackColor = Color.Transparent;
            resetLabel.Cursor = Cursors.Hand;
            resetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resetLabel.ForeColor = Color.FromArgb(40, 90, 120);
            resetLabel.Location = new Point(69, 406);
            resetLabel.Name = "resetLabel";
            resetLabel.Size = new Size(132, 62);
            resetLabel.TabIndex = 1;
            resetLabel.Text = "Reset";
            resetLabel.TextAlign = ContentAlignment.MiddleCenter;
            resetLabel.Click += resetLabel_Click;
            resetLabel.MouseLeave += resetLabel_MouseLeave;
            resetLabel.MouseHover += resetLabel_MouseHover;
            // 
            // listBoxRanges
            // 
            listBoxRanges.Anchor = AnchorStyles.None;
            listBoxRanges.BorderStyle = BorderStyle.None;
            listBoxRanges.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxRanges.Font = new Font("Segoe UI", 9F);
            listBoxRanges.FormattingEnabled = true;
            listBoxRanges.ItemHeight = 25;
            listBoxRanges.Items.AddRange(new object[] { "Custom Range", "This Week", "Last Week", "Next Week", "This Month", "Last Month", "Next Month", "This Year", "Last Year", "Next Year" });
            listBoxRanges.Location = new Point(49, 72);
            listBoxRanges.Name = "listBoxRanges";
            listBoxRanges.Size = new Size(156, 350);
            listBoxRanges.TabIndex = 0;
            listBoxRanges.DrawItem += listBoxRanges_DrawItem;
            listBoxRanges.SelectedIndexChanged += listBoxRanges_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel2.Controls.Add(btnApply, 3, 1);
            tableLayoutPanel2.Controls.Add(labelTotalDays, 0, 1);
            tableLayoutPanel2.Controls.Add(btnCancel, 2, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(5, 5, 5, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.Size = new Size(890, 456);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.None;
            btnApply.Location = new Point(791, 407);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(133, 59);
            btnApply.Styles.Corners = new C1.Framework.Corners(8, 8, 8, 8);
            btnApply.Styles.Default.BackColor = Color.FromArgb(61, 142, 165);
            btnApply.Styles.Default.BorderColor = Color.FromArgb(61, 142, 165);
            btnApply.Styles.Default.ForeColor = Color.White;
            btnApply.TabIndex = 1;
            btnApply.Text = "Apply";
            btnApply.Click += btnApply_Click;
            // 
            // labelTotalDays
            // 
            labelTotalDays.Anchor = AnchorStyles.None;
            labelTotalDays.Location = new Point(18, 412);
            labelTotalDays.Name = "labelTotalDays";
            labelTotalDays.Size = new Size(150, 42);
            labelTotalDays.TabIndex = 3;
            labelTotalDays.Text = "0 Days Selected";
            labelTotalDays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(686, 407);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 59);
            btnCancel.Styles.Corners = new C1.Framework.Corners(8, 8, 8, 8);
            btnCancel.Styles.Default.BackColor = Color.FromArgb(250, 250, 250);
            btnCancel.Styles.Default.BorderColor = Color.FromArgb(104, 118, 130);
            btnCancel.Styles.Default.ForeColor = Color.FromArgb(104, 118, 130);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // panel2
            // 
            tableLayoutPanel2.SetColumnSpan(panel2, 4);
            panel2.Controls.Add(c1CalendarView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 16);
            panel2.Margin = new Padding(16, 16, 16, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(870, 375);
            panel2.TabIndex = 4;
            panel2.Paint += Panel1_Paint;
            // 
            // c1CalendarView1
            // 
            c1CalendarView1.CalendarDimensions = 2;
            c1CalendarView1.CaptionFormat = null;
            c1CalendarView1.CurrentCulture = new System.Globalization.CultureInfo("");
            c1CalendarView1.Dock = DockStyle.Fill;
            c1CalendarView1.Location = new Point(0, 0);
            c1CalendarView1.MaxDate = new DateTime(9999, 12, 31, 0, 0, 0, 0);
            c1CalendarView1.MaxSelectionCount = 366;
            c1CalendarView1.Name = "c1CalendarView1";
            c1CalendarView1.ScrollBars = ScrollBars.None;
            c1CalendarView1.ShowToday = false;
            c1CalendarView1.ShowWeekNumbers = false;
            c1CalendarView1.Size = new Size(870, 375);
            c1CalendarView1.Styles.Common.BackColor = Color.FromArgb(250, 251, 251);
            c1CalendarView1.Styles.Common.BackImageAlignment = C1.Framework.ImageAlignment.CenterCenter;
            c1CalendarView1.Styles.Common.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            c1CalendarView1.Styles.Day.Selected.BackColor = Color.FromArgb(61, 142, 165);
            c1CalendarView1.Styles.Titles.Day.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            c1CalendarView1.Styles.Titles.Day.ForeColor = SystemColors.GrayText;
            c1CalendarView1.Styles.Titles.Day.Margins = new C1.Framework.Thickness(0, 0, 0, 10);
            c1CalendarView1.Styles.Titles.Day.Padding = new C1.Framework.Thickness(10, 15, 10, 15);
            c1CalendarView1.Styles.Titles.Month.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            c1CalendarView1.Styles.Titles.Month.Margins = new C1.Framework.Thickness(0, 0, 0, 20);
            c1CalendarView1.Styles.Titles.Month.Padding = new C1.Framework.Thickness(0, 30, 0, 0);
            c1CalendarView1.Styles.Titles.Week.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            c1CalendarView1.Styles.Titles.Week.Font = new Font("Segoe UI", 7F);
            c1CalendarView1.Styles.Titles.Week.ForeColor = SystemColors.GrayText;
            c1CalendarView1.Styles.Titles.Week.Margins = new C1.Framework.Thickness(0, 0, 0, 10);
            c1CalendarView1.TabIndex = 0;
            c1CalendarView1.Text = "c1CalendarView1";
            c1CalendarView1.DayFormatting += C1CalendarView1_DayFormatting;
            c1CalendarView1.SelectionChanged += c1CalendarView1_SelectionChanged;
            // 
            // samplesTitle
            // 
            samplesTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            samplesTitle.Location = new Point(923, 94);
            samplesTitle.Name = "samplesTitle";
            samplesTitle.Size = new Size(362, 67);
            samplesTitle.TabIndex = 3;
            samplesTitle.Text = "Input Date Range";
            // 
            // sampleDescriptionLabel
            // 
            sampleDescriptionLabel.Font = new Font("Segoe UI", 10F);
            sampleDescriptionLabel.Location = new Point(710, 200);
            sampleDescriptionLabel.Name = "sampleDescriptionLabel";
            sampleDescriptionLabel.Size = new Size(1064, 136);
            sampleDescriptionLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            sampleDescriptionLabel.TabIndex = 4;
            sampleDescriptionLabel.Text = "This sample demonstrates an interactive date range picker using C1CalendarView \r\nwith multi-cultural support. Select date ranges using predefined options or the calendar interface. \r\n\r\n\r\n\r\n\r\n";
            // 
            // dropDownPanel
            // 
            dropDownPanel.BackColor = Color.FromArgb(216, 232, 237);
            dropDownPanel.Controls.Add(dateSelectedLabel);
            dropDownPanel.Location = new Point(2, 2);
            dropDownPanel.Margin = new Padding(5, 5, 5, 5);
            dropDownPanel.Name = "dropDownPanel";
            dropDownPanel.Padding = new Padding(2, 2, 2, 2);
            dropDownPanel.Size = new Size(1362, 246);
            dropDownPanel.TabIndex = 5;
            dropDownPanel.Paint += Panel1_Paint;
            // 
            // dateSelectedLabel
            // 
            dateSelectedLabel.Icon = new C1.Framework.C1BitmapIcon(null, new Size(16, 16), Color.Transparent, Properties.Resources.calendar);
            dateSelectedLabel.ImageAlign = ContentAlignment.MiddleRight;
            dateSelectedLabel.Location = new Point(401, 93);
            dateSelectedLabel.Name = "dateSelectedLabel";
            dateSelectedLabel.Size = new Size(345, 34);
            dateSelectedLabel.Styles.Border = new C1.Framework.Thickness(1, 1, 1, 1);
            dateSelectedLabel.Styles.Corners = new C1.Framework.Corners(4, 4, 4, 4);
            dateSelectedLabel.Styles.Default.BackColor = SystemColors.Control;
            dateSelectedLabel.Styles.Default.ForeColor = SystemColors.GrayText;
            dateSelectedLabel.TabIndex = 3;
            dateSelectedLabel.Text = "Start Date     -     End Date";
            dateSelectedLabel.TextAlign = ContentAlignment.MiddleLeft;
            dateSelectedLabel.Click += DateSelectedLabel_Click;
            // 
            // featurePanel
            // 
            featurePanel.BackColor = Color.FromArgb(99, 112, 125);
            featurePanel.Controls.Add(splitContainer2);
            featurePanel.Location = new Point(525, 622);
            featurePanel.Margin = new Padding(5, 5, 5, 5);
            featurePanel.Name = "featurePanel";
            featurePanel.Padding = new Padding(2, 2, 2, 2);
            featurePanel.Size = new Size(1365, 557);
            featurePanel.TabIndex = 6;
            featurePanel.Paint += Panel1_Paint;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(99, 112, 125);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(2, 2);
            splitContainer2.Margin = new Padding(5, 5, 5, 5);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.White;
            splitContainer2.Panel1.Controls.Add(panel3);
            splitContainer2.Panel1.Controls.Add(yourDateSelectionLabel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer2.Panel2.Controls.Add(c1PictureBox3);
            splitContainer2.Panel2.Controls.Add(c1PictureBox2);
            splitContainer2.Panel2.Controls.Add(c1PictureBox1);
            splitContainer2.Panel2.Controls.Add(jpRadioButton);
            splitContainer2.Panel2.Controls.Add(krRadioButton);
            splitContainer2.Panel2.Controls.Add(usRadioButton);
            splitContainer2.Panel2.Controls.Add(rangeLimitNumericEditEx);
            splitContainer2.Panel2.Controls.Add(rangeLimitLabel);
            splitContainer2.Panel2.Controls.Add(maxDateLabel);
            splitContainer2.Panel2.Controls.Add(minDateLabel);
            splitContainer2.Panel2.Controls.Add(maxDateDateEdit);
            splitContainer2.Panel2.Controls.Add(minDateDateEdit);
            splitContainer2.Panel2.Controls.Add(DateLimitLabel);
            splitContainer2.Panel2.Controls.Add(cultureSelectionLabel);
            splitContainer2.Panel2.Controls.Add(featureLabel);
            splitContainer2.Size = new Size(1361, 553);
            splitContainer2.SplitterDistance = 805;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            splitContainer2.Paint += Panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(216, 232, 237);
            panel3.Controls.Add(startDateLabel);
            panel3.Controls.Add(endDateTextLabel);
            panel3.Controls.Add(endDateLabel);
            panel3.Controls.Add(startDateTextLabel);
            panel3.Location = new Point(51, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 131);
            panel3.TabIndex = 1;
            panel3.Paint += Panel1_Paint;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startDateLabel.Location = new Point(231, 30);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(355, 57);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "No selected start date";
            // 
            // endDateTextLabel
            // 
            endDateTextLabel.AutoSize = true;
            endDateTextLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            endDateTextLabel.Location = new Point(31, 112);
            endDateTextLabel.Name = "endDateTextLabel";
            endDateTextLabel.Size = new Size(173, 57);
            endDateTextLabel.TabIndex = 2;
            endDateTextLabel.Text = "End Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            endDateLabel.Location = new Point(231, 112);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(342, 57);
            endDateLabel.TabIndex = 1;
            endDateLabel.Text = "No selected end date";
            // 
            // startDateTextLabel
            // 
            startDateTextLabel.AutoSize = true;
            startDateTextLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDateTextLabel.Location = new Point(31, 30);
            startDateTextLabel.Name = "startDateTextLabel";
            startDateTextLabel.Size = new Size(188, 57);
            startDateTextLabel.TabIndex = 0;
            startDateTextLabel.Text = "Start Date:";
            // 
            // yourDateSelectionLabel
            // 
            yourDateSelectionLabel.AutoSize = true;
            yourDateSelectionLabel.Location = new Point(180, 91);
            yourDateSelectionLabel.Name = "yourDateSelectionLabel";
            yourDateSelectionLabel.Size = new Size(468, 77);
            yourDateSelectionLabel.Styles.Default.ForeColor = Color.FromArgb(61, 142, 165);
            yourDateSelectionLabel.Styles.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yourDateSelectionLabel.TabIndex = 0;
            yourDateSelectionLabel.Text = "Your Date Selection";
            // 
            // c1PictureBox3
            // 
            c1PictureBox3.Image = Properties.Resources.c1PictureBox3_Image;
            c1PictureBox3.Location = new Point(109, 253);
            c1PictureBox3.Name = "c1PictureBox3";
            c1PictureBox3.Size = new Size(18, 18);
            c1PictureBox3.TabIndex = 18;
            c1PictureBox3.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox3, "Controls the maximum number of days that can be selected at once.\r\nPrevents selecting more dates than the specified");
            // 
            // c1PictureBox2
            // 
            c1PictureBox2.Image = Properties.Resources.c1PictureBox2_Image;
            c1PictureBox2.Location = new Point(161, 242);
            c1PictureBox2.Margin = new Padding(5, 5, 5, 5);
            c1PictureBox2.Name = "c1PictureBox2";
            c1PictureBox2.Size = new Size(18, 18);
            c1PictureBox2.TabIndex = 17;
            c1PictureBox2.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox2, "Sets the minimum and maximum selectable dates in the calendar. \r\nDates outside this range will be disabled");
            // 
            // c1PictureBox1
            // 
            c1PictureBox1.Image = Properties.Resources.c1PictureBox1_Image;
            c1PictureBox1.Location = new Point(237, 122);
            c1PictureBox1.Margin = new Padding(5, 5, 5, 5);
            c1PictureBox1.Name = "c1PictureBox1";
            c1PictureBox1.Size = new Size(18, 18);
            c1PictureBox1.TabIndex = 8;
            c1PictureBox1.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox1, "Changes the display language and date format. \r\nSwitch between English, Korean, and Japanese");
            // 
            // jpRadioButton
            // 
            jpRadioButton.AutoSize = true;
            jpRadioButton.Location = new Point(158, 165);
            jpRadioButton.Name = "jpRadioButton";
            jpRadioButton.Size = new Size(106, 38);
            jpRadioButton.TabIndex = 16;
            jpRadioButton.TabStop = true;
            jpRadioButton.Text = "ja-JP";
            jpRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // krRadioButton
            // 
            krRadioButton.AutoSize = true;
            krRadioButton.Location = new Point(271, 165);
            krRadioButton.Name = "krRadioButton";
            krRadioButton.Size = new Size(120, 38);
            krRadioButton.TabIndex = 15;
            krRadioButton.TabStop = true;
            krRadioButton.Text = "ko-KR";
            krRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // usRadioButton
            // 
            usRadioButton.AutoSize = true;
            usRadioButton.Location = new Point(32, 165);
            usRadioButton.Name = "usRadioButton";
            usRadioButton.Size = new Size(122, 38);
            usRadioButton.TabIndex = 13;
            usRadioButton.TabStop = true;
            usRadioButton.Text = "en-US";
            usRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rangeLimitNumericEditEx
            // 
            rangeLimitNumericEditEx.Location = new Point(23, 280);
            rangeLimitNumericEditEx.Maximum = 99999;
            rangeLimitNumericEditEx.Name = "rangeLimitNumericEditEx";
            rangeLimitNumericEditEx.Size = new Size(195, 40);
            rangeLimitNumericEditEx.TabIndex = 12;
            rangeLimitNumericEditEx.Value = new decimal(new int[] { 366, 0, 0, 0 });
            rangeLimitNumericEditEx.ValueChanged += RangeLimit_ValueChanged;
            // 
            // rangeLimitLabel
            // 
            rangeLimitLabel.AutoSize = true;
            rangeLimitLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rangeLimitLabel.Location = new Point(18, 248);
            rangeLimitLabel.Name = "rangeLimitLabel";
            rangeLimitLabel.Size = new Size(156, 44);
            rangeLimitLabel.TabIndex = 11;
            rangeLimitLabel.Text = "Range Limit";
            // 
            // maxDateLabel
            // 
            maxDateLabel.AutoSize = true;
            maxDateLabel.Font = new Font("Segoe UI", 7F);
            maxDateLabel.Location = new Point(306, 277);
            maxDateLabel.Name = "maxDateLabel";
            maxDateLabel.Size = new Size(104, 37);
            maxDateLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            maxDateLabel.TabIndex = 10;
            maxDateLabel.Text = "Max Date";
            // 
            // minDateLabel
            // 
            minDateLabel.AutoSize = true;
            minDateLabel.Font = new Font("Segoe UI", 7F);
            minDateLabel.Location = new Point(29, 277);
            minDateLabel.Name = "minDateLabel";
            minDateLabel.Size = new Size(101, 37);
            minDateLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            minDateLabel.TabIndex = 9;
            minDateLabel.Text = "Min Date";
            // 
            // maxDateDateEdit
            // 
            maxDateDateEdit.ButtonsSettings.DropDownButton.Icon = new C1.Framework.C1BitmapIcon(null, new Size(17, 18), Color.Transparent, Properties.Resources.calendar);
            maxDateDateEdit.ButtonsSettings.DropDownButton.Width = 24;
            maxDateDateEdit.ButtonsSettings.UpDownButton.Visible = false;
            maxDateDateEdit.Calendar.ShowClearButton = false;
            maxDateDateEdit.Calendar.ShowToday = false;
            maxDateDateEdit.CustomFormat = "dd/MM/yyyy";
            maxDateDateEdit.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            maxDateDateEdit.DisplayFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            maxDateDateEdit.DisplayFormat.Inherit = C1.Win.Input.FormatInfoInheritProperties.NullText | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull | C1.Win.Input.FormatInfoInheritProperties.TrimStart | C1.Win.Input.FormatInfoInheritProperties.TrimEnd | C1.Win.Input.FormatInfoInheritProperties.CalendarType;
            maxDateDateEdit.EditFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            maxDateDateEdit.EditFormat.Inherit = C1.Win.Input.FormatInfoInheritProperties.CustomFormat | C1.Win.Input.FormatInfoInheritProperties.NullText | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull | C1.Win.Input.FormatInfoInheritProperties.TrimStart | C1.Win.Input.FormatInfoInheritProperties.TrimEnd | C1.Win.Input.FormatInfoInheritProperties.CalendarType;
            maxDateDateEdit.FormatType = C1.Win.Input.FormatType.CustomFormat;
            maxDateDateEdit.Location = new Point(196, 202);
            maxDateDateEdit.Name = "maxDateDateEdit";
            maxDateDateEdit.Size = new Size(193, 40);
            maxDateDateEdit.TabIndex = 8;
            maxDateDateEdit.ValueChanged += DateLimit_ValueChanged;
            // 
            // minDateDateEdit
            // 
            minDateDateEdit.ButtonsSettings.DropDownButton.Icon = new C1.Framework.C1BitmapIcon(null, new Size(17, 18), Color.Transparent, Properties.Resources.calendar);
            minDateDateEdit.ButtonsSettings.DropDownButton.Width = 24;
            minDateDateEdit.ButtonsSettings.UpDownButton.Visible = false;
            minDateDateEdit.Calendar.ShowClearButton = false;
            minDateDateEdit.Calendar.ShowToday = false;
            minDateDateEdit.CustomFormat = "dd/MM/yyyy";
            minDateDateEdit.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            minDateDateEdit.DisplayFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            minDateDateEdit.DisplayFormat.Inherit = C1.Win.Input.FormatInfoInheritProperties.NullText | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull | C1.Win.Input.FormatInfoInheritProperties.TrimStart | C1.Win.Input.FormatInfoInheritProperties.TrimEnd | C1.Win.Input.FormatInfoInheritProperties.CalendarType;
            minDateDateEdit.EditFormat.FormatType = C1.Win.Input.FormatType.CustomFormat;
            minDateDateEdit.EditFormat.Inherit = C1.Win.Input.FormatInfoInheritProperties.CustomFormat | C1.Win.Input.FormatInfoInheritProperties.NullText | C1.Win.Input.FormatInfoInheritProperties.EmptyAsNull | C1.Win.Input.FormatInfoInheritProperties.TrimStart | C1.Win.Input.FormatInfoInheritProperties.TrimEnd | C1.Win.Input.FormatInfoInheritProperties.CalendarType;
            minDateDateEdit.FormatType = C1.Win.Input.FormatType.CustomFormat;
            minDateDateEdit.Location = new Point(24, 202);
            minDateDateEdit.Name = "minDateDateEdit";
            minDateDateEdit.Size = new Size(193, 40);
            minDateDateEdit.TabIndex = 7;
            minDateDateEdit.ValueChanged += DateLimit_ValueChanged;
            // 
            // DateLimitLabel
            // 
            DateLimitLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DateLimitLabel.Location = new Point(29, 232);
            DateLimitLabel.Name = "DateLimitLabel";
            DateLimitLabel.Size = new Size(153, 42);
            DateLimitLabel.TabIndex = 6;
            DateLimitLabel.Text = "Date Limit";
            // 
            // cultureSelectionLabel
            // 
            cultureSelectionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cultureSelectionLabel.Location = new Point(29, 114);
            cultureSelectionLabel.Name = "cultureSelectionLabel";
            cultureSelectionLabel.Size = new Size(219, 42);
            cultureSelectionLabel.TabIndex = 1;
            cultureSelectionLabel.Text = "Culture Selection";
            // 
            // featureLabel
            // 
            featureLabel.AutoSize = true;
            featureLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureLabel.Location = new Point(29, 29);
            featureLabel.Margin = new Padding(5, 0, 5, 0);
            featureLabel.Name = "featureLabel";
            featureLabel.Size = new Size(130, 45);
            featureLabel.TabIndex = 0;
            featureLabel.Text = "Feature";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = Color.FromArgb(99, 112, 125);
            borderPanel.Controls.Add(dropDownPanel);
            borderPanel.Location = new Point(533, 346);
            borderPanel.Margin = new Padding(5, 5, 5, 5);
            borderPanel.Name = "borderPanel";
            borderPanel.Padding = new Padding(2, 2, 2, 2);
            borderPanel.Size = new Size(1365, 250);
            borderPanel.TabIndex = 7;
            borderPanel.Paint += Panel1_Paint;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1543, 956);
            Controls.Add(samplesTitle);
            Controls.Add(sampleDescriptionLabel);
            Controls.Add(panelCalendar);
            Controls.Add(borderPanel);
            Controls.Add(featurePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Date Range";
            panelCalendar.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnApply).EndInit();
            ((System.ComponentModel.ISupportInitialize)labelTotalDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCancel).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1CalendarView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)samplesTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampleDescriptionLabel).EndInit();
            dropDownPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateSelectedLabel).EndInit();
            featurePanel.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)startDateLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)endDateTextLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)endDateLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)startDateTextLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)yourDateSelectionLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)jpRadioButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)krRadioButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)usRadioButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)rangeLimitNumericEditEx).EndInit();
            ((System.ComponentModel.ISupportInitialize)rangeLimitLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxDateLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)minDateLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxDateDateEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)minDateDateEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateLimitLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)cultureSelectionLabel).EndInit();
            borderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCalendar;
        private SplitContainer splitContainer1;
        private ListBox listBoxRanges;
        private C1.Win.Calendar.C1CalendarView c1CalendarView1;
        private C1.Win.Input.C1Button btnCancel;
        private C1.Win.Input.C1Button btnApply;
        private TableLayoutPanel tableLayoutPanel1;
        private Label resetLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private C1.Win.Input.C1Label labelTotalDays;
        private Panel panel2;
        private C1.Win.Input.C1Label samplesTitle;
        private C1.Win.Input.C1Label sampleDescriptionLabel;
        private Panel dropDownPanel;
        private Panel featurePanel;
        private SplitContainer splitContainer2;
        private C1.Win.Input.C1Label cultureSelectionLabel;
        private Label featureLabel;
        private C1.Win.Calendar.C1DateEdit minDateDateEdit;
        private C1.Win.Input.C1Label DateLimitLabel;
        private C1.Win.Calendar.C1DateEdit maxDateDateEdit;
        private C1.Win.Input.C1Label maxDateLabel;
        private C1.Win.Input.C1Label minDateLabel;
        private C1.Win.Input.C1Label rangeLimitLabel;
        private CustomControl.C1NumericEditEx rangeLimitNumericEditEx;
        private C1.Win.Input.C1Label yourDateSelectionLabel;
        private C1.Win.Input.C1RadioButton jpRadioButton;
        private C1.Win.Input.C1RadioButton krRadioButton;
        private C1.Win.Input.C1RadioButton usRadioButton;
        private Panel panel3;
        private C1.Win.Input.C1Label startDateLabel;
        private C1.Win.Input.C1Label endDateLabel;
        private C1.Win.Input.C1Label dateSelectedLabel;
        private Panel borderPanel;
        private C1.Win.Input.C1Label endDateTextLabel;
        private C1.Win.Input.C1Label startDateTextLabel;
        private C1.Win.Input.C1PictureBox c1PictureBox2;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private C1.Win.Input.C1PictureBox c1PictureBox3;
        private ToolTip toolTip1;
    }
}
