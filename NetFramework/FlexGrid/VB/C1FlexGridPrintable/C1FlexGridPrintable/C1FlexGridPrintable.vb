Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Text
Imports System.Reflection
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Drawing.Printing
Imports System.IO

Imports C1.Win.FlexGrid
Imports C1.C1Preview

Namespace C1.Win.FlexGrid

    ''' <summary>
    ''' Defines a C1FlexGrid that can be printed or inserted in a C1PrintDocument.
    ''' Can be used either by itself, or to print another C1FlexGrid object.
    ''' </summary>
    Public Class C1FlexGridPrintable
        Inherits Global.C1.Win.FlexGrid.C1FlexGrid

        Private Const c_tag_t As String = "\\t"
        Private Const c_tag_p As String = "\\p"
        Private Const c_tag_Pcap As String = "\\P"
        Private Const c_tag_s As String = "\\s"
        Private Const c_tag_Scap As String = "\\S"
        Private Const c_tag_g As String = "\\g"
        Private Const c_tag_Gcap As String = "\\G"

        Private _imgSize As Size
        Private _doc As C1PrintDocument = Nothing
        Private _workTable As RenderTable = Nothing
        Private _zoom As Double = 1.0
        Private _perc As Double = 0
        Private _curRow As Integer = 0
        Private _terminated As Boolean = False
        Private _printInfo As PrintInfo = New PrintInfo()
        Private _pageHeaderHeight As Integer = 30
        Private _pageFooterHeight As Integer = 30
        Private _rowh As Integer = 0
        Private _maxHeight As Integer = 0
        Private _maxWidth As Integer = 0
        Private _maxWidthPix As Integer = 0
        Private _dpiScreen As Integer = 0  'dots per inch for screen resolution
        Private _dpiPrinter As Integer = 0  'dots per inch for printer resolution
        Private _measureGraphics As Graphics = Nothing ' graphics for measuring string size
        Private _progressDlg As C1PrintProgress = Nothing
        Private _previewWrapper As PreviewWrapper = Nothing
        Private _sf As StringFormat = Nothing
        Private _graphics As Graphics
        Private _img As Bitmap = New Bitmap(1, 1)

        ''' <summary>
        ''' Creates a new instance of C1FlexGridPrintable class.
        ''' </summary>
        Public Sub New()
        End Sub

        ''' <summary>
        ''' Creates a new instance of C1FlexGridPrintable class to print/preview/export
        ''' another C1FlexGrid object.
        ''' </summary>
        ''' <param name="flex">The object to print/preview/export.</param>
        Public Sub New(ByVal flex As Global.C1.Win.FlexGrid.C1FlexGrid)
            Debug.Assert(flex IsNot Nothing)
            Me.DataSource = flex
            Me.AllowMerging = flex.AllowMerging
            Me.BackColor = flex.BackColor
            Me.BackgroundImage = flex.BackgroundImage
            Me.ForeColor = flex.ForeColor
        End Sub

        ''' <summary>
        ''' Gets the current row which is displayed in the progress dialog.
        ''' </summary>
        <Browsable(False)>
        Public Property CurRow() As Integer
            Get
                Return _curRow
            End Get
            Set(ByVal value As Integer)
                _curRow = value
                If _progressDlg IsNot Nothing Then
                    _progressDlg.TxtPrinting = String.Format("Processing row {0} of {1}", CurRow, Me.Rows.Count)
                    Application.DoEvents()
                    If _progressDlg.CancelClicked Then
                        _terminated = True
                        OnEndPrinting()
                    End If
                End If
                OnAfterRowPrinted()
            End Set
        End Property

        ''' <summary>
        ''' Gets the PrintInfo object.
        ''' </summary>
        Public Property PrintInfo() As PrintInfo
            Get
                Return _printInfo
            End Get
            Set(ByVal value As PrintInfo)
                _printInfo = value
            End Set
        End Property

        ''' <summary>
        ''' Shows the print preview.
        ''' </summary>
        Public Sub PrintPreview()
            If Not HaveSomethingToPrint Then
                Return
            End If
            Dim exporter As Global.C1.C1Preview.Export.Exporter = Nothing
            Dim action As ActionFlags = ActionFlags.Preview
            Dim fn As String = String.Empty
            If _printInfo.ShowOptionsDialog Then
                action = DoShowOptionsDialog(exporter, ActionFlags.Preview, fn)
            End If

            If action = ActionFlags.Preview Then
                LoadPreviewWrapper()
                Dim doc As Global.C1.C1Preview.C1PrintDocument = RenderSourceTree()
                _previewWrapper.Preview(doc)
                DisposeProgressDlg()
            End If
        End Sub

        ''' <summary>
        ''' Prints the grid imports the default printer settings.
        ''' </summary>
        Public Sub Print()
            Dim ps As PrinterSettings = Nothing
            Print(ps)
        End Sub

        ''' <summary>
        ''' Prints the grid imports the specified printer settings.
        ''' </summary>
        ''' <param name="printerSettings">The printer settings to use.</param>
        Public Sub Print(ByVal printerSettings As PrinterSettings)
            If Not HaveSomethingToPrint Then
                Return
            End If
            Dim action As ActionFlags = ActionFlags.Print
            Dim exporter As Global.C1.C1Preview.Export.Exporter = Nothing
            Dim fn As String = String.Empty
            If (_printInfo.ShowOptionsDialog) Then
                action = DoShowOptionsDialog(exporter, ActionFlags.Print, fn)
            End If
            If action <> ActionFlags.Print Then
                Return
            End If
            LoadPreviewWrapper()
            Dim doc As Global.C1.C1Preview.C1PrintDocument = RenderSourceTree()
            _previewWrapper.Print(doc)
            DisposeProgressDlg()
        End Sub

        ''' <summary>
        ''' Outputs the grid as a C1PrintDocument into the specified stream.
        ''' </summary>
        ''' <param name="stream">The output stream.</param>
        Public Sub Print(ByVal stream As System.IO.Stream)
            If HaveSomethingToPrint Then
                LoadPreviewWrapper()
                Dim oldshowprogress As Boolean = _printInfo.ShowProgressForm
                _printInfo.ShowProgressForm = False
                Dim doc As Global.C1.C1Preview.C1PrintDocument = RenderSourceTree()
                doc.Save(stream)
                ' stream.Position = 0
                _printInfo.ShowProgressForm = oldshowprogress
            End If
        End Sub

        ''' <summary>
        ''' Outputs the grid as a C1PrintDocument into a memory stream.
        ''' </summary>
        ''' <returns>The memory stream.</returns>
        Public Function PrintToStream() As System.IO.Stream
            Dim mystream As System.IO.Stream = New System.IO.MemoryStream()
            Print(mystream)
            Return mystream
        End Function

        ''' <summary>
        ''' Shows the export dialog and exports the grid to the file specified by the user.
        ''' </summary>
        Public Sub ExportTo()
            Dim exporter As Global.C1.C1Preview.Export.Exporter = Nothing
            Dim outputfn As String = String.Empty
            Dim action As ActionFlags = DoShowOptionsDialog(exporter, ActionFlags.Export, outputfn)
            If action <> ActionFlags.None AndAlso exporter IsNot Nothing Then
                _export(exporter, outputfn)
            End If
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file. The format is determined by the file extension.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        Public Sub ExportTo(ByVal outputFileName As String)
            Dim fileExt As String = System.IO.Path.GetExtension(outputFileName)
            If String.IsNullOrEmpty(fileExt) Then
                Return
            End If
            fileExt = fileExt.ToLower()
            ' nuke the '.' as provider.DefaultExtension doesn't contain one
            If fileExt(0) = "." Then
                fileExt = fileExt.Remove(0, 1)
            End If
            ' if the passed in extension is .html, make it .htm
            If fileExt = "html" Then
                fileExt = "htm"
            End If
            _exportTo(fileExt, outputFileName)
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file as HTML.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        Public Sub ExportToHtml(ByVal outputFileName As String)
            _exportTo("htm", outputFileName)
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file as PDF.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        Public Sub ExportToPdf(ByVal outputFileName As String)

            _exportTo("pdf", outputFileName)
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file as RTF.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        Public Sub ExportToRtf(ByVal outputFileName As String)
            _exportTo("rtf", outputFileName)
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file as Excel.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        Public Sub ExportToExcel(ByVal outputFileName As String)
            _exportTo("xls", outputFileName)
        End Sub

        ''' <summary>
        ''' Exports the grid to the specified file as Excel.
        ''' </summary>
        ''' <param name="outputFileName">The output file name.</param>
        ''' <param name="onePagePerSheet">Determines whether each page is exported as a single work sheet.</param>
        Public Sub ExportToExcel(ByVal outputFileName As String, ByVal onePagePerSheet As Boolean)
            _exportTo("xls", outputFileName, New ExportParameters(onePagePerSheet))
        End Sub

        ''' <summary>
        ''' Implements IC1Printable interface so the grid
        ''' can be inserted in a C1PrintDocument via a
        ''' RenderC1Printable object.
        ''' </summary>
        ''' <returns></returns>
        Public Function C1PrintableGetTree() As Stream
            Return PrintToStream()
        End Function

        ''' <summary>
        ''' Calls dialog for defining export firmat and file name.
        ''' </summary>
        ''' <param name="parent">Parent form owned Me dialog form.</param>
        ''' <param name="availableProviders">List of available export providers.</param>
        ''' <param name="name">File name to export to.</param>
        ''' <param name="ep">Export format.</param>
        ''' <returns></returns>
        Friend Shared Function SelectExportFile(
        ByVal parent As Form, ByVal availableProviders As Global.C1.C1Preview.Export.ExportProvider(),
            ByRef name As String, ByRef ep As Global.C1.C1Preview.Export.ExportProvider) As Boolean
            ' build a filter
            Dim sfd As SaveFileDialog = New SaveFileDialog()
            sfd.FileName = name
            sfd.Title = "Export To..."
            sfd.Filter = PreviewWrapper.ExportFilter(availableProviders)

            Dim i As Integer

            For i = 0 To availableProviders.Length - 1
                If availableProviders(i) Is ep Then
                    sfd.FilterIndex = i + 1
                    Exit For
                End If
            Next
            If sfd.ShowDialog(parent) <> DialogResult.OK Then
                Return False
            End If

            ep = availableProviders(sfd.FilterIndex - 1)
            name = sfd.FileName
            Return True
        End Function

        ''' <summary>
        ''' Changes text in progress dialog window.
        ''' </summary>
        ''' <param name="text">New text.</param>
        Friend Sub SetProgressText(ByVal text As String)
            If _progressDlg IsNot Nothing Then
                _progressDlg.TxtPrinting = text
                Application.DoEvents()
                If (String.IsNullOrEmpty(text)) Then
                    _progressDlg.Hide()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Returns a list of export providers corresponding given file extensions.
        ''' </summary>
        ''' <param name="formatExt">A list of format extensions.</param>
        ''' <returns>A list of export providers.</returns>
        Friend Shared Function GetExportProviders(ByVal formatExt As String) As Global.C1.C1Preview.Export.ExportProvider()
            If String.IsNullOrEmpty(formatExt) Then
                Return PreviewWrapper.GetExportProviders()
            Else
                Return PreviewWrapper.GetExportProviders()
            End If
        End Function

        ''' <summary>
        ''' Returns a new exporter for given export provider.
        ''' </summary>
        ''' <param name="exportProvider">Export provider.</param>
        ''' <param name="exportParameters">Custom parameters for Excel exporter</param>
        ''' <returns></returns>
        Friend Shared Function CreateExporter(ByVal exportProvider As Global.C1.C1Preview.Export.ExportProvider,
        ByVal exportParameters As ExportParameters) As Global.C1.C1Preview.Export.Exporter

            Dim result As Global.C1.C1Preview.Export.Exporter = exportProvider.NewExporter()
            Dim exporterType As System.Type = result.GetType()
            If exporterType.Name = "XlsExporter" Then
                ' turn off OnePagePerSheet option
                Dim onePagePerSheetProperty As PropertyInfo = exporterType.GetProperty("OnePagePerSheet")
                If (onePagePerSheetProperty IsNot Nothing) AndAlso
                    onePagePerSheetProperty.PropertyType Is Type.GetType("System.Boolean") AndAlso
                    onePagePerSheetProperty.CanWrite Then
                    If exportParameters Is Nothing Then
                        onePagePerSheetProperty.SetValue(result, False, New Object())
                    Else
                        onePagePerSheetProperty.SetValue(result, exportParameters.OnePagePerSheet, New Object())
                    End If
                End If
            End If
            Return result
        End Function

        ''' <summary>
        ''' Returns a new exporter for the specified export provider.
        ''' </summary>
        ''' <param name="exportProvider">The export provider.</param>
        ''' <returns>A new instance of the exporter of the specified type.</returns>
        Friend Shared Function CreateExporter(ByVal exportProvider As Global.C1.C1Preview.Export.ExportProvider) _
        As Global.C1.C1Preview.Export.Exporter
            Return CreateExporter(exportProvider, Nothing)
        End Function

        ''' <summary>
        ''' Closes the progress dialog if it is shown.
        ''' </summary>
        Friend Sub DisposeProgressDlg()
            If _progressDlg IsNot Nothing Then
                _progressDlg.Close()
                _progressDlg.Dispose()
                _progressDlg = Nothing
            End If
        End Sub

        ''' <summary>
        ''' Shows dialog for selecting print options
        ''' </summary>
        ''' <param name="exporter">Selected exporter.</param>
        ''' <param name="actionMask">Action to perform.</param>
        ''' <param name="outputfn">Output file name.</param>
        ''' <returns>Selected action to perform.</returns>
        Private Function DoShowOptionsDialog(ByRef exporter As Global.C1.C1Preview.Export.Exporter,
        ByVal actionMask As ActionFlags, ByRef outputfn As String) As ActionFlags

            ' Options form can be changed (e.g. localized) by developer
            Dim frmOpt As PrintOptionsForm = New PrintOptionsForm()
            frmOpt.Exporter = exporter
            frmOpt.OutputFileName = outputfn
            frmOpt.Action = ActionFlags.Preview Or ActionFlags.Print '.None
            frmOpt.ActionMask = actionMask
            frmOpt.RowHeight = _printInfo.VarRowHeight
            frmOpt.PageBreaks = _printInfo.PageBreak
            frmOpt.FillEmpty = _printInfo.FillAreaWidth
            frmOpt.WrapText = _printInfo.WrapText
            frmOpt.m_chkRepeatRows.Checked = _printInfo.RepeatFixedRows
            frmOpt.m_chkRepeatCols.Checked = _printInfo.RepeatFixedCols
            frmOpt.m_chkUseGridColors.Checked = _printInfo.UseGridColors
            frmOpt.m_chkHiddenRows.Checked = _printInfo.ShowHiddenRows
            frmOpt.m_chkHiddenCols.Checked = _printInfo.ShowHiddenCols
            frmOpt.m_chkShowProgress.Checked = _printInfo.ShowProgressForm
            frmOpt.m_cmbHorzPageBreak.SelectedIndex = CType(_printInfo.PageBreak, Integer)
            frmOpt.m_cmbStretchToWidth.SelectedIndex = CType(_printInfo.FillAreaWidth, Integer)
            frmOpt.m_cmbWrapText.SelectedIndex = CType(_printInfo.WrapText, Integer)
            frmOpt.m_txtFooter.Text = _printInfo.PageFooter
            frmOpt.m_txtHeader.Text = _printInfo.PageHeader
            frmOpt.m_numFooterHeight.Value = _printInfo.PageFooterHeight
            frmOpt.m_numHeaderHeight.Value = _printInfo.PageHeaderHeight
            frmOpt.m_numMaxRowHeight.Value = _printInfo.MaxRowHeight
            Dim res As DialogResult = DialogResult.Cancel
            Try
                res = frmOpt.ShowDialog()
            Catch ex As Exception
                res = DialogResult.Abort
            End Try
            If res <> DialogResult.OK Then
                frmOpt.Dispose()
                Return ActionFlags.None
            End If

            System.Diagnostics.Debug.Assert((frmOpt.Action And actionMask) <> 0)
            exporter = frmOpt.Exporter
            outputfn = frmOpt.OutputFileName
            _printInfo.RepeatFixedRows = frmOpt.m_chkRepeatRows.Checked
            _printInfo.RepeatFixedCols = frmOpt.m_chkRepeatCols.Checked
            _printInfo.UseGridColors = frmOpt.m_chkUseGridColors.Checked
            _printInfo.ShowProgressForm = frmOpt.m_chkShowProgress.Checked
            _printInfo.ShowHiddenRows = frmOpt.m_chkHiddenRows.Checked
            _printInfo.ShowHiddenCols = frmOpt.m_chkHiddenCols.Checked
            _printInfo.PageFooter = frmOpt.m_txtFooter.Text
            _printInfo.PageHeader = frmOpt.m_txtHeader.Text
            _printInfo.PageFooterHeight = CType(frmOpt.m_numFooterHeight.Value, Integer)
            _printInfo.PageHeaderHeight = CType(frmOpt.m_numHeaderHeight.Value, Integer)
            _printInfo.MaxRowHeight = CType(frmOpt.m_numMaxRowHeight.Value, Integer)
            _printInfo.WrapText = frmOpt.WrapText
            _printInfo.FillAreaWidth = frmOpt.FillEmpty
            _printInfo.PageBreak = frmOpt.PageBreaks
            _printInfo.VarRowHeight = frmOpt.RowHeight
            Dim Action As ActionFlags = frmOpt.Action
            frmOpt.Dispose()
            Return Action
        End Function

        ''' <summary>
        ''' Creates PreviewWrapper instance if needed.
        ''' </summary>
        Private Sub LoadPreviewWrapper()
            If _previewWrapper Is Nothing Then
                _previewWrapper = New PreviewWrapper(Me)
            End If
        End Sub

        Private Sub OnParentFormActivate(ByVal sender As Object, ByVal e As EventArgs)
            If _progressDlg IsNot Nothing Then
                _progressDlg.Activate()
            End If
        End Sub

        ''' <summary>
        ''' Returns true if the grid has at least one row and one column.
        ''' </summary>
        Private ReadOnly Property HaveSomethingToPrint() As Boolean
            Get
                Return Me.Cols.Count <> 0 AndAlso Me.Rows.Count <> 0
            End Get
        End Property

        ''' <summary>
        ''' Creates a document with the grid, exports it to the specified format.
        ''' </summary>
        ''' <param name="formatExt">Format to export to.</param>
        ''' <param name="outputFileName">Output file name.</param>
        ''' <param name="exportParameters">Parameters.</param>
        Private Sub _exportTo(ByVal formatExt As String, ByVal outputFileName As String, ByVal exportParameters As ExportParameters)
            If Not HaveSomethingToPrint Then
                Return
            End If
            LoadPreviewWrapper()
            Dim providers As Global.C1.C1Preview.Export.ExportProvider() = PreviewWrapper.GetExportProviders(formatExt)
            If providers Is Nothing OrElse providers.Length <> 1 Then
                Throw New Exception("Could not create an export provider")
            End If

            Dim ep As Global.C1.C1Preview.Export.ExportProvider = providers(0)

            ' if we are not going to show options (which allow to select a file name)
            ' and no file name has been specified, we must show a file save dialog
            Dim showFileDlg As Boolean = False
            If Not _printInfo.ShowOptionsDialog Then
                If String.IsNullOrEmpty(outputFileName) OrElse String.IsNullOrEmpty(formatExt) Then
                    showFileDlg = True
                End If
            End If
            If showFileDlg Then
                Dim f As Form = Me.ParentForm
                If f IsNot Nothing AndAlso Not SelectExportFile(f, providers, outputFileName, ep) Then
                    Return
                End If
            End If
            Dim exporter As Global.C1.C1Preview.Export.Exporter = CreateExporter(ep, exportParameters)
            Dim outputfn As String = outputFileName
            If _printInfo.ShowOptionsDialog Then
                If DoShowOptionsDialog(exporter, ActionFlags.Export, outputfn) <> ActionFlags.Export Then
                    Return
                End If
            End If
            _export(exporter, outputfn)
        End Sub

        Private Sub _exportTo(ByVal formatExt As String, ByVal outputFileName As String)
            _exportTo(formatExt, outputFileName, Nothing)
        End Sub

        Private Sub _export(ByVal exporter As Global.C1.C1Preview.Export.Exporter, ByVal filename As String)
            LoadPreviewWrapper()
            Dim doc As Global.C1.C1Preview.C1PrintDocument = RenderSourceTree()
            _previewWrapper.Export(doc, exporter, filename)
            DisposeProgressDlg()
        End Sub

        ''' <summary>
        ''' Creates an instance of C1PrintDocument class representing the grid.
        ''' </summary>
        ''' <returns>The created document.</returns>
        Private Function RenderSourceTree() As Global.C1.C1Preview.C1PrintDocument
            Dim c1doc As Global.C1.C1Preview.C1PrintDocument = Nothing
            Dim gridForm As Form = Nothing
            Try
                ' show progress dialog if required
                If _printInfo.ShowProgressForm Then

                    _progressDlg = New C1PrintProgress()
                    ' so we can change the title
                    If (_printInfo.ProgressCaption.Length > 0) Then
                        _progressDlg.TxtTitle = _printInfo.ProgressCaption
                    End If
                    _progressDlg.Show()
                    Application.DoEvents()
                    gridForm = Me.ParentForm
                    If gridForm IsNot Nothing Then
                        ' imitate modal dialog
                        AddHandler gridForm.Activated, New EventHandler(AddressOf OnParentFormActivate)
                    End If
                End If
                ' prepare the source tree
                c1doc = Me.PrintTreeBuild(_progressDlg)
                ' render it
                If _progressDlg IsNot Nothing Then
                    Dim cb As Button = _progressDlg.CancelButton
                    If cb IsNot Nothing Then
                        cb.Enabled = False ' we cannot cancel rendering yet
                    End If
                End If
            Catch ex As Exception
                Return Nothing
            Finally
                If _progressDlg IsNot Nothing Then
                    If gridForm IsNot Nothing Then
                        RemoveHandler gridForm.Activated, New EventHandler(AddressOf OnParentFormActivate)
                    End If
                End If
            End Try
            Return c1doc
        End Function

        Private ReadOnly Property ParentForm() As Form
            Get
                Dim f As Form = Me.FindForm()
                If f Is Nothing AndAlso TypeOf Me.DataSource Is C1FlexGridBase Then
                    f = CType(Me.DataSource, C1FlexGridBase).FindForm()
                End If
                If f Is Nothing AndAlso Form.ActiveForm IsNot Nothing Then
                    f = Form.ActiveForm
                End If
                Return f
            End Get
        End Property

        ''' <summary>
        ''' The main method to prepare print document with grid.
        ''' </summary>
        ''' <param name="progressDlg">The instance of progress dialog form.</param>
        ''' <returns>Prepared document.</returns>
        Private Function PrintTreeBuild(ByVal progressDlg As C1PrintProgress) As Global.C1.C1Preview.C1PrintDocument
            Me.OnStartPrinting()

            Initialize()
            _progressDlg = progressDlg

            If _doc Is Nothing Then
                _doc = New Global.C1.C1Preview.C1PrintDocument()
            Else
                _workTable = Nothing
                _doc.Clear()
            End If
            _doc.DefaultUnit = UnitTypeEnum.Document  ' 1/300 inch
            If _printInfo.PageSettings IsNot Nothing Then
                _doc.PageLayout.PageSettings = New C1PageSettings(_printInfo.PageSettings)
            End If

            Dim workArea As RenderTable = NewTable()

            ' Calculates the zoom factor according to the page size.
            Me.GetZoom()

            ' Render the page header and footer
            Me.RenderHeader()
            Me.RenderFooter()

            Me.CreateTableCols()
            Me.CreateTableRows()
            Me.CreateTableCells()

            '' row/col groups must be declared after rows/cols have been actually added,
            '' hence moved here from NewTable:
#If skip_dima Then '' http://helpcentral.componentone.com/CS/forums/t/73525.aspx
            If _printInfo.RepeatFixedRows AndAlso Me.Rows.Fixed > 0 Then
                _workTable.RowGroups(0, Me.Rows.Fixed).PageHeader = True
            End If
            If _printInfo.RepeatFixedCols AndAlso Me.Cols.Fixed > 0 Then
                _workTable.ColGroups(0, Me.Cols.Fixed).PageHeader = True
            End If
#Else
            '' Count fixed rows/cols. Maybe there are invisible !
            Dim intFixed As Integer = 0
            If _printInfo.RepeatFixedRows Then
                '' If hidden rows are to be shown, our count is the fixed count.
                If _printInfo.ShowHiddenRows Then
                    '' Does the current grid have fixed rows ?
                    intFixed = Me.Rows.Fixed
                Else
                    '' Do not copy hidden rows: count all visible fixed rows.
                    Dim intRow As Integer
                    For intRow = 0 To Me.Rows.Fixed - 1
                        If Me.Rows(intRow).Visible Then
                            intFixed += 1
                        End If
                    Next intRow
                End If
                '' Set Fixed to Table (if found)
                If intFixed > 0 Then
                    _workTable.RowGroups(0, intFixed).PageHeader = True
                End If
            End If
            '' Same for columns:
            If _printInfo.RepeatFixedCols Then
                '' If hidden cols are to be shown, our count is the fixed count.
                If _printInfo.ShowHiddenCols Then
                    '' Does the current grid have fixed cols ?
                    intFixed = Me.Cols.Fixed
                Else
                    '' Do not copy hidden cols: count all visible fixed cols.
                    Dim intCol As Integer
                    For intCol = 0 To Me.Cols.Fixed - 1
                        If Me.Cols(intCol).Visible Then
                            intFixed += 1
                        End If
                    Next intCol
                End If
                '' Set Fixed to Table (if found)
                If intFixed > 0 Then
                    _workTable.ColGroups(0, intFixed).PageHeader = True
                End If
            End If
#End If

            _doc.Body.Children.Add(_workTable)

            Me.OnEndPrinting()
            Return _doc
        End Function

        ''' <summary>
        ''' Initializes private variables.
        ''' </summary>
        Private Sub Initialize()
            _terminated = False
            ' String format for measuring
            _sf = New StringFormat()
            _sf.Alignment = StringAlignment.Near
            _sf.LineAlignment = StringAlignment.Near
            If _printInfo.WrapText = WrapTextEnum.NoWrap Then
                _sf.FormatFlags = _sf.FormatFlags Or StringFormatFlags.NoWrap
            End If

            ' Height of page header and footer in document units
            _pageHeaderHeight = InchToDoc(_printInfo.PageHeaderHeight)
            _pageFooterHeight = InchToDoc(_printInfo.PageFooterHeight)

            ' Graphics for measuring
            If _measureGraphics Is Nothing Then
                _measureGraphics = Graphics.FromHwnd(IntPtr.Zero)
            End If

            ' The value of screen and printer resolution
            _dpiPrinter = _printInfo.PageSettings.PrinterResolution.Y
            _dpiScreen = _measureGraphics.DpiX

            ' Calculate available paper size.
            Try
                'width in 3 hundreds of inch
                Dim w As Integer = InchToDoc(_printInfo.PageSettings.PaperSize.Width)
                'height in 3 hundreds of inch
                Dim h As Integer = InchToDoc(_printInfo.PageSettings.PaperSize.Height)
                If _printInfo.PageSettings.Landscape Then
                    Dim swap As Integer = w
                    w = h
                    h = swap
                End If
                w -= InchToDoc(_printInfo.PageSettings.Margins.Left + _printInfo.PageSettings.Margins.Right)
                h -= InchToDoc(_printInfo.PageSettings.Margins.Top + _printInfo.PageSettings.Margins.Bottom)
                _maxWidth = w
                _maxHeight = h
            Catch ex As Exception
                Dim ret As PaperSize = GetCurrentLocaleDefaultPaperSize()
                'width in 3 hundreds of inch
                _maxWidth = InchToDoc(ret.Width - _printInfo.PageSettings.Margins.Left - _printInfo.PageSettings.Margins.Right)
                'height in 3 hundreds of inch
                _maxHeight = InchToDoc(ret.Height - _printInfo.PageSettings.Margins.Top - _printInfo.PageSettings.Margins.Bottom)
            End Try

            ' calculate max available width of grid column (column can't be greater when page width!)
            Dim borderw As Integer = CType( _
                Math.Round(Utils.ConvertUnits( _
                LineDef.Default.Width.Value, LineDef.Default.Width.Units, UnitTypeEnum.Document, 0, 0)) * 2, Integer)
            _maxWidthPix = DocToPx(_maxWidth - borderw)

            ' get glyphs for expanded and collapsed nodes
            Dim imgCollapsed As Image = Me.Glyphs(GlyphEnum.Collapsed)
            Dim imgExpanded As Image = Me.Glyphs(GlyphEnum.Expanded)

            ' button size:
            _imgSize.Width = Math.Max(imgCollapsed.Width, imgExpanded.Width)
            _imgSize.Height = Math.Max(imgCollapsed.Height, imgExpanded.Height)

            ' max height of detail rows
            Select Case _printInfo.VarRowHeight
                Case RowHeightEnum.LikeGrid
                    _rowh = -1
                Case RowHeightEnum.StretchToMax
                    _rowh = InchToDoc(_printInfo.MaxRowHeight)
                Case RowHeightEnum.StretchToFit
                    _rowh = 0
            End Select
        End Sub

        ''' <summary>
        ''' Creates a RenderTable for printing and sets its properties.
        ''' </summary>
        ''' <returns></returns>
        Private Function NewTable() As RenderTable
            _workTable = New RenderTable(_doc)
            _workTable.Height = Unit.Auto

            Select Case _printInfo.PageBreak
                Case PageBreaksEnum.FitIntoArea
                    _workTable.Width = New Unit("100%parent")
                    '' _workTable.CanSplitHorz = False
                    _workTable.SplitHorzBehavior = SplitBehaviorEnum.SplitNewPage
                Case Else
                    _workTable.Width = Unit.Auto
                    '' _workTable.CanSplitHorz = True
                    _workTable.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded
                    Select Case _printInfo.FillAreaWidth
                        Case FillEmptyEnum.ExtendAll
                            _workTable.StretchColumns = StretchTableEnum.AllVectors
                        Case FillEmptyEnum.ExtendLastCol
                            _workTable.StretchColumns = StretchTableEnum.LastVectorOnPage
                        Case FillEmptyEnum.None
                    End Select
            End Select
            Select Case _printInfo.WrapText
                Case WrapTextEnum.NoWrap
                    _workTable.Style.WordWrap = False
                Case WrapTextEnum.Wrap
                    _workTable.Style.WordWrap = True
                Case WrapTextEnum.LikeCell
                    'assigned for individual column
            End Select

            ' table styles
            _workTable.Style.GridLines.All = LineDef.Default
            If Me.Styles.Normal.Border.Style = BorderStyleEnum.None Then
                _workTable.Style.GridLines.All = LineDef.Empty
            End If
            _workTable.CellStyle.Padding.All = "5doc"
            Dim cstyle As Global.C1.Win.FlexGrid.CellStyle = Me.Styles.Normal
            If cstyle.BackColor.IsEmpty OrElse cstyle.BackColor.Equals(Color.Transparent) Then
                If Not IsPaperColor(Me.BackColor) Then
                    cstyle.BackColor = Me.BackColor
                End If
            End If
            ApplyStyle(_workTable.CellStyle, cstyle, True, False)
            If Me.BackgroundImage IsNot Nothing AndAlso cstyle.BackgroundImage Is Nothing Then
                cstyle.BackgroundImage = Me.BackgroundImage
            End If
            ApplyStyle(_workTable.Style, cstyle, True, False)
            Return _workTable
        End Function

        ''' <summary>
        ''' Creates page header row.
        ''' </summary>
        Private Sub RenderHeader()

            If _printInfo.IsOwnerDrawPageHeader Then
                Dim odp As C1OwnerDrawPrint = New C1OwnerDrawPrint(_doc)
                odp.SetHeightInch(CType(_pageHeaderHeight, Single) / 100)
                odp.StartDrawing()
                Dim e As OwnerDrawPageEventArgs = New OwnerDrawPageEventArgs(odp)
                Me.OnOwnerDrawPageHeader(e)
                odp.EndDrawing()
                _doc.PageLayout.PageHeader = odp.GetRootObject()
                Return
            End If

            If _printInfo.PageHeader.Length > 0 Then
                Dim rt As RenderArea = New RenderArea()
                rt.Width = New Unit("100%parent")
                rt.Height = New Unit(_pageHeaderHeight, UnitTypeEnum.Document)
                If _printInfo.PageHeaderStyle IsNot Nothing Then
                    ApplyStyle(rt.Style, _printInfo.PageHeaderStyle, True, False)
                Else
                    ApplyStyle(rt.Style, Me.Styles.Normal, True, False)
                End If

                ' draw left/center/right parts of the string
                Dim strParts As String() = SplitLine(_printInfo.PageHeader)
                If strParts.Length > 0 AndAlso strParts(0).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(0))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Left
                    rt.Children.Add(mytext1)
                End If
                If strParts.Length > 1 AndAlso strParts(1).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(1))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Center
                    rt.Children.Add(mytext1)
                End If
                If strParts.Length > 2 AndAlso strParts(2).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(2))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Right
                    rt.Children.Add(mytext1)
                End If
                _doc.PageLayout.PageHeader = rt
            End If
        End Sub

        ''' <summary>
        ''' Creates page footer row.
        ''' </summary>
        Private Sub RenderFooter()
            If _printInfo.IsOwnerDrawPageFooter Then
                Dim odp As C1OwnerDrawPrint = New C1OwnerDrawPrint(_doc)
                odp.SetHeightInch(CType(_pageFooterHeight, Single) / 100)
                odp.StartDrawing()
                Dim e As OwnerDrawPageEventArgs = New OwnerDrawPageEventArgs(odp)
                Me.OnOwnerDrawPageFooter(e)
                odp.EndDrawing()
                _doc.PageLayout.PageFooter = odp.GetRootObject()
                Return
            End If

            If _printInfo.PageFooter.Length > 0 Then
                Dim rt As RenderArea = New RenderArea()
                rt.Width = New Unit("100%parent")
                rt.Height = New Unit(_pageFooterHeight, UnitTypeEnum.Document)
                If _printInfo.PageFooterStyle IsNot Nothing Then
                    ApplyStyle(rt.Style, _printInfo.PageHeaderStyle, True, False)
                Else
                    ApplyStyle(rt.Style, Me.Styles.Normal, True, False)
                End If

                ' draw left/center/right parts of the string
                Dim strParts As String() = SplitLine(_printInfo.PageFooter)
                If strParts.Length > 0 AndAlso strParts(0).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(0))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Left
                    rt.Children.Add(mytext1)
                End If
                If strParts.Length > 1 AndAlso strParts(1).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(1))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Center
                    rt.Children.Add(mytext1)
                End If
                If strParts.Length > 2 AndAlso strParts(2).Length > 0 Then
                    Dim mytext1 As RenderText = CreatePageRenderText(strParts(2))
                    mytext1.Style.TextAlignHorz = AlignHorzEnum.Right
                    rt.Children.Add(mytext1)
                End If
                _doc.PageLayout.PageFooter = rt
            End If
        End Sub

        Private ReadOnly Property ExtendLast() As Boolean
            Get
                If _printInfo.FillAreaWidth = FillEmptyEnum.ExtendLastCol Then
                    Return True
                End If
                Return Me.ExtendLastCol
            End Get
        End Property

        ''' <summary>
        ''' Defines whether given color is the default for paper backcolor.
        ''' </summary>
        ''' <param name="clr">Tested color.</param>
        ''' <returns>True if the color is the defaul, false otherwise.</returns>
        Private Function IsPaperColor(ByVal clr As Color) As Boolean
            Return clr.Equals(SystemColors.Window) OrElse _
                clr.Equals(Color.White) OrElse clr.IsEmpty OrElse clr.Equals(Color.Transparent)
        End Function

        ''' <summary>
        ''' Applies grid style to print style.
        ''' </summary>
        ''' <param name="pstyle">Print style.</param>
        ''' <param name="cstyle">Grid style.</param>
        ''' <param name="cell">Is it style for cells?</param>
        ''' <param name="compareWithParent">Create child style, comparing with parent or not</param>
        Private Sub ApplyStyle(ByVal pstyle As Style, ByVal cstyle As Global.C1.Win.FlexGrid.CellStyle, ByVal cell As Boolean, ByVal compareWithParent As Boolean)
            If pstyle Is Nothing OrElse cstyle Is Nothing Then
                Return
            End If

            If Me._printInfo.UseGridColors Then
                If Not compareWithParent OrElse _workTable.CellStyle.TextColor <> cstyle.ForeColor Then
                    If Not cstyle.ForeColor.IsEmpty AndAlso Not cstyle.ForeColor.Equals(Color.Transparent) Then
                        pstyle.TextColor = cstyle.ForeColor
                    End If
                End If
                If Not compareWithParent OrElse _workTable.CellStyle.BackColor <> cstyle.BackColor Then
                    If Not IsPaperColor(cstyle.BackColor) Then
                        pstyle.BackColor = cstyle.BackColor
                    End If
                End If
                If Not compareWithParent OrElse _workTable.Style.BackgroundImage IsNot cstyle.BackgroundImage Then
                    pstyle.BackgroundImage = cstyle.BackgroundImage
                    pstyle.BackgroundImageAlign.TileHorz = True
                    pstyle.BackgroundImageAlign.TileVert = True
                End If
            End If
            'use the parent font if we can
            Dim f As Font = GetFont(cstyle.Font)
            If Not compareWithParent OrElse CheckFont(f, _workTable.CellStyle) Then
                pstyle.Font = f
            End If

            Select Case cstyle.TextDirection
                Case TextDirectionEnum.Down
                    pstyle.TextAngle = 90
                Case TextDirectionEnum.Up
                    pstyle.TextAngle = 270
            End Select

            Dim align As ImageAlign = CreateImageAlign(cstyle.ImageAlign)
            If Not compareWithParent OrElse Not align.Equals(_workTable.CellStyle.ImageAlign) Then
                pstyle.ImageAlign = align
            End If

            Select Case cstyle.TextAlign
                Case TextAlignEnum.CenterBottom
                    pstyle.TextAlignHorz = AlignHorzEnum.Center
                    pstyle.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.CenterCenter
                    pstyle.TextAlignHorz = AlignHorzEnum.Center
                    pstyle.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.CenterTop
                    pstyle.TextAlignHorz = AlignHorzEnum.Center
                    pstyle.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.GeneralBottom
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.GeneralCenter
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.GeneralTop
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.LeftBottom
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.LeftCenter
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.LeftTop
                    pstyle.TextAlignHorz = AlignHorzEnum.Left
                    pstyle.TextAlignVert = AlignVertEnum.Top
                Case TextAlignEnum.RightBottom
                    pstyle.TextAlignHorz = AlignHorzEnum.Right
                    pstyle.TextAlignVert = AlignVertEnum.Bottom
                Case TextAlignEnum.RightCenter
                    pstyle.TextAlignHorz = AlignHorzEnum.Right
                    pstyle.TextAlignVert = AlignVertEnum.Center
                Case TextAlignEnum.RightTop
                    pstyle.TextAlignHorz = AlignHorzEnum.Right
                    pstyle.TextAlignVert = AlignVertEnum.Top
            End Select

            If _printInfo.WrapText = WrapTextEnum.LikeCell Then
                pstyle.WordWrap = cstyle.WordWrap
            End If
        End Sub

        ''' <summary>
        ''' Creates print Image align from given grid image align.
        ''' </summary>
        ''' <param name="align">Grid style image align.</param>
        ''' <returns></returns>
        Private Function CreateImageAlign(ByVal align As ImageAlignEnum) As ImageAlign
            Dim ia As ImageAlign = ImageAlign.Default
            Select Case align
                Case ImageAlignEnum.CenterCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.CenterTop
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.CenterBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Center
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.LeftBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.LeftCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.LeftTop
                    ia.AlignHorz = ImageAlignHorzEnum.Left
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.RightBottom
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Bottom
                Case ImageAlignEnum.RightCenter
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Center
                Case ImageAlignEnum.RightTop
                    ia.AlignHorz = ImageAlignHorzEnum.Right
                    ia.AlignVert = ImageAlignVertEnum.Top
                Case ImageAlignEnum.Scale
                    ia.KeepAspectRatio = True
                Case ImageAlignEnum.Stretch
                    ia.StretchHorz = True
                    ia.StretchVert = True
                Case ImageAlignEnum.Tile
                    ia.TileHorz = True
                    ia.TileVert = True
            End Select

            Return ia
        End Function

        ''' <summary>
        ''' Creates RenderTable cells for all grid rows and columns.
        ''' </summary>
        Private Sub CreateTableCells()
            Dim r As Integer = 0
            Dim row As Row
            For Each row In Me.Rows
                If Not _printInfo.ShowHiddenRows AndAlso Not row.Visible Then
                    Continue For
                End If
                Dim c As Integer = 0
                Dim col As Column
                For Each col In Me.Cols
                    If Not _printInfo.ShowHiddenCols AndAlso Not col.Visible Then
                        Continue For
                    End If
                    CreateTableCell(r, c, row.Index, col.Index)
                    c += 1
                Next
                r += 1
                Me.CurRow = r
            Next
        End Sub

        ''' <summary>
        ''' Creates node image for tree node with level offset.
        ''' </summary>
        ''' <param name="ra">Parent RenderArea.</param>
        ''' <param name="node">Grid node.</param>
        ''' <param name="row">Row number.</param>
        Private Sub CreateNode(ByVal ra As RenderArea, ByVal node As Node, ByVal row As Integer)
            Dim level As Integer
            If node IsNot Nothing Then
                level = node.Level
            Else
                level = -1
            End If
            If IsFlagSet(TreeStyleFlags.Symbols) Then
                Dim rc As Rectangle = New Rectangle(0, 0, 1000, node.Row.HeightDisplay)
                Dim rcBtn As Rectangle = GetSymbolRect(rc, level)
                Dim imgAlign As ImageAlign = ImageAlign.Default
                Dim imgBtn As Image = GetButtonImage(row)
                If imgBtn IsNot Nothing Then
                    Dim ri As RenderImage = New RenderImage(ra.Document, imgBtn)
                    ri.Y = "parent.height/2 - self.height/2"
                    ri.X = New Unit(rcBtn.X, UnitTypeEnum.Pixel)
                    ri.Width = New Unit(rcBtn.Width, UnitTypeEnum.Pixel)
                    ra.Children.Add(ri)
                End If
            End If
        End Sub

        ''' <summary>
        ''' Sets the image as the background image of the render area, and apply the correct alignment.
        ''' </summary>
        ''' <param name="ra">Parent area.</param>
        ''' <param name="img">Background image.</param>
        ''' <param name="ai">Image align.</param>
        Private Sub CreateCellImage(ByVal ra As RenderArea, ByVal img As Image, ByVal ai As ImageAlignEnum)
            If ai = ImageAlignEnum.Hide Then
                Return
            End If

            ra.Style.BackgroundImage = img

            If ai = ImageAlignEnum.Stretch Then
                ra.Style.BackgroundImageAlign.StretchHorz = True
                ra.Style.BackgroundImageAlign.StretchVert = True
            Else
                ra.Style.BackgroundImageAlign.StretchHorz = False
                ra.Style.BackgroundImageAlign.StretchVert = False
            End If
            If ai = ImageAlignEnum.Tile Then
                ra.Style.BackgroundImageAlign.TileHorz = True
                ra.Style.BackgroundImageAlign.TileVert = True
            Else
                ra.Style.BackgroundImageAlign.TileHorz = False
                ra.Style.BackgroundImageAlign.TileVert = False
            End If
            If ai = ImageAlignEnum.CenterBottom OrElse ai = ImageAlignEnum.CenterCenter OrElse ai = ImageAlignEnum.CenterTop Then
                ra.Style.BackgroundImageAlign.AlignHorz = ImageAlignHorzEnum.Center
            End If
            If ai = ImageAlignEnum.LeftBottom OrElse ai = ImageAlignEnum.LeftCenter OrElse ai = ImageAlignEnum.LeftTop Then
                ra.Style.BackgroundImageAlign.AlignHorz = ImageAlignHorzEnum.Left
            End If
            If ai = ImageAlignEnum.RightBottom OrElse ai = ImageAlignEnum.RightCenter OrElse ai = ImageAlignEnum.RightTop Then
                ra.Style.BackgroundImageAlign.AlignHorz = ImageAlignHorzEnum.Right
            End If
            If ai = ImageAlignEnum.CenterBottom OrElse ai = ImageAlignEnum.LeftBottom OrElse ai = ImageAlignEnum.RightBottom Then
                ra.Style.BackgroundImageAlign.AlignVert = ImageAlignVertEnum.Bottom
            End If
            If ai = ImageAlignEnum.CenterCenter OrElse ai = ImageAlignEnum.LeftCenter OrElse ai = ImageAlignEnum.RightCenter Then
                ra.Style.BackgroundImageAlign.AlignVert = ImageAlignVertEnum.Center
            End If
            If ai = ImageAlignEnum.CenterTop OrElse ai = ImageAlignEnum.LeftTop OrElse ai = ImageAlignEnum.RightTop Then
                ra.Style.BackgroundImageAlign.AlignVert = ImageAlignVertEnum.Top
            End If
        End Sub

        Private Sub CreateCellImage(ByVal ra As RenderArea, ByVal img As Image, ByVal style As CellStyle)
            Me.CreateCellImage(ra, img, style.ImageAlign)
        End Sub

        ''' <summary>
        ''' Checks whether a cell can merge with another cell.
        ''' </summary>
        ''' <param name="row">Row number.</param>
        ''' <param name="col">Column number.</param>
        ''' <returns></returns>
        Private Function MergeCell(ByVal row As Integer, ByVal col As Integer) As Boolean
            ' special cases
            Select Case Me.AllowMerging
                Case AllowMergingEnum.None
                    Return False
                Case AllowMergingEnum.Spill
                    Return True
                Case AllowMergingEnum.Nodes
                    Return Me.Rows(row).IsNode
                Case AllowMergingEnum.Custom
                    Return True
            End Select

            ' default, defer to row/col settings
            Return Me.Rows(row).AllowMerging OrElse Me.Cols(col).AllowMerging
        End Function

        ''' <summary>
        ''' Creates a simple table cell.
        ''' </summary>
        ''' <param name="r">Print table row number.</param>
        ''' <param name="c">Print table column number.</param>
        ''' <param name="row">Grid row number.</param>
        ''' <param name="col">Grid column number.</param>
        ''' <returns></returns>
        Private Function CreateTableCellBase(ByVal r As Integer, ByVal c As Integer, ByVal row As Integer, ByVal col As Integer) As TableCell
            ' get content
            Dim img As Image = Nothing
            Dim chk As CheckEnum = CheckEnum.None
            Dim str As String = Me.GetDataDisplay(row, col, img, chk)
            Dim chkImage As Image = GetCheckImage(chk)
            If chkImage IsNot Nothing Then
                img = chkImage
                If Me.IsCellCheckBox(row, col) Then
                    str = Nothing
                End If
            End If

            ' get style
            Dim displayStyle As CellStyle = Me.GetCellStyleDisplay(row, col)
            Dim baseStyle As CellStyle = Me.GetCellStyle(row, col)
            Dim ra As RenderArea = New RenderArea()
            ra.Stacking = StackingRulesEnum.BlockLeftToRight

            ' get cell rectangle in view coordinates (scrolled)
            Dim rc As Rectangle = Me.GetCellRectDisplay(row, col)
            If Me.DrawMode = DrawModeEnum.OwnerDraw Then
                Dim s As CellStyle = Me.GetCellStyleDisplay(row, col)
                Dim e As OwnerDrawCellEventArgs = New OwnerDrawCellEventArgs(Me, OwnerDrawGraphics, row, col, s, rc, str, img)
                Me.OnOwnerDrawCell(e)
                If Not e.Handled Then
                    str = e.Text
                    img = e.Image
                    If e.Style IsNot Nothing Then
                        baseStyle = e.Style
                    End If
                End If
            End If

            Me.RenderCell(ra, row, col, displayStyle, baseStyle, rc, str, img, chk)

            Dim result As TableCell = _workTable.Cells(r, c)
            result.CellStyle.AmbientParent = _workTable.Rows(r).CellStyle
            ra.Style.AmbientParent = result.CellStyle
            result.RenderObject = ra

            Return result
        End Function


        ''' <summary>
        ''' Creates a simple table cell or a cell with merging.
        ''' </summary>
        ''' <param name="r">Print table row number.</param>
        ''' <param name="c">Print table column number.</param>
        ''' <param name="row">Grid row number.</param>
        ''' <param name="col">Grid column number.</param>
        ''' <returns></returns>
        Private Function CreateTableCell(ByVal r As Integer, ByVal c As Integer, ByVal row As Integer, ByVal col As Integer) As TableCell
            If Not MergeCell(row, col) Then
                Return CreateTableCellBase(r, c, row, col)
            End If

            Dim rg As CellRange = Me.GetMergedRange(row, col, False)

            ' ignore invisible cells
            While rg.r1 < rg.r2 AndAlso Not Me.Rows(rg.r1).Visible AndAlso Not _printInfo.ShowHiddenRows
                rg.r1 += 1
            End While

            While rg.c1 < rg.c2 AndAlso Not Me.Cols(rg.c1).Visible AndAlso Not _printInfo.ShowHiddenRows
                rg.c1 += 1
            End While

            ' use base implementation for single cells
            If rg.IsSingleCell Then
                Return CreateTableCellBase(r, c, row, col)
            End If
            ' skip Me cell if it has been handled over
            If row > rg.r1 Then
                Return Nothing
            End If
            If (col > rg.c1) Then
                Return Nothing
            End If

            Dim tc As TableCell = CreateTableCellBase(r, c, row, col)
            tc.SpanCols = Math.Abs(rg.c2 - rg.c1) + 1
            tc.SpanRows = Math.Abs(rg.r2 - rg.r1) + 1
            tc.VertSplitBehavior = CellSplitBehaviorEnum.Copy

            Return tc
        End Function

        ''' <summary>
        ''' Applies styles to table cell.
        ''' </summary>
        ''' <param name="ra">Parent area.</param>
        ''' <param name="row">Grid row number.</param>
        ''' <param name="col">Grid column number.</param>
        ''' <param name="displayStyle">Grid cell ctyle.</param>
        ''' <param name="baseStyle">Ownerdraw grid cell style.</param>
        ''' <param name="rc">Rectangle for cell display.</param>
        ''' <param name="str">Cell text.</param>
        ''' <param name="img">Cell image</param>
        ''' <param name="chk">Check image state.</param>
        Private Sub RenderCell(ByVal ra As RenderArea, ByVal row As Integer, ByVal col As Integer, ByVal displayStyle As CellStyle, _
        ByVal baseStyle As CellStyle, ByVal rc As Rectangle, ByVal str As String, ByVal img As Image, ByVal chk As CheckEnum)

            Dim indent As Integer = displayStyle.Margins.Left
            If baseStyle IsNot Nothing Then
                Me.ApplyStyle(ra.Style, baseStyle, True, True)
            End If

            Dim widTree As Integer = TreeWidth(col)
            If widTree > 0 Then
                ' get node object to draw tree
                Dim nd As Node = Me.Rows(row).Node
                If nd IsNot Nothing AndAlso nd.Level >= 0 Then
                    indent += (nd.Level + 1) * Me.Tree.Indent
                    Me.CreateNode(ra, nd, row)
                End If
            End If

            Dim gLeft As Image = Nothing
            Dim gRight As Image = Nothing
            Dim gSort As Image = Nothing
            ' if Me.GetCellGlyph(row, col, rc, byref glyph, byref right)
            If Me.GetCellGlyphs(row, col, rc, gLeft, gRight, gSort) Then
                If Not (gLeft Is Nothing) Then
                    CreateCellImage(ra, gLeft, ImageAlignEnum.LeftCenter)
                End If
                If Not (gRight Is Nothing) Then
                    CreateCellImage(ra, gRight, ImageAlignEnum.RightCenter)
                End If
                If Not (gSort Is Nothing) Then
                    CreateCellImage(ra, gSort, ImageAlignEnum.CenterTop)
                End If
            End If

            Dim d As DisplayEnum = displayStyle.Display
            Select Case d
                Case DisplayEnum.ImageOnly
                    str = Nothing
                Case DisplayEnum.TextOnly
                    img = Nothing
                Case DisplayEnum.None
                    Return
            End Select

            If displayStyle.ImageAlign = ImageAlignEnum.Hide Then
                img = Nothing
            End If

            Dim bHasImage As Boolean = (img IsNot Nothing)
            Dim bHasText As Boolean = Not String.IsNullOrEmpty(str)
            If Not bHasImage AndAlso Not bHasText Then
                Return
            End If

            Dim txt As RenderText = New RenderText()
            txt.Text = str
            txt.Height = "parent.height"
            txt.X = New Unit(Me.PxToDoc(indent), UnitTypeEnum.Document)

            Select Case displayStyle.TextAlign
                Case TextAlignEnum.CenterBottom
                    txt.Style.TextAlignHorz = AlignHorzEnum.Center
                Case TextAlignEnum.CenterCenter
                    txt.Style.TextAlignHorz = AlignHorzEnum.Center
                Case TextAlignEnum.CenterTop
                    txt.Style.TextAlignHorz = AlignHorzEnum.Center
                Case TextAlignEnum.GeneralBottom, TextAlignEnum.GeneralCenter, TextAlignEnum.GeneralTop
                    If IsNumeric(str, displayStyle, baseStyle) Then
                        txt.Style.TextAlignHorz = AlignHorzEnum.Right
                    End If
                Case TextAlignEnum.LeftBottom
                    txt.Style.TextAlignHorz = AlignHorzEnum.Left
                Case TextAlignEnum.LeftCenter
                    txt.Style.TextAlignHorz = AlignHorzEnum.Left
                Case TextAlignEnum.LeftTop
                    txt.Style.TextAlignHorz = AlignHorzEnum.Left
                Case TextAlignEnum.RightBottom
                    txt.Style.TextAlignHorz = AlignHorzEnum.Right
                Case TextAlignEnum.RightCenter
                    txt.Style.TextAlignHorz = AlignHorzEnum.Right
                Case TextAlignEnum.RightTop
                    txt.Style.TextAlignHorz = AlignHorzEnum.Right
            End Select

            If bHasImage Then
                Dim off As Offsets = New Offsets()
                Dim m As Margins = displayStyle.Margins

                If displayStyle.ImageAlign = ImageAlignEnum.LeftBottom OrElse _
                    displayStyle.ImageAlign = ImageAlignEnum.LeftCenter OrElse _
                    displayStyle.ImageAlign = ImageAlignEnum.LeftTop Then
                    off.Left = New Unit(Me.PxToDoc(img.Width + m.Left + 2), UnitTypeEnum.Document)
                End If

                If displayStyle.ImageAlign = ImageAlignEnum.RightBottom OrElse _
                    displayStyle.ImageAlign = ImageAlignEnum.RightCenter OrElse _
                    displayStyle.ImageAlign = ImageAlignEnum.RightTop Then
                    off.Right = New Unit(Me.PxToDoc(img.Width + m.Right + 2), UnitTypeEnum.Document)
                End If

                txt.Style.Padding = off
                txt.Style.BackgroundImage = img
                txt.Style.BackgroundImageAlign = Me.CreateImageAlign(displayStyle.ImageAlign)
            End If
            ra.Children.Add(txt)
        End Sub

        Private ReadOnly Property OwnerDrawGraphics() As Graphics
            Get
                If _graphics Is Nothing Then
                    _graphics = Graphics.FromImage(_img)
                End If
                Return _graphics
            End Get
        End Property

        ''' <summary>
        ''' Creates table columns for all grid columns.
        ''' </summary>
        Private Sub CreateTableCols()
            _workTable.Cols.Count = 0
            Dim count As Integer = 0
            _perc = 0
            Dim col As Column
            For Each col In Me.Cols
                If Not _printInfo.ShowHiddenCols AndAlso Not col.Visible Then
                    Continue For
                End If

                Me.CreateTableCol(count, col.Index)
                count += 1
            Next

            If Me.ExtendLast AndAlso Not _workTable.Width.IsAuto Then
                _workTable.Cols(_workTable.Cols.Count - 1).Width = Unit.Auto
            End If
        End Sub

        ''' <summary>
        ''' Creates one table column for given grid column.
        ''' </summary>
        ''' <param name="c">Table column number.</param>
        ''' <param name="col">Grid column number.</param>
        ''' <returns></returns>
        Private Function CreateTableCol(ByVal c As Integer, ByVal col As Integer) As TableCol
            Dim tc As TableCol = _workTable.Cols(c)
            ApplyStyle(_workTable.Cols(c).CellStyle, Me.Cols(col).Style, False, False)
            Dim flexCol As Global.C1.Win.FlexGrid.Column = Me.Cols(col)
            If _printInfo.PageBreak = PageBreaksEnum.FitIntoArea Then
                Dim w As Double = Math.Round(Me.PxToDoc(GetColWidth(flexCol) / _zoom) * 100.0 / _maxWidth, 2)
                If _perc + w > 99 Then
                    w = Math.Round(100 - _perc, 2)
                End If
                _perc += w
                Dim swidth As String = w.ToString() + "%parent.width"
                swidth = swidth.Replace(",", ".")  'if delimiter is comma 
                tc.Width = swidth
            Else
                tc.Width = New Unit(Me.PxToDoc(GetColWidth(flexCol)), UnitTypeEnum.Document)
            End If
            If (col < Me.Cols.Fixed) Then
                Me.ApplyStyle(tc.CellStyle, flexCol.StyleFixedDisplay, True, True)
            End If
            Return tc
        End Function

        ''' <summary>
        ''' Creates table rows for all grid rows.
        ''' </summary>
        Private Sub CreateTableRows()
            _workTable.Rows.Count = 0
            Dim count As Integer = 0
            Dim row As Row
            For Each row In Me.Rows
                If Not _printInfo.ShowHiddenRows AndAlso Not row.Visible Then
                    Continue For
                End If
                Me.CreateTableRow(count, row.Index)
                count += 1
            Next
        End Sub

        ''' <summary>
        ''' Creates one table row for given grid row.
        ''' </summary>
        ''' <param name="r">Table row number.</param>
        ''' <param name="row">Grid row number.</param>
        ''' <returns></returns>
        Private Function CreateTableRow(ByVal r As Integer, ByVal row As Integer) As TableRow
            Dim tr As TableRow = _workTable.Rows(r)
            Dim flexRow As Global.C1.Win.FlexGrid.Row = Me.Rows(row)
            Dim curstyle As CellStyle = flexRow.StyleDisplay
            If row < Me.Rows.Fixed Then
                curstyle = flexRow.StyleFixedDisplay
            End If

            Dim newh As Integer = PxToDoc(flexRow.HeightDisplay)
            Dim maxh As Integer = CalcRowMaxHeight(row, curstyle)
            If _rowh >= 0 Then
                If newh < maxh Then
                    newh = maxh  'max height of row
                End If
                If _rowh > 0 AndAlso newh > _rowh Then
                    newh = _rowh  'not greater then max height of row
                End If
            End If
            tr.Height = New Unit(newh, UnitTypeEnum.Document)
            Me.ApplyStyle(tr.CellStyle, curstyle, True, True)

            If (row < Rows.Fixed) Then
                Dim col As Integer
                For col = 0 To col < _workTable.Cols.Count - 1
                    ApplyStyle(tr(col).CellStyle, flexRow.StyleFixedDisplay, True, False)
                Next
            End If

            Return tr
        End Function

        ''' <summary>
        ''' Calculates maximum height of grid row with given columns widths.
        ''' </summary>
        ''' <param name="row">Grid row number.</param>
        ''' <param name="curstyle">Current grid cell style.</param>
        ''' <returns>The height in document units.</returns>
        Private Function CalcRowMaxHeight(ByVal row As Integer, ByVal curstyle As CellStyle) As Integer
            Dim maxHeight As Integer = 0
            Dim iCol As Integer = -1
            Dim col As Column
            For Each col In Me.Cols
                iCol += 1
                If Not _printInfo.ShowHiddenCols AndAlso Not col.Visible Then
                    Continue For
                End If

                Dim measurew As Integer = (GetColWidth(col) / _zoom)
                Dim str As String = Me.GetDataDisplay(row, iCol)
                Dim curHeight As Integer = MeasureText(str, curstyle.Font, measurew) + 2
                If curHeight > maxHeight Then
                    maxHeight = curHeight
                End If
            Next
            Return PxToDoc(maxHeight)
        End Function

        ''' <summary>
        ''' Calculates zoom factor for fit all columns at one page.
        ''' </summary>
        Private Sub GetZoom()
            ' calculate scale factor: 
            ' increase the size of the rectangle to make pages fit
            _zoom = 1.0

            ' get row/col count, bail if 0
            Dim cols As Integer = Me.Cols.Count
            Dim rows As Integer = Me.Rows.Count
            If cols = 0 OrElse rows = 0 Then
                Return
            End If

            ' fit to page width: don't spill horizontally 
            If _printInfo.PageBreak = PageBreaksEnum.FitIntoArea Then
                Dim gridwidth As Integer = 0
                Dim col As Column
                For Each col In Me.Cols
                    If Not _printInfo.ShowHiddenCols AndAlso Not col.Visible Then
                        Continue For
                    End If
                    gridwidth += GetColWidth(col)
                Next
                Dim wid As Double = PxToDoc(gridwidth)
                _zoom = wid / _maxWidth
            End If
        End Sub

        Private Function GetCurrentLocaleDefaultPaperSize() As PaperSize
            Dim c1ps As Global.C1.C1Preview.C1PageSettings = Global.C1.C1Preview.C1PageSettings.CreateDefaultPageSettings()
            Return c1ps.ToPageSettings().PaperSize
        End Function

        ''' <summary>
        ''' Measures text height in pixels.
        ''' </summary>
        ''' <param name="s">Measured text.</param>
        ''' <param name="f">Applied font.</param>
        ''' <param name="w">Available width.</param>
        ''' <returns></returns>
        Private Function MeasureText(ByVal s As String, ByVal f As Font, ByVal w As Integer) As Integer
            Dim res As Integer = 0
            Dim sAvail As SizeF = New SizeF(w, 0.0F)  '(DocToPx(w), 0f)
            Dim sNeeded As SizeF = _measureGraphics.MeasureString(s, f, sAvail, _sf)
            res = CType(sNeeded.Height + 2, Integer)  'Padding 1 pix
            Return res
        End Function

        ''' <summary>
        ''' Converts screen pixels to Document units (1/300 of inch)
        ''' </summary>
        ''' <param name="lengthInPixel">Length in screen pixels</param>
        ''' <returns></returns>
        Private Function PxToDoc(ByVal lengthInPixel As Double) As Integer
            Return Math.Round(Utils.ConvertUnits(lengthInPixel, UnitTypeEnum.Pixel, UnitTypeEnum.Document, _dpiScreen, 0))
        End Function

        ''' <summary>
        ''' Converts hundreds of inch to Document units (1/300 of inch)
        ''' </summary>
        ''' <param name="lengthInInch">Length in hundreds of inch</param>
        ''' <returns></returns>
        Private Function InchToDoc(ByVal lengthInInch As Integer) As Integer
            Return CType(Math.Round(Utils.ConvertUnits(lengthInInch, UnitTypeEnum.InHs, UnitTypeEnum.Document, 0, 0)), Integer)
        End Function

        ''' <summary>
        ''' Converts document units to pixels.
        ''' </summary>
        ''' <param name="lenghtInDoc">Length in document units.</param>
        ''' <returns></returns>
        Private Function DocToPx(ByVal lenghtInDoc As Integer) As Integer
            Return CType(Math.Round(Utils.ConvertUnits(lenghtInDoc, UnitTypeEnum.Document, UnitTypeEnum.Pixel, 0, _dpiScreen)), Integer)
        End Function

        ''' <summary>
        ''' Returns given font in points.
        ''' </summary>
        ''' <param name="f"></param>
        ''' <returns></returns>
        Private Function GetFont(ByVal f As Font) As Font
            If f IsNot Nothing Then
                If f.Unit = GraphicsUnit.Point Then
                    Return f
                End If
                Return New Font(f.FontFamily.Name, f.SizeInPoints, GraphicsUnit.Point)
            End If
            Return Nothing
        End Function

        ''' <summary>
        ''' Compares font with parent style font.
        ''' </summary>
        ''' <param name="f">Tested font.</param>
        ''' <param name="parentStyle">Parent preview style</param>
        ''' <returns></returns>
        Private Function CheckFont(ByVal f As Font, ByVal parentStyle As Global.C1.C1Preview.Style) As Boolean
            If f Is Nothing Then
                Return False
            End If
            Dim df As Font = parentStyle.Font
            If df IsNot Nothing Then
                Return Not df.Equals(f)
            End If
            Return True
        End Function

        ''' <summary>
        ''' Returns column width in pixels not greater then page width.
        ''' </summary>
        ''' <param name="col">Tested column.</param>
        ''' <returns></returns>
        Private Function GetColWidth(ByVal col As Column) As Integer
            If col.WidthDisplay <= _maxWidthPix Then
                Return col.WidthDisplay
            Else
                Return _maxWidthPix
            End If
        End Function

        ''' <summary>
        ''' Creates a RenderText object for printing page header-footer.
        ''' </summary>
        ''' <param name="txt">Printing text.</param>
        ''' <returns></returns>
        Private Function CreatePageRenderText(ByVal txt As String) As RenderText
            Dim mytext1 As RenderText = New RenderText()
            mytext1.Text = ReplacePageText(txt)
            mytext1.Width = New Unit("100%parent")
            mytext1.Height = New Unit("100%parent")
            mytext1.Style.TextAlignVert = AlignVertEnum.Center
            mytext1.X = 0
            mytext1.Y = 0
            Return mytext1
        End Function

        ''' <summary>
        ''' Replaces tags for page number with preview style tags.
        ''' </summary>
        ''' <param name="text">Tested text.</param>
        ''' <returns></returns>
        Friend Shared Function ReplacePageText(ByVal text As String) As String
            If text.Length > 0 Then
                text = text.Replace(c_tag_p, "[PageNo]")
                text = text.Replace(c_tag_Pcap, "[PageCount]")
                text = text.Replace(c_tag_s, "[PageX]")
                text = text.Replace(c_tag_Scap, "[PageXCount]")
                text = text.Replace(c_tag_g, "[PageY]")
                text = text.Replace(c_tag_Gcap, "[PageYCount]")
            End If
            Return text
        End Function

        ''' <summary>
        ''' Separates text to parts imports delimiter.
        ''' </summary>
        ''' <param name="s">Separated text.</param>
        ''' <returns></returns>
        Private Shared Function SplitLine(ByVal s As String) As String()
            Dim headerText As String() = New String(2) {String.Empty, String.Empty, String.Empty}
            Dim i As Integer = s.IndexOf(c_tag_t)
            If i >= 0 Then
                If i > 0 Then
                    headerText(0) = s.Substring(0, i)
                    s = s.Substring(i + c_tag_t.Length)
                    i = s.IndexOf(c_tag_t)
                    If i >= 0 Then
                        If i > 0 Then
                            headerText(1) = s.Substring(0, i)
                        End If
                        headerText(2) = s.Substring(i + c_tag_t.Length)
                    End If
                Else
                    headerText(1) = s
                End If
            Else
                headerText(0) = s
            End If
            Return headerText
        End Function

        Private Function IsFlagSet(ByVal f As TreeStyleFlags) As Boolean
            Return (Me.Tree.Style And f) <> 0
        End Function

        ''' <summary>
        ''' Returns rectangle to draw collapse/expand symbol with indent.
        ''' </summary>
        ''' <param name="rc">Base rectangle.</param>
        ''' <param name="level">Tree level.</param>
        ''' <returns></returns>
        Private Function GetSymbolRect(ByVal rc As Rectangle, ByVal level As Integer) As Rectangle
            Dim rcSymbol As Rectangle = New Rectangle(0, 0, 0, 0)
            ' get node level, no button if < 0
            If level < 0 Then
                Return rcSymbol
            End If

            Dim indent As Integer = Me.Tree.Indent
            rcSymbol.X = rc.X + level * indent + (indent - _imgSize.Width) / 2
            rcSymbol.Y = rc.Y + (rc.Height - _imgSize.Height) / 2
            rcSymbol.Width = _imgSize.Width
            rcSymbol.Height = _imgSize.Height

            rcSymbol.Intersect(rc)
            Return rcSymbol
        End Function

        ''' <summary>
        ''' Gets service image for row.
        ''' </summary>
        ''' <param name="row">Grid row number.</param>
        ''' <returns></returns>
        Private Function GetButtonImage(ByVal row As Integer) As Image
            ' check Me row
            Dim MeRow As Row = Me.Rows(row)
            If Not MeRow.IsNode Then
                Return Nothing
            End If

            ' check next row
            Dim nextRow As Row = Nothing
            Dim above As Boolean = (Me.SubtotalPosition = SubtotalPositionEnum.AboveData)
            If above AndAlso row < Me.Rows.Count - 1 Then
                nextRow = Me.Rows(row + 1)
            End If
            If Not above AndAlso row > Me.Rows.Fixed Then
                nextRow = Me.Rows(row - 1)
            End If

            ' no data/child nodes? no image
            If nextRow Is Nothing Then
                Return Nothing
            End If
            If nextRow.IsNode AndAlso nextRow.Node.Level <= MeRow.Node.Level Then
                Return Nothing
            End If

            ' return collapse/expanded image
            Dim collapsed As Boolean = Me.Rows(row).Node.Collapsed
            If collapsed Then
                Return Me.Glyphs(GlyphEnum.Collapsed)
            Else
                Return Me.Glyphs(GlyphEnum.Expanded)
            End If
        End Function

        ''' <summary>
        ''' Gets the width of grid tree.
        ''' </summary>
        ''' <param name="col"></param>
        ''' <returns></returns>
        Private Function TreeWidth(ByVal col As Integer) As Integer
            If Me.Tree.Column <> col Then
                Return 0
            End If
            If Me.Tree.Style = TreeStyleFlags.None Then
                Return 0
            End If
            Dim maxLevel As Integer = Me.Tree.MaximumLevel
            If maxLevel < 0 Then
                Return 0
            End If
            Return Me.Tree.Indent * (maxLevel + 1)
        End Function

        ''' <summary>
        ''' Returns check image depended of given flag.
        ''' </summary>
        ''' <param name="chk"></param>
        ''' <returns></returns>
        Private Function GetCheckImage(ByVal chk As CheckEnum) As Image
            Select Case chk
                Case CheckEnum.Checked
                Case CheckEnum.TSChecked
                    Return Me.Glyphs(GlyphEnum.Checked)
                Case CheckEnum.Unchecked
                Case CheckEnum.TSUnchecked
                    Return Me.Glyphs(GlyphEnum.Unchecked)
                Case CheckEnum.TSGrayed
                    Return Me.Glyphs(GlyphEnum.Grayed)
            End Select
            Return Nothing
        End Function

        Private Function IsNumeric(ByVal s As String, ByVal displayStyle As CellStyle, ByVal baseStyle As CellStyle) As Boolean
            '' The logic here should be the same as in the grid:
            If String.IsNullOrEmpty(s) Then
                Return False
            End If
            If IsTypeNumeric(baseStyle) OrElse IsTypeNumeric(displayStyle) Then
                Return True
            End If
            If IsTypeNonNumeric(baseStyle) OrElse IsTypeNonNumeric(displayStyle) Then
                Return False
            End If

            If (s.EndsWith("%")) Then
                s = s.Substring(0, s.Length - 1)
            End If
            ' use TryParse to check whether Me is a number
            Dim value As Double
            Return Double.TryParse(s, System.Globalization.NumberStyles.Any, Nothing, value)
        End Function

        Private Function IsTypeNumeric(ByVal cellStyle As CellStyle) As Boolean
            If cellStyle Is Nothing OrElse cellStyle.DataType Is Nothing Then
                Return False
            End If
            Dim t As Type = cellStyle.DataType
            Return _
                t Is System.Type.GetType("System.Double") OrElse t Is System.Type.GetType("System.Single") OrElse _
                t Is System.Type.GetType("System.Int16") OrElse t Is System.Type.GetType("System.UInt16") OrElse _
                t Is System.Type.GetType("System.Int32") OrElse t Is System.Type.GetType("System.UInt32") OrElse _
                t Is System.Type.GetType("System.Int64") OrElse t Is System.Type.GetType("System.UInt64") OrElse _
                t Is System.Type.GetType("System.SByte") OrElse t Is System.Type.GetType("System.Byte") OrElse _
                t Is System.Type.GetType("System.Decimal")
        End Function

        Private Function IsTypeNonNumeric(ByVal cellStyle As CellStyle) As Boolean
            If cellStyle Is Nothing OrElse cellStyle.DataType Is Nothing Then
                Return False
            End If
            Dim t As Type = cellStyle.DataType
            Return t Is System.Type.GetType("System.DateTime") OrElse t Is System.Type.GetType("System.String")
        End Function

        ''' <summary>
        ''' Occurs prior to printing.
        ''' </summary>
        Public Event StartPrinting As CancelEventHandler
        ''' <summary>
        ''' Raises the StartPrint event.
        ''' </summary>
        Protected Sub OnStartPrinting()
            Dim e As CancelEventArgs = New CancelEventArgs()
            RaiseEvent StartPrinting(Me, e)
            If e.Cancel Then
                _terminated = True
                OnEndPrinting()
            End If
        End Sub

        ''' <summary>
        ''' Occurs after a row has been printed.
        ''' </summary>
        Public Event AfterRowPrinted As CancelEventHandler
        ''' <summary>
        ''' Raises the AfterRowPrinted event.
        ''' </summary>
        Protected Sub OnAfterRowPrinted()
            Dim e As CancelEventArgs = New CancelEventArgs()
            RaiseEvent AfterRowPrinted(Me, e)
            If e.Cancel Then
                _terminated = True
                OnEndPrinting()
            End If
        End Sub

        ''' <summary>
        ''' Occurs after the grid has been printed.
        ''' </summary>
        Public Event EndPrinting As CancelEventHandler
        ''' <summary>
        ''' Raises the EndPrint event.
        ''' </summary>
        Protected Sub OnEndPrinting()
            Dim e As CancelEventArgs = New CancelEventArgs()
            e.Cancel = _terminated
            RaiseEvent EndPrinting(Me, e)
            If (_terminated) Then
                Throw New PrintCancelException()
            End If
        End Sub

        ''' <summary>
        ''' Occurs before the page header is to be printed.
        ''' </summary>
        Public Event OwnerDrawPageHeader As OwnerDrawPageEventHandler
        Protected Sub OnOwnerDrawPageHeader(ByVal e As OwnerDrawPageEventArgs)
            RaiseEvent OwnerDrawPageHeader(Me, e)
        End Sub

        ''' <summary>
        ''' Occurs before the page footer is to be printed.
        ''' </summary>
        Public Event OwnerDrawPageFooter As OwnerDrawPageEventHandler
        Protected Sub OnOwnerDrawPageFooter(ByVal e As OwnerDrawPageEventArgs)
            RaiseEvent OwnerDrawPageFooter(Me, e)
        End Sub

    End Class

    ''' <summary>
    ''' The exception that is thrown when a print is cancelled.
    ''' </summary>
    Public Class PrintCancelException
        Inherits Exception
        ''' <summary>
        ''' Creates a new instance of the PrintCancelException class.
        ''' </summary>
        Public Sub New()
            MyBase.New("Cancelled by user")
        End Sub
    End Class


    ''' <summary>
    ''' Specifies how empty space is printed.
    ''' </summary>
    Public Enum FillEmptyEnum
        ''' <summary>
        ''' All columns are extended proportionally.
        ''' </summary>
        ExtendAll
        ''' <summary>
        ''' Empty space on the right.
        ''' </summary>
        None
        ''' <summary>
        ''' Last column is extended to fill the empty space.
        ''' </summary>
        ExtendLastCol
    End Enum

    ''' <summary>
    ''' Specifies when page breaks are applied.
    ''' </summary>
    Public Enum PageBreaksEnum
        ''' <summary>
        ''' Fit all columns in one page.
        ''' </summary>
        FitIntoArea
        ''' <summary>
        ''' Breaks on any column that doesn't fit.
        ''' </summary>
        OnColumn
    End Enum

    ''' <summary>
    ''' Specifies how cell text is wrapped.
    ''' </summary>
    Public Enum WrapTextEnum
        ''' <summary>
        ''' Always wrap text in a cell.
        ''' </summary>
        Wrap
        ''' <summary>
        ''' Never wrap.
        ''' </summary>
        NoWrap
        ''' <summary>
        ''' Wrap or not depending on the value of the grid column's WrapText property.
        ''' </summary>
        LikeCell
    End Enum

    ''' <summary>
    ''' Specifies the height of printed rows.
    ''' </summary>
    Public Enum RowHeightEnum
        ''' <summary>
        ''' Stretch the row height to fit all the data.
        ''' </summary>
        StretchToFit
        ''' <summary>
        ''' Use the grid's row height.
        ''' </summary>
        LikeGrid
        ''' <summary>
        ''' Stretch the row height no greater than <see cref="PrintInfo.MaxRowHeight"/>.
        ''' </summary>
        StretchToMax
    End Enum

    ''' <summary>
    ''' Specifies allowable options for printing.
    ''' </summary>
    <Flags()> _
    Public Enum ActionFlags
        ''' <summary>
        ''' No options.
        ''' </summary>
        None = &H0
        ''' <summary>
        ''' Print
        ''' </summary>
        Print = &H1
        ''' <summary>
        ''' Preview
        ''' </summary>
        Preview = &H2
        ''' <summary>
        ''' Export
        ''' </summary>
        Export = &H4
        ''' <summary>
        ''' All
        ''' </summary>
        MaskAll = (-1)
    End Enum

    ''' <summary>
    ''' The object used to specify the characteristics of a grid when it is printed.
    ''' </summary>
    Public Class PrintInfo
        Private _pageHeader As String = String.Empty
        Private _pageFooter As String = String.Empty
        Private _pageHeaderStyle As Global.C1.Win.FlexGrid.CellStyle = Nothing
        Private _pageFooterStyle As Global.C1.Win.FlexGrid.CellStyle = Nothing
        Private _wrapText As WrapTextEnum = WrapTextEnum.Wrap
        Private _useGridColors As Boolean = True
        Private _pageHeaderHeight As Integer = 30
        Private _pageFooterHeight As Integer = 30
        Private _useOwnerDrawPageHeader As Boolean = False
        Private _useOwnerDrawPageFooter As Boolean = False
        Private _pageSettings As PageSettings = Nothing
        Private _showOptionsDialog As Boolean = False
        Private _showProgressForm As Boolean = True
        Private _fillWidth As FillEmptyEnum = FillEmptyEnum.ExtendAll
        Private _pageBreaks As PageBreaksEnum = PageBreaksEnum.FitIntoArea
        Private _progressCaption As String = String.Empty
        Private _repeatFixedCols As Boolean = True
        Private _repeatFixedRows As Boolean = True
        Private _showHiddenRows As Boolean = False
        Private _showHiddenCols As Boolean = False
        Private _varRowHeight As RowHeightEnum = RowHeightEnum.StretchToFit
        Private _maxRowHeight As Integer = 30

        Friend Sub New()
            _pageSettings = New PageSettings()
        End Sub


        ''' <summary>
        ''' Gets or sets the value indicating whether to print hidden rows.
        ''' </summary>
        <DefaultValue(False)> _
        <Description("Gets or sets the value indicating whether to print hidden rows.")> _
        Public Property ShowHiddenRows() As Boolean
            Get
                Return _showHiddenRows
            End Get
            Set(ByVal value As Boolean)
                _showHiddenRows = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether to print hidden columns.
        ''' </summary>
        <Description("Gets or sets the value indicating whether to print hidden columns.")> _
        <DefaultValue(False)> _
        Public Property ShowHiddenCols() As Boolean
            Get
                Return _showHiddenCols
            End Get
            Set(ByVal value As Boolean)
                _showHiddenCols = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether to repeat fixed rows on each page.
        ''' </summary>
        <Description("Gets or sets the value indicating whether to repeat fixed rows on each page.")> _
        <DefaultValue(True)> _
        Public Property RepeatFixedRows() As Boolean
            Get
                Return _repeatFixedRows
            End Get
            Set(ByVal value As Boolean)
                _repeatFixedRows = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether to repeat fixed columns on each page.
        ''' </summary>
        <Description("Gets or sets the value indicating whether to repeat fixed columns on each page.")> _
        <DefaultValue(True)> _
        Public Property RepeatFixedCols() As Boolean
            Get
                Return _repeatFixedCols
            End Get
            Set(ByVal value As Boolean)
                _repeatFixedCols = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether the grid color scheme is used to print the grid.
        ''' </summary>
        <DefaultValue(True)> _
        <Localizable(True)> _
        <Description("Gets or sets the value indicating whether the grid color scheme is used to print the grid.")> _
        Public Property UseGridColors() As Boolean
            Get
                Return Me._useGridColors
            End Get
            Set(ByVal value As Boolean)
                Me._useGridColors = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether word wrap is on for text in the grid cells.
        ''' </summary>
        <DefaultValue(WrapTextEnum.Wrap)> _
        <Description("Gets or sets the value indicating whether word wrap is on for text in the grid cells.")> _
        Public Property WrapText() As WrapTextEnum
            Get
                Return Me._wrapText
            End Get
            Set(ByVal value As WrapTextEnum)
                Me._wrapText = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the mode of stretching the printout to the page width.
        ''' </summary>
        <DefaultValue(FillEmptyEnum.ExtendAll)> _
        <Description("Gets or sets the mode of stretching the printout to the page width.")> _
        Public Property FillAreaWidth() As FillEmptyEnum
            Get
                Return Me._fillWidth
            End Get
            Set(ByVal value As FillEmptyEnum)
                Me._fillWidth = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the horizontal page break mode.
        ''' </summary>
        <DefaultValue(PageBreaksEnum.FitIntoArea)> _
        <Description("Gets or sets the horizontal page break mode.")> _
        Public Property PageBreak() As PageBreaksEnum
            Get
                Return Me._pageBreaks
            End Get
            Set(ByVal value As PageBreaksEnum)
                Me._pageBreaks = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a value indicating whether the page header is owner drawn.
        ''' </summary>
        <DefaultValue(False)> _
        <Localizable(True)> _
        <Description("Gets or sets a value indicating whether the page header is owner drawn.")> _
        Public Property IsOwnerDrawPageHeader() As Boolean
            Get
                Return Me._useOwnerDrawPageHeader
            End Get
            Set(ByVal value As Boolean)
                Me._useOwnerDrawPageHeader = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the header to be printed at the top of each page.
        ''' </summary>
        <DefaultValue("")> _
        <Localizable(True)> _
        <Description("Gets or sets the header to be printed at the top of each page.")> _
        Public Property PageHeader() As String
            Get
                Return Me._pageHeader
            End Get
            Set(ByVal value As String)
                Me._pageHeader = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the style used to render the page header.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        <Description("Gets or sets the style used to render the page header.")> _
        Public Property PageHeaderStyle() As Global.C1.Win.FlexGrid.CellStyle
            Get
                Return Me._pageHeaderStyle
            End Get
            Set(ByVal value As Global.C1.Win.FlexGrid.CellStyle)
                Me._pageHeaderStyle = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the height of the page header, in hundreds of an inch.
        ''' </summary>
        <DefaultValue(30)> _
        <Localizable(True)> _
        <Description("Gets or sets the height of the page header, in hundreds of an inch.")> _
        Public Property PageHeaderHeight() As Integer
            Get
                Return Me._pageHeaderHeight
            End Get
            Set(ByVal value As Integer)
                Me._pageHeaderHeight = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the header to be printed at the bottom of each page.
        ''' </summary>
        <DefaultValue("")> _
        <Localizable(True)> _
        <Description("Gets or sets the header to be printed at the bottom of each page.")> _
        Public Property PageFooter() As String
            Get
                Return Me._pageFooter
            End Get
            Set(ByVal value As String)
                Me._pageFooter = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the style used to render the page footer.
        ''' </summary>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        <Description("Gets or sets the style used to render the page footer.")> _
        Public Property PageFooterStyle() As Global.C1.Win.FlexGrid.CellStyle
            Get
                Return Me._pageFooterStyle
            End Get
            Set(ByVal value As Global.C1.Win.FlexGrid.CellStyle)
                Me._pageFooterStyle = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a value indicating whether the page footer is owner drawn.
        ''' </summary>
        <DefaultValue(False)> _
        <Localizable(True)> _
        <Description("Gets or sets a value indicating whether the page footer is owner drawn.")> _
        Public Property IsOwnerDrawPageFooter() As Boolean
            Get
                Return Me._useOwnerDrawPageFooter
            End Get
            Set(ByVal value As Boolean)
                Me._useOwnerDrawPageFooter = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the height of the page footer, in hundreds of an inch.
        ''' </summary>
        <DefaultValue(30)> _
        <Localizable(True)> _
        <Description("Gets or sets the height of the page footer, in hundreds of an inch.")> _
        Public Property PageFooterHeight() As Integer
            Get
                Return Me._pageFooterHeight
            End Get
            Set(ByVal value As Integer)
                Me._pageFooterHeight = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the maximum row height, in hundredths of an inch.
        ''' </summary>
        <DefaultValue(30)> _
        <Localizable(True)> _
        <Description("Gets or sets the maximum row height, in hundredths of an inch.")> _
        Public Property MaxRowHeight() As Integer
            Get
                Return Me._maxRowHeight
            End Get
            Set(ByVal value As Integer)
                Me._maxRowHeight = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value controlling the heights of rows in the printout.
        ''' </summary>
        <DefaultValue(RowHeightEnum.StretchToFit)> _
        <Description("Gets or sets the value controlling the heights of rows in the printout.")> _
        Public Property VarRowHeight() As RowHeightEnum
            Get
                Return Me._varRowHeight
            End Get
            Set(ByVal value As RowHeightEnum)
                Me._varRowHeight = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether the options dialog is
        ''' displayed when the grid is about to be printed or previewed.
        ''' </summary>
        <DefaultValue(False)> _
        <Localizable(True)> _
        <Description("Gets or sets the value indicating whether the options dialog is displayed when the grid is about to be printed or previewed.")> _
        Public Property ShowOptionsDialog() As Boolean
            Get
                Return Me._showOptionsDialog
            End Get
            Set(ByVal value As Boolean)
                Me._showOptionsDialog = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the value indicating whether the progress form is
        ''' shown while the grid is being prepared for printing.
        ''' </summary>
        <DefaultValue(True)> _
        <Localizable(True)> _
        <Description("Gets or sets the value indicating whether the progress form is shown while the grid is being prepared for printing.")> _
        Public Property ShowProgressForm() As Boolean
            Get
                Return Me._showProgressForm
            End Get
            Set(ByVal value As Boolean)
                Me._showProgressForm = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the page settings to be used for printing.
        ''' </summary>
        <Description("Gets or sets the page settings to be used for printing.")> _
        Public Property PageSettings() As PageSettings
            Get
                Return Me._pageSettings
            End Get
            Set(ByVal value As PageSettings)
                _pageSettings = value
            End Set
        End Property

        Public Function ShouldSerializePageSettings() As Boolean
            Return _pageSettings IsNot Nothing
        End Function

        ''' <summary>
        ''' Gets or sets the caption of the progress form.
        ''' </summary>
        <DefaultValue("")> _
        <Localizable(True)> _
        <Description("Gets or sets the caption of the progress form.")> _
        Public Property ProgressCaption() As String
            Get
                Return Me._progressCaption
            End Get
            Set(ByVal value As String)
                Me._progressCaption = value
            End Set
        End Property
    End Class

    Friend Class ExportParameters
        Private _onePagePerSheet As Boolean

        Public Sub New(ByVal onePagePerSheet As Boolean)
            onePagePerSheet = onePagePerSheet
        End Sub

        Public Property OnePagePerSheet() As Boolean
            Get
                Return _onePagePerSheet
            End Get
            Set(ByVal value As Boolean)
                _onePagePerSheet = value
            End Set
        End Property
    End Class

    ''' <summary>
    ''' The object used to call PrintPreview methods.
    ''' </summary>
    Friend Class PreviewWrapper

        Private Shared _availableProviders As Global.C1.C1Preview.Export.ExportProvider() = Nothing
        Private Shared _exportFilter As String = String.Empty
        Private _info As C1FlexGridPrintable = Nothing

        Public Sub New(ByVal info As C1FlexGridPrintable)
            _info = info
        End Sub

        ''' <summary>
        ''' Shows Preview window with given documen.
        ''' </summary>
        ''' <param name="doc"></param>
        Public Sub Preview(ByVal doc As Global.C1.C1Preview.C1PrintDocument)
            _info.SetProgressText("Rendering document")
            doc.Generate()
            _info.SetProgressText("")

            Dim preview As Global.C1.Win.C1Preview.C1PrintPreviewControl = New Global.C1.Win.C1Preview.C1PrintPreviewControl()
            Dim f As PreviewForm = New PreviewForm(_info)
            preview.Dock = DockStyle.Fill
            preview.Parent = f
            preview.Document = doc
            _info.SetProgressText("")
            ' show the preview dialog
            f.ShowDialog()
            f.Dispose()
        End Sub

        ''' <summary>
        ''' Prints given document.
        ''' </summary>
        ''' <param name="doc"></param>
        Public Sub Print(ByVal doc As Global.C1.C1Preview.C1PrintDocument)
            _info.SetProgressText("Rendering document")
            doc.Generate()
            _info.SetProgressText("")
            Dim manager As Global.C1.C1Preview.C1PrintManager = New Global.C1.C1Preview.C1PrintManager()
            manager.Document = doc
            manager.Print(Nothing)
        End Sub

        ''' <summary>
        ''' Exports given document imports Exporter.
        ''' </summary>
        ''' <param name="doc"></param>
        ''' <param name="exporter"></param>
        ''' <param name="filename"></param>
        Public Sub Export(ByVal doc As Global.C1.C1Preview.C1PrintDocument, _
        ByVal exporter As Global.C1.C1Preview.Export.Exporter, ByVal filename As String)
            _info.SetProgressText("Rendering document")
            doc.Generate()
            _info.SetProgressText("")

            exporter.Document = doc
            exporter.ShowOptions = False
            exporter.Export(filename)
        End Sub

        ''' <summary>
        ''' Returns a string with all export extensions for save dialog.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function ExportFilter() As String
            If _exportFilter = String.Empty Then
                If _availableProviders Is Nothing Then
                    GetExportProviders()
                End If
                Dim i As Integer
                For i = 0 To _availableProviders.Length - 1
                    _exportFilter &= _availableProviders(i).FormatName _
                        & " (*." + _availableProviders(i).DefaultExtension _
                        & ")|*." + _availableProviders(i).DefaultExtension
                    If i < _availableProviders.Length - 1 Then
                        _exportFilter &= "|"
                    End If
                Next
            End If
            Return _exportFilter
        End Function

        ''' <summary>
        ''' Returns a string with all export extensions for save dialog imports given export providers.
        ''' </summary>
        ''' <param name="availableProviders"></param>
        ''' <returns></returns>
        Public Shared Function ExportFilter(ByVal availableProviders As Global.C1.C1Preview.Export.ExportProvider()) As String
            Dim filter As String = String.Empty
            Dim i As Integer
            For i = 0 To availableProviders.Length - 1
                filter &= _availableProviders(i).FormatName _
                    & " (*." + _availableProviders(i).DefaultExtension _
                    & ")|*." + _availableProviders(i).DefaultExtension
                If (i < availableProviders.Length - 1) Then
                    filter &= "|"
                End If
            Next
            Return filter
        End Function

        ''' <summary>
        ''' Returns all available export providers.
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function GetExportProviders() As Global.C1.C1Preview.Export.ExportProvider()
            If _availableProviders Is Nothing Then
                Dim listproviders As Global.C1.C1Preview.Export.ExportProviders = Global.C1.C1Preview.Export.ExportProviders.RegisteredProviders
                If listproviders IsNot Nothing Then
                    _availableProviders = New Global.C1.C1Preview.Export.ExportProvider(listproviders.Count - 1) {}
                    Dim i As Integer
                    For i = 0 To listproviders.Count - 1
                        _availableProviders(i) = listproviders(i)
                    Next
                End If
            End If
            Return _availableProviders
        End Function

        ''' <summary>
        ''' Returns only selected export providers.
        ''' </summary>
        ''' <param name="formatExt"></param>
        ''' <returns></returns>
        Public Shared Function GetExportProviders(ByVal formatExt As String) As Global.C1.C1Preview.Export.ExportProvider()
            If _availableProviders Is Nothing Then
                GetExportProviders()
            End If
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To _availableProviders.Length - 1
                If _availableProviders(i).PreferredOrdinal >= 0 Then
                    Dim provext As String = _availableProviders(i).DefaultExtension
                    If formatExt Is Nothing OrElse provext.ToLower() = formatExt.ToLower() Then
                        j += 1
                    End If
                End If
            Next
            Dim res As Global.C1.C1Preview.Export.ExportProvider() = New Global.C1.C1Preview.Export.ExportProvider(j - 1) {}
            j = 0
            For i = 0 To _availableProviders.Length - 1
                If _availableProviders(i).PreferredOrdinal >= 0 Then
                    Dim provext As String = _availableProviders(i).DefaultExtension
                    If formatExt Is Nothing OrElse provext.ToLower() = formatExt.ToLower() Then
                        res(j) = _availableProviders(i)
                        j += 1
                    End If
                End If
            Next
            Return res
        End Function
    End Class

    '
    ' OwnerDrawPageEventArgs use for the following events:
    '
    '	OwnerDrawPageHeader
    '	OwnerDrawPageFooter
    '
    ''' <summary>
    ''' Raised when custom page headers and footers need to be rendered.
    ''' </summary>
    Public Delegate Sub OwnerDrawPageEventHandler(ByVal sender As Object, ByVal e As OwnerDrawPageEventArgs)
    ''' <summary>
    ''' Provides data for the <see cref="C1FlexGridPrintable.OwnerDrawPageHeader"/>
    ''' and <see cref="C1FlexGridPrintable.OwnerDrawPageHeader"/> events.
    ''' </summary>
    Public Class OwnerDrawPageEventArgs
        Inherits EventArgs

        Private _ownerDrawPrint As C1OwnerDrawPrint

        Friend Sub New(ByVal odp As C1OwnerDrawPrint)
            _ownerDrawPrint = odp
        End Sub

        ''' <summary>
        ''' The <see cref="C1OwnerDrawPrint"/> object used to render the custom header or footer
        ''' </summary>
        Public ReadOnly Property OwnerDrawPrint() As C1OwnerDrawPrint
            Get
                Return _ownerDrawPrint
            End Get
        End Property
    End Class

End Namespace

