Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Namespace UsingUIElementResolver
    Partial Public Class Form1
        Inherits C1.Win.C1Ribbon.C1RibbonForm
        Public Sub New()
            InitializeComponent()
            ' in design time we use the "..\..\Data\C1Sample.chm" path,
            ' in runtime C1Sample.chm wiil be in the same folder as the .exe file, so we need only file name
            c1DynamicHelp1.HelpSource = Path.GetFileName(c1DynamicHelp1.HelpSource)

            ' try to comment this line out and no topics will be displayed and you won't be able to select 
            ' separate UI elements on the C1Ribbon such as groups, etc. You will be able to select only the C1Ribbon itself
            c1DynamicHelp1.Resolver = New CustomUIElementResolver()
        End Sub

        ' toggle authoring mode when the user hits ctrl+shift+a
        Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.A AndAlso e.Control AndAlso e.Shift Then
                c1DynamicHelp1.AuthoringMode = Not c1DynamicHelp1.AuthoringMode
            End If
            MyBase.OnKeyDown(e)
        End Sub
    End Class
End Namespace