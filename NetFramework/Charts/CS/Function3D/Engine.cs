using System;
using System.Collections;
using System.Xml.Serialization;

using C1.Win.C1Chart3D;

namespace Function3D
{
	/// <summary>
	/// Summary description for Engine.
	/// </summary>
		public class Range : ICloneable
		{
			float xmin = -10, ymin = -10, xmax = 10, ymax = 10;
			int nx =11, ny= 11;

			public object Clone() //!!# Implements ICloneable.Clone
			{
				return this.MemberwiseClone();
			}


			[XmlAttribute]
			public float MinX
			{
				get{ 	return xmin;}
				set{ xmin = value;}
			}
			
			[XmlAttribute]
			public float MinY
			{
				get{ 	return ymin;}
				set{ ymin = value;}
			}
			
			[XmlAttribute]
			public float MaxX
			{
				get{ 	return xmax;}
				set{ xmax = value;}
			}
			
			[XmlAttribute]
			public float MaxY
			{
				get{ 	return ymax;}
				set{ ymax = value;}
			}
			
			[XmlAttribute]
			public int NumX
			{
				get{ 	return nx;}
				set{ nx = value;}
			}
			
			[XmlAttribute]
			public int NumY
			{
				get{ 	return ny;}
				set{ ny = value;}
			}

			internal float DeltaX 
			{
				get{ 	return (xmax - xmin)/(nx-1);}
			}
			internal float DeltaY 
			{
				get{ 	return (ymax - ymin)/(ny-1);}
			}
		}
	
		public class FunctionInfo
		{
			string[] m_code = null;
			string m_name = String.Empty;
			Range m_range = new Range();

			public FunctionInfo()	{	}

			public FunctionInfo( string name, string[] code, Range range)
			{
				m_name = name;
				m_code = code;
				Range = range;
			}

			//[XmlAttribute]
			public string[] Code
			{
				get
				{
					return m_code;
				}
				set
				{
					m_code = value;
				}
			}

			[XmlAttribute]
			public string Name
			{
				get
				{
					return m_name;
				}
				set
				{
					m_name = value;
				}
			}

			public Range Range
			{
				get
				{
					return (Range)m_range.Clone();
				}
				set
				{
					m_range = (Range)value.Clone();
				}
			}
		}

		public class FunctionInfoCollection: CollectionBase
		{
			public FunctionInfo this[int i]
			{
				get
				{
					return (FunctionInfo)List[i];
				}
				set
				{
					List[i] = value;
				}
			}

			public int Add( FunctionInfo fi)
			{
				return List.Add( fi);
			}

			public int FindName( string s)
			{
				for( int i=0; i<Count; i++)
					if( s.Equals( this[i].Name))
						return i;
				return -1;
			}
		}

		public class Engine
		{
			FunctionEvaluator func = new FunctionEvaluator();
			public Engine()
			{
			}

			public Chart3DDataSetGrid Run( string text, Range range)
			{
				func.Text = text;

				if(!func.Compile())
					return null;

				float dx = range.DeltaX;
				float dy = range.DeltaY;
				float[,] data = (float[,])Array.CreateInstance( typeof(float), range.NumX, range.NumY);
				for( int i=0; i<range.NumX; i++)
				{
					for( int j=0; j<range.NumY; j++)
					{
						data[i,j] = (float)func.Invoke( range.MinX + i*dx, range.MinY + j*dy);
					}
				}

				return new Chart3DDataSetGrid( range.MinX, range.MinY, dx, dy, data);
			}

			public string[] Errors
			{
				get
				{
					return func.Errors;
				}
			}
		}
	}
