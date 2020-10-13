using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Input.DropDowns
{
    public partial class ImageMapping : C1.Win.C1Input.DropDownForm
    {
        Hashtable ht;
        public ImageMapping()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bm = new Bitmap(img);
            Color c = bm.GetPixel(e.X, e.Y);
            if(ht.ContainsKey(c))
            {
                OwnerControl.Value = ht[c].ToString();
                CloseDropDown();
            }
            else
            {
                OwnerControl.Value = "None Selected";
            }
        }

        private void ImageMapping_Load(object sender, EventArgs e)
        {
            ht = new Hashtable();
            ht.Add(Color.FromArgb(255, 105, 180), "Portugal");
            ht.Add(Color.FromArgb(255, 140, 0), "UK");
            ht.Add(Color.FromArgb(65, 105, 225), "Spain");
            ht.Add(Color.FromArgb(144, 238, 144), "France");
            ht.Add(Color.FromArgb(178, 34, 34), "Italy");
            ht.Add(Color.FromArgb(0, 191, 255), "Iceland");
            ht.Add(Color.FromArgb(0, 0, 205), "Ireland");
            ht.Add(Color.FromArgb(240, 230, 140), "Germany");
            ht.Add(Color.FromArgb(255, 0, 255), "Belgium");
            ht.Add(Color.FromArgb(46, 139, 87), "Netherlands");
            ht.Add(Color.FromArgb(255, 255, 240), "Luxembourg");
            ht.Add(Color.FromArgb(70, 130, 180), "Switzerland");
            ht.Add(Color.FromArgb(160, 82, 45), "Austria");
            ht.Add(Color.FromArgb(175, 238, 238), "Czech-Republic");
            ht.Add(Color.FromArgb(0, 255, 0), "Denmark");
            ht.Add(Color.FromArgb(119, 136, 153), "Poland");
            ht.Add(Color.FromArgb(0, 100, 0), "Slovenia");
            ht.Add(Color.FromArgb(0, 0, 128), "Croatia");
            ht.Add(Color.FromArgb(153, 50, 204), "Hungary");
            ht.Add(Color.FromArgb(199, 21, 133), "Bosnia and Herzegovina");
            ht.Add(Color.FromArgb(255, 250, 205), "Serbia");
            ht.Add(Color.FromArgb(100, 149, 237), "Albania");
            ht.Add(Color.FromArgb(255, 215, 0), "Greece");
            ht.Add(Color.FromArgb(165, 42, 42), "Macedonia");
            ht.Add(Color.FromArgb(220, 20, 60), "Bulgaria");
            ht.Add(Color.FromArgb(210, 180, 140), "Romania");
            ht.Add(Color.FromArgb(143, 188, 139), "Slovakia");
            ht.Add(Color.FromArgb(255, 165, 0), "Russia");
            ht.Add(Color.FromArgb(107, 142, 35), "Lithuania");
            ht.Add(Color.FromArgb(255, 182, 193), "Latvia");
            ht.Add(Color.FromArgb(230, 230, 250), "Estonia");
            ht.Add(Color.FromArgb(0, 255, 255), "Norway");
            ht.Add(Color.FromArgb(255, 20, 147), "Sweden");
            ht.Add(Color.FromArgb(238, 130, 238), "Finland");
            ht.Add(Color.FromArgb(154, 205, 50), "Belarus");
            ht.Add(Color.FromArgb(253, 245, 230), "Moldova");
            ht.Add(Color.FromArgb(30, 144, 255), "Ukraine");
            ht.Add(Color.FromArgb(0, 0, 255), "Canada");
            ht.Add(Color.FromArgb(255, 0, 0), "USA");
        }
    }
}
