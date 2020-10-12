
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuFile As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelp As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   WithEvents buttonClearLabels As System.Windows.Forms.Button
   Private grpLabels As System.Windows.Forms.GroupBox
   WithEvents lblOne As System.Windows.Forms.Label
   WithEvents lblTwo As System.Windows.Forms.Label
   WithEvents lblThree As System.Windows.Forms.Label
   WithEvents lblFour As System.Windows.Forms.Label
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents menuHelpMoreInfo As System.Windows.Forms.MenuItem
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
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
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuFile = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuHelp = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.buttonClearLabels = New System.Windows.Forms.Button()
      Me.grpLabels = New System.Windows.Forms.GroupBox()
      Me.lblFour = New System.Windows.Forms.Label()
      Me.lblThree = New System.Windows.Forms.Label()
      Me.lblTwo = New System.Windows.Forms.Label()
      Me.lblOne = New System.Windows.Forms.Label()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.menuHelpMoreInfo = New System.Windows.Forms.MenuItem()
      Me.grpLabels.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, menuHelp})
      ' 
      ' menuFile
      ' 
      Me.menuFile.Index = 0
      Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      Me.menuFile.Text = "File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "Exit"
      ' 
      ' menuHelp
      ' 
      Me.menuHelp.Index = 1
      Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpMoreInfo, menuHelpAbout})
      Me.menuHelp.Text = "Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 1
      Me.menuHelpAbout.Text = "About"
      ' 
      ' buttonClearLabels
      ' 
      Me.buttonClearLabels.Location = New System.Drawing.Point(0, 8)
      Me.buttonClearLabels.Name = "buttonClearLabels"
      Me.buttonClearLabels.Size = New System.Drawing.Size(96, 32)
      Me.buttonClearLabels.TabIndex = 0
      Me.buttonClearLabels.Text = "Clear All Labels"
      ' 
      ' grpLabels
      ' 
      Me.grpLabels.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblFour, lblThree, lblTwo, lblOne})
      Me.grpLabels.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpLabels.Location = New System.Drawing.Point(112, 0)
      Me.grpLabels.Name = "grpLabels"
      Me.grpLabels.Size = New System.Drawing.Size(296, 48)
      Me.grpLabels.TabIndex = 1
      Me.grpLabels.TabStop = False
      ' 
      ' lblFour
      ' 
      Me.lblFour.Font = New System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
      Me.lblFour.Location = New System.Drawing.Point(200, 14)
      Me.lblFour.Name = "lblFour"
      Me.lblFour.Size = New System.Drawing.Size(80, 26)
      Me.lblFour.TabIndex = 3
      Me.lblFour.Text = "Four"
      ' 
      ' lblThree
      ' 
      Me.lblThree.Font = New System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
      Me.lblThree.Location = New System.Drawing.Point(128, 14)
      Me.lblThree.Name = "lblThree"
      Me.lblThree.Size = New System.Drawing.Size(72, 26)
      Me.lblThree.TabIndex = 2
      Me.lblThree.Text = "Three"
      ' 
      ' lblTwo
      ' 
      Me.lblTwo.Font = New System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
      Me.lblTwo.Location = New System.Drawing.Point(72, 14)
      Me.lblTwo.Name = "lblTwo"
      Me.lblTwo.Size = New System.Drawing.Size(56, 26)
      Me.lblTwo.TabIndex = 1
      Me.lblTwo.Text = "Two"
      ' 
      ' lblOne
      ' 
      Me.lblOne.Font = New System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
      Me.lblOne.Location = New System.Drawing.Point(16, 14)
      Me.lblOne.Name = "lblOne"
      Me.lblOne.Size = New System.Drawing.Size(56, 26)
      Me.lblOne.TabIndex = 0
      Me.lblOne.Text = "One"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.AllowDrop = True
      Me.c1Chart1.BackColor = System.Drawing.Color.LightSlateGray
      Me.c1Chart1.Location = New System.Drawing.Point(0, 56)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Max=""2.5"" Min=""0.5"" U" + "nitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""False"" AutoMinor=""True"" AutoMax=""False"" " + "AutoMin=""False"" TickMinor=""None"" AnnoMethod=""ValueLabels"" _onTop=""0"" Compass=""We" + "st""><ValueLabels><ValueLabel Value=""1"" Text=""Group 2"" /><ValueLabel Value=""2"" Te" + "xt=""Group 1"" /></ValueLabels><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Li" + "ghtGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""Light" + "Gray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""30"" Min=""0"" UnitMajor=""10"" Unit" + "Minor=""5"" AutoMajor=""False"" AutoMinor=""True"" AutoMax=""False"" AutoMin=""False"" _on" + "Top=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGr" + "ay"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray""" + " Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""" + "0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Co" + "mpass=""North""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""" + "Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text>Header</Text></Heade" + "r><ChartGroupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True" + ",Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</" + "Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" + "e=True,ShowOpen=True</HiLoData><ChartType>Bar</ChartType><Bubble>EncodingMethod=" + "Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer" + " DefaultSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y>6;15</Y><LineS" + "tyle Thickness=""1"" Color=""Red"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=" + """Coral"" /><SeriesLabel>Alpha</SeriesLabel><DataTypes>Single;Single;Single;Single" + ";Single</DataTypes><Y1 /><X>1;2</X><Y3 /><Y2 /></DataSeriesSerializer><DataSerie" + "sSerializer><Y>15;7</Y><LineStyle Thickness=""1"" Color=""Tan"" Pattern=""Solid"" /><S" + "ymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabel>Beta</SeriesLabel><" + "DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2</X><Y3 /><Y" + "2 /></DataSeriesSerializer><DataSeriesSerializer><Y>24.2;11</Y><LineStyle Thickn" + "ess=""1"" Color=""LimeGreen"" Pattern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Corn" + "silk"" /><SeriesLabel>Gamma</SeriesLabel><DataTypes>Single;Single;Single;Single;S" + "ingle</DataTypes><Y1 /><X>1;2</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesS" + "erializer><Y>4.6;15.1</Y><LineStyle Thickness=""1"" Color=""MediumTurquoise"" Patter" + "n=""Solid"" /><SymbolStyle Shape=""Diamond"" Color=""Crimson"" /><SeriesLabel>Delta</S" + "eriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2" + "</X><Y3 /><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><" + "ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=90</Bar><Pie>Ot" + "herOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnn" + "otations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><St" + "acked>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=F" + "alse,ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble" + ">EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name" + "><DataSerializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterW" + "idth=50</Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollectio" + "n><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName" + "><StyleData>Border=Solid,ControlText,1;BackColor=AliceBlue;</StyleData></NamedSt" + "yle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</ParentName><Style" + "Data>Border=RaisedBevel,LightYellow,2;AlignHorz=Center;BackColor=LightYellow;Fon" + "t=Microsoft Sans Serif, 12pt, style=Bold;</StyleData></NamedStyle><NamedStyle><N" + "ame>Footer</Name><ParentName>Control</ParentName><StyleData>ForeColor=Bisque;Bor" + "der=None,LightSlateGray,1;Font=Microsoft Sans Serif, 12pt, style=Bold;</StyleDat" + "a></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default</ParentName" + "><StyleData>Border=RaisedBevel,LightSteelBlue,2;BackColor=LightSteelBlue;</Style" + "Data></NamedStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</P" + "arentName><StyleData>BackColor=LightSlateGray;</StyleData></NamedStyle><NamedSty" + "le><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;" + "Border=None,LightSteelBlue,1;AlignHorz=Near;BackColor=Transparent;Font=Microsoft" + " Sans Serif, 12pt;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Ax" + "isY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,L" + "ightSteelBlue,1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleD" + "ata></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyl" + "eDefault.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend." + "default</Name><ParentName>Control</ParentName><StyleData>Border=None,LightYellow" + ",1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyl" + "eDefault.default</Name><ParentName>Control</ParentName><StyleData>Border=None,Co" + "ntrol,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle><Name>Header<" + "/Name><ParentName>Control</ParentName><StyleData>Border=RaisedBevel,Bisque,2;Bac" + "kColor=Bisque;Font=Microsoft Sans Serif, 12pt, style=Bold;</StyleData></NamedSty" + "le><NamedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=Co" + "ntrolText;Border=None,LightSlateGray,1;BackColor=Control;</StyleData></NamedStyl" + "e><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotatio" + "n=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Align" + "Vert=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentNa" + "me>Control</ParentName><StyleData>Border=None,LightSteelBlue,1;AlignVert=Top;</S" + "tyleData></NamedStyle></StyleCollection><Footer Compass=""South""><Text>Total # of" + " ChartLabels: </Text></Footer><Legend Compass=""East"" Visible=""True""><Text /></Le" + "gend><ChartArea Inverted=""True"" /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(480, 256)
      Me.c1Chart1.TabIndex = 2
      ' 
      ' menuHelpMoreInfo
      ' 
      Me.menuHelpMoreInfo.Index = 0
      Me.menuHelpMoreInfo.Text = "More Info..."
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(488, 353)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, grpLabels, buttonClearLabels})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Chart Labels Demo"
      Me.grpLabels.ResumeLayout(False)
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New Form1())
   End Sub 'Main
   
   
   Private Sub menuHelpMoreInfo_Click(sender As Object, e As System.EventArgs) Handles menuHelpMoreInfo.Click
      Dim msg As String = "Wander about the chart elements with the cursor," + ControlChars.Lf + "and the elements will be described as you pass over them." + ControlChars.Lf + ControlChars.Lf + "As you move over the bars of the chart, the value of each" + ControlChars.Lf + "bar is given." + ControlChars.Lf + ControlChars.Lf + "If the left mouse button is clicked at a new bar level, the" + ControlChars.Lf + "bar will change it's value to match the new level." + ControlChars.Lf + ControlChars.Lf + "Dragging a label onto a bar, will label the bar."
      
      MessageBox.Show(Me, msg, "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpMoreInfo_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Me.Close()
   End Sub 'menuFileExit_Click
   
   Private baseFooterString As String = Nothing
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' center the form
      Me.CenterToParent()
      
      ' final chart setup
      c1Chart1.Top = grpLabels.Bottom + 1
      c1Chart1.Left = 0
      c1Chart1.Size = New Size(ClientSize.Width, ClientSize.Height - c1Chart1.Top)
      c1Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      c1Chart1.Header.Text = " Drag and drop one of the above " + ControlChars.Lf + " labels onto a chart bar. "
      c1Chart1.Header.Style.HorizontalAlignment = AlignHorzEnum.Center
      
      ' save the footer string and use it later
      baseFooterString = c1Chart1.Footer.Text
   End Sub 'Form1_Load
   
   Private objectBackColor As Color = Color.Empty
   Private highlightedObjectStyle As Style = Nothing
   Private highlightedObject As Object = Nothing
   Private labName As String = "highLightLabel"
   
   
   Private Sub UpdateFooter()
      Dim labCount As Integer = c1Chart1.ChartLabels.LabelsCollection.Count
      c1Chart1.Footer.Text = baseFooterString + labCount.ToString() + " "
   End Sub 'UpdateFooter
   
   
   Private Sub HighlightObject(obj As Object)
      ' do nothing if still same object
      If Not (obj Is Nothing) Then
         If obj.Equals(highlightedObject) Then
            Return
         End If
      End If 
      ' since they are different, clear the original
      ' object if it's not null
      highlightedObject = Nothing
      If Not (highlightedObjectStyle Is Nothing) Then
         highlightedObjectStyle.BackColor = objectBackColor
         objectBackColor = Color.Empty
         highlightedObjectStyle = Nothing
      End If
      
      Dim lab As C1.Win.C1Chart.Label = c1Chart1.ChartLabels(labName)
      If Not (lab Is Nothing) Then
         c1Chart1.ChartLabels.LabelsCollection.Remove(lab)
      End If 
      If obj Is Nothing Then
         UpdateFooter()
         Return
      End If
      
      ' handle the changes for the new object highlighting
      Dim describe As String = Nothing
      Dim atPoint As Point = Point.Empty
      Dim cp As LabelCompassEnum = LabelCompassEnum.NorthWest
      
      If TypeOf obj Is Legend Then
         Dim leg As Legend = CType(obj, Legend)
         describe = " This is the Legend! "
         atPoint = leg.Location
         highlightedObjectStyle = leg.Style
      ElseIf TypeOf obj Is Title Then
         Dim t As Title = CType(obj, Title)
         highlightedObjectStyle = t.Style
         If highlightedObjectStyle.Border.BorderStyle.Equals(BorderStyleEnum.None) Then
            describe = " This is the Footer! "
            atPoint = t.Location
            atPoint.X += t.Size.Width
            cp = LabelCompassEnum.NorthEast
         Else
            describe = " This is the " + ControlChars.Lf + "Header! "
            atPoint = t.Location
            atPoint.X += t.Size.Width
            atPoint.Y += t.Size.Height
            cp = LabelCompassEnum.SouthEast
         End If
      End If
      
      If Not atPoint.IsEmpty Then
         Dim nl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
         nl.Compass = cp
         nl.Name = labName
         nl.Connected = True
         nl.Offset = 10
         nl.AttachMethod = AttachMethodEnum.Coordinate
         nl.AttachMethodData.X = atPoint.X
         nl.AttachMethodData.Y = atPoint.Y
         nl.Style.BackColor = Color.RosyBrown
         nl.Style.Border.BorderStyle = BorderStyleEnum.Solid
         nl.Style.Border.Thickness = 2
         nl.Style.Font = New Font(nl.Style.Font.Name, 10, FontStyle.Bold)
         nl.Style.HorizontalAlignment = AlignHorzEnum.Center
         nl.Text = describe
         nl.Visible = True
         
         objectBackColor = highlightedObjectStyle.BackColor
         highlightedObjectStyle.BackColor = Color.RosyBrown
         highlightedObject = obj
      End If
      
      UpdateFooter()
   End Sub 'HighlightObject
   
   Private oldSeries As Integer = - 1
   Private oldPoint As Integer = - 1
   
   
   Private Sub AddBarValueLabel(x As Integer, y As Integer, leftButtonDown As Boolean)
      Const labName As String = "barValueLabel"
      Dim lab As C1.Win.C1Chart.Label = Nothing
      
      If x < 0 OrElse y < 0 Then
         lab = c1Chart1.ChartLabels(labName)
         If Not (lab Is Nothing) Then
            c1Chart1.ChartLabels.LabelsCollection.Remove(lab)
            UpdateFooter()
         End If
         oldSeries = - 1
         oldPoint = - 1
         Return
      End If
      
      Dim s As Integer = - 1
      Dim p As Integer = - 1
      Dim d As Integer = - 1
      Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
      If grp.CoordToDataIndex(x, y, CoordinateFocusEnum.XCoord, s, p, d) Then
         If s >= 0 AndAlso p >= 0 AndAlso d = 0 Then
            If leftButtonDown Then
               ' if the left mouse button is down, then
               ' change the data point Y value at s & p
               Dim newx As Single = 0F
               Dim newy As Single = 0F
               If grp.CoordToDataCoord(x, y, newx, newy) Then
                  grp.ChartData(s).Y(p) = newy
               End If
            Else
               ' see if it's the same as the last call.
               If s = oldSeries AndAlso p = oldPoint Then
                  Return
               End If
            End If 
            lab = c1Chart1.ChartLabels(labName)
            If lab Is Nothing Then
               lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
               lab.Name = labName
               lab.Style.Border.BorderStyle = BorderStyleEnum.None
               lab.Style.BackColor = Color.Transparent
               lab.Compass = LabelCompassEnum.West
               lab.Connected = False
               lab.Offset = 10
               lab.AttachMethod = AttachMethodEnum.DataIndex
               lab.AttachMethodData.GroupIndex = 0
               lab.AttachMethodData.SeriesIndex = s
               lab.AttachMethodData.PointIndex = p
               lab.Text = CSng(grp.ChartData(s).Y(p)).ToString("0.##")
               lab.Visible = True
               
               UpdateFooter()
            Else
               lab.AttachMethodData.SeriesIndex = s
               lab.AttachMethodData.PointIndex = p
               lab.Text = CSng(grp.ChartData(s).Y(p)).ToString("0.##")
            End If
            Return
         End If
      End If
      
      AddBarValueLabel(- 1, - 1, False)
   End Sub 'AddBarValueLabel
   
   Private inMouseMove As Boolean = False
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      ' eliminate recursive calls.
      If inMouseMove Then
         Return
      End If 
      inMouseMove = True
      
      Dim [region] As ChartRegionEnum = c1Chart1.ChartRegionFromCoord(e.X, e.Y)
      Select Case [region]
         Case ChartRegionEnum.Legend
            AddBarValueLabel(- 1, - 1, False)
            HighlightObject(c1Chart1.Legend)
         
         Case ChartRegionEnum.Header
            AddBarValueLabel(- 1, - 1, False)
            HighlightObject(c1Chart1.Header)
         
         Case ChartRegionEnum.Footer
            AddBarValueLabel(- 1, - 1, False)
            HighlightObject(c1Chart1.Footer)
         
         Case ChartRegionEnum.ChartArea, ChartRegionEnum.ChartLabel, ChartRegionEnum.PlotArea
            HighlightObject(Nothing)
            AddBarValueLabel(e.X, e.Y, e.Button.Equals(MouseButtons.Left))
         
         Case Else
            AddBarValueLabel(- 1, - 1, False)
            HighlightObject(Nothing)
      End Select
      
      inMouseMove = False
   End Sub 'c1Chart1_MouseMove
   
   
   Private Sub c1Chart1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseDown
      If e.Button.Equals(MouseButtons.Left) Then
         c1Chart1_MouseMove(sender, e)
      End If
   End Sub 'c1Chart1_MouseDown
    
   Private Sub buttonClearLabels_Click(sender As Object, e As System.EventArgs) Handles buttonClearLabels.Click
      c1Chart1.ChartLabels.LabelsCollection.Clear()
      UpdateFooter()
   End Sub 'buttonClearLabels_Click
   
   
   Private Sub DragLabels_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblFour.MouseDown, lblThree.MouseDown, lblTwo.MouseDown, lblOne.MouseDown
      Dim wlab As System.Windows.Forms.Label = CType(sender, System.Windows.Forms.Label)
      wlab.DoDragDrop(wlab.Text, DragDropEffects.Copy)
   End Sub 'DragLabels_MouseDown
   
   
   Private Sub c1Chart1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles c1Chart1.DragDrop
      Dim newLabText As String = e.Data.GetData(DataFormats.Text).ToString()
      If Not (newLabText Is Nothing) AndAlso newLabText.Length > 0 Then
         ' convert the event screen coords to client coords
         ' of the chart object.
         Dim pnt As Point = c1Chart1.PointToClient(New Point(e.X, e.Y))
         Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
         Dim s As Integer = - 1
         Dim p As Integer = - 1
         Dim d As Integer = - 1
         
         ' the cursor MUST be on a bar.
         If grp.CoordToDataIndex(pnt.X, pnt.Y, CoordinateFocusEnum.XandYCoord, s, p, d) Then
            If s >= 0 AndAlso p >= 0 AndAlso d = 0 Then
               ' create the label name
               Dim labName As String = "barLabel_" + s.ToString() + "_" + p.ToString()
               
               ' now get the existing label or create it if necessary
               Dim lab As C1.Win.C1Chart.Label = c1Chart1.ChartLabels(labName)
               If lab Is Nothing Then
                  ' create the label
                  lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
                  lab.Name = labName
                  lab.Compass = LabelCompassEnum.East
                  lab.Connected = True
                  lab.Offset = 10
                  lab.AttachMethod = AttachMethodEnum.DataIndex
                  lab.AttachMethodData.GroupIndex = 0
                  lab.AttachMethodData.SeriesIndex = s
                  lab.AttachMethodData.PointIndex = p
                  lab.Style.BackColor = Color.Transparent
               End If
               lab.Text = newLabText
               lab.Visible = True
            End If
         End If
      End If
   End Sub 'c1Chart1_DragDrop
   
   
   Private Sub c1Chart1_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles c1Chart1.DragOver
      e.Effect = DragDropEffects.None
      If Not e.Data.GetDataPresent(DataFormats.Text) Then
         Return
      End If 
      ' convert the event screen coords to client coords
      ' of the chart object.
      Dim pnt As Point = c1Chart1.PointToClient(New Point(e.X, e.Y))
      Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
      Dim s As Integer = - 1
      Dim p As Integer = - 1
      Dim d As Integer = - 1
      
      ' the cursor MUST be on a bar.
      If grp.CoordToDataIndex(pnt.X, pnt.Y, CoordinateFocusEnum.XandYCoord, s, p, d) Then
         If s >= 0 AndAlso p >= 0 AndAlso d = 0 Then
            e.Effect = DragDropEffects.Copy
         End If
      End If
   End Sub 'c1Chart1_DragOver
End Class 'Form1
