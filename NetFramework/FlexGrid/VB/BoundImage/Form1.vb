Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Namespace DBImages
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
        Friend WithEvents oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
        Friend WithEvents DataSet11 As BoundImage.DataSet1
        Friend WithEvents flex As C1.Win.C1FlexGrid.C1FlexGrid
        Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
        Friend WithEvents OleDbConnection2 As System.Data.OleDb.OleDbConnection
        Friend WithEvents DataSet21 As BoundImage.DataSet2
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
            Me.DataSet11 = New BoundImage.DataSet1()
            Me.flex = New C1.Win.C1FlexGrid.C1FlexGrid()
            Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
            Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
            Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
            Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
            Me.OleDbConnection2 = New System.Data.OleDb.OleDbConnection()
            Me.DataSet21 = New BoundImage.DataSet2()
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.flex, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = GetConnectionString()
            '
            'pictureBox1
            '
            Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.pictureBox1.Location = New System.Drawing.Point(376, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(200, 349)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pictureBox1.TabIndex = 3
            Me.pictureBox1.TabStop = False
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
            Me.oleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
            Me.oleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("HireDate", "HireDate"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("Photo", "Photo")})})
            Me.oleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
            '
            'DataSet11
            '
            Me.DataSet11.DataSetName = "DataSet1"
            Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
            '
            'flex
            '
            Me.flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both
            Me.flex.AutoResize = False
            Me.flex.BackColor = System.Drawing.SystemColors.Window
            Me.flex.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:37;}" & Microsoft.VisualBasic.ChrW(9) & "1{Name:""FirstName"";Caption:""FirstName"";DataType" & _
            ":System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "2{Name:""LastName"";Caption:""LastName"";DataT" & _
            "ype:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "3{Name:""Country"";Caption:""Country"";Data" & _
            "Type:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "4{Name:""City"";Caption:""City"";DataType:" & _
            "System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "5{Name:""HireDate"";Caption:""HireDate"";DataTy" & _
            "pe:System.DateTime;Format:""d"";TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "6{Name:""Notes"";Caption:""Not" & _
            "es"";DataType:System.String;TextAlign:LeftCenter;}" & Microsoft.VisualBasic.ChrW(9) & "7{Name:""Photo"";Caption:""Photo""" & _
            ";Visible:False;AllowEditing:False;DataType:System.Byte[];}" & Microsoft.VisualBasic.ChrW(9) & "8{Name:""EmployeeID"";C" & _
            "aption:""EmployeeID"";DataType:System.Int32;TextAlign:RightCenter;}" & Microsoft.VisualBasic.ChrW(9)
            Me.flex.DataMember = "Employees"
            Me.flex.DataSource = Me.DataSet21
            Me.flex.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flex.ForeColor = System.Drawing.SystemColors.ControlText
            Me.flex.Name = "flex"
            Me.flex.Rows.Count = 1
            Me.flex.Size = New System.Drawing.Size(376, 349)
            Me.flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Normal{ForeColor:ControlText;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:Control;Border:Flat,1,ControlDark," & _
            "Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:" & _
            "Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor" & _
            ":AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;Fo" & _
            "reColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{" & _
            "BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;" & _
            "ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal" & _
            "4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDar" & _
            "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9))
            Me.flex.TabIndex = 4
            '
            'OleDbSelectCommand1
            '
            Me.OleDbSelectCommand1.CommandText = "SELECT FirstName, LastName, Country, City, HireDate, Notes, Photo, EmployeeID FRO" & _
            "M Employees"
            Me.OleDbSelectCommand1.Connection = Me.OleDbConnection2
            '
            'OleDbInsertCommand1
            '
            Me.OleDbInsertCommand1.CommandText = "INSERT INTO Employees(FirstName, LastName, Country, City, HireDate, Notes, Photo," & _
            " EmployeeID) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Me.OleDbInsertCommand1.Connection = Me.OleDbConnection2
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"))
            Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Current, Nothing))
            '
            'OleDbUpdateCommand1
            '
            Me.OleDbUpdateCommand1.CommandText = "UPDATE Employees SET FirstName = ?, LastName = ?, Country = ?, City = ?, HireDate" & _
            " = ?, Notes = ?, Photo = ?, EmployeeID = ? WHERE (EmployeeID = ?) AND (City = ? " & _
            "OR ? IS NULL AND City IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL" & _
            ") AND (FirstName = ?) AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (" & _
            "LastName = ?) AND (Notes = ? OR ? IS NULL AND Notes IS NULL) AND (Photo = ? OR ?" & _
            " IS NULL AND Photo IS NULL)"
            Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection2
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, "FirstName"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 20, "LastName"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("HireDate", System.Data.OleDb.OleDbType.DBDate, 0, "HireDate"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Notes", System.Data.OleDb.OleDbType.VarWChar, 0, "Notes"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Photo", System.Data.OleDb.OleDbType.VarBinary, 0, "Photo"))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Current, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HireDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HireDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Photo", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Photo", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Photo1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Photo", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbDeleteCommand1
            '
            Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Employees WHERE (EmployeeID = ?) AND (City = ? OR ? IS NULL AND City " & _
            "IS NULL) AND (Country = ? OR ? IS NULL AND Country IS NULL) AND (FirstName = ?) " & _
            "AND (HireDate = ? OR ? IS NULL AND HireDate IS NULL) AND (LastName = ?) AND (Not" & _
            "es = ? OR ? IS NULL AND Notes IS NULL) AND (Photo = ? OR ? IS NULL AND Photo IS " & _
            "NULL)"
            Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection2
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FirstName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HireDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HireDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_HireDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HireDate", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LastName", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Notes1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notes", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Photo", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Photo", System.Data.DataRowVersion.Original, Nothing))
            Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Photo1", System.Data.OleDb.OleDbType.VarBinary, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Photo", System.Data.DataRowVersion.Original, Nothing))
            '
            'OleDbConnection2
            '
            Me.OleDbConnection2.ConnectionString = GetConnectionString()
            '
            'DataSet21
            '
            Me.DataSet21.DataSetName = "DataSet2"
            Me.DataSet21.Locale = New System.Globalization.CultureInfo("en-US")
            Me.DataSet21.Namespace = "http://www.tempuri.org/DataSet2.xsd"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(576, 349)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.flex, Me.pictureBox1})
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "C1FlexGrid: Show Database Images"
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.flex, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.oleDbDataAdapter1.Fill(DataSet21)

            ' initialize styles
            flex.Styles.Normal.Margins.Left = 0
            flex.Styles.Normal.Margins.Right = 0
            flex.Styles.Normal.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftTop
            flex.Styles.Normal.WordWrap = True
            flex.Styles.Fixed.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter
            'flex.AutoSizeRows()
        End Sub

        Private Sub flex_AfterRowColChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles flex.AfterRowColChange
            If (flex.Row > -1 AndAlso e.NewRange.r1 <> e.OldRange.r1) Then
                Dim c As C1.Win.C1FlexGrid.Column = flex.Cols("Photo")
                If Not c Is Nothing Then
                    Me.pictureBox1.Image = LoadImage(CType(flex(flex.Row, "Photo"), Byte()))
                End If
            End If
        End Sub

        Private Function LoadImage(ByVal picData As Byte()) As Image

            ' make sure this is an embedded object
            Const bmData As Integer = 78

            If (picData Is Nothing OrElse picData.Length < bmData + 2) Then
                Return Nothing
            End If

            If (picData(0) <> 21 OrElse picData(1) <> 28) Then
                Return Nothing
            End If

            ' we only handle bitmaps for now
            If (picData(bmData) <> AscW("B") OrElse picData(bmData + 1) <> AscW("M")) Then
                Return Nothing
            End If

            ' load the picture
            Dim img As Image = Nothing

            Try
                Dim ms As MemoryStream = New MemoryStream(picData, bmData, picData.Length - bmData)
                img = Image.FromStream(ms)
            Catch

            End Try

            ' return what we got
            Return img

        End Function

        Private Sub flex_AfterDataRefresh(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles flex.AfterDataRefresh

            ' autosize to fit "notes" field
            If (e.ListChangedType = ListChangedType.Reset) Then
                flex.AutoSizeRows()
            End If
        End Sub

        Private Function GetConnectionString() As String
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
            Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
            Return String.Format(conn, path)
        End Function
    End Class
End Namespace