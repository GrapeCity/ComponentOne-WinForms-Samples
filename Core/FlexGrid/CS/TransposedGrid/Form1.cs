using C1.Chart;
using C1.Win.FlexGrid;

namespace TransposedGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1FlexGrid1.AllowSorting = AllowSortingEnum.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flexPie1.Binding = "Value";

            flexPie1.BindingName = "Name";


            //Specify where to position the data labels relative to pie slices
            flexPie1.DataLabel.Position = PieLabelPosition.Radial;

            //Setting FlexPie's Header
            flexPie1.Header.Content = "";

            //DefaultPieData defaultPie = new DefaultPieData();
            flexPie1.DataSource = DefaultPieData.GetDefaultData();


            List<Hotel> _hotels = new List<Hotel>();
            for (int i = 0; i < 3; i++)
            {
                _hotels.Add(new Hotel(i));
            }
            c1FlexGrid1.DataSource = _hotels;

            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeRows();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.Transposed = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                checkBox1.ImageIndex = 1;
                c1FlexGrid1.AutoSizeRows();
                c1FlexGrid1.AutoSizeCols();
                flexPieActionLabel.Text = "Now click any row in your transposed FlexGrid to compare your hotel performance";
            }
            else
            {
                checkBox1.ImageIndex = 0;
                c1FlexGrid1.AutoSizeCols();
                c1FlexGrid1.AutoSizeRows();
                flexPieActionLabel.Text = "In order to view the data in the FlexPie, transpose the FlexGrid and click a record to compare the performance of hotels.";
            }
        }

        private void c1FlexGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!c1FlexGrid1.Transposed)
            {
                return;
            }

            flexPieActionLabel.Text = $"{c1FlexGrid1.GetDataDisplay(0, c1FlexGrid1.Col)} metrics of hotels";

            string name1 = c1FlexGrid1[1, 1]?.ToString() ?? string.Empty;
            string name2 = c1FlexGrid1[2, 1]?.ToString() ?? string.Empty;
            string name3 = c1FlexGrid1[3, 1]?.ToString() ?? string.Empty;

            double cell1 = 0;
            if (c1FlexGrid1[1, c1FlexGrid1.Col] is double cellValue1)
            {
                cell1 = cellValue1;
            }
            double cell2 = 0;
            if (c1FlexGrid1[2, c1FlexGrid1.Col] is double cellValue2)
            {
                cell2 = cellValue2;
            }
            double cell3 = 0;
            if (c1FlexGrid1[3, c1FlexGrid1.Col] is double cellValue3)
            {
                cell3 = cellValue3;
            }

            //Specifies what and how to show data values
            flexPie1.DataLabel.Content = "{p:0}%";

            var data = new List<DefaultPieData>()
            {
                new DefaultPieData{Name=name1, Value=cell1},
                new DefaultPieData{Name=name2, Value=cell2},
                new DefaultPieData{Name=name3, Value=cell3},

            };
            flexPie1.DataSource = data;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (UserStoryModalForm usmf = new UserStoryModalForm())
            {
                usmf.Location = Location;
                usmf.ShowDialog();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (C1Form c1 = new C1Form())
            {
                c1.Location = Location;
                c1.ShowDialog();
            }
        }
    }
}