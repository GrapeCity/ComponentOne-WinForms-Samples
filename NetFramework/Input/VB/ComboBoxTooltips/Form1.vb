Imports System.ComponentModel
Imports C1.Win.C1SuperTooltip


Public Class Form1

    Private _superTooltip As C1SuperTooltipBase = New C1SuperTooltipBase()
    Private _dataSource As New List(Of DataItem)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set tooltip parameters property grid
        pgDefaultParameters.SelectedObject = _superTooltip

        ' add items And tooltip data
        AddDataItem("It`s Sphere.", "sphere", "sphere.png",
                String.Format("<table width='{0}' height='{1}' align='center'>" &
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:gold'>{2}</td></tr>" &
                              "<tr><td><img src='{3}' width='100' height='100'></td></tr></table>", 150, 150, "Sphere", "sphere.png"))

        AddDataItem("This Is The Cone.", "cone", "cone.png",
                String.Format("<table width='{0}' height='{1}' align='center'>" &
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:gold'>{2}</td></tr>" &
                              "<tr><td><img src='{3}' width='100' height='100'></td></tr></table>", 150, 150, "Cone", "cone.png"), 0)

        AddDataItem("Just a cube", "cube", "cube.png",
                String.Format("<table width='{0}' height='{1}' align='center'> " &
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:lightgreen'>{2}</td></tr>" &
                              "<tr><td align='center' style='background-color:lightblue'><img src='{3}' width='180' height='180'></td></tr></table>",
                              250, 250, "Cube", "cube.png"), -265)

        AddDataItem("Tooltip without image.", "", "",
                String.Format("<table width='{0}' height='{1}' align='center'>" &
                              "<tr><td style='font-size:15px;font-weight:bold;color:blue;background-color:cyan'>{2}<br><br>" &
                              "<font style='font-size:11px;color:DarkGreen'>{3}</font></td></tr></table>",
                              150, 80, "text only,<br>rounded corners", "without image"), 0)

        AddDataItem("Item without tooltip.", "", "", "", 0)

        AddDataItem("Cylinder", "cylinder", "cylinder.png",
                String.Format("<table width='{0}' height='{1}' align='center'>" &
                              "<tr><td><img src='{2}' width='100' height='100'></td></tr>" &
                              "<tr><td height='19px' style='font-size:15px;font-weight:bold;background-color:lightgreen'>{3}</td></tr></table>",
                              150, 150, "cylinder.png", "Cylinder..."), 0)

        ' set data source
        C1ComboBox1.DataSource = _dataSource
        C1ComboBox1.ItemsDataSource = _dataSource
        C1ComboBox1.ItemsDisplayMember = "ItemText"
        C1ComboBox1.ItemsValueMember = "ItemText"

        ' set other properties
        C1ComboBox1.ItemsImageList = ImageList1
        C1ComboBox1.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
        C1ComboBox1.HtmlPattern = "<table><tr><td><img src='{ImageFile}' width='16' height='16'></img></td><td><div style='white-space:nowrap'>{ItemText}</div></td></tr></table>"
        C1ComboBox1.ShowTooltip = True

        C1ComboBox1.SelectedIndex = 1

        ' set instructions text
        Label1.Text = "Design-time:" + Environment.NewLine & Environment.NewLine &
                          "1. Add items to C1ComboBox.Items collection." & Environment.NewLine &
                          "2. Add images to the imageList1." & Environment.NewLine &
                          "3. Set keys(Name) of the images equal to the items in C1ComboBox.Items." & Environment.NewLine &
                          "4. Enable tooltips for highlighted items by setting ShowTooltip = true." & Environment.NewLine &
                          "5. Add TooltipShowing event handler method." & Environment.NewLine &
                          "6. In the TooltipShowing event handler method add code to set tooltip parameters."

        Reset()
    End Sub

    Private Sub C1ComboBox1_TooltipShowing(sender As Object, e As C1.Win.C1Input.TooltipShowingEventArgs) Handles C1ComboBox1.TooltipShowing
        Dim item = _dataSource(e.Index)

        If item Is Nothing Then
            Return
        End If

        If String.IsNullOrEmpty(item.TooltipText) Then
            e.Handled = True ' don`t show tooltip For this item

            ' remove info text
            tbxText.Text = String.Empty
            tbxX.Text = String.Empty
            tbxY.Text = String.Empty

            Return
        End If

        ' set default tooltip properties
        e.Tooltip.Active = _superTooltip.Active
        e.Tooltip.AutomaticDelay = _superTooltip.AutomaticDelay
        e.Tooltip.AutoPopDelay = _superTooltip.AutoPopDelay
        e.Tooltip.BackColor = _superTooltip.BackColor
        e.Tooltip.BackgroundGradient = _superTooltip.BackgroundGradient
        e.Tooltip.BackgroundImage = _superTooltip.BackgroundImage
        e.Tooltip.BackgroundImageLayout = _superTooltip.BackgroundImageLayout
        e.Tooltip.Border = _superTooltip.Border
        e.Tooltip.BorderColor = _superTooltip.BorderColor
        e.Tooltip.FollowCursor = _superTooltip.FollowCursor
        e.Tooltip.Font = _superTooltip.Font
        e.Tooltip.ForeColor = _superTooltip.ForeColor
        e.Tooltip.HitTestVisible = _superTooltip.HitTestVisible
        e.Tooltip.InitialDelay = _superTooltip.InitialDelay
        e.Tooltip.IsBalloon = _superTooltip.IsBalloon
        e.Tooltip.MaximumWidth = _superTooltip.MaximumWidth
        e.Tooltip.Opacity = _superTooltip.Opacity
        e.Tooltip.ReshowDelay = _superTooltip.ReshowDelay
        e.Tooltip.RoundedCorners = _superTooltip.RoundedCorners
        e.Tooltip.Shadow = _superTooltip.Shadow
        e.Tooltip.ShowAlways = _superTooltip.ShowAlways
        e.Tooltip.StripAmpersands = _superTooltip.StripAmpersands
        e.Tooltip.UseFading = _superTooltip.UseFading

        e.Duration = Convert.ToInt32(tbxDuration.Text)

        ' set tooltip X coordinate if assigned
        If item.X <> 0 Then
            e.X = item.X
        End If

        e.Text = item.TooltipText

        ' show info
        tbxText.Text = e.Text
        tbxX.Text = Convert.ToString(e.X)
        tbxY.Text = Convert.ToString(e.Y)
    End Sub

    Private Sub AddDataItem(ByVal itemText As String, ByVal imageKey As String, ByVal imageFile As String, ByVal tooltipText As String, Optional ByVal x As Integer = 0)
        _dataSource.Add(New DataItem(itemText, imageKey, imageFile, tooltipText, x))

        ' add images if assigned
        If Not String.IsNullOrEmpty(imageKey) And Not String.IsNullOrEmpty(imageFile) Then
            ImageList1.Images.Add(imageKey, Image.FromFile(imageFile))
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim item = pgDefaultParameters.SelectedGridItem

        If item IsNot Nothing And item.PropertyDescriptor IsNot Nothing Then
            Dim context = TryCast(item, ITypeDescriptorContext)
            ResetToolStripMenuItem.Enabled = item IsNot Nothing And item.GridItemType = GridItemType.Property And context IsNot Nothing And item.PropertyDescriptor.CanResetValue(context.Instance)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim item = pgDefaultParameters.SelectedGridItem
        Dim propertyDescriptor = item.PropertyDescriptor

        If propertyDescriptor IsNot Nothing And propertyDescriptor.CanResetValue(pgDefaultParameters.SelectedObject) Then
            propertyDescriptor.ResetValue(pgDefaultParameters.SelectedObject)
            item.Select() ' refresh PropertyGrid
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Reset()
        tbxDuration.Text = "0"
    End Sub


    Private Class DataItem
        Public Sub New()
        End Sub

        Public Sub New(ByVal itemText As String, ByVal imageKey As String, ByVal imageFile As String, ByVal tooltipText As String, ByVal x As Integer)
            Me.ItemText = itemText
            Me.ImageKey = imageKey
            Me.ImageFile = imageFile
            Me.TooltipText = tooltipText
            Me.X = x
        End Sub

        Public Property ItemText As String
        Public Property ImageKey As String
        Public Property ImageFile As String
        Public Property TooltipText As String
        Public Property X As Integer
    End Class

End Class