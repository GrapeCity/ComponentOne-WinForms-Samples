using C1.Win.Calendar;
using C1.Win.Input;
using InputDateRange.Constants;
using InputDateRange.Helpers;
using InputDateRange.Services;
using System.Globalization;

namespace InputDateRange
{
    public partial class Form1 : Form
    {
        private List<DateTime> lastConfirmedDates = new();
        private DateTime? startDate;
        private DateTime? endDate;

        private readonly ILocalizationService _localizationService;
        private readonly IDateFormattingService _dateFormattingService;
        private readonly IDateRangeService _dateRangeService;

        public Form1()
        {
            InitializeComponent();

            // Initialize services
            _localizationService = new LocalizationService();
            _dateFormattingService = new DateFormattingService();
            _dateRangeService = new DateRangeService();


            InitializeCalendarDropdown();
        }

        private void InitializeCalendarDropdown()
        {
            //set this value to allow selecting multiple ranges of date in c1CalendarView
            c1CalendarView1.MaxSelectionCount = 366;
            panelCalendar.Visible = true;
            usRadioButton.Checked = true;

            SetDefaultDateLimits();
        }

        private void listBoxRanges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRanges.SelectedItem is not string option) return;

            // Map the localized display text back to the English key
            string rangeKey = _localizationService.GetRangeKeyFromDisplayText(option);
            var dateRange = _dateRangeService.GetPredefinedRange(rangeKey);
            if (dateRange == null) return;

            startDate = dateRange.Value.StartDate;
            endDate = dateRange.Value.EndDate;

