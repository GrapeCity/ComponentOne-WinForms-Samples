Imports System.Data.OleDb
Imports C1.Win.C1FlexGrid

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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _radioShippers As System.Windows.Forms.RadioButton
    Friend WithEvents _flexList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _chkCombo As System.Windows.Forms.CheckBox
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _radioProducts As System.Windows.Forms.RadioButton
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me._radioShippers = New System.Windows.Forms.RadioButton()
        Me._flexList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._chkCombo = New System.Windows.Forms.CheckBox()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._radioProducts = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me._flexList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.groupBox1.Location = New System.Drawing.Point(8, 256)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(712, 3)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        '
        '_radioShippers
        '
        Me._radioShippers.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._radioShippers.Location = New System.Drawing.Point(12, 278)
        Me._radioShippers.Name = "_radioShippers"
        Me._radioShippers.Size = New System.Drawing.Size(128, 16)
        Me._radioShippers.TabIndex = 12
        Me._radioShippers.Text = "Edit Shippers >>>"
        '
        '_flexList
        '
        Me._flexList.AllowAddNew = True
        Me._flexList.AllowDelete = True
        Me._flexList.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flexList.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:27;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flexList.Location = New System.Drawing.Point(200, 272)
        Me._flexList.Name = "_flexList"
        Me._flexList.Rows.DefaultSize = 17
        Me._flexList.ShowCursor = True
        Me._flexList.Size = New System.Drawing.Size(520, 136)
        Me._flexList.TabIndex = 10
        '
        '_chkCombo
        '
        Me._chkCombo.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._chkCombo.Location = New System.Drawing.Point(12, 398)
        Me._chkCombo.Name = "_chkCombo"
        Me._chkCombo.Size = New System.Drawing.Size(104, 16)
        Me._chkCombo.TabIndex = 9
        Me._chkCombo.Text = "Use Combos"
        '
        '_flex
        '
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.AutoClipboard = True
        Me._flex.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me._flex.Location = New System.Drawing.Point(8, 6)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(712, 240)
        Me._flex.StyleInfo = "Normal{}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1," & _
        "ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Focus" & _
        "{}" & Microsoft.VisualBasic.ChrW(9) & "Editor{}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColo" & _
        "r:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "NewRow{}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDar" & _
        "k,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:Contro" & _
        "lDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor:ControlDarkDark;ForeColor:White;" & _
        "}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:Cont" & _
        "rolDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:Whit" & _
        "e;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex.TabIndex = 8
        '
        '_radioProducts
        '
        Me._radioProducts.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me._radioProducts.Location = New System.Drawing.Point(12, 302)
        Me._radioProducts.Name = "_radioProducts"
        Me._radioProducts.Size = New System.Drawing.Size(128, 16)
        Me._radioProducts.TabIndex = 11
        Me._radioProducts.Text = "Edit Products >>>"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 326)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(168, 64)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Any changes to this data will automatically be reflected in the drop-down lists. " & _
        "(Requires version 220 or later)."
        '
        '_imgList
        '
        Me._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me._imgList.ImageSize = New System.Drawing.Size(16, 16)
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox1, Me._radioShippers, Me._flexList, Me._chkCombo, Me._flex, Me._radioProducts, Me.label1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: MultiColumnDictionary Demo"
        CType(Me._flexList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' tables used as list sources
    Dim _dtShippers As New DataTable()
    Dim _dtProducts As New DataTable()
    Dim _dtEmployees As New DataTable()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' load some data to use in multi-column combos
        Dim conn As String = GetConnectionString()
        Dim da1 As New OleDbDataAdapter("select * from shippers", conn)
        da1.Fill(_dtShippers)
        Dim da2 As New OleDbDataAdapter("select * from products", conn)
        da2.Fill(_dtProducts)
        Dim da3 As New OleDbDataAdapter("select * from Employees", conn)
        da3.Fill(_dtEmployees)

        ' show data so user can change it and see the effects
        _radioShippers.Checked = True

        ' create an image map to use with multi-column combos
        Dim img As New Hashtable()
        Dim i%
        For i = 0 To _imgList.Images.Count - 1
            img(i) = _imgList.Images(i)
        Next
        _flex.Cols.Count = 100

        ' regular combo list with duplicate items, no tabs
        Dim colIndex%
        colIndex = _flex.Cols.Fixed
        Dim col As Column = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "Reg Dup"
        col.ComboList = "foo bar|bar foo|foo bar|foo bar"

        ' regular combo list with with duplicate items and tabs
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "Reg Dup Tab"
        col.ComboList = "foo" & vbTab & "bar|bar" & vbTab & "foo|foo" & vbTab & "bar|foo" & vbTab & "bar"

        ' enumerated type
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "Enum"
        col.DataType = GetType(DockStyle)

        ' regular data map
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "Map Img"
        col.ImageMap = img
        Dim ht As New Hashtable()
        ht(0) = "Zero"
        ht(1) = "One"
        ht(2) = "Two"
        ht(3) = "Three"
        col.DataMap = ht

        ' combo with images only
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "Img Only"
        col.ImageAndText = False
        col.ImageMap = img
        col.DataMap = ht

        ' MultiColumnDictionary 1: string-based, autoKeys (stores int, duplicates allowed)
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD SA Img"
        col.ImageMap = img
        Dim foobar As String = "foo" & vbTab & "bar|bar" & vbTab & "foo|foo" & vbTab & "bar|bar" & vbTab & "foo".Replace("" & vbTab & "", vbTab)
        col.DataMap = New MultiColumnDictionary(foobar, 0, True)

        ' MultiColumnDictionary 2: string-based, explicit keys (stores string, duplicates not allowed)
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD SK"
        col.DataMap = New MultiColumnDictionary(foobar, 0, False)

        ' MultiColumnDictionary 3: bound to Shippers
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD Shippers"
        col.ImageMap = img
        Dim fields As String() = New String() {"CompanyName", "Phone"}
        col.DataMap = New C1.Win.C1FlexGrid.MultiColumnDictionary(_dtShippers, "ShipperID", fields, 0)

        ' MultiColumnDictionary 4: bound to Products
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD Prods"
        col.ImageMap = img
        col.DataMap = New C1.Win.C1FlexGrid.MultiColumnDictionary(_dtProducts, "ProductID", Nothing, 1)

        ' MultiColumnDictionary 5: bound to Employees
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD Employees"
        col.ImageMap = img
        fields = New String() {"FirstName", "LastName", "Country"}
        col.DataMap = New C1.Win.C1FlexGrid.MultiColumnDictionary(_dtEmployees, "EmployeeID", fields, 0)

        ' MultiColumnDictionary 6: string-based, multicol
        col = _flex.Cols(colIndex) : colIndex = colIndex + 1
        col.Caption = "MCD Str MC"
        Dim s As String = "Row1, Col1" & vbTab & "Row1, Col2|Row2, Col1" & vbTab & "Row2, Col2".Replace("" & vbTab & "", vbTab)
        col.DataMap = New MultiColumnDictionary(s, 0, True)
    End Sub

    ' Use combo if checked.
    ' By default, maps imply simple dropdowns.
    ' Simple dropdowns also have autosearch, but the combo autosearch looks better.
    Private Sub _flex_SetupEditor(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _flex.SetupEditor
        If _flex.Editor Is GetType(ComboBox) Then
            Dim cb As ComboBox = DirectCast(Me._flex.Editor, ComboBox)
            cb.DropDownStyle = IIf(Me._chkCombo.Checked, ComboBoxStyle.DropDown, ComboBoxStyle.DropDownList)
        End If
    End Sub

    ' Show tables that are used as combo sources so the user can update them and see the 
    ' how the changes are automatically reflected in the dropdowns.
    Private Sub _radioShippers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _radioShippers.CheckedChanged, _radioProducts.CheckedChanged

        If _radioShippers.Checked Then
            _flexList.DataSource = _dtShippers
        Else
            _flexList.DataSource = _dtProducts
        End If

    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
