using System;
using System.Drawing;
using System.Threading;
 
namespace FlexChartExplorer
{
    public partial class MainForm : BaseExplorer.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override string GetConfigLocation()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string currentConfig = string.Empty;
            switch (Thread.CurrentThread.CurrentCulture.Name)
            {
                case "en-US": currentConfig = @"Resources\ExplorerConfiguration_EN.xml"; break;
                case "ch-CH": currentConfig = @"Resources\ExplorerConfiguration_CH.xml"; break;
                case "jp-JP": currentConfig = @"Resources\ExplorerConfiguration_JP.xml"; break;
                default: currentConfig = @"Resources\ExplorerConfiguration_EN.xml"; break;
            }
            return System.IO.Path.Combine(baseDir, currentConfig);
        }
    }
}