            c1CalendarView1.SelectedDates = dateRange.Value.GetDatesInRange().ToArray();
            UpdateLabels();
        }

        private void c1CalendarView1_SelectionChanged(object sender, EventArgs e) => UpdateLabels();

        private void C1CalendarView1_DayFormatting(object sender, DayFormattingEventArgs e)
        {
            var selectedDates = c1CalendarView1.SelectedDates.Cast<DateTime>();
            CalendarViewHighlighter.HighlightSelectedRange(e, selectedDates);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            lastConfirmedDates = c1CalendarView1.SelectedDates.ToList();
            UpdateLabels();
            panelCalendar.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            c1CalendarView1.SelectedDates = lastConfirmedDates.ToArray();
            UpdateLabels();
            panelCalendar.Visible = false;
        }

        private void UpdateLabels()
        {
            var selectedDates = c1CalendarView1.SelectedDates.Cast<DateTime>().OrderBy(d => d).ToList();
            if (selectedDates.Any())
            {
                startDate = selectedDates.First();
                endDate = selectedDates.Last();
                labelTotalDays.Text = $"{selectedDates.Count} Days";

                dateSelectedLabel.Text = _dateFormattingService.FormatDateRangeForLabel(startDate.Value, endDate.Value, _localizationService.CurrentCulture);
                dateSelectedLabel.Styles.Default.ForeColor = SystemColors.ControlText;
                startDateLabel.Text = _dateFormattingService.FormatDateWithOrdinal(startDate.Value, _localizationService.CurrentCulture);
                endDateLabel.Text = _dateFormattingService.FormatDateWithOrdinal(endDate.Value, _localizationService.CurrentCulture);

                string? matchedRange = _dateRangeService.MatchPredefinedRange(startDate.Value, endDate.Value, selectedDates.Count);
                string displayText = _localizationService.GetDisplayTextFromRangeKey(matchedRange ?? DateRangeConstants.CustomRange);
                listBoxRanges.SelectedItem = displayText;
            }
            else
            {
                startDate = null;
                endDate = null;
                labelTotalDays.Text = "0 Days";
                dateSelectedLabel.Text = _localizationService.GetString("dateSelectedPlaceholder", DateRangeConstants.StartEndDatePlaceholder);
                dateSelectedLabel.Styles.Default.ForeColor = SystemColors.GrayText;
                startDateLabel.Text = DateRangeConstants.NoStartDateText;
                endDateLabel.Text = DateRangeConstants.NoEndDateText;
            }
        }


        #region Reset and Hover UI
        private void resetLabel_MouseHover(object sender, EventArgs e)
        {
            resetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
        }

        private void resetLabel_MouseLeave(object sender, EventArgs e)
        {
            resetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void resetLabel_Click(object sender, EventArgs e)
        {
            panelCalendar.Visible = false;
            c1CalendarView1.SelectedDates = Array.Empty<DateTime>();
            dateSelectedLabel.Text = _localizationService.GetString("dateSelectedPlaceholder", DateRangeConstants.StartEndDatePlaceholder);
            dateSelectedLabel.Styles.Default.ForeColor = SystemColors.GrayText;
            startDate = null;
            endDate = null;
            lastConfirmedDates.Clear();
            labelTotalDays.Text = "0 Days";
            startDateLabel.Text = DateRangeConstants.NoStartDateText;
            endDateLabel.Text = DateRangeConstants.NoEndDateText;
        }
        #endregion

        #region ListBox Custom Drawing
        private void listBoxRanges_DrawItem(object sender, DrawItemEventArgs e)
        {
            CustomDrawingHelper.DrawListBoxItem(e, listBoxRanges);
        }

        #endregion

        #region Rounded Corner
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control control)
            {
                CustomDrawingHelper.ApplyRoundedCorners(control, e, DateRangeConstants.DefaultCornerRadius);
            }
        }
        #endregion

        #region Event Handlers and Methods

        private void DateSelectedLabel_Click(object? sender, EventArgs e)
        {
            panelCalendar.Visible = !panelCalendar.Visible;
        }

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
                UpdateLabels();
            }
        }

        private void ApplyCultureToControls()
        {
            var culture = _localizationService.CurrentCulture;

            // Set the CurrentCulture for the calendar
            c1CalendarView1.CurrentCulture = culture;
            maxDateDateEdit.CultureInfo = culture;
            minDateDateEdit.CultureInfo = culture;

            var formatPattern = culture.Name switch
            {
                "en-US" => "MM/dd/yyyy",
                "ko-KR" => "yyyy-MM-dd",
                "ja-JP" => "yyyy/MM/dd",
                _ => "MM/dd/yyyy"
            };

            minDateDateEdit.CustomFormat = formatPattern;
            maxDateDateEdit.CustomFormat = formatPattern;
            minDateDateEdit.DisplayFormat.CustomFormat = formatPattern;
            maxDateDateEdit.DisplayFormat.CustomFormat = formatPattern;
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
                        c1CalendarView1.MinDate = minDate;
                        c1CalendarView1.MaxDate = maxDate;
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
                    if (maxSelectionCount > 0 && maxSelectionCount <= 366)
                    {
                        c1CalendarView1.MaxSelectionCount = maxSelectionCount;
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

        private void SetDefaultDateLimits()
        {
            var today = DateTime.Today;
            minDateDateEdit.Value = today.AddYears(-10);
            maxDateDateEdit.Value = today.AddYears(10);
            DateLimit_ValueChanged(null, EventArgs.Empty);
        }

        private void ApplyLocalizedText()
        {
            samplesTitle.Text = _localizationService.GetString("samplesTitle.Text", "Input Date Range");
            sampleDescriptionLabel.Text = _localizationService.GetString("sampleDescriptionLabel.Text", "This sample demonstrates an interactive date range picker using C1CalendarView \r\nwith multi-cultural support. Select date ranges using predefined options or the calendar interface. \r\n\r\n\r\n\r\n");
            yourDateSelectionLabel.Text = _localizationService.GetString("yourDateSelectionLabel.Text", "Your Date Selection");
            featureLabel.Text = _localizationService.GetString("featureLabel.Text", "Feature");
            cultureSelectionLabel.Text = _localizationService.GetString("cultureSelectionLabel.Text", "Culture Selection");
            DateLimitLabel.Text = _localizationService.GetString("dateLimitLabel.Text", "Date Limit");
            startDateTextLabel.Text = _localizationService.GetString("startDateTextLabel.Text", "Start Date:");
            endDateTextLabel.Text = _localizationService.GetString("endDateTextLabel.Text", "End Date:");
            minDateLabel.Text = _localizationService.GetString("minDateLabel.Text", "Min Date");
            maxDateLabel.Text = _localizationService.GetString("maxDateLabel.Text", "Max Date");
            rangeLimitLabel.Text = _localizationService.GetString("rangeLimitLabel.Text", "Range Limit");
            resetLabel.Text = _localizationService.GetString("resetLabel.Text", "Reset");
            btnApply.Text = _localizationService.GetString("btnApply.Text", "Apply");
            btnCancel.Text = _localizationService.GetString("btnCancel.Text", "Cancel");
            // Update listBoxRanges items
            UpdateListBoxRangesItems();
        }

        private void UpdateListBoxRangesItems()
        {
            var selectedIndex = listBoxRanges.SelectedIndex;
            listBoxRanges.Items.Clear();

            var rangeKeys = _dateRangeService.GetAllRangeKeys();
            foreach (var rangeKey in rangeKeys)
            {
                var displayText = _localizationService.GetDisplayTextFromRangeKey(rangeKey);
                listBoxRanges.Items.Add(displayText);
            }

            if (selectedIndex >= 0 && selectedIndex < listBoxRanges.Items.Count)
            {
                listBoxRanges.SelectedIndex = selectedIndex;
            }
        }
        #endregion
    }
}