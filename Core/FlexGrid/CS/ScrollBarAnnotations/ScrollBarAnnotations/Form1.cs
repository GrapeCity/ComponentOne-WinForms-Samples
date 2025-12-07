// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.FlexGrid;
using C1.Win.Input;
using C1.Win.Themes.Shared;
using ScrollBarAnnotations.CustomAnnotations;
using ScrollBarAnnotations.Enums;
using ScrollBarAnnotations.Manager;
using System.Data;

namespace ScrollBarAnnotations
{
    /// <summary>
    /// Demonstrates using C1FlexGrid with scrollbar annotations, themes, and tooltips.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Fields

        /// <summary>
        /// Stores product data loaded from the Access database.
        /// </summary>
        DataTable _productData = new DataTable();
        bool _annotationsEnabled = false;
        double _currentPosition = 0;
        int _scrollBarAnnotationsUpdateCount = 0;

        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            ThemeManager.InitializeTheme(themeComboBox);
        }
        #endregion

        #region Form Events
        /// <summary>
        /// Handles the form load event. Loads data into the FlexGrid and sets up default behaviors.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load product data from Access database into DataTable
            DatabaseManager.LoadProductData(_productData);

            // Attach error info event
            _flexGrid.GetRowErrorInfo += GetErrorInfo;
            _flexGrid.ShowErrors = true;

            _flexGrid.ScrollBarAnnotationsInfo.Enabled = true;

            _flexGrid.DataSource = _productData;

            foreach (Control ctrl in rightPanel.Controls)
            {
                ctrl.Margin = new Padding(10);
                if (ctrl is C1CheckBox checkbox)
                {
                    TooltipManager.MessageShownInToolTip(checkbox, toolTip);
                }
            }
        }

        /// <summary>
        /// Handles theme selection changes and applies the chosen theme to the grid.
        /// </summary>
        private void CmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (themeComboBox.SelectedIndex == -1)
                return;

            themeComboBox.Text = themeComboBox.SelectedItem.DisplayText;
            ThemeManager.ApplyTheme(_flexGrid, themeComboBox);
        }

        #endregion

        #region Checkbox Changed Events

        /// <summary>
        /// Enables or disables scrollbar annotations based on user selection.
        /// </summary>
        private void ShowAnnotaions_CheckedChanged(object sender, EventArgs e)
        {
            bool shouldAttachEvent = showAnnotationsCheckbox.Checked && customAnnotation1Checkbox.Checked;
            ToggleScrollBarAnnotationsEvent(shouldAttachEvent);
            _flexGrid.ScrollBarAnnotationsInfo.Enabled = showAnnotationsCheckbox.Checked;
        }

        /// <summary>
        /// Enables or disables display of row errors based on user selection.
        /// </summary>
        private void ShowErrors_CheckedChanged(object sender, EventArgs e)
        {
            // Detach first to avoid attaching the same event handler multiple times.
            _flexGrid.GetRowErrorInfo -= GetErrorInfo;

            _flexGrid.GetRowErrorInfo += GetErrorInfo;
            _flexGrid.ShowErrors = showErrorsCheckbox.Checked;
        }

        /// <summary>
        /// Handles enabling or disabling custom annotations and forces a layout refresh.
        /// </summary>
        private void CustomAnnotation1_CheckedChanged(object sender, EventArgs e)
        {
            //Step 1: Register the event
            bool shouldAttachEvent = showAnnotationsCheckbox.Checked && customAnnotation1Checkbox.Checked;
            ToggleScrollBarAnnotationsEvent(shouldAttachEvent);


            // TODO: Control Author will be adding a new method `UpdateScrollBarAnnotations`
            // to the grid API which will update the annotations. This code will be replaced 
            // when the package is published.

            //Step 2: Apply new settings for event to take effect
            if (_flexGrid.ScrollBarAnnotationsInfo.Enabled)
            {
                // Suspend layout updates to prevent unnecessary redraws or flickering 
                // while making multiple UI changes. This ensures the grid doesn't 
                _flexGrid.SuspendLayout();

                // Temporarily disable and re-enable the ScrollBarAnnotationsInfo feature 
                // to force the grid to refresh and apply the latest annotation settings.
                // Some UI properties only take effect after being toggled.
                _flexGrid.ScrollBarAnnotationsInfo.Enabled = false;
                _flexGrid.ScrollBarAnnotationsInfo.Enabled = true;

                // Resume layout updates and trigger a redraw with all changes applied.
                _flexGrid.ResumeLayout();
            }
        }

        /// <summary>
        /// Enables or disables scroll tip tooltips when scrolling through the grid.
        /// </summary>
        private void ShowScrollTip_CheckedChanged(object sender, EventArgs e)
        {
            _flexGrid.ScrollOptions = ScrollFlags.ScrollByRowColumn | ScrollFlags.ShowScrollTips;

            if (showScrollTipCheckbox.Checked)
            {
                _flexGrid.ShowScrollTip += Flex_ShowScrollTip;
                _flexGrid.ShowScrollTip -= Flex_RemoveScrollTip;

            }
            else
            {
                _flexGrid.ShowScrollTip += Flex_RemoveScrollTip;
                _flexGrid.ShowScrollTip -= Flex_ShowScrollTip;
            }

        }
        private void HotKeys_CheckedChanged(object sender, EventArgs e)
        {
            _annotationsEnabled = hotKeysCheckbox.Checked;
        }
        private void ShowFocusedRow_CheckedChanged(object sender, EventArgs e)
        {
            _flexGrid.ScrollBarAnnotationsInfo.ShowFocusedRow = showFocusedRowCheckbox.Checked;
        }
        private void ShowSelectedRow_CheckedChanged(object sender, EventArgs e)
        {
            _flexGrid.ScrollBarAnnotationsInfo.ShowSelectedRows = showSelectedRowCheckbox.Checked;
        }

        private void ShowHighlightedRow_CheckedChanged(object sender, EventArgs e)
        {
            _flexGrid.ScrollBarAnnotationsInfo.ShowHighlightedRows = showHighlightedRowCheckbox.Checked;
            var mode = showHighlightedRowCheckbox.Checked ? SearchHighlightMode.All : SearchHighlightMode.None;

            _flexGrid.ApplySearch("s", mode);
        }
        #endregion

        #region FlexGrid ScrollTip Event Handlers
        /// <summary>
        /// Displays a scroll tooltip when the user scrolls the grid.
        /// </summary>
        private void Flex_ShowScrollTip(object sender, ToolTipEventArgs e)
        {
            var productName = _flexGrid[e.Row, "ProductName"]?.ToString();
            //Example of how it is shown - Row 12 - Chai
            e.ToolTipText = $"{Properties.Resource.Row} {e.Row} - {productName}";
        }

        /// <summary>
        /// Removes the scroll tooltip text when the tooltip is hidden.
        /// </summary>
        private void Flex_RemoveScrollTip(object sender, ToolTipEventArgs e)
        {
            e.ToolTipText = "";
        }
        #endregion

        #region Scrollbar Annotations Events Handlers
        /// <summary>
        /// Provides custom error text for certain rows in the grid.
        /// </summary>
        private void GetErrorInfo(object sender, GetErrorInfoEventArgs e)
        {
            // Define the row indices that should display an error
            var rows = new[] { 5, 7, 9, 15, 35, 40, 50 };

            if (rows.Contains(e.Row))
            {
                e.ErrorText = Properties.Resource.ErrorText;
            }
        }

        /// <summary>
        /// Adds or updates a custom annotation in the scrollbar when annotations are refreshed.
        /// </summary>
        private void C1FlexGrid1_ScrollBarAnnotationsUpdated(object sender, ScrollBarAnnotationsUpdatedArgs e)
        {

            // Increment counter each time the event fires
            _scrollBarAnnotationsUpdateCount++;

            // Log the event firing count to the debug output
            System.Diagnostics.Debug.WriteLine($"ScrollBarAnnotationsUpdated event fired {_scrollBarAnnotationsUpdateCount} times.");

            // Remove discontinued annotations first to avoid duplicates
            e.Annotations.RemoveAll(a => a is CustomAnnotation ca && ca.Type == CustomAnnotationType.Custom2);

            // Check for discontinued rows in the bound DataTable
            if (_flexGrid.DataSource is DataTable dt)
            {
                foreach (DataRow row in dt.Rows)
                {
                    bool discontinued = Convert.ToBoolean(row["Discontinued"]);

                    if (discontinued)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        string? productName = row["ProductName"].ToString();

                        string discontinuedText = $"{productId} ({productName}) {Properties.Resource.ProductDiscontinued}";

                        // Add a new annotation at the product's row index
                        e.Annotations.Add(new CustomAnnotation(
                            CustomAnnotationType.Custom2,
                            discontinuedText,
                            productId,
                            Color.Green,
                            width: 90,
                            height: 8
                        ));
                    }
                }
            }
        }

        /// <summary>
        /// Attaches or detaches the ScrollBarAnnotationsUpdated event handler 
        /// depending on whether annotations should be active.
        /// </summary>
        /// <param name="shouldAttach">True to attach the event handler, false to detach it.</param>
        private void ToggleScrollBarAnnotationsEvent(bool shouldAttach)
        {
            _flexGrid.ScrollBarAnnotationsUpdated -= C1FlexGrid1_ScrollBarAnnotationsUpdated;

            if (shouldAttach)
                _flexGrid.ScrollBarAnnotationsUpdated += C1FlexGrid1_ScrollBarAnnotationsUpdated;

        }
        #endregion

        #region Keyboard Shortcuts for Annotations Navigation
        /// <summary>
        /// Handles keyboard shortcuts for navigating between scrollbar annotations.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!_annotationsEnabled)
                return base.ProcessCmdKey(ref msg, keyData);

            // Jump to next annotation (Ctrl + Down)
            if (keyData == (Keys.Control | Keys.Down))
            {
                NavigateToAnnotation(forward: true);
                return true;
            }

            // Jump to previous annotation (Ctrl + Up)
            if (keyData == (Keys.Control | Keys.Up))
            {
                NavigateToAnnotation(forward: false);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Navigates to the next or previous scrollbar annotation.
        /// Integrates with the existing ScrollToScrollBarAnnotation method.
        /// </summary>
        private void NavigateToAnnotation(bool forward)
        {
            ScrollBarAnnotation? targetAnnotation;

            var annotations = _flexGrid.ScrollBarAnnotations.ToList();
            if (annotations == null || annotations.Count == 0)
                return;

            // Filter annotations to include only grid-related ones, excluding those for selected or focused rows
            var validAnnotations = annotations
                                    .OfType<GridScrollBarAnnotation>()
                                    .Where(g => g.ScrollBarAnnotationType != ScrollBarAnnotationType.SelectedRow
                                    && g.ScrollBarAnnotationType != ScrollBarAnnotationType.FocusedRow);

            targetAnnotation = forward
                             ? validAnnotations.Where(g => g.Row > _currentPosition).OrderBy(g => g.Position).FirstOrDefault()
                             : validAnnotations.Where(g => g.Row < _currentPosition).OrderByDescending(g => g.Position).FirstOrDefault();

            if (targetAnnotation != null && targetAnnotation is GridScrollBarAnnotation gridAnnotation)
            {
                _currentPosition = gridAnnotation.Row;
                _flexGrid.ScrollToScrollBarAnnotation(gridAnnotation);

                // Select the row in the grid after scrolling to it
                _flexGrid.Select(new CellRange
                {
                    c1 = 1,
                    c2 = 1,
                    r1 = (int)_currentPosition,
                    r2 = (int)_currentPosition
                });
            }

        }

        #endregion
    }
}
