using C1.Framework;
using C1.Win.FlexGrid;
using FlexGrid_Selection.Data;
using FlexGrid_Selection.Helper_Classes;
using FlexGrid_Selection.Interfaces;
using System.Drawing.Drawing2D;

namespace FlexGrid_Selection
{
    public partial class Form1 : Form
    {
        private readonly IAggregateManager _aggregateManager;
        private readonly ISelectionModeManager _selectionModeManager;
        private readonly IClipboardManager _clipboardManager;

        // Dictionary for selection mode icons.
        private Dictionary<int, Image> _selectionModeIcons;
        private About aboutForm;
        private bool _isUpdatingCheckboxes = false;
        public Form1()
        {
            InitializeComponent();
            InitializeFlexGrid();
            LoadSelectionModeIcons();

            _aggregateManager = new AggregateManager(
                sourceFlexGrid, destinationFlexGrid, c1Ribbon1,
                cbSum, cbCount, cbAverage, cbCountDistinct, cbMax, cbMin, cbSampleVariance,
                cbPopulationStandardDeviation, cbPopulationVariance, cbSampleStandardDeviation
            );

            _selectionModeManager = new SelectionModeManager(sourceFlexGrid, selectAllBtn);

            _selectionModeManager.PopulateSelectionModeCombo(rbSelectionMod);
            rbSelectionMod.SelectedIndex = 0;

            _clipboardManager = new ClipboardManager(
                sourceFlexGrid, destinationFlexGrid, copyModeGallery,
                DataAndAllHeaders, DataOnly, DataAndColumnHeaders, DataAndRowHeaders,
                Disabled, tbSearch
            );

            SubscribeEvents();

            _clipboardManager.UpdateClipboardCopyModeText();
            copyModeGallery.SelectedIndex = 0;
        }

        #region Helper Methods for Icon Update 
        private void LoadSelectionModeIcons()
        {
            _selectionModeIcons = new Dictionary<int, Image>
            {
                [0] = Properties.Resources._default, 
                [1] = Properties.Resources.cell,
                [2] = Properties.Resources.cellRange,
                [3] = Properties.Resources.row,
                [4] = Properties.Resources.rowRange,
                [5] = Properties.Resources.column,
                [6] = Properties.Resources.columnRange,
                [7] = Properties.Resources.listBox,
                [8] = Properties.Resources.multiRange
            };
        }
        private void UpdateSelectionRibbonIcon()
        {
            int selectedIndex = rbSelectionMod.SelectedIndex;
            if (_selectionModeIcons != null && _selectionModeIcons.TryGetValue(selectedIndex, out Image newIcon))
            {
                rbSelectionMod.IconSet.Clear();
                rbSelectionMod.IconSet.Add(new C1BitmapIcon("Icon" + selectedIndex, new Size(16, 16), Color.Transparent, newIcon));
                c1Ribbon1.Refresh();
            }
        }
        #endregion

        #region Event Subscriptions
        private void SubscribeEvents()
        {
            sourceFlexGrid.AfterSelChange += async (s, e) =>
            {
                await _aggregateManager.UpdateStatisticsAsync();
                UpdateSplitContainerState();
            };

            destinationFlexGrid.AfterSelChange += async (s, e) =>
            {
                await _aggregateManager.UpdateStatisticsAsync();
                UpdateSplitContainerState();
            };

            cbCheckAll.CheckedChanged += (s, e) =>
            {
                if (cbCheckAll.Checked)
                {
                    _isUpdatingCheckboxes = true;
                    _aggregateManager.SetAggregateChecks(true);
                    _isUpdatingCheckboxes = false;
                    UpdateSplitContainerState();
                }
            };

            cbUncheckAll.CheckedChanged += (s, e) =>
            {
                if (cbUncheckAll.Checked)
                {
                    _aggregateManager.SetAggregateChecks(false);
                    cbUncheckAll.Checked = false;
                    cbCheckAll.Checked = false;
                    UpdateSplitContainerState();
                }
            };

            copyModeGallery.SelectedIndexChanged += (s, e) =>
            {
                _clipboardManager.UpdateCopyMode();
                c1Ribbon1.Refresh();
            };

            _aggregateManager.AggregatesComputed += (s, e) =>
            {
                if (e.Aggregates.Any())
                {
                    aggregatePanel.Visible = true;
                    aggregatePanel.UpdateAggregates(e.Aggregates);

                    splitContainer1.Panel2MinSize = 150; 
                    splitContainer1.Panel2Collapsed = false;
                    splitContainer1.SplitterDistance = Math.Min(splitContainer1.Width - 380,
                                                               splitContainer1.SplitterDistance);
                }
                else
                {
                    aggregatePanel.ClearDisplay();
                    aggregatePanel.Visible = false;
                }
            };

            aggregatePanel.CloseButtonClicked += AggregateUserControl_CloseButtonClicked;

            rbSelectionMod.SelectedIndexChanged += (s, e) =>
            {
                if (rbSelectionMod.SelectedItem != null && rbSelectionMod.SelectedItem.Tag is SelectionModeEnum newMode)
                {
                    _selectionModeManager.HandleSelectionModeChanged(newMode);
                }
                UpdateSelectionRibbonIcon();
            };

            tbSearch.TextChanged += (s, e) => _clipboardManager.ApplySearch();

            copyBtn.Click += (s, e) =>
            {
                _clipboardManager.Copy();
                pasteBtn.Enabled = true;
            };

            pasteBtn.Click += (s, e) => _clipboardManager.Paste();

            SubscribeAggregateCheckboxEvents();
        }

