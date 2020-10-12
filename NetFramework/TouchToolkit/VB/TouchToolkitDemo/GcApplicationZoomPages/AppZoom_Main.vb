Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit

Namespace C1ApplicationZoomPages
    Partial Public Class AppZoom_Main
        Inherits Form
        Public Sub New()
            InitializeComponent()
            PopulateDateGridView()
            dataGridView1.RowCount = 10
        End Sub

        Private Sub PopulateDateGridView()
            Dim row0 As String() = {"2012/12/12", "1128", "ABC商事", "支払勘定", "23.27", "",
                "36,020.30"}
            Dim row1 As String() = {"2012/12/13", "1129", "グレープ株式会社", "支払勘定", "182.30", "",
                "35,837.30"}
            Dim row2 As String() = {"2012/12/14", "1123", "グレープシードオフィス", "支払勘定", "240.00", "",
                "32,433.30"}
            Dim row3 As String() = {"2012/12/15", "1130", "DD株式会社", "支払勘定", "240.00", "",
                "39,426.30"}
            Dim row4 As String() = {"2012/12/22", "1131", "ブドウ貿易", "支払勘定", "1,275.00", "",
                "39,222.30"}
            Dim row5 As String() = {"2012/12/25", "1209", "パワーツール", "支払勘定", "1,275.00", "",
                "38,134.30"}
            Dim row6 As String() = {"2012/12/25", "1212", "オレンジ商事", "支払勘定", "1,275.00", "",
                "36,433.30"}
            Dim row7 As String() = {"2012/12/26", "1204", "レイザーコンサルタント", "支払勘定", "375.00", "",
                "36,020.30"}
            Dim row8 As String() = {"2012/12/26", "1215", "グレープ株式会社", "支払勘定", "2,835.00", "",
                "36,433.30"}
            Dim row9 As String() = {"2012/12/27", "1218", "ITC株式会社", "支払勘定", "2,835.00", "",
                "33,479.30"}
            Dim row10 As String() = {"2012/12/29", "1221", "ワイン事務所", "支払勘定", "23.27", "",
                "32,011.30"}


            If True Then
                Dim rows As DataGridViewRowCollection = Me.dataGridView1.Rows
                rows.Add(row0)
                rows.Add(row1)
                rows.Add(row2)
                rows.Add(row3)
                rows.Add(row4)
                rows.Add(row5)
                rows.Add(row6)
                rows.Add(row7)
                rows.Add(row8)
                rows.Add(row9)
                rows.Add(row0)
            End If
        End Sub

        Private Sub myImageButton_Click(sender As Object, e As EventArgs)
            Dim form1 As Form = Nothing
            If Object.ReferenceEquals(sender, Me.myImageButton1) Then
                form1 = New AppZoom_Child1()
            ElseIf Object.ReferenceEquals(sender, Me.myImageButton2) Then
                form1 = New AppZoom_Child2()
            ElseIf Object.ReferenceEquals(sender, Me.myImageButton6) Then
                form1 = New AppZoom_Child3()
            Else
                MessageBox.Show("Show other forms.")
            End If
            If form1 IsNot Nothing Then
                form1.StartPosition = FormStartPosition.CenterParent
                form1.ShowDialog(Me)
            End If
        End Sub

    End Class

    Public Class MyImageButtonZoomPolicy
        Inherits ZoomPolicy
        Public Overrides ReadOnly Property TargetType() As Type
            Get
                Return GetType(MyImageButton)
            End Get
        End Property

        Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
            Dim imageBUtton As MyImageButton = TryCast(control, MyImageButton)
            imageBUtton.ImageFactor = infos.TargetFactor
            MyBase.ZoomBounds(control, infos)
        End Sub
    End Class



    Public Class MyImageButton
        Inherits Button
        Public Sub New()
            Me.TextAlign = ContentAlignment.BottomCenter
            Me.ImageFactor = 1
        End Sub

        Private Const ImagePadding As Integer = 4

        Public Property RenderImage() As Bitmap
            Get
                Return m_RenderImage
            End Get
            Set(value As Bitmap)
                m_RenderImage = value
            End Set
        End Property
        Private m_RenderImage As Bitmap

        Public Property ImageFactor() As Single
            Get
                Return m_ImageFactor
            End Get
            Set(value As Single)
                m_ImageFactor = value
            End Set
        End Property
        Private m_ImageFactor As Single

        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            MyBase.OnPaint(pevent)
            If RenderImage IsNot Nothing Then
                Dim width As Integer = CInt(Math.Truncate(Math.Round(RenderImage.Width * ImageFactor)))
                Dim height As Integer = CInt(Math.Truncate(Math.Round(RenderImage.Height * ImageFactor)))
                Dim x As Integer = (Me.ClientSize.Width - width) \ 2
                Dim y As Integer = CInt(Math.Truncate(Math.Round(ImagePadding * ImageFactor)))
                pevent.Graphics.DrawImage(RenderImage, New Rectangle(x, y, width, height))
            End If
        End Sub
    End Class
End Namespace