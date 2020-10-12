Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages
	Public Class ZoomPolicyProvider
		Inherits ZoomPolicyProviderBase
		Public Overrides ReadOnly Property PolicyGroups() As String()
			Get
				Return New String() {"Standard"}
			End Get
		End Property

	End Class
End Namespace
