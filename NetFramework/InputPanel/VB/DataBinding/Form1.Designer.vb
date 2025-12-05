<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NWINDDataSet = New DataBinding.NWINDDataSet
        Me.EmployeesTableAdapter = New DataBinding.NWINDDataSetTableAdapters.EmployeesTableAdapter
        Me.c1InputPanel1 = New C1.Win.InputPanel.C1InputPanel
        Me.InputGroupHeader4 = New C1.Win.InputPanel.InputGroupHeader
        Me.InputDataNavigator1 = New C1.Win.InputPanel.InputDataNavigator
        Me.inputGroupHeader1 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel1 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox1 = New C1.Win.InputPanel.InputTextBox
        Me.inputTextBox2 = New C1.Win.InputPanel.InputTextBox
        Me.inputComboBox2 = New C1.Win.InputPanel.InputComboBox
        Me.inputOption1 = New C1.Win.InputPanel.InputOption
        Me.inputOption2 = New C1.Win.InputPanel.InputOption
        Me.inputLabel2 = New C1.Win.InputPanel.InputLabel
        Me.inputDatePicker1 = New C1.Win.InputPanel.InputDatePicker
        Me.inputLabel9 = New C1.Win.InputPanel.InputLabel
        Me.inputTimePicker1 = New C1.Win.InputPanel.InputTimePicker
        Me.inputImage1 = New C1.Win.InputPanel.InputImage
        Me.inputGroupHeader2 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel3 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox3 = New C1.Win.InputPanel.InputTextBox
        Me.inputLabel4 = New C1.Win.InputPanel.InputLabel
        Me.inputDatePicker2 = New C1.Win.InputPanel.InputDatePicker
        Me.inputLabel5 = New C1.Win.InputPanel.InputLabel
        Me.inputComboBox1 = New C1.Win.InputPanel.InputComboBox
        Me.inputGroupHeader3 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel6 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox5 = New C1.Win.InputPanel.InputTextBox
        Me.inputLabel7 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox6 = New C1.Win.InputPanel.InputTextBox
        Me.inputTextBox7 = New C1.Win.InputPanel.InputTextBox
        Me.inputLabel8 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox8 = New C1.Win.InputPanel.InputTextBox
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NWINDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Employees"
        Me.BindingSource1.DataSource = Me.NWINDDataSet
        '
        'NWINDDataSet
        '
        Me.NWINDDataSet.DataSetName = "NWINDDataSet"
        Me.NWINDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel1.Items.Add(Me.InputGroupHeader4)
        Me.c1InputPanel1.Items.Add(Me.InputDataNavigator1)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel1)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox1)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox2)
        Me.c1InputPanel1.Items.Add(Me.inputComboBox2)
        Me.c1InputPanel1.Items.Add(Me.inputLabel2)
        Me.c1InputPanel1.Items.Add(Me.inputDatePicker1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel9)
        Me.c1InputPanel1.Items.Add(Me.inputTimePicker1)
        Me.c1InputPanel1.Items.Add(Me.inputImage1)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader2)
        Me.c1InputPanel1.Items.Add(Me.inputLabel3)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox3)
        Me.c1InputPanel1.Items.Add(Me.inputLabel4)
        Me.c1InputPanel1.Items.Add(Me.inputDatePicker2)
        Me.c1InputPanel1.Items.Add(Me.inputLabel5)
        Me.c1InputPanel1.Items.Add(Me.inputComboBox1)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader3)
        Me.c1InputPanel1.Items.Add(Me.inputLabel6)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox5)
        Me.c1InputPanel1.Items.Add(Me.inputLabel7)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox6)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox7)
        Me.c1InputPanel1.Items.Add(Me.inputLabel8)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox8)
        Me.c1InputPanel1.Location = New System.Drawing.Point(0, 2)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(534, 486)
        Me.c1InputPanel1.SmoothScrolling = True
        Me.c1InputPanel1.TabIndex = 1
        '
        'InputGroupHeader4
        '
        Me.InputGroupHeader4.Name = "InputGroupHeader4"
        Me.InputGroupHeader4.Text = "Employees"
        '
        'InputDataNavigator1
        '
        Me.InputDataNavigator1.AddNewImage = CType(resources.GetObject("InputDataNavigator1.AddNewImage"), System.Drawing.Image)
        Me.InputDataNavigator1.AddNewToolTip = "Add New"
        Me.InputDataNavigator1.ApplyImage = CType(resources.GetObject("InputDataNavigator1.ApplyImage"), System.Drawing.Image)
        Me.InputDataNavigator1.ApplyToolTip = "Apply Changes"
        Me.InputDataNavigator1.CancelImage = CType(resources.GetObject("InputDataNavigator1.CancelImage"), System.Drawing.Image)
        Me.InputDataNavigator1.CancelToolTip = "Cancel Changes"
        Me.InputDataNavigator1.DataSource = Me.BindingSource1
        Me.InputDataNavigator1.DeleteImage = CType(resources.GetObject("InputDataNavigator1.DeleteImage"), System.Drawing.Image)
        Me.InputDataNavigator1.DeleteToolTip = "Delete"
        Me.InputDataNavigator1.MoveFirstImage = CType(resources.GetObject("InputDataNavigator1.MoveFirstImage"), System.Drawing.Image)
        Me.InputDataNavigator1.MoveFirstToolTip = "Move First"
        Me.InputDataNavigator1.MoveLastImage = CType(resources.GetObject("InputDataNavigator1.MoveLastImage"), System.Drawing.Image)
        Me.InputDataNavigator1.MoveLastToolTip = "Move Last"
        Me.InputDataNavigator1.MoveNextImage = CType(resources.GetObject("InputDataNavigator1.MoveNextImage"), System.Drawing.Image)
        Me.InputDataNavigator1.MoveNextToolTip = "Move Next"
        Me.InputDataNavigator1.MovePreviousImage = CType(resources.GetObject("InputDataNavigator1.MovePreviousImage"), System.Drawing.Image)
        Me.InputDataNavigator1.MovePreviousToolTip = "Move Previous"
        Me.InputDataNavigator1.Name = "InputDataNavigator1"
        Me.InputDataNavigator1.ReloadImage = CType(resources.GetObject("InputDataNavigator1.ReloadImage"), System.Drawing.Image)
        Me.InputDataNavigator1.ReloadToolTip = "Reload Data"
        Me.InputDataNavigator1.SaveImage = CType(resources.GetObject("InputDataNavigator1.SaveImage"), System.Drawing.Image)
        Me.InputDataNavigator1.SaveToolTip = "Save Data"
        Me.InputDataNavigator1.ShowReloadButton = True
        Me.InputDataNavigator1.ShowSaveButton = True
        '
        'inputGroupHeader1
        '
        Me.inputGroupHeader1.Name = "inputGroupHeader1"
        Me.inputGroupHeader1.Text = "Personal Info"
        '
        'inputLabel1
        '
        Me.inputLabel1.Name = "inputLabel1"
        Me.inputLabel1.Text = "Name: "
        '
        'inputTextBox1
        '
        Me.inputTextBox1.Break = C1.Win.InputPanel.BreakType.None
        Me.inputTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "FirstName", True))
        Me.inputTextBox1.Name = "inputTextBox1"
        Me.inputTextBox1.Width = 120
        '
        'inputTextBox2
        '
        Me.inputTextBox2.Break = C1.Win.InputPanel.BreakType.None
        Me.inputTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "LastName", True))
        Me.inputTextBox2.Name = "inputTextBox2"
        Me.inputTextBox2.Width = 120
        '
        'inputComboBox2
        '
        Me.inputComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "TitleOfCourtesy", True))
        Me.inputComboBox2.Items.Add(Me.inputOption1)
        Me.inputComboBox2.Items.Add(Me.inputOption2)
        Me.inputComboBox2.Name = "inputComboBox2"
        Me.inputComboBox2.Width = 60
        '
        'inputOption1
        '
        Me.inputOption1.Name = "inputOption1"
        Me.inputOption1.Text = "Mr."
        '
        'inputOption2
        '
        Me.inputOption2.Name = "inputOption2"
        Me.inputOption2.Text = "Ms."
        '
        'inputLabel2
        '
        Me.inputLabel2.Name = "inputLabel2"
        Me.inputLabel2.Text = "Birth Date:"
        '
        'inputDatePicker1
        '
        Me.inputDatePicker1.Break = C1.Win.InputPanel.BreakType.None
        Me.inputDatePicker1.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "BirthDate", True))
        Me.inputDatePicker1.Name = "inputDatePicker1"
        '
        'inputLabel9
        '
        Me.inputLabel9.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        Me.inputLabel9.Name = "inputLabel9"
        Me.inputLabel9.Text = "Birth Time:"
        Me.inputLabel9.Width = 68
        '
        'inputTimePicker1
        '
        Me.inputTimePicker1.Break = C1.Win.InputPanel.BreakType.Column
        Me.inputTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "BirthDate", True))
        Me.inputTimePicker1.Name = "inputTimePicker1"
        '
        'inputImage1
        '
        Me.inputImage1.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "Photo", True))
        Me.inputImage1.Height = 155
        Me.inputImage1.Image = CType(resources.GetObject("inputImage1.Image"), System.Drawing.Image)
        Me.inputImage1.Name = "inputImage1"
        Me.inputImage1.Width = 155
        '
        'inputGroupHeader2
        '
        Me.inputGroupHeader2.Name = "inputGroupHeader2"
        Me.inputGroupHeader2.Text = "Job Information"
        '
        'inputLabel3
        '
        Me.inputLabel3.Name = "inputLabel3"
        Me.inputLabel3.Text = "Title:"
        Me.inputLabel3.Width = 80
        '
        'inputTextBox3
        '
        Me.inputTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "Title", True))
        Me.inputTextBox3.Name = "inputTextBox3"
        Me.inputTextBox3.Width = 210
        '
        'inputLabel4
        '
        Me.inputLabel4.Name = "inputLabel4"
        Me.inputLabel4.Text = "Hire Date:"
        Me.inputLabel4.Width = 80
        '
        'inputDatePicker2
        '
        Me.inputDatePicker2.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "HireDate", True))
        Me.inputDatePicker2.Name = "inputDatePicker2"
        '
        'inputLabel5
        '
        Me.inputLabel5.Name = "inputLabel5"
        Me.inputLabel5.Text = "Reports To:"
        Me.inputLabel5.Width = 80
        '
        'inputComboBox1
        '
        Me.inputComboBox1.AutoCompleteMode = C1.Win.InputPanel.InputAutoCompleteMode.Suggest
        Me.inputComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource1, "ReportsTo", True))
        Me.inputComboBox1.DataSource = Me.BindingSource1
        Me.inputComboBox1.DisplayMember = "LastName"
        Me.inputComboBox1.FormattingEnabled = True
        Me.inputComboBox1.Name = "inputComboBox1"
        Me.inputComboBox1.UpdateListPosition = False
        Me.inputComboBox1.ValueMember = "EmployeeID"
        Me.inputComboBox1.Width = 186
        '
        'inputGroupHeader3
        '
        Me.inputGroupHeader3.Name = "inputGroupHeader3"
        Me.inputGroupHeader3.Text = "Address"
        '
        'inputLabel6
        '
        Me.inputLabel6.Height = 40
        Me.inputLabel6.Name = "inputLabel6"
        Me.inputLabel6.Text = "Street:"
        Me.inputLabel6.Width = 80
        '
        'inputTextBox5
        '
        Me.inputTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "Address", True))
        Me.inputTextBox5.Height = 40
        Me.inputTextBox5.Multiline = True
        Me.inputTextBox5.Name = "inputTextBox5"
        Me.inputTextBox5.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Spread
        Me.inputTextBox5.Width = 272
        '
        'inputLabel7
        '
        Me.inputLabel7.Name = "inputLabel7"
        Me.inputLabel7.Text = "City, Region:"
        Me.inputLabel7.Width = 80
        '
        'inputTextBox6
        '
        Me.inputTextBox6.Break = C1.Win.InputPanel.BreakType.None
        Me.inputTextBox6.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "City", True))
        Me.inputTextBox6.Name = "inputTextBox6"
        Me.inputTextBox6.Width = 182
        '
        'inputTextBox7
        '
        Me.inputTextBox7.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "Region", True))
        Me.inputTextBox7.Name = "inputTextBox7"
        Me.inputTextBox7.Width = 85
        '
        'inputLabel8
        '
        Me.inputLabel8.Name = "inputLabel8"
        Me.inputLabel8.Text = "Country:"
        Me.inputLabel8.Width = 80
        '
        'inputTextBox8
        '
        Me.inputTextBox8.DataBindings.Add(New System.Windows.Forms.Binding("BoundValue", Me.BindingSource1, "Country", True))
        Me.inputTextBox8.Name = "inputTextBox8"
        Me.inputTextBox8.Width = 182
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 491)
        Me.Controls.Add(Me.c1InputPanel1)
        Me.Name = "Form1"
        Me.Text = "DataBinding Sample"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NWINDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NWINDDataSet As DataBinding.NWINDDataSet
    Friend WithEvents EmployeesTableAdapter As DataBinding.NWINDDataSetTableAdapters.EmployeesTableAdapter
    Private WithEvents c1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents inputGroupHeader1 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel1 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox1 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputTextBox2 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputComboBox2 As C1.Win.InputPanel.InputComboBox
    Private WithEvents inputOption1 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption2 As C1.Win.InputPanel.InputOption
    Private WithEvents inputLabel2 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputDatePicker1 As C1.Win.InputPanel.InputDatePicker
    Private WithEvents inputLabel9 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTimePicker1 As C1.Win.InputPanel.InputTimePicker
    Private WithEvents inputImage1 As C1.Win.InputPanel.InputImage
    Private WithEvents inputGroupHeader2 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel3 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox3 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputLabel4 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputDatePicker2 As C1.Win.InputPanel.InputDatePicker
    Private WithEvents inputLabel5 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputComboBox1 As C1.Win.InputPanel.InputComboBox
    Private WithEvents inputGroupHeader3 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel6 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox5 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputLabel7 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox6 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputTextBox7 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputLabel8 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox8 As C1.Win.InputPanel.InputTextBox
    Friend WithEvents InputDataNavigator1 As C1.Win.InputPanel.InputDataNavigator
    Friend WithEvents InputGroupHeader4 As C1.Win.InputPanel.InputGroupHeader

End Class
