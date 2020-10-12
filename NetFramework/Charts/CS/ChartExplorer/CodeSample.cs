using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace SampleCenter
{
	public interface IChartSample
	{
		void Load( C1.Win.C1Chart.C1Chart chart);
		void Unload( C1.Win.C1Chart.C1Chart chart);
		void Dispose();
	}

	public class ChartSample : IChartSample
	{
		Panel _panel = null;
		ArrayList _al = new ArrayList();
		protected C1.Win.C1Chart.C1Chart c1chart1 = null;

		protected void FillComboBox( ComboBox cb, Type type)
		{
			cb.Items.Clear();

			Array objs = Enum.GetValues( type);

			foreach( object obj in objs)
				cb.Items.Add( obj);
		}

		void Add( Control control)
		{
			if( _panel!=null)
			{
				_al.Add( control);
				_panel.Controls.Add( control);

				if( ! (control is TrackBar) )
					_panel.DockPadding.Top = Math.Max( _panel.DockPadding.Top, control.Height);
			}
		}

		virtual protected Control[] Controls
		{
			get
			{
				return null;
			}
		}
		
		public virtual void Load( C1.Win.C1Chart.C1Chart chart)
		{
			c1chart1 = chart;
			Control[] controls = Controls;

			if( controls!=null)
			{
				_panel = chart.Parent as System.Windows.Forms.Panel;
				_al.Clear();

				foreach( Control control in controls)
					Add( control);
			}
		}
		
		public virtual void Unload( C1.Win.C1Chart.C1Chart chart)
		{
			if( _panel!=null)
			{
				foreach( Control control in _al)
					_panel.Controls.Remove( control);

				//_panel.DockPadding.Top = 0;
			}
		}

		public virtual void Dispose()
		{
			if(_al.Count > 0)
			{
				Unload(null);
				foreach(Control control in _al)
					control.Dispose();

				_al.Clear();
			}
		}
	}

	/// <summary>
	/// Summary description for CodeSample.
	/// </summary>
	public class CodeSample
	{
		static string FolderCS = "CS";
		//static string FolderVB = "VB";

		string _text = "";
		string _name = "";
		string _parentName = "";
		string _info = "";
		string _codeCS = "";
		string _codeVB = "";
		IChartSample _sample = null;

		public CodeSample()
		{
		}

		public CodeSample(string name, string text, string info)
		{
			_name = name;
			_text = text;
			_info = info;
		}

		[XmlAttribute()]
		[DefaultValue("")]
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		[XmlAttribute()]
		[DefaultValue("")]
		public string ParentName
		{
			get
			{
				return _parentName;
			}
			set
			{
				_parentName = value;
			}
		}

		[DefaultValue("")]
		public string CodeCS
		{
			get
			{
				return _codeCS;
			}
			set
			{
				_codeCS = value;

				string s = CodeSample.GetTagContent( _codeCS, "Info", @"//", true);
				if( s.Length>0)
					Info = s;
			}
		}

		[DefaultValue("")]
		public string CodeVB
		{
			get
			{
				return _codeVB;
			}
			set
			{
				_codeVB = value;
			}
		}

		[DefaultValue("")]
		public string Info
		{
			get
			{
				return _info;
			}
			set
			{
				_info = value;
			}
		}

		[DefaultValue("")]
		[XmlAttribute()]
		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				_text = value;
			}
		}

		[XmlIgnore()]
		public IChartSample Sample
		{
			get
			{
				if( _sample==null)
				{
					foreach( IChartSample cs in ChartSamples.Samples)
					{
						//if( cs.GetType().Name == Path.GetFileName(Name).Replace(' ', '_'))
						if( cs.GetType().Name == Text.Replace(' ', '_'))
						{
							_sample = cs;
							break;
						}
					}
				}

				return _sample;
			}
		}

		static int CountTabs( string s)
		{
			int i=0;
			for( ; ;i++)
			{
				if( s.StartsWith("\t"))
					s = s.Remove( 0, 1);
				else if( s.StartsWith(" "))
					s = s.Remove( 0, 1);
				else
					break;
			}

			return i;
		}

		static string RemoveTabs( string s, int cnt)
		{
			for( int i=0;  i<cnt; i++)
			{
				if( s.StartsWith("\t"))
					s = s.Remove( 0, 1);
				else if( s.StartsWith(" "))
					s = s.Remove( 0, 1);
				else
					break;
			}

			return s;
		}

		public static string GetTagContent(string code, string tag, string comment)
		{
			return GetTagContent( code, tag, comment, false);
		}

		public static string GetTagContent(string code, string tag, string comment, bool removecomments)
		{
			string start = comment + "<" + tag + ">";
			string end = comment + "</" + tag + ">";

			string[] ss = code.Split( new char[] { '\n'});

			StringBuilder sb = new StringBuilder();

			bool inTag = false;
			int ntabs = -1;

			for( int i=0; i<ss.Length; i++)
			{
				if( inTag)
				{
					//if( ss[i].Trim().StartsWith( end))
					if( ss[i].IndexOf( end)!=-1) // VB converter mixes up lines
					{
						ntabs = -1;
						inTag = false;
					}
					else
					{
						if( ntabs == -1)
							ntabs = CountTabs( ss[i]);
						
						ss[i] = RemoveTabs( ss[i], ntabs);
						if( removecomments)
						{
							if( ss[i].StartsWith( comment))
								ss[i] = ss[i].Remove( 0, comment.Length);
						}

						if( ss[i].IndexOf( @"End Sub 'Load")!=-1)
							continue;

						if( ss[i].IndexOf( "End Class") == -1 ) // remove end line in VB files
						{
							sb.Append( ss[i]);
							sb.Append( "\n");
						}
					}
				}
				else
				{
					if( ss[i].Trim().StartsWith(  start))
						inTag = true;
				}
			}

			return sb.ToString();
		}

