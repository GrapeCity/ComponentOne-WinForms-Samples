using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.IO;
using System.Globalization;
using C1.Win.FlexGrid;

namespace CustomSort
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGrid _flex;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
			this._flex.ColumnInfo = "4,1,0,0,75,75,Columns:0{Width:24;}\t1{Width:188;Caption:\"Name\";}\t2{Width:114;TextAlign:CenterCenter;Text" +
                "AlignFixed:CenterCenter;Caption:\"Last Modified\";}\t3{Width:94;TextAlign:RightCent" +
                "er;TextAlignFixed:RightCenter;Caption:\"Size\";}";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(5, 5);
            this._flex.Name = "_flex";
            this._flex.Rows.Count = 500;
            this._flex.Size = new System.Drawing.Size(481, 430);
            this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
            this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
            this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
            this._flex.BeforeSort += new C1.Win.FlexGrid.SortColEventHandler(this._flex_BeforeSort);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(491, 440);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._flex});
            this.DockPadding.All = 5;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom sorting";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        // populate grid
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // initialize columns: file name, date, size
            _flex.Rows.Count = 1;
            _flex.Cols.Count = 4;
            _flex.Cols[0].Width = _flex.Rows.DefaultSize;
            
            Column c = _flex.Cols[1];
            c.Name = c.Caption = "Name";
            c.DataType = typeof(string);

            c = _flex.Cols[2];
            c.Name = c.Caption = "Last Mod";
            c.DataType = typeof(DateTime);
            c.TextAlign = c.TextAlignFixed = TextAlignEnum.CenterCenter;

            c = _flex.Cols[3];
            c.Name = c.Caption = "Size";
            c.DataType = typeof(MySize);
            c.TextAlign = c.TextAlignFixed = TextAlignEnum.RightCenter;

            // populate grid
            //
            // note: MySize has a TypeConverter that knows how to convert from longs,
            // so we can assign any longs (fi.Lenght) directly to the "Size" column.
            //
            string sysDir = @"c:\winnt\system32";
            if (!Directory.Exists(sysDir))
            {
                sysDir = @"c:\windows\system32";
            }
            DirectoryInfo di = new DirectoryInfo(sysDir);
            _flex.Rows.Count = 1;
            foreach (FileInfo fi in di.GetFiles())
            {
                _flex.AddItem(new object[] { null, fi.Name, fi.LastWriteTime, fi.Length });
            }
        }

        private void _flex_BeforeSort(object sender, C1.Win.FlexGrid.SortColEventArgs e)
        {
            // use custom sorting for column "Name" (sort files by extension)
            if (_flex.Cols[e.Col].Name == "Name")
            {
                // hadle the sort ourselves
                Cursor = Cursors.WaitCursor;
                _flex.Sort(new FileNameComparer(_flex, e.Order));
                Cursor = null;

                // tell control we handled it
                e.Handled = true;
            }
        }
	}

    /// <summary>
    /// MySize encapsulates a long and formats it with a scale string (meg/kilo/"")
    /// it provides implicit converters and implements IComparable.
    /// </summary>
    [TypeConverter(typeof(MySizeTypeConverter))]
    class MySize : IComparable
    {
        long _val;

        public MySize(long sz)
        {
            _val = sz;
        }

        override public string ToString()
        {
            // format megs
            if (_val > 10 * 1024 * 1024)
                return string.Format("{0:#,###}m", _val / 1024 / 1024);

            // format ks
            if (_val > 10 * 1024)
                return string.Format("{0:#,###}k", _val / 1024);

            // format plain
            return string.Format("{0:#,###}", _val);
        }

        // provide implicit conversions to/from long
        public static implicit operator long(MySize sz) 
        {
            return sz._val;
        }
        public static implicit operator MySize(long sz) 
        {
            return new MySize(sz);
        }

        // comparer
        public int CompareTo(object obj)
        {
            long l1 = this;
            long l2 = (MySize)obj;
            if (l1 > l2) return 1;
            if (l1 < l2) return -1;
            return 0;
        }
    }

    /// <summary>
    /// This MySizeTypeConverter provides formattig/conversions for the MySize class
    /// (used when assigning longs/strings to grid cells)
    /// </summary>
    public class MySizeTypeConverter : TypeConverter
    {
        override public bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) 
        {
            if (sourceType == typeof(string)) 
                return true;

            if (sourceType == typeof(long)) 
                return true;

            return base.CanConvertFrom(context, sourceType);
        }
        override public object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) 
        {
            if (value is string) 
            {
                string s = (string)value;

                int i = s.IndexOf('m');
                if (i > -1)
                    return new MySize(long.Parse(s.Substring(0, i), NumberStyles.Any) * 1024 * 1024);

                i = s.IndexOf('k');
                if (i > -1)
                    return new MySize(long.Parse(s.Substring(0, i), NumberStyles.Any) * 1024);

                return new MySize(long.Parse((string)value, NumberStyles.Any));
            }

            if (value is long) 
                return new MySize((long)value);

            return base.ConvertFrom(context, culture, value);
        }
        override public object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) 
        {  
            if (destinationType == typeof(string)) 
                return ((MySize)value).ToString();

            if (destinationType == typeof(long)) 
                return (long)((MySize)value);

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }


    // custom comparer used for grid sorting
    // the Compare member compares file names based on their extension
    //
    // note: This is a pretty slow comparison, because it extracts the
    // extension for each file name every time. It would be much faster
    // to create a separate column just for the file extension and use 
    // that instead. But that's not always possible...
    class FileNameComparer : IComparer
    {
        C1FlexGrid _flex;
        bool _desc;

        // ctor
        public FileNameComparer(C1FlexGrid flex, SortFlags order)
        {
            _flex = flex;
            _desc = ((order & SortFlags.Descending) != 0);
        }
        
        // IComparer
        public int Compare(object r1, object r2)
        {
            // get file names
            string s1 = (string)_flex[((Row)r1).Index, "Name"];
            string s2 = (string)_flex[((Row)r2).Index, "Name"];

            // compare extensions
            int icmp = string.Compare(Path.GetExtension(s1), Path.GetExtension(s2), true);

            // return sort order (ascending or descending)
            return (_desc)? -icmp: icmp;
        }
    }
}
