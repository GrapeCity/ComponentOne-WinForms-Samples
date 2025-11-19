// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using MultiSelectExplorer.Properties;
using System;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Designer
{
    /// <summary>
    /// Represents a confirmation dialog that displays the selected member(s)
    /// and allows the user to confirm or cancel their selection.
    /// </summary>
    public partial class ConfimedSelectionForm : Form
    {
        private string _selectedMember;
        public ConfimedSelectionForm(string selectedMember)
        {
            _selectedMember = selectedMember;
            InitializeComponent();
            InitializeLocalizedText();
        }

        private void InitializeLocalizedText()
        {
            int memberCount = _selectedMember.Split(',').Length;
            lblSelectedMemberTitle.Text = string.Format(Resources.SelectedMemberTitle, memberCount);
            lblSelectedMember.Text = Text = "✓ " + _selectedMember;
            btnCancel.Text = Resources.Cancel;
            btnAddMember.Text = Resources.AddToTeam;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmSelection_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(Resources.MemberAddedMessage, _selectedMember));
            this.Close();
        }
    }
}
