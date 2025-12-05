Public Class frmStyles
    Inherits System.Windows.Forms.Form
    Public m_Skins As New Hashtable()

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents cmbSkins As System.Windows.Forms.ComboBox
    Friend WithEvents chkWallpaper As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbrOpacityHighlight As System.Windows.Forms.TrackBar
    Friend WithEvents tbrOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStyles))
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.pGrid = New System.Windows.Forms.PropertyGrid
        Me.lbl2 = New System.Windows.Forms.Label
        Me.flex = New C1.Win.FlexGrid.C1FlexGrid
        Me.cmbSkins = New System.Windows.Forms.ComboBox
        Me.chkWallpaper = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbrOpacityHighlight = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl = New System.Windows.Forms.Label
        Me.tbrOpacity = New System.Windows.Forms.TrackBar
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbrOpacityHighlight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Haettenschweiler", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(792, 56)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "  Styles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Haettenschweiler", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(28, 132)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(166, 26)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Global Default Styles"
        '
        'pGrid
        '
        Me.pGrid.CommandsBackColor = System.Drawing.Color.White
        Me.pGrid.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.pGrid.Location = New System.Drawing.Point(28, 176)
        Me.pGrid.Name = "pGrid"
        Me.pGrid.Size = New System.Drawing.Size(296, 300)
        Me.pGrid.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(332, 92)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(38, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Skins"
        '
        'flex
        '
        Me.flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.flex.Location = New System.Drawing.Point(332, 176)
        Me.flex.Name = "flex"
        Me.flex.Rows.DefaultSize = 17
        Me.flex.Size = New System.Drawing.Size(448, 304)
        Me.flex.StyleInfo = resources.GetString("flex.StyleInfo")
        Me.flex.TabIndex = 4
        Me.flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.flex.Tree.NodeImageCollapsed = CType(resources.GetObject("flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me.flex.Tree.NodeImageExpanded = CType(resources.GetObject("flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'cmbSkins
        '
        Me.cmbSkins.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSkins.Items.AddRange(New Object() {"None", "Ocean", "Forest", "Sky", "Night", "Fire", "Wood", "Toolbox", "Notebook", "Sam", "Oldtimer", "Panther"})
        Me.cmbSkins.Location = New System.Drawing.Point(332, 108)
        Me.cmbSkins.Name = "cmbSkins"
        Me.cmbSkins.Size = New System.Drawing.Size(128, 23)
        Me.cmbSkins.TabIndex = 5
        '
        'chkWallpaper
        '
        Me.chkWallpaper.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWallpaper.Location = New System.Drawing.Point(332, 140)
        Me.chkWallpaper.Name = "chkWallpaper"
        Me.chkWallpaper.Size = New System.Drawing.Size(88, 20)
        Me.chkWallpaper.TabIndex = 6
        Me.chkWallpaper.Text = "Wallpaper"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbrOpacityHighlight)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.tbrOpacity)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(472, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alpha Blending"
        '
        'tbrOpacityHighlight
        '
        Me.tbrOpacityHighlight.Location = New System.Drawing.Point(124, 44)
        Me.tbrOpacityHighlight.Name = "tbrOpacityHighlight"
        Me.tbrOpacityHighlight.Size = New System.Drawing.Size(172, 45)
        Me.tbrOpacityHighlight.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Highlight BackColor"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 20)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(108, 15)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Normal BackColor"
        '
        'tbrOpacity
        '
        Me.tbrOpacity.Location = New System.Drawing.Point(124, 16)
        Me.tbrOpacity.Name = "tbrOpacity"
        Me.tbrOpacity.Size = New System.Drawing.Size(172, 45)
        Me.tbrOpacity.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 36)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmStyles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(808, 485)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkWallpaper)
        Me.Controls.Add(Me.cmbSkins)
        Me.Controls.Add(Me.flex)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.pGrid)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStyles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Styles"
        CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbrOpacityHighlight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub frmStyles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ' Set Track Bar
        tbrOpacity.Minimum = 1
        tbrOpacity.Maximum = 255
        tbrOpacityHighlight.Minimum = 1
        tbrOpacityHighlight.Maximum = 255

        ' set default values for controls
        chkWallpaper.Checked = True
        tbrOpacityHighlight.Value = 125
        tbrOpacity.Value = 25

        ' set default look and feel
        flex.BackColor = SystemColors.Window
        flex.Styles.Alternate.Clear(C1.Win.FlexGrid.StyleElementFlags.Font)
        flex.Styles.Highlight.ForeColor = Color.Black
        flex.Styles.Highlight.BackColor = Color.FromArgb(tbrOpacityHighlight.Value, 255, 255, 192)
        flex.Styles.Normal.Margins.Right = 2
        flex.Styles.Normal.Border.Style = C1.Win.FlexGrid.BorderStyleEnum.Flat
        flex.Styles.Normal.Border.Color = SystemColors.Control
        flex.Styles.Normal.BackColor() = Color.FromArgb(tbrOpacity.Value, 0, 125, 192)

        flex.Styles.Focus.Clear(C1.Win.FlexGrid.StyleElementFlags.Font)
        flex.Styles.Highlight.Clear(C1.Win.FlexGrid.StyleElementFlags.Font)

        ' load data
        flex.Rows.Count = 1
        flex.Cols.Count = 4

        flex.ClipSeparators = "|;"
        ' enter all data
        flex.AddItem("Germany|Gold|Export|1,267")
        flex.AddItem("Germany|Gold|Import|167")
        flex.AddItem("Germany|Silver|Import|167")
        flex.AddItem("Canada|Silver|Import|70")
        flex.AddItem("Canada|Silver|Export|70")
        flex.AddItem("Canada|Gold|Export|70")
        flex.AddItem("Canada|Gold|Import|70")
        flex.AddItem("USA|Silver|Export|70")
        flex.AddItem("USA|Gold|Export|70")
        flex.AddItem("USA|Gold|Import|70")

        ' create custom styles
        Dim s As C1.Win.FlexGrid.CellStyle
        s = flex.Styles.Add("Country")
        s.BackColor = Color.BlanchedAlmond
        s.TextAlign = C1.Win.FlexGrid.TextAlignEnum.CenterCenter

        ' create SmallNumber style
        s = flex.Styles.Add("SmallNumber")
        s.ForeColor = Color.Red
        s.BackColor = Color.PowderBlue
        s.Font = New Font(s.Font.Name, s.Font.Size, FontStyle.Bold)

        ' assign Country style to two columns
        'flex.Cols(1).Style = flex.Styles("Country")
        'flex.Cols(2).Style = flex.Styles("Country")

        ' browse objects on property grid
        pGrid.SelectedObject = flex.Styles


        ' build skin dictionary
        m_Skins.Add("Ocean", "Normal{BackColor:LightSeaGreen;ForeColor:Aquamarine;Border:Flat,1,SeaGreen,Horizontal;}	Fixed{BackColor:Aqua;ForeColor:DarkGreen;Border:Flat,1,SeaGreen,Both;}	Highlight{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Aqua;ForeColor:DarkGreen;}")
        m_Skins.Add("Forest", "Normal{BackColor:ForestGreen;ForeColor:LightGreen;Border:Flat,1,DarkGreen,Horizontal;}	Fixed{BackColor:YellowGreen;ForeColor:DarkGreen;Border:Flat,1,DarkGreen,Both;}	Highlight{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:LightGreen;ForeColor:DarkGreen;}")
        m_Skins.Add("Sky", "Normal{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:DeepSkyBlue;ForeColor:White;Border:None,1,Black,Both;}	Fixed{Font:Microsoft Sans Serif, 8.25pt;BackColor:White;ForeColor:RoyalBlue;Border:Flat,1,SteelBlue,Both;}	Highlight{BackColor:White;ForeColor:RoyalBlue;}")
        m_Skins.Add("Night", "Normal{BackColor:MidnightBlue;ForeColor:LightGoldenrodYellow;Border:None,1,Black,Both;}	Fixed{BackColor:MidnightBlue;ForeColor:PaleGoldenrod;Border:Flat,1,LightSteelBlue,Both;}	Highlight{BackColor:SteelBlue;ForeColor:LightGoldenrodYellow;Border:Raised,1,Black,Both;}")
        m_Skins.Add("Fire", "Normal{BackColor:Gold;ForeColor:Red;Border:Flat,1,Coral,Both;}	Fixed{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Red;ForeColor:Gold;Border:Flat,1,ControlDark,Both;}	Highlight{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:DodgerBlue;ForeColor:WhiteSmoke;}")
        m_Skins.Add("Wood", "Normal{BackColor:BurlyWood;ForeColor:SaddleBrown;Border:Flat,1,Moccasin,Both;}	Fixed{Font:Microsoft Sans Serif, 8.25pt, style=Bold;BackColor:Tan;ForeColor:SaddleBrown;Border:Flat,1,DarkGoldenrod,Both;}	Highlight{BackColor:Sienna;ForeColor:BurlyWood;}")
        m_Skins.Add("Toolbox", "Normal{BackColor:Control;ForeColor:ControlDark;}	Fixed{BackColor:Control;ForeColor:ControlDark;Border:None,1,Black,Both;}	Highlight{BackColor:BlanchedAlmond;ForeColor:WindowText;Border:Inset,1,Black,Both;}")
        m_Skins.Add("Notebook", "Normal{Font:Viner Hand ITC, 11.25pt;BackColor:LightCyan;ForeColor:DarkBlue;Border:Flat,1,DarkCyan,Horizontal;}	Fixed{Font:Courier New, 9.75pt;BackColor:PaleTurquoise;ForeColor:Black;Border:Flat,2,Firebrick,Vertical;}	Highlight{Font:Viner Hand ITC, 11.25pt, style=Bold, Underline;BackColor:LightCyan;ForeColor:Red;}")
        m_Skins.Add("Sam", "Normal{Font:Rockwell, 9pt, style=Bold;BackColor:Red;ForeColor:White;Border:None,1,Black,Both;}	Fixed{BackColor:Blue;ForeColor:White;Border:Flat,1,Silver,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}")
        m_Skins.Add("Oldtimer", "Normal{Font:Lucida Console, 8.25pt;BackColor:Ivory;Border:None,1,Black,Both;}	Alternate{BackColor:DarkSeaGreen;}	Fixed{Font:Lucida Console, 8.25pt, style=Bold;BackColor:DarkGray;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{Font:Lucida Console, 8.25pt, style=Bold;BackColor:Black;ForeColor:White;}")
        m_Skins.Add("Panther", "Normal{Font:Tempo Grunge, 11.25pt, style=Bold;BackColor:HotPink;ForeColor:Purple;Border:Flat,1,DeepPink,Both;}	Fixed{BackColor:Purple;ForeColor:Orchid;Border:Flat,1,Orchid,Both;}	Highlight{BackColor:Purple;ForeColor:HotPink;}")

        cmbSkins.SelectedIndex = 0

    End Sub

    Private Sub chkWallpaper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWallpaper.CheckedChanged

        If chkWallpaper.Checked Then
            ' set wallpaper
            flex.BackColor = System.Drawing.Color.Transparent
            flex.BackgroundImage = PictureBox1.BackgroundImage
        Else
            flex.BackColor = System.Drawing.Color.White
            flex.BackgroundImage = Nothing
        End If

    End Sub

    Private Sub tbrOpacity_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrOpacity.ValueChanged

        ' set alpha blending/opacity
        flex.Styles.Normal.BackColor = Color.FromArgb(tbrOpacity.Value(), flex.Styles.Normal.BackColor.R, flex.Styles.Normal.BackColor.G, flex.Styles.Normal.BackColor.B)

    End Sub

    Private Sub tbrOpacityHighlight_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrOpacityHighlight.ValueChanged

        ' set alpha blending/opacity
        flex.Styles.Highlight.BackColor = Color.FromArgb(tbrOpacityHighlight.Value(), flex.Styles.Highlight.BackColor.R, flex.Styles.Highlight.BackColor.G, flex.Styles.Highlight.BackColor.B)

    End Sub

    Private Sub pGrid_SelectedGridItemChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.SelectedGridItemChangedEventArgs) Handles pGrid.SelectedGridItemChanged

        ' update both track bars
        tbrOpacity.Refresh()
        tbrOpacityHighlight.Refresh()

    End Sub


    Private Sub cmbSkins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSkins.SelectedIndexChanged

        flex.Styles.Clear()

        If cmbSkins.SelectedItem = "None" Then Exit Sub

        ' apply skin style
        flex.Styles.ParseString(m_Skins(cmbSkins.SelectedItem))

        ' update both track bars
        tbrOpacity_ValueChanged(Me, Nothing)
        tbrOpacityHighlight_ValueChanged(Me, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printer As C1FlexGridPrintable.C1.Win.FlexGrid.C1FlexGridPrintable
        printer = New C1FlexGridPrintable.C1.Win.FlexGrid.C1FlexGridPrintable(flex)
        printer.PrintPreview()
    End Sub
End Class
