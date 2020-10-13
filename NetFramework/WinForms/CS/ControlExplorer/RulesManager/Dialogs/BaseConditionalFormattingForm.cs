using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.RulesManager.Dialogs
{
    public partial class BaseConditionalFormattingForm : Form
    {
        public BaseConditionalFormattingForm()
        {
            InitializeComponent();
        }

        [DefaultValue("Operation:")]
        public string ConditionalOperationText
        {
            get
            {
                return lblOperationText?.Text;
            }
            set
            {
                var operationText = lblOperationText;
                if (operationText != null)
                {
                    operationText.Text = value;
                }
            }
        }

        [DefaultValue(null)]
        public Control EditorRowControl
        {
            get
            {
                return tlpMainLayout?.GetControlFromPosition(0, 1);
            }
            set
            {
                var mainLayout = tlpMainLayout;
                if (mainLayout == null)
                {
                    return;
                }

                var control = mainLayout.GetControlFromPosition(0, 1);
                if (control != null)
                {
                    if (control != value)
                    {
                        mainLayout.Controls.Remove(control);
                    }
                    else
                    {
                        return;
                    }
                }

                mainLayout.Controls.Add(value, 0, 1);
            }
        }

        private void BaseConditionalFormattingForm_Load(object sender, EventArgs e)
        {
            Explorer.ApplyTheme(this);
        }
    }
}
