using C1.Win.Calendar;
using C1.Win.Input;
using InputDateRange.Helpers;
using InputDateRange.Properties;
using InputDateRange.Services;
using System.Globalization;

namespace InputDateRange
{
    public partial class Form1 : Form
    {
        private readonly LocalizationService _localizationService;
        private readonly CalendarViewHighlighter _calendarViewHighlighter;
        private readonly CustomDrawingHelper _customDrawingHelper;
        private readonly DateFormatterFactory _dateFormatterFactory;

        public Form1()
        {
            InitializeComponent();

            _localizationService = new LocalizationService();
            _calendarViewHighlighter = new CalendarViewHighlighter();
            _customDrawingHelper = new CustomDrawingHelper();
            _dateFormatterFactory = new DateFormatterFactory();

            InitializeCalendarDropdown();
        }

        #region Initialization

        private void InitializeCalendarDropdown()
        {
            //set this value to allow selecting multiple ranges of date in c1DateRangeEdit
            c1DateRangeEdit1.Calendar.MaxSelectionCount = 366;

            InitializePredefinedRanges();
            //set this value to show predefined ranges in the dropdown of c1DateRangeEdit
            //Note that if you have a custom predefinedRanges, the default predefinedRanges will not be shown
            c1DateRangeEdit1.Calendar.ShowPredefinedRanges = true;
            usRadioButton.Checked = true; 

            c1DateRangeEdit1.ValueChanged += (s, e) => UpdateLabels();
            SetDefaultDateLimits();
        }

        private void SetDefaultDateLimits()
        {
            var today = DateTime.Today;
            minDateDateEdit.Value = today.AddYears(-10);
            maxDateDateEdit.Value = today.AddYears(10);
            DateLimit_ValueChanged(null, EventArgs.Empty);
        }

        private void InitializePredefinedRanges()
        {
            var today = DateTime.Today;
            int diff = (7 + (int)(today.DayOfWeek - DayOfWeek.Sunday)) % 7;
            var startOfWeek = today.AddDays(-diff).Date;
            var startOfMonth = new DateTime(today.Year, today.Month, 1);

            c1DateRangeEdit1.Calendar.PredefinedRanges.AddRange(new[]
            {
                new PredefinedRange(startOfWeek,                 startOfWeek.AddDays(6),                 Resources.ListBoxItem_ThisWeek),
                new PredefinedRange(startOfWeek.AddDays(-7),     startOfWeek.AddDays(-1),                Resources.ListBoxItem_LastWeek),
                new PredefinedRange(startOfWeek.AddDays(7),      startOfWeek.AddDays(13),                Resources.ListBoxItem_NextWeek),
                new PredefinedRange(startOfMonth,                startOfMonth.AddMonths(1).AddDays(-1),  Resources.ListBoxItem_ThisMonth),
                new PredefinedRange(startOfMonth.AddMonths(-1),  startOfMonth.AddDays(-1),               Resources.ListBoxItem_LastMonth),
                new PredefinedRange(startOfMonth.AddMonths(1),   startOfMonth.AddMonths(2).AddDays(-1),  Resources.ListBoxItem_NextMonth),
            });
        }

        #endregion

        #region Calendar Configuration

