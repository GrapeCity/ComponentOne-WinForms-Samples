using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FinancialChartExplorer
{
    public class Sample
    {
        [XmlAttribute]
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        [XmlAttribute]
        public string ControlName
        {
            get;
            set;
        }
    }

    public class SampleGroup
    {
        List<Sample> _samples = new List<Sample>();

        [XmlAttribute]
        public string Name
        {
            get;
            set;
        }

        public List<Sample> Samples
        {
            get { return _samples; }
        }
    }

    public class AllSamples
    {
        List<SampleGroup> _groups = new List<SampleGroup>();

        public List<SampleGroup> Groups 
        {
            get { return _groups; }
        }
    }
}