#if DEBUG

		public void Dispose()
		{
			if(_sample != null)
				_sample.Dispose();
		}

		public void LoadCodeSnippets(string basefolder)
		{
			CodeCS = LoadCodeSnippet( basefolder, CodeSample.FolderCS, ".cs");
			CodeVB = BuildAndLoadVBCodeSnippet( basefolder, CodeSample.FolderCS);
			//CodeVB = LoadCodeSnippet( basefolder, CodeSample.FolderVB, ".vb");
		}

		private string LoadCodeSnippet( string basefolder, string folder, string ext)
		{
			string s = "";
			//string fn = basefolder + "\\" + folder + "\\" + Name + ext;
			string fn = Name + ext;
			if( File.Exists( fn))
			{
				StreamReader sr = null;
				try
				{
					sr = new StreamReader( fn);
					s = sr.ReadToEnd();
				}
				finally
				{
					if( sr!=null)
						sr.Close();
				}
			}

			return s;
		}

		public static string BuildAndCreateVBCodeSnippetFromCSFile(string csfn)
		{
			string s = "";
			string vbfn = csfn.Replace(".cs", ".vb");

			if( File.Exists( csfn))
			{
				// run vb converter
				string csfn_wo_dir = Path.GetFileName( csfn);
				string vbfn_wo_dir = Path.GetFileName( vbfn);

				System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo( "cstovb.exe", "\"" + csfn_wo_dir + "\"" + " /out:" + "\"" + vbfn_wo_dir + "\"");
				psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				psi.WorkingDirectory = Path.GetFullPath( Path.GetDirectoryName( csfn));

				System.Diagnostics.Process process = System.Diagnostics.Process.Start( psi);
				process.WaitForExit( 10000);


				if( File.Exists( vbfn))
				{
					StreamReader sr = null;
					try
					{
						sr = new StreamReader( vbfn);
						s = AdjustVBString( sr.ReadToEnd());
					}
					finally
					{
						if( sr!=null)
							sr.Close();
					}
				}
			}

			return s;
		}

		private string BuildAndLoadVBCodeSnippet( string basefolder, string folder)
		{
			string s = "";
			string csfn = Name + ".cs";
			string vbfn = Name + ".vb";

			if( File.Exists( csfn))
			{
				// run vb converter
				if( !File.Exists( vbfn) || File.GetLastWriteTime( csfn) > File.GetLastWriteTime( vbfn))
				{
					string csfn_wo_dir = Path.GetFileName( csfn);
					string vbfn_wo_dir = Path.GetFileName( vbfn);

					System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo( "cstovb.exe", "\"" + csfn_wo_dir + "\"" + " /out:" + "\"" + vbfn_wo_dir + "\"");
					psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
					psi.WorkingDirectory = Path.GetFullPath( Path.GetDirectoryName( csfn));

					System.Diagnostics.Process process = System.Diagnostics.Process.Start( psi);
					process.WaitForExit( 10000);
				}

				if( File.Exists( vbfn))
				{
					StreamReader sr = null;
					try
					{
						sr = new StreamReader( vbfn);
						s = AdjustVBString( sr.ReadToEnd());
					}
					finally
					{
						if( sr!=null)
							sr.Close();
					}
				}
			}

			return s;
		}

		private static string AdjustVBString( string vbs)
		{
			string s = vbs;
			
			s =	s.Replace( "Dim x(n) As Double", "Dim x(n-1) As Double");
			s = s.Replace( "Dim y(n) As Double", "Dim y(n-1) As Double");
			s =	s.Replace( "Dim x1(n) As Double", "Dim x1(n-1) As Double");
			s = s.Replace( "Dim y1(n) As Double", "Dim y1(n-1) As Double");
			s =	s.Replace( "Dim x2(n) As Double", "Dim x2(n-1) As Double");
			s = s.Replace( "Dim y2(n) As Double", "Dim y2(n-1) As Double");
			s =	s.Replace( "Dim x3(n) As Double", "Dim x3(n-1) As Double");
			s = s.Replace( "Dim y3(n) As Double", "Dim y3(n-1) As Double");
			return s;
		}
