Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports System.Configuration
Imports C1.Util
Imports C1.Win.C1Editor.UICustomization
Imports Resources = CustomDialogs.Resources

''' <summary>
''' Represents a form for editing hyperlink properties.
''' </summary>
Friend Partial Class HyperlinkEditorForm
	Inherits BaseEditorForm
	Implements IHyperlinkItemDialog
	#Region "ctors"

	Public Sub New()
		InitializeComponent()
		InitializeTargets()
		AddHandler _tbTabIndex.Validated, New EventHandler(AddressOf ValidateNumber)
		AddHandler _btnSelectImageSource.Click, New EventHandler(AddressOf _btnSelectLink_Click)
		AddHandler _tbText.TextChanged, New EventHandler(AddressOf _tbText_TextChanged)
		_tbAccessKey.MaxLength = 1
	End Sub

	#End Region

	#Region "implementation"

	Private ReadOnly Property Item() As XHTMLHyperlinkItem
		Get
			Return TryCast(_item, XHTMLHyperlinkItem)
		End Get
	End Property

	Private Sub InitializeTargets()
		_cmbTarget.Items.Add(Resources.sHyperlinkTargetDefault)
		_cmbTarget.Items.Add(Resources.sHyperlinkTargetSameFrame)
		_cmbTarget.Items.Add(Resources.sHyperlinkTargetWholePage)
		_cmbTarget.Items.Add(Resources.sHyperlinkTargetNewWindow)
		_cmbTarget.Items.Add(Resources.sHyperlinkTargetParentFrame)
	End Sub

	#End Region

	#Region "event handlers"

	Private Sub _btnSelectLink_Click(sender As Object, e As EventArgs)
		Dim dlg As New OpenFileDialog()
		dlg.Title = Resources.sSelectFile
		dlg.Filter = Resources.sFilterAllFiles
		dlg.Multiselect = False
		dlg.FilterIndex = 1
		dlg.InitialDirectory = Path.GetDirectoryName(_item.DocumentName)
		If dlg.ShowDialog() = DialogResult.OK Then
			_tbLink.Text = GetUriFromPath(_item.DocumentName, dlg.FileName)
			BindingContext(_item).EndCurrentEdit()
		End If
	End Sub

	Private Sub _tbText_TextChanged(sender As Object, e As EventArgs)
		_btnOK.Enabled = Not String.IsNullOrEmpty(_tbText.Text.Trim())
	End Sub

	Protected Overloads Overrides Sub OnLoad(e As EventArgs)
		MyBase.OnLoad(e)
		AdjustBrowseButtons(New Button() {_btnSelectImageSource}, New Control() {_tbLink})
	End Sub

	#End Region

	#Region "IHyperlinkItemDialog Members"

	''' <summary>
	''' Binds data from the item to GUI controls on the form.
	''' Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
	''' to read data from the item and write it back.
	''' </summary>
	''' <param name="item">The item to be bound to the GUI controls.</param>
	Private Sub IHyperlinkItemDialog_BindData(item As XHTMLHyperlinkItem) Implements IHyperlinkItemDialog.BindData
		_item = item

		If Not String.IsNullOrEmpty(item.AccessKey) AndAlso item.AccessKey.Length > 1 Then
			item.AccessKey = item.AccessKey.Substring(0, 1)
		End If

		_tbText.DataBindings.Add("Text", item, "Text")
		_tbLink.DataBindings.Add("Text", item, "Href")
		_tbTitle.DataBindings.Add("Text", item, "Title")
		_tbAccessKey.DataBindings.Add("Text", item, "AccessKey")
		_tbTabIndex.DataBindings.Add("Value", item, "TabIndex")
		_cmbTarget.DataBindings.Add("Text", item, "Target")

		_tbText.Enabled = item.IsEmpty
		_tbText_TextChanged(Me, EventArgs.Empty)
	End Sub

	''' <summary>
	''' Shows the form with the specified owner to the user.
	''' </summary>
	''' <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
	''' the top-level window that will own this form.</param>
	''' <returns>True if the form was displayed successfully and the item was changed.</returns>
	Private Function IHyperlinkItemDialog_Show(owner As IWin32Window) As Boolean Implements IHyperlinkItemDialog.Show
		Return Show(owner)
	End Function

	#End Region
End Class

