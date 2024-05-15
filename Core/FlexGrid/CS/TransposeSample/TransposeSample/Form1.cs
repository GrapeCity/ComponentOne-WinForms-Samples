using C1.Chart;
using C1.Win.FlexGrid;

namespace TransposeSample
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
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            UserStoryModalForm usmf = new UserStoryModalForm();
            usmf.Location = this.Location;
            usmf.Show();
        }
        private void linkLabel2_Click(object sender, EventArgs e)
        {
            c1 usmf = new c1();
            usmf.Location = this.Location;
            usmf.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ImageIndex = 1;
                c1FlexGrid1.Transposed = true;
                c1FlexGrid1.Rows.MinSize = 150;
                c1FlexGrid1.Cols.DefaultSize = 30;
                flexPieActionLabel.Text = "Now click any row in your transposed FlexGrid to compare your hotel performance";
            }
            else
            {
                checkBox1.ImageIndex = 0;
                c1FlexGrid1.Rows.MinSize = 25;
                c1FlexGrid1.Cols.DefaultSize = 120;
                c1FlexGrid1.Transposed = false;
                flexPieActionLabel.Text = "In order to view the data in the FlexPie, transpose the FlexGrid and click a record to compare the performance of hotels.";
            }
        }

        private void c1FlexGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (c1FlexGrid1.Transposed)
            {

                flexPieActionLabel.Text = $"{c1FlexGrid1.GetDataDisplay(0, c1FlexGrid1.Col)} metrics of hotels"; ;
                String cell1 = c1FlexGrid1.GetDataDisplay(1, c1FlexGrid1.Col);
                String cell2 = c1FlexGrid1.GetDataDisplay(2, c1FlexGrid1.Col);
                String cell3 = c1FlexGrid1.GetDataDisplay(3, c1FlexGrid1.Col);

                String name1 = c1FlexGrid1.GetDataDisplay(1, c1FlexGrid1.Row);
                String name2 = c1FlexGrid1.GetDataDisplay(2, c1FlexGrid1.Row);
                String name3 = c1FlexGrid1.GetDataDisplay(3, c1FlexGrid1.Row);



                //flexPie1.Header.Content =

                //Specifies what and how to show data values
                flexPie1.DataLabel.Content = "{p:0}%";


                var data = new List<DefaultPieData>()
                {
                    new DefaultPieData{Name=name1, Value=Int32.Parse(cell1)},
                    new DefaultPieData{Name=name2, Value=Int32.Parse(cell2)},
                    new DefaultPieData{Name=name3, Value=Int32.Parse(cell3)},

                };
                flexPie1.DataSource = data;
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void flexPieActionLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  c1 usmf = new c1();
                usmf.Location = this.Location;
                usmf.Show();
        }
    }
}