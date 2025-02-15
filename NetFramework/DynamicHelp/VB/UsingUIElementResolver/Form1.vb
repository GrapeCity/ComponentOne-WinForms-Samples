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
        Inherits C1.Win.Ribbon.C1RibbonForm
        Public Sub New()
            InitializeComponent()

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