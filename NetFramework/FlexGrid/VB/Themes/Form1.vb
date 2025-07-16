Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.FlexGrid


Public Class Form1
   Public Enum Theme
        [Default]
        WindowsXP
        Office2003
        Office12
        Vista
        Mac
        Shadow
        Steel
        Glass
    End Enum

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' show some data
        Dim sql As String = "select * from products"
        Dim conn As String = GetConnectionString()
        Dim da As New OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        _flex.DataSource = dt

        ' initialize themes
        For Each theme As Theme In [Enum].GetValues(GetType(Theme))
            Me.comboBox1.Items.Add(theme)
        Next
        Me.comboBox1.SelectedIndex = 0
    End Sub


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        _flex.ShowThemedHeaders = ShowThemedHeadersEnum.None
        _flex.Styles.Clear()

        Select Case DirectCast(Me.comboBox1.SelectedItem, Theme)
            Case Theme.[Default]
                Exit Select
            Case Theme.WindowsXP
                _flex.ShowThemedHeaders = ShowThemedHeadersEnum.Both
                Exit Select
            Case Theme.Office2003
                Office2003(_flex.Styles)
                Exit Select
            Case Theme.Office12
                Office12(_flex.Styles)
                Exit Select
            Case Theme.Vista
                Vista(_flex.Styles)
                Exit Select
            Case Theme.Mac
                Mac(_flex.Styles)
                Exit Select
            Case Theme.Shadow
                Shadow(_flex.Styles)
                Exit Select
            Case Theme.Steel
                Steel(_flex.Styles)
                Exit Select
            Case Theme.Glass
                Glass(_flex.Styles)
                Exit Select
        End Select
        _flex.AutoSizeCols()
        For r As Integer = 0 To _flex.Rows.Fixed - 1
            _flex.AutoSizeRow(r)
        Next

    End Sub

    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

    '*****themes*******'
