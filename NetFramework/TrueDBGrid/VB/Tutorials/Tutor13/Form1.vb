Public Class Form1
    Inherits System.Windows.Forms.Form
      Private _ptStartDrag As Point = Point.Empty
      Private _dragRow As Integer = - 1

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        Application.EnableVisualStyles()
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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsTutor131 As Tutor13.dsTutor13
      Friend Label3 As System.Windows.Forms.Label
      Friend label6 As System.Windows.Forms.Label
      Friend label7 As System.Windows.Forms.Label
    Friend WithEvents C1TrueDBGrid2 As C1.Win.TrueDBGrid.C1TrueDBGrid

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DsTutor131 = New Tutor13.dsTutor13
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid
        Me.C1TrueDBGrid2 = New C1.Win.TrueDBGrid.C1TrueDBGrid
        CType(Me.DsTutor131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 10)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Drag a row from the top grid and drop it on the bottom grid"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(16, 216)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 23)
        Me.label6.TabIndex = 14
        Me.label6.Text = "To here:"
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(16, 40)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(100, 23)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Drag from here:"
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"), New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"), New System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode"), New System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString")
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Customer(Company, Contacted, CustType, FirstName, LastName, Phone, U" & _
            "serCode) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Company", System.Data.OleDb.OleDbType.VarWChar, 30, "Company"), New System.Data.OleDb.OleDbParameter("Contacted", System.Data.OleDb.OleDbType.DBDate, 0, "Contacted"), New System.Data.OleDb.OleDbParameter("CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"), New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 15, "LastName"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, "UserCode")})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserCode", "UserCode"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Contacted", "Contacted"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CustType", "CustType")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_UserCode", System.Data.OleDb.OleDbType.VarWChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Company", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Company1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Company", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Contacted", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Contacted1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacted", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustType", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustType1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustType", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Company, Contacted, CustType, FirstName, LastName, Phone, UserCode FROM Cu" & _
            "stomer"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CallList", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("CallDate", "CallDate")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO CallList(CallDate, Customer, Phone) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CallDate", System.Data.OleDb.OleDbType.DBDate, 0, "CallDate"), New System.Data.OleDb.OleDbParameter("Customer", System.Data.OleDb.OleDbType.VarWChar, 55, "Customer"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(15, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Current, Nothing)})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CallDate, Customer, Phone FROM CallList"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'DsTutor131
        '
        Me.DsTutor131.DataSetName = "DataSet1"
        Me.DsTutor131.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsTutor131.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowDrag = True
        Me.C1TrueDBGrid1.AllowDrop = True
        Me.C1TrueDBGrid1.Caption = "C1TrueDBGrid.Net"
        Me.C1TrueDBGrid1.DataMember = "Customer"
        Me.C1TrueDBGrid1.DataSource = Me.DsTutor131
        Me.C1TrueDBGrid1.ExtendRightColumn = True
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(16, 64)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.SolidCellBorder
        Me.C1TrueDBGrid1.MultiSelect = C1.Win.TrueDBGrid.MultiSelectEnum.Simple
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(456, 140)
        Me.C1TrueDBGrid1.TabIndex = 17
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.AllowDrop = True
        Me.C1TrueDBGrid2.DataMember = "CallList"
        Me.C1TrueDBGrid2.DataSource = Me.DsTutor131
        Me.C1TrueDBGrid2.ExtendRightColumn = True
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(16, 240)
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(456, 104)
        Me.C1TrueDBGrid2.TabIndex = 18
        Me.C1TrueDBGrid2.Text = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 366)
        Me.Controls.Add(Me.C1TrueDBGrid2)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Tutorial 13"
        CType(Me.DsTutor131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dragColumn As Integer
    Dim isDrag As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
            Me.OleDbDataAdapter1.Fill(Me.DsTutor131)
            Me.OleDbDataAdapter2.Fill(Me.DsTutor131)
        Catch eLoad As System.Exception
            MsgBox(eLoad.Message)
        End Try
          Me.C1TrueDBGrid1.AllowDrag = True
         Me.C1TrueDBGrid2.AllowDrop = True

    End Sub

    Private Sub ResetDragDrop()
         ' Turn off drag-and-drop by resetting the highlight and label text.
         Me._ptStartDrag = Point.Empty
         Me._dragRow = - 1
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.SolidCellBorder
        Me.C1TrueDBGrid2.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.SolidCellBorder
         Me.Label3.Text = "Drag a row from the top grid and drop it on the bottom grid."
    End Sub

    Private Sub C1TrueDBGrid1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseDown
         Dim row, col As Integer
         Me._ptStartDrag = Point.Empty
         Me._dragRow = - 1
         If Me.C1TrueDBGrid1.CellContaining(e.X, e.Y, row, col) Then
            ' save the starting point of the drag operation
            Me._ptStartDrag = New Point(e.X, e.Y)
            Me._dragRow = row
         End If
    End Sub

    Private Sub C1TrueDBGrid1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseMove
         ' if we don't have an empty start drag point, then the drag has been initiated
         If Not Me._ptStartDrag.IsEmpty Then
            ' create a rectangle that bounds the start of the drag operation by 2 pixels
            Dim r As New Rectangle(Me._ptStartDrag, Drawing.Size.Empty)
            r.Inflate(2, 2)
            ' if we've moved more than 2 pixels, lets start the drag operation
            If Not r.Contains(e.X, e.Y) Then
               Me.C1TrueDBGrid1.Row = Me._dragRow
                Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.HighlightRow
               Me.C1TrueDBGrid1.DoDragDrop(Me._dragRow, DragDropEffects.Copy)
            End If
         End If
    End Sub
    ' reset drag drop flags on mouse up
    Private Sub C1TrueDBGrid1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles C1TrueDBGrid1.MouseUp
        ResetDragDrop()
    End Sub 'C1TrueDBGrid1_MouseUp

    ' if we cancel or droped then reset the top grid
    Private Sub C1TrueDBGrid1_QueryContinueDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs) Handles C1TrueDBGrid1.QueryContinueDrag
        If e.Action = DragAction.Drop OrElse e.Action = DragAction.Cancel Then
            ResetDragDrop()
        End If
    End Sub


    Private Sub C1TrueDBGrid2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles C1TrueDBGrid2.DragEnter
        Me.Label3.Text = "Create a new record when dropped..."
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub C1TrueDBGrid2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles C1TrueDBGrid2.DragDrop
        Try
            Dim row As Integer = CInt(e.Data.GetData(GetType(Integer)))
            ' use the grids indexer to get some data
            Dim custname As String = Me.C1TrueDBGrid1(row, "FirstName").ToString()
            ' use the CellText() method to get some data
            custname += " " + Me.C1TrueDBGrid1.Columns("LastName").CellText(row)
            ' use the CellValue() method to get some data
            custname += " " + Me.C1TrueDBGrid1.Columns("Company").CellValue(row).ToString()
            ' add a new row to the data set for the bottom grid
            Dim drv As DataRowView = Me.DsTutor131.CallList.DefaultView.AddNew()
            drv("CallDate") = DateTime.Now
            drv("Customer") = custname
            drv("Phone") = Me.C1TrueDBGrid1.Columns("Phone").Value.ToString()
            drv.EndEdit()
            Me.C1TrueDBGrid2.MoveLast()
            Me.C1TrueDBGrid2.Select()
            ' commit changes to the database
            Dim inserted As DataSet = Me.DsTutor131.GetChanges(DataRowState.Added)
            If Not (inserted Is Nothing) Then
                Me.OleDbDataAdapter2.Update(inserted)
            End If
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Return String.Format("provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
    End Function

End Class
