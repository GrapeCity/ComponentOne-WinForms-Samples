using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace OwnerDraw
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.FlexGrid.C1FlexGrid _flex;
        private System.Windows.Forms.PictureBox _picBkg;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this._picBkg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBkg)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(624, 392);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.UseCompatibleTextRendering = true;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // _picBkg
            // 
            this._picBkg.Image = ((System.Drawing.Image)(resources.GetObject("_picBkg.Image")));
            this._picBkg.Location = new System.Drawing.Point(173, 474);
            this._picBkg.Name = "_picBkg";
            this._picBkg.Size = new System.Drawing.Size(180, 45);
            this._picBkg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._picBkg.TabIndex = 1;
            this._picBkg.TabStop = false;
            this._picBkg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(624, 392);
            this.Controls.Add(this._picBkg);
            this.Controls.Add(this._flex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: OwnerDraw and AutoSize";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._picBkg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // initialize grid
            _flex.Cols[0].Width = 22;
            _flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            _flex.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            _flex.Styles.Normal.WordWrap = true;
            _flex.Styles.Normal.ImageAlign = C1.Win.FlexGrid.ImageAlignEnum.Stretch;

            // populate grid
            Random rnd = new Random();
            for (int c = 1; c < _flex.Cols.Count; c++)
            {
                _flex.Cols[c].DataType  = typeof(int);
                _flex.Cols[c].TextAlign = C1.Win.FlexGrid.TextAlignEnum.LeftCenter;
                for (int r = 1; r < _flex.Rows.Count; r++)
                    _flex[r, c] = rnd.Next(1000000);
            }

            // autosize first column
            _flex.AutoSizeCol(1);
        }
        private void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
        {
            // custom paint cells that contain integers
            if (_flex[e.Row, e.Col] is int)
            {
				// show value as a number and as text
				int i = (int)_flex[e.Row, e.Col];
                e.Text = string.Format("{0:#,##0}: {1}", i, IntToString(i));

				// show background image
				if (e.Style.BackColor != _flex.Styles.Highlight.BackColor)
					e.Image = _picBkg.Image;
            }
        }

        // -----------------------------------------------------------------------------------------
        // convert integers into text (e.g. 2 -> "two")
        private static Hashtable _numbers = null;
        private string IntToString(int i)
        {
            if (_numbers == null)
            {
                _numbers = new Hashtable();
                _numbers.Add( 0, "zero");
                _numbers.Add( 1, "one");
                _numbers.Add( 2, "two");
                _numbers.Add( 3, "three");
                _numbers.Add( 4, "four");
                _numbers.Add( 5, "five");
                _numbers.Add( 6, "six");
                _numbers.Add( 7, "seven");
                _numbers.Add( 8, "eight");
                _numbers.Add( 9, "nine");
                _numbers.Add(10, "ten");
                _numbers.Add(11, "eleven");
                _numbers.Add(12, "twelve");
                _numbers.Add(13, "thirteen");
                _numbers.Add(14, "fourteen");
                _numbers.Add(15, "fifteen");
                _numbers.Add(16, "sixteen");
                _numbers.Add(17, "seventeen");
                _numbers.Add(18, "eighteen");
                _numbers.Add(19, "nineteen");
                _numbers.Add(20, "twenty");
                _numbers.Add(30, "thirty");
                _numbers.Add(40, "fourty");
                _numbers.Add(50, "fifty");
                _numbers.Add(60, "sixty");
                _numbers.Add(70, "seventy");
                _numbers.Add(80, "eighty");
                _numbers.Add(90, "ninety");
            }

            string s = string.Empty;
            
            // billions
            int j = i / 1000000000;
            if (j > 0)
                s = AppendNumber(s, IntToString(j) + " billion");
            i -= j * 1000000000;

            // millions
            j = i / 1000000;
            if (j > 0)
                s = AppendNumber(s, IntToString(j) + " million");
            i -= j * 1000000;

            // thousands
            j = i / 1000;
            if (j > 0)
                s = AppendNumber(s, IntToString(j) + " thousand");
            i -= j * 1000;

            // hundreds
            j = i / 100;
            if (j > 0)
                s = AppendNumber(s, IntToString(j) + " hundred");
            i -= j * 100;

            // tens
            if (i >= 20)
            {
                j = (i / 10) * 10;
                s = AppendNumber(s, (string)_numbers[j]);
                i -= j;
            }

            // teens/units
            if (i > 0 || s.Length == 0)
                s = AppendNumber(s, (string)_numbers[i]);

            // done
            return s;
        }
        private string AppendNumber(string s, string number)
        {
            if (s.Length > 0) s += " ";
            s += number;
            return s;
        }
	}
}
