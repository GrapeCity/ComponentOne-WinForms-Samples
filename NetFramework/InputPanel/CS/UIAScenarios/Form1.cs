using C1.Win.InputPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;

namespace UIAScenarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Run Scenario button click event
        /// and executes the currently selected test scenario.
        /// </summary>
        private void BtnRunScenario_Click(object sender, EventArgs e) => RunSelectedScenarion((TestScenario)cmbScenario.SelectedItem);

        /// <summary>
        /// Executes the specified test scenario and manages UI state during execution.
        /// </summary>
        /// <param name="item">Scenario to execute.</param>
        private void RunSelectedScenarion(TestScenario item)
        {
            btnRunScenario.Enabled = false;
            ClearInputPanel();
            item.Scenario?.Invoke();
            btnRunScenario.Enabled = true;
        }

        /// <summary>
        /// Returns all available UI Automation test scenarios.
        /// </summary>
        /// <returns>
        /// Collection of configured test scenarios.
        /// </returns>
        private IEnumerable<TestScenario> GetTestScenarios()
            => new List<TestScenario>
            {
                GetReplaceScenario(),
                GetCheckBoxScenario(),
                GetRadioButtonScenario(),
                GetTextEditorScenario(),
                GetComboBoxScenario(),
            };

        /// <summary>
        /// Creates a scenario demonstrating text replacement
        /// using UI Automation patterns.
        /// </summary>
        /// <returns>
        /// Configured replace scenario.
        /// </returns>
        private TestScenario GetReplaceScenario()
        {
            return new TestScenario(
                "Replace words in a InputTextBox",
                "This test scenario updates records in the data source and uses InvokePattern to navigate through records and ValuePattern to edit records.")
            {
                Scenario = () =>
                {
                    // add items for scenario
                    var source = SampleDataSource.CreateProductsSource();
                    c1InputPanel1.Items.Add(new InputLabel() { Text = "Item", Width = 100, HorizontalAlign = InputContentAlignment.Far });
                    c1InputPanel1.Items.Add(new InputTextBox() { DataSource = source, DataField = "Name", Name = "NameEditor", Width = 250 });
                    c1InputPanel1.Items.Add(new InputLabel() { Text = "Description", Width = 100, HorizontalAlign = InputContentAlignment.Far });
                    c1InputPanel1.Items.Add(new InputTextBox() { DataSource = source, DataField = "Description", Name = "DescriptionEditor", Width = 250, Multiline = true, ElementHeight = 60 });
                    c1InputPanel1.Items.Add(
                        new InputDataNavigator()
                        {
                            Name = "ProductsNavigator",
                            DataSource = source,
                            AddNewImage = Properties.Resources.navIBindingList_AddNewImage,
                            ApplyImage = Properties.Resources.navEmployees_ApplyImage,
                            CancelImage = Properties.Resources.navEmployees_CancelImage,
                            DeleteImage = Properties.Resources.navEmployees_DeleteImage,
                            EditImage = Properties.Resources.navEmployees_EditImage,
                            MoveFirstImage = Properties.Resources.navEmployees_MoveFirstImage,
                            MoveLastImage = Properties.Resources.navEmployees_MoveLastImage,
                            MoveNextImage = Properties.Resources.navEmployees_MoveNextImage,
                            MovePreviousImage = Properties.Resources.navEmployees_MovePreviousImage,
                        });

                    // UIA Test Scenario
                    // C1InputPanel as root element
                    AutomationElement inputPanel = AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                            )
                        );

                    if (inputPanel is null)
                        return;

                    AutomationElement nameEditor = inputPanel.FindFirst(
                        TreeScope.Descendants,
                        new PropertyCondition(
                            AutomationElement.NameProperty,
                            "NameEditor"));
                    if (nameEditor is null)
                        return;

                    // Description property editor
                    AutomationElement descriptionEditor = inputPanel.FindFirst(
                        TreeScope.Descendants,
                        new PropertyCondition(
                            AutomationElement.NameProperty,
                            "DescriptionEditor"));
                    if (descriptionEditor is null)
                        return;
                    // ValuePattern of the Descroption property editor
                    ValuePattern descriptionEditorValuePattern = (ValuePattern)descriptionEditor.GetCurrentPattern(ValuePattern.Pattern);
                    if (descriptionEditorValuePattern is null)
                        return;

                    // Data navigator
                    AutomationElement navigator = inputPanel.FindFirst(
                        TreeScope.Descendants,
                        new PropertyCondition(
                            AutomationElement.NameProperty,
                            "ProductsNavigator"));
                    // Next button of the Data navigator
                    AutomationElement nextButton =
                        navigator.FindFirst(
                            TreeScope.Descendants,
                            new AndCondition(
                                new PropertyCondition(
                                    AutomationElement.ControlTypeProperty,
                                    ControlType.Button),
                                new PropertyCondition(
                                    AutomationElement.NameProperty,
                                    "NavigatorButton Move Next")));
                    if (nextButton is null)
                        return;
                    // InvokePattern of the Next button
                    InvokePattern nextInvoke = (InvokePattern)nextButton.GetCurrentPattern(InvokePattern.Pattern);
                    if (nextInvoke is null)
                        return;

                    bool isNextEnabled = nextButton.Current.IsEnabled;
                    while (isNextEnabled)
                    {
                        nameEditor.SetFocus();

                        var currentDescription = descriptionEditorValuePattern.Current.Value;
                        string updated = Regex.Replace(
                            currentDescription,
                            "computer",
                            "PC",
                            RegexOptions.IgnoreCase);

                        if (currentDescription != updated)
                            descriptionEditorValuePattern.SetValue(updated);

                        isNextEnabled = nextButton.Current.IsEnabled;
                        if (isNextEnabled)
                        {
                            nextInvoke.Invoke();
                            Thread.Sleep(100);
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Creates a scenario demonstrating checkbox interaction
        /// using the TogglePattern.
        /// </summary>
        /// <returns>
        /// Configured checkbox scenario.
        /// </returns>
        private TestScenario GetCheckBoxScenario()
        {
            return new TestScenario(
                "InputCheckBox UIA Api",
                "Checking and toggling a checkbox using the TogglePattern."
                )
            {
                Scenario = () =>
                {
                    // add items for scenario
                    c1InputPanel1.Items.Add(new InputCheckBox
                    {
                        Name = "CSharp",
                        Text = "C#"
                    });
                    c1InputPanel1.Items.Add(new InputCheckBox
                    {
                        Name = "Sql",
                        Text = "SQL"
                    });
                    c1InputPanel1.Items.Add(new InputCheckBox
                    {
                        Name = "Azure",
                        Text = "Azure"
                    });
                    c1InputPanel1.Items.Add(new InputCheckBox
                    {
                        Name = "JavaScript",
                        Text = "JavaScript"
                    });
                    // UIA Test Scenario
                    // C1InputPanel as root element
                    AutomationElement inputPanel = AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                            )
                        );

                    if (inputPanel is null)
                        return;

                    Action<string, ToggleState> setToggleState = (elementName, desiredState) =>
                    {
                        AutomationElement element = inputPanel.FindFirst(TreeScope.Descendants,
                            new PropertyCondition(AutomationElement.NameProperty, elementName));

                        if (element is null)
                            return;

                        TogglePattern togglePattern = (TogglePattern)element.GetCurrentPattern(TogglePattern.Pattern);

                        if (togglePattern != null && togglePattern.Current.ToggleState != desiredState)
                            togglePattern.Toggle();
                    };

                    setToggleState("CSharp", ToggleState.On);
                    setToggleState("Sql", ToggleState.Off);
                    setToggleState("Azure", ToggleState.Off);
                    setToggleState("JavaScript", ToggleState.On);
                }
            };
        }

        /// <summary>
        /// Creates a scenario demonstrating radio button selection
        /// using the SelectionItemPattern.
        /// </summary>
        /// <returns>
        /// Configured radio button scenario.
        /// </returns>
        private TestScenario GetRadioButtonScenario()
        {
            return new TestScenario(
                "InputRadioButton UIA Api",
                "Checking and selecting a radio button using the SelectionItemPattern."
                )
            {
                Scenario = () =>
                {
                    // add items for scenario
                    c1InputPanel1.Items.Add(new InputRadioButton
                    {
                        Name = "FullTime",
                        GroupName = "EmploymentType",
                        Text = "Full-time",
                        Checked = true
                    });
                    c1InputPanel1.Items.Add(new InputRadioButton
                    {
                        Name = "PartTime",
                        GroupName = "EmploymentType",
                        Text = "Part-time"
                    });
                    c1InputPanel1.Items.Add(new InputRadioButton
                    {
                        Name = "Contractor",
                        GroupName = "EmploymentType",
                        Text = "Contractor"
                    });
                    // UIA Test Scenario
                    // C1InputPanel as root element
                    AutomationElement inputPanel = AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                            )
                        );

                    if (inputPanel is null)
                        return;

                    AutomationElement contractor = inputPanel.FindFirst(
                        TreeScope.Descendants,
                        new PropertyCondition(
                            AutomationElement.NameProperty,
                            "Contractor"));
                    if (contractor is null)
                        return;

                    SelectionItemPattern contractorSelectionItemPattern = (SelectionItemPattern)contractor.GetCurrentPattern(SelectionItemPattern.Pattern);
                    if (contractorSelectionItemPattern != null && !contractorSelectionItemPattern.Current.IsSelected)
                        contractorSelectionItemPattern.AddToSelection();
                }
            };
        }

        /// <summary>
        /// Creates a scenario demonstrating interaction with
        /// text editor controls using ValuePattern and RangeValuePattern.
        /// </summary>
        /// <returns>
        /// Configured text editor scenario.
        /// </returns>
        private TestScenario GetTextEditorScenario()
        {
            return new TestScenario(
                "TextEditor's UIA Api",
                "Changing a value in input text editors using ValuePattern or RangeValuePattern."
                )
            {
                Scenario = () =>
                {
                    // add items for scenario
                    c1InputPanel1.Items.Add(new InputTextBox() { Name = "InputTextBoxUIA" });
                    c1InputPanel1.Items.Add(new InputMaskedTextBox() { Name = "InputMaskedTextBoxUIA" });
                    c1InputPanel1.Items.Add(new InputComboBox() { Name = "InputComboBoxUIA" });
                    c1InputPanel1.Items.Add(new InputNumericBox() { Name = "InputNumericBoxUIA" });
                    c1InputPanel1.Items.Add(new InputDatePicker() { Name = "InputDatePickerUIA" });
                    c1InputPanel1.Items.Add(new InputTimePicker() { Name = "InputTimePickerUIA" });
                    // UIA Test Scenario
                    // C1InputPanel as root element
                    AutomationElement inputPanel = AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                            )
                        );

                    if (inputPanel is null)
                        return;

                    Action<string, string> setValue = (elementName, value) =>
                    {
                        AutomationElement element = inputPanel.FindFirst(TreeScope.Descendants,
                            new PropertyCondition(AutomationElement.NameProperty, elementName));

                        if (element is null)
                            return;

                        ValuePattern valuePattern = (ValuePattern)element.GetCurrentPattern(ValuePattern.Pattern);
                        valuePattern?.SetValue(value);
                    };

                    setValue("InputTextBoxUIA", "text");
                    setValue("InputMaskedTextBoxUIA", "text");
                    setValue("InputComboBoxUIA", "combo text");

                    AutomationElement numericBox = inputPanel.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.NameProperty, "InputNumericBoxUIA"));
                    if (numericBox is null)
                        return;
                    RangeValuePattern rangeValuePattern = (RangeValuePattern)numericBox.GetCurrentPattern(RangeValuePattern.Pattern);
                    rangeValuePattern?.SetValue(50);

                    setValue("InputDatePickerUIA", DateTime.Today.ToShortDateString());

                    AutomationElement timePicker = inputPanel.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.NameProperty, "InputTimePickerUIA"));
                    if (timePicker is null)
                        return;
                    AutomationElement valueEditor = timePicker.FindFirst(TreeScope.Descendants,
                        new PropertyCondition(AutomationElement.NameProperty, "Value"));
                    if (valueEditor is null)
                        return;
                    ValuePattern valueEditorValuePattern = (ValuePattern)valueEditor.GetCurrentPattern(ValuePattern.Pattern);
                    valueEditorValuePattern?.SetValue(DateTime.Now.ToShortTimeString());
                }
            };
        }

        /// <summary>
        /// Creates a scenario demonstrating ComboBox interaction
        /// using ExpandCollapsePattern, SelectionPattern,
        /// and SelectionItemPattern.
        /// </summary>
        /// <returns>
        /// Configured ComboBox scenario.
        /// </returns>
        private TestScenario GetComboBoxScenario()
        {
            return new TestScenario(
                "ComboBox UIA Api",
                "Changing the selected item in a drop-down list of combobox using ExpandCollapsePattern, SelectionPattern and SelectionItemPattern."
                )
            {
                Scenario = () =>
                {
                    // add items for scenario
                    var department = new InputComboBox
                    {
                        Name = "Department",
                        DropDownStyle = InputComboBoxStyle.DropDownList,
                        Width = 180
                    };
                    department.Items.Add(new InputOption("Engineering") { Name = "optionEngineering" });
                    department.Items.Add(new InputOption("Sales") { Name = "optionSales" });
                    department.Items.Add(new InputOption("Marketing") { Name = "optionMarketing" });
                    department.Items.Add(new InputOption("Finance") { Name = "optionFinance" });
                    department.Items.Add(new InputOption("Human Resources") { Name = "optionHumanResource" });
                    department.Items.Add(new InputOption("Support") { Name = "optionSupport" });
                    c1InputPanel1.Items.Add(department);
                    // UIA Test Scenario
                    // C1InputPanel as root element
                    AutomationElement inputPanel = AutomationElement.RootElement.FindFirst(
                        TreeScope.Descendants,
                        new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.Pane),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                c1InputPanel1.Name)
                            )
                        );

                    if (inputPanel is null)
                        return;

                    AutomationElement departmentEditor = inputPanel.FindFirst(
                         TreeScope.Descendants,
                         new PropertyCondition(
                             AutomationElement.NameProperty,
                             "Department"));
                    if (departmentEditor is null)
                        return;

                    ValuePattern departmentValuePattern = (ValuePattern)departmentEditor.GetCurrentPattern(ValuePattern.Pattern);
                    if (departmentValuePattern is null)
                        return;

                    // ExpandCollapsePattern of the Department editor
                    ExpandCollapsePattern departmentExpandCollapsePattern = (ExpandCollapsePattern)departmentEditor.GetCurrentPattern(ExpandCollapsePattern.Pattern);
                    if (string.IsNullOrEmpty(departmentValuePattern.Current.Value)
                        && departmentExpandCollapsePattern.Current.ExpandCollapseState == ExpandCollapseState.Collapsed)
                    {
                        departmentExpandCollapsePattern.Expand();

                        AutomationElement departmentList = inputPanel.FindFirst(
                            TreeScope.Descendants,
                            new AndCondition(
                            new PropertyCondition(
                                AutomationElement.ControlTypeProperty,
                                ControlType.List),
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                "Department")
                            )
                        );
                        if (departmentList is null)
                            return;

                        AutomationElement option = departmentList.FindFirst(
                            TreeScope.Descendants,
                            new PropertyCondition(
                                AutomationElement.NameProperty,
                                "optionHumanResource"));
                        if (option is null)
                            return;

                        SelectionPattern departmentSelectionPattern = (SelectionPattern)departmentList.GetCurrentPattern(SelectionPattern.Pattern);
                        if (departmentSelectionPattern != null && !departmentSelectionPattern.Current.GetSelection().Contains(option))
                        {
                            SelectionItemPattern optionEngineeringSelectionItemPattern = (SelectionItemPattern)option.GetCurrentPattern(SelectionItemPattern.Pattern);
                            optionEngineeringSelectionItemPattern.AddToSelection();
                        }

                        departmentExpandCollapsePattern.Collapse();
                    }
                }
            };
        }

        /// <summary>
        /// Removes dynamically added items from the input panel.
        /// </summary>
        private void ClearInputPanel()
        {
            // remove items after second group header
            var lastIndex = c1InputPanel1.Items.IndexOf(inputGroupHeader2);
            for (int i = c1InputPanel1.Items.Count - 1; i > lastIndex; i--)
                c1InputPanel1.Items.RemoveAt(i);
        }

        /// <summary>
        /// Initializes scenario-related UI bindings when the form loads.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDescription.DataSource = cmbScenario.DataSource = GetTestScenarios();
            cmbScenario.DisplayMember = "Name";
            lblDescription.DataField = "Description";
        }

    }
}