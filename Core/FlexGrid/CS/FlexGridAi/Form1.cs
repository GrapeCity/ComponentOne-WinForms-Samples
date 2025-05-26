using FlexGridAi.Data;
using FlexGridAi.Forms;
using FlexGridAi.Helpers;
using FlexGridAi.Utilities;
using System.Data;

namespace FlexGridAi
{
    public partial class Form1 : Form
    {
        DataTable _originalDataTable;
        string _sqlQuery = @"
            SELECT 
                p.ProductID,
                p.ProductName,
                p.QuantityPerUnit,
                p.UnitPrice,
                p.UnitsInStock,
                p.UnitsOnOrder,
                p.ReorderLevel,
                p.Discontinued,

                s.ContactName AS SupplierName,
                s.Country,

                c.CategoryName
            FROM Products p
            JOIN Suppliers s ON p.SupplierID = s.SupplierID
            JOIN Categories c ON p.CategoryID = c.CategoryID;
            "
        ;

        public Form1()
        {
            InitializeComponent();
        }

        private void CenterLoadingIcon()
        {
            picBoxLoading.Location = new Point(
                txtBoxGetResponse.Left + (txtBoxGetResponse.Width - picBoxLoading.Width) / 2,
                txtBoxGetResponse.Top + (txtBoxGetResponse.Height - picBoxLoading.Height) / 2
            );
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLoadingIcon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLoadingIcon();

            _originalDataTable = DataSource.GetRows(_sqlQuery);
            flexGrid.DataSource = _originalDataTable;

            if (!EnvironmentHelper.EnsureApiKey(this)) return;
        }

        #region Control State Management

        private void SetControlState(bool isEnabled)
        {
            customTxtBoxSendPrompt.AskButtonEnabled = isEnabled;
            btnResetGrid.Enabled = isEnabled;
            customTxtBoxSendPrompt.Enabled = isEnabled;
            btnManageApiKey.Enabled = isEnabled;
            btnClearText.Enabled = isEnabled;
            picBoxLoading.Visible = !isEnabled;
        }

        #endregion

        #region Event Handlers

        private async void CustomTxtBox_AskBtnClick(object sender, EventArgs e)
        {
            try
            {
                string userPrompt = customTxtBoxSendPrompt.InputText.Trim();

                if (!EnvironmentHelper.EnsureApiKey(this)) return;

                if (string.IsNullOrEmpty(userPrompt))
                {
                    txtBoxGetResponse.Text = "Please enter a prompt!";
                    return;
                }

                string jsonData = DataTableJsonConverter.ConvertDataTableToJson(_originalDataTable);

                SetControlState(false);
                txtBoxGetResponse.Text = string.Empty;

                var gs = new GeminiService();
                string responseJson = await gs.GetResponseAsync(userPrompt, jsonData);

                var parsedResult = GeminiResponseParser.ExtractJsonFromResponse(responseJson);

                // Show the response message
                txtBoxGetResponse.Text = parsedResult.ResponseText;
                txtBoxGetResponse.Styles.Disabled.ForeColor = SystemColors.ControlText;

                // If there's JSON data, bind it to the grid
                if (!string.IsNullOrEmpty(parsedResult.JsonData))
                {
                    DataTable updatedDataTable = DataTableJsonConverter.ConvertJsonToDataTable(parsedResult.JsonData);
                    _originalDataTable = updatedDataTable;
                    flexGrid.DataSource = updatedDataTable;
                }
            }
            catch (HttpRequestException ex)
            {
                ShowError($"An error occurred: \n{ex.Message}");
            }
            catch (TaskCanceledException ex)
            {
                ShowError($"An error occurred: \n{ex.Message}");
            }
            catch (GeminiApiException ex)
            {
                ShowError($"An error occurred: \n{ex.Message}");
            }
            finally
            {
                SetControlState(true);
            }
        }

        private void BtnResetGrid_Click(object sender, EventArgs e)
        {
            _originalDataTable = DataSource.GetRows(_sqlQuery);
            flexGrid.DataSource = _originalDataTable;
        }

        private void BtnManageApiKey_Click(object sender, EventArgs e)
        {
            using (var overlay = new Form())
            {
                // Configure the dimmed overlay
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.ShowInTaskbar = false;
                overlay.BackColor = Color.Black;
                overlay.Opacity = 0.3;
                overlay.Size = this.ClientSize;
                overlay.Location = this.PointToScreen(this.ClientRectangle.Location);
                overlay.Owner = this;

                // Show the overlay
                overlay.Show();

                // Show the API key entry dialog on top of the overlay
                using (var promptDialog = new FormApiKeyEntry())
                {
                    promptDialog.StartPosition = FormStartPosition.CenterParent;
                    promptDialog.ShowInTaskbar = false;
                    promptDialog.ShowDialog(overlay);
                }
            }
        }

        private void BtnClearText_Click(object sender, EventArgs e)
        {
            customTxtBoxSendPrompt.InputText = string.Empty;
            txtBoxGetResponse.Text = string.Empty;
            txtBoxGetResponse.Styles.Disabled.ForeColor = Color.FromArgb(98, 99, 100);
        }

        private void ShowError(string message)
        {
            txtBoxGetResponse.Text = message;
        }

        #endregion

    }
}
