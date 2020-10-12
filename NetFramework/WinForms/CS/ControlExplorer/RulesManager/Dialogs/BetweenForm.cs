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
    public partial class BetweenForm : BaseConditionalFormattingForm
    {
        public BetweenForm()
        {
            InitializeComponent();
        }

        private void BetweenForm_Load(object sender, EventArgs e)
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
        public string MinimumValue
        {
            get
            {
                var textMinimumValue = tbMinimumValue?.Text;
                if (textMinimumValue != null)
                {
                    return textMinimumValue;
                }

                return string.Empty;
            }
        }

        [Browsable(false)]
        public string MaximumValue
        {
            get
            {
                var textMaximumValue = tbMaximumValue?.Text;
                if (textMaximumValue != null)
                {
                    return textMaximumValue;
                }

                return string.Empty;
            }
        }
    }
}
