<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColumnBandsUserControl
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColumnBandsUserControl))
        Dim band1 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band2 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band3 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band4 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band5 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band6 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band7 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band8 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band9 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band10 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band11 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band12 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band13 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band14 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Dim band15 As C1.Win.C1FlexGrid.Band = New C1.Win.C1FlexGrid.Band()
        Me.flexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.c1FlexGridBandedView1 = New C1.Win.C1FlexGrid.C1FlexGridBandedView()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.c1FlexGridGroupPanel1 = New C1.Win.C1FlexGrid.C1FlexGridGroupPanel()
        CType((Me.flexGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
        CType((Me.c1FlexGridBandedView1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.flexGrid1.AllowEditing = False
        Me.flexGrid1.ColumnContextMenuEnabled = True
        Me.flexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:8{Visible:False;}" & vbTab & "9{Visible:False;}" & vbTab
        Me.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexGrid1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me.flexGrid1.Location = New System.Drawing.Point(3, 120)
        Me.flexGrid1.Name = "flexGrid1"
        Me.flexGrid1.Rows.Count = 3
        Me.flexGrid1.Rows.Fixed = 3
        Me.flexGrid1.Size = New System.Drawing.Size(644, 462)
        Me.flexGrid1.StyleInfo = resources.GetString("flexGrid1.StyleInfo")
        Me.flexGrid1.TabIndex = 0
        Me.flexGrid1.UseCompatibleTextRendering = False
        band1.Name = "OrderID"
        band3.Name = "ProductID"
        band4.Name = "ProductName"
        band2.Children.Add(band3)
        band2.Children.Add(band4)
        band2.ColSpan = 1
        band2.Name = "Product"
        band6.Name = "UnitPrice"
        band7.Name = "Quantity"
        band8.Name = "Discount"
        band9.Name = "Amount"
        band10.Name = "OrderDate"
        band11.Name = "CompanyName"
        band12.Name = "ShipCountry"
        band13.Name = "ShipCity"
        band14.Name = "ShipAddress"
        band15.Name = "DeliveryDate"
        band5.Children.Add(band6)
        band5.Children.Add(band7)
        band5.Children.Add(band8)
        band5.Children.Add(band9)
        band5.Children.Add(band10)
        band5.Children.Add(band11)
        band5.Children.Add(band12)
        band5.Children.Add(band13)
        band5.Children.Add(band14)
        band5.Children.Add(band15)
        band5.ColSpan = 5
        band5.Name = "Details"
        Me.c1FlexGridBandedView1.Bands.Add(band1)
        Me.c1FlexGridBandedView1.Bands.Add(band2)
        Me.c1FlexGridBandedView1.Bands.Add(band5)
        Me.c1FlexGridBandedView1.ColumnContextMenuEnabled = True
        Me.c1FlexGridBandedView1.FlexGrid = Me.flexGrid1
        Me.c1FlexGridBandedView1.ShowBandHeaders = False
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.flexGrid1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.c1FlexGridGroupPanel1, 0, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(650, 585)
        Me.tableLayoutPanel1.TabIndex = 1
        Me.c1FlexGridGroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGridGroupPanel1.FlexGrid = Me.flexGrid1
        Me.c1FlexGridGroupPanel1.Location = New System.Drawing.Point(3, 3)
        Me.c1FlexGridGroupPanel1.Name = "c1FlexGridGroupPanel1"
        Me.c1FlexGridGroupPanel1.Size = New System.Drawing.Size(644, 111)
        Me.c1FlexGridGroupPanel1.TabIndex = 1
        Me.c1FlexGridGroupPanel1.Text = "c1FlexGridGroupPanel1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0F, 28.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ColumnBandsGrouping"
        Me.Size = New System.Drawing.Size(650, 585)
        CType((Me.flexGrid1), System.ComponentModel.ISupportInitialize).EndInit()
        CType((Me.c1FlexGridBandedView1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Private c1FlexGridBandedView1 As C1.Win.C1FlexGrid.C1FlexGridBandedView
    Private flexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private c1FlexGridGroupPanel1 As C1.Win.C1FlexGrid.C1FlexGridGroupPanel
End Class

