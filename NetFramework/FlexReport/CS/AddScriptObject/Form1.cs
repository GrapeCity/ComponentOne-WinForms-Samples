using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddScriptObject
{
    public partial class Form1 : Form
    {
        private MathHelper _mathHelper = new MathHelper();

        public Form1()
        {
            InitializeComponent();

            c1FlexReport1.GetScriptObject += c1FlexReport1_GetScriptObject;
        }

        void c1FlexReport1_GetScriptObject(object sender, C1.Report.ReportGetScriptObjectEventArgs e)
        {
            // FlexReport's VBScript is case-insensitive
            switch (e.Name.ToLower())
            {
                case "externalcontrol":
                    e.Object = this.textBox1;
                    break;
                case "mathhelper":
                    e.Object = _mathHelper;
                    break;
                default:
                    e.Object = null;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1FlexViewerDialog1.DocumentSource = null;
            c1FlexReport1.Render();
            c1FlexViewerDialog1.DocumentSource = c1FlexReport1;
            c1FlexViewerDialog1.ShowDialog();
        }
    }

    public class MathHelper
    {
        public int Factorial(double value)
        {
            return (value > 1)
                ? (int)(value * Factorial(value - 1))
                : 1;
        }
    }
}
