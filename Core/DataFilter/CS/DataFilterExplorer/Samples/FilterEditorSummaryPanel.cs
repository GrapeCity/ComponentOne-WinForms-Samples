using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.DataEngine;
using C1.DataFilter;
using C1.Win.FlexGrid;
using DataFilterExplorer.Data;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DataFilterExplorer.Samples
{
    public partial class FilterEditorSummaryPanel : UserControl
    {
        public FilterEditorSummaryPanel()
        {
            InitializeComponent();
        }

        private void FilterEditorSummary_Load(object sender, EventArgs e)
        {
            var dt = DataService.GetDataSource();
            flexGrid.DataSource = dt;
            summaryPanel.DataSource = dt;
            summaryPanel.Visible = true;
            summaryPanel.AddSampleExpressions();
        }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme) => summaryPanel?.ApplyTheme(theme);

        private void c1ContextMenu1_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            if(e.CallerLink.Command.Name == "ShowFilterSummaryPanel")
                summaryPanel.ShowFilterPanel();
            else
                summaryPanel.CloseFilterPanel();
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.Command.CommandClickEventArgs e)
        {
            if (e.Command == ShowFilterSummaryPanel)
                summaryPanel.ShowFilterPanel();
            else if(e.Command == CloseFilterSummaryPanel)
                summaryPanel.CloseFilterPanel();
        }

        private void FlexGridContextMenu_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            if (e.CallerLink.Command == ShowFilterSummaryPanel)
                summaryPanel.ShowFilterPanel();
            else if (e.CallerLink.Command == CloseFilterSummaryPanel)
                summaryPanel.CloseFilterPanel();
        }
    }
}
