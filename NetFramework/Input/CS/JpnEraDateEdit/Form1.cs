using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using C1.Win.C1Input;

namespace JpnEraDateEdit
{
    public partial class Form1 : Form
    {

        public class DateFormatDesc
        {
            public int CultureId { get; set; }

            public CalendarType CalendarType { get; set; }
            public string Text { get; set; }

            public string Format { get; set; }

            public override string ToString()
            {
                return Text + " " + Format;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var jpnId = new CultureInfo("ja-JP").LCID;

            CultureInfo jcidef = new CultureInfo("ja-JP");

            List<DateFormatDesc> formats = new List<DateFormatDesc>();
            formats.Add(new DateFormatDesc { Text = "Current culture" });
            formats.Add(new DateFormatDesc { Text = "Gregorian, With era" , Format = "MM/dd/yyyy gg"});
            formats.Add(new DateFormatDesc { Text = "Time", Format = "HH:mm:ss" });
            formats.Add(new DateFormatDesc { Text = "Japaneese",  CultureId = jpnId });
            formats.Add(new DateFormatDesc { Text = "Japaneese with time", CultureId = jpnId, Format = "yy/MM/dd HH:mm:ss" });
            formats.Add(new DateFormatDesc { Text = "Japaneese separators", CultureId = jpnId, Format = "yyyy年MM月dd日 HH時mm分ss秒" });
            formats.Add(new DateFormatDesc { Text = "Japaneese time", CultureId = jpnId, Format = "tt hh時mm分ss秒" });
            formats.Add(new DateFormatDesc { Text = "Japaneese, Jpn Calendar", CultureId = jpnId, CalendarType = CalendarType.JapaneseCalendar });
            formats.Add(new DateFormatDesc { Text = "Japaneese, Jpn Calendar", CultureId = jpnId, CalendarType = CalendarType.JapaneseCalendar, Format = "yy年MM月dd日" });
            formats.Add(new DateFormatDesc { Text = "Japaneese, Jpn Calendar, Era", CultureId = jpnId, CalendarType = CalendarType.JapaneseCalendar, Format = "ggyy年MM月dd日" });
            formats.Add(new DateFormatDesc { Text = "Japaneese, Jpn Calendar, EraAbbr", CultureId = jpnId, CalendarType = CalendarType.JapaneseCalendar, Format = "g.yy年MM月dd日" });
            formats.Add(new DateFormatDesc { Text = "Japaneese, Jpn Calendar, EraOneSymbol", CultureId = jpnId, CalendarType = CalendarType.JapaneseCalendar, Format = "g yy年MM月dd日" });

            c1ComboBox1.ItemsDataSource = formats;

            c1DateEdit1.Value = DateTime.Now;
        }

        private void c1ComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            DateFormatDesc selectedFormat = (DateFormatDesc)c1ComboBox1.SelectedItem;
            if (selectedFormat != null)
            {
                c1DateEdit1.Culture = selectedFormat.CultureId;
                c1DateEdit1.CalendarType = selectedFormat.CalendarType;

                if (selectedFormat != null)
                {
                    c1DateEdit1.DisplayFormat.CustomFormat = selectedFormat.Format;
                    c1DateEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;

                    c1DateEdit1.EditFormat.CustomFormat = selectedFormat.Format;
                    c1DateEdit1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
                }
                else
                {
                    c1DateEdit1.DisplayFormat.FormatType = FormatTypeEnum.DefaultFormat;
                    c1DateEdit1.EditFormat.FormatType = FormatTypeEnum.DefaultFormat;
                }

            }
        }
    }
}
