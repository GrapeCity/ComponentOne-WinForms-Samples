Namespace CustomUI
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.splitContainer1 = New SplitContainer()
			Me.toolStrip1 = New ToolStrip()
			Me.toolStripLabel2 = New ToolStripLabel()
			Me._btnSalesperson = New ToolStripButton()
			Me._btnProduct = New ToolStripButton()
			Me._btnCountry = New ToolStripButton()
			Me.toolStripSeparator2 = New ToolStripSeparator()
			Me.toolStripLabel3 = New ToolStripLabel()
			Me._btnExpensive = New ToolStripButton()
			Me._btnModerate = New ToolStripButton()
			Me._btnInexpensive = New ToolStripButton()
			Me._btnAllPrices = New ToolStripButton()
			Me.toolStripSeparator3 = New ToolStripSeparator()
			Me.toolStripButton5 = New ToolStripButton()
			Me.panel1 = New Panel()
			Me.label1 = New Label()
			Me.c1OlapGrid1 = New C1.Win.Olap.C1OlapGrid()
			Me.c1OlapPanel1 = New C1.Win.Olap.C1OlapPanel()
			Me.c1OlapChart1 = New C1.Win.Olap.C1OlapChart()
			Me.c1OlapPrintDocument1 = New C1.Win.Olap.C1OlapPrintDocument()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			Me.toolStrip1.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.c1OlapGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.c1OlapPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.c1OlapChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = DockStyle.Fill
			Me.splitContainer1.Location = New Point(119, 57)
			Me.splitContainer1.Margin = New Padding(4)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.c1OlapGrid1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.c1OlapChart1)
			Me.splitContainer1.Size = New Size(790, 449)
			Me.splitContainer1.SplitterDistance = 380
			Me.splitContainer1.SplitterWidth = 5
			Me.splitContainer1.TabIndex = 4
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Dock = DockStyle.Left
			Me.toolStrip1.GripStyle = ToolStripGripStyle.Hidden
			Me.toolStrip1.Items.AddRange(New ToolStripItem() { Me.toolStripLabel2, Me._btnSalesperson, Me._btnProduct, Me._btnCountry, Me.toolStripSeparator2, Me.toolStripLabel3, Me._btnExpensive, Me._btnModerate, Me._btnInexpensive, Me._btnAllPrices, Me.toolStripSeparator3, Me.toolStripButton5})
			Me.toolStrip1.Location = New Point(0, 57)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New Size(119, 449)
			Me.toolStrip1.TabIndex = 3
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' toolStripLabel2
			' 
			Me.toolStripLabel2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.toolStripLabel2.Name = "toolStripLabel2"
			Me.toolStripLabel2.Size = New Size(116, 20)
			Me.toolStripLabel2.Text = "View Sales by:"
			' 
			' _btnSalesperson
			' 
			Me._btnSalesperson.Image = (CType(resources.GetObject("_btnSalesperson.Image"), Image))
			Me._btnSalesperson.ImageScaling = ToolStripItemImageScaling.None
			Me._btnSalesperson.ImageTransparentColor = Color.Magenta
			Me._btnSalesperson.Name = "_btnSalesperson"
			Me._btnSalesperson.Size = New Size(116, 54)
			Me._btnSalesperson.Text = "Salesperson"
			Me._btnSalesperson.TextImageRelation = TextImageRelation.ImageAboveText
'			Me._btnSalesperson.Click += New System.EventHandler(Me._btnSalesperson_Click)
			' 
			' _btnProduct
			' 
			Me._btnProduct.Image = (CType(resources.GetObject("_btnProduct.Image"), Image))
			Me._btnProduct.ImageScaling = ToolStripItemImageScaling.None
			Me._btnProduct.ImageTransparentColor = Color.Magenta
			Me._btnProduct.Name = "_btnProduct"
			Me._btnProduct.Size = New Size(116, 54)
			Me._btnProduct.Text = "Product"
			Me._btnProduct.TextImageRelation = TextImageRelation.ImageAboveText
