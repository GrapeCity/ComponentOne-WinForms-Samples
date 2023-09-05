
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Management
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
    Inherits System.Windows.Forms.Form


    ' Structure that holds the disk information
    Private Class DiskInfo
        Public Size As Int64
        Public FreeSpace As Int64
        Public DeviceID As String
        Public VolumnName As String
        Public FileSystem As String
    End Class 'DiskInfo


    ' Size format enumeration
    Private Enum SizeFormat
        By = 0
        KB
        MB
        GB
    End Enum 'SizeFormat


    WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
    Private panel1 As System.Windows.Forms.Panel

    Private diskCount As Integer = 0
    Private maxDisk As Integer = 24
    Private arrDiskInfo As DiskInfo() = CType(Array.CreateInstance(GetType(DiskInfo), maxDisk), DiskInfo())
    Private prePointIndex As Integer = -1

    Private groupBox1 As System.Windows.Forms.GroupBox
    WithEvents radioButton1 As System.Windows.Forms.RadioButton
    WithEvents radioButton2 As System.Windows.Forms.RadioButton
    WithEvents radioButton3 As System.Windows.Forms.RadioButton
    WithEvents radioButton4 As System.Windows.Forms.RadioButton
    WithEvents chbShowSize As System.Windows.Forms.CheckBox
    Private groupBox2 As System.Windows.Forms.GroupBox
    WithEvents udElev As System.Windows.Forms.NumericUpDown
    Private lblElev As System.Windows.Forms.Label
    WithEvents check3D As System.Windows.Forms.CheckBox
    WithEvents udDepth As System.Windows.Forms.NumericUpDown
    Private lblDepth As System.Windows.Forms.Label
    WithEvents button1 As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        udDepth.Minimum = 5
        udDepth.Maximum = 100
        udDepth.Increment = 5

        udElev.Minimum = 5
        udElev.Maximum = 85
        udElev.Increment = 5

        InitChart()
        GetDiskInfo()
        FillChartData()
        '			PositionDiskLabels();
        c1Chart1.ChartLabels.DefaultLabelStyle.BackColor = SystemColors.Info
        c1Chart1.ChartLabels.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid

        c1Chart1.ChartLabels.LabelsCollection.Clear()
        SetDiskLabels()
        SetSizeLabels(True)

        udDepth.Value = c1Chart1.ChartArea.PlotArea.View3D.Depth
        udElev.Value = c1Chart1.ChartArea.PlotArea.View3D.Elevation
        check3D.Checked = udDepth.Value > 0
        udDepth.Enabled = check3D.Checked
        udElev.Enabled = check3D.Checked
    End Sub 'New


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose


