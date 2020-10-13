
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private panel1 As System.Windows.Forms.Panel
   Private panel2 As System.Windows.Forms.Panel
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents btnHeader As System.Windows.Forms.Button
   WithEvents btnFooter As System.Windows.Forms.Button
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   WithEvents cbHeaderAlign As System.Windows.Forms.ComboBox
   WithEvents cbFooterAlign As System.Windows.Forms.ComboBox
   WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
   Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
   WithEvents btnPrintPreview As System.Windows.Forms.Button
   Private panel3 As System.Windows.Forms.Panel
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
    
   '
   ' TODO: Add any constructor code after InitializeComponent call
   '
   
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
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.panel3 = New System.Windows.Forms.Panel()
      Me.cbFooterAlign = New System.Windows.Forms.ComboBox()
      Me.cbHeaderAlign = New System.Windows.Forms.ComboBox()
      Me.label2 = New System.Windows.Forms.Label()
      Me.label1 = New System.Windows.Forms.Label()
      Me.btnFooter = New System.Windows.Forms.Button()
      Me.btnHeader = New System.Windows.Forms.Button()
      Me.btnPrintPreview = New System.Windows.Forms.Button()
      Me.panel2 = New System.Windows.Forms.Panel()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
      Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
      Me.panel1.SuspendLayout()
      Me.panel2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' panel1
      ' 
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3, Me.cbFooterAlign, Me.cbHeaderAlign, Me.label2, Me.label1, Me.btnFooter, Me.btnHeader, Me.btnPrintPreview})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(168, 437)
      Me.panel1.TabIndex = 0
      ' 
      ' panel3
      ' 
      Me.panel3.BackColor = System.Drawing.SystemColors.ControlDark
      Me.panel3.Location = New System.Drawing.Point(8, 152)
      Me.panel3.Name = "panel3"
      Me.panel3.Size = New System.Drawing.Size(152, 4)
      Me.panel3.TabIndex = 6
      ' 
      ' cbFooterAlign
      ' 
      Me.cbFooterAlign.BackColor = System.Drawing.SystemColors.Control
      Me.cbFooterAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbFooterAlign.Items.AddRange(New Object() {"North", "South", "West", "East"})
      Me.cbFooterAlign.Location = New System.Drawing.Point(8, 112)
      Me.cbFooterAlign.Name = "cbFooterAlign"
      Me.cbFooterAlign.Size = New System.Drawing.Size(72, 21)
      Me.cbFooterAlign.TabIndex = 5
      ' 
      ' cbHeaderAlign
      ' 
      Me.cbHeaderAlign.BackColor = System.Drawing.SystemColors.Control
      Me.cbHeaderAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbHeaderAlign.Items.AddRange(New Object() {"North", "South", "West", "East"})
      Me.cbHeaderAlign.Location = New System.Drawing.Point(8, 40)
      Me.cbHeaderAlign.Name = "cbHeaderAlign"
      Me.cbHeaderAlign.Size = New System.Drawing.Size(72, 21)
      Me.cbHeaderAlign.TabIndex = 4
      ' 
      ' label2
      ' 
      Me.label2.BackColor = System.Drawing.SystemColors.InactiveCaption
      Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
      Me.label2.Location = New System.Drawing.Point(8, 80)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(152, 23)
      Me.label2.TabIndex = 3
      Me.label2.Text = "Footer"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' label1
      ' 
      Me.label1.BackColor = System.Drawing.SystemColors.InactiveCaption
      Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(152, 23)
      Me.label1.TabIndex = 2
      Me.label1.Text = "Header"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' btnFooter
      ' 
      Me.btnFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnFooter.Location = New System.Drawing.Point(88, 112)
      Me.btnFooter.Name = "btnFooter"
      Me.btnFooter.Size = New System.Drawing.Size(72, 21)
      Me.btnFooter.TabIndex = 1
      Me.btnFooter.Text = "Edit rtf ..."
      ' 
      ' btnHeader
      ' 
      Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnHeader.Location = New System.Drawing.Point(88, 40)
      Me.btnHeader.Name = "btnHeader"
      Me.btnHeader.Size = New System.Drawing.Size(72, 21)
      Me.btnHeader.TabIndex = 0
      Me.btnHeader.Text = "Edit rtf ..."
      ' 
      ' btnPrintPreview
      ' 
      Me.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnPrintPreview.Location = New System.Drawing.Point(40, 176)
      Me.btnPrintPreview.Name = "btnPrintPreview"
      Me.btnPrintPreview.Size = New System.Drawing.Size(96, 23)
      Me.btnPrintPreview.TabIndex = 1
      Me.btnPrintPreview.Text = "Print preview"
      ' 
      ' panel2
      ' 
      Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.panel2.Location = New System.Drawing.Point(168, 0)
      Me.panel2.Name = "panel2"
      Me.panel2.Size = New System.Drawing.Size(480, 437)
      Me.panel2.TabIndex = 1
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=None,Black,1;"" /><NamedStyle Nam" + "e=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Footer"" ParentName=""C" + "ontrol"" StyleData=""Font=Microsoft Sans Serif, 8.25pt;GradientStyle=None;ForeColo" + "r=ControlText;Border=None,Black,1;HatchStyle=None;Opaque=True;BackColor2=;BackCo" + "lor=White;"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle Na" + "me=""Control"" ParentName=""Control.default"" StyleData=""BackColor=White;"" /><NamedS" + "tyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Center" + ";AlignVert=Bottom;"" /><NamedStyle Name=""AxisY"" ParentName=""Area"" StyleData=""Rota" + "tion=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><NamedStyle Name=""LabelStyleD" + "efault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""Legend.defaul" + "t"" ParentName=""Control"" StyleData=""Border=None,Black,1;Wrap=False;AlignVert=Top;" + """ /><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""Control"" StyleData=" + """Border=None,Black,1;BackColor=Transparent;"" /><NamedStyle Name=""Header"" ParentN" + "ame=""Control"" StyleData=""Font=Microsoft Sans Serif, 8.25pt;GradientStyle=Diagona" + "lCenter;ForeColor=ControlText;Border=None,Black,1;HatchStyle=None;Opaque=True;Ba" + "ckColor2=Black;BackColor=White;"" /><NamedStyle Name=""Control.default"" ParentName" + "="""" StyleData=""ForeColor=ControlText;Border=None,Black,1;BackColor=Control;"" /><" + "NamedStyle Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHor" + "z=Far;AlignVert=Center;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" " + "StyleData=""Border=None,Black,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsC" + "ollection><ChartGroup Name=""Group1"" Use3D=""False""><DataSerializer DefaultSet=""Tr" + "ue""><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod""" + " /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><" + "X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Doubl" + "e</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><D" + "ataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""Cornflower" + "Blue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;1" + "0;12;15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>" + ";;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><Line" + "Style Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLab" + "el>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;" + "Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /" + "></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><Sy" + "mbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel><" + "X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doubl" + "e</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer></" + "DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=""Group2""><Da" + "taSerializer /></ChartGroup></ChartGroupsCollection><Header Compass=""North"" /><F" + "ooter Compass=""South"" /><Legend Compass=""East"" Visible=""False"" /><ChartArea /><A" + "xes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMin" + "or=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""South""><GridMajor /><GridMinor " + "/></Axis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" AutoMajor=""True"" Aut" + "oMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West""><GridMajor /><GridMin" + "or /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" A" + "utoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""East""><GridMajor /><GridM" + "inor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(476, 433)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' printDocument1
      ' 
      ' 
      ' printPreviewDialog1
      ' 
      Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
      Me.printPreviewDialog1.Document = Me.printDocument1
      Me.printPreviewDialog1.Enabled = True
      Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
      Me.printPreviewDialog1.Location = New System.Drawing.Point(148, 17)
      Me.printPreviewDialog1.MaximumSize = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog1.Name = "printPreviewDialog1"
      Me.printPreviewDialog1.Opacity = 1
      Me.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
      Me.printPreviewDialog1.Visible = False
      ' 
      ' Form1
      ' 
      Me.ClientSize = New System.Drawing.Size(648, 437)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.panel1})
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Rtf Title Demo"
      Me.panel1.ResumeLayout(False)
      Me.panel2.ResumeLayout(False)
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
   
   
   Private Sub btnHeader_Click(sender As Object, e As System.EventArgs) Handles btnHeader.Click
      Dim frm As New RtfForm()
      frm.Rtf = c1Chart1.Header.Rtf
      
      If frm.ShowDialog() = DialogResult.OK Then
         c1Chart1.Header.Rtf = frm.Rtf
      End If
   End Sub 'btnHeader_Click
   
   
   Private Sub btnFooter_Click(sender As Object, e As System.EventArgs) Handles btnFooter.Click
      Dim frm As New RtfForm()
      frm.Rtf = c1Chart1.Footer.Rtf
      
      If frm.ShowDialog() = DialogResult.OK Then
         c1Chart1.Footer.Rtf = frm.Rtf
      End If
   End Sub 'btnFooter_Click
   
   
   Private Sub cbHeaderAlign_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbHeaderAlign.SelectedIndexChanged
      c1Chart1.Header.Compass = CType([Enum].Parse(GetType(CompassEnum), cbHeaderAlign.SelectedItem.ToString()), CompassEnum)
   End Sub 'cbHeaderAlign_SelectedIndexChanged
   
   
   Private Sub cbFooterAlign_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbFooterAlign.SelectedIndexChanged
      c1Chart1.Footer.Compass = CType([Enum].Parse(GetType(CompassEnum), cbFooterAlign.SelectedItem.ToString()), CompassEnum)
   End Sub 'cbFooterAlign_SelectedIndexChanged
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' Create sample rtf header using RichTextBox cotrol
      Dim rtb As New RichTextBox()
      rtb.SelectionAlignment = HorizontalAlignment.Center
      rtb.SelectedText = "Multi-color header:" + ControlChars.Lf
      Dim fs As FontStyle = FontStyle.Underline Or FontStyle.Bold 
      rtb.SelectionFont = New Font("Lucida Console", 20, fs)
      rtb.SelectionColor = Color.Red
      rtb.SelectedText = "R"
      rtb.SelectionColor = Color.Orange
      rtb.SelectedText = "A"
      rtb.SelectionColor = Color.Yellow
      rtb.SelectedText = "I"
      rtb.SelectionColor = Color.Green
      rtb.SelectedText = "N"
      rtb.SelectionColor = Color.SkyBlue
      rtb.SelectedText = "B"
      rtb.SelectionColor = Color.Blue
      rtb.SelectedText = "O"
      rtb.SelectionColor = Color.Violet
      rtb.SelectedText = "W"
      c1Chart1.Header.Rtf = rtb.Rtf
      
      ' Create sample rtf footer using RichTextBox cotrol
      rtb.ResetText()
      rtb.SelectionAlignment = HorizontalAlignment.Center
      rtb.SelectedText = "Different text styles:" + ControlChars.Lf
      rtb.SelectionFont = New Font("Times New Roman", 12) ' , FontStyle.Underline | FontStyle.Bold);
      rtb.SelectionColor = Color.Black
      rtb.SelectedText = "Normal "
      rtb.SelectionFont = New Font("Times New Roman", 12, FontStyle.Bold)
      rtb.SelectedText = "Bold "
      rtb.SelectionFont = New Font("Times New Roman", 12, FontStyle.Underline)
      rtb.SelectedText = "Underline"
      rtb.SelectionFont = New Font("Times New Roman", 12)
      rtb.SelectedText = " "
      rtb.SelectionFont = New Font("Times New Roman", 12, FontStyle.Strikeout)
      rtb.SelectedText = "Strikeout"
      c1Chart1.Footer.Rtf = rtb.Rtf
      
      ' Set initial alignment
      cbHeaderAlign.SelectedItem = "North"
      cbFooterAlign.SelectedItem = "South"
   End Sub 'Form1_Load
   
   
   Private Sub printDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
      c1Chart1.Draw(e.Graphics, e.MarginBounds)
   End Sub 'printDocument1_PrintPage
   
   
   Private Sub btnPrintPreview_Click(sender As Object, e As System.EventArgs) Handles btnPrintPreview.Click
      printPreviewDialog1.ShowDialog()
   End Sub 'btnPrintPreview_Click
End Class 'Form1
