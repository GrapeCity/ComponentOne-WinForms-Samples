using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    using InputPanelExplorer.Data;
    public partial class Customization : UserControl
    {
        private BindingSource employeesBindingSource;

        public Customization()
        {
            InitializeComponent();

            var resources = new ComponentResourceManager(typeof(Customization));
            if (DeviceDpi > 144)
            {
                navEmployees.AddNewImage?.Dispose();
                navEmployees.ApplyImage?.Dispose();
                navEmployees.CancelImage?.Dispose();
                navEmployees.DeleteImage?.Dispose();
                navEmployees.EditImage?.Dispose();
                navEmployees.MoveFirstImage?.Dispose();
                navEmployees.MoveLastImage?.Dispose();
                navEmployees.MoveNextImage?.Dispose();
                navEmployees.MovePreviousImage?.Dispose();
                navEmployees.ReloadImage?.Dispose();
                navEmployees.SaveImage?.Dispose();
                navEmployees.AddNewImage = (Image)resources.GetObject("navEmployees.AddNewImage32");
                navEmployees.ApplyImage = (Image)resources.GetObject("navEmployees.ApplyImage32");
                navEmployees.CancelImage = (Image)resources.GetObject("navEmployees.CancelImage32");
                navEmployees.DeleteImage = (Image)resources.GetObject("navEmployees.DeleteImage32");
                navEmployees.EditImage = (Image)resources.GetObject("navEmployees.EditImage32");
                navEmployees.MoveFirstImage = (Image)resources.GetObject("navEmployees.MoveFirstImage32");
                navEmployees.MoveLastImage = (Image)resources.GetObject("navEmployees.MoveLastImage32");
                navEmployees.MoveNextImage = (Image)resources.GetObject("navEmployees.MoveNextImage32");
                navEmployees.MovePreviousImage = (Image)resources.GetObject("navEmployees.MovePreviousImage32");
                navEmployees.ReloadImage = (Image)resources.GetObject("navEmployees.ReloadImage32");
                navEmployees.SaveImage = (Image)resources.GetObject("navEmployees.SaveImage32");
            }
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            // Create data source
            employeesBindingSource = new BindingSource();
            var imagesColumns = new List<string>() { "Photo" };
            employeesBindingSource.DataSource = DataSource.GetRows("Select * from Employees", "Employees", imagesColumns);

            // Databinding
            navEmployees.DataSource = this.employeesBindingSource;
            c1InputPanel1.DataSource = this.employeesBindingSource;
            txtTitleOfCourtesy.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "TitleOfCourtesy", true));
            txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "FirstName", true));
            txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "LastName", true));
            dtpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "BirthDate", true));
            txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Notes", true));
            imgPhoto.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Photo", true));
            txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Title", true));
            cbReportsTo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "ReportsTo", true));
            dtpHireDate.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "HireDate", true));
            txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Address", true));
            txtCity.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "City", true));
            txtRegion.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Region", true));
            txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Country", true));
            txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "PostalCode", true));
            txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "HomePhone", true));
            txtExtension.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.employeesBindingSource, "Extension", true));
        }

        private void cbReportsTo_Format(object sender, ListControlConvertEventArgs e)
        {            
            if (TypeDescriptor.GetProperties(e.ListItem)["FirstName"] is PropertyDescriptor pd)
            {
                object firstName = pd.GetValue(e.ListItem);
                if (firstName is string firstNameString && e.Value is string valueString)
                {
                    e.Value = firstNameString + " " + valueString;
                }
            }
        }

    }
}
