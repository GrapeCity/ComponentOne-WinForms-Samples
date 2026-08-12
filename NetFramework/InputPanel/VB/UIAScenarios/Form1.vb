Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Automation
Imports C1.Win.InputPanel
Imports UIAScenarios.My.Resources
Imports UIAScenarios.UIAScenarios

Public Class Form1

    ''' <summary>
    ''' Handles the Run Scenario button click event
    ''' and executes the currently selected test scenario.
    ''' </summary>
    Private Sub BtnRunScenario_Click(sender As Object, e As EventArgs) _
        Handles btnRunScenario.Click

        RunSelectedScenarion(DirectCast(cmbScenario.SelectedItem, TestScenario))

    End Sub

    ''' <summary>
    ''' Executes the specified test scenario and manages UI state during execution.
    ''' </summary>
    ''' <param name="item">Scenario to execute.</param>
    Private Sub RunSelectedScenarion(item As TestScenario)

        btnRunScenario.Enabled = False

        ClearInputPanel()

        If item.Scenario IsNot Nothing Then
            item.Scenario.Invoke()
        End If

        btnRunScenario.Enabled = True

    End Sub

    ''' <summary>
    ''' Returns all available UI Automation test scenarios.
    ''' </summary>
    ''' <returns>
    ''' Collection of configured test scenarios.
    ''' </returns>
    Private Function GetTestScenarios() As IEnumerable(Of TestScenario)

        Return New List(Of TestScenario) From
        {
            GetReplaceScenario(),
            GetCheckBoxScenario(),
            GetRadioButtonScenario(),
            GetTextEditorScenario(),
            GetComboBoxScenario()
        }

    End Function

    ''' <summary>
    ''' Creates a scenario demonstrating text replacement
    ''' using UI Automation patterns.
    ''' </summary>
    ''' <returns>
    ''' Configured replace scenario.
    ''' </returns>
    Private Function GetReplaceScenario() As TestScenario

        Return New TestScenario(
        "Replace words in a InputTextBox",
        "This test scenario updates records in the data source and uses InvokePattern to navigate through records and ValuePattern to edit records."
    ) With {
        .Scenario =
            Sub()

                ' Add items for scenario.
                Dim source = SampleDataSource.CreateProductsSource()

                c1InputPanel1.Items.Add(
                    New InputLabel() With {
                        .Text = "Item",
                        .Width = 100,
                        .HorizontalAlign = InputContentAlignment.Far
                    })

                c1InputPanel1.Items.Add(
                    New InputTextBox() With {
                        .DataSource = source,
                        .DataField = "Name",
                        .Name = "NameEditor",
                        .Width = 250
                    })

                c1InputPanel1.Items.Add(
                    New InputLabel() With {
                        .Text = "Description",
                        .Width = 100,
                        .HorizontalAlign = InputContentAlignment.Far
                    })

                c1InputPanel1.Items.Add(
                    New InputTextBox() With {
                        .DataSource = source,
                        .DataField = "Description",
                        .Name = "DescriptionEditor",
                        .Width = 250,
                        .Multiline = True,
                        .ElementHeight = 60
                    })

                c1InputPanel1.Items.Add(
                    New InputDataNavigator() With {
                        .Name = "ProductsNavigator",
                        .DataSource = source,
                        .AddNewImage = Resource1.navIBindingList_AddNewImage,
                        .ApplyImage = Resource1.navEmployees_ApplyImage,
                        .CancelImage = Resource1.navEmployees_CancelImage,
                        .DeleteImage = Resource1.navEmployees_DeleteImage,
                        .EditImage = Resource1.navEmployees_EditImage,
                        .MoveFirstImage = Resource1.navEmployees_MoveFirstImage,
                        .MoveLastImage = Resource1.navEmployees_MoveLastImage,
                        .MoveNextImage = Resource1.navEmployees_MoveNextImage,
                        .MovePreviousImage = Resource1.navEmployees_MovePreviousImage
                    })

                ' UIA Test Scenario
                ' C1InputPanel as root element.
                Dim inputPanel As AutomationElement =
                    AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                        ))

                If inputPanel Is Nothing Then
                    Return
                End If

                Dim nameEditor As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "NameEditor"))
                If nameEditor Is Nothing Then
                    Return
                End If

                ' Description property editor.
                Dim descriptionEditor As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "DescriptionEditor"))
                If descriptionEditor Is Nothing Then
                    Return
                End If

                ' ValuePattern of the Description property editor.
                Dim descriptionEditorValuePattern As ValuePattern =
                    CType(
                        descriptionEditor.GetCurrentPattern(ValuePattern.Pattern),
                        ValuePattern)
                If descriptionEditorValuePattern Is Nothing Then
                    Return
                End If

                ' Data navigator.
                Dim navigator As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "ProductsNavigator"))

                ' Next button of the Data navigator.
                Dim nextButton As AutomationElement =
                    navigator.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Button),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                "NavigatorButton Move Next")))
                If nextButton Is Nothing Then
                    Return
                End If

                ' InvokePattern of the Next button.
                Dim nextInvoke As InvokePattern =
                    CType(
                        nextButton.GetCurrentPattern(InvokePattern.Pattern),
                        InvokePattern)
                If nextInvoke Is Nothing Then
                    Return
                End If

                Dim isNextEnabled As Boolean = nextButton.Current.IsEnabled

                While isNextEnabled

                    nameEditor.SetFocus()

                    Dim currentDescription =
                        descriptionEditorValuePattern.Current.Value

                    Dim updated As String =
                        Regex.Replace(
                            currentDescription,
                            "computer",
                            "PC",
                            RegexOptions.IgnoreCase)

                    If currentDescription <> updated Then
                        descriptionEditorValuePattern.SetValue(updated)
                    End If

                    isNextEnabled = nextButton.Current.IsEnabled

                    If isNextEnabled Then
                        nextInvoke.Invoke()
                        Thread.Sleep(100)
                    End If

                End While

            End Sub
    }

    End Function

    ''' <summary>
    ''' Creates a scenario demonstrating checkbox interaction
    ''' using the TogglePattern.
    ''' </summary>
    ''' <returns>
    ''' Configured checkbox scenario.
    ''' </returns>
    Private Function GetCheckBoxScenario() As TestScenario

        Return New TestScenario(
        "InputCheckBox UIA Api",
        "Checking and toggling a checkbox using the TogglePattern."
    ) With {
        .Scenario =
            Sub()

                ' Add items for scenario.
                c1InputPanel1.Items.Add(
                    New InputCheckBox With {
                        .Name = "CSharp",
                        .Text = "C#"
                    })

                c1InputPanel1.Items.Add(
                    New InputCheckBox With {
                        .Name = "Sql",
                        .Text = "SQL"
                    })

                c1InputPanel1.Items.Add(
                    New InputCheckBox With {
                        .Name = "Azure",
                        .Text = "Azure"
                    })

                c1InputPanel1.Items.Add(
                    New InputCheckBox With {
                        .Name = "JavaScript",
                        .Text = "JavaScript"
                    })

                ' UIA Test Scenario
                ' C1InputPanel as root element.
                Dim inputPanel As AutomationElement =
                    AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                        ))

                If inputPanel Is Nothing Then
                    Return
                End If

                Dim setToggleState As Action(Of String, ToggleState) =
                    Sub(elementName, desiredState)

                        Dim element As AutomationElement =
                            inputPanel.FindFirst(
                                TreeScope.Descendants,
                                New PropertyCondition(
                                    AutomationElement.NameProperty,
                                    elementName))

                        If element Is Nothing Then
                            Return
                        End If

                        Dim togglePattern As TogglePattern =
                            CType(
                                element.GetCurrentPattern(TogglePattern.Pattern),
                                TogglePattern)

                        If togglePattern IsNot Nothing AndAlso togglePattern.Current.ToggleState <> desiredState Then
                            togglePattern.Toggle()
                        End If

                    End Sub

                setToggleState("CSharp", ToggleState.On)
                setToggleState("Sql", ToggleState.Off)
                setToggleState("Azure", ToggleState.Off)
                setToggleState("JavaScript", ToggleState.On)

            End Sub
    }

    End Function

    ''' <summary>
    ''' Creates a scenario demonstrating radio button selection
    ''' using the SelectionItemPattern.
    ''' </summary>
    ''' <returns>
    ''' Configured radio button scenario.
    ''' </returns>
    Private Function GetRadioButtonScenario() As TestScenario

        Return New TestScenario(
        "InputRadioButton UIA Api",
        "Checking and selecting a radio button using the SelectionItemPattern."
    ) With {
        .Scenario =
            Sub()

                ' Add items for scenario.
                c1InputPanel1.Items.Add(
                    New InputRadioButton With {
                        .Name = "FullTime",
                        .GroupName = "EmploymentType",
                        .Text = "Full-time",
                        .Checked = True
                    })

                c1InputPanel1.Items.Add(
                    New InputRadioButton With {
                        .Name = "PartTime",
                        .GroupName = "EmploymentType",
                        .Text = "Part-time"
                    })

                c1InputPanel1.Items.Add(
                    New InputRadioButton With {
                        .Name = "Contractor",
                        .GroupName = "EmploymentType",
                        .Text = "Contractor"
                    })

                ' UIA Test Scenario
                ' C1InputPanel as root element.
                Dim inputPanel As AutomationElement =
                    AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                        ))

                If inputPanel Is Nothing Then
                    Return
                End If

                Dim contractor As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "Contractor"))
                If contractor Is Nothing Then
                    Return
                End If

                Dim contractorSelectionItemPattern As SelectionItemPattern =
                    CType(
                        contractor.GetCurrentPattern(SelectionItemPattern.Pattern),
                        SelectionItemPattern)

                If contractorSelectionItemPattern IsNot Nothing AndAlso Not contractorSelectionItemPattern.Current.IsSelected Then
                    contractorSelectionItemPattern.AddToSelection()
                End If

            End Sub
    }

    End Function

    ''' <summary>
    ''' Creates a scenario demonstrating interaction with
    ''' text editor controls using ValuePattern and RangeValuePattern.
    ''' </summary>
    ''' <returns>
    ''' Configured text editor scenario.
    ''' </returns>
    Private Function GetTextEditorScenario() As TestScenario

        Return New TestScenario(
        "TextEditor's UIA Api",
        "Changing a value in input text editors using ValuePattern or RangeValuePattern."
    ) With {
        .Scenario =
            Sub()

                ' Add items for scenario.
                c1InputPanel1.Items.Add(
                    New InputTextBox() With {
                        .Name = "InputTextBoxUIA"
                    })

                c1InputPanel1.Items.Add(
                    New InputMaskedTextBox() With {
                        .Name = "InputMaskedTextBoxUIA"
                    })

                c1InputPanel1.Items.Add(
                    New InputComboBox() With {
                        .Name = "InputComboBoxUIA"
                    })

                c1InputPanel1.Items.Add(
                    New InputNumericBox() With {
                        .Name = "InputNumericBoxUIA"
                    })

                c1InputPanel1.Items.Add(
                    New InputDatePicker() With {
                        .Name = "InputDatePickerUIA"
                    })

                c1InputPanel1.Items.Add(
                    New InputTimePicker() With {
                        .Name = "InputTimePickerUIA"
                    })

                ' UIA Test Scenario
                ' C1InputPanel as root element.
                Dim inputPanel As AutomationElement =
                    AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                        ))

                If inputPanel Is Nothing Then
                    Return
                End If

                Dim setValue As Action(Of String, String) =
                    Sub(elementName, value)

                        Dim element As AutomationElement =
                            inputPanel.FindFirst(
                                TreeScope.Descendants,
                                New PropertyCondition(
                                    AutomationElement.NameProperty,
                                    elementName))

                        If element Is Nothing Then
                            Return
                        End If

                        Dim valuePattern As ValuePattern =
                            CType(
                                element.GetCurrentPattern(ValuePattern.Pattern),
                                ValuePattern)

                        If valuePattern IsNot Nothing Then
                            valuePattern.SetValue(value)
                        End If

                    End Sub

                setValue("InputTextBoxUIA", "text")
                setValue("InputMaskedTextBoxUIA", "text")
                setValue("InputComboBoxUIA", "combo text")

                Dim numericBox As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "InputNumericBoxUIA"))

                If numericBox Is Nothing Then
                    Return
                End If

                Dim rangeValuePattern As RangeValuePattern =
                    CType(
                        numericBox.GetCurrentPattern(RangeValuePattern.Pattern),
                        RangeValuePattern)

                If rangeValuePattern IsNot Nothing Then
                    rangeValuePattern.SetValue(50)
                End If

                setValue(
                    "InputDatePickerUIA",
                    DateTime.Today.ToShortDateString())

                Dim timePicker As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "InputTimePickerUIA"))

                If timePicker Is Nothing Then
                    Return
                End If

                Dim valueEditor As AutomationElement =
                    timePicker.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "Value"))

                Dim valueEditorValuePattern As ValuePattern =
                    CType(
                        valueEditor.GetCurrentPattern(ValuePattern.Pattern),
                        ValuePattern)

                If valueEditorValuePattern IsNot Nothing Then
                    valueEditorValuePattern.SetValue(DateTime.Now.ToShortTimeString())
                End If

            End Sub
    }

    End Function

    ''' <summary>
    ''' Creates a scenario demonstrating ComboBox interaction
    ''' using ExpandCollapsePattern, SelectionPattern,
    ''' and SelectionItemPattern.
    ''' </summary>
    ''' <returns>
    ''' Configured ComboBox scenario.
    ''' </returns>
    Private Function GetComboBoxScenario() As TestScenario

        Return New TestScenario(
        "ComboBox UIA Api",
        "Changing the selected item in a drop-down list of combobox using ExpandCollapsePattern, SelectionPattern and SelectionItemPattern."
    ) With {
        .Scenario =
            Sub()

                ' Add items for scenario.
                Dim department As New InputComboBox With {
                    .Name = "Department",
                    .DropDownStyle = InputComboBoxStyle.DropDownList,
                    .Width = 180
                }

                department.Items.Add(
                    New InputOption("Engineering") With {
                        .Name = "optionEngineering"
                    })

                department.Items.Add(
                    New InputOption("Sales") With {
                        .Name = "optionSales"
                    })

                department.Items.Add(
                    New InputOption("Marketing") With {
                        .Name = "optionMarketing"
                    })

                department.Items.Add(
                    New InputOption("Finance") With {
                        .Name = "optionFinance"
                    })

                department.Items.Add(
                    New InputOption("Human Resources") With {
                        .Name = "optionHumanResource"
                    })

                department.Items.Add(
                    New InputOption("Support") With {
                        .Name = "optionSupport"
                    })

                c1InputPanel1.Items.Add(department)

                ' UIA Test Scenario
                ' C1InputPanel as root element.
                Dim inputPanel As AutomationElement =
                    AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        New AndCondition(
                            New PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                        ))

                If inputPanel Is Nothing Then
                    Return
                End If

                Dim departmentEditor As AutomationElement =
                    inputPanel.FindFirst(
                        TreeScope.Descendants,
                        New PropertyCondition(
                            AutomationElement.NameProperty,
                            "Department"))
                If departmentEditor Is Nothing Then
                    Return
                End If

                Dim departmentValuePattern As ValuePattern =
                    CType(
                        departmentEditor.GetCurrentPattern(ValuePattern.Pattern),
                        ValuePattern)
                If departmentValuePattern Is Nothing Then
                    Return
                End If

                ' ExpandCollapsePattern of the Department editor.
                Dim departmentExpandCollapsePattern As ExpandCollapsePattern =
                    CType(
                        departmentEditor.GetCurrentPattern(ExpandCollapsePattern.Pattern),
                        ExpandCollapsePattern)

                If departmentExpandCollapsePattern IsNot Nothing AndAlso String.IsNullOrEmpty(departmentValuePattern.Current.Value) AndAlso
                   departmentExpandCollapsePattern.Current.ExpandCollapseState =
                   ExpandCollapseState.Collapsed Then

                    departmentExpandCollapsePattern.Expand()

                    Dim departmentList As AutomationElement =
                        inputPanel.FindFirst(
                            TreeScope.Descendants,
                            New AndCondition(
                                New PropertyCondition(
                                    AutomationElement.ControlTypeProperty,
                                    ControlType.List),
                                New PropertyCondition(
                                    AutomationElement.NameProperty,
                                    "Department")
                            ))
                    If departmentList Is Nothing Then
                        Return
                    End If

                    Dim [option] As AutomationElement =
                        departmentList.FindFirst(
                            TreeScope.Descendants,
                            New PropertyCondition(
                                AutomationElement.NameProperty,
                                "optionHumanResource"))
                    If [option] Is Nothing Then
                        Return
                    End If

                    Dim departmentSelectionPattern As SelectionPattern =
                        CType(
                            departmentList.GetCurrentPattern(SelectionPattern.Pattern),
                            SelectionPattern)

                    If departmentSelectionPattern IsNot Nothing AndAlso Not departmentSelectionPattern.Current.GetSelection().Contains([option]) Then

                        Dim optionEngineeringSelectionItemPattern As SelectionItemPattern =
                            CType(
                                [option].GetCurrentPattern(SelectionItemPattern.Pattern),
                                SelectionItemPattern)

                        optionEngineeringSelectionItemPattern.AddToSelection()

                    End If

                    departmentExpandCollapsePattern.Collapse()

                End If

            End Sub
    }

    End Function

    ''' <summary>
    ''' Removes dynamically added items from the input panel.
    ''' </summary>
    Private Sub ClearInputPanel()

        ' Remove items after the second group header.
        Dim lastIndex = c1InputPanel1.Items.IndexOf(inputGroupHeader2)

        For i As Integer = c1InputPanel1.Items.Count - 1 To lastIndex + 1 Step -1
            c1InputPanel1.Items.RemoveAt(i)
        Next

    End Sub

    ''' <summary>
    ''' Initializes scenario-related UI bindings when the form loads.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        lblDescription.DataSource = GetTestScenarios()
        cmbScenario.DataSource = GetTestScenarios()

        cmbScenario.DisplayMember = "Name"

        lblDescription.DataField = "Description"

    End Sub

End Class
