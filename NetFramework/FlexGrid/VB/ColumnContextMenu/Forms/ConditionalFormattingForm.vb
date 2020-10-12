Imports C1.Win.Ribbon
Imports C1.Win.RulesManager
Imports C1.Win.RulesManager.Model
Imports System.Windows.Forms
Imports System.Linq

Public Class ConditionalFormattingForm

    Private _defaultRules As RuleCollection

    Public Sub New(grid As Object)
        InitializeComponent()
        c1RulesManager1.SetC1RulesManager(grid, c1RulesManager1)
    End Sub

    Public ReadOnly Property Rules As RuleCollection
        Get
            Return c1RulesManager1.Rules
        End Get
    End Property

    Public ReadOnly Property IsEmpty As Boolean
        Get
            Return c1RulesManager1.Rules Is Nothing Or c1RulesManager1.Rules.Count = 0
        End Get
    End Property

    Private Sub ConditionalFormattingForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Store the default rules to Undo changes if needed
        _defaultRules = New RuleCollection()
        _defaultRules.AddRange(c1RulesManager1.Rules.Select(Function(x)
                                                                Dim result As IRule = x.Clone()
                                                                Return result
                                                            End Function))
    End Sub

    'Clear button clicked
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear rules
        c1RulesManager1.Rules.Clear()
    End Sub

    'Ok button clicked
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Close form
        DialogResult = DialogResult.OK
        Close()
    End Sub

    'Cancel button clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Undo changes and close form
        c1RulesManager1.Rules.Clear()
        c1RulesManager1.Rules.AddRange(_defaultRules)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class