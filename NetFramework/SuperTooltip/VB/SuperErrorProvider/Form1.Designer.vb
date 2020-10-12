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
        Me.epInfo = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.c1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.epWarning = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.epComplete = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.epError = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.navigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New System.Data.DataSet
        Me.bindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.bindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.bindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.bindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.bindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.epDataBound = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnClearError = New System.Windows.Forms.Button
        Me.txtZip = New System.Windows.Forms.TextBox
        Me.label10 = New System.Windows.Forms.Label
        Me.cbField = New System.Windows.Forms.ComboBox
        Me.btnSetError = New System.Windows.Forms.Button
        Me.txtState = New System.Windows.Forms.TextBox
        Me.label9 = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.label7 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        CType(Me.epInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navigator.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epDataBound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'epInfo
        '
        Me.epInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epInfo.ContainerControl = Me
        Me.epInfo.Image = CType(resources.GetObject("epInfo.Image"), System.Drawing.Image)
        Me.epInfo.ToolTip = Me.c1SuperTooltip1
        '
        'c1SuperTooltip1
        '
        Me.c1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.c1SuperTooltip1.Images.Add(New C1.Win.C1SuperTooltip.ImageEntry("Info2.png", CType(resources.GetObject("c1SuperTooltip1.Images"), System.Drawing.Image)))
        Me.c1SuperTooltip1.Images.Add(New C1.Win.C1SuperTooltip.ImageEntry("Cancel2.png", CType(resources.GetObject("c1SuperTooltip1.Images1"), System.Drawing.Image)))
        '
        'epWarning
        '
        Me.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epWarning.ContainerControl = Me
        Me.epWarning.Image = CType(resources.GetObject("epWarning.Image"), System.Drawing.Image)
        Me.epWarning.ToolTip = Me.c1SuperTooltip1
        '
        'epComplete
        '
        Me.epComplete.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.epComplete.ContainerControl = Me
        Me.epComplete.Image = CType(resources.GetObject("epComplete.Image"), System.Drawing.Image)
        Me.epComplete.ImageHot = CType(resources.GetObject("epComplete.ImageHot"), System.Drawing.Image)
        Me.epComplete.ToolTip = Me.c1SuperTooltip1
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        Me.epError.ToolTip = Me.c1SuperTooltip1
        '
        'navigator
        '
        Me.navigator.AddNewItem = Nothing
        Me.navigator.BindingSource = Me.bs
        Me.navigator.CountItem = Me.bindingNavigatorCountItem
        Me.navigator.DeleteItem = Nothing
        Me.navigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.navigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bindingNavigatorMoveFirstItem, Me.bindingNavigatorMovePreviousItem, Me.bindingNavigatorSeparator, Me.bindingNavigatorPositionItem, Me.bindingNavigatorCountItem, Me.bindingNavigatorSeparator1, Me.bindingNavigatorMoveNextItem, Me.bindingNavigatorMoveLastItem, Me.bindingNavigatorSeparator2})
        Me.navigator.Location = New System.Drawing.Point(3, 263)
        Me.navigator.MoveFirstItem = Me.bindingNavigatorMoveFirstItem
        Me.navigator.MoveLastItem = Me.bindingNavigatorMoveLastItem
        Me.navigator.MoveNextItem = Me.bindingNavigatorMoveNextItem
        Me.navigator.MovePreviousItem = Me.bindingNavigatorMovePreviousItem
        Me.navigator.Name = "navigator"
        Me.navigator.PositionItem = Me.bindingNavigatorPositionItem
        Me.navigator.Size = New System.Drawing.Size(457, 25)
        Me.navigator.TabIndex = 17
        Me.navigator.Text = "bindingNavigator1"
        '
        'bs
        '
        Me.bs.DataSource = Me.ds
        Me.bs.Position = 0
        '
        'ds
        '
        Me.ds.DataSetName = "NewDataSet"
        '
        'bindingNavigatorCountItem
        '
        Me.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem"
        Me.bindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.bindingNavigatorCountItem.Text = "of {0}"
        Me.bindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'bindingNavigatorMoveFirstItem
        '
        Me.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("bindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem"
        Me.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'bindingNavigatorMovePreviousItem
        '
        Me.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("bindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem"
        Me.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'bindingNavigatorSeparator
        '
        Me.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator"
        Me.bindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorPositionItem
        '
        Me.bindingNavigatorPositionItem.AccessibleName = "Position"
        Me.bindingNavigatorPositionItem.AutoSize = False
        Me.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem"
        Me.bindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.bindingNavigatorPositionItem.Text = "1"
        Me.bindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'bindingNavigatorSeparator1
        '
        Me.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1"
        Me.bindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bindingNavigatorMoveNextItem
        '
        Me.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveNextItem.Image = CType(resources.GetObject("bindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem"
        Me.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveNextItem.Text = "Move next"
        '
        'bindingNavigatorMoveLastItem
        '
        Me.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bindingNavigatorMoveLastItem.Image = CType(resources.GetObject("bindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem"
        Me.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.bindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.bindingNavigatorMoveLastItem.Text = "Move last"
        '
        'bindingNavigatorSeparator2
        '
        Me.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2"
        Me.bindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'epDataBound
        '
        Me.epDataBound.Antiphased = False
        Me.epDataBound.ContainerControl = Me
        Me.epDataBound.DataSource = Me.bs
        Me.epDataBound.ToolTip = Me.c1SuperTooltip1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(471, 317)
        Me.TabControl1.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnClearError)
        Me.TabPage1.Controls.Add(Me.txtZip)
        Me.TabPage1.Controls.Add(Me.label10)
        Me.TabPage1.Controls.Add(Me.cbField)
        Me.TabPage1.Controls.Add(Me.btnSetError)
        Me.TabPage1.Controls.Add(Me.txtState)
        Me.TabPage1.Controls.Add(Me.label9)
        Me.TabPage1.Controls.Add(Me.txtCity)
        Me.TabPage1.Controls.Add(Me.label8)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.label7)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.label6)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Controls.Add(Me.label5)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.label4)
        Me.TabPage1.Controls.Add(Me.navigator)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(463, 291)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Bound Errors"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.textBox3)
        Me.TabPage2.Controls.Add(Me.label3)
        Me.TabPage2.Controls.Add(Me.textBox2)
        Me.TabPage2.Controls.Add(Me.label2)
        Me.TabPage2.Controls.Add(Me.textBox1)
        Me.TabPage2.Controls.Add(Me.label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(463, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Informational Tips"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClearError
        '
        Me.btnClearError.Location = New System.Drawing.Point(319, 20)
        Me.btnClearError.Name = "btnClearError"
        Me.btnClearError.Size = New System.Drawing.Size(87, 21)
        Me.btnClearError.TabIndex = 34
        Me.btnClearError.Text = "Clear Error"
        Me.btnClearError.UseVisualStyleBackColor = True
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(134, 217)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(167, 21)
        Me.txtZip.TabIndex = 33
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(52, 220)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(25, 13)
        Me.label10.TabIndex = 32
        Me.label10.Text = "Zip:"
        '
        'cbField
        '
        Me.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbField.FormattingEnabled = True
        Me.cbField.Items.AddRange(New Object() {"FirstName", "LastName", "Phone", "Address", "City", "State", "Zip"})
        Me.cbField.Location = New System.Drawing.Point(40, 20)
        Me.cbField.Name = "cbField"
        Me.cbField.Size = New System.Drawing.Size(153, 21)
        Me.cbField.TabIndex = 18
        '
        'btnSetError
        '
        Me.btnSetError.Location = New System.Drawing.Point(231, 20)
        Me.btnSetError.Name = "btnSetError"
        Me.btnSetError.Size = New System.Drawing.Size(82, 21)
        Me.btnSetError.TabIndex = 19
        Me.btnSetError.Text = "Set Error"
        Me.btnSetError.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(134, 190)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(238, 21)
        Me.txtState.TabIndex = 31
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(52, 193)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(37, 13)
        Me.label9.TabIndex = 30
        Me.label9.Text = "State:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(134, 163)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(238, 21)
        Me.txtCity.TabIndex = 29
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(52, 166)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(30, 13)
        Me.label8.TabIndex = 28
        Me.label8.Text = "City:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(134, 136)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(238, 21)
        Me.txtAddress.TabIndex = 27
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(52, 139)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(50, 13)
        Me.label7.TabIndex = 26
        Me.label7.Text = "Address:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(134, 109)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 21)
        Me.txtPhone.TabIndex = 25
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(52, 112)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(41, 13)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Phone:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(134, 82)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(238, 21)
        Me.txtLastName.TabIndex = 23
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(52, 85)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(61, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(134, 55)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(238, 21)
        Me.txtFirstName.TabIndex = 21
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(52, 58)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(62, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "First Name:"
        '
        'textBox3
        '
        Me.epInfo.SetError(Me.textBox3, resources.GetString("textBox3.Error"))
        Me.epWarning.SetIconPadding(Me.textBox3, 5)
        Me.epError.SetIconPadding(Me.textBox3, 5)
        Me.epInfo.SetIconPadding(Me.textBox3, 5)
        Me.epComplete.SetIconPadding(Me.textBox3, 5)
        Me.textBox3.Location = New System.Drawing.Point(130, 176)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(249, 21)
        Me.textBox3.TabIndex = 14
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(57, 179)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Third:"
        '
        'textBox2
        '
        Me.epInfo.SetError(Me.textBox2, resources.GetString("textBox2.Error"))
        Me.epWarning.SetIconPadding(Me.textBox2, 5)
        Me.epError.SetIconPadding(Me.textBox2, 5)
        Me.epInfo.SetIconPadding(Me.textBox2, 5)
        Me.epComplete.SetIconPadding(Me.textBox2, 5)
        Me.textBox2.Location = New System.Drawing.Point(130, 115)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(249, 21)
        Me.textBox2.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(56, 118)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Second:"
        '
        'textBox1
        '
        Me.epInfo.SetError(Me.textBox1, resources.GetString("textBox1.Error"))
        Me.epWarning.SetIconPadding(Me.textBox1, 5)
        Me.epError.SetIconPadding(Me.textBox1, 5)
        Me.epInfo.SetIconPadding(Me.textBox1, 5)
        Me.epComplete.SetIconPadding(Me.textBox1, 5)
        Me.textBox1.Location = New System.Drawing.Point(130, 54)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(249, 21)
        Me.textBox1.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(57, 57)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "First:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 317)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "C1SuperErrorProvider"
        CType(Me.epInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epComplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navigator.ResumeLayout(False)
        Me.navigator.PerformLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epDataBound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents epInfo As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents navigator As System.Windows.Forms.BindingNavigator
    Private WithEvents bs As System.Windows.Forms.BindingSource
    Private WithEvents ds As System.Data.DataSet
    Private WithEvents bindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Private WithEvents bindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Private WithEvents bindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Private WithEvents bindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents bindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Private WithEvents bindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents bindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Private WithEvents bindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Private WithEvents bindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents c1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Private WithEvents epWarning As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents epComplete As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents epError As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Private WithEvents epDataBound As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents btnClearError As System.Windows.Forms.Button
    Private WithEvents txtZip As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents cbField As System.Windows.Forms.ComboBox
    Private WithEvents btnSetError As System.Windows.Forms.Button
    Private WithEvents txtState As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtCity As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtLastName As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