#Region "** themes"

    Private Sub Office2003(ByVal s As CellStyleCollection)
        s.Clear()
        s.Normal.Border.Color = SystemColors.InactiveBorder
        s.Highlight.Clear()
        s.Highlight.BackColor = SystemColors.GradientInactiveCaption
        s.SelectedColumnHeader.BackColor = System.Windows.Forms.VisualStyles.VisualStyleInformation.ControlHighlightHot
        s.SelectedRowHeader.MergeWith(s.SelectedColumnHeader)
    End Sub
    Private Sub Office12(ByVal s As CellStyleCollection)
        Office2003(s)

        s.Highlight.BackColor = Color.FromArgb(180, s.Highlight.BackColor)

        Dim cs As CellStyle = s.Fixed
        cs.BackgroundImage = BuildStyleBackground(s.Fixed.BackColor)
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.BackColor = Color.White

        cs = s.SelectedColumnHeader
        cs.BackgroundImage = BuildStyleBackground(s.SelectedColumnHeader.BackColor)
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.BackColor = Color.White

        cs = s.SelectedRowHeader
        cs.Clear()
        cs.MergeWith(s.SelectedColumnHeader)
    End Sub
    Private Sub Vista(ByVal s As CellStyleCollection)
        s.Clear()

        Dim cs As CellStyle = s.Normal
        cs.BackColor = Color.FromArgb(247, 247, 247)
        cs.Border.Width = 0

        cs = s.Fixed
        cs.BackgroundImage = GetBitmapResource("Vista_Header.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.ForeColor = Color.FromArgb(150, s.Normal.BackColor)
        cs.Font = New Font(s.Normal.Font, FontStyle.Bold)

        cs = s.Highlight
        cs.Clear()
        cs.BackgroundImage = GetBitmapResource("Vista_Highlight.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.ForeColor = Color.Navy

        s.Focus.MergeWith(cs)
    End Sub
    Private Sub Mac(ByVal s As CellStyleCollection)
        s.Clear()

        Dim cs As CellStyle = s.Normal
        cs.BackColor = Color.FromArgb(250, 250, 250)
        cs.Border.Width = 0

        cs = s.Fixed
        cs.BackgroundImage = GetBitmapResource("Mac_Header.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.Border.Width = 0
        cs.Margins = New System.Drawing.Printing.Margins(4, 4, 4, 2)

        cs = s.SelectedColumnHeader
        cs.MergeWith(s.Fixed)
        cs.BackgroundImage = GetBitmapResource("Mac_HeaderSelected.png")

        s.SelectedRowHeader.MergeWith(cs)

        cs = s.Highlight
        cs.Clear()
        cs.BackColor = Color.FromArgb(150, Color.LightSteelBlue)

        s.Focus.MergeWith(cs)
    End Sub
    Private Sub Shadow(ByVal s As CellStyleCollection)
        s.Clear()

        Dim color__1 As Color = SystemColors.ActiveBorder

        s.Normal.Border.Color = Color.FromArgb(80, color__1)

        Dim cs As CellStyle = s.Fixed
        cs.BackColor = Color.FromArgb(180, color__1)
        cs.Border.Color = Color.FromArgb(220, color__1)

        cs = s.SelectedColumnHeader
        cs.BackgroundImage = BuildStyleBackground(color__1, s.Normal.BackColor, 90)
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch

        cs = s.SelectedRowHeader
        cs.Clear()
        cs.MergeWith(s.SelectedColumnHeader)
        cs.BackgroundImage = BuildStyleBackground(color__1, s.Normal.BackColor, 0)

        cs = s.Highlight
        cs.Clear()
        cs.BackColor = Color.FromArgb(150, s.Fixed.BackColor)
    End Sub
    Private Sub Steel(ByVal s As CellStyleCollection)
        s.Clear()

        Dim cs As CellStyle = s.Normal
        cs.BackColor = Color.FromArgb(250, 250, 250)
        cs.Border.Width = 0

        cs = s.Fixed
        cs.BackgroundImage = GetBitmapResource("Steel_Header.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.Border.Width = 0

        cs = s.SelectedColumnHeader
        cs.MergeWith(s.Fixed)
        cs.BackgroundImage = GetBitmapResource("Steel_HeaderSelected.png")
        cs.Font = New Font(cs.Font, FontStyle.Bold)

        s.SelectedRowHeader.MergeWith(cs)

        cs = s.Highlight
        cs.Clear()
        cs.BackColor = Color.FromArgb(150, Color.LightSteelBlue)

        s.Focus.MergeWith(cs)
    End Sub
    Private Sub Glass(ByVal s As CellStyleCollection)
        s.Clear()

        Dim cs As CellStyle = s.Normal
        cs.BackColor = Color.FromArgb(250, 250, 250)
        cs.Border.Width = 0

        cs = s.Normal
        cs.BackgroundImage = GetBitmapResource("Glass_Normal.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch

        cs = s.Alternate
        cs.BackgroundImage = GetBitmapResource("Glass_Alternate.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch

        cs = s.Fixed
        cs.BackgroundImage = GetBitmapResource("Glass_Header.png")
        cs.BackgroundImageLayout = ImageAlignEnum.TileStretch
        cs.Margins = New System.Drawing.Printing.Margins(4, 4, 4, 2)
        cs.Border.Width = 0

        cs = s.SelectedColumnHeader
        cs.MergeWith(s.Fixed)
        cs.BackgroundImage = GetBitmapResource("Glass_HeaderSelected.png")

        s.SelectedRowHeader.MergeWith(cs)

        cs = s.Highlight
        cs.BackgroundImageLayout = ImageAlignEnum.Hide
        cs.BackColor = Color.FromArgb(165, 200, 240)

        s.Focus.MergeWith(cs)
    End Sub

    ' utilities
    Private Function BuildStyleBackground(ByVal background As Color) As Bitmap
        Return BuildStyleBackground(Color.FromArgb(150, background), background, 90.0F)
    End Function
    Private Function BuildStyleBackground(ByVal color1 As Color, ByVal color2 As Color, ByVal angle As Single) As Bitmap
        Dim rc As New Rectangle(0, 0, 10, 15)
        Dim bmp As New Bitmap(rc.Width, rc.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using br As New LinearGradientBrush(rc, color1, color2, angle)
                g.FillRectangle(br, rc)
            End Using
        End Using
        Return bmp
    End Function
    Private Function GetBitmapResource(ByVal name As String) As Bitmap
        Dim asm As Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim array() As String = asm.GetManifestResourceNames()
        For Each item In array

            If item.EndsWith(name) Then
                Return CType(Bitmap.FromStream(asm.GetManifestResourceStream(item)), Bitmap) 'DirectCast(Bitmap.FromStream(asm.GetManifestResourceStream(res)), Bitmap)
            End If
        Next
        Throw New ArgumentException("can't find resource " & name)
    End Function
#End Region

End Class
