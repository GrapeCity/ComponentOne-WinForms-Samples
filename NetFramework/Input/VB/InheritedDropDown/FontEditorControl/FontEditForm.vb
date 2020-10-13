Public Class FontEditForm
    Inherits C1.Win.C1Input.DropDownForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitForm()
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
    Friend WithEvents labSampleLabel As System.Windows.Forms.Label
    Friend WithEvents labSample As System.Windows.Forms.Label
    Friend WithEvents lbSizes As System.Windows.Forms.ListBox
    Friend WithEvents edSize As C1.Win.C1Input.C1TextBox
    Friend WithEvents labSize As System.Windows.Forms.Label
    Friend WithEvents labFont As System.Windows.Forms.Label
    Friend WithEvents gbFontStyle As System.Windows.Forms.GroupBox
    Friend WithEvents ckItalic As System.Windows.Forms.CheckBox
    Friend WithEvents ckBold As System.Windows.Forms.CheckBox
    Friend WithEvents gbEffects As System.Windows.Forms.GroupBox
    Friend WithEvents ckUnderline As System.Windows.Forms.CheckBox
    Friend WithEvents ckStrikeout As System.Windows.Forms.CheckBox
    Friend WithEvents cbFontFamily As System.Windows.Forms.ComboBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.labSampleLabel = New System.Windows.Forms.Label()
        Me.labSample = New System.Windows.Forms.Label()
        Me.lbSizes = New System.Windows.Forms.ListBox()
        Me.edSize = New C1.Win.C1Input.C1TextBox()
        Me.labSize = New System.Windows.Forms.Label()
        Me.labFont = New System.Windows.Forms.Label()
        Me.gbFontStyle = New System.Windows.Forms.GroupBox()
        Me.ckItalic = New System.Windows.Forms.CheckBox()
        Me.ckBold = New System.Windows.Forms.CheckBox()
        Me.gbEffects = New System.Windows.Forms.GroupBox()
        Me.ckUnderline = New System.Windows.Forms.CheckBox()
        Me.ckStrikeout = New System.Windows.Forms.CheckBox()
        Me.cbFontFamily = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.edSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFontStyle.SuspendLayout()
        Me.gbEffects.SuspendLayout()
        Me.SuspendLayout()
        '
        'labSampleLabel
        '
        Me.labSampleLabel.Location = New System.Drawing.Point(72, 65)
        Me.labSampleLabel.Name = "labSampleLabel"
        Me.labSampleLabel.Size = New System.Drawing.Size(128, 16)
        Me.labSampleLabel.TabIndex = 20
        Me.labSampleLabel.Text = "Sample Text:"
        '
        'labSample
        '
        Me.labSample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labSample.Location = New System.Drawing.Point(72, 82)
        Me.labSample.Name = "labSample"
        Me.labSample.Size = New System.Drawing.Size(128, 48)
        Me.labSample.TabIndex = 21
        Me.labSample.Text = "AaBbYyZz"
        Me.labSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSizes
        '
        Me.lbSizes.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.lbSizes.Location = New System.Drawing.Point(8, 90)
        Me.lbSizes.Name = "lbSizes"
        Me.lbSizes.Size = New System.Drawing.Size(52, 82)
        Me.lbSizes.TabIndex = 19
        '
        'edSize
        '
        Me.edSize.CustomFormat = "##0.##"
        Me.edSize.DataType = GetType(System.Single)
        Me.edSize.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.edSize.Location = New System.Drawing.Point(8, 66)
        Me.edSize.Name = "edSize"
        Me.edSize.Size = New System.Drawing.Size(52, 21)
        Me.edSize.TabIndex = 18
        Me.edSize.Tag = Nothing
        '
        'labSize
        '
        Me.labSize.Location = New System.Drawing.Point(8, 50)
        Me.labSize.Name = "labSize"
        Me.labSize.Size = New System.Drawing.Size(52, 16)
        Me.labSize.TabIndex = 17
        Me.labSize.Text = "Size:"
        '
        'labFont
        '
        Me.labFont.Location = New System.Drawing.Point(8, 5)
        Me.labFont.Name = "labFont"
        Me.labFont.Size = New System.Drawing.Size(192, 16)
        Me.labFont.TabIndex = 14
        Me.labFont.Text = "Font:"
        '
        'gbFontStyle
        '
        Me.gbFontStyle.Controls.AddRange(New System.Windows.Forms.Control() {Me.ckItalic, Me.ckBold})
        Me.gbFontStyle.Location = New System.Drawing.Point(212, 6)
        Me.gbFontStyle.Name = "gbFontStyle"
        Me.gbFontStyle.Size = New System.Drawing.Size(92, 64)
        Me.gbFontStyle.TabIndex = 16
        Me.gbFontStyle.TabStop = False
        Me.gbFontStyle.Text = " Font Style "
        '
        'ckItalic
        '
        Me.ckItalic.Location = New System.Drawing.Point(10, 40)
        Me.ckItalic.Name = "ckItalic"
        Me.ckItalic.Size = New System.Drawing.Size(74, 16)
        Me.ckItalic.TabIndex = 1
        Me.ckItalic.Text = "Italic"
        '
        'ckBold
        '
        Me.ckBold.Location = New System.Drawing.Point(10, 20)
        Me.ckBold.Name = "ckBold"
        Me.ckBold.Size = New System.Drawing.Size(74, 16)
        Me.ckBold.TabIndex = 0
        Me.ckBold.Text = "Bold"
        '
        'gbEffects
        '
        Me.gbEffects.Controls.AddRange(New System.Windows.Forms.Control() {Me.ckUnderline, Me.ckStrikeout})
        Me.gbEffects.Location = New System.Drawing.Point(212, 76)
        Me.gbEffects.Name = "gbEffects"
        Me.gbEffects.Size = New System.Drawing.Size(92, 64)
        Me.gbEffects.TabIndex = 22
        Me.gbEffects.TabStop = False
        Me.gbEffects.Text = " Effects "
        '
        'ckUnderline
        '
        Me.ckUnderline.Location = New System.Drawing.Point(10, 40)
        Me.ckUnderline.Name = "ckUnderline"
        Me.ckUnderline.Size = New System.Drawing.Size(74, 16)
        Me.ckUnderline.TabIndex = 1
        Me.ckUnderline.Text = "Underline"
        '
        'ckStrikeout
        '
        Me.ckStrikeout.Location = New System.Drawing.Point(10, 20)
        Me.ckStrikeout.Name = "ckStrikeout"
        Me.ckStrikeout.Size = New System.Drawing.Size(74, 16)
        Me.ckStrikeout.TabIndex = 0
        Me.ckStrikeout.Text = "Strikeout"
        '
        'cbFontFamily
        '
        Me.cbFontFamily.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFontFamily.Location = New System.Drawing.Point(8, 21)
        Me.cbFontFamily.Name = "cbFontFamily"
        Me.cbFontFamily.Size = New System.Drawing.Size(192, 22)
        Me.cbFontFamily.Sorted = True
        Me.cbFontFamily.TabIndex = 15
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(231, 149)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(73, 23)
        Me.btnApply.TabIndex = 25
        Me.btnApply.Text = "Apply"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(152, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(72, 149)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(74, 23)
        Me.btnOk.TabIndex = 23
        Me.btnOk.Text = "OK"
        '
        'FontEditForm
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(312, 180)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.labSampleLabel, Me.labSample, Me.lbSizes, Me.edSize, Me.labSize, Me.labFont, Me.gbFontStyle, Me.gbEffects, Me.cbFontFamily, Me.btnApply, Me.btnCancel, Me.btnOk})
        Me.FocusControl = Me.cbFontFamily
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FontEditForm"
        Me.Text = "FontEditForm"
        CType(Me.edSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFontStyle.ResumeLayout(False)
        Me.gbEffects.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _internalChange As Boolean = False
    Private _initFont As Font, _newFont As Font
    Private _gdiCharSet As Byte
    Private _modified As Boolean
    Private _travelMode As Boolean = False
    Private _startX As Int32, _startY As Int32
    Private _prevCursor As Cursor

    Private Sub InitForm()
        Me.KeyPreview = False
        Dim families As FontFamily() = FontFamily.Families
        Dim ff As FontFamily
        For Each ff In families
            cbFontFamily.Items.Add(ff.Name)
        Next
    End Sub

    Private Sub SetInitFont(ByVal font As Font)
        _initFont = font
        btnApply.Enabled = False
        _modified = False
    End Sub

    Private Sub UpdateModified()
        Dim fontFamilyIndex As Int32 = cbFontFamily.SelectedIndex
        Dim size As Object = edSize.Value
        If fontFamilyIndex = -1 OrElse Not (TypeOf size Is Single) Then Return
        Dim ff As FontFamily = New FontFamily(DirectCast(cbFontFamily.Items(fontFamilyIndex), String))
        Dim fs As FontStyle = FontStyle.Regular
        If ckBold.Checked Then fs = fs Or FontStyle.Bold
        If ckItalic.Checked Then fs = fs Or FontStyle.Italic
        If ckStrikeout.Checked Then fs = fs Or FontStyle.Strikeout
        If ckUnderline.Checked Then fs = fs Or FontStyle.Underline
        Dim newFont As Font = Nothing
        Try
            Dim f1 As Font = New Font(ff, DirectCast(size, Single), fs, GraphicsUnit.Point, _gdiCharSet, False)
            Dim f2 As Font = System.Drawing.Font.FromHfont(f1.ToHfont())
            newFont = New Font(ff, f2.SizeInPoints, fs, GraphicsUnit.Point, _gdiCharSet, False)
            f1.Dispose()
            f1 = Nothing
            f2.Dispose()
            f2 = Nothing
        Catch
            Dim fss As FontStyle() = {FontStyle.Regular, FontStyle.Italic, FontStyle.Bold, FontStyle.Bold Or FontStyle.Italic}
            For Each fs In fss
                Try
                    newFont = New Font(ff, DirectCast(size, Single), fs, GraphicsUnit.Point, _gdiCharSet, False)
                    Exit For
                Catch
                End Try
            Next
            If newFont Is Nothing Then Return
        End Try
        If Not _modified AndAlso Not Object.Equals(_initFont, newFont) Then
            btnApply.Enabled = True
            _modified = True
        End If
        labSample.Font = newFont
        _newFont = newFont
    End Sub

    Protected Overrides Sub OnOpen(ByVal e As EventArgs)
        MyBase.OnOpen(e)
        RightToLeft = OwnerControl.RightToLeft
        SetInitFont((DirectCast(OwnerControl, FontEdit))._lastValue)
        If Not _initFont Is Nothing Then
            _newFont = _initFont
        Else
            _newFont = Control.DefaultFont
        End If
        _gdiCharSet = _newFont.GdiCharSet
        _internalChange = True
        Try
            Dim ind As Int32 = cbFontFamily.FindStringExact(_newFont.FontFamily.Name)
            If ind <> -1 Then
                cbFontFamily.SelectedIndex = ind
            Else
                cbFontFamily.SelectedIndex = 0
            End If
            ckBold.Checked = _newFont.Bold
            ckItalic.Checked = _newFont.Italic
            ckStrikeout.Checked = _newFont.Strikeout
            ckUnderline.Checked = _newFont.Underline
            Dim size As Single = _newFont.Size
            lbSizes.SelectedIndex = lbSizes.FindStringExact(size.ToString())
            edSize.Value = size
        Finally
            _internalChange = False
        End Try
        UpdateModified()
    End Sub

    Protected Overrides Sub OnPostChanges(ByVal e As EventArgs)
        MyBase.OnPostChanges(e)
        If _modified Then
            OwnerControl.Value = _newFont
            SetInitFont(_newFont)
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        CloseDropDown(True)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CloseDropDown(False)
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        OnPostChanges(e)
    End Sub

    Private Sub lbSizes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbSizes.SelectedIndexChanged
        If _internalChange Then Return
        Dim ind As Int32 = lbSizes.SelectedIndex
        If ind <> -1 Then
            _internalChange = True
            Try
                edSize.Value = Single.Parse(DirectCast(lbSizes.Items(ind), String))
            Finally
                _internalChange = False
            End Try
        End If
        UpdateModified()
    End Sub

    Private Sub edSize_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles edSize.ValueChanged
        If _internalChange Then Return
        Dim newValue As Object = Nothing
        Try
            newValue = edSize.Value
        Catch
        End Try
        If TypeOf newValue Is Single Then
            _internalChange = True
            Try
                lbSizes.SelectedIndex = lbSizes.FindStringExact(DirectCast(newValue, Single).ToString())
            Finally
                _internalChange = False
            End Try
        End If
        UpdateModified()
    End Sub

    Private Sub cbFontFamily_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbFontFamily.SelectionChangeCommitted, _
    ckBold.CheckedChanged, ckItalic.CheckedChanged, ckStrikeout.CheckedChanged, ckUnderline.CheckedChanged
        If _internalChange Then Return
        UpdateModified()
    End Sub

    Private Sub FontEditForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, _
    labFont.MouseDown, labSize.MouseDown, labSample.MouseDown, labSampleLabel.MouseDown, _
    gbFontStyle.MouseDown, gbEffects.MouseDown

        If Not _travelMode AndAlso (e.Button And System.Windows.Forms.MouseButtons.Left) = System.Windows.Forms.MouseButtons.Left Then
            Dim pt As Point = PointToScreen(New Point(e.X, e.Y))
            _startX = pt.X
            _startY = pt.Y
            _prevCursor = Cursor
            Cursor = Cursors.SizeAll
            _travelMode = True
        End If
    End Sub

    Private Sub FontEditForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, _
    labFont.MouseUp, labSize.MouseUp, labSample.MouseUp, labSampleLabel.MouseUp, _
    gbFontStyle.MouseUp, gbEffects.MouseUp
        Cursor = _prevCursor
        _travelMode = False
    End Sub

    Private Sub FontEditForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, _
    labFont.MouseMove, labSize.MouseMove, labSample.MouseMove, labSampleLabel.MouseMove, _
    gbFontStyle.MouseMove, gbEffects.MouseMove
        If _travelMode AndAlso (e.Button And System.Windows.Forms.MouseButtons.Left) = System.Windows.Forms.MouseButtons.Left Then
            Dim pt As Point = PointToScreen(New Point(e.X, e.Y))
            Left += pt.X - _startX
            Top += pt.Y - _startY
            _startX = pt.X
            _startY = pt.Y
        End If
    End Sub

    Private Sub cbFontFamily_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles cbFontFamily.DrawItem
        Dim str As String = DirectCast(cbFontFamily.Items(e.Index), String)
        e.DrawBackground()
        Dim rtl As Boolean = Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Dim sm As RectangleF
        Dim tm As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height - 2)
        Dim sf As StringFormat = New StringFormat(StringFormat.GenericDefault)
        If Not rtl Then
            sm = New RectangleF(tm.X, tm.Y, 22, tm.Height)
            tm = New RectangleF(tm.X + 27, tm.Y, tm.Width - 27, tm.Height)
        Else
            sm = New RectangleF(tm.X + tm.Width - 22, tm.Y, 22, tm.Height)
            tm = New RectangleF(tm.X, tm.Y, tm.Width - 27, tm.Height)
            sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionRightToLeft
        End If
        e.Graphics.FillRectangle(SystemBrushes.ActiveCaption, sm)
        Dim family As FontFamily = Nothing
        Try
            family = New FontFamily(str)
        Catch
        End Try
        If Not family Is Nothing Then
            Dim size As Single = CType((CType(sm.Height, Double) / 1.2), Single)
            Dim fnt As System.Drawing.Font = Nothing
            Try
                fnt = New Font(family, size, FontStyle.Regular, GraphicsUnit.Pixel)
            Catch
                Try
                    fnt = New Font(family, size, FontStyle.Italic, GraphicsUnit.Pixel)
                Catch
                    Try
                        fnt = New Font(family, size, FontStyle.Bold, GraphicsUnit.Pixel)
                    Catch
                        Try
                            fnt = New Font(family, size, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Pixel)
                        Catch
                        End Try
                    End Try
                End Try
            End Try
            If Not fnt Is Nothing Then
                e.Graphics.DrawString("abcd", fnt, SystemBrushes.ActiveCaptionText, sm, sf)
                fnt.Dispose()
            End If
        End If
        e.Graphics.DrawRectangle(SystemPens.WindowFrame, Rectangle.Round(sm))
        e.Graphics.DrawString(str, e.Font, New SolidBrush(e.ForeColor), tm, sf)
    End Sub

    Private Sub edSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles edSize.KeyDown
        If e.Modifiers = Keys.None AndAlso (e.KeyCode = Keys.F2 OrElse e.KeyCode = Keys.F3 OrElse _
         e.KeyCode = Keys.F4 OrElse e.KeyCode = Keys.F9) Then
            e.Handled = True
        End If
    End Sub

    Private Sub edSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles edSize.KeyPress
        If e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub
End Class
