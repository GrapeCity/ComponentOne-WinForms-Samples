Imports C1.Win.TouchToolKit
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class ZoomPolicyForm
		Inherits Form
		Private _titleText As String = "ZoomPolicy sample for "
		Private _font As Font = New System.Drawing.Font("Harlow Solid", 12)

		Public Sub New(provider As IZoomPolicyProvider, group As String, zoomPolicy As String)
			InitializeComponent()
			Dim policy1 As ZoomPolicy = provider.GetZoomPolicy(group, zoomPolicy)
			Dim policy2 As ZoomPolicy = provider.GetZoomPolicy(group, zoomPolicy)
			If policy1 Is Nothing OrElse policy2 Is Nothing Then
				For i As Integer = 0 To gcZoomPanel2.DefaultZoomPolicies.Count - 1
					If gcZoomPanel2.DefaultZoomPolicies(i).[GetType]().Name = zoomPolicy Then
						policy2 = gcZoomPanel2.DefaultZoomPolicies(i)
						policy2.Enabled = False
						Exit For
					End If
				Next
			Else
				policy2.Enabled = False
				gcZoomPanel1.ZoomPolicies.Add(policy1)
				gcZoomPanel2.ZoomPolicies.Add(policy2)
			End If

			If policy2 IsNot Nothing Then
				Me.Text = _titleText + policy2.TargetType.Name
				Dim control As Control = provider.GetControl(group, zoomPolicy, _font, gcZoomPanel1.ClientSize)
				If control Is Nothing Then
					Return
				End If
				Dim targetControlName As String = zoomPolicy
				If targetControlName.EndsWith("Policy", StringComparison.OrdinalIgnoreCase) Then
					targetControlName = targetControlName.Substring(0, targetControlName.Length - "Policy".Length)
				End If
				If targetControlName.EndsWith("Zoom", StringComparison.OrdinalIgnoreCase) Then
					targetControlName = targetControlName.Substring(0, targetControlName.Length - "Zoom".Length)
				End If
				If control.[GetType]().Name <> targetControlName Then
					Dim controls As New Queue(Of Control)()
					controls.Enqueue(control)
					Dim tmpControl As Control
					While controls.Count > 0
						tmpControl = controls.Dequeue()
						If tmpControl.[GetType]().Name = targetControlName Then
							Exit While
						End If
						Dim policy3 As ZoomPolicy = provider.GetZoomPolicy(group, tmpControl.[GetType]().Name + "ZoomPolicy")
						Dim policy4 As ZoomPolicy = provider.GetZoomPolicy(group, tmpControl.[GetType]().Name + "ZoomPolicy")
						If policy3 Is Nothing Then
							policy3 = provider.GetZoomPolicy(group, tmpControl.[GetType]().Name + "Policy")
							policy4 = provider.GetZoomPolicy(group, tmpControl.[GetType]().Name + "Policy")
						End If
						If policy3 IsNot Nothing AndAlso Not Contains(gcZoomPanel1.ZoomPolicies, policy3) Then
							gcZoomPanel1.ZoomPolicies.Add(policy3)
							gcZoomPanel2.ZoomPolicies.Add(policy4)
						End If
						For Each childControl As Control In tmpControl.Controls
							If childControl.[GetType]().Assembly = GetType(Control).Assembly Then
								Continue For
							End If
							controls.Enqueue(childControl)
						Next
					End While
				End If
				gcZoomPanel1.Controls.Add(control)
				gcZoomPanel2.Controls.Add(provider.GetControl(group, zoomPolicy, _font, gcZoomPanel2.ClientSize))
			End If
			Dim size As System.Nullable(Of Size) = provider.GetDemoSize(group, zoomPolicy)
			If size.HasValue Then
				Me.Size = size.Value
			End If
		End Sub

		Private Shared Function Contains(list As List(Of ZoomPolicy), item As ZoomPolicy) As Boolean
			For Each policy As ZoomPolicy In list
				If policy.TargetType = item.TargetType Then
					Return True
				End If
			Next
			Return False
		End Function
	End Class
End Namespace
