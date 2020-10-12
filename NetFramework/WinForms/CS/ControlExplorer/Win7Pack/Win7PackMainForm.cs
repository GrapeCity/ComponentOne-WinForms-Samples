using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace ControlExplorer.Win7Pack
{
    public partial class Win7PackMainForm : C1DemoForm
    {
        public Win7PackMainForm()
        {
            InitializeComponent();
        }

        private void btnJumpTaskDemo_Click(object sender, EventArgs e)
        {
            if (C1TaskbarButton.IsPlatformSupported)
            {
                JumpTaskDemo demo = new JumpTaskDemo();
                demo.StartPosition = FormStartPosition.CenterScreen;
                demo.Show();
            }
            else
            {
                MessageBox.Show("C1TaskbarButton is only supported on Windows 7 and later systems.");
            }
        }

        private void btnProgressDemo_Click(object sender, EventArgs e)
        {
            if (C1TaskbarButton.IsPlatformSupported)
            {
                ProgressIndicatorDemo demo = new ProgressIndicatorDemo();
                demo.StartPosition = FormStartPosition.CenterScreen;
                demo.Show();
            }
            else
            {
                MessageBox.Show("C1TaskbarButton is only supported on Windows 7 and later systems.");
            }
        }

        private void btnThumbnailButtons_Click(object sender, EventArgs e)
        {
            if (C1TaskbarButton.IsPlatformSupported)
            {
                ThumbnailButtonDemo demo = new ThumbnailButtonDemo();
                demo.StartPosition = FormStartPosition.CenterScreen;
                demo.Show();
            }
            else
            {
                MessageBox.Show("C1TaskbarButton is only supported on Windows 7 and later systems.");
            }
        }

        private void btnDialogDemo_Click(object sender, EventArgs e)
        {
            if (C1TaskDialog.IsPlatformSupported)
            {
                // show custom error dialog
                dialogError.Show();
            }
            else
            {
                MessageBox.Show("Sorry, C1TaskDialog is only supported on Vista and later systems.");
            }
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
    }
}