#endif
	}

	public class CodeSamplesCollection : CollectionBase
	{
		public CodeSample this[int i]
		{
			get
			{
				return (CodeSample)List[i];
			}
			set
			{
				List[i] = value;
			}
		}

		public int Add( CodeSample cs)
		{
			return List.Add( cs);
		}

		public int Add( CodeSample cs, CodeSample parent)
		{
			if( parent!=null)
				cs.ParentName = parent.Name;
			else
				cs.ParentName = "";
			return Add( cs);
		}

		public void LoadIntoTree( TreeView tree)
		{
			tree.Nodes.Clear();

			ArrayList alr = new ArrayList();

			foreach( CodeSample cs in this)
			{
				if( cs.ParentName.Length==0)
					tree.Nodes.Add( LoadTreeNode( cs));
			}
		}

		private TreeNode LoadTreeNode( CodeSample cs)
		{
			CodeSample[] childs = GetChilds( cs.Name);

			TreeNode tn = null;

			if( childs!=null)
			{
				TreeNode[] tns = new TreeNode[childs.Length];
				for( int i=0; i<childs.Length; i++)
				{
					tns[i] = LoadTreeNode( childs[i]);
				}
				tn = new TreeNode( cs.Text, tns);
			}
			else
			{
				tn = new TreeNode( cs.Text);
				tn.ImageIndex = 2;
				tn.SelectedImageIndex = 2;
			}
			tn.Tag = cs;
			return tn;
		}

		private CodeSample[] GetChilds( string name)
		{
			ArrayList al = new ArrayList();
			foreach( CodeSample cs in this)
			{
				if( cs.ParentName == name)
					al.Add( cs);
			}

			if( al.Count > 0)
			{
				CodeSample[] css = new CodeSample[al.Count];
				al.CopyTo( css);
				return css;
			}
			else
				return null;
		}

		public static CodeSamplesCollection LoadFromStream( Stream stream)
		{
			CodeSamplesCollection csc = null;
			TextReader reader = null;
			XmlSerializer x = new XmlSerializer(typeof(CodeSamplesCollection));
			
			try
			{
				reader = new StreamReader( stream);
				csc = (CodeSamplesCollection)x.Deserialize(reader);
			}
			finally
			{
				if( reader!=null)
					reader.Close();
			}

			return csc;
		}

#if DEBUG
		public void LoadCodeSnippets(string basefolder)
		{
			foreach( CodeSample cs in this)
				cs.LoadCodeSnippets(basefolder);
		}

		public static void SaveToFile( CodeSamplesCollection csc, string fn)
		{
			XmlSerializer x = new XmlSerializer(typeof(CodeSamplesCollection));
			
			TextWriter writer = null;

			try
			{
				writer = new StreamWriter( fn);
				x.Serialize(writer, csc);
			}
			finally
			{
				if( writer!=null)
					writer.Close();
			}
		}
		
		public static void LoadFromTree(TreeNodeCollection tnc, CodeSamplesCollection csc)
		{
			if(csc == null || tnc == null || tnc.Count == 0) return;
			foreach(TreeNode tn in tnc)
			{
				CodeSample cs = tn.Tag as CodeSample;
				if(cs != null) csc.Add(cs);
				LoadFromTree(tn.Nodes, csc);
			}
		}

		public static CodeSamplesCollection LoadFromFile( string fn)
		{
			CodeSamplesCollection csc = null;
			TextReader reader = null;
			XmlSerializer x = new XmlSerializer(typeof(CodeSamplesCollection));
			
			try
			{
				reader = new StreamReader( fn);
				csc = (CodeSamplesCollection)x.Deserialize(reader);
			}
			finally
			{
				if( reader!=null)
					reader.Close();
			}

			return csc;
		}

		public void GenerateCode( string fn, string ns)
		{
			GenerateCode(fn, ns, null);
		}

		public void GenerateCode( string fn, string ns, string defaultCodeString)
		{
			TextWriter writer = null;

			try
			{
				StringBuilder sb = new StringBuilder();
				sb.Append( "public class ChartSamples\n");
				sb.Append( "{\n");
				sb.Append( "public static IChartSample[] Samples = new IChartSample[]\n");
				sb.Append( "{\n");

				writer = new StreamWriter( fn);
				writer.WriteLine( "using System;");
				writer.WriteLine( "using System.Data;");
				writer.WriteLine( "using System.Drawing;");
				writer.WriteLine( "namespace {0}", ns);
				writer.WriteLine( "{");

				if(defaultCodeString != null && defaultCodeString.Length > 0)
				{
					writer.WriteLine(defaultCodeString);
					sb.AppendFormat("new NewSample(),\n");
				}

				foreach( CodeSample cs in this)
				{
					if( cs.CodeCS.Length>0)
					{
						writer.WriteLine( cs.CodeCS);

						//string cname = Path.GetFileName(cs.Name).Replace(' ', '_');
						string cname = Path.GetFileName(cs.Text).Replace(' ', '_');

						sb.AppendFormat( "new {0}(),\n", cname);
					}
				}

				sb.Append("};\n}");

				writer.Write( sb.ToString());
				writer.WriteLine( "}");
			}
			finally
			{
				if( writer!=null)
					writer.Close();
			}
		}

		public void LoadFromFileSystem( string rdir, string ext)
		{
			LoadFromFileSystem( rdir, ext, null);
		}

		public void LoadFromFileSystem( string rdir, string ext, CodeSample parent)
		{
			string[] dirs = Directory.GetDirectories( rdir);

			Array.Sort( dirs);
			foreach( string dir in dirs)
			{
				string name = Path.GetFileName(dir);
				CodeSample cs = new CodeSample( name, name.Remove(0,3), "");
				Add( cs, parent); 
				
				LoadFromFileSystem( dir, ext, cs);
			}

			string[] files = Directory.GetFiles( rdir, "*" + ext);
			Array.Sort( files);
			foreach( string file in files)
			{
				CodeSample cs = new CodeSample( file.Remove( file.Length - ext.Length, ext.Length),
					Path.GetFileNameWithoutExtension(file).Remove(0,3), "");
				Add( cs, parent); 
			}
		}
#endif
	}
}
