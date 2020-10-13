using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using System.IO;

namespace ControlExplorer.Editor
{
    public partial class RTFEditor : C1DemoForm
    {
        public RTFEditor()
        {
            InitializeComponent();
            AddProperty("Mode", c1Editor1);
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            //Save RTF file on the button click event
            saveFileDialog1.ShowDialog();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
           //Load a prespecified RTF file on button click in the Editor control 
           //c1Editor1.LoadRtf(@"..\..\Resources\Rich_Text_Format.rtf");
            c1Editor1.LoadRtf(File.Open(AppDomain.CurrentDomain.BaseDirectory + "Resources\\Rich_Text_Format.rtf", FileMode.Open), null);
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            //Set the editor mode to Design View
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design;
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            //Set the editor mode to Source/HTML view
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source;
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            //Set the editor mode to Preview
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview;
        }

        private void ribbonButton6_Click_1(object sender, EventArgs e)
        {
            //Load a different RTF file in the editor control
            //c1Editor1.LoadRtf(@"..\..\Resources\test.rtf");
            c1Editor1.LoadRtf(File.Open(AppDomain.CurrentDomain.BaseDirectory + "Resources\\test.rtf", FileMode.Open), null);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            c1Editor1.SaveRtf(saveFileDialog1.FileName);
        }
    }
}
