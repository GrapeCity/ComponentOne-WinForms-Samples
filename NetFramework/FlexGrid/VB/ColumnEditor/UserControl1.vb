Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid

Namespace ColumnEditor
    Public Class UserControl1
        Inherits System.Windows.Forms.UserControl
        Implements ISupportInitialize

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'UserControl overrides dispose to clean up the component list.
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
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
            Me.label1 = New System.Windows.Forms.Label()
            Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Black
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(5, 5)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(470, 68)
            Me.label1.TabIndex = 2
            Me.label1.Text = "To edit the grid columns at design-time, select the control and click the button " & _
        "next to the ""GridColumns"" property."
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            '_flex
            '
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width" & _
        ":20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "7{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "8{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "9{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
            Me._flex.Location = New System.Drawing.Point(5, 73)
            Me._flex.Name = "_flex"
            Me._flex.Rows.DefaultSize = 21
            Me._flex.Size = New System.Drawing.Size(470, 210)
            Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
            Me._flex.TabIndex = 3
            '
            'UserControl1
            '
            Me.BackColor = System.Drawing.SystemColors.Desktop
            Me.Controls.Add(Me._flex)
            Me.Controls.Add(Me.label1)
            Me.Name = "UserControl1"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.Size = New System.Drawing.Size(480, 288)
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        'expose grid columns as a property so user can edit them at design time
        'must be get/set property, although the set will only be used during 
        'initialization
        Public Property GridColumns() As C1.Win.C1FlexGrid.ColumnCollection
            Get
                Return _flex.Cols
            End Get
            Set(ByVal Value As C1.Win.C1FlexGrid.ColumnCollection)
                _flex.Cols = Value
            End Set
        End Property

        'ISupportInitialize implementation extends initialization process to the 
        'contained grid
        Sub BeginInit() Implements ISupportInitialize.BeginInit
            _flex.BeginInit()
        End Sub

        Sub EndInit() Implements ISupportInitialize.EndInit
            _flex.EndInit()
        End Sub

        'grid columns are persisted via hidden ColumnInfo Property
        <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)> _
        Public Property ColumnInfo() As String
            Get
                Return _flex.ColumnInfo
            End Get
            Set(ByVal Value As String)
                _flex.ColumnInfo = Value

            End Set
        End Property
    End Class
End Namespace