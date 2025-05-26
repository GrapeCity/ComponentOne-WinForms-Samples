using FlexGridAi.Helpers;
using FlexGridAi.Utilities;
using System.Diagnostics;

namespace FlexGridAi.Forms
{
    public partial class FormApiKeyEntry : Form
    {
        public FormApiKeyEntry()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 

            txtBoxApiKey.Text = EnvironmentHelper.GetApiKey();
            txtBoxApiKey.UseSystemPasswordChar = true;
            btnToggle.Icon = Resources.ControlIcons.EyeCloseIcon;

            AddLinkToDescription(" Here’s how to create API key", "https://ai.google.dev/gemini-api/docs/api-key");
        }

        private void AddLinkToDescription(string linkText, string linkUrl)
        {
            if (string.IsNullOrEmpty(linkText)) return;

            int index = linkLblDescription.Text.IndexOf(linkText);
            if (index >= 0)
            {
                linkLblDescription.Links.Add(index, linkText.Length, linkUrl);
            }
        }

        /// Prevent window from being moved or resized
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MOVE = 0xF010;
            const int HTCAPTION = 0x2;
            const int WM_NCLBUTTONDBLCLK = 0xA3;
            const int HTCLIENT = 1;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCLIENT; // Pretend mouse is always on client area
                return;
            }

            if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MOVE)
            {
                // Block moving the window via keyboard or mouse
                return;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return; // Prevent maximize/double-click
            }

            base.WndProc(ref m);
        }

        #region Control State Management

        private void SetControlState(bool isEnabled)
        {
            btnConfirm.Enabled = isEnabled;
            txtBoxApiKey.Enabled = isEnabled;
            btnToggle.Enabled = isEnabled;
        }

        #endregion

        #region UI Event Handlers

        private async void BtnConfirm_Click(object sender, EventArgs e)
        {
            string enteredKey = txtBoxApiKey.Text?.Trim();

            if (string.IsNullOrWhiteSpace(enteredKey))
            {
                ShowError("Please enter an API key.");
                return;
            }

            if (enteredKey == EnvironmentHelper.GetApiKey())
            {
                ShowError("This API key is already saved.");
                return;
            }

            SetControlState(false);
            ShowError("Validating API key...");

            try
            {
                await GeminiService.ValidateApiKeyAsync(enteredKey);
                EnvironmentHelper.SetApiKey(enteredKey);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (HttpRequestException ex)
            {
                ShowError(ex.Message);
            }
            catch (TaskCanceledException ex)
            {
                ShowError(ex.Message);
            }
            catch (GeminiApiException ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                SetControlState(true);
            }
        }

        private void LinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = e.Link.LinkData.ToString(),
                    UseShellExecute = true
                });
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show($"Failed to open the link. No application is associated with the URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnToggle_Click(object sender, EventArgs e)
        {
            bool isMasked = txtBoxApiKey.UseSystemPasswordChar;
            txtBoxApiKey.UseSystemPasswordChar = !isMasked;

            btnToggle.Icon = isMasked
                ? Resources.ControlIcons.EyeOpenIcon
                : Resources.ControlIcons.EyeCloseIcon;
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
        }

        #endregion
    }
}
