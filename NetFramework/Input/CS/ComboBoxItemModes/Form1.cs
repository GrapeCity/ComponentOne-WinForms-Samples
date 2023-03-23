using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxItemModes
{
    public partial class Form1 : Form
    {

        class Place
        {
            public string Box { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var places = new List<Place>();
            places.Add(new Place { Box = "Studio 103", Address = "61 Wellfield Road", City = "Cardiff", Country = "England"});
            places.Add(new Place { Box = "Unit 14", Address = "George Street", City = "Kirov", Country = "Russia" });
            places.Add(new Place { Box = "Office 304", Address = "Some Road", City = "Little Rock", Country = "USA" });
            places.Add(new Place { Box = "Apartment 1", Address = "Main street", City = "Mexico", Country = "Brazil" });
            places.Add(new Place { Box = "Studio 103", Address = "61 Wellfield Road", City = "Cardiff", Country = "England" });
            places.Add(new Place { Box = "Unit 14", Address = "George Street", City = "Kirov", Country = "Russia" });
            places.Add(new Place { Box = "Office 304", Address = "Some Road", City = "Little Rock", Country = "USA" });
            places.Add(new Place { Box = "Apartment 1", Address = "Main street", City = "Mexico", Country = "Brazil" });
            places.Add(new Place { Box = "Studio 103", Address = "61 Wellfield Road", City = "Cardiff", Country = "England" });
            places.Add(new Place { Box = "Unit 14", Address = "George Street", City = "Kirov", Country = "Russia" });
            places.Add(new Place { Box = "Office 304", Address = "Some Road", City = "Little Rock", Country = "USA" });
            places.Add(new Place { Box = "Apartment 1", Address = "Main street", City = "Mexico", Country = "Brazil" });
            c1ComboBox4.ItemsDataSource = places;
//            c1ComboBox4.DropDownForm.Width = 600;
        }
    }
}
