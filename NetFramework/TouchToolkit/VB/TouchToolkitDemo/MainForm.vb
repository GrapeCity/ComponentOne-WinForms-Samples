Imports C1.Win.TouchToolKit
Imports System.Collections
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Partial Public Class MainForm
    Inherits Form
    Public Sub New()
        InitializeComponent()

        AddHandler Me.Load, New EventHandler(AddressOf MainForm_Load)
        AddHandler treemenu.AfterSelect, New TreeViewEventHandler(AddressOf treemenu_AfterSelect)
        AddHandler treemenu.AfterCollapse, New TreeViewEventHandler(AddressOf treemenu_AfterCollapse)
        AddHandler firstView.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf firstView_LinkClicked)
        AddHandler product_info.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf product_info_LinkClicked)
        AddHandler twitter.LinkClicked, New LinkLabelLinkClickedEventHandler(AddressOf twitter_LinkClicked)
        AddHandler searchtext.TextChanged, New EventHandler(AddressOf searchtext_TextChanged)
        AddHandler searchlist.SelectedIndexChanged, New EventHandler(AddressOf searchlist_SelectedIndexChanged)
        AddHandler myTabControl1.SelectedIndexChanged, New EventHandler(AddressOf myTabControl1_SelectedIndexChanged)

        ' VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
        ' デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
        splitContainer3.FixedPanel = FixedPanel.Panel2
        ' デザイナを開くたびに位置が変わるため、コードから設定して回避
        grapecity_logo.Location = New Point(12, 27)
        copyright.Location = New Point(173, 35)

        ' ちらつき防止
        ' ヘッダ
        pictureBox1.Controls.Add(cube)
        pictureBox1.Controls.Add(product_logo)
        pictureBox1.Controls.Add(product_title)
        pictureBox1.Controls.Add(firstView)

        ' フッタ
        pictureBox2.Controls.Add(grapecity_logo)
        pictureBox2.Controls.Add(copyright)
        pictureBox2.Controls.Add(product_info)
        pictureBox2.Controls.Add(separator)
        pictureBox2.Controls.Add(twitter)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs)
        Dim maxTouchPoints As Integer = C1TouchEventProvider.MaximunTouches

        Dim win8 As Boolean = Environment.OSVersion.Version >= New Version(6, 2)
        If maxTouchPoints = 0 OrElse Not win8 Then
            Dim commonFile As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)
            Dim r As DialogResult = MessageBox.Show("To have better experience, please try this demo in a touchable environment." & vbCr & vbLf & vbCr & vbLf & "Environment request:" & vbCr & vbLf & "- Windows 8 Oprating System or upper." & vbCr & vbLf & "- A touchable device. (Or Simulator in " & commonFile & "\Microsoft Shared\Windows Simulator)" & vbCr & vbLf & vbCr & vbLf & "Are you still want to contine try?" & vbCr & vbLf & "Click 'Yes' to continue. Click 'No' to close." & vbCr & vbLf & "                ", "Do not support touch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If r = System.Windows.Forms.DialogResult.No Then
                Me.Close()
            End If
        End If

        ' ファーストビューを開く
        Me.setMainPanel(New FirstViewPage())
    End Sub
    Private Sub treemenu_AfterSelect(sender As Object, e As TreeViewEventArgs)
        Dim text As String = e.Node.Text
        Dim node = e.Node
        While node.Nodes.Count > 0
            node = node.Nodes(0)
            text = node.Text
        End While

        Select Case text.Trim()
            Case "Basic (Zoom and Scroll)"
                If e.Node.Tag IsNot Nothing Then
                    If e.Node.Tag.ToString() = "C1Zoom" Then
                        Me.setMainPanel(New C1ZoomPages.C1ZoomCommenDemo())
                    End If
                    If e.Node.Tag.ToString() = "C1ZoomPanel" Then
                        Me.setMainPanel(New C1ZoomPanelPages.C1ZoomPanelDemo())
                    End If
                End If
                Exit Select
            Case "ControlBar"
                Me.setMainPanel(New C1ZoomPages.ControlBarDemo())
                Exit Select
            Case "Show Control"
                Me.setMainPanel(New C1ZoomPages.ShowControlDemo())
                Exit Select
            Case "Pan Window"
                Me.setMainPanel(New C1ZoomPages.PanWindowDemo())
                Exit Select
            Case "Zoom Policy"
                Me.setMainPanel(New C1ZoomPages.ZoomPolicyDemo())
                Exit Select
            Case "Misc"
                Me.setMainPanel(New C1ZoomPages.MiscFeatureDemo())
                Exit Select

            Case "Multiple window Business app example with the Component"
                Me.setMainPanel(New C1ApplicationZoomPages.C1ApplicationZoomDemo())
                Exit Select

            Case "C1Magnify"
                Me.setMainPanel(New C1MagnifyPages.C1MagnifyCommon())
                Exit Select
            Case "Compare PictureBox and C1MultiScaleImage"
                Me.setMainPanel(New MultiScaleImagePages.MultiScaleImageDemo())
                Exit Select

            Case "Touch Events Listener"
                Me.setMainPanel(New TouchEvent.TouchEventListener())
                Exit Select
            Case "ContextualUI"
                Me.setMainPanel(New TouchEvent.ContextualUIDemo())
                Exit Select
            Case "AutoRepeat"
                Me.setMainPanel(New TouchEvent.AutoRepeatDemo())
                Exit Select
            Case "ImageViewer"
                Me.setMainPanel(New TouchEvent.TouchEventDemo())
                Exit Select
            Case "Drawing Board for Pen"
                Me.setMainPanel(New TouchEvent.DrawingBoardDemo())
                Exit Select
            Case Else

                Exit Select
        End Select
    End Sub

    Private Sub treemenu_AfterCollapse(sender As Object, e As TreeViewEventArgs)
        treemenu.SelectedNode = Nothing
    End Sub

#Region "ページ移動処理"
    Private Sub setMainPanel(ucontrol As FirstViewPage)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ucontrol As DemoBase)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ucontrol As DemoBase_settings)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
