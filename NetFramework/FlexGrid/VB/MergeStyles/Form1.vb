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
  Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flex
        '
        Me.flex.BackColor = System.Drawing.SystemColors.Window
        Me.flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:18;}" & Microsoft.VisualBasic.ChrW(9)
        Me.flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flex.ExtendLastCol = True
        Me.flex.Name = "flex"
        Me.flex.Size = New System.Drawing.Size(407, 283)
        Me.flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.flex.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 15)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Red
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(407, 283)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.flex})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid 2.1: Merging Styles"
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create image map
        Dim imap As Hashtable = New Hashtable()
        Dim dmap As Hashtable = New Hashtable()
        Dim i As Integer, max As Integer
        max = Me.ImageList1.Images.Count - 1
        For i = 0 To max
            imap.Add(i, Me.ImageList1.Images(i))
            dmap.Add(i, i.ToString())
        Next

        ' format grid
        flex.Cols(1).DataType = GetType(Int32)
        flex.Cols(1).ImageMap = imap
        flex.Cols(1).DataMap = dmap

        ' populate grid
        Dim rnd As Random = New Random()
        For i = 1 To flex.Rows.Count - 1
            flex(i, 1) = rnd.Next(max)
        Next

        ' change some row colors
        For i = 1 To flex.Rows.Count - 1 Step 3
            flex.Rows(i).StyleNew.BackColor = Color.FromArgb(125 + rnd.Next(100), 125 + rnd.Next(100), 125 + rnd.Next(100))
        Next

        ' change some cell colors
        For i = 1 To 20
            Dim cr As CellRange = flex.GetCellRange(rnd.Next(1, flex.Rows.Count - 1), 1)
            cr.StyleNew.BackColor = Color.Red
        Next

        ' add a combo box to a column (saved with the column style)
        flex.Cols(2).ComboList = "A|B|C|D|E|F"

        ' apply a new style to the column without disturbing the combo
        flex.Cols(2).Style.MergeWith(flex.Styles.Frozen)

        ' ** this wouldn't work, it would remove the ComboList saved with the column style
        'flex.Cols(2).Style = flex.Styles.Frozen


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.flex.ScrollBars = ScrollBars.Vertical
    End Sub
End Class
