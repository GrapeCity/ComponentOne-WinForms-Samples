Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon
Imports C1.Win.RulesManager

Public Class MainForm
    Private Const xmlFileName As String = "FlexGridConditionalFormattingRules.xml"
    Private pathToXmlFile As String = Nothing
    Private lastRuleUnderMouse As AccessibleObject = Nothing
    Private Const toolTipText As String = "Click on Rule to Edit"

#Region "Initialization"

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitThemes()

        flexGrid.DataSource = GetDataSource()

        ApplyRules()

        ' uncomment line below to allow saving of changed rules in xml file and loading of it on startup of application
        ' AddHandler rulesManager.RulesChanged, AddressOf RulesManager_RulesChanged
    End Sub

    Private Sub ApplyRules()
        pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), xmlFileName)

        If Not File.Exists(pathToXmlFile) Then
            ApplyPredefinedRules()
        Else
            rulesManager.LoadRules(pathToXmlFile)
        End If
    End Sub

    Private Sub ApplyPredefinedRules()
        Dim rule1 = New Rule() With {
            .Name = "In Order",
            .Expression = "= [UnitsOnOrder] > 0",
            .Style = New ItemStyle() With {
                .ForeColor = Color.DarkBlue,
                .BorderColor = Color.DarkBlue,
                .FontStyle = FontStyle.Bold
            }
        }
        rule1.AppliesTo.Add(New FieldRange(New String() {"UnitsOnOrder"}))
        rulesManager.Rules.Add(rule1)
        Dim rule2 = New Rule() With {
            .Name = "Only Few In Stock",
            .Expression = "= [UnitsInStock] < 10",
            .Style = New ItemStyle() With {
                .ForeColor = Color.White,
                .BackColor = Color.Green
            }
        }
        rule2.AppliesTo.Add(New ItemRange(flexGrid.Rows.Fixed, flexGrid.Rows.Count - 1))
        rulesManager.Rules.Add(rule2)
    End Sub

    Private Sub RulesManager_RulesChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        rulesManager.SaveRules(pathToXmlFile)
    End Sub

#End Region

#Region "Rules manager UI visibility management"

    Private Sub ribbonToggleButtonManageRules_PressedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonToggleButtonManageRules.PressedChanged
        Dim ribbonToggleButton = TryCast(sender, RibbonToggleButton)

        If ribbonToggleButton Is Nothing Then
            Return
        End If

        dockingTabPageConditionalFormatting.TabVisible = ribbonToggleButton.Pressed
    End Sub

    Private Sub ribbonCheckBoxHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxHeader.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsHeaderVisible = ribbonCheckBox.Checked
    End Sub

    Private Sub ribbonCheckBoxAddButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxAddButton.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsAddButtonVisible = ribbonCheckBox.Checked
    End Sub

    Private Sub ribbonCheckBoxRemoveButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxRemoveButton.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsRemoveButtonVisible = ribbonCheckBox.Checked
    End Sub

    Private Sub ribbonCheckBoxRuleName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxRuleName.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsRuleNameVisible = ribbonCheckBox.Checked
    End Sub

    Private Sub ribbonCheckBoxRangeSelector_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxRangeSelector.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsRangeSelectorVisible = ribbonCheckBox.Checked
    End Sub

    Private Sub ribbonCheckBoxCondition_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonCheckBoxCondition.CheckedChanged
        Dim ribbonCheckBox = TryCast(sender, RibbonCheckBox)

        If ribbonCheckBox Is Nothing Then
            Return
        End If

        rulesManager.Options.IsConditionVisible = ribbonCheckBox.Checked
    End Sub

#End Region

#Region "ToolTip showing"

    Private Sub rulesManager_MouseMove(sender As Object, e As MouseEventArgs) Handles rulesManager.MouseMove
        Dim rulesManager = TryCast(sender, C1RulesManager)

        If rulesManager Is Nothing Then
            Return
        End If

        Dim previousRule = lastRuleUnderMouse
        Dim mousePointOnScreen = rulesManager.PointToScreen(New Point(e.X, e.Y))
        lastRuleUnderMouse = GetRuleFromMousePosition(mousePointOnScreen, rulesManager)

        If lastRuleUnderMouse Is Nothing Then
            superTooltip.Hide(rulesManager)
            Return
        End If

        If previousRule IsNot lastRuleUnderMouse Then
            Dim textWidth = TextRenderer.MeasureText(toolTipText, superTooltip.Font).Width
            superTooltip.Show(toolTipText, rulesManager, rulesManager.PointToClient(New Point(lastRuleUnderMouse.Bounds.X + lastRuleUnderMouse.Bounds.Width / 2 - textWidth / 2, lastRuleUnderMouse.Bounds.Y + lastRuleUnderMouse.Bounds.Height)))
        End If
    End Sub

    Private Sub rulesManager_MouseLeave(sender As Object, e As EventArgs) Handles rulesManager.MouseLeave
        superTooltip.Hide(rulesManager)
        lastRuleUnderMouse = Nothing
    End Sub

    Private Function GetRuleFromMousePosition(ByVal mousePoint As Point, ByVal rulesManager As C1RulesManager) As AccessibleObject
        Dim controlChildren = rulesManager.Controls

        If controlChildren Is Nothing Then
            Return Nothing
        End If

        Dim controlChildrenCount = controlChildren.Count

        If controlChildrenCount = 0 Then
            Return Nothing
        End If

        Dim xView = controlChildren(0)

        If xView Is Nothing Then
            Return Nothing
        End If

        Dim rulesManagerPanelAccessibilityObject = xView.AccessibilityObject

        If rulesManagerPanelAccessibilityObject Is Nothing Then
            Return Nothing
        End If

        Dim accessibilityObjectChildrenCount = rulesManagerPanelAccessibilityObject.GetChildCount()

        If accessibilityObjectChildrenCount = 0 Then
            Return Nothing
        End If

        Dim rulesListAccessibilityObject = rulesManagerPanelAccessibilityObject.GetChild(0)

        If rulesListAccessibilityObject Is Nothing Then
            Return Nothing
        End If

        Dim rulesListAccessibilityObjectChildrenCount = rulesListAccessibilityObject.GetChildCount()

        If rulesListAccessibilityObjectChildrenCount = 0 Then
            Return Nothing
        End If

        For childIndex = 0 To rulesListAccessibilityObjectChildrenCount - 1
            Dim ruleAccessibilityObject = rulesListAccessibilityObject.GetChild(childIndex)

            If ruleAccessibilityObject IsNot Nothing AndAlso ruleAccessibilityObject.Name = "Rule" AndAlso ruleAccessibilityObject.Bounds.Contains(mousePoint) Then
                Return ruleAccessibilityObject
            End If
        Next

        Return Nothing
    End Function

#End Region

#Region "Themes"

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office365"))

        For Each theme In themes
            ribbonComboBoxTheme.Items.Add(theme)
        Next

        ribbonComboBoxTheme.SelectedIndex = ribbonComboBoxTheme.Items.IndexOf("Office365Green")
    End Sub

    Private Sub ribbonComboBoxTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonComboBoxTheme.SelectedIndexChanged
        C1ThemeController.ApplicationTheme = ribbonComboBoxTheme.SelectedItem.Text
    End Sub

#End Region

#Region "DataSource"

    Private Function GetDataSource() As DataTable
        Dim rs = "select * from Products;"
        Dim cn = GetConnectionString()
        Dim da = New OleDbDataAdapter(rs, cn)
        Dim dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Private Shared Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

#End Region

End Class
