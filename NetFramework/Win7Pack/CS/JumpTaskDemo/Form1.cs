using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Win7Pack;

namespace JumpTaskDemo
{
    internal enum JumpTaskAction
    {
        None,
        Available,
        Busy,
        Away,
        AppearOffline,
        SignInOut
    }

    public partial class Form1 : Form
    {
        internal static JumpTaskAction Action = JumpTaskAction.None;
        private bool _first = true;

        private bool _signedIn;
        private int _status;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_signedIn)
            {
                _signedIn = false;
                _status = 0;
                UpdateJumpTasks();
                taskbarButton.JumpList.Apply();
            }
        }

        private void tm_ApplyingJumpListChanges(object sender, CancelEventArgs e)
        {
            if (_first)
            {
                _first = false;
                HandleJumpTaskAction();
                UpdateJumpTasks();
                UpdateOverlay();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Program.WM_UpdateDemoStatus)
            {
                Action = (JumpTaskAction)m.WParam.ToInt32();
                if (HandleJumpTaskAction())
                {
                    UpdateJumpTasks();
                    taskbarButton.JumpList.Apply();
                    UpdateOverlay();
                }
                m.Result = IntPtr.Zero;
            }
            base.WndProc(ref m);
        }

        private bool HandleJumpTaskAction()
        {
            if (Action == JumpTaskAction.None)
            {
                return false;
            }
            if (!_signedIn)
            {
                if (Action != JumpTaskAction.SignInOut)
                {
                    _status = (int)Action;
                }
                else
                {
                    _status = 1;
                }
                if (!signInDialog.CheckBoxChecked)
                {
                    signInDialog.SetDefaultRadioIndex(_status - 1);
                    if (signInDialog.Show(this) != TaskDialogResult.Yes)
                    {
                        return false;
                    }
                    _status = signInDialog.SelectedRadioIndex + 1;
                }
                _signedIn = true;
            }
            else if (Action != JumpTaskAction.SignInOut)
            {
                if (_status == (int)Action)
                {
                    return false;
                }
                _status = (int)Action;
            }
            else
            {
                _signedIn = false;
                _status = 0;
            }
            return true;
        }

        private void UpdateJumpTasks()
        {
            JumpTaskCollection tasks = taskbarButton.JumpList.Tasks;
            tasks[0].IconIndex = _status == 1 ? 2 : 1;
            tasks[1].IconIndex = _status == 2 ? 2 : 1;
            tasks[2].IconIndex = _status == 3 ? 2 : 1;
            tasks[3].IconIndex = _status == 4 ? 2 : 1;
            tasks[5].Title = _signedIn ? "Sign Out" : "Sign In...";
        }

        private void UpdateOverlay()
        {
            Icon icon = null;
            if (!_signedIn)
                icon = Properties.Resources.SignedOut;
            else
            {
                switch (_status)
                {
                    case 1:
                        icon = Properties.Resources.Available;
                        break;
                    case 2:
                        icon = Properties.Resources.Busy;
                        break;
                    case 3:
                        icon = Properties.Resources.Away;
                        break;
                    case 4:
                        icon = Properties.Resources.Offline;
                        break;
                }
            }
            taskbarButton.OverlayIcon = icon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _signedIn = false;
            taskbarButton.JumpList.ClearTasksAndCustomCategories();
            taskbarButton.OverlayIcon = null;
        }
    }
}
