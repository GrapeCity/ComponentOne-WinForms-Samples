using C1.Win.C1Themes;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBinding
{
    public partial class MainForm : C1RibbonForm
    {
        private static Random rnd = new Random();
        private List<BitmapPanel> _items;
        private BitmapPanel _selectPanel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
            if (!DesignMode)
                InitializeBitmaps();
        }

        private void InitializeBitmaps()
        {
            var request =  "Select Title as Caption, Photo as Picture, FirstName as Description from Employees;"; 

            var data = GetDataSource(request);

            // Set random order positions
            var count = data.Rows.Count;
            var list = new List<int>(Enumerable.Range(0, count + 1).ToArray());

            // Creating pictures
            _items = data.Rows.Cast<DataRow>()
                .Select(x => new BitmapPanel(x, true, new Size(150, 150)))
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
            textBox1.Text = "";
            InitializeBitmaps();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchText = textBox1.Text.Trim();
            var result = _items.Where(x => x.Caption.IndexOf(searchText) >= 0);
            if (result.Any())
            {
                _items.ToList()
                    .ForEach(x => x.Select(searchText));
            }
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion

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
