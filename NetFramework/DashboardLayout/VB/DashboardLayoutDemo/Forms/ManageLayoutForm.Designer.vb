Namespace DashboardDemo
    Partial Public Class ManageLayoutForm
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageLayoutForm))
            Me.btnClose = New C1.Win.C1Input.C1Button()
            Me.btnRename = New C1.Win.C1Input.C1Button()
            Me.btnDelete = New C1.Win.C1Input.C1Button()
            Me.c1List1 = New C1.Win.List.C1List()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel2 = New System.Windows.Forms.Panel()
            CType((Me.btnClose), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnRename), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnDelete), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.c1List1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            Me.btnClose.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles))
            Me.btnClose.Location = New System.Drawing.Point(338, 3)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(100, 35)
            Me.btnClose.TabIndex = 0
            Me.btnClose.Text = "Close"
            Me.btnClose.UseVisualStyleBackColor = True
            AddHandler Me.btnClose.Click, New System.EventHandler(AddressOf Me.btnClose_Click)
            Me.btnRename.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.btnRename.Enabled = False
            Me.btnRename.Location = New System.Drawing.Point(3, 3)
            Me.btnRename.Name = "btnRename"
            Me.btnRename.Size = New System.Drawing.Size(100, 35)
            Me.btnRename.TabIndex = 1
            Me.btnRename.Text = "Rename"
            Me.btnRename.UseVisualStyleBackColor = True
            AddHandler Me.btnRename.Click, New System.EventHandler(AddressOf Me.btnRename_Click)
            Me.btnDelete.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)), System.Windows.Forms.AnchorStyles))
            Me.btnDelete.Enabled = False
            Me.btnDelete.Location = New System.Drawing.Point(109, 3)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(100, 35)
            Me.btnDelete.TabIndex = 2
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.UseVisualStyleBackColor = True
            AddHandler Me.btnDelete.Click, New System.EventHandler(AddressOf Me.btnDelete_Click)
            Me.c1List1.AddItemSeparator = ";"c
            Me.c1List1.Caption = "Saved Layouts:"
            Me.c1List1.ColumnHeaders = False
            Me.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
            Me.c1List1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1List1.ExtendRightColumn = True
            Me.c1List1.Images.Add((CType((resources.GetObject("c1List1.Images")), System.Drawing.Image)))
            Me.c1List1.Location = New System.Drawing.Point(0, 0)
            Me.c1List1.MatchEntryTimeout = (CLng((2000)))
            Me.c1List1.Name = "c1List1"
            Me.c1List1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
            Me.c1List1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
            Me.c1List1.PreviewInfo.ZoomFactor = 75.0R
            Me.c1List1.PrintInfo.PageSettings = (CType((resources.GetObject("c1List1.PrintInfo.PageSettings")), System.Drawing.Printing.PageSettings))
            Me.c1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None
            Me.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
            Me.c1List1.ShowHeaderCheckBox = False
            Me.c1List1.Size = New System.Drawing.Size(442, 309)
            Me.c1List1.TabIndex = 3
            Me.c1List1.Text = "c1List1"
            AddHandler Me.c1List1.SelectionChanged, New System.EventHandler(AddressOf Me.c1List1_SelectionChanged)
            Me.c1List1.PropBag = resources.GetString("c1List1.PropBag")
            Me.panel1.Controls.Add(Me.btnDelete)
            Me.panel1.Controls.Add(Me.btnClose)
            Me.panel1.Controls.Add(Me.btnRename)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 309)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(442, 42)
            Me.panel1.TabIndex = 4
            Me.panel2.Controls.Add(Me.c1List1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(442, 309)
            Me.panel2.TabIndex = 5
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(442, 351)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Name = "ManageLayoutForm"
            Me.Text = "Manage Layout"
            CType((Me.btnClose), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnRename), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnDelete), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.c1List1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private btnClose As C1.Win.C1Input.C1Button
        Private btnRename As C1.Win.C1Input.C1Button
        Private btnDelete As C1.Win.C1Input.C1Button
        Private c1List1 As C1.Win.List.C1List
        Private panel1 As System.Windows.Forms.Panel
        Private panel2 As System.Windows.Forms.Panel
    End Class
End Namespace
