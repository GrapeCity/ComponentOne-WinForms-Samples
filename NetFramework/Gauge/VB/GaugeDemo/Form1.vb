Imports System.Reflection

Public Class Form1

    Private Function AddCase(ByVal nodes As TreeNodeCollection, _
      ByVal className As String, ByVal text As String) As TreeNode

        Dim node As New TreeNode(text)
        node.Tag = className
        nodes.Add(node)
        Return node

    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim node As TreeNode = AddCase(samplesTree.Nodes, "PageRoot1", "Samples")
        Dim nodes As TreeNodeCollection = node.Nodes

        AddCase(nodes, "PageGageDial", "Gage Dial")
        AddCase(nodes, "PageLogarithmic", "Logarithmic 1")
        AddCase(nodes, "PageLogScale", "Logarithmic 2")
        AddCase(nodes, "PageYandexGauge", "Yandex Gauge")
        AddCase(nodes, "PageHelical", "Helical Gauge")
        AddCase(nodes, "PageInclined", "Inclined")
        AddCase(nodes, "PageSlidingScale", "Sliding Scale")
        AddCase(nodes, "PageIntervalWidth", "Fixed Interval Width")
        AddCase(nodes, "PageClock", "Clock")
        AddCase(nodes, "PageSwissRailwayClock", "Swiss Railway Clock")
        AddCase(nodes, "PageEqualizer", "Equalizer")
        AddCase(nodes, "PageCarDashboard", "Car Dashboard")
        AddCase(nodes, "PageHypotrochoid", "Hypotrochoid")
        AddCase(nodes, "PageLituus", "Lituus Progress Bar")
        AddCase(nodes, "PageCircularProgress", "Circular Progress Bar")
        AddCase(nodes, "PageMultithreaded", "Multi-Threaded")
        AddCase(nodes, "PageDataBound", "Data Bound")
        AddCase(nodes, "PageInteractive", "Interactive")
        AddCase(nodes, "PageKnob", "Knob")
        AddCase(nodes, "PageKnob2", "Double Knob")
        AddCase(nodes, "PageRuler", "Ruler Gauge")
        AddCase(nodes, "PageTrackBar", "Track Bar")
        AddCase(nodes, "PageBulletGraph", "Bullet Graph")

        'nodes = samplesTree.Nodes["Samples 2"].Nodes;

        samplesTree.ExpandAll()
    End Sub

    Private _gridHidden As Boolean

    Private Sub samplesTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles samplesTree.AfterSelect
        hsButton.Visible = False
        Dim controls As Control.ControlCollection = hostPanel.Controls
        If controls.Count = 1 Then
            Dim oldPage As BaseGaugePage = controls(0)
            controls.Clear()
            oldPage.Dispose()
        End If
        If e.Node.Tag IsNot Nothing Then
            Dim className As String = e.Node.Tag
            Dim asm As Assembly = Assembly.GetExecutingAssembly()
            Dim classType As Type = asm.GetType("GaugeDemo." + className)
            Dim ci As ConstructorInfo = classType.GetConstructor(New Type() {})
            Dim page As BaseGaugePage = ci.Invoke(Nothing)
            If Not (TypeOf page Is BasePageNoGrid) Then
                hsButton.Visible = True
                If (_gridHidden) Then
                    page.gridPanel.Visible = False
                    page.splitter1.Visible = False
                End If
            End If
            page.captionLabel.Text = e.Node.Text
            page.Dock = DockStyle.Fill
            controls.Add(page)
        End If
    End Sub

    Private Sub hsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hsButton.Click
        Dim controls As Control.ControlCollection = hostPanel.Controls
        If controls.Count = 1 Then
            Dim page As BaseGaugePage = controls(0)
            If Not (TypeOf page Is BasePageNoGrid) Then
                If Not _gridHidden Then
                    page.gridPanel.Visible = False
                    page.splitter1.Visible = False
                    hsButton.Text = "show"
                    _gridHidden = True
                Else
                    page.splitter1.Visible = True
                    page.gridPanel.Visible = True
                    hsButton.Text = "hide"
                    _gridHidden = False
                End If
            End If
        End If
    End Sub
End Class

