// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using MultiSelectExplorer.Properties;
using MultiSelectExplorer.Samples.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Designer
{
    /// <summary>
    /// A user control that allows selecting team members and confirming selections.
    /// </summary>
    public partial class DesignerControl : UserControl
    {
        /// <summary>
        /// Raised when the reset action is triggered.
        /// </summary>
        public event EventHandler DesignerActionTriggered;

        private readonly MemberSelectionService _selectionService;

        public DesignerControl()
        {
            InitializeComponent();
            InitializeLocalizedText();

            // Initialize with default member selection service
            _selectionService = new MemberSelectionService();

            InitializeMultiSelect();
        }

        private void InitializeLocalizedText()
        {
            btnResetEventControl.Text = Resources.Reset;
            btnConfirmSelection.Text = Resources.ConfirmSelection;

            _multiSelect.Placeholder = Resources.SelectTeamMemberValue;
            lblMultiSelectMemberTitle.Text = Resources.TeamMemberTitle;
        }

        /// <summary>
        /// Sets up the multiselect control with predefined values and behaviors.
        /// </summary>
        private void InitializeMultiSelect()
        {
            _multiSelect.Items.AddRange(_selectionService.GetAvailableMembers().ToArray());

            //indicating whether to open the drop down control when the control receives the focus
            _multiSelect.AutoOpen = true;
        }

        private void btnResetEventControl_Click(object sender, EventArgs e)
        {
            OnDesignerActionTriggered();
        }

        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            IEnumerable<string> selectedMembers = _selectionService.GetSelectedMembers(_multiSelect);

            if (!_selectionService.HasValidSelection(selectedMembers))
            {
                ShowWarning(Resources.NoTeamMemberSelectionMessage, Resources.NoTeamMemberSelectionTitle);
                return;
            }

            using (var overlay = OverlayHelper.CreateOverlay(this))
            {
                overlay.Show();

                using (var dialog = new ConfimedSelectionForm(string.Join(", ", selectedMembers)))
                {
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    dialog.ShowDialog(overlay);
                }
            }
        }

        /// <summary>
        /// Invokes the <see cref="DesignerActionTriggered"/> event.
        /// </summary>
        protected virtual void OnDesignerActionTriggered()
        {
            DesignerActionTriggered?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Displays a warning message.
        /// </summary>
        private static void ShowWarning(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void propertyGridMultiSelect_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                _multiSelect.Focus();
            }));
        }
    }
}
