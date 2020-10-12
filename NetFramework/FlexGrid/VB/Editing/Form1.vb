Imports System.Collections.Specialized
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.Cols.Count = 10
        Me.fg.Cols.Fixed = 1
        Me.fg.Cols.MaxSize = 0
        Me.fg.Cols.MinSize = 0
        Me.fg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 50
        Me.fg.Rows.Fixed = 1
        Me.fg.Rows.MaxSize = 0
        Me.fg.Rows.MinSize = 0
        Me.fg.Size = New System.Drawing.Size(576, 273)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:LightBlue;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppW" & _
        "orkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackC" & _
        "olor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeC" & _
        "olor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{Bac" & _
        "kColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;For" & _
        "eColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.fg.TabIndex = 0
        Me.fg.Tree.LineColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(128, Byte))
        Me.fg.Tree.NodeImageCollapsed = CType(resources.GetObject("fg.Tree.NodeImageCollapsed"), System.Drawing.Bitmap)
        Me.fg.Tree.NodeImageExpanded = CType(resources.GetObject("fg.Tree.NodeImageExpanded"), System.Drawing.Bitmap)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.fg})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Enum Branches
        NewYork
        Chicago
        NewOrleans
        London
        Paris
    End Enum

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set up grid
        fg.Cols.Count = 8
        fg.Cols(0).Width = fg.Cols.DefaultSize / 3
        Dim index As Integer
        For index = fg.Rows.Fixed To fg.Rows.Count - 1
            fg(index, 0) = index
        Next

        ' column 1: enumeration
        Dim c As Column = fg.Cols(1)
        c.Name = "Branches"
        c.DataType = GetType(Branches)

        ' column 2: data map
        Dim dtMap As ListDictionary = New ListDictionary()
        dtMap.Add(Color.Red, "Apple")
        dtMap.Add(Color.Green, "Avocado")
        dtMap.Add(Color.Blue, "Sky")
        dtMap.Add(Color.Black, "Coal")
        dtMap.Add(Color.White, "Snow")
        c = fg.Cols(2)
        c.Name = "DataMap"
        c.DataType = GetType(Color)
        c.DataMap = dtMap

        ' column 3: boolean
        c = fg.Cols(3)
        c.Name = "Boolean"
        c.DataType = GetType(Boolean)
        c.ImageAlign = ImageAlignEnum.CenterCenter

        ' column 4: currency
        c = fg.Cols(4)
        c.Name = "Currency"
        c.DataType = GetType(Decimal)
        c.Format = "c" ' << currency

        ' column 5: date
        c = fg.Cols(5)
        c.Name = "Date"
        c.DataType = GetType(Date)
        c.Format = "dd MMM, yyyy" ' << medium date

        ' column 6: mask
        c = fg.Cols(6)
        c.Name = "Mask"
        c.DataType = GetType(String)
        c.EditMask = "000/000-0000"

        ' column 7: color
        c = fg.Cols(7)
        c.Name = "Color"
        c.DataType = GetType(Color)
        c.ComboList = "..."

        ' column names
        For index = 0 To fg.Cols.Count - 1
            fg(0, index) = fg.Cols(index).Name
        Next

    End Sub

    Private Sub fg_CellButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles fg.CellButtonClick

        Dim clrDlg As New ColorDialog()

        If fg(e.Row, e.Col) Is GetType(Color) Then
            clrDlg.Color = fg(e.Row, e.Col)
        End If

        If clrDlg.ShowDialog() = DialogResult.OK Then
            fg(e.Row, e.Col) = clrDlg.Color
        End If

    End Sub

    Private Sub fg_ValidateEdit(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.ValidateEditEventArgs) Handles fg.ValidateEdit

        ' validate amounts
        If fg.Cols(e.Col).DataType Is GetType(Decimal) Then
            Try
                Dim dec As Decimal = Decimal.Parse(fg.Editor.Text())
                If dec < 1000 Or dec > 10000 Then
                    MessageBox.Show("Value must be between 1,000 and 10,000")
                    e.Cancel = True
                End If
            Catch
                MessageBox.Show("Value not recognized as a Currency")
                e.Cancel = True
            End Try
        End If

    End Sub
End Class
