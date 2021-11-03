using System.Linq;
using System.Windows.Forms;
using Tooltips.Forms;
using Tooltips.Resources;

namespace Tooltips
{
    public partial class MainForm : Form
    {
        RegularTooltipForm _frmRegularTooltip;
        HTMLTooltipForm _frmHTMLTooltip;
        ChartTooltipForm _frmChartTooltip;

        public MainForm()
        {
            InitializeComponent();
            this.Text = AppResources.MainTitle;

            this.viewToolStripMenuItem.Text = AppResources.ToolStripItemView;
            this.regularTooltipMenuItem.Text = AppResources.TooltStripItemRegularTooltip;
            this.hTMLTooltipMenuItem.Text = AppResources.TooltStripItemHTMLTooltip;
            this.chartTooltipMenuItem.Text = AppResources.ToolStripItemChartTooltip;

            regularTooltipMenuItem.Click += (s,e) => {
                if (!this.MdiChildren.Contains(_frmRegularTooltip))
                {
                    _frmRegularTooltip = new RegularTooltipForm();
                    _frmRegularTooltip.MdiParent = this;
                    _frmRegularTooltip.WindowState = this.WindowState;
                    _frmRegularTooltip.Show();
                }
                else
                    _frmRegularTooltip.Activate();
            };

            hTMLTooltipMenuItem.Click += (s, e) =>
            {
                if (!this.MdiChildren.Contains(_frmHTMLTooltip))
                {
                    _frmHTMLTooltip = new HTMLTooltipForm();
                    _frmHTMLTooltip.MdiParent = this;
                    _frmHTMLTooltip.WindowState = this.WindowState;
                    _frmHTMLTooltip.Show();
                }
                else
                    _frmHTMLTooltip.Activate();

            };

            chartTooltipMenuItem.Click += (s, e) =>
                {
                    if (!this.MdiChildren.Contains(_frmChartTooltip))
                    {
                        _frmChartTooltip = new ChartTooltipForm();
                        _frmChartTooltip.MdiParent = this;
                        _frmChartTooltip.WindowState = this.WindowState;
                        _frmChartTooltip.Show();
                    } 
                    else
                        _frmChartTooltip.Activate();
                };

            chartTooltipMenuItem.PerformClick();

        }
    }
}
