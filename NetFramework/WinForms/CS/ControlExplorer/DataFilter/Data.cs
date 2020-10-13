using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExplorer.DataFilter
{
    public static class Data
    {
        public static DataTable GetDataSource()
        {
            var dt = new DataTable();
            dt.Columns.Add("Brand");
            dt.Columns.Add("Model");
            dt.Columns.Add("HP", typeof(int));
            dt.Columns.Add("Liter", typeof(double));
            dt.Columns.Add("Cylinder", typeof(int));
            dt.Columns.Add("TransmissionSpeedCount", typeof(int));
            dt.Columns.Add("AutomaticTransmission", typeof(bool));
            dt.Columns.Add("Category");
            dt.Columns.Add("StartSaleDate", typeof(DateTime));
            dt.Columns.Add("Price", typeof(int));

            dt.Rows.Add("Mercedes-Benz", "SLK R172 Cabriolet", 302, 4.966, 8, 5, true, "Sports", new DateTime(2011, 1, 1), 83800);
            dt.Rows.Add("Mercedes-Benz", "SL AMG R231 Cabriolet", 342, 5.439, 8, 5, true, "Sports", new DateTime(2012, 1, 1), 79645);
            dt.Rows.Add("Mercedes-Benz", "SL R231 Cabriolet", 189, 1.796, 4, 5, true, "Sports", new DateTime(2012, 1, 1), 25600);
            dt.Rows.Add("BMW", "M3 F30 Sedan", 225, 3, 6, 6, false, "Saloon", new DateTime(2014, 1, 1), 39450);
            dt.Rows.Add("Rolls-Royce", "Wraith", 325, 6.75, 8, 4, true, "Saloon", new DateTime(2016, 1, 1), 370485);
            dt.Rows.Add("Jaguar", "XFR-S I", 235, 3, 6, 5, false, "Saloon", new DateTime(2012, 1, 1), 44320);
            dt.Rows.Add("Cadillac", "ATS I", 275, 4.6, 8, 4, true, "Saloon", new DateTime(2007, 1, 1), 49600);
            dt.Rows.Add("Cadillac", "CTS III", 275, 4.6, 8, 4, true, "Saloon", new DateTime(2007, 1, 1), 47780);
            dt.Rows.Add("Lexus", "ES VI Sedan", 290, 4.3, 8, 5, true, "Saloon", new DateTime(2005, 1, 1), 54900);
            dt.Rows.Add("Lexus", "IS III", 300, 4.3, 8, 5, true, "Saloon", new DateTime(2008, 1, 1), 41242);
            dt.Rows.Add("Ford", "Ranger VI", 135, 2.3, 4, 5, true, "Truck", new DateTime(2015, 1, 1), 12565);
            dt.Rows.Add("Dodge", "Ram 1500", 215, 3.7, 6, 4, true, "Truck", new DateTime(1981, 1, 1), 17315);
            dt.Rows.Add("GMC", "Envoy", 200, 4.3, 6, 4, true, "Truck", new DateTime(1997, 1, 1), 17748);
            dt.Rows.Add("Nissan", "Navara IV", 143, 2.4, 4, 4, true, "Truck", new DateTime(2014, 6, 1), 12800);
            dt.Rows.Add("Toyota", "HILUX VIII", 190, 3.4, 6, 5, false, "Truck", new DateTime(2015, 1, 1), 20000);
            dt.Rows.Add("Infiniti", "Q50 I", 340, 4.5, 8, 5, true, "Saloon", new DateTime(2013, 1, 1), 62300);
            dt.Rows.Add("Infiniti", "Q60 I Cabriolet", 280, 3.5, 6, 6, true, "Sports", new DateTime(2014, 1, 1), 34000);
            dt.Rows.Add("Jaguar", "F-TYPE I", 294, 4.2, 8, 6, true, "Sports", new DateTime(2013, 1, 1), 73000);
            dt.Rows.Add("Audi", "A3 (V8)", 220, 3, 6, 5, true, "Saloon", new DateTime(2012, 1, 1), 38000);
            dt.Rows.Add("Audi", "TT 8S Cabriolet", 180, 1.8, 4, 6, true, "Sports", new DateTime(2014, 1, 1), 45000);
            dt.Rows.Add("BMW", "BMW 7 G11/G12 Sedan", 438, 6, 12, 6, true, "Saloon", new DateTime(2015, 1, 1), 120000);
            dt.Rows.Add("BMW", "Z4 E89 Roadster", 225, 3, 6, 6, false, "Sports", new DateTime(2013, 1, 1), 45000);
            dt.Rows.Add("Acura", "NSX II Coupe", 200, 2.4, 4, 6, false, "Sports", new DateTime(2012, 1, 1), 28500);
            dt.Rows.Add("Acura", "TLX I Sedan", 290, 3.2, 6, 6, false, "Saloon", new DateTime(2014, 1, 1), 95000);

            return dt;
        }
    }
}
