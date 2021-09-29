using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace InputExplorer.Samples
{
    using InputExplorer.Data;
    using C1.Win.Input;
    using C1.Win.Input.Base;

    public partial class DataCreating : UserControl
    {
        #region "Properties"

        private string _base64Image = "";
        private Dictionary<string, string> _errors = new Dictionary<string, string>();
        private BindingSource _data = new BindingSource();
        private int _Id = 0;

        #endregion
        public DataCreating()
        {
            InitializeComponent();
        }

        private List<IInputEditor> GetTextBoxControls(TableLayoutPanel sourcePanel)
        {
            var result = new List<IInputEditor>();

            foreach (var item in editFormPanel.Controls)
            {
                if (item is not IInputEditor control) continue;
                    result.Add(control);
            }

            return result;
        }

        private void InitializeProperties()
        {
            var table = DataSource.GetRows("Select * from Employees limit 1", "Employees");
            _data.DataSource = table;
            var _currentRow = _data.AddNew();
            var columns = (from s in table.Columns.Cast<DataColumn>() select s)
                .Select(x => x.ColumnName).ToList();
            var refs = new List<string>() { "Country" };

            var controls = GetTextBoxControls(editFormPanel);
            controls.ForEach(x =>
            {
                var textBox = x as C1TextBoxBase;
                if (textBox.Enabled && !textBox.ReadOnly)
                {
                    // Add data source
                    textBox.DataSource = _data;
                    var dataMember = columns.Where(y => y.IndexOf(textBox.Name, StringComparison.InvariantCultureIgnoreCase) >= 0)
                        .FirstOrDefault();
                    textBox.DataMember = dataMember;

                    // Add clear button
                    textBox.ButtonsSettings.ModalButton.Image = InputExplorer.Properties.Resources.delete;
                    textBox.ButtonsSettings.ModalButton.Visible = true;

                    // Add event
                    textBox.ModalButtonClick += textBox_Clear;
                    textBox.MouseMove += textBox_MouseMove;

                    if (refs.Any(y => y.IndexOf(textBox.Name, StringComparison.InvariantCultureIgnoreCase) >= 0))
                    {
                        // Add button for select from directory
                        textBox.ButtonsSettings.DropDownButton.Image = InputExplorer.Properties.Resources.search;
                        textBox.ButtonsSettings.DropDownButton.Visible = true;
                        textBox.DropDownButtonClick += textBox_OpenReference;
                    }

                    // Add validation
                    textBox.ErrorInfo.BeepOnError = true;
                    textBox.ErrorInfo.ShowErrorMessage = false;
                    textBox.ValidationError += textBox_ValidationError;
                    textBox.PreValidating += textBox_PreValidating;
                    textBox.PreValidated += textBox_PreValidated;
                }
            });

            // Set special border color
            var gcColor = Color.FromArgb(102, 102, 153);
            errorInfo.Styles.Default.BorderColor = gcColor;
            errorInfo.Styles.Hot.BorderColor = gcColor;
            errorInfo.Styles.Focused.BorderColor = gcColor;

            // Set custom format
            BirthDate.DisplayFormat.CustomFormat = "MM/dd/yyyy";
            BirthDate.DisplayFormat.FormatType = FormatType.CustomFormat;

            BirthDate.EditFormat.CustomFormat = "MM/dd/yyyy";
            BirthDate.EditFormat.FormatType = FormatType.CustomFormat;
        }

        private void ShowErrors()
        {
            errorInfo.Text = "";
            if(_errors.Any())
            {
                var list = _errors.Keys.OrderBy(x => x)
                    .Select(x => string.Format("{0}: {1}", x, _errors[x]));
                errorInfo.Text = string.Join(Environment.NewLine, list.ToArray());
            }

            // Set red frame for C1TextBox
            var controls = GetTextBoxControls(editFormPanel);
            controls.ForEach(x =>
            {
                var textBox = x as C1TextBoxBase;
                if (textBox != null)
                {
                    if (textBox.Enabled && !textBox.ReadOnly)
                    {
                        var styles = x.GetStyles();
                        styles.Reset();

                        // Set color of frame
                        var IsError = _errors.Keys.Any(y => y == textBox.Name);
                        if (IsError)
                        {
                            var textBoxStyles = styles as C1.Win.Input.Styles.TextBoxStyles;
                            textBoxStyles.Default.BorderColor = Color.Red;
                            textBoxStyles.Focused.BorderColor = Color.Red;
                            textBoxStyles.Hot.BorderColor = Color.Red;
                        }
                    }
                }
            });
        }

        private bool SaveRecord()
        {
            var insertSql = string.Format(
                "Insert into Employees(FirstName, LastName, HomePhone, BirthDate, Extension, Photo, Country) Values ('{0}','{1}','{2}','{3}',{4},'{5}','{6}')",
                FirstName.Value, LastName.Value, PhoneNumber.Value, ((DateTime)BirthDate.Value).ToString("s"), Extension.Value, _base64Image, Country.Value);

            var updateSql = string.Format(
                "Update Employees Set FirstName ='{0}', LastName = '{1}', HomePhone = '{2}', BirthDate = '{3}', Extension = {4}, Photo = '{5}', Country = '{6}' where EmployeeID = {7}",
                FirstName.Value, LastName.Value, PhoneNumber.Value, ((DateTime)BirthDate.Value).ToString("s"), Extension.Value, _base64Image, Country.Value, _Id);

            var sql = (_Id > 0 ? updateSql : insertSql);
            try
            {
                var result = DataSource.SaveRow(sql);
                if(result && _Id == 0)
                {
                    // Getting the unique key
                    sql = "Select * from Employees order by EmployeeID desc Limit 1";
                    var table = DataSource.GetRows(sql);
                    if (table.Rows.Count > 0)
                        _Id = Convert.ToInt32(table.Rows[0]["EmployeeID"]);
                    else
                        // Failure for read data
                        return false;
                }
                return result;
            }
            catch (Exception ex)
            {
                _errors.Add("Database", ex.Message + ex.InnerException?.Message);
                ShowErrors();
            }

            return false;
        }

        private void CheckErrors()
        {
            // For each the control raised event for check error
            var controls = GetTextBoxControls(editFormPanel);
            controls.Cast<C1TextBoxBase>().ToList()
                .ForEach(x => x.UpdateValueWithCurrentText());
        }

        private void CheckErrorItem(object sender, C1.Win.Input.Validation.ErrorInfo errorInfo)
        {
            var error = errorInfo.ErrorMessage;
            var IsYesError = !string.IsNullOrEmpty(error);
            if (sender is not Control control) return;

            var key = control.Name;
            if (IsYesError)
            {
                if (_errors.ContainsKey(key))
                    _errors[key] = error;
                else
                    _errors.Add(key, error);
            }

            if (!IsYesError && _errors.ContainsKey(key))
                _errors.Remove(key);

            ShowErrors();
        }

        #region "TextBox events"
        private void textBox_PreValidated(object sender, PreValidationEventArgs e)
        {
            CheckErrorItem(sender, e.ErrorInfo);
        }

        private void textBox_PreValidating(object sender, PreValidationEventArgs e)
        {
            // Setting mannual errors 
            if (sender is not C1NumericEdit numericBox) return;

            var error = e.ErrorInfo.ErrorMessage;
            var IsYesError = !string.IsNullOrEmpty(error);

            var value = Convert.ToDecimal(e.Text);
            if (value < 0)
                e.ErrorInfo.ErrorMessage = "The value must be positive!";

             if (value > 500)
                e.ErrorInfo.ErrorMessage = "The value must be less than 500!";

            // Clear error
            if (IsYesError && _errors.ContainsKey(numericBox.Name))
                _errors.Remove(numericBox.Name);
        }

        private void textBox_OpenReference(object sender, EventArgs e)
        {
            if (sender is not C1TextBox textBox) return;

            var table = DataSource.GetRows("Select * from Countries order by CountryName");
            var dialog = new SelectDialog(table, "CountryID","CountryName");
            if (dialog.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                textBox.Value = dialog.Value;
                textBox.UpdateValueWithCurrentText();
            }
        }

        private void textBox_Clear(object sender, EventArgs e)
        {
            if (sender is not Control control) return;

            var key = control.Name;
            if (_errors.ContainsKey(key))
                _errors.Remove(key);

            control.Text = "";
            ShowErrors();
        }

        private void textBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is not C1.Framework.IView control) return;
            

            var innerControl = control.HitTest();
            if (innerControl is null) return;

            if (innerControl is not C1.Framework.ButtonElement) return;

            if (sender is not C1.Win.Input.C1TextBox sourceControl) return;
            sourceControl.Cursor = Cursors.Hand;
        }

        private void textBox_ValidationError(object sender, C1.Win.Input.ValidationErrorEventArgs e)
        {
            CheckErrorItem(sender, e.ErrorInfo);
        }

        #endregion

        private void DataCreating_Load(object sender, EventArgs e)
        {
            var image = InputExplorer.Properties.Resources.GcLogo;
            picturePhoto.Image = image;
            _base64Image = DataSource.ImageToBase64(image, false);

            image = InputExplorer.Properties.Resources.ok;
            pictureSuccess.Image = image;

            InitializeProperties();
        }

        private void LoadImage()
        {
            if (openFileDialog1.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                if (!File.Exists(fileName)) return;

                var image = Image.FromFile(fileName);
                _base64Image = DataSource.ImageToBase64(image, false);
                picturePhoto.Image = image;
            }
        }

        private void lnkSelectFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            CheckErrors();
            if (_errors.Any())
            {
                ShowErrors();
                return;
            }

            if (SaveRecord())
            {
                // Show success
                pictureSuccess.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureSuccess.Visible = false;
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _errors.Clear();
            _Id = 0;

            GetTextBoxControls(editFormPanel).Cast<Control>()
                .ToList().ForEach(x => x.Text = "");
            
            ShowErrors();
        }

        private void Extension_UpDownButtonClick(object sender, UpDownButtonClickEventArgs e)
        {
            if (sender is not C1NumericEdit numericBox) return;
            if (numericBox.Value is null)
                numericBox.Value = e.Delta;

        }
    }
}

