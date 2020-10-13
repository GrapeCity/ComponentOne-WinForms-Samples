using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<DataItem> _dataItemList = new List<DataItem>();
        private List<string> _htmlPatternList = new List<string>();


        public Form1()
        {
            InitializeComponent();

            // create images 150x150 px size
            CreateBitmap("red.png", Color.Red);
            CreateBitmap("green.png", Color.Green);
            CreateBitmap("blue.png", Color.Blue);

            // add items data
            AddDataItem("Red square", "Some description text", "red", "red.png");
            AddDataItem("Green square", "Description for green square", "green", "green.png");
            AddDataItem("Blue square", "Description for blue square", "blue", "blue.png");
            AddDataItem("Red sphere", "Description for red sphere", "sphere", "sphere.png");
            AddDataItem("The Cone", "A lot of description for cone figure", "cone", "cone.png");
            AddDataItem("Just a cube for sample", "Description for cube", "cube", "cube.png");

            // set data source
            cbxResult.DataSource = _dataItemList;
            cbxResult.ItemsDataSource = _dataItemList;
            cbxResult.ItemsDisplayMember = "Title";
            cbxResult.ItemsValueMember = "Title";

            // set other properties
            cbxResult.ItemsImageList = _imageList;
            cbxResult.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern;

            // sample 1 data
            cbxSelectSample.Items.Add("Sample 1: image + title");

            _htmlPatternList.Add(
            "<table style='background:#D6EAF8;border:1px solid #AEB6BF;width:278px'>" + Environment.NewLine +
            "<tr style='padding:3px;border:0'>" + Environment.NewLine +
            "<td style='width:32px'><img src='{ImageFile}' width='24' height='24'></td>" + Environment.NewLine +
            "<td style='padding-left:5px;font-weight:bold'>{Title}</td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "</table>");

            // sample 2 data
            cbxSelectSample.Items.Add("Sample 2: image + title + description");

            _htmlPatternList.Add(
            "<table style='background:#D6EAF8;border:0;width:278px'>" + Environment.NewLine +
            "<tr>" + Environment.NewLine +
            "<td style='width:24px'><img src='{ImageFile}' width='24' height='24'></td>" + Environment.NewLine +
            "<td style='border:1px solid #85929E;background:#AED6F1;font-weight:bold;padding:3px'>{Title}</td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "<tr>" + Environment.NewLine +
            "<td></td>" + Environment.NewLine +
            "<td style='padding:3px'>{Description}</td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "</table>");

            // sample 3 data
            cbxSelectSample.Items.Add("Sample 3: image + title + description");

            _htmlPatternList.Add(
            "<div style='background:#D6EAF8;border:1px solid #85929E'>" + Environment.NewLine +
            "<div style='background:#AED6F1;padding:3px'>" + Environment.NewLine +
            "<img src='{ImageFile}' width='24' height='24'>" + Environment.NewLine +
            "<span style='height:25px;font:14px;font-weight:bold;margin-left:3px'>{Title}</span>" + Environment.NewLine +
            "</div>" + Environment.NewLine +
            "<div style='padding:3px'>{Description}</div>" + Environment.NewLine +
            "</div>");

            // sample 4 data
            cbxSelectSample.Items.Add("Sample 4: title + large image + description");

            _htmlPatternList.Add(
            string.Format("<table style='background:#D6EAF8;border-collapse:collapse;border:1px solid #AEB6BF;text-align:center;width:242px;margin-left:-{0}px'>", 
            SystemInformation.VerticalScrollBarWidth) + Environment.NewLine +
            "<tr>" + Environment.NewLine +
            "<td style='background:#AED6F1;border:0;height:25px;font:14px;font-weight:bold'>{Title}</td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "<tr>" + Environment.NewLine +
            "<td style='border:0'><img style='padding:5px' src='{ImageFile}' width='150px' height='150px'></td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "<tr>" + Environment.NewLine +
            "<td style='border:0;color:#17202A'>{Description}</td>" + Environment.NewLine +
            "</tr>" + Environment.NewLine +
            "</table>");

            // select first sample by default
            cbxSelectSample.SelectedIndex = 0;
        }

        private void AddDataItem(string title, string description, string imageKey, string imageFile)
        {
            _dataItemList.Add(new DataItem(title, description, imageKey, imageFile));

            // add image if key and file assigned
            if (!(string.IsNullOrEmpty(imageKey) || string.IsNullOrEmpty(imageFile)))
            {
                _imageList.Images.Add(imageKey, Image.FromFile(imageFile));
            }
        }

        public static void CreateBitmap(string fileName, Color color)
        {
            var width = 150;
            var height = 150;

            // create bitmap with specified color
            var bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, 0, 0, width, height);
            }

            bitmap.Save(fileName);
        }

        private void cbxSelectSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectSample.SelectedIndex == -1)
            {
                return;
            }

            var pattern = _htmlPatternList[cbxSelectSample.SelectedIndex];
            cbxResult.HtmlPattern = pattern;
            tbxHtmlPattern.Text = pattern;
        }


        private class DataItem
        {
            public DataItem()
            {}

            public DataItem(string title, string description, string imageKey, string imageFile)
            {
                Title = title;
                Description = description;
                ImageKey = imageKey;
                ImageFile = imageFile;
            }

            public string Title { get; set; }
            public string Description { get; set; }
            public string ImageKey { get; set; }
            public string ImageFile { get; set; }
        }
    }
}