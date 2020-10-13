using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFilter
{
    public partial class MainForm : C1RibbonForm
    {
        private Loader _loader;

        #region ctor

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            foreach (var theme in C1ThemeController.GetThemes())
                ribbonCmbThemes.Items.Add(theme);
            c1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.System;

            _loader = new Loader() { Visible = false, Dock = DockStyle.Fill };
            panel1.Controls.Add(_loader);
        }

        #endregion

        #region themes

        private void ribbonCmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }

        private string ThemeName
        {
            get;
            set;
        }

        private void ApplyTheme(Control control)
        {
            if (!string.IsNullOrEmpty(ThemeName))
            {
                var theme = C1ThemeController.GetThemeByName(ThemeName, false);
                if (theme != null)
                    C1ThemeController.ApplyThemeToControlTree(control, theme);
            }
        }

        #endregion

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // show animated loader
            _loader.ShowLoader();
            // hide data filter
            c1DataFilter1.Visible = false;
            // async part
            // To prevent the user interface from freezing, load data asynchronously
            await Task.Run(() => 
            {                 
                var data = Employee.GenerateData();                
                c1DataFilter1.DataSource = data;
                       
            });                        
            // apply filter async
            await c1DataFilter1.ApplyFilterAsync();

            c1DataFilter1.Visible = true;
            // hide animated loader
            _loader.HideLoader();
        }
        
        private void c1DataFilter1_FilterChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c1DataFilter1.View.ToList();
            _loader.HideLoader();
        }

        private void c1DataFilter1_FilterChanging(object sender, CancelEventArgs e)
        {
            _loader.ShowLoader();
        }

        private async void btnApplyFilter_Click(object sender, EventArgs e)
        {
            await c1DataFilter1.ApplyFilterAsync();
        }

        private void c1DataFilter1_FilterAutoGenerating(object sender, C1.DataFilter.FilterAutoGeneratingEventArgs e)
        {
            switch(e.Property.Name)
            {
                case "PostId":
                    var postFilter = new C1.Win.DataFilter.ChecklistFilter("PostId")
                    {
                        DisplayMemberPath = "Title",
                        ValueMemberPath = "Id",
                        SelectionMode = C1.DataFilter.SelectionMode.Single,
                        ShowSearchBox = false,
                        LayoutType = C1.DataFilter.LayoutType.List,
                        MaxHeight = 200,
                        HeaderText = e.Filter.HeaderText,
                        ItemsSource = Employee.Posts
                    };
                    postFilter.Items[0].Selected = true;                    
                    e.Filter = postFilter;
                    break;
                case "EmploymentDate":
                    var eDate = (C1.Win.DataFilter.DateRangeFilter)e.Filter;
                    var data = (List<Employee>)c1DataFilter1.DataSource;
                    eDate.Minimum = data.Min(x => x.EmploymentDate);
                    eDate.Maximum = data.Max(x => x.EmploymentDate);                    
                    break;
                case "CountryId":
                    var cntFilter = new C1.Win.DataFilter.ChecklistFilter("CountryId")
                    {
                        DisplayMemberPath = "Name",
                        ValueMemberPath = "Id",
                        SelectionMode = C1.DataFilter.SelectionMode.Multiple,
                        ShowSearchBox = false,
                        ShowSelectAll = true,
                        HeaderText = e.Filter.HeaderText,
                        ItemsSource = Employee.Countries
                    };
                    cntFilter.SelectAll();
                    e.Filter = cntFilter;
                    break;
                default:
                    e.Cancel = true;
                    break;

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "PostId" && e.RowIndex >= 0 && dgv["PostId", e.RowIndex].Value is int)
            {
                var id = (int)dgv["PostId", e.RowIndex].Value;
                e.Value = Employee.Posts.FirstOrDefault(x => x.Id == id).Title;
                e.FormattingApplied = true;                
            }
            if (dgv.Columns[e.ColumnIndex].Name == "CountryId" && e.RowIndex >= 0 && dgv["CountryId", e.RowIndex].Value is int)
            {
                var id = (int)dgv["CountryId", e.RowIndex].Value;
                e.Value = Employee.Countries.FirstOrDefault(x => x.Id == id).Name;
                e.FormattingApplied = true;
            }
        }
    }
}
