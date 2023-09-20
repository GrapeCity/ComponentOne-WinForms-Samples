//----------------------------------------------------------------------------
// MessageForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using C1.Win.Localization;

namespace FlexReportDesignerApp
{
    /// <summary>
    /// Represents a message box that can optionally display a checkbox
    /// "do not show this again".
    /// </summary>
    public partial class MessageForm : Form
    {
        /// <summary>
        /// Keys for messages that allow the "do not show this again" option.
        /// </summary>
        public enum MessageKey
        {
            None,
            WarnOnAbort,
            WarnImportCrystalRASNotAvailable,
            WarnAppIn64bitMode,
        }

        /// <summary>
        /// List of warning names for suppressable warnings - MUST BE SYNCED with MessageKey!!!
        /// </summary>
        public static readonly Dictionary<MessageKey, string> KeyedMessages = new Dictionary<MessageKey, string>()
            {
                { MessageKey.None, null },
                { MessageKey.WarnOnAbort, Strings.MessageForm.MessageNames.WarnOnAbort },
                { MessageKey.WarnImportCrystalRASNotAvailable, Strings.MessageForm.MessageNames.WarnImportCrystalRASNotAvailable },
                // ...
            };

        public enum Caption
        {
            Message,
            Warning,
            Confirm,
            Error,
            Fatal,
        }

        private static readonly Dictionary<Caption, string> c_captions = new Dictionary<Caption, string>()
        {
            { Caption.Message, Strings.MessageForm.Captions.Message },
            { Caption.Warning, Strings.MessageForm.Captions.Warning },
            { Caption.Confirm, Strings.MessageForm.Captions.Confirm },
            { Caption.Error, Strings.MessageForm.Captions.Error },
            { Caption.Fatal, Strings.MessageForm.Captions.Fatal },
        };

