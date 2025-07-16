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
        Dim band1 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band2 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band3 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band4 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band5 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band6 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band7 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band8 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band9 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band10 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band11 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band12 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band13 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band14 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band15 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band16 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band17 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band18 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band19 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band20 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band21 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band22 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band23 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band24 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim band25 As C1.Win.FlexGrid.Band = New C1.Win.FlexGrid.Band()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColumnBandsUserControl))
        Me.c1FlexGridBandedView1 = New C1.Win.FlexGrid.C1FlexGridBandedView()
        Me.c1FlexGridBandedView2 = New C1.Win.FlexGrid.C1FlexGridBandedView()
        Me.flexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.c1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1FlexGridBandedView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        band2.Name = "OrderID"
        band3.Name = "Saler"
        band4.ColSpan = 2
        band4.Name = "OrderDate"
        band1.Children.Add(band2)
        band1.Children.Add(band3)
        band1.Children.Add(band4)
        band1.ColSpan = 2
        band1.Name = "Order"
        band6.Name = "CompanyName"
        band7.Name = "Country"
        band5.Children.Add(band6)
        band5.Children.Add(band7)
        band5.ColSpan = 1
        band5.Name = "Buyer"
        band9.ColSpan = 4
        band9.Name = "Product"
        band10.Name = "UnitPrice"
        band11.Name = "Quantity"
        band12.Name = "Discount"
        band13.Name = "ExtendedPrice"
        band8.Children.Add(band9)
        band8.Children.Add(band10)
        band8.Children.Add(band11)
        band8.Children.Add(band12)
        band8.Children.Add(band13)
        band8.ColSpan = 4
        band8.Name = "Article"
        Me.c1FlexGridBandedView1.Bands.Add(band1)
        Me.c1FlexGridBandedView1.Bands.Add(band5)
        Me.c1FlexGridBandedView1.Bands.Add(band8)
        Me.c1FlexGridBandedView1.ColumnContextMenuEnabled = True
        Me.c1FlexGridBandedView1.ShowBandHeaders = False
        band15.Name = "OrderID"
        band16.Name = "OrderDate"
        band17.ColSpan = 2
        band17.Name = "Saler"
        band18.Name = "CompanyName"
        band19.Name = "Country"
        band14.Children.Add(band15)
        band14.Children.Add(band16)
        band14.Children.Add(band17)
        band14.Children.Add(band18)
        band14.Children.Add(band19)
        band14.ColSpan = 2
        band14.Name = "Order"
        band21.ColSpan = 2
        band21.Name = "Product"
        band22.Name = "UnitPrice"
        band23.Name = "Discount"
        band24.Name = "Quantity"
        band25.Name = "ExtendedPrice"
        band20.Children.Add(band21)
        band20.Children.Add(band22)
        band20.Children.Add(band23)
        band20.Children.Add(band24)
        band20.Children.Add(band25)
        band20.ColSpan = 2
        band20.Name = "Article"
        Me.c1FlexGridBandedView2.Bands.Add(band14)
        Me.c1FlexGridBandedView2.Bands.Add(band20)
        Me.c1FlexGridBandedView2.ColumnContextMenuEnabled = True
        Me.flexGrid1.AllowEditing = False
        Me.flexGrid1.ColumnContextMenuEnabled = True
        Me.flexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.flexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw
        Me.flexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.flexGrid1.Name = "flexGrid1"
        Me.flexGrid1.Rows.Count = 1
        Me.flexGrid1.Size = New System.Drawing.Size(650, 585)
        Me.flexGrid1.StyleInfo = resources.GetString("flexGrid1.StyleInfo")
        Me.flexGrid1.TabIndex = 1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0F, 28.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.flexGrid1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75F)
        Me.Name = "ColumnBandsUserControl"
        Me.Size = New System.Drawing.Size(650, 585)
        CType(Me.c1FlexGridBandedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGridBandedView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private c1FlexGridBandedView1 As C1.Win.FlexGrid.C1FlexGridBandedView
    Private c1FlexGridBandedView2 As C1.Win.FlexGrid.C1FlexGridBandedView
    Private flexGrid1 As C1.Win.FlexGrid.C1FlexGrid
End Class

