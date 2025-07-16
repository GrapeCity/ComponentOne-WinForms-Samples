Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports C1.Win.FlexGrid
Imports C1.Win.C1Chart

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
    Friend WithEvents splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents _btnInsert As System.Windows.Forms.Button
    Friend WithEvents _checkRotate As System.Windows.Forms.CheckBox
    Friend WithEvents _checkGridlines As System.Windows.Forms.CheckBox
    Friend WithEvents _btnDelete As System.Windows.Forms.Button
    Friend WithEvents _chart As C1.Win.C1Chart.C1Chart
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me._btnInsert = New System.Windows.Forms.Button()
        Me._checkRotate = New System.Windows.Forms.CheckBox()
        Me._checkGridlines = New System.Windows.Forms.CheckBox()
        Me._btnDelete = New System.Windows.Forms.Button()
        Me._chart = New C1.Win.C1Chart.C1Chart()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        Me.panel1.SuspendLayout()
        CType(Me._chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitter1
        '
        Me.splitter1.Location = New System.Drawing.Point(0, 40)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(256, 309)
        Me.splitter1.TabIndex = 4
        Me.splitter1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me._btnInsert, Me._checkRotate, Me._checkGridlines, Me._btnDelete})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(632, 40)
        Me.panel1.TabIndex = 5
        '
        '_btnInsert
        '
        Me._btnInsert.Location = New System.Drawing.Point(8, 8)
        Me._btnInsert.Name = "_btnInsert"
        Me._btnInsert.Size = New System.Drawing.Size(104, 24)
        Me._btnInsert.TabIndex = 1
        Me._btnInsert.Text = "Insert Data Point"
        '
        '_checkRotate
        '
        Me._checkRotate.Location = New System.Drawing.Point(256, 12)
        Me._checkRotate.Name = "_checkRotate"
        Me._checkRotate.Size = New System.Drawing.Size(112, 16)
        Me._checkRotate.TabIndex = 0
        Me._checkRotate.Text = "Rotate Labels"
        '
        '_checkGridlines
        '
        Me._checkGridlines.Location = New System.Drawing.Point(384, 12)
        Me._checkGridlines.Name = "_checkGridlines"
        Me._checkGridlines.Size = New System.Drawing.Size(112, 16)
        Me._checkGridlines.TabIndex = 0
        Me._checkGridlines.Text = "Gridlines"
        '
        '_btnDelete
        '
        Me._btnDelete.Location = New System.Drawing.Point(120, 8)
        Me._btnDelete.Name = "_btnDelete"
        Me._btnDelete.Size = New System.Drawing.Size(104, 24)
        Me._btnDelete.TabIndex = 1
        Me._btnDelete.Text = "Delete Data Point"
        '
        '_chart
        '
        Me._chart.Dock = System.Windows.Forms.DockStyle.Fill
        Me._chart.Location = New System.Drawing.Point(256, 40)
        Me._chart.Name = "_chart"
        Me._chart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Footer Compass=""South""><Text /><" & _
    "/Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartArea /><Ch" & _
    "artGroupsCollection><ChartGroup><DataSerializer DefaultSet=""True""><DataSeriesCol" & _
    "lection><DataSeriesSerializer><Y1 /><SeriesLabel>series 0</SeriesLabel><DataType" & _
    "s>Single;Single;Single;Single;Single</DataTypes><X>1;2;3;4;5</X><Y2 /><Y>20;22;1" & _
    "9;24;25</Y><Y3 /><LineStyle Pattern=""Solid"" Thickness=""1"" Color=""DarkGoldenrod"" " & _
    "/><SymbolStyle Shape=""Box"" Color=""Coral"" /></DataSeriesSerializer><DataSeriesSer" & _
    "ializer><Y1 /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single" & _
    ";Single;Single</DataTypes><X>1;2;3;4;5</X><Y2 /><Y>8;12;10;12;15</Y><Y3 /><LineS" & _
    "tyle Pattern=""Solid"" Thickness=""1"" Color=""DarkGray"" /><SymbolStyle Shape=""Dot"" C" & _
    "olor=""CornflowerBlue"" /></DataSeriesSerializer></DataSeriesCollection></DataSeri" & _
    "alizer><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Name>Group1</Name><Polar>Degr" & _
    "ees=True,PiRatioAnnotations=True,Start=0</Polar><ShowOutline>True</ShowOutline><" & _
    "Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><" & _
    "ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diame" & _
    "ter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTranspar" & _
    "ent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData></ChartGroup><Ch" & _
    "artGroup><DataSerializer /><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Name>Grou" & _
    "p2</Name><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><ShowOutline" & _
    ">True</ShowOutline><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOff" & _
    "set=0,Start=0</Pie><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>" & _
    "EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalli" & _
    "ng=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoD" & _
    "ata></ChartGroup></ChartGroupsCollection><StyleCollection><NamedStyle><Name>Plot" & _
    "Area</Name><ParentName>Area</ParentName><StyleData>Border=None,Control,1;</Style" & _
    "Data></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</Par" & _
    "entName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName>Con" & _
    "trol</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><Name" & _
    "dStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Name" & _
    "dStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName><" & _
    "StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentN" & _
    "ame><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor" & _
    "=Transparent;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</" & _
    "Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Cont" & _
    "rol,1;AlignHorz=Near;BackColor=Transparent;AlignVert=Center;</StyleData></NamedS" & _
    "tyle><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.def" & _
    "ault</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Nam" & _
    "e><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;Alig" & _
    "nVert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</" & _
    "Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;BackColor=" & _
    "Transparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>" & _
    "Control</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><N" & _
    "amedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=Control" & _
    "Text;Border=None,Control,1;BackColor=Control;</StyleData></NamedStyle><NamedStyl" & _
    "e><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;B" & _
    "order=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</" & _
    "StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Control<" & _
    "/ParentName><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData></NamedSt" & _
    "yle></StyleCollection><Header Compass=""North""><Text /></Header><Axes><Axis Compa" & _
    "ss=""South"" Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMi" & _
    "nor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""><GridMajor AutoSpace=""True"" " & _
    "Pattern=""Dash"" Thickness=""1"" Color=""LightGray"" /><GridMinor AutoSpace=""True"" Pat" & _
    "tern=""Dash"" Thickness=""1"" Color=""LightGray"" /><Text /></Axis><Axis Compass=""West" & _
    """ Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True""" & _
    " AutoMax=""True"" AutoMin=""True"" _onTop=""0""><GridMajor AutoSpace=""True"" Pattern=""D" & _
    "ash"" Thickness=""1"" Color=""LightGray"" /><GridMinor AutoSpace=""True"" Pattern=""Dash" & _
    """ Thickness=""1"" Color=""LightGray"" /><Text /></Axis><Axis Compass=""East"" Max=""0"" " & _
    "Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""T" & _
    "rue"" AutoMin=""True"" _onTop=""0""><GridMajor AutoSpace=""True"" Pattern=""Dash"" Thickn" & _
    "ess=""1"" Color=""LightGray"" /><GridMinor AutoSpace=""True"" Pattern=""Dash"" Thickness" & _
    "=""1"" Color=""LightGray"" /><Text /></Axis></Axes></Chart2DPropBag>"
        Me._chart.Size = New System.Drawing.Size(376, 309)
        Me._chart.TabIndex = 7
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "4,1,0,0,0,85,Columns:0{Width:35;}" & Microsoft.VisualBasic.ChrW(9) & "1{Caption:""X"";TextAlign:CenterCenter;TextAlignF" & _
        "ixed:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Series 1"";DataType:System.Single;Format:""#,##0.00" & _
        """;TextAlign:RightCenter;TextAlignFixed:RightCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Caption:""Series 2"";DataTy" & _
        "pe:System.Single;Format:""#,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCen" & _
        "ter;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex.ForeColor = System.Drawing.SystemColors.WindowText
        Me._flex.Location = New System.Drawing.Point(8, 40)
        Me._flex.Name = "_flex"
        Me._flex.Rows.Count = 13
        Me._flex.Size = New System.Drawing.Size(248, 304)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;Format:""#,##0.00"";}" & Microsoft.VisualBasic.ChrW(9) & "Search{B" & _
        "ackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{" & _
        "BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor" & _
        ":Black;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "S" & _
        "ubtotal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:Control" & _
        "DarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & _
        "" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:Contr" & _
        "olDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me._chart, Me.splitter1, Me.panel1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Charting with C1Chart"
        Me.panel1.ResumeLayout(False)
        CType(Me._chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UpdateChart()

        ' populate X labels
        Dim col As Integer = 1
        Dim ax As Axis = _chart.ChartArea.AxisX
        ax.ValueLabels.Clear()
        Dim i As Integer
        For i = _flex.Rows.Fixed To _flex.Rows.Count - 1
            ax.ValueLabels.Add(i, _flex(i, col).ToString())
        Next
        ax.AnnoMethod = AnnotationMethodEnum.ValueLabels

        ' populate series
        Dim cnt As Integer = _flex.Rows.Count - _flex.Rows.Fixed
        Dim arr(cnt - 1) As Single
        Dim cds As chartdataseries
        For Each cds In _chart.ChartGroups(0).ChartData.SeriesList

            ' increment grid column index
            col += 1
            If col >= _flex.Cols.Count Then
                Exit For
            End If

            ' x values
            For i = 0 To cnt - 1
                arr(i) = i
            Next
            cds.X.CopyDataIn(arr)

            ' y values
            For i = 0 To cnt - 1
                Try
                    arr(i) = CType(_flex(i + _flex.Rows.Fixed, col), Single)
                Catch
                    arr(i) = CType(cds.Y.Hole, Single)
                End Try
            Next
            cds.Y.CopyDataIn(arr)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' populate grid
        Dim rnd As Random = New Random()
        Dim dt As DateTime
        Dim i As Integer
        For i = 1 To 12
            dt = New DateTime(2002, i, 1)
            _flex(i, 1) = String.Format("{0:MMMM}", dt)
            _flex(i, 2) = rnd.Next(100000) \ 100.0
            _flex(i, 3) = rnd.Next(100000) \ 100.0
        Next

        ' and update the chart
        UpdateChart()
    End Sub

    Private Sub _checkRotate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _checkRotate.CheckedChanged
        Dim ax As axis = _chart.chartarea.axisx
        If _checkRotate.Checked Then
            ax.annotationrotation = 270
        Else
            ax.annotationrotation = 0
        End If
    End Sub

    Private Sub _checkGridlines_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _checkGridlines.CheckedChanged
        Dim cgs As ChartGridStyle() = New ChartGridStyle() {_chart.ChartArea.AxisX.GridMajor, _chart.ChartArea.AxisY.GridMajor}
        Dim style As chartgridstyle
        For Each style In cgs
            style.Color = Color.DarkGray
            style.Visible = _checkGridlines.Checked
        Next
    End Sub

    Private Sub _flex_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.AfterEdit
        UpdateChart()
    End Sub

    Private Sub _chart_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _chart.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim series As Integer = -1
            Dim point As Integer = -1
            Dim distance As Integer = -1
            Dim grp As ChartGroup = _chart.ChartGroups(0)
            Dim foundDataPoint As Boolean = grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, series, point, distance)
            If foundDataPoint AndAlso distance < 10 Then
                _flex.Select(point + _flex.Rows.Fixed, series + _flex.Cols.Fixed + 1)
                _flex.Focus()
            End If
        End If
    End Sub

    Private Sub _btnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnInsert.Click
        Dim index As Integer = _flex.Row
        If index < 1 Then index = _flex.Rows.Count
        _flex.Rows.Insert(index)
        _flex(index, 1) = "New Point"
        _flex(index, 2) = 0
        _flex(index, 3) = 0
        UpdateChart()
    End Sub

    Private Sub _btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _btnDelete.Click
        Dim index As Integer = _flex.Row
        If (index >= 1) Then
            _flex.Rows.Remove(index)
        End If
        UpdateChart()
    End Sub
End Class
