using System;
using System.Collections;

namespace C1ReportParms
{
	/// <summary>
	/// C1ReportParameters
	/// this class parses C1Report parameterized query strings
	/// </summary>
	public class C1ReportParameters
	{
		private string    _source;
		private string    _body;
		private ArrayList _parms;
		
		// ** ctor

		public C1ReportParameters(string rs)
		{
			// save source string
			_source = rs.Trim();
			_parms  = null;

			// get parameters
			if (_source.ToUpper().StartsWith("PARAMETERS"))
			{
				int i = _source.IndexOf(';');
				if (i > -1)
				{
					_body = _source.Substring(i+1).Trim();
					ParseParameters(_source.Substring(11, i-10));
				}
			}
		}

		// ** public methods/properties

		public string Source
		{
			get { return _source; }
		}
		public string QueryString
		{
			get { return BuildQueryString(); }
		}
		public ArrayList List
		{
			get { return _parms; }	
		}
		public C1ReportParameter this [int index]
		{
			get { return (C1ReportParameter)_parms[index]; }
		}
		public C1ReportParameter this [string name]
		{
			get 
			{
				foreach (C1ReportParameter rp in _parms)
				{
					if (string.Compare(name, rp.Name, true) == 0)
						return rp;
				}
				return null;
			}
		}

		// ** utilities

		private void ParseParameters(string parms)
		{
			_parms = new ArrayList();
			int s = 0;
			int e = 0;
			string parm = "";
			while (s < parms.Length)
			{
				// eat white space
				while (parms[s] <= ' ' && s < parms.Length) s++;
				
				// handle enclosed values
				char term = (char)0;
				switch (parms[s])
				{
					case '[':  term = ']';  break;
					case '#':  term = '#';  break;
					case '\'': term = '\''; break;
					case '\"': term = '\"'; break;
				}

				// found token start, now find the end
				string token;
				e = s;
				if (term != 0)
				{
					e++;
					while (parms[e] != term && e < parms.Length) e++;
					token = parms.Substring(s, e-s+1);
				}
				else
				{
					while (parms[e] != ',' && parms[e] != ';' && parms[e] > ' ' && e < parms.Length) e++;
					token = parms.Substring(s, e-s);
				}

				// found token, add to current parameter descriptor
				if (parm.Length > 0) parm += '\t';
				parm += token;

				// found end of parameter, add to parameter list
				if (parms[e] == ';' || parms[e] == ',')
				{
					_parms.Add(new C1ReportParameter(parm));
					parm = "";
				}

				// look for more
				s = e+1;
			}
		}
		private string BuildQueryString()
		{
			// no parameters? easy
			if (_parms == null)
				return _body;

			// replace parameter values in body
			string rs = _body;
			foreach (C1ReportParameter rp in _parms)
			{
				// enclose value in delimiters if they were not supplied
				// ("#" for dates, "'" for strings)
				string val = rp._value;
				if (rp._type == typeof(DateTime))
					if (val.Length < 2 || val[0] != '#' || val[val.Length-1] != '#')
						val = "#" + val + "#";
				if (rp._type == typeof(string))
					if (val.Length < 2 || val[0] != '\'' || val[val.Length-1] != '\'')
						val = "\'" + val + "\'";

				// replace parameter with its value
				// (this takes into account EndDate as well as [EndDate])
				rs = ReplaceAfter(rs, "WHERE", "[" + rp._name + "]", val);
				rs = ReplaceAfter(rs, "WHERE", rp._name, val);
			}

			// done
			return rs;
		}
		private string ReplaceAfter(string src, string after, string find, string replace)
		{
			// find position of 'after' word
			string up = src.ToUpper();
			after = after.ToUpper();
			int pos = up.IndexOf(after);
			while (pos > -1)
			{
				int end = pos + after.Length;
				if (end < src.Length && src[end] > ' ')
					pos = up.IndexOf(after, pos+1);
				else
					break;
			}

			// break string into 'before' and 'after' parts
			string bef, aft;
			if (pos > 0)
			{
				pos += after.Length;
				bef = src.Substring(0, pos);
				aft = src.Substring(pos);
			}
			else
			{
				bef = "";
				aft = src;
			}

			// make replacement in 'after' part
			aft = aft.Replace(find, replace);

			// join them together again
			return bef + aft;
		}
	}

	/// <summary>
	/// C1ReportParameter class
	/// encapsulates individual parameters in a C1ReportParameters object
	/// </summary>
	public class C1ReportParameter
	{
		internal string		_name;
		internal string		_value;
		internal Type		_type;

		// ** ctor

		public C1ReportParameter(string str)
		{
			// split parameter into pieces
			string[] s = str.Split('\t');

			// save parameter name
			_name = "";
			if (s.Length > 0)
				_name = Unbracket(s[0]);

			// save parameter type
			_type = typeof(string);
			if (s.Length > 1)
			{
				switch (s[1].ToLower())
				{
					case "date":		_type = typeof(DateTime);	break;
					case "datetime":	_type = typeof(DateTime);	break;
					case "bit":			_type = typeof(int);		break;
					case "byte":		_type = typeof(int);		break;
					case "int":			_type = typeof(int);		break;
					case "short":		_type = typeof(int);		break;
					case "long":		_type = typeof(int);		break;
					case "currency":	_type = typeof(int);		break;
					case "single":		_type = typeof(float);		break;
					case "double":		_type = typeof(double);		break;
					case "ieeesingle":	_type = typeof(float);		break;
					case "ieeedouble":	_type = typeof(double);		break;
					case "text":		_type = typeof(string);		break;
					case "string":		_type = typeof(string);		break;
					case "boolean":		_type = typeof(bool);		break;
					case "bool":		_type = typeof(bool);		break;
					case "yesno":		_type = typeof(bool);		break;
				}
			}

			// save parameter value
			_value = "";
			if (s.Length > 2)
				_value = Unquote(s[2]);
		}

		// ** public methods/properties

		public string Name
		{
			get { return _name; }
		}
		public Type Type
		{
			get { return _type; }
		}
		public string Value
		{
			get { return _value; }
			set { _value = value; }
		}

		// ** util

		private static string Unbracket(string s)
		{
			if (s != null && s.StartsWith("[") && s.EndsWith("]"))
				return s.Substring(1, s.Length-2);
			return s;
		}
		private static string Unquote(string s)
		{
			if (s != null && s.Length >= 2 && 
				(s.StartsWith("\"") && s.EndsWith("\"")) ||
				(s.StartsWith("'")  && s.EndsWith("'"))  ||
				(s.StartsWith("#")  && s.EndsWith("#")))
				return s.Substring(1, s.Length-2);
			return s;
		}
	}
}
