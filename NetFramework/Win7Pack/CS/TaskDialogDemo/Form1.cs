using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace TaskDialogDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkCommonButtons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TaskDialogResult result = dialogCommonButtons.Show();
            string buttonText = result == TaskDialogResult.Ok ? "OK" : result.ToString();
            MessageBox.Show(string.Format("The \"{0}\" button was clicked.", buttonText),
                "Common Buttons Sample");
        }

        private void linkCustomButtons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogCustomButtons.Show();
        }

        private void dialogCustomButtons_ButtonClick(object sender, TaskDialogButtonClickEventArgs e)
        {
            if (e.DialogResult == TaskDialogResult.Custom)
            {
                switch (e.CustomButton.Name)
                {
                    case "Button1":
                        MessageBox.Show("Custom button 1 was clicked.", "Custom Buttons Sample");
                        e.Cancel = true;
                        break;
                    case "Button2":
                        MessageBox.Show("Custom button 2 was clicked.", "Custom Buttons Sample");
                        e.Cancel = true;
                        break;
                    case "Button3":
                        MessageBox.Show("Custom close button was clicked. Closing the dialog...", "Custom Buttons Sample");
                        break;
                }
            }
        }

        private void linkEnableDisable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogEnableDisable.Show();
        }

        private void dialogEnableDisable_ButtonClick(object sender, TaskDialogButtonClickEventArgs e)
        {
            if (e.DialogResult == TaskDialogResult.Custom)
            {
                CustomButtonCollection cbc = dialogEnableDisable.CustomButtons;
                if (e.CustomButton.Name == "enableButton")
                {
                    dialogEnableDisable.RadioButtons[0].Enabled = true;
                    cbc["enableButton"].Enabled = false;
                    cbc["disableButton"].Enabled = true;
                }
                else if (e.CustomButton.Name == "disableButton")
                {
                    dialogEnableDisable.RadioButtons[0].Enabled = false;
                    cbc["enableButton"].Enabled = true;
                    cbc["disableButton"].Enabled = false;
                }
                e.Cancel = true;
            }
        }

        private void linkElevation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogElevation.Show();
        }

        private void linkError_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogError.Show();
        }

        private void dialogError_ButtonClick(object sender, TaskDialogButtonClickEventArgs e)
        {
            if (e.DialogResult == TaskDialogResult.Custom &&
                e.CustomButton.Name == "sendButton")
            {
                C1TaskDialog sendDialog = new C1TaskDialog();
                sendDialog.WindowTitle = "Send Feedback Dialog";
                sendDialog.Content = "Sending your feedback .....";
                sendDialog.ProgressBar.Maximum = 5000;
                sendDialog.ProgressBar.Visible = true;
                sendDialog.EnableTimer = true;
                sendDialog.TimerTick += new TaskDialogTimerTickEventHandler(sendDialog_TimerTick);

                sendDialog.Show();
                sendDialog.Dispose();
            }
        }

        private void sendDialog_TimerTick(object sender, TaskDialogTimerTickEventArgs e)
        {
            C1TaskDialog dialog = (C1TaskDialog)sender;
            if (e.Ticks <= 5000)
            {
                dialog.MainInstruction = string.Format("Sending ....{0}", e.Ticks);
                dialog.ProgressBar.Value = e.Ticks;
            }
            else
            {
                dialog.MainInstruction = "Thanks for the feedback!";
                dialog.Content = "Our developers will get right on that...";
                dialog.ProgressBar.Value = 5000;
            }
        }

        private void linkIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogIcons.Show(false);
        }

        private void dialogIcons_RadioButtonClick(object sender, EventArgs e)
        {
            C1TaskDialog dialog = (C1TaskDialog)sender;
            switch (dialog.SelectedRadioButton.Name)
            {
                case "radioNone":
                    dialog.MainCommonIcon = TaskDialogCommonIcon.None;
                    dialog.FooterCommonIcon = TaskDialogCommonIcon.None;
                    break;
                case "radioError":
                    dialog.MainCommonIcon = TaskDialogCommonIcon.Error;
                    dialog.FooterCommonIcon = TaskDialogCommonIcon.Error;
                    break;
                case "radioWarning":
                    dialog.MainCommonIcon = TaskDialogCommonIcon.Warning;
                    dialog.FooterCommonIcon = TaskDialogCommonIcon.Warning;
                    break;
                case "radioInformation":
                    dialog.MainCommonIcon = TaskDialogCommonIcon.Information;
                    dialog.FooterCommonIcon = TaskDialogCommonIcon.Information;
                    break;
                case "radioShield":
                    dialog.MainCommonIcon = TaskDialogCommonIcon.Shield;
                    dialog.FooterCommonIcon = TaskDialogCommonIcon.Shield;
                    break;
            }
        }

        private void linkProgress1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogProgress1.ProgressBar.Value = 0;
            dialogProgress1.Show();
        }

        private void dialogProgress1_TimerTick(object sender, TaskDialogTimerTickEventArgs e)
        {
            C1TaskDialog dialog = (C1TaskDialog)sender;
            if (e.Ticks <= 5000)
            {
                dialog.MainInstruction = string.Format("Progress = {0}", e.Ticks);
                dialog.ProgressBar.Value = e.Ticks;
            }
            else
            {
                dialog.MainInstruction = "Progress = Done";
                dialog.ProgressBar.Value = 5000;
            }
        }

        private void linkProgress2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogProgress2.Show();
        }

        private void linkTimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dialogTimer.MainInstruction = "Time elapsed: 0 seconds";
            dialogTimer.Show();
        }

        private void dialogTimer_TimerTick(object sender, TaskDialogTimerTickEventArgs e)
        {
            ((C1TaskDialog)sender).MainInstruction = string.Format("Time elapsed: {0} seconds", e.Ticks / 1000);
        }
    }
}
