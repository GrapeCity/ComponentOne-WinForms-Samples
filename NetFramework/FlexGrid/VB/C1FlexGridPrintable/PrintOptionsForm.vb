Imports System
Imports System.Drawing
imports System.Collections
imports System.ComponentModel
Imports System.Windows.Forms

Imports C1.C1Preview

Namespace C1.Win.C1FlexGrid
    ''' <summary>
    ''' Provides UI for printing, exporting or previewing C1FlexGridPrintable.
    ''' </summary>
    Public Class PrintOptionsForm
        Inherits System.Windows.Forms.Form
	    ''' <summary>
        ''' Describes the desired action, such as printing or exporting.
        ''' </summary>
        Public Class ActionItem
            ''' <summary>
            ''' The empty action item (no action).
            ''' </summary>
            Public Shared Empty As New ActionItem(ActionFlags.None, Nothing)

            Private _action As ActionFlags = ActionFlags.None
            Private _provider As Global.C1.C1Preview.Export.ExportProvider = Nothing

            ''' <summary>
            ''' Creates a new instance of the ActionItem class. 
            ''' </summary>
            Public Sub New(ByVal action As ActionFlags, ByVal provider As Export.ExportProvider)
                _action = action
                _provider = provider
            End Sub

            ''' <summary>
            ''' Gets or sets the desired action.
            ''' </summary>
            Public Property Action() As ActionFlags
                Get
                    Return _action
                End Get
                Set(ByVal value As ActionFlags)
                    _action = value
                End Set
            End Property

            ''' <summary>
            ''' Gets or sets the export provider.
            ''' </summary>
            Public Property Provider() As Export.ExportProvider
                Get
                    Return _provider
                End Get
                Set(ByVal value As Export.ExportProvider)
                    _provider = value
                End Set
            End Property

            ''' <summary>
            ''' 
            ''' </summary>
            Public Overrides Function ToString() As String
                If Provider IsNot Nothing Then
                    Return String.Format("Export to {0}", Provider.FormatName)
                Else
                    Select Case Action
                        Case ActionFlags.None
                            Return "None"
                        Case ActionFlags.Preview
                            Return "Print Preview"
                        Case ActionFlags.Print
                            Return "Print"
                        Case Else
                            Return "None"
                    End Select
                End If
            End Function
        End Class

        ''' <summary>
        ''' Describes the row height.
        ''' </summary>
        Public Class RowHeightItem
            Public RowHeight As RowHeightEnum = RowHeightEnum.StretchToFit

            Public Sub New(ByVal rh As RowHeightEnum)
                RowHeight = rh
            End Sub

            Public Overrides Function ToString() As String
                Select Case RowHeight
                    Case RowHeightEnum.StretchToFit
                        Return "Stretch to fit"
                    Case RowHeightEnum.LikeGrid
                        Return "Fixed"
                    Case RowHeightEnum.StretchToMax
                        Return "Stretch up to value"
                    Case Else
                        Return "Stretch to fit"
                End Select
            End Function

            Public Shared RowHeightItems As RowHeightItem() = New RowHeightItem() { _
                New RowHeightItem(RowHeightEnum.StretchToFit), _
                New RowHeightItem(RowHeightEnum.LikeGrid), _
                New RowHeightItem(RowHeightEnum.StretchToMax) _
            }
        End Class

        Public Class PageBreakItem
            Public PageBreaks As PageBreaksEnum = PageBreaksEnum.FitIntoArea

            Public Sub New(ByVal pb As PageBreaksEnum)
                PageBreaks = pb
            End Sub

            Public Overrides Function ToString() As String
                Select Case (PageBreaks)
                    Case PageBreaksEnum.FitIntoArea
                        Return "Fit columns on one page"
                    Case PageBreaksEnum.OnColumn
                        Return "Break on any column"
                    Case Else
                        Return "Fit columns on one page"
                End Select
            End Function

            Public Shared PageBreakItems As PageBreakItem() = New PageBreakItem() { _
                New PageBreakItem(PageBreaksEnum.FitIntoArea), _
                New PageBreakItem(PageBreaksEnum.OnColumn) _
            }

        End Class

        Public Class FillEmptyItem

            Public FillEmpty As FillEmptyEnum = FillEmptyEnum.ExtendAll

            Public Sub New(ByVal fe As FillEmptyEnum)
                FillEmpty = fe
            End Sub

            Public Overrides Function ToString() As String
                Select Case (FillEmpty)
                    Case FillEmptyEnum.ExtendAll
                        Return "Stretch all columns"
                    Case FillEmptyEnum.None
                        Return "Do not stretch"
                    Case FillEmptyEnum.ExtendLastCol
                        Return "Stretch last column"
                    Case Else
                        Return "Stretch all columns"
                End Select
            End Function

            Public Shared FillEmptyItems As FillEmptyItem() = New FillEmptyItem() { _
                New FillEmptyItem(FillEmptyEnum.ExtendAll), _
                New FillEmptyItem(FillEmptyEnum.None), _
                New FillEmptyItem(FillEmptyEnum.ExtendLastCol) _
            }

        End Class

        Public Class WrapTextItem
            Public WrapText As WrapTextEnum = WrapTextEnum.Wrap

            Public Sub New(ByVal wt As WrapTextEnum)
                WrapText = wt
            End Sub

            Public Overrides Function ToString() As String
                Select Case (WrapText)
                    Case WrapTextEnum.Wrap
                        Return "Wrap all text"
                    Case WrapTextEnum.NoWrap
                        Return "Do not wrap text"
                    Case WrapTextEnum.LikeCell
                        Return "Wrap like cells"
                    Case Else
                        Return "Wrap all text"
                End Select
            End Function

            Public Shared WrapTextItems As WrapTextItem() = New WrapTextItem() { _
                New WrapTextItem(WrapTextEnum.Wrap), _
                New WrapTextItem(WrapTextEnum.NoWrap), _
                New WrapTextItem(WrapTextEnum.LikeCell) _
            }
        End Class

        ' filled in Form_Load
        Private _providers As Export.ExportProvider() = Nothing

        Public Event ExporterChanged As EventHandler

        Protected Overridable Sub OnExporterChanged(ByVal e As EventArgs)
            RaiseEvent ExporterChanged(Me, e)
        End Sub

        Public Event ActionChanged As EventHandler

        Protected Overridable Sub OnActionChanged(ByVal e As EventArgs)
            RaiseEvent ActionChanged(Me, e)
        End Sub

        Protected m_exporter As Global.C1.C1Preview.Export.Exporter = Nothing
        Protected m_action As ActionFlags = ActionFlags.None
        Protected m_actionMask As ActionFlags = ActionFlags.MaskAll
        Protected m_rowHeight As RowHeightEnum = RowHeightEnum.StretchToFit
        Protected m_pageBreaks As PageBreaksEnum = PageBreaksEnum.FitIntoArea
        Protected m_fillEmpty As FillEmptyEnum = FillEmptyEnum.ExtendAll
        Protected m_wrapText As WrapTextEnum = WrapTextEnum.Wrap
        Public WithEvents m_outputFileName As System.Windows.Forms.TextBox
        Public WithEvents m_chkUseGridColors As System.Windows.Forms.CheckBox
        Public WithEvents m_numFooterHeight As System.Windows.Forms.NumericUpDown
        Public WithEvents m_numHeaderHeight As System.Windows.Forms.NumericUpDown
        Public WithEvents m_txtFooter As System.Windows.Forms.TextBox
        Public WithEvents m_txtHeader As System.Windows.Forms.TextBox
        Public WithEvents m_numMaxRowHeight As System.Windows.Forms.NumericUpDown
        Public WithEvents m_cmbRowHeight As System.Windows.Forms.ComboBox
        Public WithEvents m_chkHiddenRows As System.Windows.Forms.CheckBox
        Public WithEvents m_chkHiddenCols As System.Windows.Forms.CheckBox
        Public WithEvents m_chkRepeatRows As System.Windows.Forms.CheckBox
        Public WithEvents m_chkRepeatCols As System.Windows.Forms.CheckBox
        Public WithEvents m_cmbStretchToWidth As System.Windows.Forms.ComboBox
        Public WithEvents m_cmbWrapText As System.Windows.Forms.ComboBox
        Public WithEvents m_cmbHorzPageBreak As System.Windows.Forms.ComboBox
        Public WithEvents m_chkShowProgress As System.Windows.Forms.CheckBox
        Protected WithEvents m_grpPageHeaders As System.Windows.Forms.GroupBox
        Protected WithEvents m_lblFooterHeight As System.Windows.Forms.Label
        Protected WithEvents m_lblHeaderHeight As System.Windows.Forms.Label
        Protected WithEvents m_lblFooter As System.Windows.Forms.Label
        Protected WithEvents m_lblHeader As System.Windows.Forms.Label
        Protected WithEvents m_grpRenderOptions As System.Windows.Forms.GroupBox
        Protected WithEvents m_lblRowHeight As System.Windows.Forms.Label
        Protected WithEvents m_lblStretchToWidth As System.Windows.Forms.Label
        Protected WithEvents m_lblWrapText As System.Windows.Forms.Label
        Protected WithEvents m_lblHorzPageBreak As System.Windows.Forms.Label
        Protected WithEvents m_btnOK As System.Windows.Forms.Button
        Protected WithEvents m_btnCancel As System.Windows.Forms.Button
        Protected WithEvents m_lblAction As System.Windows.Forms.Label
        Protected WithEvents m_btnOutputFileName As System.Windows.Forms.Button
        Protected WithEvents m_btnOptions As System.Windows.Forms.Button
        Protected WithEvents m_cmbAction As System.Windows.Forms.ComboBox
        Protected WithEvents m_lblOutputFileName As System.Windows.Forms.Label
        Protected WithEvents m_lblMaxRowHeight As System.Windows.Forms.Label
        Private components As System.ComponentModel.Container = Nothing

        ''' <summary>
        ''' Creates a new instance of the PrintOptionsFrom class.
        ''' </summary>
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' Called when the class is being disposed.
        ''' </summary>
        ''' <param name="disposing">
        ''' True to cleanup.
        ''' </param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of me method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.m_chkUseGridColors = New System.Windows.Forms.CheckBox()
            Me.m_grpPageHeaders = New System.Windows.Forms.GroupBox()
            Me.m_numFooterHeight = New System.Windows.Forms.NumericUpDown()
            Me.m_lblFooterHeight = New System.Windows.Forms.Label()
            Me.m_numHeaderHeight = New System.Windows.Forms.NumericUpDown()
            Me.m_lblHeaderHeight = New System.Windows.Forms.Label()
            Me.m_txtFooter = New System.Windows.Forms.TextBox()
            Me.m_lblFooter = New System.Windows.Forms.Label()
            Me.m_txtHeader = New System.Windows.Forms.TextBox()
            Me.m_lblHeader = New System.Windows.Forms.Label()
            Me.m_grpRenderOptions = New System.Windows.Forms.GroupBox()
            Me.m_lblMaxRowHeight = New System.Windows.Forms.Label()
            Me.m_cmbHorzPageBreak = New System.Windows.Forms.ComboBox()
            Me.m_lblHorzPageBreak = New System.Windows.Forms.Label()
            Me.m_cmbWrapText = New System.Windows.Forms.ComboBox()
            Me.m_lblWrapText = New System.Windows.Forms.Label()
            Me.m_cmbStretchToWidth = New System.Windows.Forms.ComboBox()
            Me.m_lblStretchToWidth = New System.Windows.Forms.Label()
            Me.m_chkHiddenRows = New System.Windows.Forms.CheckBox()
            Me.m_chkHiddenCols = New System.Windows.Forms.CheckBox()
            Me.m_chkRepeatRows = New System.Windows.Forms.CheckBox()
            Me.m_chkRepeatCols = New System.Windows.Forms.CheckBox()
            Me.m_numMaxRowHeight = New System.Windows.Forms.NumericUpDown()
            Me.m_cmbRowHeight = New System.Windows.Forms.ComboBox()
            Me.m_lblRowHeight = New System.Windows.Forms.Label()
            Me.m_btnOK = New System.Windows.Forms.Button()
            Me.m_btnCancel = New System.Windows.Forms.Button()
            Me.m_cmbAction = New System.Windows.Forms.ComboBox()
            Me.m_lblAction = New System.Windows.Forms.Label()
            Me.m_outputFileName = New System.Windows.Forms.TextBox()
            Me.m_lblOutputFileName = New System.Windows.Forms.Label()
            Me.m_btnOutputFileName = New System.Windows.Forms.Button()
            Me.m_btnOptions = New System.Windows.Forms.Button()
            Me.m_chkShowProgress = New System.Windows.Forms.CheckBox()
            Me.m_grpPageHeaders.SuspendLayout()
            CType(Me.m_numFooterHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.m_numHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.m_grpRenderOptions.SuspendLayout()
            CType(Me.m_numMaxRowHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' m_chkUseGridColors
            ' 
            Me.m_chkUseGridColors.Checked = True
            Me.m_chkUseGridColors.CheckState = System.Windows.Forms.CheckState.Checked
            Me.m_chkUseGridColors.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkUseGridColors.Location = New System.Drawing.Point(480, 136)
            Me.m_chkUseGridColors.Name = "m_chkUseGridColors"
            Me.m_chkUseGridColors.Size = New System.Drawing.Size(128, 24)
            Me.m_chkUseGridColors.TabIndex = 32
            Me.m_chkUseGridColors.Text = "Use grid colors"
            ' 
            ' m_grpPageHeaders
            ' 
            Me.m_grpPageHeaders.Controls.Add(Me.m_numFooterHeight)
            Me.m_grpPageHeaders.Controls.Add(Me.m_lblFooterHeight)
            Me.m_grpPageHeaders.Controls.Add(Me.m_numHeaderHeight)
            Me.m_grpPageHeaders.Controls.Add(Me.m_lblHeaderHeight)
            Me.m_grpPageHeaders.Controls.Add(Me.m_txtFooter)
            Me.m_grpPageHeaders.Controls.Add(Me.m_lblFooter)
            Me.m_grpPageHeaders.Controls.Add(Me.m_txtHeader)
            Me.m_grpPageHeaders.Controls.Add(Me.m_lblHeader)
            Me.m_grpPageHeaders.Location = New System.Drawing.Point(8, 40)
            Me.m_grpPageHeaders.Name = "m_grpPageHeaders"
            Me.m_grpPageHeaders.Size = New System.Drawing.Size(456, 80)
            Me.m_grpPageHeaders.TabIndex = 6
            Me.m_grpPageHeaders.TabStop = False
            Me.m_grpPageHeaders.Text = " Page Headers and Footers"
            ' 
            ' m_numFooterHeight
            ' 
            Me.m_numFooterHeight.Location = New System.Drawing.Point(400, 51)
            Me.m_numFooterHeight.Name = "m_numFooterHeight"
            Me.m_numFooterHeight.Size = New System.Drawing.Size(45, 20)
            Me.m_numFooterHeight.TabIndex = 14
            ' 
            ' m_lblFooterHeight
            ' 
            Me.m_lblFooterHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblFooterHeight.Location = New System.Drawing.Point(280, 51)
            Me.m_lblFooterHeight.Name = "m_lblFooterHeight"
            Me.m_lblFooterHeight.Size = New System.Drawing.Size(118, 16)
            Me.m_lblFooterHeight.TabIndex = 13
            Me.m_lblFooterHeight.Text = "Height (in 1/100 inch)"
            Me.m_lblFooterHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_numHeaderHeight
            ' 
            Me.m_numHeaderHeight.Location = New System.Drawing.Point(400, 27)
            Me.m_numHeaderHeight.Name = "m_numHeaderHeight"
            Me.m_numHeaderHeight.Size = New System.Drawing.Size(45, 20)
            Me.m_numHeaderHeight.TabIndex = 10
            Me.m_numHeaderHeight.Value = New Decimal(New Integer() {30, 0, 0, 0})
            ' 
            ' m_lblHeaderHeight
            ' 
            Me.m_lblHeaderHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblHeaderHeight.Location = New System.Drawing.Point(280, 27)
            Me.m_lblHeaderHeight.Name = "m_lblHeaderHeight"
            Me.m_lblHeaderHeight.Size = New System.Drawing.Size(118, 16)
            Me.m_lblHeaderHeight.TabIndex = 9
            Me.m_lblHeaderHeight.Text = "Height (in 1/100 inch)"
            Me.m_lblHeaderHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_txtFooter
            ' 
            Me.m_txtFooter.Location = New System.Drawing.Point(88, 51)
            Me.m_txtFooter.Name = "m_txtFooter"
            Me.m_txtFooter.Size = New System.Drawing.Size(176, 20)
            Me.m_txtFooter.TabIndex = 12
            ' 
            ' m_lblFooter
            ' 
            Me.m_lblFooter.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblFooter.Location = New System.Drawing.Point(11, 51)
            Me.m_lblFooter.Name = "m_lblFooter"
            Me.m_lblFooter.Size = New System.Drawing.Size(77, 16)
            Me.m_lblFooter.TabIndex = 11
            Me.m_lblFooter.Text = "Footer text"
            Me.m_lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_txtHeader
            ' 
            Me.m_txtHeader.Location = New System.Drawing.Point(88, 24)
            Me.m_txtHeader.Name = "m_txtHeader"
            Me.m_txtHeader.Size = New System.Drawing.Size(176, 20)
            Me.m_txtHeader.TabIndex = 8
            Me.m_txtHeader.Text = "Page \\p of \\P"
            ' 
            ' m_lblHeader
            ' 
            Me.m_lblHeader.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblHeader.Location = New System.Drawing.Point(11, 27)
            Me.m_lblHeader.Name = "m_lblHeader"
            Me.m_lblHeader.Size = New System.Drawing.Size(77, 16)
            Me.m_lblHeader.TabIndex = 7
            Me.m_lblHeader.Text = "Header text"
            Me.m_lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_grpRenderOptions
            ' 
            Me.m_grpRenderOptions.Controls.Add(Me.m_lblMaxRowHeight)
            Me.m_grpRenderOptions.Controls.Add(Me.m_cmbHorzPageBreak)
            Me.m_grpRenderOptions.Controls.Add(Me.m_lblHorzPageBreak)
            Me.m_grpRenderOptions.Controls.Add(Me.m_cmbWrapText)
            Me.m_grpRenderOptions.Controls.Add(Me.m_lblWrapText)
            Me.m_grpRenderOptions.Controls.Add(Me.m_cmbStretchToWidth)
            Me.m_grpRenderOptions.Controls.Add(Me.m_lblStretchToWidth)
            Me.m_grpRenderOptions.Controls.Add(Me.m_chkHiddenRows)
            Me.m_grpRenderOptions.Controls.Add(Me.m_chkHiddenCols)
            Me.m_grpRenderOptions.Controls.Add(Me.m_chkRepeatRows)
            Me.m_grpRenderOptions.Controls.Add(Me.m_chkRepeatCols)
            Me.m_grpRenderOptions.Controls.Add(Me.m_numMaxRowHeight)
            Me.m_grpRenderOptions.Controls.Add(Me.m_cmbRowHeight)
            Me.m_grpRenderOptions.Controls.Add(Me.m_lblRowHeight)
            Me.m_grpRenderOptions.Location = New System.Drawing.Point(8, 128)
            Me.m_grpRenderOptions.Name = "m_grpRenderOptions"
            Me.m_grpRenderOptions.Size = New System.Drawing.Size(456, 155)
            Me.m_grpRenderOptions.TabIndex = 15
            Me.m_grpRenderOptions.TabStop = False
            Me.m_grpRenderOptions.Text = "C1FlexGrid printing options"
            ' 
            ' m_lblMaxRowHeight
            ' 
            Me.m_lblMaxRowHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblMaxRowHeight.Location = New System.Drawing.Point(352, 27)
            Me.m_lblMaxRowHeight.Name = "m_lblMaxRowHeight"
            Me.m_lblMaxRowHeight.Size = New System.Drawing.Size(81, 16)
            Me.m_lblMaxRowHeight.TabIndex = 19
            Me.m_lblMaxRowHeight.Text = "(in 1/100 inch)"
            Me.m_lblMaxRowHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_cmbHorzPageBreak
            ' 
            Me.m_cmbHorzPageBreak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.m_cmbHorzPageBreak.ItemHeight = 13
            Me.m_cmbHorzPageBreak.Items.AddRange(New Object() { _
            "Fit columns on one page", _
            "Clip columns in page", _
            "Break on splits", _
            "Break on any column"})
            Me.m_cmbHorzPageBreak.Location = New System.Drawing.Point(128, 88)
            Me.m_cmbHorzPageBreak.Name = "m_cmbHorzPageBreak"
            Me.m_cmbHorzPageBreak.Size = New System.Drawing.Size(160, 21)
            Me.m_cmbHorzPageBreak.TabIndex = 23
            ' 
            ' m_lblHorzPageBreak
            ' 
            Me.m_lblHorzPageBreak.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblHorzPageBreak.Location = New System.Drawing.Point(8, 88)
            Me.m_lblHorzPageBreak.Name = "m_lblHorzPageBreak"
            Me.m_lblHorzPageBreak.Size = New System.Drawing.Size(120, 23)
            Me.m_lblHorzPageBreak.TabIndex = 22
            Me.m_lblHorzPageBreak.Text = "Horizontal page break"
            Me.m_lblHorzPageBreak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_cmbWrapText
            ' 
            Me.m_cmbWrapText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.m_cmbWrapText.ItemHeight = 13
            Me.m_cmbWrapText.Items.AddRange(New Object() { _
            "Wrap all text", _
            "Do not wrap text", _
            "Wrap like columns"})
            Me.m_cmbWrapText.Location = New System.Drawing.Point(128, 56)
            Me.m_cmbWrapText.Name = "m_cmbWrapText"
            Me.m_cmbWrapText.Size = New System.Drawing.Size(160, 21)
            Me.m_cmbWrapText.TabIndex = 21
            ' 
            ' m_lblWrapText
            ' 
            Me.m_lblWrapText.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblWrapText.Location = New System.Drawing.Point(8, 56)
            Me.m_lblWrapText.Name = "m_lblWrapText"
            Me.m_lblWrapText.Size = New System.Drawing.Size(120, 23)
            Me.m_lblWrapText.TabIndex = 20
            Me.m_lblWrapText.Text = "Wrap text in columns"
            Me.m_lblWrapText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_cmbStretchToWidth
            ' 
            Me.m_cmbStretchToWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.m_cmbStretchToWidth.ItemHeight = 13
            Me.m_cmbStretchToWidth.Items.AddRange(New Object() { _
            "Stretch all columns", _
            "Do not stretch", _
            "Stretch last column"})
            Me.m_cmbStretchToWidth.Location = New System.Drawing.Point(128, 120)
            Me.m_cmbStretchToWidth.Name = "m_cmbStretchToWidth"
            Me.m_cmbStretchToWidth.Size = New System.Drawing.Size(160, 21)
            Me.m_cmbStretchToWidth.TabIndex = 25
            ' 
            ' m_lblStretchToWidth
            ' 
            Me.m_lblStretchToWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblStretchToWidth.Location = New System.Drawing.Point(8, 120)
            Me.m_lblStretchToWidth.Name = "m_lblStretchToWidth"
            Me.m_lblStretchToWidth.Size = New System.Drawing.Size(120, 23)
            Me.m_lblStretchToWidth.TabIndex = 24
            Me.m_lblStretchToWidth.Text = "Stretch to page width"
            Me.m_lblStretchToWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_chkHiddenRows
            ' 
            Me.m_chkHiddenRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkHiddenRows.Location = New System.Drawing.Point(304, 128)
            Me.m_chkHiddenRows.Name = "m_chkHiddenRows"
            Me.m_chkHiddenRows.Size = New System.Drawing.Size(144, 17)
            Me.m_chkHiddenRows.TabIndex = 29
            Me.m_chkHiddenRows.Text = "Show hidden rows"
            ' 
            ' m_chkHiddenCols
            ' 
            Me.m_chkHiddenCols.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkHiddenCols.Location = New System.Drawing.Point(304, 104)
            Me.m_chkHiddenCols.Name = "m_chkHiddenCols"
            Me.m_chkHiddenCols.Size = New System.Drawing.Size(144, 17)
            Me.m_chkHiddenCols.TabIndex = 28
            Me.m_chkHiddenCols.Text = "Show hidden columns"
            ' 
            ' m_chkRepeatRows
            ' 
            Me.m_chkRepeatRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkRepeatRows.Location = New System.Drawing.Point(304, 80)
            Me.m_chkRepeatRows.Name = "m_chkRepeatRows"
            Me.m_chkRepeatRows.Size = New System.Drawing.Size(144, 17)
            Me.m_chkRepeatRows.TabIndex = 27
            Me.m_chkRepeatRows.Text = "Repeat fixed rows"
            ' 
            ' m_chkRepeatCols
            ' 
            Me.m_chkRepeatCols.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkRepeatCols.Location = New System.Drawing.Point(304, 56)
            Me.m_chkRepeatCols.Name = "m_chkRepeatCols"
            Me.m_chkRepeatCols.Size = New System.Drawing.Size(144, 17)
            Me.m_chkRepeatCols.TabIndex = 26
            Me.m_chkRepeatCols.Text = "Repeat fixed columns"
            ' 
            ' m_numMaxRowHeight
            ' 
            Me.m_numMaxRowHeight.Location = New System.Drawing.Point(304, 24)
            Me.m_numMaxRowHeight.Name = "m_numMaxRowHeight"
            Me.m_numMaxRowHeight.Size = New System.Drawing.Size(42, 20)
            Me.m_numMaxRowHeight.TabIndex = 18
            Me.m_numMaxRowHeight.Value = New Decimal(New Integer() {15, 0, 0, 0})
            ' 
            ' m_cmbRowHeight
            ' 
            Me.m_cmbRowHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.m_cmbRowHeight.ItemHeight = 13
            Me.m_cmbRowHeight.Items.AddRange(New Object() { _
            "Stretch to fit", _
            "Fixed", _
            "Stretch up to value"})
            Me.m_cmbRowHeight.Location = New System.Drawing.Point(128, 24)
            Me.m_cmbRowHeight.Name = "m_cmbRowHeight"
            Me.m_cmbRowHeight.Size = New System.Drawing.Size(160, 21)
            Me.m_cmbRowHeight.TabIndex = 17
            ' 
            ' m_lblRowHeight
            ' 
            Me.m_lblRowHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblRowHeight.Location = New System.Drawing.Point(8, 24)
            Me.m_lblRowHeight.Name = "m_lblRowHeight"
            Me.m_lblRowHeight.Size = New System.Drawing.Size(120, 23)
            Me.m_lblRowHeight.TabIndex = 16
            Me.m_lblRowHeight.Text = "Row height"
            Me.m_lblRowHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_btnOK
            ' 
            Me.m_btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.m_btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_btnOK.Location = New System.Drawing.Point(526, 226)
            Me.m_btnOK.Name = "m_btnOK"
            Me.m_btnOK.Size = New System.Drawing.Size(80, 23)
            Me.m_btnOK.TabIndex = 34
            Me.m_btnOK.Text = "OK"
            ' 
            ' m_btnCancel
            ' 
            Me.m_btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            Me.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.m_btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_btnCancel.Location = New System.Drawing.Point(526, 257)
            Me.m_btnCancel.Name = "m_btnCancel"
            Me.m_btnCancel.Size = New System.Drawing.Size(80, 23)
            Me.m_btnCancel.TabIndex = 35
            Me.m_btnCancel.Text = "Cancel"
            ' 
            ' m_cmbAction
            ' 
            Me.m_cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.m_cmbAction.ItemHeight = 13
            Me.m_cmbAction.Items.AddRange(New Object() { _
            "Print Preview", _
            "Export to HTML", _
            "Export to PDF"})
            Me.m_cmbAction.Location = New System.Drawing.Point(48, 7)
            Me.m_cmbAction.Name = "m_cmbAction"
            Me.m_cmbAction.Size = New System.Drawing.Size(184, 21)
            Me.m_cmbAction.TabIndex = 2
            ' 
            ' m_lblAction
            ' 
            Me.m_lblAction.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblAction.Location = New System.Drawing.Point(8, 5)
            Me.m_lblAction.Name = "m_lblAction"
            Me.m_lblAction.Size = New System.Drawing.Size(40, 23)
            Me.m_lblAction.TabIndex = 1
            Me.m_lblAction.Text = "Action:"
            Me.m_lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' m_outputFileName
            ' 
            Me.m_outputFileName.Location = New System.Drawing.Point(304, 8)
            Me.m_outputFileName.Name = "m_outputFileName"
            Me.m_outputFileName.Size = New System.Drawing.Size(272, 20)
            Me.m_outputFileName.TabIndex = 4
            ' 
            ' m_lblOutputFileName
            ' 
            Me.m_lblOutputFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_lblOutputFileName.Location = New System.Drawing.Point(240, 5)
            Me.m_lblOutputFileName.Name = "m_lblOutputFileName"
            Me.m_lblOutputFileName.Size = New System.Drawing.Size(64, 23)
            Me.m_lblOutputFileName.TabIndex = 3
            Me.m_lblOutputFileName.Text = "File name:"
            Me.m_lblOutputFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            ' 
            ' m_btnOutputFileName
            ' 
            Me.m_btnOutputFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_btnOutputFileName.Location = New System.Drawing.Point(584, 8)
            Me.m_btnOutputFileName.Name = "m_btnOutputFileName"
            Me.m_btnOutputFileName.Size = New System.Drawing.Size(22, 20)
            Me.m_btnOutputFileName.TabIndex = 5
            Me.m_btnOutputFileName.Text = "..."
            ' 
            ' m_btnOptions
            ' 
            Me.m_btnOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_btnOptions.Location = New System.Drawing.Point(528, 48)
            Me.m_btnOptions.Name = "m_btnOptions"
            Me.m_btnOptions.Size = New System.Drawing.Size(80, 23)
            Me.m_btnOptions.TabIndex = 31
            Me.m_btnOptions.Text = "Options..."
            ' 
            ' m_chkShowProgress
            ' 
            Me.m_chkShowProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.m_chkShowProgress.Location = New System.Drawing.Point(480, 160)
            Me.m_chkShowProgress.Name = "m_chkShowProgress"
            Me.m_chkShowProgress.Size = New System.Drawing.Size(128, 24)
            Me.m_chkShowProgress.TabIndex = 33
            Me.m_chkShowProgress.Text = "Show progress"
            ' 
            ' PrintOptionsForm
            ' 
            Me.AcceptButton = Me.m_btnOK
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.CancelButton = Me.m_btnCancel
            Me.ClientSize = New System.Drawing.Size(616, 295)
            Me.Controls.Add(Me.m_chkShowProgress)
            Me.Controls.Add(Me.m_btnOptions)
            Me.Controls.Add(Me.m_btnOutputFileName)
            Me.Controls.Add(Me.m_lblOutputFileName)
            Me.Controls.Add(Me.m_outputFileName)
            Me.Controls.Add(Me.m_lblAction)
            Me.Controls.Add(Me.m_cmbAction)
            Me.Controls.Add(Me.m_btnCancel)
            Me.Controls.Add(Me.m_btnOK)
            Me.Controls.Add(Me.m_grpRenderOptions)
            Me.Controls.Add(Me.m_grpPageHeaders)
            Me.Controls.Add(Me.m_chkUseGridColors)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "PrintOptionsForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "FlexGrid Print/Export Options"
            Me.m_grpPageHeaders.ResumeLayout(False)
            Me.m_grpPageHeaders.PerformLayout()
            CType(Me.m_numFooterHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.m_numHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
            Me.m_grpRenderOptions.ResumeLayout(False)
            CType(Me.m_numMaxRowHeight, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Public Property Exporter() As Global.C1.C1Preview.Export.Exporter
            Get
                Return m_exporter
            End Get
            Set(ByVal value As Global.C1.C1Preview.Export.Exporter)
                m_exporter = value
                Me.OnExporterChanged(EventArgs.Empty)
            End Set
        End Property

        Public Property OutputFileName() As String
            Get
                Return m_outputFileName.Text
            End Get
            Set(ByVal value As String)
                m_outputFileName.Text = value
            End Set
        End Property

        Friend ReadOnly Property ExpProvider() As Global.C1.C1Preview.Export.ExportProvider
            Get
                Return Exporter.ExportProvider
            End Get
        End Property

        Public Property Action() As ActionFlags
            Get
                Return m_action
            End Get
            Set(ByVal value As ActionFlags)
                Me.OnActionChanged(EventArgs.Empty)
                m_action = value
            End Set
        End Property

        Public Property ActionMask() As ActionFlags
            Get
                Return m_actionMask
            End Get
            Set(ByVal value As ActionFlags)
                m_actionMask = value
            End Set
        End Property

        Public Property RowHeight() As RowHeightEnum
            Get
                Return m_rowHeight
            End Get
            Set(ByVal value As RowHeightEnum)
                m_rowHeight = value
            End Set
        End Property

        Public Property PageBreaks() As PageBreaksEnum
            Get
                Return m_pageBreaks
            End Get
            Set(ByVal value As PageBreaksEnum)
                m_pageBreaks = value
            End Set
        End Property

        Public Property FillEmpty() As FillEmptyEnum
            Get
                Return m_fillEmpty
            End Get
            Set(ByVal value As FillEmptyEnum)
                m_fillEmpty = value
            End Set
        End Property

        Public Property WrapText() As WrapTextEnum
            Get
                Return m_wrapText
            End Get
            Set(ByVal value As WrapTextEnum)
                m_wrapText = value
            End Set
        End Property

        Protected Overridable Sub m_btnOutputFileName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_btnOutputFileName.Click
            Dim ep As Global.C1.C1Preview.Export.ExportProvider
            If Exporter IsNot Nothing Then
                ep = ExpProvider
            Else
                ep = Nothing
            End If
            Dim name As String = Me.m_outputFileName.Text
            Dim ok As Boolean = C1FlexGridPrintable.SelectExportFile(Me, _providers, name, ep)
            If (Not ok OrElse ep Is Nothing) Then
                Return
            End If

            Me.m_outputFileName.Text = name
            If Exporter Is Nothing OrElse ep IsNot ExpProvider Then
                ' export format was changed in the save as dialog
                Exporter = C1FlexGridPrintable.CreateExporter(ep)
                Dim ai As ActionItem
                For Each ai In m_cmbAction.Items
                    If ai.Provider Is ep Then
                        m_cmbAction.SelectedItem = ai
                        Exit For
                    End If
                Next
            End If
        End Sub

        Protected Sub m_btnOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_btnOptions.Click
            If Exporter IsNot Nothing Then
                ' note: it is responsibility of the exporter to save options if the user
                ' pressed OK and drop them if she pressed Cancel.
                Exporter.ShowOptionsDialog()
            End If
        End Sub

        Protected Sub m_cmbAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cmbAction.SelectedIndexChanged
            Dim ai As ActionItem = m_cmbAction.SelectedItem
            If ai Is Nothing Then
                ai = ActionItem.Empty
            End If
            Action = ai.Action
            If ai.Provider IsNot Nothing Then
                If Exporter Is Nothing OrElse ExpProvider IsNot ai.Provider Then
                    Exporter = C1FlexGridPrintable.CreateExporter(ai.Provider)
                Else
                    Exporter = Nothing
                End If
            End If
            UpdateStatus()
        End Sub

        Protected Overridable Sub UpdateStatus()
            Me.m_outputFileName.Enabled = Exporter IsNot Nothing
            Me.m_lblOutputFileName.Enabled = Me.m_outputFileName.Enabled
            Me.m_btnOutputFileName.Enabled = Me.m_outputFileName.Enabled
            Me.m_btnOptions.Enabled = (Exporter IsNot Nothing AndAlso Exporter.ExportProvider.CanShowOptions)
            Dim rh As RowHeightItem = Me.m_cmbRowHeight.SelectedItem
            Dim tomax As Boolean = (rh IsNot Nothing) AndAlso (rh.RowHeight = RowHeightEnum.StretchToMax) 'qq
            'qq bool tomax = (rh != nothing) && (rh.RowHeight == RowHeightEnum.StretchToMax)
            Me.m_numMaxRowHeight.Enabled = tomax
            Me.m_lblMaxRowHeight.Visible = tomax
        End Sub

        Protected Overridable Sub PrintOptionsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ' build _providers
            If Exporter Is Nothing Then
                If ((ActionMask And ActionFlags.Export) <> 0) Then
                    _providers = C1FlexGridPrintable.GetExportProviders(Nothing)
                Else
                    _providers = New Global.C1.C1Preview.Export.ExportProvider() {}
                End If
            Else
                _providers = New Global.C1.C1Preview.Export.ExportProvider() {Exporter.ExportProvider}
            End If

            Me.m_cmbAction.Items.Clear()
            ' for preview
            If ((ActionFlags.Preview And ActionMask) <> 0) Then
                Me.m_cmbAction.Items.Add(New ActionItem(ActionFlags.Preview, Nothing))
            End If
            ' for print
            If ((ActionFlags.Print And ActionMask) <> 0) Then
                Me.m_cmbAction.Items.Add(New ActionItem(ActionFlags.Print, Nothing))
                ' for all exporters
            End If
            Dim provider As Global.C1.C1Preview.Export.ExportProvider
            For Each provider In _providers
                Me.m_cmbAction.Items.Add(New ActionItem(ActionFlags.Export, provider))
            Next
            ' selected item
            Me.m_cmbAction.SelectedIndex = 0

            Me.m_cmbRowHeight.Items.Clear()
            Dim rh As RowHeightItem
            For Each rh In RowHeightItem.RowHeightItems
                Me.m_cmbRowHeight.Items.Add(rh)
                If rh.RowHeight = Me.RowHeight Then
                    Me.m_cmbRowHeight.SelectedItem = rh
                End If
            Next
            If Me.m_cmbRowHeight.SelectedItem Is Nothing Then
                Me.m_cmbRowHeight.SelectedIndex = 0
            End If
            Me.m_cmbHorzPageBreak.Items.Clear()
            Dim pb As PageBreakItem
            For Each pb In PageBreakItem.PageBreakItems
                Me.m_cmbHorzPageBreak.Items.Add(pb)
                If pb.PageBreaks = Me.PageBreaks Then
                    Me.m_cmbHorzPageBreak.SelectedItem = pb
                End If
            Next
            If Me.m_cmbHorzPageBreak.SelectedItem Is Nothing Then
                Me.m_cmbHorzPageBreak.SelectedIndex = 0
            End If
            Me.m_cmbStretchToWidth.Items.Clear()
            Dim fe As FillEmptyItem
            For Each fe In FillEmptyItem.FillEmptyItems
                Me.m_cmbStretchToWidth.Items.Add(fe)
                If fe.FillEmpty = Me.FillEmpty Then
                    Me.m_cmbStretchToWidth.SelectedItem = fe
                End If
            Next
            If Me.m_cmbStretchToWidth.SelectedItem Is Nothing Then
                Me.m_cmbStretchToWidth.SelectedIndex = 0
            End If
            Me.m_cmbWrapText.Items.Clear()
            Dim wt As WrapTextItem
            For Each wt In WrapTextItem.WrapTextItems
                Me.m_cmbWrapText.Items.Add(wt)
                If wt.WrapText = Me.WrapText Then
                    Me.m_cmbWrapText.SelectedItem = wt
                End If
            Next
            If Me.m_cmbWrapText.SelectedItem Is Nothing Then
                Me.m_cmbWrapText.SelectedIndex = 0
            End If
            'if (Exporter != nothing)
            '    me.m_outputFileName.Text = Exporter.OutputFileName
            UpdateStatus()
        End Sub

        Protected Sub PrintOptionsForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
            If DialogResult <> System.Windows.Forms.DialogResult.OK Then
                Return
            End If
            If Not m_outputFileName.Enabled Then
                Return
            End If
            If m_outputFileName.Text.Length = 0 Then
                MessageBox.Show(Me, "Please provide a file name", "Export", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                m_outputFileName.Focus()
                e.Cancel = True
            End If
        End Sub

        Protected Sub m_cmbRowHeight_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cmbRowHeight.SelectedIndexChanged
            Dim rh As RowHeightItem = m_cmbRowHeight.SelectedItem
            If rh IsNot Nothing Then
                RowHeight = rh.RowHeight
            End If
            UpdateStatus()
        End Sub

        Protected Sub m_cmbHorzPageBreak_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cmbHorzPageBreak.SelectedIndexChanged
            If TypeOf m_cmbHorzPageBreak.SelectedItem Is PageBreakItem Then
                PageBreaks = CType(m_cmbHorzPageBreak.SelectedItem, PageBreakItem).PageBreaks
            End If
        End Sub

        Protected Sub m_cmbStretchToWidth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cmbStretchToWidth.SelectedIndexChanged
            If TypeOf m_cmbStretchToWidth.SelectedItem Is FillEmptyItem Then
                FillEmpty = CType(m_cmbStretchToWidth.SelectedItem, FillEmptyItem).FillEmpty
            End If
        End Sub

        Protected Sub m_cmbWrapText_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_cmbWrapText.SelectedIndexChanged
            If TypeOf m_cmbWrapText.SelectedItem Is WrapTextItem Then
                WrapText = CType(m_cmbWrapText.SelectedItem, WrapTextItem).WrapText
            End If
        End Sub
    End Class
End Namespace
