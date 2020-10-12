Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace C1ApplicationZoomPages
    Partial Public Class AppZoom_Child1
        Inherits Form
        Public Sub New()
            InitializeComponent()
            PopulateDateGridView1()
            dataGridView1.RowCount = 100
            PopulateDateGridView2()
            dataGridView2.RowCount = 100

            InitRecentlyUsedSubjects()

            InitTreeView()
        End Sub

#Region "DataGridView"
        Private Sub PopulateDateGridView1()
            Dim row0 As String() = {"2012/12/22", "✕✕銀行借入金", "預金", "", "10,000", "150,000"}
            Dim row1 As String() = {"2012/12/23", "〇〇信用組合", "預金", "20,000", "", "170,000"}
            Dim row2 As String() = {"2012/12/23", "BOCバンク", "預金", "", "50,000", "120,000"}
            Dim row3 As String() = {"2012/12/24", "不動産収入", "ゆうちょ", "90,000", "", "210,000"}
            Dim row4 As String() = {"2012/12/25", "営業収入", "預金", "40,000", "", "250,000"}
            Dim row5 As String() = {"2012/12/25", "光熱費", "ゆうちょ", "", "20,000", "230,000"}
            Dim row6 As String() = {"2012/12/26", "スタジオ使用料", "預金", "", "22,000", "208,000"}

            If True Then
                Dim rows As DataGridViewRowCollection = Me.dataGridView1.Rows
                rows.Add(row0)
                rows.Add(row1)
                rows.Add(row2)
                rows.Add(row3)
                rows.Add(row4)
                rows.Add(row5)
                rows.Add(row6)

            End If
        End Sub

        Private Sub PopulateDateGridView2()
            Dim row0 As String() = {"✕✕銀行", "2012/12/01", "前月繰越", "", "50,000", "", _
                "50,000"}
            Dim row1 As String() = {"JJJ信用金庫", "2012/12/05", "当座預金口座に預入", "", "80,000", "", _
                "130,000"}
            Dim row2 As String() = {"✕✕銀行", "2012/12/07", "A商店に掛代金支払", "G001", "", "45,000", _
                "85,000"}
            Dim row3 As String() = {"✕✕銀行", "2012/12/11", "B会社に仕入代金支払", "G002", "", "20,000", _
                "65,000"}
            Dim row4 As String() = {"〇〇信用組合", "2012/12/23", "C会社から掛代金回収", "", "35,000", "", _
                "100,000"}
            Dim row5 As String() = {"✕✕銀行", "2012/12/30", "次月繰越", "", "", "", _
                "100,000"}
            If True Then
                Dim rows As DataGridViewRowCollection = Me.dataGridView2.Rows
                rows.Add(row0)
                rows.Add(row1)
                rows.Add(row2)
                rows.Add(row3)
                rows.Add(row4)
                rows.Add(row5)

            End If
        End Sub
#End Region

        Private Sub InitRecentlyUsedSubjects()
            listBox1.SelectionMode = SelectionMode.MultiExtended
            listBox1.BeginUpdate()

            listBox1.Items.Add("現金")
            listBox1.Items.Add("小口預金")
            listBox1.Items.Add("定期預金")
            listBox1.Items.Add("当座預金")
            listBox1.Items.Add("郵便貯金")
            listBox1.Items.Add("普通預金")
            listBox1.Items.Add("定期積金")
            listBox1.Items.Add("商品")

            listBox1.EndUpdate()
        End Sub

        Private Sub InitTreeView()
            treeView1.BeginUpdate()
            treeView1.Nodes.Add("[資産]")
            treeView1.Nodes(0).Nodes.Add("[流動資産]")
            treeView1.Nodes(0).Nodes.Add("[固定資産]")

            '#Region "Current Assets"
            treeView1.Nodes(0).Nodes(0).Nodes.Add("[現金]")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("商品")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("小口預金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("定期預金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("当座預金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("郵便貯金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("普通預金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("ゆうちょ預金")
            treeView1.Nodes(0).Nodes(0).Nodes(0).Nodes.Add("定期積金")

            treeView1.Nodes(0).Nodes(0).Nodes.Add("[契約量]")
            treeView1.Nodes(0).Nodes(0).Nodes(1).Nodes.Add("手形")
            treeView1.Nodes(0).Nodes(0).Nodes(1).Nodes.Add("不渡り手形")
            treeView1.Nodes(0).Nodes(0).Nodes(1).Nodes.Add("未収金")
            treeView1.Nodes(0).Nodes(0).Nodes(1).Nodes.Add("不良債権")
            treeView1.Nodes(0).Nodes(0).Nodes(1).Nodes.Add("契約量合計")
            '#End Region

            treeView1.Nodes(0).Nodes(1).Nodes.Add("......")

            treeView1.EndUpdate()
        End Sub

        Private Sub button3_Click(sender As Object, e As EventArgs)
            Dim form As New AppZoom_Child3()
            form.StartPosition = FormStartPosition.CenterParent
            form.ShowDialog(Me)
        End Sub


    End Class
End Namespace
