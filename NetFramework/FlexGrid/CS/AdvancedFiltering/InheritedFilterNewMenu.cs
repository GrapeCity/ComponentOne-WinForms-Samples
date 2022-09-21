using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdvancedFiltering
{
    internal class InheritedFilterNewMenu : ColumnFilter
    {
        public WeekdayFilter WeekdayFilter = new WeekdayFilter();

        public override IC1ColumnFilterEditor GetEditor()
        {
            return new InheritedFilterEditorNewMenu();
        }

        public override void Reset()
        {
            base.Reset();
            WeekdayFilter.Reset();
        }

        public override bool Apply(object value)
        {
            return base.Apply(value) && WeekdayFilter.Apply(value);
        }

        public override bool IsActive
        {
            get
            {
                return base.IsActive || WeekdayFilter.IsActive;
            }
        }

        public override void WriteXmlDefinition(XmlWriter xw)
        {
            base.WriteXmlDefinition(xw);

            if (WeekdayFilter.IsActive)
            {
                xw.WriteAttributeString("ActiveFilter", WeekdayFilter.GetType().Name);
                xw.WriteStartElement(WeekdayFilter.GetType().Name);
                xw.WriteStartElement("Monday");
                xw.WriteAttributeString("Value", WeekdayFilter.Monday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Tuesday");
                xw.WriteAttributeString("Value", WeekdayFilter.Tuesday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Wednesday");
                xw.WriteAttributeString("Value", WeekdayFilter.Wednesday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Thursday");
                xw.WriteAttributeString("Value", WeekdayFilter.Thursday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Friday");
                xw.WriteAttributeString("Value", WeekdayFilter.Friday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Saturday");
                xw.WriteAttributeString("Value", WeekdayFilter.Saturday.ToString());
                xw.WriteEndElement();
                xw.WriteStartElement("Sunday");
                xw.WriteAttributeString("Value", WeekdayFilter.Sunday.ToString());
                xw.WriteEndElement();
                xw.WriteEndElement();
            }
        }

        public override void ReadXmlDefinition(XmlReader xr)
        {
            base.ReadXmlDefinition(xr);

            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    if (xr.Name == "Monday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Monday);
                    }
                    else if (xr.Name == "Tuesday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Tuesday);
                    }
                    else if (xr.Name == "Wednesday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Wednesday);
                    }
                    else if (xr.Name == "Thursday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Thursday);
                    }
                    else if (xr.Name == "Friday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Friday);
                    }
                    else if (xr.Name == "Saturday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Saturday);
                    }
                    else if (xr.Name == "Sunday")
                    {
                        bool.TryParse(xr.GetAttribute("Value"), out WeekdayFilter.Sunday);
                    }
                }
            }
        }
    }
}