#Region " Windows Form Designer generated code "
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.chbShowSize = New System.Windows.Forms.CheckBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.udElev = New System.Windows.Forms.NumericUpDown()
        Me.lblElev = New System.Windows.Forms.Label()
        Me.check3D = New System.Windows.Forms.CheckBox()
        Me.udDepth = New System.Windows.Forms.NumericUpDown()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.udElev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' c1Chart1
        ' 
        Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Chart1.Location = New System.Drawing.Point(0, 96)
        Me.c1Chart1.Name = "c1Chart1"
        Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Compass=""South"" Min=""" + "1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True" + """ AutoMin=""True"" _onTop=""0"" Max=""5""><GridMajor AutoSpace=""True"" Thickness=""1"" Pa" + "ttern=""Dash"" Color=""LightGray"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Patte" + "rn=""Dash"" Color=""LightGray"" /><Text /></Axis><Axis Compass=""West"" Min=""8"" UnitMa" + "jor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""" + "True"" _onTop=""0"" Max=""26""><GridMajor AutoSpace=""True"" Thickness=""1"" Pattern=""Das" + "h"" Color=""LightGray"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Pattern=""Dash"" " + "Color=""LightGray"" /><Text /></Axis><Axis Compass=""East"" Min=""0"" UnitMajor=""0"" Un" + "itMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onT" + "op=""0"" Max=""0""><GridMajor AutoSpace=""True"" Thickness=""1"" Pattern=""Dash"" Color=""L" + "ightGray"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Pattern=""Dash"" Color=""Ligh" + "tGray"" /><Text /></Axis></Axes><Header Compass=""North""><Text /></Header><ChartGr" + "oupsCollection><ChartGroup><Stacked>False</Stacked><HiLoData>FillFalling=True,Fi" + "llTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Name>" + "Group1</Name><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50<" + "/Bar><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><DataSeries" + "Collection><DataSeriesSerializer><LineStyle Thickness=""1"" Pattern=""Solid"" Color=" + """DarkGoldenrod"" /><Y3 /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sin" + "gle;Double;Double;Double</DataTypes><Y>20;22;19;24;25</Y><SymbolStyle Color=""Cor" + "al"" Shape=""Box"" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeries" + "Serializer><LineStyle Thickness=""1"" Pattern=""Solid"" Color=""DarkGray"" /><Y3 /><Se" + "riesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</D" + "ataTypes><Y>8;12;10;12;15</Y><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><" + "Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSerializer><DataSeriesSerializer><LineSty" + "le Thickness=""1"" Pattern=""Solid"" Color=""DarkGreen"" /><Y3 /><SeriesLabel>series 2" + "</SeriesLabel><DataTypes>Single;Single;Double;Double;Double</DataTypes><Y>10;16;" + "17;15;23</Y><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><Y1 /><X>1;2;3;4;5</X><Y" + "2 /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=""1"" Patter" + "n=""Solid"" Color=""DarkKhaki"" /><Y3 /><SeriesLabel>series 3</SeriesLabel><DataType" + "s>Single;Single;Double;Double;Double</DataTypes><Y>16;19;15;22;18</Y><SymbolStyl" + "e Color=""Crimson"" Shape=""Diamond"" /><Y1 /><X>1;2;3;4;5</X><Y2 /></DataSeriesSeri" + "alizer></DataSeriesCollection></DataSerializer><Bubble>EncodingMethod=Diameter,M" + "aximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True," + "Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True" + "</ShowOutline><Pie>OtherOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Stacked>" + "False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,S" + "howClose=True,ShowOpen=True</HiLoData><Name>Group2</Name><ChartType>XYPlot</Char" + "tType><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><DataSerializer Hole=""3.4028234" + "663852886E+38"" /><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" + "ubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=" + "True,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline><Pie>OtherOffset" + "=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><Footer Compass=""South""><Te" + "xt /></Footer><StyleCollection><NamedStyle><StyleData>Border=None,Control,1;</St" + "yleData><Name>PlotArea</Name><ParentName>Area</ParentName></NamedStyle><NamedSty" + "le><StyleData /><Name>Legend</Name><ParentName>Legend.default</ParentName></Name" + "dStyle><NamedStyle><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Na" + "me><ParentName>Control</ParentName></NamedStyle><NamedStyle><StyleData /><Name>A" + "rea</Name><ParentName>Area.default</ParentName></NamedStyle><NamedStyle><StyleDa" + "ta /><Name>Control</Name><ParentName>Control.default</ParentName></NamedStyle><N" + "amedStyle><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;Bac" + "kColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData><Name>AxisX</Name><" + "ParentName>Area</ParentName></NamedStyle><NamedStyle><StyleData>Rotation=Rotate2" + "70;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;Align" + "Vert=Center;</StyleData><Name>AxisY</Name><ParentName>Area</ParentName></NamedSt" + "yle><NamedStyle><StyleData /><Name>LabelStyleDefault</Name><ParentName>LabelStyl" + "eDefault.default</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Bla" + "ck,1;Wrap=False;AlignVert=Top;</StyleData><Name>Legend.default</Name><ParentName" + ">Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;B" + "ackColor=Transparent;</StyleData><Name>LabelStyleDefault.default</Name><ParentNa" + "me>Control</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1" + ";</StyleData><Name>Header</Name><ParentName>Control</ParentName></NamedStyle><Na" + "medStyle><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Contro" + "l;</StyleData><Name>Control.default</Name><ParentName /></NamedStyle><NamedStyle" + "><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=" + "Transparent;AlignVert=Center;</StyleData><Name>AxisY2</Name><ParentName>Area</Pa" + "rentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;AlignVert=Top" + ";</StyleData><Name>Area.default</Name><ParentName>Control</ParentName></NamedSty" + "le></StyleCollection><Legend Compass=""East"" Visible=""False""><Text /></Legend><Ch" + "artArea /></Chart2DPropBag>"

        Me.c1Chart1.Size = New System.Drawing.Size(680, 390)
        Me.c1Chart1.TabIndex = 0
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox1, groupBox2, button1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(680, 96)
        Me.panel1.TabIndex = 1
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioButton4, radioButton1, radioButton2, radioButton3, chbShowSize})
        Me.groupBox1.Location = New System.Drawing.Point(16, 16)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(224, 72)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Size Format"
        ' 
        ' radioButton4
        ' 
        Me.radioButton4.Location = New System.Drawing.Point(160, 48)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(48, 16)
        Me.radioButton4.TabIndex = 4
        Me.radioButton4.Text = "GB"
        ' 
        ' radioButton1
        ' 
        Me.radioButton1.Location = New System.Drawing.Point(88, 24)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(64, 16)
        Me.radioButton1.TabIndex = 1
        Me.radioButton1.Text = "Byte"
        ' 
        ' radioButton2
        ' 
        Me.radioButton2.Location = New System.Drawing.Point(160, 24)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(48, 16)
        Me.radioButton2.TabIndex = 2
        Me.radioButton2.Text = "KB"
        ' 
        ' radioButton3
        ' 
        Me.radioButton3.Checked = True
        Me.radioButton3.Location = New System.Drawing.Point(88, 48)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(48, 16)
        Me.radioButton3.TabIndex = 3
        Me.radioButton3.TabStop = True
        Me.radioButton3.Text = "MB"
        ' 
        ' chbShowSize
        ' 
        Me.chbShowSize.Checked = True
        Me.chbShowSize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbShowSize.Location = New System.Drawing.Point(8, 32)
        Me.chbShowSize.Name = "chbShowSize"
        Me.chbShowSize.Size = New System.Drawing.Size(56, 16)
        Me.chbShowSize.TabIndex = 1
        Me.chbShowSize.Text = "Show"
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.udElev, lblElev, check3D, udDepth, lblDepth})
        Me.groupBox2.Location = New System.Drawing.Point(256, 16)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(208, 72)
        Me.groupBox2.TabIndex = 7
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "3D"
        ' 
        ' udElev
        ' 
        Me.udElev.Enabled = False
        Me.udElev.Location = New System.Drawing.Point(104, 40)
        Me.udElev.Name = "udElev"
        Me.udElev.Size = New System.Drawing.Size(56, 20)
        Me.udElev.TabIndex = 9
        ' 
        ' lblElev
        ' 
        Me.lblElev.Location = New System.Drawing.Point(64, 40)
        Me.lblElev.Name = "lblElev"
        Me.lblElev.Size = New System.Drawing.Size(32, 16)
        Me.lblElev.TabIndex = 8
        Me.lblElev.Text = "Elev."
        ' 
        ' check3D
        ' 
        Me.check3D.Location = New System.Drawing.Point(8, 16)
        Me.check3D.Name = "check3D"
        Me.check3D.Size = New System.Drawing.Size(40, 40)
        Me.check3D.TabIndex = 7
        Me.check3D.Text = "On"
        ' 
        ' udDepth
        ' 
        Me.udDepth.Enabled = False
        Me.udDepth.Location = New System.Drawing.Point(104, 16)
        Me.udDepth.Name = "udDepth"
        Me.udDepth.Size = New System.Drawing.Size(56, 20)
        Me.udDepth.TabIndex = 7
        ' 
        ' lblDepth
        ' 
        Me.lblDepth.Location = New System.Drawing.Point(64, 16)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(40, 16)
        Me.lblDepth.TabIndex = 7
        Me.lblDepth.Text = "Depth"
        ' 
        ' button1
        ' 
        Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
        Me.button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.button1.ForeColor = System.Drawing.Color.Lime
        Me.button1.Location = New System.Drawing.Point(552, 64)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 24)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Visit Web Site"
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 486)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, panel1})
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "ComponentOne Chart for .NET Demo - Disk Space"
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.udElev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udDepth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent

#End Region
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main



    '/ <summary>
    '/ Get the bottom point of a pie
    '/ </summary>
    '/ <param name="i"></param>
    '/ <returns></returns>
    Private Function GetDiskLabelPosition(i As Integer) As Point
        Dim r As Rectangle = c1Chart1.ChartGroups(0).DataIndexToRect(0, i)

        Dim pt As Point = r.Location
        While True
            Dim s As Integer = 0
            Dim p As Integer = 0
            Dim d As Integer = 0
            c1Chart1.ChartGroups(0).CoordToDataIndex(pt.X, pt.Y, C1.Win.C1Chart.CoordinateFocusEnum.YCoord, s, p, d)

            If d = 0 Then
                pt.Offset(0, 10)
            Else
                pt.Offset(0, -d)
                Exit While
            End If
        End While

        pt.Offset(0, 5)
        Return pt
    End Function 'GetDiskLabelPosition



    '/ <summary>
    '/ Get the disk information of all logic disks
    '/ </summary>
    Private Sub GetDiskInfo()
        Dim diskID As Char = "c"c
        Dim disk As ManagementObject = Nothing
        Dim i As Integer

        For i = 0 To maxDisk - 1
            Try
                disk = New ManagementObject("win32_logicaldisk.deviceid=""" + diskID + ":""")
                disk.Get()

                Dim info As New DiskInfo()
                info.Size = Int64.Parse(disk("Size").ToString())
                info.FreeSpace = Int64.Parse(disk("FreeSpace").ToString())
                info.DeviceID = diskID.ToString()
                info.VolumnName = CStr(disk("VolumeName"))
                info.FileSystem = CStr(disk("FileSystem"))
                arrDiskInfo(i) = info
                diskID = Chr(Asc(diskID) + 1)
            Catch
                Exit For
            End Try
        Next i

        diskCount = Asc(diskID) - Asc("c")
        If diskCount <= 0 Then
            Throw New Exception("Error happend while read the disk information.")
        End If
        ' The last one is used to store the total size information
        Dim allInfo As New DiskInfo()
        allInfo.Size = 0
        allInfo.FreeSpace = 0
        For i = 0 To diskCount - 1
            allInfo.Size += arrDiskInfo(i).Size
            allInfo.FreeSpace += arrDiskInfo(i).FreeSpace
        Next i

        arrDiskInfo(diskCount) = allInfo
    End Sub 'GetDiskInfo


    '/ <summary>
    '/ Initialize the chart
    '/ </summary>
    Private Sub InitChart()
        button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        c1Chart1.BackColor = SystemColors.ControlLightLight

        ' Set up the header
        c1Chart1.Header.Text = "Disk Space Information"
        c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet
        c1Chart1.Header.Style.Border.Thickness = 2
        c1Chart1.Header.Style.Font = New Font("Arial", 14, FontStyle.Bold)
        c1Chart1.Header.Style.ForeColor = Color.MediumBlue

        ' Set up the footer
        c1Chart1.Footer.Text = "Please move your mouse on each pie to see information in detail."
        c1Chart1.Footer.Style.Border.Color = Color.Blue
        c1Chart1.Footer.Style.Font = New Font("Arial", 10)

        ' Setup the legend.
        Dim lgd As Legend = c1Chart1.Legend
        lgd.Compass = CompassEnum.North
        lgd.Location = New Point(8, 20)
        lgd.Style.Border.BorderStyle = BorderStyleEnum.Raised
        lgd.Style.Border.Thickness = 2
        lgd.Style.Font = New Font("Arial Narrow", 10)
        lgd.Style.HorizontalAlignment = AlignHorzEnum.Center
        lgd.Style.BackColor = Color.LightSeaGreen
        lgd.Style.BackColor2 = Color.LightCyan
        lgd.Style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.Horizontal
        lgd.Visible = True

        c1Chart1.ChartArea.PlotArea.View3D.Depth = 10
        c1Chart1.ChartArea.PlotArea.View3D.Elevation = 30

        ' We use Pie Chart in this demo
        c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie
        c1Chart1.ChartGroups(0).Pie.OtherOffset = 20
    End Sub 'InitChart



    '/ <summary>
    '/ Fill the chart data with the disk info
    '/ </summary>
    Private Sub FillChartData()
        Dim pieCount As Integer = diskCount + 1
        Dim arrDiskSize As Int64() = CType(Array.CreateInstance(GetType(Int64), pieCount), Int64())
        Dim arrFreeSpace As Int64() = CType(Array.CreateInstance(GetType(Int64), pieCount), Int64())
        Dim arrUsedSpace As Int64() = CType(Array.CreateInstance(GetType(Int64), pieCount), Int64())
        Dim i As Integer

        For i = 0 To pieCount - 1
            arrDiskSize(i) = arrDiskInfo(i).Size
            arrFreeSpace(i) = arrDiskInfo(i).FreeSpace
            arrUsedSpace(i) = arrDiskInfo(i).Size - arrDiskInfo(i).FreeSpace
        Next i

        ' Clear the existing data
        Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
        grp.ChartData.SeriesList.Clear()

        ' Set up the X series array
        Dim arrXSeries As Integer() = CType(Array.CreateInstance(GetType(Integer), pieCount), Integer())
        For i = 0 To pieCount - 1
            arrXSeries(i) = i
        Next i
        ' Fill the Used Space
        Dim series As ChartDataSeries = grp.ChartData.SeriesList.AddNewSeries()
        series.LineStyle.Color = Color.Blue
        series.Label = "Used Space"
        series.X.CopyDataIn(arrXSeries)
        series.Y.CopyDataIn(arrUsedSpace)

        ' Fill the Used Space
        series = grp.ChartData.SeriesList.AddNewSeries()
        series.LineStyle.Color = Color.OrangeRed
        series.Label = "Free Space"
        series.X.CopyDataIn(arrXSeries)
        series.Y.CopyDataIn(arrFreeSpace)

        c1Chart1.Legend.Text = "Total Capacity: " + ControlChars.Lf + Me.GetSizeString(arrDiskInfo(diskCount).Size, Format)
    End Sub 'FillChartData


    '/ <summary>
    '/ Gets the size string according to the size format
    '/ </summary>
    '/ <param name="size">Size in byte.</param>
    '/ <param name="format">Size formate</param>
    '/ <returns></returns>
    Private Function GetSizeString(size As Int64, format As SizeFormat) As String
        Dim dblSize As Double = size
        Select Case format
            Case SizeFormat.By
                Return String.Format("{0} Bytes", size)

            Case SizeFormat.KB
                Return String.Format("{0:N} KB", size / 1024)

            Case SizeFormat.MB
                dblSize = CDbl(size) / 1024 / 1024
                Return String.Format("{0:N} MB", dblSize)

            Case SizeFormat.GB
                dblSize = CDbl(size) / 1024 / 1024 / 1024
                Return String.Format("{0:N} GB", dblSize)
        End Select

        Return Nothing
    End Function 'GetSizeString

    '/ <summary>
    '/ Gets the selected size format.
    '/ </summary>

    Private ReadOnly Property Format() As SizeFormat
        Get
            If Me.radioButton1.Checked Then
                Return SizeFormat.By
            End If
            If Me.radioButton2.Checked Then
                Return SizeFormat.KB
            End If
            If Me.radioButton3.Checked Then
                Return SizeFormat.MB
            End If
            Return SizeFormat.GB
        End Get
    End Property


    '/ <summary>
    '/ Sets the labels for each slice.
    '/ </summary>
    Private Sub SetDiskLabels()
        Dim lbl As C1.Win.C1Chart.Label = Nothing
        Dim i As Integer
        For i = 0 To diskCount - 1
            ' Add a chart label for each disk
            lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
            lbl.AttachMethod = AttachMethodEnum.Coordinate
            lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.South
            lbl.Style.BackColor = Color.Transparent
            lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
            lbl.Text = "Drive " + arrDiskInfo(i).DeviceID.ToUpper()
            lbl.Offset = 0
            lbl.Visible = True
        Next i

        ' Add a chart label for the summary pie
        lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
        lbl.AttachMethod = AttachMethodEnum.Coordinate
        lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.South
        lbl.Style.BackColor = Color.Transparent
        lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
        lbl.Text = "Total"
        lbl.Offset = 0
        lbl.Visible = True
    End Sub 'SetDiskLabels


    '/ <summary>
    '/ Position the disk labels
    '/ </summary>
    Private Sub PositionDiskLabels()
        If first Then
            Return
        End If
        Dim i As Integer
        For i = 0 To (diskCount + 1) - 1
            Dim p As Point = Me.GetDiskLabelPosition(i)

            Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection(i)
            lbl.AttachMethodData.X = p.X
            lbl.AttachMethodData.Y = p.Y
        Next i
    End Sub 'PositionDiskLabels


    '/ <summary>
    '/ Sets the labels for each slice.
    '/ </summary>
    Private Sub SetSizeLabels(create As Boolean)
        If create Then
            ' Set labels for Used Space
            Dim i As Integer
            For i = 0 To (diskCount + 1) - 1
                Dim j As Integer
                For j = 0 To 1
                    Dim series As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData.SeriesList(j)
                    ' Add a chart label for each slice
                    Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
                    lbl.AttachMethod = AttachMethodEnum.DataIndex
                    lbl.Text = GetSizeString(CType(series.Y(i), Int64), Format)
                    If j = 0 Then
                        lbl.Compass = LabelCompassEnum.North
                    Else
                        lbl.Compass = LabelCompassEnum.South
                    End If
                    lbl.Offset = 0
                    lbl.Visible = True

                    Dim amd As AttachMethodData = lbl.AttachMethodData
                    amd.GroupIndex = 0
                    amd.SeriesIndex = j
                    amd.PointIndex = i
                Next j
            Next i
        Else
            Dim i As Integer
            For i = 0 To (diskCount + 1) - 1
                Dim j As Integer
                For j = 0 To 1
                    Dim series As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData.SeriesList(j)
                    ' Add a chart label for each slice
                    Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection((diskCount + 1 + i * 2 + j))
                    lbl.Text = GetSizeString(CType(series.Y(i), Int64), Format)
                Next j
            Next i
        End If
    End Sub 'SetSizeLabels


    '/ <summary>
    '/ The mouse move event handler.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
        If e.Button.Equals(MouseButtons.None) Then
            Dim s As Integer = -1
            Dim p As Integer = -1
            Dim d As Integer = -1
            Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
            If grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, s, p, d) Then
                If p >= 0 AndAlso d = 0 Then
                    If prePointIndex = -1 AndAlso prePointIndex <> p Then
                        Dim ftr As String
                        Dim info As DiskInfo = arrDiskInfo(p)
                        If p < diskCount Then
                            ftr = String.Format("Total Capacity: {0} | VolumnName: {1} | File System: {2}", GetSizeString(info.Size, Format), info.VolumnName, info.FileSystem)
                        Else
                            ftr = String.Format("Total Capacity: {0}", GetSizeString(info.Size, Format))
                        End If
                        c1Chart1.Footer.Text = ftr
                        prePointIndex = p
                    End If

                Else
                    c1Chart1.Footer.Text = "Please move the mouse on each pie to see information in details."
                    prePointIndex = -1
                End If
            End If
        End If
    End Sub 'c1Chart1_MouseMove


    Private Sub chbShowSize_CheckedChanged(sender As Object, e As System.EventArgs) Handles chbShowSize.CheckedChanged
        Dim show As Boolean = Me.chbShowSize.Checked
        Dim i As Integer
        For i = diskCount + 1 To c1Chart1.ChartLabels.LabelsCollection.Count - 1
            c1Chart1.ChartLabels.LabelsCollection(i).Visible = show
        Next i
    End Sub 'chbShowSize_CheckedChanged

    Private Sub radioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles radioButton4.CheckedChanged, radioButton1.CheckedChanged, radioButton2.CheckedChanged, radioButton3.CheckedChanged
        If c1Chart1.ChartGroups(0).ChartData.SeriesList.Count > 0 Then
            Me.SetSizeLabels(False)

            c1Chart1.Legend.Text = "Total Capacity: " + ControlChars.Lf + Me.GetSizeString(arrDiskInfo(diskCount).Size, Format)
        End If
    End Sub 'radioButton_CheckedChanged


    Private Sub check3D_CheckedChanged(sender As Object, e As System.EventArgs) Handles check3D.CheckedChanged
        If check3D.Checked Then
            c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
            c1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(udElev.Value)

            udDepth.Enabled = True
            udElev.Enabled = True
        Else
            c1Chart1.ChartArea.PlotArea.View3D.Depth = 0

            udDepth.Enabled = False
            udElev.Enabled = False
        End If

        recalc = True
    End Sub 'check3D_CheckedChanged


    Private Sub udDepth_ValueChanged(sender As Object, e As System.EventArgs) Handles udDepth.ValueChanged
        If check3D.Checked Then
            c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
            recalc = True
        End If
    End Sub 'udDepth_ValueChanged


    Private Sub udElev_ValueChanged(sender As Object, e As System.EventArgs) Handles udElev.ValueChanged
        If check3D.Checked Then
            c1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(udElev.Value)
            recalc = True
        End If
    End Sub 'udElev_ValueChanged


    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        System.Diagnostics.Process.Start("https://developer.mescius.com")
    End Sub 'button1_Click


    Private Sub c1Chart1_SizeChanged(sender As Object, e As System.EventArgs) Handles c1Chart1.SizeChanged
        recalc = True
    End Sub 'c1Chart1_SizeChanged

    Private first As Boolean = True
    Private recalc As Boolean = False

    Private Sub c1Chart1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles c1Chart1.Paint
        If first Then
            first = False
            PositionDiskLabels()
        End If

        If recalc Then
            recalc = False
            PositionDiskLabels()
        End If
    End Sub 'c1Chart1_Paint
End Class 'Form1
