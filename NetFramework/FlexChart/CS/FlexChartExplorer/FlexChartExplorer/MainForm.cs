using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BaseExplorer;

namespace FlexChartExplorer
{
    public partial class MainForm : BaseExplorer.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            BaseFormLoad(GetConfigLocation());
        }

        private string GetConfigLocation()
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
