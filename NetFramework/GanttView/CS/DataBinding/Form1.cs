using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.GanttView;

namespace DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                tasksTableAdapter1.Fill(c1NwindDataSet1.Tasks);
                resourcesTableAdapter1.Fill(c1NwindDataSet1.Resources);
                propertiesTableAdapter1.Fill(c1NwindDataSet1.Properties);
                calendarsTableAdapter1.Fill(c1NwindDataSet1.Calendars);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveData()
        {
            try
            {
                tasksTableAdapter1.Update(c1NwindDataSet1.Tasks);
                resourcesTableAdapter1.Update(c1NwindDataSet1.Resources);
                propertiesTableAdapter1.Update(c1NwindDataSet1.Properties);
                calendarsTableAdapter1.Update(c1NwindDataSet1.Calendars);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

    }
}
