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
    Friend WithEvents C1Combo1 As C1.Win.List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.C1Combo1 = New C1.Win.List.C1Combo()
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Combo1
        '
        Me.C1Combo1.AddItemCols = 0
        Me.C1Combo1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1Combo1.AllowColMove = True
        Me.C1Combo1.AllowSort = True
        Me.C1Combo1.AlternatingRows = False
        Me.C1Combo1.Caption = ""
        Me.C1Combo1.CaptionHeight = 17
        Me.C1Combo1.CellTips = C1.Win.List.CellTipEnum.NoCellTips
        Me.C1Combo1.CellTipsWidth = 0
        Me.C1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.C1Combo1.ColumnCaptionHeight = 17
        Me.C1Combo1.ColumnFooterHeight = 17
        Me.C1Combo1.ColumnWidth = -1
        Me.C1Combo1.ContentHeight = 17
        Me.C1Combo1.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Combo1.DefColWidth = 0
        Me.C1Combo1.EditorBackColor = System.Drawing.SystemColors.Window
        Me.C1Combo1.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.C1Combo1.EditorHeight = 17
        Me.C1Combo1.GapHeight = 2
        Me.C1Combo1.IntegralHeight = False
        Me.C1Combo1.ItemHeight = 15
        Me.C1Combo1.Location = New System.Drawing.Point(48, 32)
        Me.C1Combo1.MatchEntryTimeout = CType(100, Long)
        Me.C1Combo1.MaxDropDownItems = CType(5, Short)
        Me.C1Combo1.MaxLength = 32767
        Me.C1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.C1Combo1.Name = "C1Combo1"
        Me.C1Combo1.PropBag = "<?xml version=""1.0""?><Blob><DataCols><C1DataColumn Level=""0"" Caption=""Name"" DataF" &
        "ield=""Name""><ValueItems /></C1DataColumn><C1DataColumn Level=""0"" Caption=""Contac" &
        "ted"" DataField=""Contacted""><ValueItems Translate=""True""><internalValues><ValueIt" &
        "em type=""C1.Win.List.ValueItem"" Value=""0"" dispVal=""No"" /><ValueItem type=""C1.W" &
        "in.C1List.ValueItem"" Value=""1"" dispVal=""Yes"" /></internalValues></ValueItems></C" &
        "1DataColumn></DataCols><Styles type=""C1.Win.List.Design.ContextWrapper""><Data>" &
        "Caption{AlignHorz:Center;}Normal{BackColor:Window;}Selected{ForeColor:HighlightT" &
        "ext;BackColor:Highlight;}Style18{AlignHorz:Near;}Style19{AlignHorz:Near;}Style14" &
        "{}Style15{AlignHorz:Near;}Style16{AlignHorz:Near;}Style17{}Style10{}Style11{}Odd" &
        "Row{}Style13{AlignHorz:Near;}Style12{AlignHorz:Near;}HighlightRow{ForeColor:High" &
        "lightText;BackColor:Highlight;}RecordSelector{AlignImage:Center;}Footer{}Style23" &
        "{}Style22{AlignHorz:Near;}Style21{AlignHorz:Near;}Style20{}Inactive{ForeColor:In" &
        "activeCaptionText;BackColor:InactiveCaption;}EvenRow{BackColor:Aqua;}Heading{Wra" &
        "p:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColo" &
        "r:Control;}Style4{}Style9{AlignHorz:Near;}Style8{}Style5{}Group{BackColor:Contro" &
        "lDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style7{}Style6{}Style1{}Style3{}" &
        "Style2{}</Data></Styles><Splits><C1.Win.List.ListBoxView AllowColSelect=""False" &
        """ Name="""" CaptionHeight=""17"" ColumnCaptionHeight=""17"" ColumnFooterHeight=""17"" Ve" &
        "rticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 118, 158</Clie" &
        "ntRect><internalCols><C1DisplayColumn><HeadingStyle parent=""Style2"" me=""Style18""" &
        " /><Style parent=""Normal"" me=""Style19"" /><FooterStyle parent=""Style3"" me=""Style2" &
        "0"" /><ColumnDivider><Color>DarkGray</Color><Style>Single</Style></ColumnDivider>" &
        "<Width>200</Width><Height>15</Height><DCIdx>0</DCIdx></C1DisplayColumn><C1Displa" &
        "yColumn><HeadingStyle parent=""Style2"" me=""Style21"" /><Style parent=""Normal"" me=""" &
        "Style22"" /><FooterStyle parent=""Style3"" me=""Style23"" /><ColumnDivider><Color>Dar" &
        "kGray</Color><Style>Single</Style></ColumnDivider><Height>15</Height><DCIdx>1</D" &
        "CIdx></C1DisplayColumn></internalCols><VScrollBar><Width>17</Width></VScrollBar>" &
        "<HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""St" &
        "yle9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer" &
        """ me=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""" &
        "Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><I" &
        "nactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""St" &
        "yle8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedSty" &
        "le parent=""Selected"" me=""Style5"" /><Style parent="""" me=""Normal"" /></C1.Win.Lis" &
        "t.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent" &
        "=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""He" &
        "ading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Nor" &
        "mal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""N" &
        "ormal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Headin" &
        "g"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><ver" &
        "tSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><Defaul" &
        "tRecSelWidth>17</DefaultRecSelWidth></Blob>"
        Me.C1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.None
        Me.C1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Combo1.ScrollTips = False
        Me.C1Combo1.SelectionStart = 0
        Me.C1Combo1.Size = New System.Drawing.Size(336, 21)
        Me.C1Combo1.TabIndex = 0
        Me.C1Combo1.Text = "C1Combo1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 272)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1Combo1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial21"
        CType(Me.C1Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me.C1Combo1
            .HoldFields()

            .AddItem("Greg Daryll;0")

            .AddItem("Jane Lambert;1")

            .AddItem("Allen Clark;1")

            .AddItem("David Elkins;1")

            .AddItem("Carl Ziegler;0")

            .AddItem("William Yahner;1")

        End With
    End Sub
End Class
