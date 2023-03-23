using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WYSIWYGPrinting
{
    public partial class PrintRangeDialog : Form
    {
        private DateTime _startDate;
        private DateTime _endDate;

        public PrintRangeDialog()
        {
            InitializeComponent();
            _startDate = DateTime.Now;
            _endDate = DateTime.Now;
        }

        public PrintRangeDialog(DateTime start, DateTime end)
        {
            InitializeComponent();
            _startDate = start;
            _endDate = end;
        }
     
        public DateTime StartDate 
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                UpdateDates();
                dtpkrStart.Value = _startDate;
            }
        }
        public DateTime EndDate 
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                UpdateDates();
                dtpkrEnd.Value = _endDate;
            }
        }

        // returns an array representing the date range selected
        public DateTime[] GetDateRange()
        {
            DateTime[] _dateRange = new DateTime[(int)EndDate.ToOADate() - (int)StartDate.ToOADate() + 1];
            DateTime _start = StartDate;
            for (int i = 0; i < _dateRange.Length; i++)
            {
                _dateRange[i] = _start;
                _start = _start.AddDays(1);
            }
            return _dateRange;
        }

        private void UpdateDates()
        {
            if (_endDate < _startDate)
            {
                _endDate = _startDate;
            }
        }

        private void dtpkrStart_ValueChanged(object sender, EventArgs e)
        {
            this.StartDate = dtpkrStart.Value;
        }

        private void dtpkrEnd_ValueChanged(object sender, EventArgs e)
        {
            this.EndDate = dtpkrEnd.Value;
        }
    }
}
