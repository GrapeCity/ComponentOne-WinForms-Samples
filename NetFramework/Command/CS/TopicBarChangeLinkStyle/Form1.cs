using System;
using System.Drawing;
using System.Windows.Forms;

namespace TopicBarChangeLinkStyle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.ExpandAll();
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // first page has normal state, second page has special state
            SetPageStyleInfo();
            SetStyleValue();
        }

        private void SetStyleValue()
        {
            var pageStyle = comboBox1.SelectedIndex == 0 ? c1TopicBar1.LinkStyle.NormalPage :
                c1TopicBar1.LinkStyle.SpecialPage;

            c1fpNormal.Value = pageStyle.NormalLink.Font;
            c1cpNormal.Value = pageStyle.NormalLink.ForeColor;

            c1fpMouseOver.Value = pageStyle.MouseOverLink.Font;
            c1cpMouseOver.Value = pageStyle.MouseOverLink.ForeColor;

            c1fpPressed.Value = pageStyle.PressedLink.Font;
            c1cpPressed.Value = pageStyle.PressedLink.ForeColor;

            c1fpDisabled.Value = pageStyle.DisabledLink.Font;
            c1cpDisabled.Value = pageStyle.DisabledLink.ForeColor;
        }
        
        private void SetPageStyleInfo()
        {
            var pageStyle = comboBox1.SelectedIndex == 0 ? c1TopicBar1.LinkStyle.NormalPage:
                c1TopicBar1.LinkStyle.SpecialPage;

            treeView1.Nodes[0].Nodes[0].Text = pageStyle.NormalLink.Font.ToString();
            treeView1.Nodes[0].Nodes[1].Text = pageStyle.NormalLink.ForeColor.ToString();
            
            treeView1.Nodes[1].Nodes[0].Text = pageStyle.MouseOverLink.Font.ToString();
            treeView1.Nodes[1].Nodes[1].Text = pageStyle.MouseOverLink.ForeColor.ToString();
            
            treeView1.Nodes[2].Nodes[0].Text = pageStyle.PressedLink.Font.ToString();
            treeView1.Nodes[2].Nodes[1].Text = pageStyle.PressedLink.ForeColor.ToString();
            
            treeView1.Nodes[3].Nodes[0].Text = pageStyle.DisabledLink.Font.ToString();
            treeView1.Nodes[3].Nodes[1].Text = pageStyle.DisabledLink.ForeColor.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1TopicBar1.VisualStyle = C1.Win.Command.VisualStyle.Office2007Blue;
            SetPageStyleInfo();
            SetStyleValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1TopicBar1.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            SetPageStyleInfo();
            SetStyleValue();
        }

        private void c1cpNormal_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                c1TopicBar1.LinkStyle.NormalPage.NormalLink.ForeColor = (Color)c1cpNormal.Value;
            else
                c1TopicBar1.LinkStyle.SpecialPage.NormalLink.ForeColor = (Color)c1cpNormal.Value;
        }

        private void c1cpMouseOver_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                c1TopicBar1.LinkStyle.NormalPage.MouseOverLink.ForeColor = (Color)c1cpMouseOver.Value;
            else
                c1TopicBar1.LinkStyle.SpecialPage.MouseOverLink.ForeColor = (Color)c1cpMouseOver.Value;
        }

        private void c1cpPressed_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                c1TopicBar1.LinkStyle.NormalPage.PressedLink.ForeColor = (Color)c1cpPressed.Value;
            else
                c1TopicBar1.LinkStyle.SpecialPage.PressedLink.ForeColor = (Color)c1cpPressed.Value;
        }

        private void c1cpDisabled_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                c1TopicBar1.LinkStyle.NormalPage.DisabledLink.ForeColor = (Color)c1cpDisabled.Value;
            else
                c1TopicBar1.LinkStyle.SpecialPage.DisabledLink.ForeColor = (Color)c1cpDisabled.Value;
        }

        private void c1fpNormal_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var font = c1TopicBar1.LinkStyle.NormalPage.NormalLink.Font;
                c1TopicBar1.LinkStyle.NormalPage.NormalLink.Font = new Font(c1fpNormal.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
            else
            {
                var font = c1TopicBar1.LinkStyle.SpecialPage.NormalLink.Font;
                c1TopicBar1.LinkStyle.SpecialPage.NormalLink.Font = new Font(c1fpNormal.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
        }

        private void c1fpMouseOver_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var font = c1TopicBar1.LinkStyle.NormalPage.MouseOverLink.Font;
                c1TopicBar1.LinkStyle.NormalPage.MouseOverLink.Font = new Font(c1fpMouseOver.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
            else
            {
                var font = c1TopicBar1.LinkStyle.SpecialPage.MouseOverLink.Font;
                c1TopicBar1.LinkStyle.SpecialPage.MouseOverLink.Font = new Font(c1fpMouseOver.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
        }

        private void c1fpPressed_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var font = c1TopicBar1.LinkStyle.NormalPage.PressedLink.Font;
                c1TopicBar1.LinkStyle.NormalPage.PressedLink.Font = new Font(c1fpPressed.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
            else
            {
                var font = c1TopicBar1.LinkStyle.SpecialPage.PressedLink.Font;
                c1TopicBar1.LinkStyle.SpecialPage.PressedLink.Font = new Font(c1fpPressed.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
        }

        private void c1fpDisabled_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var font = c1TopicBar1.LinkStyle.NormalPage.DisabledLink.Font;
                c1TopicBar1.LinkStyle.NormalPage.DisabledLink.Font = new Font(c1fpDisabled.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
            else
            {
                var font = c1TopicBar1.LinkStyle.SpecialPage.DisabledLink.Font;
                c1TopicBar1.LinkStyle.SpecialPage.DisabledLink.Font = new Font(c1fpDisabled.Value.ToString(), font.SizeInPoints, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
            }
        }

        private void c1TopicBar1_LinkStyleChanged(object sender, EventArgs e)
        {
            SetPageStyleInfo();
        }
    }
}
