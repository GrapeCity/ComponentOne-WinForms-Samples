using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace SeparateEffects
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void evaluateCheckBoxes()
		{
			VisualEffectsStyleCollection vesc = c1Chart1.VisualEffects.Styles;
			checkDefaultEffects.Checked = vesc["Default"].Enabled;
			checkGroup0Effects.Checked = vesc["Group0"].Enabled;
			checkGroup1Effects.Checked = vesc["Group1"].Enabled;
		}

		private void CheckBoxEffects_Changed(object sender, EventArgs e)
		{
			CheckBox cb = sender as CheckBox;
			VisualEffectsStyleCollection vesc = c1Chart1.VisualEffects.Styles;
			if(cb.Text.Contains("Default"))
				vesc["Default"].Enabled = cb.Checked;
			else if(cb.Text.Contains("Group0"))
				vesc["Group0"].Enabled = cb.Checked;
			else if(cb.Text.Contains("Group1"))
				vesc["Group1"].Enabled = cb.Checked;
		}

		private void btnVisualEffectsEditor_Click(object sender, EventArgs e)
		{
			c1Chart1.ShowVisualEffectsEditor();
			evaluateCheckBoxes();
		}

		private void btnClearEffects_Click(object sender, EventArgs e)
		{
			VisualEffectsStyleCollection vesc = c1Chart1.VisualEffects.Styles;
			vesc["Default"].Enabled = false;
			vesc["Group0"].Enabled = false;
			vesc["Group1"].Enabled = false;
			evaluateCheckBoxes();
		}
	}
}
