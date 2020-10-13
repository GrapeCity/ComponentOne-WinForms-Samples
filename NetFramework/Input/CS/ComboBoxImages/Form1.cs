using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void AddItem(string item, string image)
        {
            imageList2.Images.Add(item, Image.FromFile(image));
            c1ComboBox2.Items.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1ComboBox2.ItemsImageList = imageList2;
            AddItem("Circle", "shape_circle.png");
            AddItem("Square", "shape_square.png");
            AddItem("Triangle", "shape_triangle.png");
            c1ComboBox2.SelectedIndex = 0;
        }
    }
}
