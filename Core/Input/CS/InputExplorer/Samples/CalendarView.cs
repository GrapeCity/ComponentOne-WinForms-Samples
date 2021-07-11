using C1.Win.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    public partial class CalendarView : UserControl
    {
        private System.DateTime[] bolderDates;
        private System.DateTime[] annualyDates;
        private System.DateTime[] disabledDates;
        public CalendarView()
        {
            InitDateLists();
            InitializeComponent();
            foreach (Control control in Controls)
                if (control is C1CalendarView)
                    control.Enter += Control_GotFocus;

        }

        private void InitDateLists()
        {
            DateTime currendDate = DateTime.Now;
            DateTime tempDate;
            annualyDates = new DateTime[12];
            bolderDates = new DateTime[3];
            disabledDates = new DateTime[2];

            if (currendDate.Day != 3)
                tempDate = new DateTime(currendDate.Year, currendDate.Month, 3);
            else
                tempDate = new DateTime(currendDate.Year, currendDate.Month, 4);
            
            for (int i = -2; i < 10; i++)
                annualyDates.SetValue(tempDate.AddDays(i*30), i+2);
            
            for (int i = 0; i < 3; i++)
                if(tempDate.AddDays(9) != currendDate) 
                    bolderDates.SetValue(tempDate.AddDays(9),i);

            for (int i = 0; i <2; i++)
                if (tempDate.AddDays(2) != currendDate)
                    disabledDates.SetValue(tempDate.AddDays(2), i);


        }
        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
