
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports System.Reflection
Imports C1.Win.Ribbon
Imports C1.Win.C1Tile
Imports C1.Win.FlexReport

Namespace C1FlexReportExplorer
    Partial Public Class MainForm
        Inherits C1RibbonForm
        ' C1TileControl is used to navigate between reports.
        ' It has two 'levels' of files: 
        ' - top level tiles correspond to report categories, while
        ' - 2nd level tiles correspond to individual reports.
        '
        ' The wiring of tiles and categories/reports:
        ' Correspondence of tiles' properties and ReportInfos.xml elements/attributes:
        ' - 'Top-level' tiles -> Category elements:
        ' -- tile.Name: category.Name
        ' -- tile.Text: category.Text
        ' -- tile.Image: image loaded from category.Image resource
        ' -- tile.Tag: instance of CategoryInfo, with child count.
        ' 
        ' - 'Child tiles' -> Report elements:
        ' -- tile.Text: ReportTitle
        ' -- tile.Tag: parent category.Name
        ' -- tile.Text1: FileName
        ' -- tile.Text2: ReportName
        ' -- tile.Image: image loaded from ImageName resource
        '

        ''' <summary>
        ''' This is used to:
        ''' - keep the count of 'child' tiles (there is no built in notion of parent-child in C1TileControl);
        ''' - recognize that the current tile is a 'top-level' category tile.
        ''' </summary>
        Private Class CategoryInfo
            Public Property ReportCount() As Integer
                Get
                    Return m_ReportCount
                End Get
                Set
                    m_ReportCount = Value
                End Set
            End Property
            Private m_ReportCount As Integer
        End Class

#Region "Private data members"
        Private _frmPreview As PreviewForm = Nothing
        Private _previewTile As Tile = Nothing
        Private Shared s_collapseTag As New Object()
#End Region

#Region "ctor, form load, initialization"
        Public Sub New()
            InitializeComponent()

            ' Add 'top-level' tiles for categories:
            AddTilesForCategories()
            ' Copy the list of category tiles and loop over it, 
            ' as we are going to modify the tile collection (add report tiles):
            Dim categoryTiles = c1tileCntrl.Groups(0).Tiles.ToList()
            ' Add report tiles:

            For Each tile As Tile In categoryTiles
                Dim tempImg As Image = DirectCast(My.Resources.ResourceManager.GetObject("expand"), Image)
                tile.Image1 = tempImg
                tile.Image1.Tag = s_collapseTag
                AddTilesInCategory(tile)
                HideShowTile(tile)
            Next
        End Sub

        Private Sub AddTilesForCategories()
            Try
                Dim xdoc As XDocument = LoadReportInfos()
                Dim categories = xdoc.Descendants("Category").ToList()
                ' Sortinig categories by name makes navigation easier:
                categories.Sort(Function(c1_, c2_) String.Compare(c1_.Attribute("Text").Value, c2_.Attribute("Text").Value))
                For Each category As XElement In categories
                    Dim name As String = category.Attribute("Name").Value
                    ' Skip duplicate categories:
                    If tileGrp.Tiles.Contains(name) Then
                        Continue For
                    End If
                    Dim tile As New Tile()
                    tile.Name = name
                    tile.Text = category.Attribute("Text").Value
                    tile.Image = DirectCast(My.Resources.ResourceManager.GetObject(category.Attribute("Image").Value), Image)
                    If Not tile.Name.Equals("Separator") Then
                        tile.VerticalSize = 5
                        AddHandler tile.Click, AddressOf Me.Tile_Click
                    Else
                        tile.Template = _tileLineTemplate
                    End If
                    Me.tileGrp.Tiles.Add(tile)
                Next
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        End Sub

        Private Sub AddTilesInCategory(categoryTile As Tile)
            Dim categoryName As String = categoryTile.Name
            Dim xdoc As XDocument = LoadReportInfos()
            ' Get the list of matching categories:
            Dim matchingCategories = xdoc.Descendants("Category").Where(Function(c_) String.Compare(c_.Attribute("Name").Value, categoryName, True) = 0)
            ' Select all reports within:
            Dim reportNodes = matchingCategories.SelectMany(Function(c_) c_.Descendants("Report"))
            ' Add CategoryInfo on the category tile now that we have all children:
            Dim catInfo As CategoryInfo = New CategoryInfo()
            catInfo.ReportCount = reportNodes.Count()
            categoryTile.Tag = catInfo
            '
            For Each childReport As XElement In reportNodes
                Dim reportTile As New Tile()
                reportTile.Text = childReport.Element("ReportTitle").Value
                reportTile.Tag = categoryName
                reportTile.VerticalSize = 10
                reportTile.Text1 = childReport.Element("FileName").Value
                reportTile.Text2 = childReport.Element("ReportName").Value
                reportTile.Image = GetReportPreviewImage(categoryName, childReport.Element("ImageName").Value)
                reportTile.Template = _reportDefaultTemplate
                AddHandler reportTile.Click, AddressOf ChldTile_Click
                categoryTile.Group.Tiles.Insert(categoryTile.Index + 1, reportTile)
#If regenerate_screenshots Then
                ' This code can be used to create the screenshots:
                Dim fileName = reportTile.Text1
                Dim reportName = reportTile.Text2
                Dim rptFile As String = Path.Combine("..\..\Reports", categoryName, fileName)
                Try
                    Dim flxRpt = LoadReport(categoryName, fileName, reportName)
                    flxRpt.Render()
                    Dim mf As Metafile = flxRpt.GetPageImage(0)
                    Dim imagePath = Path.Combine("..\..\Reports", categoryName, "Images", Path.GetFileNameWithoutExtension(fileName) & ".emf")
                    C1.Win.C1Document.Utils.WriteMetafileToFile(mf, imagePath)
                    System.Diagnostics.Debug.WriteLine("Screenshot " + imagePath + " written.")
                Catch ex As Exception
					System.Diagnostics.Debug.WriteLine((Convert.ToString("Error writing ") & rptFile) + ": " + ex.Message)
                End Try
#End If
            Next
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)
            Try
                Dim xdoc As XDocument = LoadReportInfos()
                Dim xelem As XElement = xdoc.Descendants("SelectedReport").First()
                Dim selCategory As String = xelem.Element("CategoryName").Value
                Dim selRptName As String = xelem.Element("ReportName").Value
                Dim tileCatSelected As Tile = Me.tileGrp.Tiles.First(Function(t) t.Name.ToLower() = selCategory.ToLower())
                If tileCatSelected IsNot Nothing Then
                    Tile_Click(tileCatSelected, EventArgs.Empty)
                    Dim tileRptSelected As Tile = tileCatSelected.Group.Tiles.First(Function(t) t.Text2.ToLower() = selRptName.ToLower() AndAlso t.Index > tileCatSelected.Index)
                    ChldTile_Click(tileRptSelected, EventArgs.Empty)
                    c1tileCntrl.ScrollToTile(tileRptSelected, True)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Function LoadReportInfos() As XDocument
            Dim thisExe As Assembly = Assembly.GetExecutingAssembly()
            Dim file As Stream = thisExe.GetManifestResourceStream("C1FlexReportExplorer.ReportInfos.xml")
            Return XDocument.Load(file)
        End Function

        Private Function GetReportPreviewImage(category As String, imageName As String) As Image
            Dim thisExe As Assembly = Assembly.GetExecutingAssembly()
            Dim file As Stream = thisExe.GetManifestResourceStream("C1FlexReportExplorer." & imageName)
            If file IsNot Nothing Then
                Return Image.FromStream(file)
            End If
            Return Nothing
        End Function
#End Region

#Region "Event handling"
        Private Sub PbTabShowHide_Click(sender As Object, e As EventArgs)
            dockTabPagePreview.AutoHiding = Not dockTabPagePreview.AutoHiding
            Dim img As Image = pbTabShowHide.Image
            img.RotateFlip(RotateFlipType.Rotate270FlipX)
            pbTabShowHide.Image = img
        End Sub

        ''' <summary>
        ''' Click Event 
        ''' Hide And show child tiles based on tile clicked
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub Tile_Click(sender As Object, e As EventArgs)
            HideShowTile(DirectCast(sender, Tile))
        End Sub

        ''' <summary>
        ''' Click Event
        ''' create Tle fo each report(s) preview in the below the parent tile
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ChldTile_Click(sender As Object, e As EventArgs)
            Dim tile = DirectCast(sender, Tile)
            flxViewer.DocumentSource = LoadReport(TryCast(tile.Tag, String), tile.Text1, tile.Text2)
            HighlightSelectedTile(tile)
        End Sub

        ''' <summary>
        ''' MouseMove Event
        ''' Set location of Preview Form
        ''' </summary>
        Private Sub TileControl_MouseMove(sender As Object, e As MouseEventArgs)
            If dockTabPagePreview.AutoHiding Then
                Return
            End If

            ' Get Tile:
            Dim mouseTile As Tile = c1tileCntrl.GetTileAt(New Point(e.Location.X, e.Location.Y))
            ' Nothing to do if we are already showing the preview for this tile:
            If Object.ReferenceEquals(mouseTile, _previewTile) Then
                Return
            End If

            ' If no tile, or a parent (category) tile, or we are on current tile - hide preview and we're done
            If mouseTile Is Nothing OrElse TypeOf mouseTile.Tag Is CategoryInfo OrElse Object.ReferenceEquals(mouseTile.Template, _reportSelectedTemplate) Then
                If _frmPreview IsNot Nothing Then
                    _frmPreview.Hide()
                    _previewTile = Nothing
                End If
                Return
            End If

            If _frmPreview Is Nothing Then
                _frmPreview = New PreviewForm()
            End If

            ' Get the image:
            Dim img As Image = mouseTile.Image
            If IsNothing(img) Then
                Return
            End If

            ' Set preview orientation to match the screenshot:
            Dim w = _frmPreview.Width
            Dim h = _frmPreview.Height
            If (w > h) <> (img.Width > img.Height) Then
                _frmPreview.Width = h
                _frmPreview.Height = w
            End If
            _frmPreview.pictureBox1.Image = img

            ' Set Location:
            Dim p As New Point(c1tileCntrl.Location.X + mouseTile.Group.X + mouseTile.X, c1tileCntrl.Location.Y + c1tileCntrl.ScrollOffset + mouseTile.Group.Y + mouseTile.Y)
            p = c1tileCntrl.PointToScreen(p)
            p.X += mouseTile.Width + 10
            ' Try to keep the preview within screen bounds:
            p.X = Math.Max(p.X, 0)
            p.Y = Math.Max(p.Y, 0)
            Dim screen__1 = Screen.FromControl(Me)
            p.Y = Math.Min(p.Y, screen__1.Bounds.Bottom - _frmPreview.Height)
            _frmPreview.Show(p)
            _previewTile = mouseTile
        End Sub

        Private Sub TileControl_MouseLeave(sender As Object, e As EventArgs)
            If _frmPreview IsNot Nothing Then
                _frmPreview.Hide()
            End If
        End Sub
#End Region

#Region "Private members"
        Private Sub HideShowTile(tile As Tile)
            Dim count As Integer = DirectCast(tile.Tag, CategoryInfo).ReportCount
            If Object.ReferenceEquals(tile.Image1.Tag, s_collapseTag) Then
                For i As Integer = 0 To count - 1
                    tile.Group.Tiles(tile.Index + i + 1).Visible = False
                Next
                Dim _timg As Image = tile.Image1
                _timg.RotateFlip(RotateFlipType.Rotate180FlipX)
                tile.Image1 = Nothing
                tile.Image1 = _timg
                ' "Expand";
                tile.Image1.Tag = Nothing
            Else
                For i As Integer = 0 To count - 1
                    tile.Group.Tiles(tile.Index + i + 1).Visible = True
                Next
                Dim _timg As Image = tile.Image1
                _timg.RotateFlip(RotateFlipType.Rotate180FlipX)
                tile.Image1 = Nothing
                tile.Image1 = _timg
                tile.Image1.Tag = s_collapseTag
            End If
        End Sub

        ''' <summary>
        ''' Highlights the selected tile and its parent.
        ''' </summary>
        ''' <param name="tile"></param>
        Private Sub HighlightSelectedTile(tile As Tile)
            Dim tiles = c1tileCntrl.Groups(0).Tiles
            ' Find old selected child/parent, reset their templates:
            Dim oldParent = tiles.FirstOrDefault(Function(t_) Object.ReferenceEquals(t_.Template, _tileSelectedTemplate))
            If oldParent IsNot Nothing Then
                oldParent.Template = Nothing
            End If
            Dim oldTile = tiles.FirstOrDefault(Function(t_) Object.ReferenceEquals(t_.Template, _reportSelectedTemplate))
            If oldTile IsNot Nothing Then
                oldTile.Template = _reportDefaultTemplate
            End If
            ' Set new selected tile/parent templates:
            Dim newParent = tiles.FirstOrDefault(Function(t_) String.Compare(t_.Name, TryCast(tile.Tag, String), True) = 0)
            If newParent IsNot Nothing Then
                newParent.Template = _tileSelectedTemplate
            End If
            tile.Template = _reportSelectedTemplate
            ' No point in previewing the current report, so hide preview:
            If _frmPreview IsNot Nothing AndAlso Object.ReferenceEquals(tile, _previewTile) Then
                _frmPreview.Hide()
            End If
        End Sub

        ''' <summary>
        ''' Tries to load the specified report from 3 locations, in order:
        ''' - from embedded resource;
        ''' - from file in Reports folder rel to .exe;
        ''' - from file in ..\..\Reports folder rel to .exe.
        ''' </summary>
        ''' <param name="category"></param>
        ''' <param name="reportFile"></param>
        ''' <param name="reportName"></param>
        ''' <returns></returns>
        Private Function LoadReport(category As String, reportFile As String, reportName As String) As C1FlexReport
            Try
                Dim thisExe As Assembly = Assembly.GetExecutingAssembly()
                Dim rptFile As Stream = thisExe.GetManifestResourceStream("C1FlexReportExplorer.Reports." & category & "." & reportFile)
                If rptFile Is Nothing Then
                    Dim exePath = Path.GetDirectoryName(thisExe.Location)
                    Dim tFile = Path.Combine(exePath, "Reports", category, reportFile)
                    If File.Exists(tFile) Then
                        rptFile = New FileStream(tFile, FileMode.Open, FileAccess.Read)
                    Else
                        rptFile = New FileStream(Path.Combine(exePath, "..\..\Reports", category, reportFile), FileMode.Open, FileAccess.Read)
                    End If
                    If rptFile Is Nothing Then
                        Return Nothing
                    End If
                End If
                flxRpt = New C1FlexReport()
                flxRpt.Load(rptFile, reportName)
                '
                FixConnectionStrings(flxRpt)
                '
                Return flxRpt
            Catch exc As Exception
                MessageBox.Show(exc.Message)
                Return Nothing
            End Try
        End Function

        Private Sub FixConnectionStrings(rpt As C1FlexReport)
            If rpt Is Nothing Then
                Return
            End If
            For Each ds As DataSource In rpt.DataSources
                ds.ConnectionString = FixConnectionString(ds.ConnectionString)
            Next
            For Each f As FieldBase In rpt.Fields
                If TypeOf f Is SubreportField Then
                    FixConnectionStrings(DirectCast(f, SubreportField).Subreport)
                ElseIf TypeOf f Is Field Then
                    FixConnectionStrings(DirectCast(f, Field).Subreport)
                End If
            Next
        End Sub

        Private Function FixConnectionString(connectionString As String) As String
            If String.IsNullOrEmpty(connectionString) Then
                Return connectionString
            End If

            Dim dsIndexStart As Integer = connectionString.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
            If dsIndexStart < 0 Then
                Return connectionString
            End If

            While dsIndexStart < connectionString.Length AndAlso connectionString(dsIndexStart) <> "="c
                dsIndexStart += 1
            End While
            If dsIndexStart >= connectionString.Length Then
                Return connectionString
            End If

            Dim dsIndexEnd As Integer = dsIndexStart
            While dsIndexEnd < connectionString.Length AndAlso connectionString(dsIndexEnd) <> ";"c
                dsIndexEnd += 1
            End While

            Dim dbName As String = connectionString.Substring(dsIndexStart + 1, dsIndexEnd - dsIndexStart - 1).Trim()
            If dbName.Length = 0 Then
                Return connectionString
            End If

            ' Look for the data file in:
            '' - Data folder rel to .exe;
            '' - ..\..\Data folder rel to .exe.
            Dim exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
            Dim tFile = Path.Combine(exePath, "Data", Path.GetFileName(dbName))
            If Not File.Exists(tFile) Then
                tFile = Path.Combine(exePath, "..\..\Data", Path.GetFileName(dbName))
            End If
            If File.Exists(tFile) Then
                dbName = tFile
            End If

            connectionString = (connectionString.Substring(0, dsIndexStart + 1) & dbName) + connectionString.Substring(dsIndexEnd)
            Return connectionString
        End Function
#End Region
    End Class
End Namespace
