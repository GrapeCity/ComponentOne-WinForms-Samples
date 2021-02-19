using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DataBinding
{
    [ToolboxItem(true)]
    public partial class Sample : UserControl
    {
        private static Random rnd = new Random();
        private List<BitmapPanel> _items;
        private BitmapPanel _selectPanel;

        public Sample()
        {
            InitializeComponent();
        }

        private void InitializeBitmaps()
        {
            var request = "Select [Brand] & \" \" & [Model] as Caption, Picture, Description from Cars;";
            var data = GetDataSource(request);
            
            // Creating pictures
            _items = data.Rows.Cast<DataRow>()
                .Select(x => new BitmapPanel(x, true, new Size(240, 150)))
                .ToList();
            _items.ForEach(x => x.SelectImage += Image_Click);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(_items.ToArray());
        }

        public Control[] ThemeableControls => new Control[] { button1, textBox1, label1, richTextBox1, linkLabelRefresh };

        private void Search(string searchText)
        {
            var result = _items.Where(x => x.Caption.IndexOf(searchText) >= 0);
            if (result.Any())
            {
                _items.ToList()
                    .ForEach(x => x.Select(searchText));
            }
        }

        #region Handlers

        private void Sample_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                InitializeBitmaps();
        }

        private void Image_Click(object sender, EventArgs e)
        {
            var panel = sender as BitmapPanel;
            if (panel == null) return;

            // Changed select flag
            if (_selectPanel != null)
                _selectPanel.IsSelect = false;
            panel.IsSelect = true;

            // Get and transformed picture
            _selectPanel = panel;
            c1PictureBox1.Image = Effects.RoundUpImage(panel.Bitmap).ToGdiBitmap();
            richTextBox1.Text = panel.Description;
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();
            InitializeBitmaps();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search(textBox1.Text.Trim());
        }

        #endregion Handlers

        #region DataSource

        private DataTable GetDataSource(string request)
        {
            var cn = GetConnectionString();
            var da = new OleDbDataAdapter(request, cn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        #endregion
    }
}
