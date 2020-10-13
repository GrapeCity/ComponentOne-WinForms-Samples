Imports C1.Win.C1Input

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
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents c1PictureBox1 As C1.Win.C1Input.C1PictureBox
    Friend WithEvents c1DbNavigator2 As C1.Win.C1Input.C1DbNavigator
    Friend WithEvents c1DateEdit1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents c1DbNavigator1 As C1.Win.C1Input.C1DbNavigator
    Friend WithEvents listView2 As System.Windows.Forms.ListView
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "iVBORw0KGgoAAAANSUhEUgAAAA8AAAAPCAIAAAC0tAIdAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8Y" & _
        "QUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAARxJREFUKFOV0r9LA" & _
        "mEcx/GC/Avqfwi0/8CldhEcXZIbHYQa6u5mQTFvqcHCIUHBWoQO/wAPjmtVaEhcbMvNwKG2d997zjNP7" & _
        "dczPryeD5/vw3fbcZytvx/RG48krN9Hrhjs8rTPc5KxJppJhTebmcv7MHi5ovd8PUzyovSr6IcftMoWH" & _
        "WQv9Mfm7KiWJlPJ9vhGh02+ekebUKthmhQKHOcYKC1TBr0nFyp7aUqaTUolDJ18nnSao8PYDgcJRGcyG" & _
        "AbVKo0Gjx7+n9DpcHlFscjZOdksqZSv46HWsUTf4s2163J/R72OZXF6gqZFtLGi+326Xdptbq5/3wBGI" & _
        "3o9bJtWi3JZJpbsRNjbDLPnvdeXYXlKU1dTLnr/a6s+Aa6zlQ2DPb5kAAAAAElFTkSuQmCC", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "iVBORw0KGgoAAAANSUhEUgAAAA8AAAAPCAIAAAC0tAIdAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8Y" & _
        "QUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAg5JREFUKFNV0l9IU" & _
        "2EYx/GvKdKFreiuLBVbFNth57AdRHTgdtVCSkbkGCrt4MYaxlLcRWJrIQwiEJ3in8HmaGHiCoq6mF4Ei" & _
        "y4scMsJRe4iugm6VoLA4LTDxrL35n3g/fze9+HhrcvlchxZtrov/GlCd5Efe7z4mPO6jp5S1pXVsJxp2" & _
        "s+zk2BmlvQjXqVYniZswXO7ZqpaUlXpYL/jQ76hmGR+hvgwcR/xFMkII1ItoOm27K5FVeW9kvTzW/1i+" & _
        "Uo/S2MsB1lP8WSFVIbnoUpA03r1UFbV9s8lXq6QXWJzg3dJUqtkw0TvMOVh0M1cn6bL7dZ/KogFdeLwc" & _
        "azkbSws8L5AOsz4KFaJvi4sYO0mHSGWgHEPOxtt27+/qs7vqvlk7AYRJ0M9+IwEZII2QvdYe0DsPgEBp" & _
        "id5/ZbNuFx8astPHPOb8Au4z+G243cxn2T1GaMT9FhwmMEbwNpKdyMPr7E2R8Crvbu7zdYWsUXSUUJjD" & _
        "JkxmRHLPZ09zmkQjej1KJ1kEmRnUVUOfhG+imKnS8AnI5pxWrWZYDOhB+N5btpITLH+hkKRySjudlwi1" & _
        "y30WggaqhPE7kUZwBfA2Y9Bx6VTKA7idxn0oFxBMTFsostR1do20I+zVWupDS5AMxhg4RaTCqMjFfpPa" & _
        "1VLLz0tCM0a1aElz0DHiRr9T1fTUieigCAgCVyWa/+pUvwF5kz8uKHDS4QAAAAASUVORK5CYII=", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "iVBORw0KGgoAAAANSUhEUgAAAA8AAAAPCAIAAAC0tAIdAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8Y" & _
        "QUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAUdJREFUKFONkiGPh" & _
        "DAQRvccEomsrKysraxEopGVlUgsbhXJ2pVIJAkKRVYi9y+cRN69UrbZPXXkCymdN99MO3zN83z5/wOdn" & _
        "nVd28Zbo7QsjJbIO8dmAi5p1fe9UaI0qrZBVkslCylyKQpCETtpvl2pOmeHrh6vbrz5q7e+0iRjkRICT" & _
        "S1KH2g13dtl6HizZseVJEii1AELdOO90eLWlEDbMj635THdKcIO9pUN9loJjhRoTkOXmG3LsO/fP/v+f" & _
        "EzQNNPUBpooCSjQtEW5oa2whEYHHTqJ3oHWLzpclhLEKI1lUFu1ztA0KEZH8TdvzkGMum1tSHtHkzFM6" & _
        "IQR0Ay72HDT+PFmjVLHoGDnDUJzR2xx9nigKD5RDJ03iD3TKYociZeOQQYLxklaHOfH5PMsy/OsQEdOf" & _
        "Cf0g45DpTkhBGmx1J+/6hfSUAtgpGeWSwAAAABJRU5ErkJggg==", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "iVBORw0KGgoAAAANSUhEUgAAAAwAAAAMCAIAAADZF8uwAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8Y" & _
        "QUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAJpJREFUKFOFkNERx" & _
        "CAIRL2a6Ime6MYC6Il7uMbk8nOMmTHwWBc+c87xN4CIiDCzyOTQortKrcLn7hQy0xZBOPcI8hvqGjoPA" & _
        "pSMaOmNrLKl1GGGxnGo5rfpI6AG+buhqlJqK7qf34Ze5ZbAZtWPJ6Z9rqmHulzjj9NKmDtPIDGuIURQ3" & _
        "XviRbp78ovAUENm9zLPxtvQGpseaSi+o/mhyZtOQ+AAAAAASUVORK5CYII=", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "iVBORw0KGgoAAAANSUhEUgAAAA8AAAANCAIAAAD5fKMWAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8Y" & _
        "QUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAKBJREFUKFONkcEVw" & _
        "yAMQ91pMkAG6DbM0TXYht5ZINO0InIVPbeH8nww8C0bcRtjhK3juGu3bU+/Wjlort5frSGmh26ZJH2ii" & _
        "/Prfa8ni5ZqCsSM6MxLgehUFcckYqJADQPCHOMjTKghzqT/Qz++aYj+1lYfTOKmXXOrI7orHE0H5YmP6" & _
        "FbybcXv9VYUeA0/gehFm+vlO1O10tyzqcLnQf4GcRFb3T+m1fIAAAAASUVORK5CYII=", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "5", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "45", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "14", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "2", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "9", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Me.button1 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.c1PictureBox1 = New C1.Win.C1Input.C1PictureBox()
        Me.c1DbNavigator2 = New C1.Win.C1Input.C1DbNavigator()
        Me.c1DateEdit1 = New C1.Win.C1Input.C1DateEdit()
        Me.c1DbNavigator1 = New C1.Win.C1Input.C1DbNavigator()
        Me.listView2 = New System.Windows.Forms.ListView()
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        CType(Me.c1DbNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DbNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Location = New System.Drawing.Point(368, 196)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 23)
        Me.button1.TabIndex = 22
        Me.button1.Text = "Copy image"
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button3.Location = New System.Drawing.Point(368, 244)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(100, 23)
        Me.button3.TabIndex = 25
        Me.button3.Text = "Clear image"
        '
        'label6
        '
        Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label6.Location = New System.Drawing.Point(12, 132)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(452, 2)
        Me.label6.TabIndex = 18
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(248, 176)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 16)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Image:"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(228, 54)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 16)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Date:"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button2.Location = New System.Drawing.Point(368, 220)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 23)
        Me.button2.TabIndex = 24
        Me.button2.Text = "Paste image"
        '
        'c1PictureBox1
        '
        Me.c1PictureBox1.Location = New System.Drawing.Point(248, 196)
        Me.c1PictureBox1.Name = "c1PictureBox1"
        Me.c1PictureBox1.Size = New System.Drawing.Size(112, 92)
        Me.c1PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.c1PictureBox1.TabIndex = 23
        Me.c1PictureBox1.TabStop = False
        '
        'c1DbNavigator2
        '
        Me.c1DbNavigator2.Location = New System.Drawing.Point(160, 144)
        Me.c1DbNavigator2.Name = "c1DbNavigator2"
        Me.c1DbNavigator2.Size = New System.Drawing.Size(292, 25)
        Me.c1DbNavigator2.TabIndex = 20
        Me.c1DbNavigator2.VisibleButtons = ((C1.Win.C1Input.NavigatorButtonFlags.Navigation Or C1.Win.C1Input.NavigatorButtonFlags.Apply) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Cancel)
        '
        'c1DateEdit1
        '
        Me.c1DateEdit1.EmptyAsNull = True
        Me.c1DateEdit1.Location = New System.Drawing.Point(228, 72)
        Me.c1DateEdit1.Name = "c1DateEdit1"
        Me.c1DateEdit1.Size = New System.Drawing.Size(200, 21)
        Me.c1DateEdit1.TabIndex = 16
        Me.c1DateEdit1.Tag = Nothing
        '
        'c1DbNavigator1
        '
        Me.c1DbNavigator1.Location = New System.Drawing.Point(160, 16)
        Me.c1DbNavigator1.Name = "c1DbNavigator1"
        Me.c1DbNavigator1.Size = New System.Drawing.Size(300, 25)
        Me.c1DbNavigator1.TabIndex = 14
        Me.c1DbNavigator1.VisibleButtons = ((C1.Win.C1Input.NavigatorButtonFlags.Navigation Or C1.Win.C1Input.NavigatorButtonFlags.Apply) _
                    Or C1.Win.C1Input.NavigatorButtonFlags.Cancel)
        '
        'listView2
        '
        Me.listView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader2})
        Me.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.listView2.LabelEdit = True
        Me.listView2.Location = New System.Drawing.Point(12, 180)
        Me.listView2.Name = "listView2"
        Me.listView2.Size = New System.Drawing.Size(224, 112)
        Me.listView2.TabIndex = 26
        Me.listView2.View = System.Windows.Forms.View.Details
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Image"
        Me.columnHeader2.Width = 200
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(12, 144)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(132, 32)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Items are images in Base64 encoding:"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(116, 32)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Each item is a number of days from today:"
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
        Me.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        ListViewItem6.StateImageIndex = 0
        Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.listView1.Location = New System.Drawing.Point(12, 56)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(192, 64)
        Me.listView1.TabIndex = 17
        Me.listView1.View = System.Windows.Forms.View.List
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Days"
        Me.columnHeader1.Width = 90
        '
        'C1Label1
        '
        Me.C1Label1.DataType = GetType(System.DateTime)
        Me.C1Label1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.C1Label1.Location = New System.Drawing.Point(229, 102)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.NullText = "(null)"
        Me.C1Label1.Size = New System.Drawing.Size(188, 16)
        Me.C1Label1.TabIndex = 27
        Me.C1Label1.Tag = Nothing
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(480, 305)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1DbNavigator2, Me.c1DbNavigator1, Me.C1Label1, Me.button1, Me.button3, Me.label6, Me.label5, Me.label4, Me.button2, Me.c1PictureBox1, Me.c1DateEdit1, Me.listView2, Me.label3, Me.label2, Me.listView1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Using BindingFormatting and BindingParsing events"
        CType(Me.c1DbNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DbNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c1DbNavigator1.SetDataBinding(listView1.Items, "")
        c1DateEdit1.DataBindings.Add("Value", listView1.Items, "Text")
        C1Label1.DataBindings.Add("Value", listView1.Items, "Text", True, DataSourceUpdateMode.Never)
        c1DbNavigator2.SetDataBinding(listView2.Items, "")
        c1PictureBox1.DataBindings.Add("Image", listView2.Items, "Text")
    End Sub

    Private Sub c1DateEdit1_BindingFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.ConvertEventArgs) Handles c1DateEdit1.BindingFormatting, C1Label1.BindingFormatting
        If e.DesiredType Is GetType(DateTime) AndAlso TypeOf e.Value Is String Then
            Dim s As String = CType(e.Value, String)
            If s Is Nothing OrElse s = String.Empty Then
                e.Value = Nothing
            Else
                e.Value = DateTime.Today.AddDays(Int32.Parse(s))
            End If
        End If
    End Sub

    Private Sub c1DateEdit1_BindingParsing(ByVal sender As Object, ByVal e As System.Windows.Forms.ConvertEventArgs) Handles c1DateEdit1.BindingParsing
        If e.DesiredType Is GetType(String) Then
            If TypeOf e.Value Is DBNull OrElse e.Value Is Nothing Then
                e.Value = String.Empty
            ElseIf (TypeOf e.Value Is DateTime) Then
                e.Value = CType(CType(e.Value, DateTime).Subtract(DateTime.Today), TimeSpan).Days.ToString()
            End If
        End If
    End Sub

    Private Sub c1PictureBox1_BindingFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.ConvertEventArgs) Handles c1PictureBox1.BindingFormatting
        If e.DesiredType Is GetType(Image) AndAlso TypeOf e.Value Is String AndAlso CType(e.Value, String) <> String.Empty Then
            e.Value = Convert.FromBase64String(CType(e.Value, String))
        End If
    End Sub

    Private Sub c1PictureBox1_BindingParsing(ByVal sender As Object, ByVal e As System.Windows.Forms.ConvertEventArgs) Handles c1PictureBox1.BindingParsing
        If e.DesiredType Is GetType(String) Then
            If TypeOf e.Value Is Image Then
                e.Value = Convert.ToBase64String(C1PictureBox.ImageToByteArray(CType(e.Value, Image), System.Drawing.Imaging.ImageFormat.Png))
            ElseIf (e.Value Is Nothing OrElse TypeOf e.Value Is DBNull) Then
                e.Value = String.Empty
            End If
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        c1PictureBox1.CopyImage()
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        c1PictureBox1.PasteImage()
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        c1PictureBox1.Image = Nothing
    End Sub
End Class
