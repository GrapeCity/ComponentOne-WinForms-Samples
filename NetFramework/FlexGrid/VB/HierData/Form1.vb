Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified imports  the Windows Form Designer.  
    'Do not modify it imports  the code editor.
    Friend WithEvents lblMaster As System.Windows.Forms.Label
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents flex1 As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents flex2 As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMaster = New System.Windows.Forms.Label()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.flex1 = New C1.Win.FlexGrid.C1FlexGrid()
        Me.flex2 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.flex1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flex2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMaster
        '
        Me.lblMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaster.Location = New System.Drawing.Point(8, 16)
        Me.lblMaster.Name = "lblMaster"
        Me.lblMaster.Size = New System.Drawing.Size(64, 16)
        Me.lblMaster.TabIndex = 5
        Me.lblMaster.Text = "Master"
        Me.lblMaster.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblDetail
        '
        Me.lblDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(344, 16)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(208, 16)
        Me.lblDetail.TabIndex = 4
        Me.lblDetail.Text = "Detail"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'flex1
        '
        Me.flex1.BackColor = System.Drawing.SystemColors.Window
        Me.flex1.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex1.Location = New System.Drawing.Point(8, 32)
        Me.flex1.Name = "flex1"
        Me.flex1.Size = New System.Drawing.Size(320, 256)
        Me.flex1.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" &
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" &
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" &
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" &
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" &
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" &
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" &
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" &
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.flex1.TabIndex = 8
        '
        'flex2
        '
        Me.flex2.BackColor = System.Drawing.SystemColors.Window
        Me.flex2.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex2.Location = New System.Drawing.Point(344, 32)
        Me.flex2.Name = "flex2"
        Me.flex2.Size = New System.Drawing.Size(320, 256)
        Me.flex2.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" &
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" &
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" &
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" &
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" &
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" &
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" &
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" &
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.flex2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.flex2, Me.flex1, Me.lblMaster, Me.lblDetail})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Master-Detail data binding"
        CType(Me.flex1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flex2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create hierarchical DataSet
        Dim drc As DataRowCollection
        Dim dcc As DataColumnCollection
        Dim ds As DataSet = New DataSet("Hierarchical Dataset")

        ds.Tables.Add("Products")
        dcc = ds.Tables("Products").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("Name", GetType(String))
        dcc.Add("Value", GetType(Decimal))

        drc = ds.Tables("Products").Rows
        drc.Add(New Object() {"P1", "Widget", 19.95})
        drc.Add(New Object() {"P2", "Gadget", 22.75})
        drc.Add(New Object() {"P3", "Sprocket", 33.1})

        ds.Tables.Add("Customers")
        dcc = ds.Tables("Customers").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("Name", GetType(String))
        dcc.Add("Address", GetType(String))

        drc = ds.Tables("Customers").Rows
        drc.Add(New Object() {"C1", "John", "122 Penny Lane"})
        drc.Add(New Object() {"C2", "Paul", "646 Abbey Road"})
        drc.Add(New Object() {"C3", "George", "222 Chatham Road"})
        drc.Add(New Object() {"C4", "Ringo", "345 Oxford St"})

        ds.Tables.Add("Orders")
        dcc = ds.Tables("Orders").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("CustomerID", GetType(String))
        dcc.Add("Prty", GetType(Integer))
        dcc.Add("Date", GetType(DateTime))

        drc = ds.Tables("Orders").Rows
        drc.Add(New Object() {"O1", "C1", 1, New DateTime(2001, 12, 1)})
        drc.Add(New Object() {"O2", "C2", 2, New DateTime(2002, 1, 22)})
        drc.Add(New Object() {"O3", "C3", 3, New DateTime(2002, 1, 20)})
        drc.Add(New Object() {"O4", "C4", 1, New DateTime(2002, 1, 14)})
        drc.Add(New Object() {"O5", "C1", 3, New DateTime(2002, 1, 16)})

        ds.Tables.Add("OrderDetail")
        dcc = ds.Tables("OrderDetail").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("OrderID", GetType(String))
        dcc.Add("ProductID", GetType(String))
        dcc.Add("Qty", GetType(Integer))

        drc = ds.Tables("OrderDetail").Rows
        drc.Add(New Object() {"D1", "O1", "P1", 1})
        drc.Add(New Object() {"D2", "O1", "P2", 12})
        drc.Add(New Object() {"D3", "O1", "P3", 1})
        drc.Add(New Object() {"D4", "O2", "P1", 1})
        drc.Add(New Object() {"D5", "O2", "P2", 8})
        drc.Add(New Object() {"D6", "O2", "P3", 1})
        drc.Add(New Object() {"D7", "O3", "P1", 1})
        drc.Add(New Object() {"D8", "O4", "P1", 1})
        drc.Add(New Object() {"D9", "O4", "P2", 10})
        drc.Add(New Object() {"D10", "O5", "P1", 1})
        drc.Add(New Object() {"D11", "O5", "P2", 16})
        drc.Add(New Object() {"D12", "O5", "P3", 1})

        ds.Relations.Add("CustomerOrders", ds.Tables("Customers").Columns("ID"), ds.Tables("Orders").Columns("CustomerID"))
        ds.Relations.Add("Order Details", ds.Tables("Orders").Columns("ID"), ds.Tables("OrderDetail").Columns("OrderID"))
        ds.Relations.Add("Product Details", ds.Tables("Products").Columns("ID"), ds.Tables("OrderDetail").Columns("ProductID"))

        ' bind data set to flex1/flex2 controls
        flex1.DataMember = "Customers"
        flex1.DataSource = ds
        flex2.DataMember = "Customers.CustomerOrders"
        flex2.DataSource = ds
    End Sub
End Class
