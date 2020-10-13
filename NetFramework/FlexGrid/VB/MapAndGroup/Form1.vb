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
   Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents LoadBtn As System.Windows.Forms.Button
   Friend WithEvents SortBtn As System.Windows.Forms.Button
   Friend WithEvents OutlineBtn As System.Windows.Forms.Button
   Friend WithEvents MapBtn As System.Windows.Forms.Button
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.SortBtn = New System.Windows.Forms.Button()
        Me.OutlineBtn = New System.Windows.Forms.Button()
        Me.MapBtn = New System.Windows.Forms.Button()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1FlexGrid1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.C1FlexGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,75,Columns:"
        Me.C1FlexGrid1.Location = New System.Drawing.Point(10, 10)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Size = New System.Drawing.Size(676, 296)
        Me.C1FlexGrid1.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.C1FlexGrid1.TabIndex = 0
        '
        'LoadBtn
        '
        Me.LoadBtn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.LoadBtn.Location = New System.Drawing.Point(10, 316)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(113, 29)
        Me.LoadBtn.TabIndex = 1
        Me.LoadBtn.Text = "Load Grid"
        '
        'SortBtn
        '
        Me.SortBtn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.SortBtn.Location = New System.Drawing.Point(276, 316)
        Me.SortBtn.Name = "SortBtn"
        Me.SortBtn.Size = New System.Drawing.Size(113, 29)
        Me.SortBtn.TabIndex = 1
        Me.SortBtn.Text = "Sort"
        '
        'OutlineBtn
        '
        Me.OutlineBtn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.OutlineBtn.Location = New System.Drawing.Point(410, 316)
        Me.OutlineBtn.Name = "OutlineBtn"
        Me.OutlineBtn.Size = New System.Drawing.Size(112, 29)
        Me.OutlineBtn.TabIndex = 1
        Me.OutlineBtn.Text = "Outline"
        '
        'MapBtn
        '
        Me.MapBtn.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.MapBtn.Location = New System.Drawing.Point(143, 316)
        Me.MapBtn.Name = "MapBtn"
        Me.MapBtn.Size = New System.Drawing.Size(113, 29)
        Me.MapBtn.TabIndex = 1
        Me.MapBtn.Text = "Map data"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(696, 351)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.LoadBtn, Me.C1FlexGrid1, Me.SortBtn, Me.OutlineBtn, Me.MapBtn})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "C1FlexGrid: Grouping Mapped Data"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LoadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBtn.Click

        With C1FlexGrid1
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Clear)
            .Clear(C1.Win.C1FlexGrid.ClearFlags.All)
            .Sort(C1.Win.C1FlexGrid.SortFlags.None, 0, .Cols.Count - 1)
            .Cols(1).DataMap = Nothing
            .Cols(2).DataMap = Nothing
            .Cols(3).DataMap = Nothing

            .Cols.Count = 6
            .Rows.Count = 6
            .Cols(1).Caption = "Manager"
            .Cols(2).Caption = "Person"
            .Cols(3).Caption = "Skill"
            .Cols(4).Caption = "Start"
            .Cols(5).Caption = "End"

            .SetData(1, 1, 11111)
            .SetData(1, 2, 11111)
            .SetData(1, 3, 1)
            .SetData(1, 4, "1/5/2002")
            .SetData(1, 5, "5/5/2002")

            .SetData(2, 1, 11111)
            .SetData(2, 2, 11111)
            .SetData(2, 3, 1)
            .SetData(2, 4, "6/5/2002")
            .SetData(2, 5, "9/5/2002")

            .SetData(3, 1, 22222)
            .SetData(3, 2, 22222)
            .SetData(3, 3, 1)
            .SetData(3, 4, "1/5/2002")
            .SetData(3, 5, "5/5/2002")

            .SetData(4, 1, 22222)
            .SetData(4, 2, 22222)
            .SetData(4, 3, 2)
            .SetData(4, 4, "1/5/2002")
            .SetData(4, 5, "5/5/2002")

            .SetData(5, 1, 22222)
            .SetData(5, 2, 22222)
            .SetData(5, 3, 5)
            .SetData(5, 4, "1/5/2002")
            .SetData(5, 5, "5/5/2002")

            .AutoSizeCols()
        End With
    End Sub

    Private Sub MapBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MapBtn.Click
        Dim ManagerHash As New Hashtable()
        Dim PersonHash As New Hashtable()
        Dim SkillHash As New Hashtable()

        With ManagerHash ' Employee ID to Manager Name
            .Add(11111, "Big Boss")
            .Add(22222, "Big Boss")
        End With

        With PersonHash ' Employee ID to Employee Name
            .Add(11111, "Joe Worker (11111)")
            .Add(22222, "Bill Slacker (22222)")
        End With

        With SkillHash ' Skill ID to Skill Name
            .Add(1, "Eng (1)")
            .Add(2, "Adm (2)")
            .Add(3, "BS (3)")
            .Add(4, "Mgmt (4)")
            .Add(5, "Slacker (5)")
        End With

        With C1FlexGrid1
            .Cols(1).DataMap = ManagerHash
            .Cols(2).DataMap = PersonHash
            .Cols(3).DataMap = SkillHash
            .AutoSizeCols()
        End With
    End Sub

    Private Sub SortBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SortBtn.Click
        Dim msg As String
        msg = "Push the column headers to sort." & vbCrLf & vbCrLf & _
              "Notice how the data appears in order of the data being displayed, not the actual underlying data. " & vbCrLf & vbCrLf & _
              "To achieve this behavior, the sample uses the BeforeSort event and applies the 'AsDisplayed' flag to the sort order (by default, the grid will sort based on the underlying values)."
        MsgBox(msg)
    End Sub

    Private Sub OutlineBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutlineBtn.Click
        With C1FlexGrid1
            .Cols(1).Visible = False
            .Tree.Column = 2
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.None, 0, 1, 1, 2, "Manager: {0}")
            .Subtotal(C1.Win.C1FlexGrid.AggregateEnum.None, 1, 2, 2, 3, "Employee: {0}")
            .AutoSizeCols()

            Dim msg As String
            msg = "Notice that there are two 'Big Boss' groups." & vbCrLf & vbCrLf & _
                  "This is because although the entries have the same display value, they have different underlying values. The grid groups based on the underlying data, not on display values."
            MsgBox(msg)
        End With
    End Sub

    ' sort based on mapped values, not on the underlying data
    Private Sub C1FlexGrid1_BeforeSort(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles C1FlexGrid1.BeforeSort
        e.Order = e.Order Or C1.Win.C1FlexGrid.SortFlags.AsDisplayed
    End Sub
End Class