        private void SubscribeAggregateCheckboxEvents()
        {
            cbSum.CheckedChanged += AggregateCheckbox_Changed;
            cbCount.CheckedChanged += AggregateCheckbox_Changed;
            cbAverage.CheckedChanged += AggregateCheckbox_Changed;
            cbCountDistinct.CheckedChanged += AggregateCheckbox_Changed;
            cbMax.CheckedChanged += AggregateCheckbox_Changed;
            cbMin.CheckedChanged += AggregateCheckbox_Changed;
            cbSampleVariance.CheckedChanged += AggregateCheckbox_Changed;
            cbPopulationStandardDeviation.CheckedChanged += AggregateCheckbox_Changed;
            cbPopulationVariance.CheckedChanged += AggregateCheckbox_Changed;
            cbSampleStandardDeviation.CheckedChanged += AggregateCheckbox_Changed;
        }

        private void AggregateCheckbox_Changed(object sender, EventArgs e)
        {
            UpdateSplitContainerState();

            if (_isUpdatingCheckboxes)
                return;

            // Check if all checkboxes are checked
            bool allChecked = cbSum.Checked && cbCount.Checked && cbAverage.Checked &&
                             cbCountDistinct.Checked && cbMax.Checked && cbMin.Checked &&
                             cbSampleVariance.Checked && cbPopulationStandardDeviation.Checked &&
                             cbPopulationVariance.Checked && cbSampleStandardDeviation.Checked;

            cbCheckAll.Checked = allChecked;
        }
        /// <summary>
        /// Updates the split container state: if any aggregate checkbox is checked, Panel2 is shown.
        /// Otherwise, Panel2 is collapsed.
        /// </summary>
        private void UpdateSplitContainerState()
        {
            bool anyChecked = cbSum.Checked || cbCount.Checked || cbAverage.Checked || cbCountDistinct.Checked ||
                              cbMax.Checked || cbMin.Checked || cbSampleVariance.Checked || cbPopulationStandardDeviation.Checked ||
                              cbPopulationVariance.Checked || cbSampleStandardDeviation.Checked;
            splitContainer1.Panel2Collapsed = !anyChecked;
        }
        /// <summary>
        /// Handles the close button event from AggregateUserControl.
        /// When clicked, Panel2 is collapsed.
        /// </summary>
        private void AggregateUserControl_CloseButtonClicked(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }
        #endregion

        #region FlexGrid Initialization
        private void InitializeFlexGrid()
        {
            sourceFlexGrid.BeginUpdate();
            sourceFlexGrid.DataSource = DataSource.GetRows("Select * from Orders");
            sourceFlexGrid.AutoSizeCols();
            sourceFlexGrid.AutoSizeRows();
            sourceFlexGrid.AutoClipboard = true;
            sourceFlexGrid.SelectionMode = SelectionModeEnum.Default;
            sourceFlexGrid.EndUpdate();
        }
        #endregion

        #region Clear, SelectAll and About
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            destinationFlexGrid.Clear();
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            sourceFlexGrid.Select(1, 1, sourceFlexGrid.Rows.Count - 1, sourceFlexGrid.Cols.Count - 1, true);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            using (var infoForm = new About())
            {
                infoForm.StartPosition = FormStartPosition.CenterParent;
                infoForm.ShowDialog(this);
            }
        }
        #endregion

        #region Rounded Corner
        //if you are developing for .Net 9 or higher, use System.Drawing.Common.Graphics.DrawRoundedRectangle instead of this helper methods
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control control)
            {
                using (var path = CreateRoundedRectanglePath(control.ClientRectangle, 10))
                {
                    control.Region = new Region(path);
                }
            }
        }
        private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            var path = new GraphicsPath();
            int diameter = cornerRadius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
        #endregion
    }
}
