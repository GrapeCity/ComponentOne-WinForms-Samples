using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SelectionMode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid2;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid3;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid4;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid5;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid7;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
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
			this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1FlexGrid2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1FlexGrid3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1FlexGrid4 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1FlexGrid5 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.c1FlexGrid6 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.c1FlexGrid7 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.label6 = new System.Windows.Forms.Label();
			this.c1FlexGrid8 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid8)).BeginInit();
			this.SuspendLayout();
			// 
			// c1FlexGrid1
			// 
			this.c1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid1.Location = new System.Drawing.Point(8, 24);
			this.c1FlexGrid1.Name = "c1FlexGrid1";
			this.c1FlexGrid1.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid1.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid1.TabIndex = 0;
			this.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid1.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid1.Tree.NodeImageCollapsed")));
			this.c1FlexGrid1.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid1.Tree.NodeImageExpanded")));
			this.c1FlexGrid1.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid1.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid1.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid1.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid1.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid1.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// c1FlexGrid2
			// 
			this.c1FlexGrid2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid2.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid2.Location = new System.Drawing.Point(272, 24);
			this.c1FlexGrid2.Name = "c1FlexGrid2";
			this.c1FlexGrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.c1FlexGrid2.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid2.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid2.TabIndex = 0;
			this.c1FlexGrid2.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid2.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid2.Tree.NodeImageCollapsed")));
			this.c1FlexGrid2.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid2.Tree.NodeImageExpanded")));
			this.c1FlexGrid2.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid2.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid2.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid2.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid2.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid2.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// c1FlexGrid3
			// 
			this.c1FlexGrid3.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid3.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid3.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid3.Location = new System.Drawing.Point(272, 176);
			this.c1FlexGrid3.Name = "c1FlexGrid3";
			this.c1FlexGrid3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.c1FlexGrid3.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid3.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid3.TabIndex = 0;
			this.c1FlexGrid3.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid3.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid3.Tree.NodeImageCollapsed")));
			this.c1FlexGrid3.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid3.Tree.NodeImageExpanded")));
			this.c1FlexGrid3.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid3.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid3.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid3.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid3.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid3.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// c1FlexGrid4
			// 
			this.c1FlexGrid4.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid4.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid4.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid4.Location = new System.Drawing.Point(8, 176);
			this.c1FlexGrid4.Name = "c1FlexGrid4";
			this.c1FlexGrid4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this.c1FlexGrid4.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid4.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid4.TabIndex = 0;
			this.c1FlexGrid4.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid4.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid4.Tree.NodeImageCollapsed")));
			this.c1FlexGrid4.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid4.Tree.NodeImageExpanded")));
			this.c1FlexGrid4.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid4.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid4.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid4.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid4.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid4.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// c1FlexGrid5
			// 
			this.c1FlexGrid5.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid5.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid5.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid5.Location = new System.Drawing.Point(272, 328);
			this.c1FlexGrid5.Name = "c1FlexGrid5";
			this.c1FlexGrid5.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ColumnRange;
			this.c1FlexGrid5.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid5.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid5.TabIndex = 0;
			this.c1FlexGrid5.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid5.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid5.Tree.NodeImageCollapsed")));
			this.c1FlexGrid5.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid5.Tree.NodeImageExpanded")));
			this.c1FlexGrid5.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid5.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid5.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid5.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid5.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid5.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// c1FlexGrid6
			// 
			this.c1FlexGrid6.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid6.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid6.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid6.Location = new System.Drawing.Point(8, 328);
			this.c1FlexGrid6.Name = "c1FlexGrid6";
			this.c1FlexGrid6.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Column;
			this.c1FlexGrid6.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid6.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid6.TabIndex = 0;
			this.c1FlexGrid6.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid6.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid6.Tree.NodeImageCollapsed")));
			this.c1FlexGrid6.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid6.Tree.NodeImageExpanded")));
			this.c1FlexGrid6.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid6.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid6.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid6.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid6.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid6.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Default";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(272, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cell";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Row";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(272, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "RowRange";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(536, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "CellRange";
			// 
			// c1FlexGrid7
			// 
			this.c1FlexGrid7.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid7.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid7.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid7.Location = new System.Drawing.Point(536, 24);
			this.c1FlexGrid7.Name = "c1FlexGrid7";
			this.c1FlexGrid7.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.c1FlexGrid7.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid7.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid7.TabIndex = 0;
			this.c1FlexGrid7.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid7.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid7.Tree.NodeImageCollapsed")));
			this.c1FlexGrid7.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid7.Tree.NodeImageExpanded")));
			this.c1FlexGrid7.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid7.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid7.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid7.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid7.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid7.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(536, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "ListBox";
			// 
			// c1FlexGrid8
			// 
			this.c1FlexGrid8.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.c1FlexGrid8.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.c1FlexGrid8.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1FlexGrid8.Location = new System.Drawing.Point(536, 176);
			this.c1FlexGrid8.Name = "c1FlexGrid8";
			this.c1FlexGrid8.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
			this.c1FlexGrid8.Size = new System.Drawing.Size(256, 128);
			this.c1FlexGrid8.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Arial, 6pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.c1FlexGrid8.TabIndex = 0;
			this.c1FlexGrid8.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.c1FlexGrid8.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid8.Tree.NodeImageCollapsed")));
			this.c1FlexGrid8.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("c1FlexGrid8.Tree.NodeImageExpanded")));
			this.c1FlexGrid8.RowColChange += new System.EventHandler(this.c1FlexGrid1_RowColChange);
			this.c1FlexGrid8.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterRowColChange);
			this.c1FlexGrid8.BeforeRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeRowColChange);
			this.c1FlexGrid8.SelChange += new System.EventHandler(this.c1FlexGrid1_SelChange);
			this.c1FlexGrid8.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_BeforeSelChange);
			this.c1FlexGrid8.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.c1FlexGrid1_AfterSelChange);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 312);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 16);
			this.label7.TabIndex = 1;
			this.label7.Text = "Col";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(272, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 16);
			this.label8.TabIndex = 1;
			this.label8.Text = "ColRange";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(544, 328);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(224, 32);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "No Rows";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(544, 368);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(224, 32);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "No Cols";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBox1,
																		  this.label1,
																		  this.c1FlexGrid1,
																		  this.c1FlexGrid2,
																		  this.c1FlexGrid3,
																		  this.c1FlexGrid4,
																		  this.c1FlexGrid5,
																		  this.c1FlexGrid6,
																		  this.label2,
																		  this.label3,
																		  this.label4,
																		  this.label5,
																		  this.c1FlexGrid7,
																		  this.label6,
																		  this.c1FlexGrid8,
																		  this.label7,
																		  this.label8,
																		  this.checkBox2});
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid8)).EndInit();
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

		int _i = 0;
		private void c1FlexGrid1_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_AfterSelChange " + _i.ToString());
			Console.WriteLine("-------------------\n");
		}

		private void c1FlexGrid1_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_AfterRowColChange " + _i.ToString());
		}

		private void c1FlexGrid1_BeforeRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_BeforeRowColChange " + _i.ToString());
		}

		private void c1FlexGrid1_BeforeSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_BeforeSelChange " + _i.ToString());
		}

		private void c1FlexGrid1_RowColChange(object sender, System.EventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_RowColChange " + _i.ToString());
		}

		private void c1FlexGrid1_SelChange(object sender, System.EventArgs e)
		{
			_i++;
			Console.WriteLine("c1FlexGrid1_SelChange " + _i.ToString());
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			int n = checkBox1.Checked? 1: 50;
			c1FlexGrid1.Rows.Count = n;
			c1FlexGrid2.Rows.Count = n;
			c1FlexGrid3.Rows.Count = n;
			c1FlexGrid4.Rows.Count = n;
			c1FlexGrid5.Rows.Count = n;
			c1FlexGrid6.Rows.Count = n;
			c1FlexGrid7.Rows.Count = n;
			c1FlexGrid8.Rows.Count = n;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			int n = checkBox2.Checked? 1: 10;
			c1FlexGrid1.Cols.Count = n;
			c1FlexGrid2.Cols.Count = n;
			c1FlexGrid3.Cols.Count = n;
			c1FlexGrid4.Cols.Count = n;
			c1FlexGrid5.Cols.Count = n;
			c1FlexGrid6.Cols.Count = n;
			c1FlexGrid7.Cols.Count = n;
			c1FlexGrid8.Cols.Count = n;
		}
	}
}