        // Used to replace single '\n' chars with '\r\n' for newlines in TextBox:
        private static readonly Regex c_newlines = new Regex(@"(?<!\r)\n", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        private static System.Collections.ArrayList s_suppressMessages = null;
        private const string c_suppressMessagesSettingName = "suppressmessages";

        static MessageForm()
        {
            // If the .settings file is corrupt, we still need to proceed. (TFS:214796)
            try
            {
                s_suppressMessages = Util.AppSettings.LoadList(c_suppressMessagesSettingName, MessageForm.Warn);
            }
            catch
            {
                s_suppressMessages = new System.Collections.ArrayList();
            }
        }

        public MessageForm()
        {
            InitializeComponent();
            //
            this.toolTip1.SetToolTip(this.chkDoNotShowAgain, Strings.MessageForm.TT_chkDoNotShowAgain);
            // 
            lblMessage.MaximumSize = new Size(
                Screen.PrimaryScreen.WorkingArea.Width / 2,
                Screen.PrimaryScreen.WorkingArea.Height / 2);

            lblMessage.TextChanged += (ss, ee) =>
                {
                    var s = TextRenderer.MeasureText(lblMessage.Text, lblMessage.Font, lblMessage.ClientRectangle.Size, TextFormatFlags.WordBreak);
                    lblMessage.Height = (int)s.Height;
                };

            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.DialogResult = DialogResult.Cancel;
        }

        static public bool GetMessageSuppressed(MessageKey messageKey)
        {
            return s_suppressMessages.Contains(messageKey.ToString());
        }

        static public void SetMessageSuppressed(MessageKey messageKey, bool value)
        {
            bool change = false;
            if (value)
            {
                if (!GetMessageSuppressed(messageKey))
                {
                    s_suppressMessages.Add(messageKey.ToString());
                    change = true;
                }
            }
            else
            {
                if (GetMessageSuppressed(messageKey))
                {
                    s_suppressMessages.Remove(messageKey.ToString());
                    change = true;
                }
            }
            if (change)
                Util.AppSettings.SaveList(c_suppressMessagesSettingName, s_suppressMessages, false, MessageForm.Warn);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Button btn = this.AcceptButton as Button;
            if (btn != null && btn.Visible)
            {
                btn.Focus();
                return;
            }
            btn = this.CancelButton as Button;
            if (btn != null && btn.Visible)
            {
                btn.Focus();
                return;
            }
            if (btnOk.Visible)
                btnOk.Focus();
            else if (btnNo.Visible)
                btnNo.Focus();
            else if (btnCancel.Visible)
                btnCancel.Focus();
        }

        /// <summary>
        /// Shows a dialog with a question.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="buttons"></param>
        /// <returns></returns>
        public static DialogResult Ask(string msg, MessageBoxButtons buttons)
        {
            MainForm.HideSpash();
            return Show(null, Caption.Confirm, msg, buttons, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Shows a dialog with a question.
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult Ask(string msg)
        {
            return Ask(msg, MessageBoxButtons.YesNo);
        }

        /// <summary>
        /// Shows an info message.
        /// </summary>
        /// <param name="msg"></param>
        public static void Info(string msg)
        {
            MainForm.HideSpash();
            Show(null, Caption.Message, msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows a warning message.
        /// </summary>
        /// <param name="msg"></param>
        public static void Warn(string msg)
        {
            MainForm.HideSpash();
            Show(null, Caption.Warning, msg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Shows an error message.
        /// </summary>
        /// <param name="msg"></param>
        public static void Error(string msg)
        {
            MainForm.HideSpash();
            Show(null, Caption.Error, msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a fatal error message.
        /// </summary>
        /// <param name="msg"></param>
        public static void Fatal(string msg)
        {
            MainForm.HideSpash();
            Show(null, Caption.Fatal, msg, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Program.Exit(Program.ExitCodes.FatalError);
        }

        private static string ValidateNewlines(string @string)
        {
            return c_newlines.Replace(@string, Environment.NewLine);
        }

        /// <summary>
        /// Shows a message similar to the standard MessageBox.Show.
        /// This overload does not show the "do not show this again" checkbox.
        /// </summary>
        /// <param name="owner">The owner form.</param>
        /// <param name="message">The message to show.</param>
        /// <param name="caption">The dialog caption.</param>
        /// <param name="buttons">The buttons to show in the dialog.</param>
        /// <param name="icon">The icon to show in the dialog.</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(
            IWin32Window owner,
            Caption caption,
            string message,
            MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return Show(owner, caption, message, buttons, icon, MessageKey.None);
        }

        /// <summary>
        /// Shows a message including the "do not show this again" checkbox.
        /// If that checkbox has been checked in the past, the message is not shown at all.
        /// Note that "do not show this again" is ignored unless the user also pressed OK or Yes.
        /// </summary>
        /// <param name="owner">The owner form.</param>
        /// <param name="message">The message to show.</param>
        /// <param name="caption">The dialog caption.</param>
        /// <param name="buttons">The buttons to show in the dialog.</param>
        /// <param name="icon">The icon to show in the dialog.</param>
        /// <param name="messageKey">The message key (used to mark messages that are not to be shown, in the settings file).</param>
        /// <returns>The dialog result.</returns>
        public static DialogResult Show(
            IWin32Window owner,
            Caption caption,
            string message,
            MessageBoxButtons buttons,
            MessageBoxIcon icon,
            MessageKey messageKey)
        {
            using (MessageForm mf = new MessageForm())
            {
                DialogResult res = DialogResult.Cancel;
                mf.Text = c_captions[caption];
                mf.lblMessage.Text = ValidateNewlines(message);
                switch (buttons)
                {
                    case MessageBoxButtons.OK:
                        mf.btnOk.Text = Strings.MessageForm.ButtonOK;
                        mf.btnOk.DialogResult = DialogResult.OK;
                        mf.btnNo.Visible = mf.btnCancel.Visible = false;
                        mf.AcceptButton = mf.btnOk;
                        res = DialogResult.OK;
                        break;
                    case MessageBoxButtons.OKCancel:
                        mf.btnOk.Text = Strings.MessageForm.ButtonOK;
                        mf.btnOk.DialogResult = DialogResult.OK;
                        mf.btnCancel.Text = Strings.MessageForm.ButtonCancel;
                        mf.btnCancel.DialogResult = DialogResult.Cancel;
                        mf.btnNo.Visible = false;
                        mf.AcceptButton = mf.btnOk;
                        mf.CancelButton = mf.btnCancel;
                        res = DialogResult.OK;
                        break;
                    case MessageBoxButtons.AbortRetryIgnore:
                        mf.btnOk.Text = Strings.MessageForm.ButtonAbort;
                        mf.btnOk.DialogResult = DialogResult.Abort;
                        mf.btnNo.Text = Strings.MessageForm.ButtonRetry;
                        mf.btnNo.DialogResult = DialogResult.Retry;
                        mf.btnCancel.Text = Strings.MessageForm.ButtonIgnore;
                        mf.btnCancel.DialogResult = DialogResult.Ignore;
                        messageKey = MessageKey.None; // do not allow "do not show this again"
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        mf.btnOk.Text = Strings.MessageForm.ButtonYes;
                        mf.btnOk.DialogResult = DialogResult.Yes;
                        mf.btnNo.Text = Strings.MessageForm.ButtonNo;
                        mf.btnNo.DialogResult = DialogResult.No;
                        mf.btnCancel.Text = Strings.MessageForm.ButtonCancel;
                        mf.btnCancel.DialogResult = DialogResult.Cancel;
                        mf.AcceptButton = mf.btnOk;
                        mf.CancelButton = mf.btnCancel;
                        res = DialogResult.Yes;
                        break;
                    case MessageBoxButtons.YesNo:
                        mf.btnOk.Text = Strings.MessageForm.ButtonYes;
                        mf.btnOk.DialogResult = DialogResult.Yes;
                        mf.btnNo.Text = Strings.MessageForm.ButtonNo;
                        mf.btnNo.DialogResult = DialogResult.No;
                        mf.btnCancel.Visible = false;
                        mf.AcceptButton = mf.btnOk;
                        res = DialogResult.Yes;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        mf.btnOk.Text = Strings.MessageForm.ButtonRetry;
                        mf.btnOk.DialogResult = DialogResult.Retry;
                        mf.btnCancel.Text = Strings.MessageForm.ButtonCancel;
                        mf.btnCancel.DialogResult = DialogResult.Cancel;
                        mf.btnNo.Visible = false;
                        mf.CancelButton = mf.btnCancel;
                        messageKey = MessageKey.None; // do no allow "do not show this again"
                        break;
                    default:
                        Debug.Assert(false);
                        return DialogResult.Cancel;
                }

                switch (icon)
                {
                    case MessageBoxIcon.None:
                        mf.picIcon.Visible = false;
                        break;
                    case MessageBoxIcon.Error:
                    //case MessageBoxIcon.Hand:
                    //case MessageBoxIcon.Stop:
                        mf.picIcon.Image = global::FlexReportDesignerApp.Properties.Resources.error32;
                        break;
                    case MessageBoxIcon.Question:
                        mf.picIcon.Image = global::FlexReportDesignerApp.Properties.Resources.question32;
                        break;
                    case MessageBoxIcon.Exclamation:
                    //case MessageBoxIcon.Warning:
                        mf.picIcon.Image = global::FlexReportDesignerApp.Properties.Resources.warn32;
                        break;
                    case MessageBoxIcon.Information:
                    //case MessageBoxIcon.Asterisk:
                        mf.picIcon.Image = global::FlexReportDesignerApp.Properties.Resources.info32;
                        break;
                    default:
                        Debug.Assert(false);
                        return DialogResult.Cancel;
                }

                bool show;
                if (messageKey != MessageKey.None)
                {
                    mf.chkDoNotShowAgain.Visible = true;
                    show = !GetMessageSuppressed(messageKey);
                }
                else
                {
                    mf.chkDoNotShowAgain.Visible = false;
                    show = true;
                }

                if (show)
                {
                    if (owner == null)
                        mf.StartPosition = FormStartPosition.CenterScreen;
                
                show_dialog:
                    res = mf.ShowDialog(owner);

                    // make sure:
                    if (res == DialogResult.Abort)
                    {
                        DialogResult abort = Show(mf, Caption.Confirm, Strings.MessageForm.ConfirmAbort, MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageKey.WarnOnAbort);
                        if (abort != DialogResult.Yes)
                            goto show_dialog;
                        // ABORT:
                        Program.Exit(Program.ExitCodes.UserAbort); // ooops
                    }
                }
                // else we already set the default result

                if (messageKey != MessageKey.None && mf.chkDoNotShowAgain.Checked && (res == DialogResult.OK || res == DialogResult.Yes))
                    SetMessageSuppressed(messageKey, true);

                return res;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
