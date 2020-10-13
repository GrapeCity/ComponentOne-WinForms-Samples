using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ODataRecordset
{
    public partial class ODataRecordsetForm : Form
    {
        private ODataRecordset _recordset = new ODataRecordset();

        public ODataRecordsetForm()
        {
            InitializeComponent();
        }

        public bool Edit(ODataRecordset recordset)
        {
            ActiveControl = tbService;
            _recordset.ServiceUri = recordset.ServiceUri;
            cbEntitySet.Text = recordset.EntitySetName;
            if (recordset.ServiceUri != null)
            {
                tbService.Text = recordset.ServiceUri.ToString();
                try
                {
                    var entitisets = recordset.GetEntitySets();
                    foreach (var entityset in entitisets)
                        cbEntitySet.Items.Add(entityset.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format("Could not get list of entity sets from service, error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bool result = ShowDialog() == DialogResult.OK;
            if (result)
            {
                recordset.ServiceUri = new Uri(tbService.Text, UriKind.Absolute);
                recordset.EntitySetName = cbEntitySet.Text;
            }
            return result;
        }

        private void cbEntitySet_Enter(object sender, EventArgs e)
        {
            Uri uri;
            if (!Uri.TryCreate(tbService.Text, UriKind.Absolute, out uri))
            {
                ActiveControl = tbService;
                MessageBox.Show(this, string.Format("Invalid URL:\r\n{0}", tbService.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _recordset.ServiceUri = uri;
            try
            {
                var entities = _recordset.GetEntitySets();
                cbEntitySet.Items.Clear();
                foreach (var entity in entities)
                    cbEntitySet.Items.Add(entity.Name);
            }
            catch (Exception ex)
            {
                ActiveControl = tbService;
                MessageBox.Show(this, string.Format("Could not get list of entity sets from service, error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbEntitySet.Text))
            {
                ActiveControl = cbEntitySet;
                MessageBox.Show(this, "Name of entityset is not specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _recordset.ServiceUri = new Uri(tbService.Text);
            try
            {
                var entities = _recordset.GetEntitySets();
                var entitySet = entities.FirstOrDefault((item_) => { return string.Compare(item_.Name, cbEntitySet.Text, true) == 0; });
                if (entitySet == null)
                {
                    ActiveControl = cbEntitySet;
                    MessageBox.Show(this, string.Format("[{0}] entity set is not found.", cbEntitySet.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                ActiveControl = tbService;
                MessageBox.Show(this, string.Format("Could not get list of entity sets from service, error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
