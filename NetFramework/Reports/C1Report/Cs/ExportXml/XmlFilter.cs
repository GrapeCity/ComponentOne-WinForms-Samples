using System;
using System.Xml;
using System.Text;
using System.Drawing;
using C1.C1Report;

namespace ExportXml
{
	/// <summary>
	/// Summary description for XmlFilter.
	/// </summary>
    public class XmlFilter : C1.C1Report.ExportFilter
	{
		// ** fields
		private XmlWriter _w;
		private bool	  _overlay = false;
		private bool	  _valuesAsAtts = false;

		// ** ctors
		public XmlFilter(XmlWriter writer)
		{
			_w = writer;
			_w.WriteStartDocument();
		}
		public XmlFilter(string fileName)
		{
			XmlTextWriter textWriter = new XmlTextWriter(fileName, Encoding.UTF8);
			textWriter.Formatting = Formatting.Indented;
			textWriter.Indentation = 2;
			_w = textWriter;
		}

		// ** object model
		public bool ValuesAsAttributes
		{
			get { return _valuesAsAtts; }
			set { _valuesAsAtts = value; }
		}

		// ** overrides
		override public void StartReport(C1Report r)
		{
			_w.WriteStartElement("REPORT");
			_w.WriteAttributeString("name", r.ReportName);
		}
		override public void EndReport()
		{
			_w.WriteEndElement();
			_w.Close();
			_w = null;
		}
		override public void StartSection(Section s, double x, double y)
		{
			_w.WriteStartElement("SECTION");
			_w.WriteAttributeString("name", s.Name);
		}
		override public void EndSection(Section s)
		{
			_w.WriteEndElement();
		}
		override public void RenderField(Field f, Rectangle rc, string text, Image img)
		{
			// no overlays
			if (_overlay) return;

			// don't write empty fields
			if (text == null || text.Length == 0) return;

			// write field
			_w.WriteStartElement("FIELD");
			_w.WriteAttributeString("name", f.Name);
			if (_valuesAsAtts)
			{
				_w.WriteAttributeString("value", text);
			}
			else
			{
				_w.WriteString(text);
			}
			_w.WriteEndElement();
		}

		// starting ovelays: ignore all fields after this
		override public void StartOverlays()
		{
			_overlay = true;
		}

		// this format is not paged
		override public bool IsPaged() 
		{
			return false; 
		}

		// this format does not rely on page images
		override public bool UsesImages()
		{
			return false; 
		}
	}
}