#End Region

#Region "リンク処理"
    Private Sub firstView_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' ファーストビューに戻る
        Me.setMainPanel(New FirstViewPage())
        treemenu.SelectedNode = Nothing
        treemenu.ExpandAll()
    End Sub

    Private Sub trial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' トライアル版へのリンク
        'System.Diagnostics.Process.Start("");
    End Sub

    Private Sub product_info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' フッタから製品情報へのリンク
        'System.Diagnostics.Process.Start("");
    End Sub

    Private Sub twitter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        ' ツイッターへのリンク
        'System.Diagnostics.Process.Start("");
    End Sub
#End Region

#Region "検索機能"
    ' 検索ノードのコレクション               
    Private myNode As New ArrayList()

    Private Sub searchtext_TextChanged(sender As Object, e As EventArgs)
        ' 検索結果(searchlist)をクリア
        searchlist.Items.Clear()
        myNode.Clear()

        If searchtext.Text = "" Then
            Return
        End If

        ' ツリーコントロールのノードを取得
        For Each node As TreeNode In GetAllNodes(treemenu.Nodes)
            If node.Parent IsNot Nothing Then
                Dim s As String = node.Text
                If node.Tag IsNot Nothing Then
                    s += node.Tag.ToString()
                End If

                ' 検索ワードを含むノードのみ抽出
                If s.ToUpper().Contains(searchtext.Text.ToUpper()) Then
                    myNode.Add(node)
                    searchlist.Items.Add(node.Text)
                End If
            End If
        Next
    End Sub

    Private Function GetAllNodes(Nodes As TreeNodeCollection) As ArrayList
        Dim Ar As New ArrayList()
        ' ツリーコントロールのノードを取得
        For Each Node As TreeNode In Nodes
            Ar.Add(Node)
            If Node.GetNodeCount(False) > 0 Then
                Ar.AddRange(GetAllNodes(Node.Nodes))
            End If
        Next
        Return Ar
    End Function

    Private Sub searchlist_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' リストボックスで選択されたページを表示
        treemenu.SelectedNode = DirectCast(myNode(searchlist.SelectedIndex), TreeNode)
    End Sub

    Private Sub myTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' ツリービューにフォーカスを設定して選択状態にする
        If myTabControl1.SelectedIndex = 0 Then
            treemenu.[Select]()
        End If
    End Sub
#End Region

    Private Sub treemenu_VisibleChanged(sender As Object, e As EventArgs) Handles treemenu.VisibleChanged
        'Me.treemenu.Nodes(0).ExpandAll()
    End Sub


End Class

' ツリービューのシングルクリックでの開閉
Class MyTreeView
    Inherits TreeView
    Public Sub New()
        MyBase.New()
        AddHandler NodeMouseClick, New TreeNodeMouseClickEventHandler(AddressOf MyTreeView_NodeMouseClick)
    End Sub

    Private Sub MyTreeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
        If e.Node IsNot Nothing Then
            If HitTest(e.Location).Location = TreeViewHitTestLocations.Label OrElse HitTest(e.Location).Location = TreeViewHitTestLocations.Image Then
                e.Node.Toggle()
            End If
        End If
    End Sub
End Class

' タブコントロール内のちらつきを抑える
Class MyTabControl
    Inherits TabControl
    ' リサイズ途中のちらつきを抑える処理
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class