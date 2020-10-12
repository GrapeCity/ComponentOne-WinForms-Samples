
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports C1.Win.C1Chart



'/ </summary>
Public Class Form1
    Inherits System.Windows.Forms.Form
    WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
    Private label2 As System.Windows.Forms.Label
    Private propertyGrid1 As System.Windows.Forms.PropertyGrid
    WithEvents zoneSelect As System.Windows.Forms.CheckedListBox
    Private labDescription As System.Windows.Forms.Label
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
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
        Me.zoneSelect = New System.Windows.Forms.CheckedListBox()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' c1Chart1
        ' 
        Me.c1Chart1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.c1Chart1.DataSource = Nothing
        Me.c1Chart1.Location = New System.Drawing.Point(250, 0)
        Me.c1Chart1.Name = "c1Chart1"
        Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=None,Transparent,1;"" /><NamedSty" + "le Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Footer"" ParentN" + "ame=""Control"" StyleData=""Border=None,Transparent,1;"" /><NamedStyle Name=""Area"" P" + "arentName=""Area.default"" /><NamedStyle Name=""Control"" ParentName=""Control.defaul" + "t"" StyleData=""BackColor=WhiteSmoke;"" /><NamedStyle Name=""AxisX"" ParentName=""Area" + """ StyleData=""Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;"" /><NamedStyle " + "Name=""AxisY"" ParentName=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;Alig" + "nVert=Center;"" /><NamedStyle Name=""LabelStyleDefault"" ParentName=""LabelStyleDefa" + "ult.default"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=" + """Border=None,Transparent,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""LabelS" + "tyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;B" + "ackColor=Transparent;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleDat" + "a=""Border=None,Transparent,1;"" /><NamedStyle Name=""Control.default"" ParentName=""" + """ StyleData=""ForeColor=ControlText;Border=None,Transparent,1;BackColor=Control;""" + " /><NamedStyle Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;Alig" + "nHorz=Far;AlignVert=Center;"" /><NamedStyle Name=""Area.default"" ParentName=""Contr" + "ol"" StyleData=""Border=None,Transparent,1;AlignVert=Top;"" /></StyleCollection><Ch" + "artGroupsCollection><ChartGroup Name=""Group1""><DataSerializer DefaultSet=""True"">" + "<DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><" + "SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;" + "2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Double</D" + "ataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataS" + "eriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue" + """ Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12" + ";15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;" + "</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyl" + "e Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>s" + "eries 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Sing" + "le;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></D" + "ataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><Symbol" + "Style Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel><X>1;" + "2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Double</D" + "ataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer></Data" + "SeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=""Group2""><DataSe" + "rializer /></ChartGroup></ChartGroupsCollection><Header Compass=""North"" /><Foote" + "r Compass=""South"" /><Legend Compass=""East"" Visible=""False"" /><ChartArea /><Axes>" + "<Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""" + "True"" AutoMax=""True"" AutoMin=""True"" Compass=""South""><GridMajor /><GridMinor /></" + "Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoM" + "inor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West""><GridMajor /><GridMinor" + " /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" Aut" + "oMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""East""><GridMajor /><GridMin" + "or /></Axis></Axes></Chart2DPropBag>"

        Me.c1Chart1.Size = New System.Drawing.Size(424, 448)
        Me.c1Chart1.TabIndex = 0
        ' 
        ' zoneSelect
        ' 
        Me.zoneSelect.BackColor = System.Drawing.SystemColors.Control
        Me.zoneSelect.Items.AddRange(New Object() {"AlarmZone 0 (Rectangle)", "AlarmZone 1 (Ellipse)", "AlarmZone 2 (Polygon Coordinates)", "AlarmZone 3 (Polygon DataSeries)", "AlarmZone 4 (Fixed Size)"})
        Me.zoneSelect.Location = New System.Drawing.Point(8, 56)
        Me.zoneSelect.Name = "zoneSelect"
        Me.zoneSelect.Size = New System.Drawing.Size(224, 79)
        Me.zoneSelect.TabIndex = 5
        ' 
        ' labDescription
        ' 
        Me.labDescription.Location = New System.Drawing.Point(8, 152)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(224, 64)
        Me.labDescription.TabIndex = 6
        ' 
        ' label2
        ' 
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.label2.Location = New System.Drawing.Point(8, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(224, 48)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Check an AlarmZone entry to show it on the chart.  Select an AlarmZone for short " + "description and to explore its properties."
        ' 
        ' propertyGrid1
        ' 
        Me.propertyGrid1.CommandsVisibleIfAvailable = True
        Me.propertyGrid1.LargeButtons = False
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(8, 224)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(232, 224)
        Me.propertyGrid1.TabIndex = 8
        Me.propertyGrid1.Text = "propertyGrid1"
        Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
        Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1, Me.label2, Me.labDescription, Me.zoneSelect, Me.c1Chart1})
        Me.Location = New System.Drawing.Point(100, 200)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AlarmZones"
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent

