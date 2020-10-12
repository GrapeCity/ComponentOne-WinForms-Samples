using ControlExplorer.RulesManager.Presets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.RulesManager.Dialogs
{
    public partial class SingleValueConditionalFormattingForm : BaseConditionalFormattingForm
    {
        public SingleValueConditionalFormattingForm()
        {
            InitializeComponent();
        }

        private void SingleValueConditionalFormattingForm_Load(object sender, EventArgs e)
        {
            cmbStylePreset.SelectedIndex = 0;
        }

        [Browsable(false)]
        public Highlight SelectedStylePreset
        {
            get
            {
                var selectedStylePresetText = cmbStylePreset.Text;
                var stylePresets = Enum.GetValues(typeof(Highlight)).Cast<Highlight>().ToList();

                return stylePresets.First(stylePreset => stylePreset.ToString().ToLower() == selectedStylePresetText.ToLower().Replace(" ", ""));
            }
        }

        [Browsable(false)]
        public string Value
        {
            get
            {
                var textValue = tbValue?.Text;
                if (textValue != null)
                {
                    return textValue;
                }

                return string.Empty;
            }
        }
    }
}
