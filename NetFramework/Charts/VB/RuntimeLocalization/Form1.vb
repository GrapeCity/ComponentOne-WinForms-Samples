Imports System.IO
Imports System.Text
Imports System.Xml

Imports C1.Win.C1Chart
Imports C1.Win.C1Chart3D

Public Class Form1

#Region " Main Events "
	Private Sub c1Chart1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles c1Chart1.Click
		' Show the ChartProperties dialog
		c1Chart1.ShowProperties()
	End Sub	'c1Chart1_Click

	Private Sub c1Chart3D1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles c1Chart3D1.Click
		' Show the ChartProperties dialog
		c1Chart3D1.ShowProperties()
	End Sub	'c1Chart3D1_Click

	Private Sub btnAddPrefix_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddPrefix.Click
		' Call runOperations to execute "localizeChart" for each checked chart
		runOperations(AddressOf localizeChart)
	End Sub	'btnAddPrefix_Click

	Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
		' Call runOperations to execute "resetLocalizations" for each checked chart
		runOperations(AddressOf resetLocalizations)
	End Sub	'btnReset_Click

	Private Sub btnShowLocalizations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowLocalizations.Click
		' Call runOperations to execute "showLocalizations" for each checked chart
		runOperations(AddressOf showLocalizations)
	End Sub	'btnShowLocalizations_Click

	Private Sub btnShowPropGrids_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowPropGrids.Click
		' Call runOperations to execute "showPropertyGrids" for each checked chart
		runOperations(AddressOf showPropertyGrids)
	End Sub	'btnShowPropGrids_Click

#End Region

#Region " Operations routines "
	' <summary>
	' Defines routine operation function construct.
	' </summary>
	' <param name="objChart"></param>
	Public Delegate Sub runOperation(ByVal objChart As Object)


	' <summary>
	' Framework to run the runOperation delegates for each
	' checked chart in groupBox1.
	' </summary>
	' <param name="runop"></param>
	Private Sub runOperations(ByVal runop As runOperation)
		Dim cb As CheckBox
		For Each cb In groupBox1.Controls
			If cb.Checked Then
				Select Case cb.Text
					Case "Chart 2D"
						runop(c1Chart1)

					Case "Chart 3D"
						runop(c1Chart3D1)
				End Select
			End If
		Next cb
	End Sub	'runOperations


	' <summary>
	' Localizes the specified chart object by adding the specified
	' prefix in groupBox2 to the beginning of each localizable string.
	' 
	' Of course, no one would really want to do this, but it
	' demonstrates how to modify and localize the strings used in the
	' dialogs and property descriptions.
	' </summary>
	' <param name="objChart"></param>
	Private Sub localizeChart(ByVal objChart As Object)
		' a MemoryStream is used for demo purposes.
		Dim ChartLocalizationStream As New MemoryStream()

		If TypeOf objChart Is C1Chart Then
			Dim chart As C1Chart = objChart
			If chart.SaveLocalizations(ChartLocalizationStream) Then
				addPrefixToLocalizations(ChartLocalizationStream)
				chart.LoadLocalizations(ChartLocalizationStream)
			End If
		ElseIf TypeOf objChart Is C1Chart3D Then
			Dim chart As C1Chart3D = objChart
			If chart.SaveLocalizations(ChartLocalizationStream) Then
				addPrefixToLocalizations(ChartLocalizationStream)
				chart.LoadLocalizations(ChartLocalizationStream)
			End If
		End If

		ChartLocalizationStream.Close()
		ChartLocalizationStream.Dispose()
	End Sub	'localizeChart


	' <summary>
	' Resets the chart localizations to the default state for the
	' specified chart.  This removes previous localizations and
	' frees all memory associated with the localizations.
	' </summary>
	' <param name="objChart"></param>
	Private Sub resetLocalizations(ByVal objChart As Object)
		' passing null to any of the LoadLocalization overload
		' clears any existing localizations previously loaded.
		If TypeOf objChart Is C1Chart Then
			Dim chart As C1Chart = objChart
			chart.LoadLocalizations(CType(Nothing, Stream))
		ElseIf TypeOf objChart Is C1Chart3D Then
			Dim chart As C1Chart3D = objChart
			chart.LoadLocalizations(CType(Nothing, Stream))
		End If
	End Sub	'resetLocalizations


	' <summary>
	' Creates a form and show the localization XML for the specified chart.
	' 
	' The localization XML is saved to a byte array for easy conversion to
	' text.  Note that the first bytes of the array may be byte encodings.
	' 
	' The form is sizeable.
	' </summary>
	' <param name="objChart"></param>
	Private Sub showLocalizations(ByVal objChart As Object)
		Dim title As String = " string localizations."
		Dim ChartLocalizationBytes As Byte() = Nothing

		If TypeOf objChart Is C1Chart Then
			Dim chart As C1Chart = objChart
			chart.SaveLocalizations(ChartLocalizationBytes)
			title = chart.Name + title
		ElseIf TypeOf objChart Is C1Chart3D Then
			Dim chart As C1Chart3D = objChart
			chart.SaveLocalizations(ChartLocalizationBytes)
			title = chart.Name + title
		Else
			MessageBox.Show("Object specified is not supported.")
			Return
		End If

		Dim ChartLocalizationString As String = Encoding.UTF8.GetString(ChartLocalizationBytes)

		Dim frm As New Form()
		Dim tb As New TextBox()
		frm.Text = title
		frm.Size = Me.Size
		frm.WindowState = FormWindowState.Normal
		frm.FormBorderStyle = FormBorderStyle.Sizable

		frm.Controls.Add(tb)
		tb.Dock = DockStyle.Fill
		tb.Multiline = True
		tb.ReadOnly = True
		tb.ScrollBars = ScrollBars.Both
		tb.Text = ChartLocalizationString
		tb.SelectionStart = 0
		tb.SelectionLength = 0
		tb.Visible = True

		frm.Show()
	End Sub	'showLocalizations


	' <summary>
	' Creates a form and adds a PropertyGrid connected to the specified chart.
	' The localizations of the Property Descriptions can be seen.
	'
	' Special Note: Once a control property description has been
	' retrieved, it does not change for the application.	This is a
	' behavior of the .NET PropertyDescriptor.
	'
	' The form is sizeable.
	' </summary>
	' <param name="objChart"></param>
	Private Sub showPropertyGrids(ByVal objChart As Object)
		Dim title As String = " Property Grid."

		Dim frm As New Form()
		Dim pg As New PropertyGrid()

		If TypeOf objChart Is C1Chart Then
			Dim chart As C1Chart = objChart
			pg.SelectedObject = chart
			title = chart.Name + title
		ElseIf TypeOf objChart Is C1Chart3D Then
			Dim chart As C1Chart3D = objChart
			pg.SelectedObject = chart
			title = chart.Name + title
		Else
			MessageBox.Show("Object specified is not supported.")
			Return
		End If

		frm.Text = title
		frm.Size = New Size(300, 400)
		frm.WindowState = FormWindowState.Normal
		frm.FormBorderStyle = FormBorderStyle.Sizable

		frm.Controls.Add(pg)
		pg.Dock = DockStyle.Fill
		pg.HelpVisible = True

		frm.Show()
	End Sub	'showPropertyGrids


