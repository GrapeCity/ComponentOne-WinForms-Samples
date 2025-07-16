Imports C1.Win.FlexGrid

Public Class frmEdit
    Inherits System.Windows.Forms.Form
    Public imgMap As New Hashtable()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents cmbDateFormat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBooleanFormat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents optNoPicture As System.Windows.Forms.RadioButton
    Friend WithEvents optPictureText As System.Windows.Forms.RadioButton
    Friend WithEvents optPictures As System.Windows.Forms.RadioButton
    Friend WithEvents imgCountries As System.Windows.Forms.ImageList
    Friend WithEvents flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.cmbDateFormat = New System.Windows.Forms.ComboBox
        Me.lbl2 = New System.Windows.Forms.Label
        Me.cmbBooleanFormat = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optPictures = New System.Windows.Forms.RadioButton
        Me.optPictureText = New System.Windows.Forms.RadioButton
        Me.optNoPicture = New System.Windows.Forms.RadioButton
        Me.imgCountries = New System.Windows.Forms.ImageList(Me.components)
        Me.flex = New C1.Win.FlexGrid.C1FlexGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SeaGreen
        Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "   Editing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(16, 96)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(100, 16)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Date Column"
        '
        'cmbDateFormat
        '
        Me.cmbDateFormat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDateFormat.Items.AddRange(New Object() {"dd M, yyyy", "MMMM dd, yyyy", "M/dd/yy", "d/M/yy", "dd-MMM", "dd-MMM-yy", "MMM-yy", "MMMM-yy"})
        Me.cmbDateFormat.Location = New System.Drawing.Point(16, 112)
        Me.cmbDateFormat.Name = "cmbDateFormat"
        Me.cmbDateFormat.Size = New System.Drawing.Size(136, 23)
        Me.cmbDateFormat.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.Enabled = False
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(20, 152)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(100, 16)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Boolean Column"
        Me.lbl2.Visible = False
        '
        'cmbBooleanFormat
        '
        Me.cmbBooleanFormat.Enabled = False
        Me.cmbBooleanFormat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBooleanFormat.Items.AddRange(New Object() {"Yes;No", "Si;No", "In;Out", "Full;Empty"})
        Me.cmbBooleanFormat.Location = New System.Drawing.Point(20, 168)
        Me.cmbBooleanFormat.Name = "cmbBooleanFormat"
        Me.cmbBooleanFormat.Size = New System.Drawing.Size(132, 23)
        Me.cmbBooleanFormat.TabIndex = 4
        Me.cmbBooleanFormat.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPictures)
        Me.GroupBox1.Controls.Add(Me.optPictureText)
        Me.GroupBox1.Controls.Add(Me.optNoPicture)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 84)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Image Map Column"
        '
        'optPictures
        '
        Me.optPictures.Location = New System.Drawing.Point(12, 60)
        Me.optPictures.Name = "optPictures"
        Me.optPictures.Size = New System.Drawing.Size(104, 16)
        Me.optPictures.TabIndex = 2
        Me.optPictures.Text = "Pictures Only"
        '
        'optPictureText
        '
        Me.optPictureText.Location = New System.Drawing.Point(12, 40)
        Me.optPictureText.Name = "optPictureText"
        Me.optPictureText.Size = New System.Drawing.Size(120, 16)
        Me.optPictureText.TabIndex = 1
        Me.optPictureText.Text = "Pictures and Text"
        '
        'optNoPicture
        '
        Me.optNoPicture.Location = New System.Drawing.Point(12, 20)
        Me.optNoPicture.Name = "optNoPicture"
        Me.optNoPicture.Size = New System.Drawing.Size(104, 16)
        Me.optNoPicture.TabIndex = 0
        Me.optNoPicture.Text = "Text Only"
        '
        'imgCountries
        '
        Me.imgCountries.ImageStream = CType(resources.GetObject("imgCountries.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCountries.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCountries.Images.SetKeyName(0, "")
        Me.imgCountries.Images.SetKeyName(1, "")
        Me.imgCountries.Images.SetKeyName(2, "")
        Me.imgCountries.Images.SetKeyName(3, "")
        Me.imgCountries.Images.SetKeyName(4, "")
        Me.imgCountries.Images.SetKeyName(5, "")
        Me.imgCountries.Images.SetKeyName(6, "")
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Location = New System.Drawing.Point(176, 92)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(472, 400)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 6
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(656, 497)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBooleanFormat)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.cmbDateFormat)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim r As Integer
        Dim mcol As Column

        With flex
            'add columns

            '--------------------------------------------
            ' column 0: sequential
            '--------------------------------------------
            .Cols(0).Width = 2 * .Rows(0).HeightDisplay

            '--------------------------------------------
            ' column 1: strings
            '--------------------------------------------
            mcol = .Cols.Add()
            mcol.Name = "strings"
            mcol.DataType = GetType(String)
            flex(0, 1) = mcol.DataType.ToString()

            '--------------------------------------------
            ' column 2: enumeration
            '--------------------------------------------
            mcol = .Cols.Add()
            mcol.Name = "enum"
            mcol.DataType = GetType([Enum])
            flex(0, 2) = mcol.DataType.ToString()

            '--------------------------------------------
            ' column 3: dates
            '--------------------------------------------
            mcol = .Cols.Add()
            mcol.Name = "dates"
            mcol.DataType = GetType(DateTime)
            mcol.Format = "dd MMMM, yyyy"
            flex(0, 3) = mcol.DataType.ToString()
            .Cols(3).Format = mcol.Format

            .Cols(6).DataType = GetType(Boolean)

            '--------------------------------------------
            ' column 3: dates
            '--------------------------------------------

            ' create image list
            imgMap.Add("Canada", imgCountries.Images(0))
            imgMap.Add("USA", imgCountries.Images(1))
            imgMap.Add("Brazil", imgCountries.Images(2))
            imgMap.Add("France", imgCountries.Images(3))
            imgMap.Add("Germany", imgCountries.Images(4))
            imgMap.Add("Spain", imgCountries.Images(5))
            imgMap.Add("Mexico", imgCountries.Images(6))

            ' add grid titles
            flex(0, 1) = "String"
            flex(0, 2) = "Enumerations"
            flex(0, 3) = "Date"
            flex(0, 4) = "Numbers"
            flex(0, 5) = "Image Map"
            flex(0, 6) = "Boolean"

            For r = .Rows.Fixed To .Rows.Count - 1
                flex(r, 0) = r
                flex(r, 1) = Country()
                flex(r, 2) = Country()
                flex(r, 3) = New DateTime(1985 + Rnd(20), 1 + Rnd(11), 1 + Rnd(25))
                flex(r, 4) = Rnd() * 100000
                flex(r, 5) = Country()
                flex(r, 6) = (Rnd() * 1000) > 500
            Next r
            flex.ShowCell(0, 1)
        End With
    End Sub
    Private Function Country() As String

        Select Case Int((Rnd() * 1000) Mod 6)
            Case 0 : Country = "Canada"
            Case 1 : Country = "USA"
            Case 2 : Country = "Brazil"
            Case 3 : Country = "France"
            Case 4 : Country = "Germany"
            Case 5 : Country = "Spain"
            Case Else : Country = "Mexico"
        End Select

    End Function

    Private Sub cmbDateFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDateFormat.SelectedIndexChanged
        flex.ShowCell(0, 3)
        flex.Cols(3).Format = cmbDateFormat.Text
        flex.AutoSizeCol(3)
    End Sub

    Private Sub cmbBooleanFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBooleanFormat.SelectedIndexChanged
        flex.ShowCell(0, 6)
        flex.Cols(6).Format = cmbBooleanFormat.Text
        flex.AutoSizeCol(6)
    End Sub


    Private Sub optPictures_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPictureText.CheckedChanged, optNoPicture.CheckedChanged, optPictures.CheckedChanged

        flex.ShowCell(0, 5)
        If optNoPicture.Checked Then flex.Cols(5).ImageMap = Nothing

        If optPictures.Checked Then
            ' associate image list to column 0 (Country)
            flex.Cols(5).ImageMap = imgMap
            flex.Cols(5).ImageAndText = False
            flex.Cols(5).ImageAlign = ImageAlignEnum.LeftCenter
        End If

        If optPictureText.Checked Then
            ' associate image list to column 0 (Country)
            flex.Cols(5).ImageMap = imgMap
            flex.Cols(5).ImageAndText = True
            flex.Cols(5).ImageAlign = ImageAlignEnum.LeftCenter
        End If

        flex.AutoSizeCol(5)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1FlexGridPrintable.C1.Win.FlexGrid.C1FlexGridPrintable
        printer = New C1FlexGridPrintable.C1.Win.FlexGrid.C1FlexGridPrintable(flex)
        printer.PrintPreview()
        'printer.ExportTo()
    End Sub
End Class
