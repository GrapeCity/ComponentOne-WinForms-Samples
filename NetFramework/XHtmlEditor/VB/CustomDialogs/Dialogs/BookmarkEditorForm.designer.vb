Partial Class BookmarkEditorForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
	''' </summary>
	''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me._panelProperties = New System.Windows.Forms.Panel()
		Me._tbName = New System.Windows.Forms.TextBox()
		Me._lblName = New System.Windows.Forms.Label()
		Me._gbBookmarks = New System.Windows.Forms.GroupBox()
		Me._panel = New System.Windows.Forms.Panel()
		Me._tree = New System.Windows.Forms.TreeView()
		Me._toolStrip = New System.Windows.Forms.ToolStrip()
		Me._btnRemove = New System.Windows.Forms.ToolStripButton()
		Me._btnGoTo = New System.Windows.Forms.ToolStripButton()
		Me._containerMain.SuspendLayout()
		Me._panelProperties.SuspendLayout()
		Me._gbBookmarks.SuspendLayout()
		Me._panel.SuspendLayout()
		Me._toolStrip.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _btnOK
		' 
		Me._btnOK.Location = New System.Drawing.Point(216, 289)
		' 
		' _btnCancel
		' 
		Me._btnCancel.Location = New System.Drawing.Point(313, 289)
		' 
		' _btnAplly
		' 
		Me._btnAplly.Location = New System.Drawing.Point(410, 289)
		' 
		' _containerMain
		' 
		Me._containerMain.Controls.Add(Me._gbBookmarks)
		Me._containerMain.Controls.Add(Me._panelProperties)
		Me._containerMain.Size = New System.Drawing.Size(489, 274)
		' 
		' _panelProperties
		' 
		Me._panelProperties.Controls.Add(Me._tbName)
		Me._panelProperties.Controls.Add(Me._lblName)
		Me._panelProperties.Dock = System.Windows.Forms.DockStyle.Top
		Me._panelProperties.Location = New System.Drawing.Point(3, 17)
		Me._panelProperties.Name = "_panelProperties"
		Me._panelProperties.Size = New System.Drawing.Size(483, 38)
		Me._panelProperties.TabIndex = 0
		' 
		' _tbName
		' 
		Me._tbName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
		Me._tbName.Location = New System.Drawing.Point(64, 9)
		Me._tbName.Name = "_tbName"
		Me._tbName.Size = New System.Drawing.Size(412, 21)
		Me._tbName.TabIndex = 1
		' 
		' _lblName
		' 
		Me._lblName.AutoSize = True
		Me._lblName.Location = New System.Drawing.Point(7, 12)
		Me._lblName.Name = "_lblName"
		Me._lblName.Size = New System.Drawing.Size(38, 13)
		Me._lblName.TabIndex = 0
		Me._lblName.Text = "&Name:"
		' 
		' _gbBookmarks
		' 
		Me._gbBookmarks.Controls.Add(Me._panel)
		Me._gbBookmarks.Dock = System.Windows.Forms.DockStyle.Fill
		Me._gbBookmarks.Location = New System.Drawing.Point(3, 55)
		Me._gbBookmarks.Name = "_gbBookmarks"
		Me._gbBookmarks.Padding = New System.Windows.Forms.Padding(6)
		Me._gbBookmarks.Size = New System.Drawing.Size(483, 216)
		Me._gbBookmarks.TabIndex = 1
		Me._gbBookmarks.TabStop = False
		Me._gbBookmarks.Text = "Other &bookmarks in this document"
		' 
		' _panel
		' 
		Me._panel.Controls.Add(Me._tree)
		Me._panel.Controls.Add(Me._toolStrip)
		Me._panel.Dock = System.Windows.Forms.DockStyle.Fill
		Me._panel.Location = New System.Drawing.Point(6, 20)
		Me._panel.Name = "_panel"
		Me._panel.Padding = New System.Windows.Forms.Padding(1)
		Me._panel.Size = New System.Drawing.Size(471, 190)
		Me._panel.TabIndex = 1
		' 
		' _tree
		' 
		Me._tree.Dock = System.Windows.Forms.DockStyle.Fill
		Me._tree.Location = New System.Drawing.Point(1, 26)
		Me._tree.Name = "_tree"
		Me._tree.Size = New System.Drawing.Size(469, 163)
		Me._tree.TabIndex = 1
		' 
		' _toolStrip
		' 
		Me._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me._toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._btnRemove, Me._btnGoTo})
		Me._toolStrip.Location = New System.Drawing.Point(1, 1)
		Me._toolStrip.Name = "_toolStrip"
		Me._toolStrip.Size = New System.Drawing.Size(469, 25)
		Me._toolStrip.TabIndex = 0
		Me._toolStrip.Text = "toolStrip1"
		' 
		' _btnRemove
		' 
        Me._btnRemove.Image = Global.CustomDialogs.Resources.remove
		Me._btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnRemove.Name = "_btnRemove"
		Me._btnRemove.Size = New System.Drawing.Size(115, 22)
		Me._btnRemove.Text = "&Remove Bookmark"
		' 
		' _btnGoTo
		' 
        Me._btnGoTo.Image = Global.CustomDialogs.Resources.gotoright
		Me._btnGoTo.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnGoTo.Name = "_btnGoTo"
		Me._btnGoTo.Size = New System.Drawing.Size(104, 22)
		Me._btnGoTo.Text = "&Go To Bookmark"
		' 
		' BookmarkEditorForm
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.ClientSize = New System.Drawing.Size(513, 326)
		Me.MinimumSize = New System.Drawing.Size(521, 174)
		Me.Name = "BookmarkEditorForm"
		Me.Text = "Bookmark Properties"
		Me._containerMain.ResumeLayout(False)
		Me._panelProperties.ResumeLayout(False)
		Me._panelProperties.PerformLayout()
		Me._gbBookmarks.ResumeLayout(False)
		Me._panel.ResumeLayout(False)
		Me._panel.PerformLayout()
		Me._toolStrip.ResumeLayout(False)
		Me._toolStrip.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private _gbBookmarks As System.Windows.Forms.GroupBox
	Private _panelProperties As System.Windows.Forms.Panel
	Private _tbName As System.Windows.Forms.TextBox
	Private _lblName As System.Windows.Forms.Label
	Private _panel As System.Windows.Forms.Panel
	Private _tree As System.Windows.Forms.TreeView
	Private _toolStrip As System.Windows.Forms.ToolStrip
	Private _btnRemove As System.Windows.Forms.ToolStripButton
	Private _btnGoTo As System.Windows.Forms.ToolStripButton



End Class
