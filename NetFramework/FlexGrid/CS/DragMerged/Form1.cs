using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace FlexGridTest
{
	/// <summary>
	/// Zusammendfassende Beschreibung für Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid fg;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
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
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fg = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.ColumnInfo = "0,0,0,0,0,80,Columns:";
            this.fg.Location = new System.Drawing.Point(8, 8);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 0;
            this.fg.Rows.Fixed = 0;
            this.fg.Size = new System.Drawing.Size(1036, 554);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            this.fg.Tree.Column = 0;
            this.fg.Tree.Indent = 18;
            this.fg.UseCompatibleTextRendering = true;
            this.fg.BeforeDragColumn += new C1.Win.FlexGrid.DragRowColEventHandler(this.fg_BeforeDragColumn);
            this.fg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fg_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(1044, 708);
            this.Controls.Add(this.fg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			fg.Cols.Count = 12;
			fg.Cols.Fixed = 2;
			fg.Rows.Count = 12;
			fg.Rows.Fixed = 2;

			fg.Rows[0].AllowMerging = true;
			fg.Rows[1].AllowMerging = true;
			fg.Rows[6].AllowMerging = true;
			fg.Rows[11].AllowMerging = true;

			fg.Cols[0].AllowMerging = true;
			fg.Cols[1].AllowMerging = true;
			fg.Cols[6].AllowMerging = true;
			fg.Cols[11].AllowMerging = true;
			
			fg[0,0] = " ";
			fg[0,1] = " ";
			fg[1,0] = " ";
			fg[1,1] = " ";

			for (int i = 2; i <= 6; i++)
			{
				fg[i,0] = "Continent 1";
				fg[i,1] = "Country " + i;
			}
			fg[6,1] = "Total";
			for (int i = 7; i <= 11; i++)
			{
				fg[i,0] = "Continent 2";
				fg[i,1] = "Country " + i;
			}
			fg[11,1] = "Total";
			for (int j = 2; j <= 6; j++)
			{
				fg[0,j] = "1994";
				fg[1,j] = "Dep. " + j;
			}
			fg[1,6] = "Total";
	
			for (int j = 7; j <= 11; j++)
			{
				fg[0,j] = "1995";
				fg[1,j] = "Dep. " + j;
			}
			fg[1,11] = "Total";			
		}

        int _rowDown = 0;
        private void fg_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _rowDown = fg.MouseRow;
        }
        private void fg_BeforeDragColumn(object sender, C1.Win.FlexGrid.DragRowColEventArgs e)
        {
            // get range with merged columns
            CellRange rg = fg.GetMergedRange(_rowDown, e.Col);
            
            // calculate parameters to move column range
            int indexOld = rg.LeftCol;
            int indexNew = e.Position;
            int count = rg.RightCol - rg.LeftCol + 1;
            if (indexOld < indexNew) indexNew = indexNew - count + 1;

            // move column range
            fg.Cols.MoveRange(indexOld, count, indexNew);

            // cancel default processing, we're done
            e.Cancel = true;
        }
	}
}
