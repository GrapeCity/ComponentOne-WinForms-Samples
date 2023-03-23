Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Namespace AddingUICommands
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()

            ' need to handle the following events to enable/disable Back/Forward buttons
            AddHandler c1DynamicHelp1.Browser.CanGoBackChanged, AddressOf Browser_CanGoBackChanged
            AddHandler c1DynamicHelp1.Browser.CanGoForwardChanged, AddressOf Browser_CanGoForwardChanged
        End Sub

        Private Sub Browser_CanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs)
            btnForward.Enabled = c1DynamicHelp1.Browser.CanGoForward
        End Sub

        Private Sub Browser_CanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs)
            btnBack.Enabled = c1DynamicHelp1.Browser.CanGoBack
        End Sub

        Private Sub toolStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles toolStrip1.ItemClicked
            ' Use the C1DynamicHelp.Browser property to implement Back/Forward buttons
            If e.ClickedItem Is btnBack Then
                c1DynamicHelp1.Browser.GoBack()
            ElseIf e.ClickedItem Is btnForward Then
                c1DynamicHelp1.Browser.GoForward()
            ' use C1DynamicHelp.ShowExternalHelp methods to open help in an external window
            ElseIf e.ClickedItem Is btnContents Then
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.TableOfContents)
            ElseIf e.ClickedItem Is btnIndex Then
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Index)
            ElseIf e.ClickedItem Is btnSearch Then
                c1DynamicHelp1.ShowExternalHelp(C1.Win.C1DynamicHelp.HelpTab.Find)
            End If
        End Sub

        Private Sub btnPin_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPin.CheckedChanged
            c1DynamicHelp1.IsPinnedDown = btnPin.Checked
            If btnPin.Checked Then
                btnPin.Image = My.Resources.pinned
            Else
                btnPin.Image = My.Resources.unpinned
            End If
            If btnPin.Checked Then
                btnPin.ToolTipText = "Fixed topic"
            Else
                btnPin.ToolTipText = "Fix topic"
            End If
        End Sub

    End Class
End Namespace