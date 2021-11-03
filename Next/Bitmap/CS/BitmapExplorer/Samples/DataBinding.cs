using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapExplorer.Samples
{
    using BitmapExplorer.Data;
    public partial class DataBinding : UserControl
    {
        private static Random rnd = new Random();
        private List<BitmapPanel> _items;
        private BitmapPanel _selectPanel;

        public DataBinding()
        {
            InitializeComponent();
        }

        private void InitializeBitmaps()
        {
            var sql = @"Select * from GetAllImages";
            var imageFields = new List<string>() { "Picture" };
            var data = DataSource.GetRows(sql, "Pictures", imageFields);

            // Set random order positions
            var count = data.Rows.Count;
            var list = new List<int>(Enumerable.Range(0, count + 1).ToArray());

            while(list.Count() > 0)
            {
                var random = rnd.Next(0, count + 1);
                if (list.Any(x => x == random))
                {
                    var index = list.IndexOf(random);
                    list.RemoveAt(index);

                    var row = (from s in data.Rows.Cast<DataRow>() where Convert.ToInt32(s["Position"]) == 0 select s).FirstOrDefault();
                    if (row != null)
                        row["Position"] = random;
                }
            }

            // Creating pictures
            _items = (from s in data.Rows.Cast<DataRow>() orderby s["Position"] select s )
                .Select(x => new BitmapPanel(x, true, new Size( Convert.ToInt32( x["Size"]), Convert.ToInt32(x["Size"]))))
                .ToList();
            _items.ForEach(x => x.SelectImage += Image_Click);

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(_items.ToArray());
        }

        private void Image_Click(object sender, EventArgs e)
        {
            var panel = sender as BitmapPanel;
            if (panel == null) return;

            // Changed select flag
            if(_selectPanel != null)
                _selectPanel.IsSelect = false;
            panel.IsSelect = true;

            // Get and transformed picture
            _selectPanel = panel;
            c1PictureBox1.Image = Effects.RoundUpImage(panel.Bitmap).ToGdiBitmap();
            richTextBox1.Text = panel.Description;
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                InitializeBitmaps();
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = "";
            InitializeBitmaps();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text.Trim();
            var result = _items.Where(x => x.Caption.IndexOf(searchText) >= 0);
            if(result.Any())
            {
                _items.ToList()
                    .ForEach(x => x.Select(searchText));
            }
        }
    }
}