#End Region
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()>
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


    Function GetPoints(funcType As Integer, nElements As Integer, xstart As Double, xend As Double, ylow As Double, yhigh As Double) As PointF()
        Dim pts As PointF() = CType(Array.CreateInstance(GetType(PointF), nElements), PointF())

        Select Case funcType
            Case 1
                If (True) Then
                    ' x and y values form a sine curve for 1.5 cycles
                    Dim i As Integer
                    For i = 0 To nElements - 1
                        Dim xd As Double = xstart + i * (xend - xstart) / (nElements - 1)
                        Dim yd As Double = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI
                        Dim yh As Double = (yhigh - ylow) * 0.5
                        pts(i).X = CSng(xd)
                        pts(i).Y = CSng(Math.Sin(yd) * yh + ylow + yh)
                    Next i
                End If

            Case 3
                ' x and y values form a sine curve for 1.5 cycles with random aspects
                Dim rnd As New Random()
                Dim i As Integer
                For i = 0 To nElements - 1
                    Dim xd As Double = xstart + i * (xend - xstart) / (nElements - 1)
                    Dim yd As Double = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI
                    Dim yh As Double = (yhigh - ylow) * 0.5
                    pts(i).X = CSng(xd)
                    pts(i).Y = CSng(Math.Sin(yd) * yh + ylow + yh) + CSng(0.5 * yh * rnd.NextDouble())
                Next i
        End Select

        Return pts
    End Function 'GetPoints


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Form1_Resize(Nothing, Nothing)
        c1Chart1.ChartArea.AxisY.SetMinMax(0, 30)

        ' using the routine GetPoints defined above, create some
        ' additional data and add it to the chart.
        Dim pfs As PointF() = GetPoints(3, 201, 1, 5, 1, 7.5)
        Dim cdsc As ChartDataSeriesCollection = c1Chart1.ChartGroups(0).ChartData.SeriesList
        Dim cds As ChartDataSeries = cdsc.AddNewSeries()
        cds.PointData.CopyDataIn(pfs)
        cds.SymbolStyle.Shape = SymbolShapeEnum.None

        ' turn on all of the checked listbox items.
        Dim z As Integer
        For z = 0 To zoneSelect.Items.Count - 1
            zoneSelect.SetItemChecked(z, True)
        Next z
        ' create the alarm zones.
        Dim azs As AlarmZonesCollection = c1Chart1.ChartArea.PlotArea.AlarmZones

        ' add the rectangle
        Dim az As AlarmZone = azs.AddNewZone()
        az.Name = CStr(zoneSelect.Items(0))
        az.BackColor = Color.FromArgb(100, Color.Red)
        az.Shape = AlarmZoneShapeEnum.Rectangle
        az.UpperExtent = 20
        az.LowerExtent = 16
        az.FarExtent = 2.5
        az.NearExtent = 1.5
        az.Visible = True

        ' add the ellipse
        az = azs.AddNewZone()
        az.BackColor = Color.FromArgb(100, Color.Blue)
        az.Shape = AlarmZoneShapeEnum.Ellipse
        az.Name = CStr(zoneSelect.Items(1))
        az.UpperExtent = 24
        az.LowerExtent = 16
        az.FarExtent = 4.5
        az.NearExtent = 3
        az.Visible = True

        ' add a polygon defined by coordinates.  Coordinates
        ' are obtained using the GetPoints method defined above.
        az = azs.AddNewZone()
        az.BackColor = Color.FromArgb(100, Color.Green)
        az.Shape = AlarmZoneShapeEnum.Polygon
        az.Name = CStr(zoneSelect.Items(2))
        az.UpperExtent = 14
        az.LowerExtent = 8
        az.FarExtent = 4.5
        az.NearExtent = 2.5
        pfs = GetPoints(1, 15, az.NearExtent, az.FarExtent, az.LowerExtent, az.UpperExtent)
        az.PolygonData.PointData.CopyDataIn(pfs)
        az.Visible = True

        ' add a polygon
        az = azs.AddNewZone()
        az.BackColor = Color.FromArgb(100, Color.Yellow)
        az.PatternStyle = HatchStyle.DiagonalBrick
        az.PatternVisible = True
        az.Shape = AlarmZoneShapeEnum.Rectangle
        az.Name = CStr(zoneSelect.Items(4))
        az.UpperExtent = 24
        az.LowerExtent = 24
        az.FarExtent = 3
        az.NearExtent = 3
        az.MinHeight = 32
        az.MinWidth = 32
        az.Visible = True

        ' add another polygon defined by the DataSeries.
        az = azs.AddNewZone()
        az.BackColor = Color.FromArgb(100, Color.Brown)
        az.Shape = AlarmZoneShapeEnum.Polygon
        az.PolygonData.PolygonSource = PolygonSourceEnum.DataSeries
        az.PolygonData.SeriesIndex = 4
        az.Name = CStr(zoneSelect.Items(3))
        az.UpperExtent = 10
        az.LowerExtent = 6
        az.NearExtent = 1.15
        az.FarExtent = 2.25
        az.Visible = True


        ' Add a Header that will be updated to the current AlarmZone
        ' under the cursor.
        c1Chart1.Header.Text = "-- Mouse is not over an AlarmZone --"

        ' now select the first alarmzone
        zoneSelect.SelectedIndex = 0

        ' Add some marker style ValueLabels.  These will be used to
        ' mark the Near and Far extents of the DataSeries AlarmZone
        Dim ax As Axis = c1Chart1.ChartArea.AxisX
        ax.AnnoMethod = AnnotationMethodEnum.Mixed

        Dim vl As ValueLabel = ax.ValueLabels.AddNewLabel()
        vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker
        vl.Text = "M1"
        vl.Color = Color.FromArgb(100, Color.Red)
        vl.GridLine = True
        vl.Moveable = True
        vl.NumericValue = az.NearExtent
        AddHandler vl.ValueChanged, AddressOf ValueLabelChangedHandler
        vl.MarkerSize = 13

        vl = ax.ValueLabels.AddNewLabel()
        vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker
        vl.Text = "M2"
        vl.Color = Color.FromArgb(100, Color.Red)
        vl.GridLine = True
        vl.Moveable = True
        vl.NumericValue = az.FarExtent
        AddHandler vl.ValueChanged, AddressOf ValueLabelChangedHandler
        vl.MarkerSize = 13

        ' Call it to get markers and extensions recalculated.
        ValueLabelChangedHandler(Nothing, Nothing)

        ' Add some instructions about how to use the markers.
        c1Chart1.Footer.Text = "Drag markers M1 and M2 along the X axis" + ControlChars.Lf + "to adjust the extents of the DataSeries sourced AlarmZone"
    End Sub 'Form1_Load


    Private Sub ValueLabelChangedHandler(sender As Object, e As EventArgs)
        Dim vls As ValueLabelsCollection = c1Chart1.ChartArea.AxisX.ValueLabels
        Dim minMarker As String = "M1"
        Dim maxMarker As String = "M2"
        If vls("M1").NumericValue > vls("M2").NumericValue Then
            minMarker = "M2"
            maxMarker = "M1"
        End If

        Dim minValue As Single = CSng(vls(minMarker).NumericValue)
        Dim maxValue As Single = CSng(vls(maxMarker).NumericValue)

        Dim name As String = CStr(zoneSelect.Items(3))
        Dim az As AlarmZone = c1Chart1.ChartArea.PlotArea.AlarmZones(name)

        Dim gi As Integer = az.GroupIndex
        Dim si As Integer = az.PolygonData.SeriesIndex
        Dim cg As ChartGroup = c1Chart1.ChartGroups(gi)
        Dim cds As ChartDataSeries = cg.ChartData.SeriesList(si)

        Dim pfs As PointF() = CType(cds.PointData.CopyDataOut(), PointF())
        Dim pmin As Integer = -1
        Dim pmax As Integer = -1
        Dim minY As Single = Single.MaxValue
        Dim maxY As Single = Single.MinValue
        Dim p As Integer
        For p = 0 To pfs.Length - 1
            If pmin < 0 AndAlso pfs(p).X >= minValue Then
                pmin = p
            End If
            If pmax < 0 AndAlso pfs(p).X >= maxValue Then
                If pfs(p).X = maxValue Then
                    pmax = p
                Else
                    pmax = p - 1
                End If
                Exit For
            End If

            If pmin >= 0 Then
                If pfs(p).Y < minY Then
                    minY = pfs(p).Y
                End If
                If pfs(p).Y > maxY Then
                    maxY = pfs(p).Y
                End If
            End If
        Next p
        az.NearExtent = pfs(pmin).X
        az.FarExtent = pfs(pmax).X
        az.UpperExtent = maxY
        az.LowerExtent = minY
    End Sub 'ValueLabelChangedHandler


    Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
        Dim zones As AlarmZonesCollection = c1Chart1.ChartArea.PlotArea.AlarmZones
        Dim az As AlarmZone = zones.AlarmZoneAtCoord(e.X, e.Y)
        If Not (az Is Nothing) Then
            Cursor.Current = Cursors.Cross
            c1Chart1.Header.Text = "Mouse is over " + az.Name
        Else
            Cursor.Current = Cursors.Default
            c1Chart1.Header.Text = "-- Mouse is not over an AlarmZone --"
        End If
    End Sub 'c1Chart1_MouseMove


    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
        Dim w As Integer = ClientSize.Width - c1Chart1.Left
        Dim h As Integer = ClientSize.Height
        If w < 10 Then
            w = 10
        End If
        If h < 10 Then
            h = 10
        End If
        c1Chart1.Size = New Size(w, h)

        h = ClientSize.Height - propertyGrid1.Top
        If h < 10 Then
            h = 10
        End If
        propertyGrid1.Height = h
    End Sub 'Form1_Resize


    Private Sub zoneSelect_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles zoneSelect.SelectedIndexChanged
        Dim zname As String = CStr(zoneSelect.SelectedItem)
        Dim description As String = ""
        If zname.IndexOf("Rectangle") > 0 Then
            description = "A rectangle defined by data coordinates " + "specified by the AlarmZone extents."

        ElseIf zname.IndexOf("Ellipse") > 0 Then
            description = "An ellipse bounded by a rectangle defined by " + "data coordinates specified by the AlarmZone extents."

        ElseIf zname.IndexOf("Polygon Coordinates") > 0 Then
            description = "A polygon defined by a set of X,Y data coordinates. " + "Polygons are automatically close with a straight line."

        ElseIf zname.IndexOf("Polygon DataSeries") > 0 Then
            description = "A polygon defined by a combination of a ChartDataSeries " + "and the extents of the AlarmZone which are used for clipping " + "the AlarmZone."

        ElseIf zname.IndexOf("Fixed Size") > 0 Then
            description = "Fixed size AlarmZones are located by data coordinates, " + "and sized using the MinWidth and MinHeight properties. " + "Applicable to Rectangle and Ellipse shaped AlarmZones."
        End If

        labDescription.Text = description
        Dim zones As AlarmZonesCollection = c1Chart1.ChartArea.PlotArea.AlarmZones
        propertyGrid1.SelectedObject = zones(zname)
    End Sub 'zoneSelect_SelectedIndexChanged


    Private Sub zoneSelect_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles zoneSelect.ItemCheck
        If e.Index >= 0 Then
            Dim name As String = CStr(zoneSelect.Items(e.Index))
            Dim isChecked As Boolean = e.NewValue.Equals(CheckState.Checked)
            Dim zones As AlarmZonesCollection = c1Chart1.ChartArea.PlotArea.AlarmZones
            If Not (zones(name) Is Nothing) Then
                zones(name).Visible = isChecked
            End If
        End If
    End Sub 'zoneSelect_ItemCheck
End Class 'Form1
