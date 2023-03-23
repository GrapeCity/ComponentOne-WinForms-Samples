
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Reflection
Imports System.Runtime.InteropServices

Namespace FlexReportExplorer
    Partial Public Class PreviewForm
        Inherits Form
#Region "Interop"
        '' Const WS_POPUP As Integer = CInt(&H80000000UI)
        Const SW_SHOWNOACTIVATE As Integer = 4
        Const WS_EX_TOPMOST As Integer = &H8
        Const WS_EX_NOACTIVATE As Integer = &H8000000
        Const WS_EX_LAYERED As Integer = &H80000
        Const AW_BLEND As Integer = &H80000
        Const AW_HIDE As Integer = &H10000

        <DllImport("user32")>
        Private Shared Function SetWindowPos(hWnd As IntPtr, hWndInsertAfter As IntPtr, x As Integer, y As Integer, cx As Integer, cy As Integer,
            wFlags As Integer) As Integer
        End Function
        Const SWP_NOSIZE As Integer = &H1, SWP_NOMOVE As Integer = &H2, SWP_NOZORDER As Integer = &H4, SWP_NOREDRAW As Integer = &H8, SWP_NOACTIVATE As Integer = &H10, SWP_FRAMECHANGED As Integer = &H20,
            SWP_SHOWWINDOW As Integer = &H40, SWP_HIDEWINDOW As Integer = &H80, SWP_NOCOPYBITS As Integer = &H100, SWP_NOOWNERZORDER As Integer = &H200, SWP_NOSENDCHANGING As Integer = &H400, SWP_DEFERERASE As Integer = &H2000,
            SWP_ASYNCWINDOWPOS As Integer = &H4000

        <DllImport("user32")>
        Private Shared Function AnimateWindow(hWnd As IntPtr, dwTime As Integer, dwFlags As UInteger) As Boolean
        End Function
#End Region

        Protected Overrides ReadOnly Property CreateParams() As CreateParams

            ' [SecurityPermission(SecurityAction.LinkDemand)]
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                ' NOTE: WS_EX_NOACTIVATE works only on w2k/xp.
                Try
                    Dim os As OperatingSystem = Environment.OSVersion
                    Select Case os.Platform
                        Case PlatformID.Win32NT
                            If os.Version.Major > 4 Then
                                cp.ExStyle = cp.ExStyle Or WS_EX_NOACTIVATE Or WS_EX_TOPMOST
                            Else
                                cp.ExStyle = cp.ExStyle Or WS_EX_TOPMOST
                            End If
                            Exit Select
                        Case Else
                            cp.ExStyle = cp.ExStyle Or WS_EX_TOPMOST
                            Exit Select
                    End Select
                Catch
                End Try
                Return cp
            End Get
        End Property

        ' This is to make sure our dummy var with its assignment are not optimized away
        ' (we need to have the handle for preview to show the first time):
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Public Sub New()
            InitializeComponent()
            CreateHandle()
            ' SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Dim dummy = Me.pictureBox1.Handle
        End Sub

        Public Sub Show(location As Point)
            Me.Location = location
            SetWindowPos(Me.Handle, IntPtr.Zero, location.X, location.Y, Me.Size.Width, Me.Size.Height,
                SWP_HIDEWINDOW Or SWP_NOACTIVATE)
            AnimateWindow(Me.Handle, 500, AW_BLEND)
        End Sub

        Public Shadows Sub Hide()
            If Me.IsHandleCreated Then
                AnimateWindow(Me.Handle, 500, AW_HIDE Or AW_BLEND)
            End If
        End Sub
    End Class
End Namespace

