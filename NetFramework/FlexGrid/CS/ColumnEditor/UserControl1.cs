using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ColumnEditor
{
	/// <summary>
	/// Summary description for UserControl1.
	/// To allow the column editor to work at design time, the UserControl
	/// must implement ISupportInitialize
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl, ISupportInitialize
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Label label1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserControl1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call
		}


		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:20;}\t1{Width:20;}\t2{Width:20;}\t3{Width:20;}\t4{Width" +
    ":20;}\t5{Width:20;}\t6{Width:20;}\t7{Width:20;}\t8{Width:20;}\t9{Width:20;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(5, 72);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 21;
            this._flex.Size = new System.Drawing.Size(470, 211);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "To edit the grid columns at design-time, select the control and click the button " +
    "next to the \"GridColumns\" property.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this._flex);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(480, 288);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		// expose grid columns as a property so user can edit them at design time
		// must be get/set property, although the set will only be used during
		// initialization
		public C1.Win.C1FlexGrid.ColumnCollection GridColumns
		{
			get { return _flex.Cols; }
			set { _flex.Cols = value; }
		}

		// ISupportInitialize implementation extends initialization process to the 
		// contained grid
		void ISupportInitialize.BeginInit()
		{
			_flex.BeginInit();
		}
		void ISupportInitialize.EndInit()
		{
			_flex.EndInit();
		}

        // grid columns are persisted via hidden ColumnInfo property
        [Browsable(false), EditorBrowsableAttribute(EditorBrowsableState.Never) ]
        public string ColumnInfo
        {
            get { return _flex.ColumnInfo; }
            set { _flex.ColumnInfo = value; }
        }
    }
}
