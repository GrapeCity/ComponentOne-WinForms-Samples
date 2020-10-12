using System;
using System.Drawing;

namespace Function2D
{
		public class Engine
		{
			FunctionEvaluator func = new FunctionEvaluator();
			public Engine()
			{
			}

			public PointF[] Run( string text, float xmin, float xmax, int npts)
			{
				func.Text = text;

				if(!func.Compile())
					return null;

				PointF[] data = (PointF[])Array.CreateInstance( typeof(PointF), npts);
				float dx = (xmax-xmin)/(npts-1);
				for( int i=0; i<npts; i++)
				{
					data[i].X = xmin + dx*i;
					data[i].Y = (float)func.Invoke( data[i].X);
				}

				return data;
			}

			public string[] Errors
			{
				get
				{
					return func.Errors;
				}
			}

			public bool Compile( string text)
			{
				func.Text = text;

				return func.Compile();
			}
		}
	}
