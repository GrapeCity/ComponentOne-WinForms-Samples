Imports C1.Win.C1Ribbon
Imports System.Reflection

Public Class BrowserCheck
    ''' <summary>
    ''' Initializes a new instance of the BrowserCheck class.
    ''' </summary>
    ''' <param name="webUrl"></param>
    Public Sub New(ByVal webUrl As Uri, ByVal vis As VisualStyle)
        InitializeComponent()
        brwsOne.Url = webUrl
        VisualStyle = vis
        C1SplitterPanel1.Text = webUrl.ToString
        btnOK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Custom

        Dim mi As MethodInfo = btnOK.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        mi.Invoke(btnOK, New Object() {})
        mi.Invoke(btnCancel, New Object() {})
    End Sub


    
  

End Class
