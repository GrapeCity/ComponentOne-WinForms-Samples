﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DashboardModel;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Drawing.Imaging;
using C1.Win.C1Command;
using C1.Win.C1Themes;

namespace DashboardWinForms
{
    public partial class Form1 : Form
    {

        private int[] _sizes = { 50, 200 };

        string _initialPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "InitialData.xml");
        Dictionary<object, Control> _pages = new Dictionary<object, Control>();
        volatile string _error = null;

        public Form1()
        {
            InitializeComponent();
            C1ThemeController.ApplicationTheme = "Office365White";
            _btnHamb_Click(this, EventArgs.Empty);
            var worker = new BackgroundWorker();
            worker.DoWork += (s, e) =>
            {
                DataService service = DataService.GetService();
                service.InitializeDataService();
                _error = service.Error;
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                _picSpinner.Visible = false;
                if (_error != null)
                {
                    MessageBox.Show(this, _error, Strings.Resource.ErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }
                _pages.Add(cmdDashboard, new Dashboard());
                _pages.Add(cmdAnalysis, new Analysis());
                _pages.Add(cmdReporting, new Reporting());
                _pages.Add(cmdTasks, new Tasks());
                _pages.Add(cmdProducts, new Products()); 
                cmd_Click(cmdDashboard, ClickEventArgs.Empty);
            };
            worker.RunWorkerAsync();
        }

        private void _panMain_Resize(object sender, EventArgs e)
        {
            CenterSpinner();
        }

        private void CenterSpinner()
        {
            if (_picSpinner.Visible)
            {
                _picSpinner.Left = (_panMain.Width - _picSpinner.Width) / 2;
                _picSpinner.Top = (_panMain.Height - _picSpinner.Height) / 2 - 40;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _btnHamb.Font = new Font("Segoe MDL2 Assets", _btnHamb.Font.Size);
            _btnHamb.Text = char.ConvertFromUtf32(0xE700);
            CenterSpinner();
        }

        private void _btnHamb_Click(object sender, EventArgs e)
        {
            _panToolBar.Width = _panToolBar.Width > _sizes[0] ? _sizes[0] : _sizes[1];
        }

        private void cmd_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (_picSpinner.Visible)
                return;
            Control page;
            if (!_pages.TryGetValue(sender, out page))
                return;
            foreach (C1Command cmd in _pages.Keys)
                cmd.Checked = false;
            (sender as C1Command).Checked = true;
            _panControl.Controls.Clear();
            _labCaption.Text = page.Text;
            page.Dock = DockStyle.Fill;
            page.Parent = _panControl;
        }
    }
}
