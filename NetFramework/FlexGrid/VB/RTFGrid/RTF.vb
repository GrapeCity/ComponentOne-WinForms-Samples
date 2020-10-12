Imports System.Runtime.InteropServices
Imports System.Collections

Public Class RTF
    Inherits System.Windows.Forms.RichTextBox

#Region "** ctor"

    Public Sub New()
        MyBase.BorderStyle = BorderStyle.None
        MyBase.ScrollBars = RichTextBoxScrollBars.None
    End Sub

#End Region

#Region "** Editing"

    Public Function C1EditorGetValue() As Object
        Return MyBase.Rtf
    End Function

    Public Sub C1EditorInitialize(ByVal value As Object, ByVal editorAttributes As IDictionary)
        MyBase.Rtf = CStr(value)
        Me.BackColor = DirectCast(editorAttributes.Item("BackColor"), Color)
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If (e.Modifiers = Keys.Control) Then
            Select Case e.KeyCode
                Case Keys.B
                    Me.ToggleStyle(FontStyle.Bold)
                    e.SuppressKeyPress = True
                    Exit Select
                Case Keys.I
                    Me.ToggleStyle(FontStyle.Italic)
                    e.SuppressKeyPress = True
                    Exit Select
                Case Keys.U
                    Me.ToggleStyle(FontStyle.Underline)
                    e.SuppressKeyPress = True
                    Exit Select
            End Select
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub ToggleStyle(ByVal fs As FontStyle)
        Dim f As Font = MyBase.SelectionFont
        If (Not f Is Nothing) Then
            fs = IIf(((f.Style And fs) = FontStyle.Regular), (f.Style Or fs), (f.Style And Not fs))
            MyBase.SelectionFont = New Font(f, fs)
        End If
    End Sub

#End Region

#Region "** Rendering"

    ' render RTF into a Graphics object
    Public Sub RenderTo(ByVal g As Graphics, ByVal rc As Rectangle)

        ' create temp bitmap
        Dim bmp As Bitmap = New Bitmap(rc.Width, rc.Height)

        ' render RTF into bitmap
        Dim rcSrc As Rectangle = New Rectangle(0, 0, rc.Width, rc.Height)
        Dim gBmp As Graphics = Graphics.FromImage(bmp)
        RenderToDirect(gBmp, rcSrc)

        ' transfer bitmap to original Graphics object
        ' (this honors clipping set in the target Graphics object)
        g.DrawImage(bmp, rc, rcSrc, GraphicsUnit.Pixel)

        ' clean up
        gBmp.Dispose()
        bmp.Dispose()
    End Sub

    ' render the control directly into a given Graphics object 
    ' (this does not honor any clipping set in the target Graphics object)
    Public Sub RenderToDirect(ByVal g As Graphics, ByVal rc As Rectangle)

        ' convert rect from pixels to twips
        rc.X = rc.X * 1440 / g.DpiX
        rc.Y = rc.Y * 1440 / g.DpiY
        rc.Width = rc.X + rc.Width * 1440 / g.DpiX
        rc.Height = rc.Y + rc.Height * 1440 / g.DpiY

        ' get dc
        Dim hdc As IntPtr = g.GetHdc()

        ' set up FORMATRANGE struct
        Dim fmt As FORMATRANGE = New FORMATRANGE()
        fmt.hdc = hdc
        fmt.hdcTarget = hdc
        fmt.rc = rc
        fmt.rcPage = rc
        fmt.cpMin = 0
        fmt.cpMax = -1

        ' render RTF (for this to compile, the project properties must 
        ' be set to allow unsafe blocks)
        Dim render As Integer = 1
        SendMessageFormatRange(Handle, EM_FORMATRANGE, render, fmt)

        ' clean up
        SendMessageFormatRange(Handle, EM_FORMATRANGE, 0, Nothing)

        ' done with dc
        g.ReleaseHdc(hdc)
    End Sub

#End Region

#Region "** Win32"

    Const WM_USER As Integer = &H400
    Const EM_FORMATRANGE As Integer = WM_USER + 57

    ' FORMATRANGE is used by RichEd20.dll to render RTF
    Structure FORMATRANGE
        Dim hdc As IntPtr
        Dim hdcTarget As IntPtr
        Dim rc As Rectangle
        Dim rcPage As Rectangle
        Dim cpMin As Integer
        Dim cpMax As Integer
    End Structure

    ' to make FORMATRANGE calls
    <DllImport("USER32.DLL", CharSet:=CharSet.Auto, EntryPoint:="SendMessage")> _
    Shared Function SendMessageFormatRange( _
        ByVal hWnd As IntPtr, _
        ByVal wMsg As Integer, _
        ByVal wParam As Integer, _
        ByRef lParam As FORMATRANGE) As IntPtr
    End Function

#End Region
End Class