#End Region

#Region " Miscellaneous Routines "
	' <summary>
	' This method adds the prefix that is checked in groupBox2
	' to the existing translations in the specified
	' ChartLocalizationsStream.
	' </summary>
	' <param name="ChartLocalizationStream"></param>
	Private Sub addPrefixToLocalizations(ByVal ChartLocalizationStream As Stream)
		Dim prefix As String = Nothing

		' remove the quotes from the text field values
		Dim rb As RadioButton
		For Each rb In groupBox2.Controls
			If rb.Checked Then
				prefix = rb.Text.Replace("""", "")
				Exit For
			End If
		Next rb
		If prefix Is Nothing Then
			Return ' nothing to do.
		End If
		Dim xdoc As New XmlDocument()

		' When saving the localizations to a stream, the chart
		' only writes forward and does not take control of the
		' stream from the caller.	Therefore, it will be necessary
		' to position the stream to the beginning in order to load
		' and Xml document directly.
		ChartLocalizationStream.Seek(0, SeekOrigin.Begin)
		xdoc.Load(ChartLocalizationStream)

		' The Chart basic element of the chart localization XML is
		' the C1ChartTranslation element.	It has two child nodes,
		' KeyStr and Trans.  KeyStr specifies the string that is
		' used by the default localization, and Trans specifies the
		' string to be used in place of the KeyStr.  If Trans is empty,
		' the KeyStr is used.
		'
		' To change the displayed value of the string, add or modify the
		' Trans inner text.
		' Get all the C1ChartTranslation element nodes, and insert the
		' prefix string before the existing Trans inner text.	If Trans
		' is empty, then it is set to prefix + KeyStr inner text.
		Dim xnl As XmlNodeList = xdoc.GetElementsByTagName("C1ChartTranslation")
		Dim xn As XmlNode
		For Each xn In xnl
			If xn.HasChildNodes Then
				Dim transNode As XmlNode = xn.LastChild

				Dim trans As String = transNode.InnerText
				If trans = String.Empty Then
					Dim keystrNode As XmlNode = xn.FirstChild
					trans = keystrNode.InnerText
				End If
				trans = prefix + ":" + trans
				transNode.InnerText = trans
			End If
		Next xn

		' empty the existing memory stream.
		ChartLocalizationStream.SetLength(0)

		' save the new translations to the existing stream
		xdoc.Save(ChartLocalizationStream)

		' position to the beginning of the stream in preparation
		' of the chart.LoadLocalizations().
		ChartLocalizationStream.Seek(0, SeekOrigin.Begin)
	End Sub	'addPrefixToLocalizations
#End Region

End Class 'Form1

