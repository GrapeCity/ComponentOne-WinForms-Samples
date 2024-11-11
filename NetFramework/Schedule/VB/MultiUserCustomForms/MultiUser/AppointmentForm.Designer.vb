Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
    Inherits C1RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentForm))
        Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu
        Me.ribbonListItem1 = New C1.Win.Ribbon.RibbonListItem
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat
        Me._btnSaveAs = New C1.Win.Ribbon.RibbonButton
        Me._rbDelete = New C1.Win.Ribbon.RibbonButton
        Me._btnPrint = New C1.Win.Ribbon.RibbonButton
        Me._btnPreview = New C1.Win.Ribbon.RibbonButton
        Me._rbSaveClose = New C1.Win.Ribbon.RibbonButton
        Me._toggleHighImportance = New C1.Win.Ribbon.RibbonToggleButton
        Me._toggleLowImportance = New C1.Win.Ribbon.RibbonToggleButton
        Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab
        Me.ribbonGroup1 = New C1.Win.Ribbon.RibbonGroup
        Me.ribbonGroup2 = New C1.Win.Ribbon.RibbonGroup
        Me.ribbonToolBar1 = New C1.Win.Ribbon.RibbonToolBar
        Me.ribbonLabel1 = New C1.Win.Ribbon.RibbonLabel
        Me._cmbStatus = New RibbonControls.ComboBoxHost
        Me._cmbReminder = New C1.Win.Ribbon.RibbonComboBox
        Me._btnRecurrence = New C1.Win.Ribbon.RibbonToggleButton
        Me.ribbonGroup4 = New C1.Win.Ribbon.RibbonGroup
        Me.ribbonToolBar2 = New C1.Win.Ribbon.RibbonToolBar
        Me.ribbonLabel2 = New C1.Win.Ribbon.RibbonLabel
        Me._cmbLabel = New RibbonControls.ComboBoxHost
        Me.ribbonToolBar3 = New C1.Win.Ribbon.RibbonToolBar
        Me._togglePrivate = New C1.Win.Ribbon.RibbonToggleButton
        Me.ribbonGroup3 = New C1.Win.Ribbon.RibbonGroup
        Me._galleryZoom = New C1.Win.Ribbon.RibbonGallery
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label9 = New System.Windows.Forms.Label
        Me._lstClients = New System.Windows.Forms.CheckedListBox
        Me.label6 = New System.Windows.Forms.Label
        Me._lstCategories = New System.Windows.Forms.CheckedListBox
        Me._cmbOwner = New System.Windows.Forms.ComboBox
        Me.label5 = New System.Windows.Forms.Label
        Me._pnPattern = New System.Windows.Forms.Panel
        Me.label7 = New System.Windows.Forms.Label
        Me._lblPattern = New System.Windows.Forms.Label
        Me._txtSubject = New System.Windows.Forms.TextBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me._pnTime = New System.Windows.Forms.Panel
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me._chkAllDay = New System.Windows.Forms.CheckBox
        Me._dpStartDate = New System.Windows.Forms.DateTimePicker
        Me._dpEndTime = New System.Windows.Forms.DateTimePicker
        Me._dpEndDate = New System.Windows.Forms.DateTimePicker
        Me._dpStartTime = New System.Windows.Forms.DateTimePicker
        Me.label2 = New System.Windows.Forms.Label
        Me._txtBody = New System.Windows.Forms.RichTextBox
        Me._cmbLocation = New System.Windows.Forms.ComboBox
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me._pnPattern.SuspendLayout()
        Me._pnTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1Ribbon1
        '
        Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
        Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
        Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.c1Ribbon1.Name = "c1Ribbon1"
        Me.c1Ribbon1.QatHolder = Me.ribbonQat1
        Me.c1Ribbon1.Size = New System.Drawing.Size(646, 156)
        Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
        '
        'ribbonApplicationMenu1
        '
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        Me.ribbonApplicationMenu1.RightPaneItems.Add(Me.ribbonListItem1)
        Me.ribbonApplicationMenu1.Visible = False
        '
        'ribbonListItem1
        '
        Me.ribbonListItem1.Name = "ribbonListItem1"
        '
        'ribbonConfigToolBar1
        '
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        '
        'ribbonQat1
        '
        Me.ribbonQat1.HotItemLinks.Add(Me._btnSaveAs)
        Me.ribbonQat1.HotItemLinks.Add(Me._rbDelete)
        Me.ribbonQat1.HotItemLinks.Add(Me._btnPrint)
        Me.ribbonQat1.HotItemLinks.Add(Me._btnPreview)
        Me.ribbonQat1.ItemLinks.Add(Me._rbSaveClose)
        Me.ribbonQat1.ItemLinks.Add(Me._toggleHighImportance)
        Me.ribbonQat1.ItemLinks.Add(Me._toggleLowImportance)
        Me.ribbonQat1.ItemLinks.Add(Me._btnPreview)
        Me.ribbonQat1.ItemLinks.Add(Me._rbDelete)
        Me.ribbonQat1.Name = "ribbonQat1"
        '
        '_btnSaveAs
        '
        Me._btnSaveAs.Name = "_btnSaveAs"
        Me._btnSaveAs.Text = "Save As..."
        Me._btnSaveAs.ToolTip = "Save current item to file."
        '
        '_rbDelete
        '
        Me._rbDelete.LargeImage = CType(resources.GetObject("_rbDelete.LargeImage"), System.Drawing.Image)
        Me._rbDelete.Name = "_rbDelete"
        Me._rbDelete.SmallImage = CType(resources.GetObject("_rbDelete.SmallImage"), System.Drawing.Image)
        Me._rbDelete.Text = "Delete"
        Me._rbDelete.ToolTip = "Delete"
        '
        '_btnPrint
        '
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.SmallImage = CType(resources.GetObject("_btnPrint.SmallImage"), System.Drawing.Image)
        Me._btnPrint.Text = "Print"
        Me._btnPrint.ToolTip = "Print current item."
        '
        '_btnPreview
        '
        Me._btnPreview.Name = "_btnPreview"
        Me._btnPreview.SmallImage = CType(resources.GetObject("_btnPreview.SmallImage"), System.Drawing.Image)
        Me._btnPreview.Text = "Preview"
        Me._btnPreview.ToolTip = "Preview current item before printing."
        '
        '_rbSaveClose
        '
        Me._rbSaveClose.LargeImage = CType(resources.GetObject("_rbSaveClose.LargeImage"), System.Drawing.Image)
        Me._rbSaveClose.Name = "_rbSaveClose"
        Me._rbSaveClose.SmallImage = CType(resources.GetObject("_rbSaveClose.SmallImage"), System.Drawing.Image)
        Me._rbSaveClose.Text = "Save && Close"
        Me._rbSaveClose.ToolTip = "Save and close"
        '
        '_toggleHighImportance
        '
        Me._toggleHighImportance.LargeImage = CType(resources.GetObject("_toggleHighImportance.LargeImage"), System.Drawing.Image)
        Me._toggleHighImportance.Name = "_toggleHighImportance"
        Me._toggleHighImportance.SmallImage = CType(resources.GetObject("_toggleHighImportance.SmallImage"), System.Drawing.Image)
        Me._toggleHighImportance.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me._toggleHighImportance.ToolTip = "Hight Importance"
        '
        '_toggleLowImportance
        '
        Me._toggleLowImportance.LargeImage = CType(resources.GetObject("_toggleLowImportance.LargeImage"), System.Drawing.Image)
        Me._toggleLowImportance.Name = "_toggleLowImportance"
        Me._toggleLowImportance.SmallImage = CType(resources.GetObject("_toggleLowImportance.SmallImage"), System.Drawing.Image)
        Me._toggleLowImportance.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me._toggleLowImportance.ToolTip = "Low Importance"
        '
        'ribbonTab1
        '
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup2)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup4)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup3)
        Me.ribbonTab1.Name = "ribbonTab1"
        Me.ribbonTab1.Text = "Appointment"
        '
        'ribbonGroup1
        '
        Me.ribbonGroup1.Items.Add(Me._rbSaveClose)
        Me.ribbonGroup1.Items.Add(Me._rbDelete)
        Me.ribbonGroup1.Items.Add(Me._btnSaveAs)
        Me.ribbonGroup1.Items.Add(Me._btnPrint)
        Me.ribbonGroup1.Items.Add(Me._btnPreview)
        Me.ribbonGroup1.Name = "ribbonGroup1"
        Me.ribbonGroup1.Text = "Actions"
        '
        'ribbonGroup2
        '
        Me.ribbonGroup2.Items.Add(Me.ribbonToolBar1)
        Me.ribbonGroup2.Items.Add(Me._cmbReminder)
        Me.ribbonGroup2.Items.Add(Me._btnRecurrence)
        Me.ribbonGroup2.Name = "ribbonGroup2"
        Me.ribbonGroup2.Text = "Options"
        '
        'ribbonToolBar1
        '
        Me.ribbonToolBar1.Items.Add(Me.ribbonLabel1)
        Me.ribbonToolBar1.Items.Add(Me._cmbStatus)
        Me.ribbonToolBar1.Name = "ribbonToolBar1"
        Me.ribbonToolBar1.ToolTip = "Change how the time on this item is marked on your calendar."
        '
        'ribbonLabel1
        '
        Me.ribbonLabel1.Name = "ribbonLabel1"
        Me.ribbonLabel1.SmallImage = CType(resources.GetObject("ribbonLabel1.SmallImage"), System.Drawing.Image)
        Me.ribbonLabel1.Text = "Show As:"
        '
        '_cmbStatus
        '
        Me._cmbStatus.BackColor = System.Drawing.SystemColors.Window
        Me._cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me._cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbStatus.Name = "_cmbStatus"
        Me._cmbStatus.Width = 100
        '
        '_cmbReminder
        '
        Me._cmbReminder.AutoCompleteMode = C1.Win.Ribbon.ComboBoxAutoCompleteMode.Suggest
        Me._cmbReminder.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me._cmbReminder.GripHandleVisible = True
        Me._cmbReminder.Label = "Reminder:"
        Me._cmbReminder.Name = "_cmbReminder"
        Me._cmbReminder.SmallImage = CType(resources.GetObject("_cmbReminder.SmallImage"), System.Drawing.Image)
        Me._cmbReminder.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.TextAlwaysVisible
        Me._cmbReminder.ToolTip = "Choose when to be reminded of this item."
        '
        '_btnRecurrence
        '
        Me._btnRecurrence.Description = "Make this item recurring, or edit the recurrence pattern."
        Me._btnRecurrence.LargeImage = CType(resources.GetObject("_btnRecurrence.LargeImage"), System.Drawing.Image)
        Me._btnRecurrence.Name = "_btnRecurrence"
        Me._btnRecurrence.SmallImage = CType(resources.GetObject("_btnRecurrence.SmallImage"), System.Drawing.Image)
        Me._btnRecurrence.Text = "Recurrence"
        Me._btnRecurrence.TextImageRelation = C1.Win.Ribbon.TextImageRelation.ImageAboveText
        Me._btnRecurrence.ToolTip = "Recurrence"
        '
        'ribbonGroup4
        '
        Me.ribbonGroup4.Items.Add(Me.ribbonToolBar2)
        Me.ribbonGroup4.Items.Add(Me.ribbonToolBar3)
        Me.ribbonGroup4.Name = "ribbonGroup4"
        Me.ribbonGroup4.Text = "Tags"
        '
        'ribbonToolBar2
        '
        Me.ribbonToolBar2.Items.Add(Me.ribbonLabel2)
        Me.ribbonToolBar2.Items.Add(Me._cmbLabel)
        Me.ribbonToolBar2.Name = "ribbonToolBar2"
        Me.ribbonToolBar2.ToolTip = "Change how this item is labeled on your calendar."
        '
        'ribbonLabel2
        '
        Me.ribbonLabel2.Name = "ribbonLabel2"
        Me.ribbonLabel2.SmallImage = CType(resources.GetObject("ribbonLabel2.SmallImage"), System.Drawing.Image)
        Me.ribbonLabel2.Text = "Label:"
        '
        '_cmbLabel
        '
        Me._cmbLabel.BackColor = System.Drawing.SystemColors.Window
        Me._cmbLabel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me._cmbLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._cmbLabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me._cmbLabel.Name = "_cmbLabel"
        Me._cmbLabel.Width = 100
        '
        'ribbonToolBar3
        '
        Me.ribbonToolBar3.Items.Add(Me._togglePrivate)
        Me.ribbonToolBar3.Items.Add(Me._toggleHighImportance)
        Me.ribbonToolBar3.Items.Add(Me._toggleLowImportance)
        Me.ribbonToolBar3.MarginBottom = 0
        Me.ribbonToolBar3.MarginTop = 0
        Me.ribbonToolBar3.Name = "ribbonToolBar3"
        '
        '_togglePrivate
        '
        Me._togglePrivate.LargeImage = CType(resources.GetObject("_togglePrivate.LargeImage"), System.Drawing.Image)
        Me._togglePrivate.Name = "_togglePrivate"
        Me._togglePrivate.SmallImage = CType(resources.GetObject("_togglePrivate.SmallImage"), System.Drawing.Image)
        Me._togglePrivate.ToolTip = "Private"
        '
        'ribbonGroup3
        '
        Me.ribbonGroup3.Items.Add(Me._galleryZoom)
        Me.ribbonGroup3.Name = "ribbonGroup3"
        Me.ribbonGroup3.Text = "Zoom"
        '
        '_galleryZoom
        '
        Me._galleryZoom.DropDownAlign = C1.Win.Ribbon.DropDownAlignment.Left
        Me._galleryZoom.Enabled = False
        Me._galleryZoom.Expanded = False
        Me._galleryZoom.ItemSize = New System.Drawing.Size(40, 20)
        Me._galleryZoom.LargeImage = CType(resources.GetObject("_galleryZoom.LargeImage"), System.Drawing.Image)
        Me._galleryZoom.Name = "_galleryZoom"
        Me._galleryZoom.SmallImage = CType(resources.GetObject("_galleryZoom.SmallImage"), System.Drawing.Image)
        Me._galleryZoom.Text = "Zoom"
        Me._galleryZoom.ToolTip = "Select the zoom level of the document."
        Me._galleryZoom.VisibleItems = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me._lstClients)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me._lstCategories)
        Me.panel1.Controls.Add(Me._cmbOwner)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me._pnPattern)
        Me.panel1.Controls.Add(Me._txtSubject)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me._pnTime)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me._txtBody)
        Me.panel1.Controls.Add(Me._cmbLocation)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 156)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(646, 394)
        Me.panel1.TabIndex = 19
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(13, 63)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(41, 13)
        Me.label9.TabIndex = 24
        Me.label9.Text = "&Clients:"
        '
        '_lstClients
        '
        Me._lstClients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._lstClients.FormattingEnabled = True
        Me._lstClients.Location = New System.Drawing.Point(80, 61)
        Me._lstClients.Name = "_lstClients"
        Me._lstClients.ScrollAlwaysVisible = True
        Me._lstClients.Size = New System.Drawing.Size(561, 79)
        Me._lstClients.TabIndex = 23
        '
        'label6
        '
        Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 315)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(60, 13)
        Me.label6.TabIndex = 20
        Me.label6.Text = "Cate&gories:"
        '
        '_lstCategories
        '
        Me._lstCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._lstCategories.FormattingEnabled = True
        Me._lstCategories.Location = New System.Drawing.Point(80, 312)
        Me._lstCategories.Name = "_lstCategories"
        Me._lstCategories.Size = New System.Drawing.Size(561, 79)
        Me._lstCategories.TabIndex = 19
        '
        '_cmbOwner
        '
        Me._cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbOwner.FormattingEnabled = True
        Me._cmbOwner.Location = New System.Drawing.Point(80, 7)
        Me._cmbOwner.Name = "_cmbOwner"
        Me._cmbOwner.Size = New System.Drawing.Size(200, 21)
        Me._cmbOwner.TabIndex = 18
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 10)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 13)
        Me.label5.TabIndex = 17
        Me.label5.Text = "&Manager:"
        '
        '_pnPattern
        '
        Me._pnPattern.Controls.Add(Me.label7)
        Me._pnPattern.Controls.Add(Me._lblPattern)
        Me._pnPattern.Location = New System.Drawing.Point(5, 147)
        Me._pnPattern.Name = "_pnPattern"
        Me._pnPattern.Size = New System.Drawing.Size(534, 62)
        Me._pnPattern.TabIndex = 12
        Me._pnPattern.Visible = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(7, 7)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(66, 13)
        Me.label7.TabIndex = 2
        Me.label7.Text = "Recurrence:"
        '
        '_lblPattern
        '
        Me._lblPattern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._lblPattern.Location = New System.Drawing.Point(75, 7)
        Me._lblPattern.Name = "_lblPattern"
        Me._lblPattern.Size = New System.Drawing.Size(456, 50)
        Me._lblPattern.TabIndex = 0
        Me._lblPattern.Text = "asdfgajksd ajsdhgf jasdgh jasdhgf jasdgh fjasghdf jasdghf jasghdfjasg kajdf kasj " &
            "akj kasjdfhdf jasghdf"
        '
        '_txtSubject
        '
        Me._txtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txtSubject.Location = New System.Drawing.Point(80, 35)
        Me._txtSubject.MaxLength = 255
        Me._txtSubject.Name = "_txtSubject"
        Me._txtSubject.Size = New System.Drawing.Size(561, 20)
        Me._txtSubject.TabIndex = 1
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Location = New System.Drawing.Point(5, 145)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(649, 2)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(46, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "&Subject:"
        '
        '_pnTime
        '
        Me._pnTime.Controls.Add(Me.label3)
        Me._pnTime.Controls.Add(Me.label4)
        Me._pnTime.Controls.Add(Me._chkAllDay)
        Me._pnTime.Controls.Add(Me._dpStartDate)
        Me._pnTime.Controls.Add(Me._dpEndTime)
        Me._pnTime.Controls.Add(Me._dpEndDate)
        Me._pnTime.Controls.Add(Me._dpStartTime)
        Me._pnTime.Location = New System.Drawing.Point(5, 147)
        Me._pnTime.Name = "_pnTime"
        Me._pnTime.Size = New System.Drawing.Size(534, 62)
        Me._pnTime.TabIndex = 14
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 14)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "S&tart time:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(7, 44)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "&End time:"
        '
        '_chkAllDay
        '
        Me._chkAllDay.AutoSize = True
        Me._chkAllDay.Location = New System.Drawing.Point(330, 10)
        Me._chkAllDay.Name = "_chkAllDay"
        Me._chkAllDay.Size = New System.Drawing.Size(87, 17)
        Me._chkAllDay.TabIndex = 11
        Me._chkAllDay.Text = "&All day event"
        Me._chkAllDay.UseVisualStyleBackColor = True
        '
        '_dpStartDate
        '
        Me._dpStartDate.Location = New System.Drawing.Point(75, 7)
        Me._dpStartDate.Name = "_dpStartDate"
        Me._dpStartDate.Size = New System.Drawing.Size(147, 20)
        Me._dpStartDate.TabIndex = 7
        '
        '_dpEndTime
        '
        Me._dpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me._dpEndTime.Location = New System.Drawing.Point(238, 37)
        Me._dpEndTime.Name = "_dpEndTime"
        Me._dpEndTime.ShowUpDown = True
        Me._dpEndTime.Size = New System.Drawing.Size(70, 20)
        Me._dpEndTime.TabIndex = 10
        '
        '_dpEndDate
        '
        Me._dpEndDate.Location = New System.Drawing.Point(75, 37)
        Me._dpEndDate.Name = "_dpEndDate"
        Me._dpEndDate.Size = New System.Drawing.Size(147, 20)
        Me._dpEndDate.TabIndex = 8
        '
        '_dpStartTime
        '
        Me._dpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me._dpStartTime.Location = New System.Drawing.Point(238, 7)
        Me._dpStartTime.Name = "_dpStartTime"
        Me._dpStartTime.ShowUpDown = True
        Me._dpStartTime.Size = New System.Drawing.Size(70, 20)
        Me._dpStartTime.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(297, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(51, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "&Location:"
        '
        '_txtBody
        '
        Me._txtBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._txtBody.Location = New System.Drawing.Point(3, 216)
        Me._txtBody.Name = "_txtBody"
        Me._txtBody.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me._txtBody.Size = New System.Drawing.Size(639, 90)
        Me._txtBody.TabIndex = 12
        Me._txtBody.Text = ""
        '
        '_cmbLocation
        '
        Me._cmbLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._cmbLocation.FormattingEnabled = True
        Me._cmbLocation.Location = New System.Drawing.Point(354, 7)
        Me._cmbLocation.MaxLength = 255
        Me._cmbLocation.Name = "_cmbLocation"
        Me._cmbLocation.Size = New System.Drawing.Size(287, 21)
        Me._cmbLocation.TabIndex = 4
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(646, 550)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.c1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 500)
        Me.Name = "AppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AppointmentForm"
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me._pnPattern.ResumeLayout(False)
        Me._pnPattern.PerformLayout()
        Me._pnTime.ResumeLayout(False)
        Me._pnTime.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private WithEvents ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private WithEvents ribbonListItem1 As C1.Win.Ribbon.RibbonListItem
    Private WithEvents ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private WithEvents ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private WithEvents _btnSaveAs As C1.Win.Ribbon.RibbonButton
    Private WithEvents _rbDelete As C1.Win.Ribbon.RibbonButton
    Private WithEvents _btnPrint As C1.Win.Ribbon.RibbonButton
    Private WithEvents _btnPreview As C1.Win.Ribbon.RibbonButton
    Private WithEvents _rbSaveClose As C1.Win.Ribbon.RibbonButton
    Private WithEvents _toggleHighImportance As C1.Win.Ribbon.RibbonToggleButton
    Private WithEvents _toggleLowImportance As C1.Win.Ribbon.RibbonToggleButton
    Private WithEvents ribbonTab1 As C1.Win.Ribbon.RibbonTab
    Private WithEvents ribbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents ribbonGroup2 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents ribbonToolBar1 As C1.Win.Ribbon.RibbonToolBar
    Private WithEvents ribbonLabel1 As C1.Win.Ribbon.RibbonLabel
    Private WithEvents _cmbStatus As RibbonControls.ComboBoxHost
    Private WithEvents _cmbReminder As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents _btnRecurrence As C1.Win.Ribbon.RibbonToggleButton
    Private WithEvents ribbonGroup4 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents ribbonToolBar2 As C1.Win.Ribbon.RibbonToolBar
    Private WithEvents ribbonLabel2 As C1.Win.Ribbon.RibbonLabel
    Private WithEvents _cmbLabel As RibbonControls.ComboBoxHost
    Private WithEvents ribbonToolBar3 As C1.Win.Ribbon.RibbonToolBar
    Private WithEvents _togglePrivate As C1.Win.Ribbon.RibbonToggleButton
    Private WithEvents ribbonGroup3 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents _galleryZoom As C1.Win.Ribbon.RibbonGallery
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents _lstClients As System.Windows.Forms.CheckedListBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents _lstCategories As System.Windows.Forms.CheckedListBox
    Private WithEvents _cmbOwner As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents _pnPattern As System.Windows.Forms.Panel
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents _lblPattern As System.Windows.Forms.Label
    Private WithEvents _txtSubject As System.Windows.Forms.TextBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents _pnTime As System.Windows.Forms.Panel
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents _chkAllDay As System.Windows.Forms.CheckBox
    Private WithEvents _dpStartDate As System.Windows.Forms.DateTimePicker
    Private WithEvents _dpEndTime As System.Windows.Forms.DateTimePicker
    Private WithEvents _dpEndDate As System.Windows.Forms.DateTimePicker
    Private WithEvents _dpStartTime As System.Windows.Forms.DateTimePicker
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _txtBody As System.Windows.Forms.RichTextBox
    Private WithEvents _cmbLocation As System.Windows.Forms.ComboBox
End Class