'			Me._btnProduct.Click += New System.EventHandler(Me._btnProduct_Click)
			' 
			' _btnCountry
			' 
			Me._btnCountry.Image = (CType(resources.GetObject("_btnCountry.Image"), Image))
			Me._btnCountry.ImageScaling = ToolStripItemImageScaling.None
			Me._btnCountry.ImageTransparentColor = Color.Magenta
			Me._btnCountry.Name = "_btnCountry"
			Me._btnCountry.Size = New Size(116, 54)
			Me._btnCountry.Text = "Country"
			Me._btnCountry.TextImageRelation = TextImageRelation.ImageAboveText
'			Me._btnCountry.Click += New System.EventHandler(Me._btnCountry_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New Size(116, 6)
			' 
			' toolStripLabel3
			' 
			Me.toolStripLabel3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.toolStripLabel3.Name = "toolStripLabel3"
			Me.toolStripLabel3.Size = New Size(116, 20)
			Me.toolStripLabel3.Text = "Price Filter:"
			' 
			' _btnExpensive
			' 
			Me._btnExpensive.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me._btnExpensive.Image = (CType(resources.GetObject("_btnExpensive.Image"), Image))
			Me._btnExpensive.ImageTransparentColor = Color.Magenta
			Me._btnExpensive.Name = "_btnExpensive"
			Me._btnExpensive.Size = New Size(116, 22)
			Me._btnExpensive.Text = "$$$ E&xpensive"
'			Me._btnExpensive.Click += New System.EventHandler(Me._btnExpensive_Click)
			' 
			' _btnModerate
			' 
			Me._btnModerate.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me._btnModerate.Image = (CType(resources.GetObject("_btnModerate.Image"), Image))
			Me._btnModerate.ImageTransparentColor = Color.Magenta
			Me._btnModerate.Name = "_btnModerate"
			Me._btnModerate.Size = New Size(116, 22)
			Me._btnModerate.Text = "$$ &Moderate"
'			Me._btnModerate.Click += New System.EventHandler(Me._btnModerate_Click)
			' 
			' _btnInexpensive
			' 
			Me._btnInexpensive.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me._btnInexpensive.Image = (CType(resources.GetObject("_btnInexpensive.Image"), Image))
			Me._btnInexpensive.ImageTransparentColor = Color.Magenta
			Me._btnInexpensive.Name = "_btnInexpensive"
			Me._btnInexpensive.Size = New Size(116, 22)
			Me._btnInexpensive.Text = "$ &Inexpensive"
'			Me._btnInexpensive.Click += New System.EventHandler(Me._btnInexpensive_Click)
			' 
			' _btnAllPrices
			' 
			Me._btnAllPrices.Checked = True
			Me._btnAllPrices.CheckState = CheckState.Checked
			Me._btnAllPrices.DisplayStyle = ToolStripItemDisplayStyle.Text
			Me._btnAllPrices.Image = (CType(resources.GetObject("_btnAllPrices.Image"), Image))
			Me._btnAllPrices.ImageTransparentColor = Color.Magenta
			Me._btnAllPrices.Name = "_btnAllPrices"
			Me._btnAllPrices.Size = New Size(116, 22)
			Me._btnAllPrices.Text = "* &All Prices"
'			Me._btnAllPrices.Click += New System.EventHandler(Me._btnAllProducts_Click)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New Size(116, 6)
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), Image))
			Me.toolStripButton5.ImageScaling = ToolStripItemImageScaling.None
			Me.toolStripButton5.ImageTransparentColor = Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New Size(116, 54)
			Me.toolStripButton5.Text = "Create &Report..."
			Me.toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText
