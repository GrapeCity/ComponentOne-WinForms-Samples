using FlexGridAi.Forms;

namespace FlexGridAi.Utilities
{
    public static class EnvironmentHelper
    {
        const string _apiKeyEnvVar = "GEMINI_API_KEY";

        public static string GetApiKey()
        {
            return Environment.GetEnvironmentVariable(_apiKeyEnvVar, EnvironmentVariableTarget.User);
        }

        public static void SetApiKey(string key)
        {
            Environment.SetEnvironmentVariable(_apiKeyEnvVar, key, EnvironmentVariableTarget.User);
        }

        public static bool EnsureApiKey(Form parentForm)
        {
            if (string.IsNullOrEmpty(GetApiKey()))
            {
                parentForm.BeginInvoke((Action)(() =>
                {
                    using (var overlay = new Form())
                    {
                        // Configure the dimmed overlay
                        overlay.StartPosition = FormStartPosition.Manual;
                        overlay.FormBorderStyle = FormBorderStyle.None;
                        overlay.ShowInTaskbar = false;
                        overlay.BackColor = Color.Black;
                        overlay.Opacity = 0.3;
                        overlay.Size = parentForm.ClientSize;
                        overlay.Location = parentForm.PointToScreen(parentForm.ClientRectangle.Location);
                        overlay.Owner = parentForm;

                        // Show the overlay
                        overlay.Show();

                        // Show the API key entry dialog
                        using (var apiKeyForm = new FormApiKeyEntry())
                        {
                            apiKeyForm.StartPosition = FormStartPosition.CenterParent;
                            apiKeyForm.ShowInTaskbar = false;
                            apiKeyForm.ShowDialog(overlay); // Show on top of the overlay
                        }

                    }
                }));
                return false;
            }
            return true;
        }
    }
}
