using C1.Chart;
using C1.Win.Chart;
using C1.Win.FlexGrid;
using CsvHelper;
using System.Data;
using System.Globalization;

namespace TransposedGrid
{
    public partial class Form1 : Form
    {
        private bool isToggleOff = true;
        public Form1()
        {
            InitializeComponent();
            LoadDataSet();
        }

        public void LoadDataSet()
        {
            /*  This AllowSorting properties must be turned off in order for the 
                correct cell data to be picked up on MouseClick event in  
                the transposed-on state of the FLexGrid so that the appropiate
                data is shown on the FlexChart Bar.
            */
            HotelFlexGrid.AllowSorting = AllowSortingEnum.None;
            List<Hotel> hotels = new List<Hotel>(); //List to store the hotel records
            using (var reader = new StreamReader("Data\\hotel_dataset.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                hotels = csv.GetRecords<Hotel>().ToList();
            }
            HotelFlexGrid.DataSource = hotels;
        }

        private void HotelFlexGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (HotelFlexGrid.Transposed)
            {
                Boolean isHeaderText = HotelFlexGrid.GetDataDisplay(HotelFlexGrid.Row, HotelFlexGrid.Col) == "Dragon Hotel" ||
                    HotelFlexGrid.GetDataDisplay(HotelFlexGrid.Row, HotelFlexGrid.Col) == "Tiger's Nest" ||
                    HotelFlexGrid.GetDataDisplay(HotelFlexGrid.Row, HotelFlexGrid.Col) == "Wind Horse";
                if (!isHeaderText)
                {
                    String metricValue1 = HotelFlexGrid.GetDataDisplay(1, HotelFlexGrid.Col);
                    String metricValue2 = HotelFlexGrid.GetDataDisplay(2, HotelFlexGrid.Col);
                    String metricValue3 = HotelFlexGrid.GetDataDisplay(3, HotelFlexGrid.Col);
                    String hotelName1 = HotelFlexGrid.GetDataDisplay(1, HotelFlexGrid.Row);
                    String hotelName2 = HotelFlexGrid.GetDataDisplay(2, HotelFlexGrid.Row);
                    String hotelName3 = HotelFlexGrid.GetDataDisplay(3, HotelFlexGrid.Row);

                    flexChart1.Series.Clear();
                    flexChart1.Header.Content = "Performance Metric Comparison";

                    DataTable dt = new DataTable("Performance Metrics Comparison");
                    // add two columns header i.e Hotel Name and the selected metric to the datatable
                    dt.Columns.Add("HotelName", typeof(string));
                    dt.Columns.Add(HotelFlexGrid.GetDataDisplay(0, HotelFlexGrid.Col), typeof(int));
                    // add rows to the datatable i.e. Hotel Names and metric values
                    dt.Rows.Add(hotelName1, metricValue1);
                    dt.Rows.Add(hotelName2, metricValue2);
                    dt.Rows.Add(hotelName3, metricValue3);
                    flexChart1.DataSource = dt;
                    flexChart1.BindingX = "HotelName";

                    var items = new Series
                    {
                        Name = HotelFlexGrid.GetDataDisplay(0, HotelFlexGrid.Col),
                        Binding = HotelFlexGrid.GetDataDisplay(0, HotelFlexGrid.Col),
                    };
                    flexChart1.Series.Add(items);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flexChart1.Series.Clear();

            //Setting FlexChart ChartType to Bar
            flexChart1.ChartType = ChartType.Column;

            //Setting FlexChart's Header
            flexChart1.Header.Content = "Toggle Transpose on and click the grid record";

            //Passing data in FlexChart
            flexChart1.DataSource = GetBarChartData();

            //Binding FlexChart's AxisX to 'Beverages' so their Unit Price appear in Horizontal axis
            flexChart1.BindingX = "HotelName";

            //Creating and adding a series in FlexChart for Unit Price 
            var items = new Series
            {
                Name = "Metrics",
                Binding = "Metrics",
            };
            flexChart1.Series.Add(items);

            HotelFlexGrid.Cols.Frozen = 1;
            HotelFlexGrid.Styles["Fixed"].BackColor = Color.Cornsilk;
            HotelFlexGrid.Rows[0].StyleNew.Font = new Font("verdana", 8, FontStyle.Bold);
            HotelFlexGrid.Cols.DefaultSize = 180;
            HotelFlexGrid.Rows.MinSize = 61;

        }

        public DataTable GetBarChartData()
        {
            // create a datatable
            DataTable dt = new DataTable("Product Comparison");

            // add columns to the datatable
            dt.Columns.Add("HotelName", typeof(string));
            dt.Columns.Add("Metrics", typeof(int));

            // add rows to the datatable
            dt.Rows.Add("x", 18);
            dt.Rows.Add("y", 19);
            dt.Rows.Add("z", 10);

            return dt;
        }

        private void transposeToggleButton_Click(object sender, EventArgs e)
        {

            if (isToggleOff)
            {
                transposeToggleButton.Image = Properties.Resources.transpose_on;
                HotelFlexGrid.Transposed = true;


                HotelFlexGrid.Size = new Size(930, 500);
                /* Always ensure, in the transposed state, that the pre-configured row and column sizes 
                   are switched for proper display of the cell data  
                 */
                HotelFlexGrid.Cols.DefaultSize = 60;
                HotelFlexGrid.Rows.MinSize = 225;
                flexChart1.Header.Content = "";
            }
            else
            {
                transposeToggleButton.Image = Properties.Resources.transpose_off;
                HotelFlexGrid.Transposed = false;
                HotelFlexGrid.Size = new Size(1000, 280);
                HotelFlexGrid.Cols.DefaultSize = 180;
                HotelFlexGrid.Rows.MinSize = 60;
                flexChart1.Header.Content = "Toggle Transpose on and click the grid record";
            }
            isToggleOff = !isToggleOff;

        }

        private void userStoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserStoryModalForm userStoryModalForm = new UserStoryModalForm();
            userStoryModalForm.StartPosition = FormStartPosition.CenterParent; // Set the child form to appear in the center of the parent form
            userStoryModalForm.ShowDialog(this); // Show the child form as a modal dialog
            //userStoryModalForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutFlexGridModalForm aboutFlexGridModal = new AboutFlexGridModalForm();
            aboutFlexGridModal.StartPosition = FormStartPosition.CenterParent; // Set the child form to appear in the center of the parent form
            aboutFlexGridModal.ShowDialog(this); // Show the child form as a modal dialog
            //userStoryModalForm.Show();

        }
    }
}