        private void calendarDimensionNumericEditEx_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(calendarDimensionNumericEditEx.Text, out int value) &&
                value >= calendarDimensionNumericEditEx.Minimum &&
                value <= calendarDimensionNumericEditEx.Maximum)
            {
                c1DateRangeEdit1.Calendar.CalendarDimensions = value;
            }
        }

        private void DateLimit_ValueChanged(object? sender, EventArgs e)
        {
            try
            {
                if (minDateDateEdit.Value != null && maxDateDateEdit.Value != null &&
                    minDateDateEdit.Value != DBNull.Value && maxDateDateEdit.Value != DBNull.Value &&
                    minDateDateEdit.Value is DateTime minDate && maxDateDateEdit.Value is DateTime maxDate)
                {
                    if (minDate <= maxDate)
                    {
                        c1DateRangeEdit1.Calendar.MinDate = minDate;
                        c1DateRangeEdit1.Calendar.MaxDate = maxDate;
                    }
                }
            }
            catch (InvalidCastException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Invalid date format: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Date outside valid range: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Invalid date configuration: {ex.Message}");
            }
        }

        private void RangeLimit_ValueChanged(object? sender, EventArgs e)
        {
            try
            {
                if (rangeLimitNumericEditEx.Value != null)
                {
                    int maxSelectionCount = Convert.ToInt32(rangeLimitNumericEditEx.Value);
                    if (maxSelectionCount > 0)
                    {
                        c1DateRangeEdit1.Calendar.MaxSelectionCount = maxSelectionCount;
                    }
                }
            }
            catch (InvalidCastException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Cannot convert value to integer: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Number too large for integer: {ex.Message}");
            }
            catch (FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Invalid number format: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Selection count outside valid range: {ex.Message}");
            }
        }

        #endregion

        #region Culture & Localization

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is C1RadioButton radioButton && radioButton.Checked)
            {
                var newCulture = radioButton.Name switch
                {
                    "usRadioButton" => new CultureInfo("en-US"),
                    "krRadioButton" => new CultureInfo("ko-KR"),
                    "jpRadioButton" => new CultureInfo("ja-JP"),
                    _ => new CultureInfo("en-US")
                };

                _localizationService.SetCulture(newCulture);

                ApplyCultureToControls();
                ApplyLocalizedText();
                UpdatePredefinedRanges();
                UpdateLabels();
            }
        }

        private void ApplyCultureToControls()
        {
            var culture = _localizationService.CurrentCulture;

            // Set the CurrentCulture for the calendar
            c1DateRangeEdit1.CultureInfo = culture;
            maxDateDateEdit.CultureInfo = culture;
            minDateDateEdit.CultureInfo = culture;

            var formatPattern = _dateFormatterFactory.CreateDateFormat(culture).ShortDatePattern;
            
            c1DateRangeEdit1.CustomFormat = formatPattern;
            c1DateRangeEdit1.DisplayFormat.CustomFormat = formatPattern;
            c1DateRangeEdit1.SetFormat(formatPattern);

            minDateDateEdit.CustomFormat = formatPattern;
            minDateDateEdit.DisplayFormat.CustomFormat = formatPattern;

            maxDateDateEdit.CustomFormat = formatPattern;
            maxDateDateEdit.DisplayFormat.CustomFormat = formatPattern;
        }

        private void ApplyLocalizedText()
        {
            samplesTitle.Text = Resources.Label_SamplesTitle;
            sampleDescriptionLabel.Text = Resources.Label_SampleDescription;
            yourDateSelectionLabel.Text = Resources.Label_YourDateSelection;
            featureLabel.Text = Resources.Label_Feature;
            cultureSelectionLabel.Text = Resources.Label_CultureSelection;
            DateLimitLabel.Text = Resources.Label_DateLimit;
            startDateTextLabel.Text = Resources.Label_StartDate;
            endDateTextLabel.Text = Resources.Label_EndDate;
            minDateLabel.Text = Resources.Label_MinDate;
            maxDateLabel.Text = Resources.Label_MaxDate;
            rangeLimitLabel.Text = Resources.Label_RangeLimit;
            startDateLabel.Text = Resources.Label_NoStartDate;
            endDateLabel.Text = Resources.Label_NoEndDate;
            calendarDimensionLabel.Text = Resources.Label_CalendarDimension;

            UpdateTooltips();
        }

        private void UpdateTooltips()
        {
            toolTip1.SetToolTip(c1PictureBox1, Resources.ToolTip_CultureSelection);
            toolTip1.SetToolTip(c1PictureBox2, Resources.ToolTip_DateLimit);
            toolTip1.SetToolTip(c1PictureBox3, Resources.ToolTip_RangeLimit);
            toolTip1.SetToolTip(c1PictureBox4, Resources.ToolTip_CalendarDimension);
        }

        private void UpdatePredefinedRanges()
        {
            var ranges = c1DateRangeEdit1.Calendar.PredefinedRanges;
            if (ranges.Count < 6) return;

            ranges[0].Name = Resources.ListBoxItem_ThisWeek;
            ranges[1].Name = Resources.ListBoxItem_LastWeek;
            ranges[2].Name = Resources.ListBoxItem_NextWeek;
            ranges[3].Name = Resources.ListBoxItem_ThisMonth;
            ranges[4].Name = Resources.ListBoxItem_LastMonth;
            ranges[5].Name = Resources.ListBoxItem_NextMonth;

            if (c1DateRangeEdit1.Calendar.ShowPredefinedRanges)
            {
                c1DateRangeEdit1.Calendar.ShowPredefinedRanges = false;
                c1DateRangeEdit1.Calendar.ShowPredefinedRanges = true;
            }
        }

        #endregion

        #region Date Selection Display

        private void c1DateRangeEdit1_DayFormatting(object sender, DayFormattingEventArgs e)
        {
            if (c1DateRangeEdit1.MinValue.HasValue && c1DateRangeEdit1.MaxValue.HasValue)
            {
                _calendarViewHighlighter.HighlightSelectedRange(e, c1DateRangeEdit1.MinValue.Value, c1DateRangeEdit1.MaxValue.Value);
            }
        }

        private void UpdateLabels()
        {
            var rangeStart = c1DateRangeEdit1.MinValue;
            var rangeEnd = c1DateRangeEdit1.MaxValue;
            if (rangeStart.HasValue && rangeEnd.HasValue)
            {
                startDateLabel.Text = _dateFormatterFactory.CreateDateFormat(_localizationService.CurrentCulture).FormatDateLabel(rangeStart.Value);
                endDateLabel.Text = _dateFormatterFactory.CreateDateFormat(_localizationService.CurrentCulture).FormatDateLabel(rangeEnd.Value);
            }
            else
            {
                c1DateRangeEdit1.Placeholder = Resources.Label_Placeholder_DateSelected;
                c1DateRangeEdit1.Refresh();
                startDateLabel.Text = Resources.Label_NoStartDate;
                endDateLabel.Text = Resources.Label_NoEndDate;
            }
        }

        #endregion

        #region Custom Drawing

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control control)
                _customDrawingHelper.ApplyRoundedCorners(control, e);
        }

        #endregion
    }
}
