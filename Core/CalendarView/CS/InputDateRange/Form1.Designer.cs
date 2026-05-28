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
            samplesTitle = new C1.Win.Input.C1Label();
            sampleDescriptionLabel = new C1.Win.Input.C1Label();
            dropDownPanel = new Panel();
            c1DateRangeEdit1 = new C1.Win.Calendar.C1DateRangeEdit();
            featurePanel = new Panel();
            splitContainer2 = new SplitContainer();
            panel3 = new Panel();
            startDateLabel = new C1.Win.Input.C1Label();
            endDateTextLabel = new C1.Win.Input.C1Label();
            endDateLabel = new C1.Win.Input.C1Label();
            startDateTextLabel = new C1.Win.Input.C1Label();
            yourDateSelectionLabel = new C1.Win.Input.C1Label();
            c1PictureBox4 = new C1.Win.Input.C1PictureBox();
            calendarDimensionNumericEditEx = new InputDateRange.CustomControl.C1NumericEditEx();
            calendarDimensionLabel = new C1.Win.Input.C1Label();
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
            ((System.ComponentModel.ISupportInitialize)samplesTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sampleDescriptionLabel).BeginInit();
            dropDownPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1DateRangeEdit1).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)c1PictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarDimensionNumericEditEx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calendarDimensionLabel).BeginInit();
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
            // samplesTitle
            // 
            samplesTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            samplesTitle.Location = new Point(566, 48);
            samplesTitle.Name = "samplesTitle";
            samplesTitle.Size = new Size(407, 73);
            samplesTitle.TabIndex = 3;
            samplesTitle.Text = "Input Date Range";
            // 
            // sampleDescriptionLabel
            // 
            sampleDescriptionLabel.Font = new Font("Segoe UI", 10F);
            sampleDescriptionLabel.Location = new Point(437, 116);
            sampleDescriptionLabel.Name = "sampleDescriptionLabel";
            sampleDescriptionLabel.Size = new Size(655, 94);
            sampleDescriptionLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            sampleDescriptionLabel.TabIndex = 4;
            sampleDescriptionLabel.Text = "This sample demonstrates an interactive date range picker using C1DateRangeEdit \r\nwith multi-cultural support. Select date ranges using predefined options or the calendar interface. \r\n\r\n\r\n\r\n\r\n";
            // 
            // dropDownPanel
            // 
            dropDownPanel.BackColor = Color.FromArgb(216, 232, 237);
            dropDownPanel.Controls.Add(c1DateRangeEdit1);
            dropDownPanel.Location = new Point(1, 1);
            dropDownPanel.Name = "dropDownPanel";
            dropDownPanel.Padding = new Padding(1);
            dropDownPanel.Size = new Size(838, 154);
            dropDownPanel.TabIndex = 5;
            dropDownPanel.Paint += Panel1_Paint;
            // 
            // c1DateRangeEdit1
            // 
            c1DateRangeEdit1.AutoOpen = true;
            c1DateRangeEdit1.BorderStyle = BorderStyle.None;
            c1DateRangeEdit1.ButtonsSettings.DropDownButton.Icon = new C1.Framework.C1BitmapIcon(null, new Size(17, 18), Color.Transparent, Properties.Resources.calendar);
            c1DateRangeEdit1.ButtonsSettings.DropDownButton.Width = 24;
            c1DateRangeEdit1.Calendar.CalendarDimensions = 3;
            c1DateRangeEdit1.Calendar.MaxColumns = 3;
            c1DateRangeEdit1.Calendar.ShowPredefinedRanges = true;
            c1DateRangeEdit1.Calendar.ShowToday = false;
            c1DateRangeEdit1.Calendar.SyncValueWithSelection = true;
            c1DateRangeEdit1.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1DateRangeEdit1.GapHeight = 20;
            c1DateRangeEdit1.Location = new Point(254, 64);
            c1DateRangeEdit1.Name = "c1DateRangeEdit1";
            c1DateRangeEdit1.Placeholder = "Start Date     -     End Date";
            c1DateRangeEdit1.Size = new Size(330, 26);
            c1DateRangeEdit1.Styles.Calendar.ClearButton.Default.BackColor = Color.FromArgb(250, 250, 250);
            c1DateRangeEdit1.Styles.Calendar.ClearButton.Default.BorderColor = Color.FromArgb(104, 118, 130);
            c1DateRangeEdit1.Styles.Calendar.ClearButton.Default.ForeColor = Color.FromArgb(104, 118, 130);
            c1DateRangeEdit1.Styles.Calendar.Common.BackColor = Color.FromArgb(250, 251, 251);
            c1DateRangeEdit1.Styles.Calendar.Common.Border = new C1.Framework.Thickness(2, 0, 0, 0);
            c1DateRangeEdit1.Styles.Calendar.Common.BorderColor = Color.FromArgb(229, 229, 229);
            c1DateRangeEdit1.Styles.Calendar.Common.Margins = new C1.Framework.Thickness(3, 3, 3, 3);
            c1DateRangeEdit1.Styles.Calendar.Day.Selected.BackColor = Color.FromArgb(61, 142, 165);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Default.BackColor = Color.FromArgb(250, 251, 251);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Default.BorderColor = Color.Black;
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Default.ForeColor = Color.Black;
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Hot.BackColor = Color.FromArgb(237, 244, 247);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Hot.ForeColor = Color.Black;
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.HotPressed.BackColor = Color.FromArgb(237, 244, 247);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.HotPressed.ForeColor = Color.Black;
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Margins = new C1.Framework.Thickness(2, 2, 2, 2);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Pressed.BackColor = Color.FromArgb(237, 244, 247);
            c1DateRangeEdit1.Styles.Calendar.PredefinedRange.Pressed.ForeColor = Color.Black;
            c1DateRangeEdit1.Styles.Calendar.Titles.Day.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            c1DateRangeEdit1.Styles.Calendar.Titles.Day.ForeColor = SystemColors.GrayText;
            c1DateRangeEdit1.Styles.Calendar.Titles.Day.Margins = new C1.Framework.Thickness(0, 0, 0, 10);
            c1DateRangeEdit1.Styles.Calendar.Titles.Day.Padding = new C1.Framework.Thickness(10, 15, 10, 15);
            c1DateRangeEdit1.Styles.Calendar.Titles.Month.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            c1DateRangeEdit1.Styles.Calendar.Titles.Month.Margins = new C1.Framework.Thickness(0, 0, 0, 20);
            c1DateRangeEdit1.Styles.Calendar.Titles.Month.Padding = new C1.Framework.Thickness(0, 30, 0, 0);
            c1DateRangeEdit1.Styles.Calendar.Titles.Week.Padding = new C1.Framework.Thickness(0, 0, 0, 10);
            c1DateRangeEdit1.Styles.Editor.Corners = new C1.Framework.Corners(2, 2, 2, 2);
            c1DateRangeEdit1.Styles.Editor.Default.BorderColor = Color.Red;
            c1DateRangeEdit1.TabIndex = 9;
            c1DateRangeEdit1.DayFormatting += c1DateRangeEdit1_DayFormatting;
            // 
            // featurePanel
            // 
            featurePanel.BackColor = Color.FromArgb(99, 112, 125);
            featurePanel.Controls.Add(splitContainer2);
            featurePanel.Location = new Point(323, 389);
            featurePanel.Name = "featurePanel";
            featurePanel.Padding = new Padding(1);
            featurePanel.Size = new Size(840, 348);
            featurePanel.TabIndex = 6;
            featurePanel.Paint += Panel1_Paint;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(99, 112, 125);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(1, 1);
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
            splitContainer2.Panel2.Controls.Add(c1PictureBox4);
            splitContainer2.Panel2.Controls.Add(calendarDimensionNumericEditEx);
            splitContainer2.Panel2.Controls.Add(calendarDimensionLabel);
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
            splitContainer2.Size = new Size(838, 346);
            splitContainer2.SplitterDistance = 495;
            splitContainer2.SplitterWidth = 1;
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
            panel3.Location = new Point(33, 145);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 121);
            panel3.TabIndex = 1;
            panel3.Paint += Panel1_Paint;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            startDateLabel.Location = new Point(142, 19);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(219, 34);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "No selected start date";
            // 
            // endDateTextLabel
            // 
            endDateTextLabel.AutoSize = true;
            endDateTextLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            endDateTextLabel.Location = new Point(19, 70);
            endDateTextLabel.Name = "endDateTextLabel";
            endDateTextLabel.Size = new Size(105, 34);
            endDateTextLabel.TabIndex = 2;
            endDateTextLabel.Text = "End Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            endDateLabel.Location = new Point(142, 70);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(213, 34);
            endDateLabel.TabIndex = 1;
            endDateLabel.Text = "No selected end date";
            // 
            // startDateTextLabel
            // 
            startDateTextLabel.AutoSize = true;
            startDateTextLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDateTextLabel.Location = new Point(19, 19);
            startDateTextLabel.Name = "startDateTextLabel";
            startDateTextLabel.Size = new Size(113, 34);
            startDateTextLabel.TabIndex = 0;
            startDateTextLabel.Text = "Start Date:";
            // 
            // yourDateSelectionLabel
            // 
            yourDateSelectionLabel.AutoSize = true;
            yourDateSelectionLabel.Location = new Point(111, 57);
            yourDateSelectionLabel.Name = "yourDateSelectionLabel";
            yourDateSelectionLabel.Size = new Size(291, 47);
            yourDateSelectionLabel.Styles.Default.ForeColor = Color.FromArgb(61, 142, 165);
            yourDateSelectionLabel.Styles.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yourDateSelectionLabel.TabIndex = 0;
            yourDateSelectionLabel.Text = "Your Date Selection";
            // 
            // c1PictureBox4
            // 
            c1PictureBox4.Image = Properties.Resources.c1PictureBox3_Image;
            c1PictureBox4.Location = new Point(175, 281);
            c1PictureBox4.Margin = new Padding(2);
            c1PictureBox4.Name = "c1PictureBox4";
            c1PictureBox4.Size = new Size(20, 20);
            c1PictureBox4.TabIndex = 39;
            c1PictureBox4.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox4, "Controls the maximum number of days that can be selected at once.\r\nPrevents selecting more dates than the specified");
            // 
            // calendarDimensionNumericEditEx
            // 
            calendarDimensionNumericEditEx.Location = new Point(35, 308);
            calendarDimensionNumericEditEx.Maximum = 99999;
            calendarDimensionNumericEditEx.Name = "calendarDimensionNumericEditEx";
            calendarDimensionNumericEditEx.Size = new Size(120, 28);
            calendarDimensionNumericEditEx.TabIndex = 38;
            calendarDimensionNumericEditEx.Value = new decimal(new int[] { 2, 0, 0, 0 });
            calendarDimensionNumericEditEx.TextChanged += calendarDimensionNumericEditEx_TextChanged;
            // 
            // calendarDimensionLabel
            // 
            calendarDimensionLabel.AutoSize = true;
            calendarDimensionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            calendarDimensionLabel.Location = new Point(24, 277);
            calendarDimensionLabel.Name = "calendarDimensionLabel";
            calendarDimensionLabel.Size = new Size(153, 26);
            calendarDimensionLabel.TabIndex = 37;
            calendarDimensionLabel.Text = "Calendar Dimension";
            // 
            // c1PictureBox3
            // 
            c1PictureBox3.Image = Properties.Resources.c1PictureBox3_Image;
            c1PictureBox3.Location = new Point(120, 215);
            c1PictureBox3.Margin = new Padding(2);
            c1PictureBox3.Name = "c1PictureBox3";
            c1PictureBox3.Size = new Size(20, 20);
            c1PictureBox3.TabIndex = 36;
            c1PictureBox3.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox3, "Controls the maximum number of days that can be selected at once.\r\nPrevents selecting more dates than the specified");
            // 
            // c1PictureBox2
            // 
            c1PictureBox2.Image = Properties.Resources.c1PictureBox2_Image;
            c1PictureBox2.Location = new Point(109, 120);
            c1PictureBox2.Name = "c1PictureBox2";
            c1PictureBox2.Size = new Size(20, 20);
            c1PictureBox2.TabIndex = 35;
            c1PictureBox2.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox2, "Sets the minimum and maximum selectable dates in the calendar. \r\nDates outside this range will be disabled");
            // 
            // c1PictureBox1
            // 
            c1PictureBox1.Image = Properties.Resources.c1PictureBox1_Image;
            c1PictureBox1.Location = new Point(152, 52);
            c1PictureBox1.Name = "c1PictureBox1";
            c1PictureBox1.Size = new Size(20, 20);
            c1PictureBox1.TabIndex = 27;
            c1PictureBox1.TabStop = false;
            toolTip1.SetToolTip(c1PictureBox1, "Changes the display language and date format. \r\nSwitch between English, Korean, and Japanese");
            // 
            // jpRadioButton
            // 
            jpRadioButton.AutoSize = true;
            jpRadioButton.Location = new Point(108, 82);
            jpRadioButton.Name = "jpRadioButton";
            jpRadioButton.Size = new Size(64, 22);
            jpRadioButton.TabIndex = 34;
            jpRadioButton.TabStop = true;
            jpRadioButton.Text = "ja-JP";
            jpRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // krRadioButton
            // 
            krRadioButton.AutoSize = true;
            krRadioButton.Location = new Point(178, 82);
            krRadioButton.Name = "krRadioButton";
            krRadioButton.Size = new Size(73, 22);
            krRadioButton.TabIndex = 33;
            krRadioButton.TabStop = true;
            krRadioButton.Text = "ko-KR";
            krRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // usRadioButton
            // 
            usRadioButton.AutoSize = true;
            usRadioButton.Location = new Point(31, 82);
            usRadioButton.Name = "usRadioButton";
            usRadioButton.Size = new Size(73, 22);
            usRadioButton.TabIndex = 32;
            usRadioButton.TabStop = true;
            usRadioButton.Text = "en-US";
            usRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rangeLimitNumericEditEx
            // 
            rangeLimitNumericEditEx.Location = new Point(35, 242);
            rangeLimitNumericEditEx.Maximum = 99999;
            rangeLimitNumericEditEx.Name = "rangeLimitNumericEditEx";
            rangeLimitNumericEditEx.Size = new Size(120, 28);
            rangeLimitNumericEditEx.TabIndex = 31;
            rangeLimitNumericEditEx.Value = new decimal(new int[] { 366, 0, 0, 0 });
            rangeLimitNumericEditEx.ValueChanged += RangeLimit_ValueChanged;
            // 
            // rangeLimitLabel
            // 
            rangeLimitLabel.AutoSize = true;
            rangeLimitLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            rangeLimitLabel.Location = new Point(24, 211);
            rangeLimitLabel.Name = "rangeLimitLabel";
            rangeLimitLabel.Size = new Size(95, 26);
            rangeLimitLabel.TabIndex = 30;
            rangeLimitLabel.Text = "Range Limit";
            // 
            // maxDateLabel
            // 
            maxDateLabel.AutoSize = true;
            maxDateLabel.Font = new Font("Segoe UI", 7F);
            maxDateLabel.Location = new Point(196, 144);
            maxDateLabel.Name = "maxDateLabel";
            maxDateLabel.Size = new Size(62, 21);
            maxDateLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            maxDateLabel.TabIndex = 29;
            maxDateLabel.Text = "Max Date";
            // 
            // minDateLabel
            // 
            minDateLabel.AutoSize = true;
            minDateLabel.Font = new Font("Segoe UI", 7F);
            minDateLabel.Location = new Point(26, 144);
            minDateLabel.Name = "minDateLabel";
            minDateLabel.Size = new Size(61, 21);
            minDateLabel.Styles.Default.ForeColor = Color.FromArgb(157, 157, 157);
            minDateLabel.TabIndex = 28;
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
            maxDateDateEdit.Location = new Point(199, 167);
            maxDateDateEdit.Name = "maxDateDateEdit";
            maxDateDateEdit.Size = new Size(119, 28);
            maxDateDateEdit.TabIndex = 26;
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
            minDateDateEdit.Location = new Point(31, 170);
            minDateDateEdit.Name = "minDateDateEdit";
            minDateDateEdit.Size = new Size(119, 28);
            minDateDateEdit.TabIndex = 25;
            minDateDateEdit.ValueChanged += DateLimit_ValueChanged;
            // 
            // DateLimitLabel
            // 
            DateLimitLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            DateLimitLabel.Location = new Point(24, 117);
            DateLimitLabel.Name = "DateLimitLabel";
            DateLimitLabel.Size = new Size(94, 26);
            DateLimitLabel.TabIndex = 24;
            DateLimitLabel.Text = "Date Limit";
            // 
            // cultureSelectionLabel
            // 
            cultureSelectionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cultureSelectionLabel.Location = new Point(24, 50);
            cultureSelectionLabel.Name = "cultureSelectionLabel";
            cultureSelectionLabel.Size = new Size(135, 26);
            cultureSelectionLabel.TabIndex = 23;
            cultureSelectionLabel.Text = "Culture Selection";
            // 
            // featureLabel
            // 
            featureLabel.AutoSize = true;
            featureLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featureLabel.Location = new Point(24, 11);
            featureLabel.Name = "featureLabel";
            featureLabel.Size = new Size(80, 28);
            featureLabel.TabIndex = 22;
            featureLabel.Text = "Feature";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = Color.FromArgb(99, 112, 125);
            borderPanel.Controls.Add(dropDownPanel);
            borderPanel.Location = new Point(328, 216);
            borderPanel.Name = "borderPanel";
            borderPanel.Padding = new Padding(1);
            borderPanel.Size = new Size(840, 156);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1425, 915);
            Controls.Add(samplesTitle);
            Controls.Add(sampleDescriptionLabel);
            Controls.Add(borderPanel);
            Controls.Add(featurePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Date Range";
            ((System.ComponentModel.ISupportInitialize)samplesTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)sampleDescriptionLabel).EndInit();
            dropDownPanel.ResumeLayout(false);
            dropDownPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1DateRangeEdit1).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)c1PictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarDimensionNumericEditEx).EndInit();
            ((System.ComponentModel.ISupportInitialize)calendarDimensionLabel).EndInit();
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
        private C1.Win.Input.C1Label samplesTitle;
        private C1.Win.Input.C1Label sampleDescriptionLabel;
        private Panel dropDownPanel;
        private Panel featurePanel;
        private SplitContainer splitContainer2;
        private C1.Win.Input.C1Label yourDateSelectionLabel;
        private Panel panel3;
        private C1.Win.Input.C1Label startDateLabel;
        private C1.Win.Input.C1Label endDateLabel;
        private Panel borderPanel;
        private C1.Win.Input.C1Label endDateTextLabel;
        private C1.Win.Input.C1Label startDateTextLabel;
        private ToolTip toolTip1;
        private C1.Win.Calendar.C1DateRangeEdit c1DateRangeEdit1;
        private C1.Win.Input.C1PictureBox c1PictureBox4;
        private CustomControl.C1NumericEditEx calendarDimensionNumericEditEx;
        private C1.Win.Input.C1Label calendarDimensionLabel;
        private C1.Win.Input.C1PictureBox c1PictureBox3;
        private C1.Win.Input.C1PictureBox c1PictureBox2;
        private C1.Win.Input.C1PictureBox c1PictureBox1;
        private C1.Win.Input.C1RadioButton jpRadioButton;
        private C1.Win.Input.C1RadioButton krRadioButton;
        private C1.Win.Input.C1RadioButton usRadioButton;
        private CustomControl.C1NumericEditEx rangeLimitNumericEditEx;
        private C1.Win.Input.C1Label rangeLimitLabel;
        private C1.Win.Input.C1Label maxDateLabel;
        private C1.Win.Input.C1Label minDateLabel;
        private C1.Win.Calendar.C1DateEdit maxDateDateEdit;
        private C1.Win.Calendar.C1DateEdit minDateDateEdit;
        private C1.Win.Input.C1Label DateLimitLabel;
        private C1.Win.Input.C1Label cultureSelectionLabel;
        private Label featureLabel;
    }
}