'			Me.toolStripButton5.Click += New System.EventHandler(Me._btnReport_Click)
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.c1OlapPanel1)
			Me.panel1.Controls.Add(Me.label1)
			Me.panel1.Dock = DockStyle.Top
			Me.panel1.Location = New Point(0, 0)
			Me.panel1.Margin = New Padding(4)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New Size(909, 57)
			Me.panel1.TabIndex = 5
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New Point(16, 11)
			Me.label1.Margin = New Padding(4, 0, 4, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(344, 32)
			Me.label1.TabIndex = 0
			Me.label1.Text = "My Custom Olap Application"
			' 
			' c1OlapGrid1
			' 
			Me.c1OlapGrid1.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
			Me.c1OlapGrid1.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictAll
			Me.c1OlapGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
			Me.c1OlapGrid1.ColumnInfo = "1,1,0,0,0,120,Columns:0{Width:101;}" & vbTab
			Me.c1OlapGrid1.DataSource = Me.c1OlapPanel1
			Me.c1OlapGrid1.Dock = DockStyle.Fill
			Me.c1OlapGrid1.Location = New Point(0, 0)
			Me.c1OlapGrid1.Margin = New Padding(4)
			Me.c1OlapGrid1.Name = "c1OlapGrid1"
			Me.c1OlapGrid1.Rows.Count = 1
			Me.c1OlapGrid1.Rows.DefaultSize = 24
			Me.c1OlapGrid1.Size = New Size(380, 449)
			Me.c1OlapGrid1.StyleInfo = resources.GetString("c1OlapGrid1.StyleInfo")
			Me.c1OlapGrid1.TabIndex = 1
			Me.c1OlapGrid1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue
			' 
			' c1OlapPanel1
			' 
			Me.c1OlapPanel1.Anchor = (CType((AnchorStyles.Top Or AnchorStyles.Right), AnchorStyles))
			Me.c1OlapPanel1.Location = New Point(576, 15)
			Me.c1OlapPanel1.Margin = New Padding(5, 6, 5, 6)
			Me.c1OlapPanel1.Name = "c1OlapPanel1"
			Me.c1OlapPanel1.ShowZeros = False
			Me.c1OlapPanel1.Size = New Size(319, 355)
			Me.c1OlapPanel1.TabIndex = 2
			Me.c1OlapPanel1.Visible = False
			' 
			' c1OlapChart1
			' 
			Me.c1OlapChart1.BackColor = Color.Transparent
			Me.c1OlapChart1.DataSource = Me.c1OlapPanel1
			Me.c1OlapChart1.Dock = DockStyle.Fill
			Me.c1OlapChart1.Location = New Point(0, 0)
			Me.c1OlapChart1.Margin = New Padding(4)
			Me.c1OlapChart1.Name = "c1OlapChart1"
			Me.c1OlapChart1.ShowTitle = False
			Me.c1OlapChart1.Size = New Size(405, 449)
			Me.c1OlapChart1.TabIndex = 1
			' 
			' c1OlapPrintDocument1
			' 
			Me.c1OlapPrintDocument1.FooterText = Nothing
			Me.c1OlapPrintDocument1.OlapChart = Me.c1OlapChart1
			Me.c1OlapPrintDocument1.OlapGrid = Me.c1OlapGrid1
			Me.c1OlapPrintDocument1.RawDataGrid = Nothing
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 20F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(909, 506)
			Me.Controls.Add(Me.splitContainer1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Controls.Add(Me.panel1)
			Me.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Margin = New Padding(3, 4, 3, 4)
			Me.Name = "Form1"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "C1Olap: Custom User Interface"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.c1OlapGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.c1OlapPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.c1OlapChart1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private splitContainer1 As SplitContainer
		Private toolStrip1 As ToolStrip
		Private toolStripLabel2 As ToolStripLabel
		Private WithEvents _btnSalesperson As ToolStripButton
		Private WithEvents _btnProduct As ToolStripButton
		Private WithEvents _btnCountry As ToolStripButton
		Private toolStripSeparator2 As ToolStripSeparator
		Private toolStripLabel3 As ToolStripLabel
		Private WithEvents _btnExpensive As ToolStripButton
		Private WithEvents _btnModerate As ToolStripButton
		Private WithEvents _btnInexpensive As ToolStripButton
		Private WithEvents _btnAllPrices As ToolStripButton
		Private toolStripSeparator3 As ToolStripSeparator
		Private WithEvents toolStripButton5 As ToolStripButton
		Private panel1 As Panel
		Private label1 As Label
		Private c1OlapPanel1 As C1.Win.Olap.C1OlapPanel
		Private c1OlapGrid1 As C1.Win.Olap.C1OlapGrid
		Private c1OlapChart1 As C1.Win.Olap.C1OlapChart
		Private c1OlapPrintDocument1 As C1.Win.Olap.C1OlapPrintDocument
	End Class
End Namespace

