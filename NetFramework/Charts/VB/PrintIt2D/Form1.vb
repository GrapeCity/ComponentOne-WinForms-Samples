
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItemFile As System.Windows.Forms.MenuItem
   WithEvents menuItemFileOpen As System.Windows.Forms.MenuItem
   WithEvents menuItem4 As System.Windows.Forms.MenuItem
   WithEvents menuItemPageSetup As System.Windows.Forms.MenuItem
   WithEvents menuItemPrint As System.Windows.Forms.MenuItem
   WithEvents menuItem7 As System.Windows.Forms.MenuItem
   WithEvents menuItemExit As System.Windows.Forms.MenuItem
   WithEvents menuItemSaveAs As System.Windows.Forms.MenuItem
   WithEvents menuItemSaveImageAs As System.Windows.Forms.MenuItem
   Private saveFileDialog As System.Windows.Forms.SaveFileDialog
   Private openFileDialog As System.Windows.Forms.OpenFileDialog
   Private panel1 As System.Windows.Forms.Panel
   Private splitter1 As System.Windows.Forms.Splitter
   Private c1Chart1 As C1.Win.C1Chart.C1Chart
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private groupBox4 As System.Windows.Forms.GroupBox
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
   Private label4 As System.Windows.Forms.Label
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents btnPrint As System.Windows.Forms.Button
   WithEvents rbClip As System.Windows.Forms.RadioButton
   WithEvents rbFile As System.Windows.Forms.RadioButton
   WithEvents rbPrinter As System.Windows.Forms.RadioButton
   WithEvents rbImage As System.Windows.Forms.RadioButton
   Private tbWidth As System.Windows.Forms.TextBox
   Private tbHeigth As System.Windows.Forms.TextBox
   WithEvents rbBmp As System.Windows.Forms.RadioButton
   WithEvents rbEMF As System.Windows.Forms.RadioButton
   WithEvents rbNone As System.Windows.Forms.RadioButton
   WithEvents rbMax As System.Windows.Forms.RadioButton
   WithEvents rbHeight As System.Windows.Forms.RadioButton
   WithEvents rbWidth As System.Windows.Forms.RadioButton
   WithEvents rbFit As System.Windows.Forms.RadioButton
   Private tbTop As System.Windows.Forms.TextBox
   Private tbLeft As System.Windows.Forms.TextBox
   Private gbPrnFmt As System.Windows.Forms.GroupBox
   Private gbScale As System.Windows.Forms.GroupBox
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   WithEvents menuFileOpenChart As System.Windows.Forms.MenuItem
   WithEvents menuFileOpenChart3D As System.Windows.Forms.MenuItem
   Private components As System.ComponentModel.IContainer = Nothing
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   
   Function getSize() As Size
      Dim sz As Size = Size.Empty
      Try
         sz.Width = Integer.Parse(tbWidth.Text)
         sz.Height = Integer.Parse(tbHeigth.Text)
      Catch
         sz = Size.Empty
      End Try
      Return sz
   End Function 'getSize
   
   
   Function getRect() As Rectangle
      Dim rect As Rectangle = Rectangle.Empty
      
      Try
         rect.X = Integer.Parse(tbLeft.Text)
         rect.Y = Integer.Parse(tbTop.Text)
         rect.Width = Integer.Parse(tbWidth.Text)
         rect.Height = Integer.Parse(tbHeigth.Text)
      Catch
         rect.X = 0
         rect.Y = 0
         If c1Chart1.Visible Then
            rect.Width = c1Chart1.Width
            rect.Height = c1Chart1.Height
         Else
            rect.Width = c1Chart3D1.Width
            rect.Height = c1Chart3D1.Height
         End If
      End Try
      
      Return rect
   End Function 'getRect
   
   
   Function getFormat() As System.Drawing.Imaging.ImageFormat
      If rbBmp.Checked Then
         Return System.Drawing.Imaging.ImageFormat.Bmp
      Else
         Return System.Drawing.Imaging.ImageFormat.Emf
      End If
   End Function 'getFormat
    
   Private Function getImageFormatFromDlg(index As Integer) As System.Drawing.Imaging.ImageFormat
      Select Case index
         Case 1
               Return System.Drawing.Imaging.ImageFormat.Bmp
         Case 2
               Return System.Drawing.Imaging.ImageFormat.Emf
         Case 3
               Return System.Drawing.Imaging.ImageFormat.Gif
         Case 4
               Return System.Drawing.Imaging.ImageFormat.Jpeg
         Case 5
               Return System.Drawing.Imaging.ImageFormat.Png
         Case Else
               Return System.Drawing.Imaging.ImageFormat.Bmp
      End Select
   End Function 'getImageFormatFromDlg
   
   
   Function getScale() As C1.Win.C1Chart.PrintScaleEnum
      If rbNone.Checked Then
         Return C1.Win.C1Chart.PrintScaleEnum.ScaleNone
      ElseIf rbFit.Checked Then
         Return C1.Win.C1Chart.PrintScaleEnum.ScaleToFit
      ElseIf rbMax.Checked Then
         Return C1.Win.C1Chart.PrintScaleEnum.ScaleToMax
      ElseIf rbHeight.Checked Then
         Return C1.Win.C1Chart.PrintScaleEnum.ScaleToHeight
      Else
         Return C1.Win.C1Chart.PrintScaleEnum.ScaleToWidth
      End If
   End Function 'getScale
    
   Sub saveImageAs()
      Dim sfd As New SaveFileDialog()
      
      sfd.Filter = "Bitmap (*.bmp)|*.bmp|" + "EMF Enhanced Metafile Format (*.emf)|*.emf|" + "Graphics Interchange Format (*.gif)|*.gif|" + "Joint Photographic Experts Group (*.jpg)|*.jpg|" + "W3C Portable Network Graphics (*.png)|*.png"
      sfd.DefaultExt = "bmp"
      sfd.FileName = "image1"
      sfd.OverwritePrompt = True
      sfd.CheckPathExists = True
      sfd.RestoreDirectory = False
      sfd.ValidateNames = True
      
      If sfd.ShowDialog(Me) = DialogResult.OK Then
         If c1Chart1.Visible Then
            c1Chart1.SaveImage(sfd.FileName, getImageFormatFromDlg(sfd.FilterIndex), getSize())
         Else
            c1Chart3D1.SaveImage(sfd.FileName, getImageFormatFromDlg(sfd.FilterIndex), getSize())
         End If
      End If
   End Sub 'saveImageAs
    
   Sub print()
      If rbImage.Checked Then
         ' create form and put image in it
         Dim sz As Size = getSize()
         Dim fmt As System.Drawing.Imaging.ImageFormat = getFormat()
         
         Dim canvas As New frmCanvas()
         If c1Chart1.Visible Then
            canvas.pictureBox1.Image = c1Chart1.GetImage(fmt, sz)
         Else
            canvas.pictureBox1.Image = c1Chart3D1.GetImage(fmt, sz)
         End If 
         canvas.Text = String.Format("Image format:{0}, width:{1}, height:{2}", fmt.ToString(), sz.Width, sz.Height)
         canvas.ShowDialog(Me)
      ElseIf rbClip.Checked Then
         ' put to the clipboard
         If c1Chart1.Visible Then
            c1Chart1.SaveImage(getFormat(), getSize())
         Else
            c1Chart3D1.SaveImage(getFormat(), getSize())
         End If
      ElseIf rbFile.Checked Then
         ' save as file
         saveImageAs()
      Else
         ' print chart
         If c1Chart1.Visible Then
            c1Chart1.PrintChart(getScale(), getRect())
         Else
            c1Chart3D1.PrintChart(CType(getScale(), C1.Win.C1Chart3D.PrintScaleEnum), getRect())
         End If
      End If
   End Sub 'print
    
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
      Me.menuItemFile = New System.Windows.Forms.MenuItem()
      Me.menuItemFileOpen = New System.Windows.Forms.MenuItem()
      Me.menuFileOpenChart = New System.Windows.Forms.MenuItem()
      Me.menuFileOpenChart3D = New System.Windows.Forms.MenuItem()
      Me.menuItemSaveAs = New System.Windows.Forms.MenuItem()
      Me.menuItemSaveImageAs = New System.Windows.Forms.MenuItem()
      Me.menuItem4 = New System.Windows.Forms.MenuItem()
      Me.menuItemPageSetup = New System.Windows.Forms.MenuItem()
      Me.menuItemPrint = New System.Windows.Forms.MenuItem()
      Me.menuItem7 = New System.Windows.Forms.MenuItem()
      Me.menuItemExit = New System.Windows.Forms.MenuItem()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
      Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.btnPrint = New System.Windows.Forms.Button()
      Me.groupBox4 = New System.Windows.Forms.GroupBox()
      Me.label4 = New System.Windows.Forms.Label()
      Me.tbHeigth = New System.Windows.Forms.TextBox()
      Me.label3 = New System.Windows.Forms.Label()
      Me.tbWidth = New System.Windows.Forms.TextBox()
      Me.label2 = New System.Windows.Forms.Label()
      Me.tbLeft = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.tbTop = New System.Windows.Forms.TextBox()
      Me.gbScale = New System.Windows.Forms.GroupBox()
      rbFit = New System.Windows.Forms.RadioButton()
      rbWidth = New System.Windows.Forms.RadioButton()
      rbHeight = New System.Windows.Forms.RadioButton()
      rbMax = New System.Windows.Forms.RadioButton()
      rbNone = New System.Windows.Forms.RadioButton()
      Me.gbPrnFmt = New System.Windows.Forms.GroupBox()
      rbEMF = New System.Windows.Forms.RadioButton()
      rbBmp = New System.Windows.Forms.RadioButton()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      rbPrinter = New System.Windows.Forms.RadioButton()
      rbFile = New System.Windows.Forms.RadioButton()
      rbClip = New System.Windows.Forms.RadioButton()
      rbImage = New System.Windows.Forms.RadioButton()
      Me.splitter1 = New System.Windows.Forms.Splitter()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.panel1.SuspendLayout()
      Me.groupBox4.SuspendLayout()
      Me.gbScale.SuspendLayout()
      Me.gbPrnFmt.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFile, Me.menuItem1})
      ' 
      ' menuItemFile
      ' 
      Me.menuItemFile.Index = 0
      Me.menuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFileOpen, Me.menuItemSaveAs, Me.menuItemSaveImageAs, Me.menuItem4, Me.menuItemPageSetup, Me.menuItemPrint, Me.menuItem7, Me.menuItemExit})
      Me.menuItemFile.Text = "&File"
      ' 
      ' menuItemFileOpen
      ' 
      Me.menuItemFileOpen.Index = 0
      Me.menuItemFileOpen.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileOpenChart, Me.menuFileOpenChart3D})
      Me.menuItemFileOpen.Text = "&Open"
      ' 
      ' menuFileOpenChart
      ' 
      Me.menuFileOpenChart.Index = 0
      Me.menuFileOpenChart.Text = "Chart ..."
      ' 
      ' menuFileOpenChart3D
      ' 
      Me.menuFileOpenChart3D.Index = 1
      Me.menuFileOpenChart3D.Text = "Chart 3D ..."
      ' 
      ' menuItemSaveAs
      ' 
      Me.menuItemSaveAs.Index = 1
      Me.menuItemSaveAs.Text = "Save &As..."
      ' 
      ' menuItemSaveImageAs
      ' 
      Me.menuItemSaveImageAs.Index = 2
      Me.menuItemSaveImageAs.Text = "Save &Image As..."
      ' 
      ' menuItem4
      ' 
      Me.menuItem4.Index = 3
      Me.menuItem4.Text = "-"
      ' 
      ' menuItemPageSetup
      ' 
      Me.menuItemPageSetup.Index = 4
      Me.menuItemPageSetup.Text = "Page Set&up..."
      ' 
      ' menuItemPrint
      ' 
      Me.menuItemPrint.Index = 5
      Me.menuItemPrint.Text = "&Print"
      ' 
      ' menuItem7
      ' 
      Me.menuItem7.Index = 6
      Me.menuItem7.Text = "-"
      ' 
      ' menuItemExit
      ' 
      Me.menuItemExit.Index = 7
      Me.menuItemExit.Text = "&Exit"
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 1
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuItem1.Text = "&Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "&About"
      ' 
      ' saveFileDialog
      ' 
      Me.saveFileDialog.FileName = "chart2D1"
      Me.saveFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml"
      ' 
      ' openFileDialog
      ' 
      Me.openFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml"
      ' 
      ' panel1
      ' 
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.groupBox4, Me.gbScale, Me.gbPrnFmt, Me.groupBox1})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(216, 403)
      Me.panel1.TabIndex = 2
      ' 
      ' btnPrint
      ' 
      Me.btnPrint.Location = New System.Drawing.Point(112, 272)
      Me.btnPrint.Name = "btnPrint"
      Me.btnPrint.Size = New System.Drawing.Size(96, 23)
      Me.btnPrint.TabIndex = 4
      Me.btnPrint.Text = "Print"
      ' 
      ' groupBox4
      ' 
      Me.groupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.label4, Me.tbHeigth, Me.label3, Me.tbWidth, Me.label2, Me.tbLeft, Me.label1, Me.tbTop})
      Me.groupBox4.Location = New System.Drawing.Point(112, 120)
      Me.groupBox4.Name = "groupBox4"
      Me.groupBox4.Size = New System.Drawing.Size(96, 144)
      Me.groupBox4.TabIndex = 3
      Me.groupBox4.TabStop = False
      Me.groupBox4.Text = "Size/Location"
      ' 
      ' label4
      ' 
      Me.label4.Location = New System.Drawing.Point(8, 114)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(40, 16)
      Me.label4.TabIndex = 11
      Me.label4.Text = "Height"
      ' 
      ' tbHeigth
      ' 
      Me.tbHeigth.Location = New System.Drawing.Point(56, 112)
      Me.tbHeigth.Name = "tbHeigth"
      Me.tbHeigth.Size = New System.Drawing.Size(32, 20)
      Me.tbHeigth.TabIndex = 10
      Me.tbHeigth.Text = "0"
      ' 
      ' label3
      ' 
      Me.label3.Location = New System.Drawing.Point(8, 82)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(40, 16)
      Me.label3.TabIndex = 9
      Me.label3.Text = "Width"
      ' 
      ' tbWidth
      ' 
      Me.tbWidth.Location = New System.Drawing.Point(56, 80)
      Me.tbWidth.Name = "tbWidth"
      Me.tbWidth.Size = New System.Drawing.Size(32, 20)
      Me.tbWidth.TabIndex = 8
      Me.tbWidth.Text = "0"
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(8, 50)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(40, 16)
      Me.label2.TabIndex = 7
      Me.label2.Text = "Left"
      ' 
      ' tbLeft
      ' 
      Me.tbLeft.Enabled = False
      Me.tbLeft.Location = New System.Drawing.Point(56, 48)
      Me.tbLeft.Name = "tbLeft"
      Me.tbLeft.Size = New System.Drawing.Size(32, 20)
      Me.tbLeft.TabIndex = 6
      Me.tbLeft.Text = "0"
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(8, 18)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(40, 16)
      Me.label1.TabIndex = 5
      Me.label1.Text = "Top"
      ' 
      ' tbTop
      ' 
      Me.tbTop.Enabled = False
      Me.tbTop.Location = New System.Drawing.Point(56, 16)
      Me.tbTop.Name = "tbTop"
      Me.tbTop.Size = New System.Drawing.Size(32, 20)
      Me.tbTop.TabIndex = 4
      Me.tbTop.Text = "0"
      ' 
      ' gbScale
      ' 
      Me.gbScale.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbFit, rbWidth, rbHeight, rbMax, rbNone})
      Me.gbScale.Enabled = False
      Me.gbScale.Location = New System.Drawing.Point(8, 120)
      Me.gbScale.Name = "gbScale"
      Me.gbScale.Size = New System.Drawing.Size(96, 144)
      Me.gbScale.TabIndex = 2
      Me.gbScale.TabStop = False
      Me.gbScale.Text = "Scale Method"
      ' 
      ' rbFit
      ' 
      rbFit.Location = New System.Drawing.Point(8, 40)
      rbFit.Name = "rbFit"
      rbFit.Size = New System.Drawing.Size(72, 24)
      rbFit.TabIndex = 7
      rbFit.Text = "To Fit"
      ' 
      ' rbWidth
      ' 
      rbWidth.Location = New System.Drawing.Point(8, 112)
      rbWidth.Name = "rbWidth"
      rbWidth.Size = New System.Drawing.Size(72, 24)
      rbWidth.TabIndex = 6
      rbWidth.Text = "To Width"
      ' 
      ' rbHeight
      ' 
      rbHeight.Location = New System.Drawing.Point(8, 88)
      rbHeight.Name = "rbHeight"
      rbHeight.Size = New System.Drawing.Size(72, 24)
      rbHeight.TabIndex = 5
      rbHeight.Text = "To Height"
      ' 
      ' rbMax
      ' 
      rbMax.Location = New System.Drawing.Point(8, 64)
      rbMax.Name = "rbMax"
      rbMax.Size = New System.Drawing.Size(72, 24)
      rbMax.TabIndex = 4
      rbMax.Text = "To Max"
      ' 
      ' rbNone
      ' 
      rbNone.Checked = True
      rbNone.Location = New System.Drawing.Point(8, 16)
      rbNone.Name = "rbNone"
      rbNone.Size = New System.Drawing.Size(72, 24)
      rbNone.TabIndex = 3
      rbNone.TabStop = True
      rbNone.Text = "None"
      ' 
      ' gbPrnFmt
      ' 
      Me.gbPrnFmt.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbEMF, rbBmp})
      Me.gbPrnFmt.Location = New System.Drawing.Point(112, 8)
      Me.gbPrnFmt.Name = "gbPrnFmt"
      Me.gbPrnFmt.Size = New System.Drawing.Size(96, 112)
      Me.gbPrnFmt.TabIndex = 1
      Me.gbPrnFmt.TabStop = False
      Me.gbPrnFmt.Text = "Print Format"
      ' 
      ' rbEMF
      ' 
      rbEMF.Location = New System.Drawing.Point(8, 40)
      rbEMF.Name = "rbEMF"
      rbEMF.Size = New System.Drawing.Size(80, 24)
      rbEMF.TabIndex = 3
      rbEMF.Text = "EMF"
      ' 
      ' rbBmp
      ' 
      rbBmp.Checked = True
      rbBmp.Location = New System.Drawing.Point(8, 16)
      rbBmp.Name = "rbBmp"
      rbBmp.Size = New System.Drawing.Size(80, 24)
      rbBmp.TabIndex = 2
      rbBmp.TabStop = True
      rbBmp.Text = "Bitmap"
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbPrinter, rbFile, rbClip, rbImage})
      Me.groupBox1.Location = New System.Drawing.Point(8, 8)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(96, 112)
      Me.groupBox1.TabIndex = 0
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Print Location"
      ' 
      ' rbPrinter
      ' 
      rbPrinter.Location = New System.Drawing.Point(8, 88)
      rbPrinter.Name = "rbPrinter"
      rbPrinter.Size = New System.Drawing.Size(56, 16)
      rbPrinter.TabIndex = 4
      rbPrinter.Text = "Printer"
      ' 
      ' rbFile
      ' 
      rbFile.Location = New System.Drawing.Point(8, 64)
      rbFile.Name = "rbFile"
      rbFile.Size = New System.Drawing.Size(56, 16)
      rbFile.TabIndex = 3
      rbFile.Text = "File"
      ' 
      ' rbClip
      ' 
      rbClip.Location = New System.Drawing.Point(8, 40)
      rbClip.Name = "rbClip"
      rbClip.Size = New System.Drawing.Size(72, 16)
      rbClip.TabIndex = 2
      rbClip.Text = "Clipboard"
      ' 
      ' rbImage
      ' 
      rbImage.Checked = True
      rbImage.Location = New System.Drawing.Point(8, 16)
      rbImage.Name = "rbImage"
      rbImage.Size = New System.Drawing.Size(72, 16)
      rbImage.TabIndex = 1
      rbImage.TabStop = True
      rbImage.Text = "Image"
      ' 
      ' splitter1
      ' 
      Me.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.splitter1.Location = New System.Drawing.Point(216, 0)
      Me.splitter1.Name = "splitter1"
      Me.splitter1.Size = New System.Drawing.Size(4, 403)
      Me.splitter1.TabIndex = 4
      Me.splitter1.TabStop = False
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(220, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><ChartGroupsCollection><ChartGrou" + "p><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Pol" + "ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" + "d=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Chart" + "Type>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,M" + "aximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=T" + "rue,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Defau" + "ltSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y2 /><Y3 /><Y>20;22;19" + ";24;25</Y><LineStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><Symb" + "olStyle Shape=""Box"" Color=""Coral"" /><Y1 /><SeriesLabel>series 0</SeriesLabel><Da" + "taTypes>Single;Single;Single;Single;Single</DataTypes><X>1;2;3;4;5</X></DataSeri" + "esSerializer><DataSeriesSerializer><Y2 /><Y3 /><Y>8;12;10;12;15</Y><LineStyle Th" + "ickness=""1"" Color=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""C" + "ornflowerBlue"" /><Y1 /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Sing" + "le;Single;Single;Single</DataTypes><X>1;2;3;4;5</X></DataSeriesSerializer><DataS" + "eriesSerializer><Y2 /><Y3 /><Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=" + """DarkGreen"" Pattern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><Y1 />" + "<SeriesLabel>series 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single" + "</DataTypes><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y2 /><" + "Y3 /><Y>16;19;15;22;18</Y><LineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""So" + "lid"" /><SymbolStyle Shape=""Diamond"" Color=""Crimson"" /><Y1 /><SeriesLabel>series " + "3</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><X>1;2;3" + ";4;5</X></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartGr" + "oup><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</Sh" + "owOutline><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degr" + "ees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group" + "2</Name><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMet" + "hod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,Fil" + "lTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSe" + "rializer /></ChartGroup></ChartGroupsCollection><StyleCollection><NamedStyle><Pa" + "rentName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plo" + "tArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Sty" + "leData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyl" + "e><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name" + "></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><" + "Name>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleD" + "ata>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparen" + "t;AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Paren" + "tName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;Align" + "Horz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name><" + "/NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><Style" + "Data /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Contro" + "l</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleDat" + "a><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Paren" + "tName><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>L" + "abelStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Par" + "entName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedS" + "tyle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Cont" + "rol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Na" + "medStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,T" + "ransparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><N" + "ame>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><Style" + "Data>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></" + "NamedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor" + "=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0" + """ Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pa" + "ttern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patte" + "rn=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" Au" + "toMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass" + "=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Das" + "h"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" " + "/><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""Tr" + "ue"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Gr" + "idMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridM" + "inor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /><" + "/Axis></Axes><Header Compass=""North"" Visible=""False""><Text /></Header><Footer Co" + "mpass=""South"" Visible=""False""><Text /></Footer><Legend Compass=""East"" Visible=""F" + "alse""><Text /></Legend><ChartArea /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(372, 403)
      Me.c1Chart1.TabIndex = 6
      ' 
      ' c1Chart3D1
      ' 
      Me.c1Chart3D1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart3D1.Location = New System.Drawing.Point(220, 0)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><AxisX /><AxisY /><AxisZ /><Chart" + "GroupsCollection><Chart3DGroup ChartType=""Surface""><Elevation><SurfaceTopColor>W" + "hite</SurfaceTopColor><SurfaceBottomColor>DarkGray</SurfaceBottomColor></Elevati" + "on><ChartData><Set type=""Chart3DDataSetGrid"" RowOrigin=""0"" RowDelta=""1"" RowCount" + "=""11"" ColumnCount=""11"" ColumnDelta=""1"" ColumnOrigin=""0"" Hole=""3.40282347E+38""><D" + "ata>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4" + ".5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 1" + "0 10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7" + " 11.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14." + "5 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4" + " 10.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 " + "6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.3" + "9999986 2.89999986 3.6 4.5 </Data></Set></ChartData><Bar /><Surface /><Contour /" + "></Chart3DGroup></ChartGroupsCollection><ContourStyles ColorSet=""Custom""><Colors" + "><Color>Black</Color><Color>Red</Color></Colors></ContourStyles><LegendData Comp" + "ass=""East"" /><StyleCollection><NamedStyle Name=""Legend"" ParentName=""Legend.defau" + "lt"" StyleData="""" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData="""" /" + "><NamedStyle Name=""Area"" ParentName=""Area.default"" StyleData="""" /><NamedStyle Na" + "me=""Control"" ParentName=""Control.default"" StyleData="""" /><NamedStyle Name=""Label" + "StyleDefault"" ParentName=""Control"" StyleData=""BackColor=Transparent;"" /><NamedSt" + "yle Name=""Legend.default"" ParentName=""Control"" StyleData=""Wrap=False;AlignVert=T" + "op;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleData="""" /><NamedStyle" + " Name=""Control.default"" ParentName="""" StyleData=""ForeColor=ControlText;BackColor" + "=Control;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" StyleData=""Ali" + "gnVert=Top;"" /></StyleCollection><FooterData Visible=""True"" Compass=""South"" /><V" + "iew AxisTitleFont=""Microsoft Sans Serif, 12world"" AxisFont=""Microsoft Sans Serif" + ", 10world""><Ceiling /><Floor /></View><HeaderData Visible=""True"" Compass=""North""" + " /></Chart3DPropBag>"

      Me.c1Chart3D1.Size = New System.Drawing.Size(372, 403)
      Me.c1Chart3D1.TabIndex = 7
      Me.c1Chart3D1.Visible = False
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, Me.c1Chart3D1, Me.splitter1, Me.panel1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET - PrintIt Demo"
      Me.panel1.ResumeLayout(False)
      Me.groupBox4.ResumeLayout(False)
      Me.gbScale.ResumeLayout(False)
      Me.gbPrnFmt.ResumeLayout(False)
      Me.groupBox1.ResumeLayout(False)
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent 
#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   Private filename As String = String.Empty
    'default
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New Form1())
   End Sub 'Main
   
   
   Private Sub menuItemPageSetup_Click(sender As Object, e As System.EventArgs) Handles menuItemPageSetup.Click
      c1Chart1.PageSetup()
   End Sub 'menuItemPageSetup_Click
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      tbWidth.Text = c1Chart1.Width.ToString()
      tbHeigth.Text = c1Chart1.Height.ToString()
   End Sub 'Form1_Load
   
   
   Private Sub menuItemSaveImageAs_Click(sender As Object, e As System.EventArgs) Handles menuItemSaveImageAs.Click
      saveImageAs()
   End Sub 'menuItemSaveImageAs_Click
   
   
   Private Sub menuItemExit_Click(sender As Object, e As System.EventArgs) Handles menuItemExit.Click
      Close()
   End Sub 'menuItemExit_Click
   
   
   Private Sub btnPrint_Click(sender As Object, e As System.EventArgs) Handles btnPrint.Click
      print()
   End Sub 'btnPrint_Click
   
   
   Private Sub rbPrnLoc_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbPrinter.CheckedChanged, rbFile.CheckedChanged, rbClip.CheckedChanged, rbImage.CheckedChanged
      gbPrnFmt.Enabled = rbImage.Checked OrElse rbClip.Checked
      gbScale.Enabled = rbPrinter.Checked
      
      tbTop.Enabled = rbPrinter.Checked
      tbLeft.Enabled = rbPrinter.Checked
   End Sub 'rbPrnLoc_CheckedChanged
   
   
   Private Sub menuItemPrint_Click(sender As Object, e As System.EventArgs) Handles menuItemPrint.Click
      print()
   End Sub 'menuItemPrint_Click
   
   
   Private Sub menuItemSaveAs_Click(sender As Object, e As System.EventArgs) Handles menuItemSaveAs.Click
      If Not filename.Equals(String.Empty) Then
         saveFileDialog.FileName = filename
      End If 
      If c1Chart1.Visible Then
         saveFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml"
      Else
         saveFileDialog.Filter = "Chart3D XML files (*.chart3dxml)|*.chart3dxml"
      End If 
      If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
         filename = saveFileDialog.FileName
         If c1Chart1.Visible Then
            c1Chart1.SaveChartToFile(filename)
         Else
            c1Chart3D1.SaveChartToFile(filename)
         End If
      End If
   End Sub 'menuItemSaveAs_Click
    
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFileOpenChart_Click(sender As Object, e As System.EventArgs) Handles menuFileOpenChart.Click
      openFileDialog.Filter = "Chart2D XML files (*.chart2dxml)|*.chart2dxml"
      If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
         filename = openFileDialog.FileName
         c1Chart1.LoadChartFromFile(filename)
         c1Chart1.Visible = True
         c1Chart3D1.Visible = False
      End If
   End Sub 'menuFileOpenChart_Click
   
   
   Private Sub menuFileOpenChart3D_Click(sender As Object, e As System.EventArgs) Handles menuFileOpenChart3D.Click
      openFileDialog.Filter = "Chart3D XML files (*.chart3dxml)|*.chart3dxml"
      If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
         filename = openFileDialog.FileName
         c1Chart3D1.LoadChartFromFile(filename)
         c1Chart3D1.Visible = True
         c1Chart1.Visible = False
      End If
   End Sub 'menuFileOpenChart3D_Click
End Class 'Form1
