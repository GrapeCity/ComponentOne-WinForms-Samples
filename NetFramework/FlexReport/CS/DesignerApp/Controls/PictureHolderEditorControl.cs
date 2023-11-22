//----------------------------------------------------------------------------
// PictureHolderEditorControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1Input;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Controls
{
    internal partial class PictureHolderEditorControl : UserControl
    {
        private C1FlexReport _report;
        private FlexDesignerHostServices _services;
        private object _propOwner;
        private string _propName;
        private PictureHolder _pictureHolder;
        private bool _canExpression;
        private bool _canEditScript;

        private string _filePath;
        private string _urlPath;
        private Image _fileImage;
        private Image _urlImage;

        private bool _updating;
        private IAsyncResult _async;
        private readonly object _lock = new object();

        public PictureHolderEditorControl()
        {
            InitializeComponent();
            AdjustLayout();

            radioNone.CheckedChanged += OnImageSourceChecked;
            radioFile.CheckedChanged += OnImageSourceChecked;
            radioURL.CheckedChanged += OnImageSourceChecked;
            radioExpression.CheckedChanged += OnImageSourceChecked;
            txtFile.Validating += OnEditorValueChanged;
            txtURL.Validating += OnEditorValueChanged;
            cmbExpression.Validating += OnEditorValueChanged;
        }

        private void AdjustLayout()
        {
            var top = grpFile.Top;
            grpExpression.Top = top;
            grpURL.Top = top;

            var height = grpFile.Bottom + 5;
            Height = height;

            MinimumSize = Size;
        }

        public void Init(FlexDesignerHostServices services, object propOwner, string propName, object value, bool supportExpression)
        {
            _propOwner = propOwner;
            _propName = propName;
            _pictureHolder = value as PictureHolder ?? PictureHolder.FromObject(null, null);
            _services = services;
            if (_services != null)
            {
                var grs = _services.GetService(typeof (IGetReportsService)) as IGetReportsService;
                if (grs != null) _report = grs.Report;
            }

            _canExpression = supportExpression && _report != null;
            if (_services != null)
            {
                var scriptService = _services.GetScriptEditorService();
                _canEditScript = _canExpression && scriptService != null;
            }
            else
            {
                _canEditScript = false;
            }
            UpdateUI();
        }

        internal void UpdateTabStop()
        {
            if (!radioFile.Checked && !radioURL.Checked && !radioExpression.Checked)
            {
                radioFile.TabStop = true;
            }
        }

        public PictureHolder Value
        {
            get { return _pictureHolder; }
        }

        private void UpdateUI()
        {
            _updating = true;

            if (_canEditScript)
            {
                cmbExpression.Init(_services, _report.DataSourceName, GetSciptName());
            }
            else
            {
                cmbExpression.VisibleButtons = DropDownControlButtonFlags.None;
            }

            if (!_canExpression)
                radioExpression.Visible = false;

            switch (_pictureHolder.Type)
            {
                case PictureHolderType.Empty:
                    radioNone.Checked = true;
                    break;
                case PictureHolderType.File:
                    radioFile.Checked = true;
                    grpFile.Visible = true;
                    txtFile.Value = _pictureHolder.ToString();
                    break;
                case PictureHolderType.Url:
                    radioURL.Checked = true;
                    grpURL.Visible = true;
                    txtURL.Value = _pictureHolder.ToString();
                    break;
                case PictureHolderType.Expression:
                    if (_canExpression)
                    {
                        radioExpression.Checked = true;
                        grpExpression.Visible = true;
                        cmbExpression.Expression = _pictureHolder.ToString();
                    }
                    break;
            }

            _updating = false;
            UpdatePreview();
        }

        public void ApplyChanges()
        {
            if (radioNone.Checked)
            {
                _pictureHolder = PictureHolder.FromObject(null, null);
            }
            else if (radioFile.Checked)
            {
                _pictureHolder = PictureHolder.FromFile(txtFile.Text, C1FlexReport.GetActualBasePath(_report));
            }
            else if (radioURL.Checked)
            {
                _pictureHolder = PictureHolder.FromUrl(txtURL.Text, C1FlexReport.GetActualBasePath(_report));
            }
            else if (radioExpression.Checked)
            {
                _pictureHolder = PictureHolder.FromExpression(cmbExpression.Expression);
            }
        }

        private void UpdateImageSource()
        {
            grpFile.Visible = radioFile.Checked;
            grpURL.Visible = radioURL.Checked;
            grpExpression.Visible = radioExpression.Checked;
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            if (_updating) return;

            lock (_lock)
            {
                if (_async != null && _async.AsyncWaitHandle != null)
                {
                    _async.AsyncWaitHandle.Close();
                    _async = null;
                }

                if (radioFile.Checked)
                {
                    PreviewFile();
                }
                else if (radioURL.Checked)
                {
                    PreviewURL();
                }
                else if (radioExpression.Checked)
                {
                    picPreview.Image = null;
                }
                else if (radioNone.Checked)
                {
                    picPreview.Image = null;
                }
                else
                {
                    if (_pictureHolder != null)
                        picPreview.Image = _pictureHolder.Image;
                }
            }
        }

        private void PreviewFile()
        {
            var file = txtFile.Text;
            if (_filePath == file)
            {
                picPreview.Image = _fileImage;
                return;
            }

            _filePath = file;
            picPreview.Image = null;
            if (_fileImage != null)
            {
                _fileImage.Dispose();
                _fileImage = null;
            }

            if (File.Exists(file))
            {
                try
                {
                    var image = Image.FromFile(file);
                    _fileImage = image;
                    picPreview.Image = _fileImage;
                }
                catch
                {
                }
            }
        }

        private void PreviewURL()
        {
            var url = txtURL.Text;
            if (url == _urlPath)
            {
                picPreview.Image = _urlImage;
                return;
            }

            _urlPath = url;
            picPreview.Image = null;
            if (_urlImage != null)
            {
                _urlImage.Dispose();
                _urlImage = null;
            }

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    var request = WebRequest.Create(url);
                    _async = request.BeginGetResponse(RequestComplete, request);
                }
                catch
                {
                }
            }
        }

        private void RequestComplete(IAsyncResult asyncResult)
        {
            if (IsDisposed) return;

            lock (_lock)
            {
                if (_async != asyncResult) return;

                var request = (WebRequest) asyncResult.AsyncState;
                try
                {
                    using (var response = request.EndGetResponse(asyncResult))
                    using (var stream = response.GetResponseStream())
                    {
                        if (stream == null) return;

                        var image = Image.FromStream(stream);
                        _urlImage = image;
                        picPreview.Image = _urlImage;
                    }
                }
                catch
                {
                }
            }
        }

        private void OnImageSourceChecked(object sender, EventArgs e)
        {
            if (_updating) return;
            var radio = sender as RadioButton;
            if (radio != null && radio.Checked)
                UpdateImageSource();
        }

        private void OnEditorValueChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            UpdatePreview();
        }

        private void c1DropDownControl1_ModalButtonClick(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = Strings.MainForm.OpenImageFilter;
                dlg.FilterIndex = 0;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = dlg.FileName;
                }
            }

            UpdatePreview();
        }

        private string GetSciptName()
        {
            var field = _propOwner as FieldBase;
            if (field != null)
                return field.Name + "." + _propName;
            else
                return _propName;
        }
    }
}
