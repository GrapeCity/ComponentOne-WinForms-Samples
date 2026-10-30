// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.InputPanel;
using System;
using System.Windows.Input;

namespace ControlExplorer.InputPanel
{
    public partial class CommandBinding : C1DemoForm
    {
        private readonly ShowControlStateCommand _command;

        public CommandBinding()
        {
            InitializeComponent();
            _command = new ShowControlStateCommand(this);
            AddCommandBindings();
        }
        /// <summary>
        /// Assigns the shared command and corresponding command parameters
        /// to all supported input controls and hooks menu/split button item click events.
        /// </summary>
        private void AddCommandBindings()
        {
            inputButton1.Command = _command;
            inputButton1.CommandParameter = "ButtonParam";

            inputCheckBox1.Command = _command;
            inputCheckBox1.CommandParameter = "CheckBoxParam";

            inputComboBox1.Command = _command;
            inputComboBox1.CommandParameter = "ComboBoxParam";

            inputDatePicker1.Command = _command;
            inputDatePicker1.CommandParameter = "DatePickerParam";

            inputMaskedTextBox1.Command = _command;
            inputMaskedTextBox1.CommandParameter = "MaskedTextBoxParam";

            inputMenu1.Command = _command;
            inputMenu1.CommandParameter = "MenuParam";
            void OnMenuItemClick(object s, EventArgs e) =>
                _command.Execute($"MenuItem:{((InputComponent)s).Text}");
            inputButton6.Click += OnMenuItemClick;
            inputButton7.Click += OnMenuItemClick;
            inputButton8.Click += OnMenuItemClick;

            inputNumericBox1.Command = _command;
            inputNumericBox1.CommandParameter = "NumericEditParam";

            inputRadioButton1.Command = _command;
            inputRadioButton1.CommandParameter = "RadioButtonParam1";

            inputRadioButton2.Command = _command;
            inputRadioButton2.CommandParameter = "RadioButtonParam2";

            inputSplitButton1.Command = _command;
            inputSplitButton1.CommandParameter = "SplitButtonParam";
            void OnSplitItemClick(object s, EventArgs e) =>
                _command.Execute($"SplitItem:{((InputComponent)s).Text}");
            inputButton2.Click += OnSplitItemClick;
            inputButton3.Click += OnSplitItemClick;
            inputSplitButton2.Click += OnSplitItemClick;
            inputButton4.Click += OnSplitItemClick;
            inputButton5.Click += OnSplitItemClick;

            inputTextBox1.Command = _command;
            inputTextBox1.CommandParameter = "TextBoxParam";

            inputTimePicker1.Command = _command;
            inputTimePicker1.CommandParameter = "TimePickerParam";
        }
        /// <summary>
        /// Enables or disables command execution for all bound controls.
        /// </summary>
        private void enableCommandsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _command.CanExecuteValue = enableCommandsCheckBox.Checked;
            _command.RaiseCanExecuteChanged();
        }
        /// <summary>
        /// Represents a command that displays the current state or value
        /// of the control that invoked it.
        /// </summary>
        private class ShowControlStateCommand : ICommand
        {
            private readonly CommandBinding _form;
            /// <summary>
            /// Initializes a new instance of the <see cref="ShowControlStateCommand"/> class.
            /// </summary>
            /// <param name="form">
            /// The control that owns the input components and output label.
            /// </param>
            public ShowControlStateCommand(CommandBinding form) => _form = form;
            /// <summary>
            /// Gets or sets a value indicating whether the command can execute.
            /// </summary>
            public bool CanExecuteValue { get; set; } = true;
            /// <summary>
            /// Determines whether the command can execute.
            /// </summary>
            /// <param name="parameter">The command parameter.</param>
            /// <returns>
            /// <see langword="true"/> if the command is enabled; otherwise,
            /// <see langword="false"/>.
            /// </returns>
            public bool CanExecute(object parameter) => CanExecuteValue;
            /// <summary>
            /// Executes the command and updates the output label with the
            /// current state or value of the invoking control.
            /// </summary>
            /// <param name="parameter">
            /// The command parameter identifying the control or menu item.
            /// </param>
            public void Execute(object parameter)
            {
                if (Equals(parameter, "ComboBoxParam"))
                {
                    _form.BeginInvoke((Action)(() =>
                        _form.commandOutputlb.Text = $"InputComboBox1 Selected: {_form.inputComboBox1.Text}"));
                    return;
                }

                string text;

                switch (parameter as string)
                {
                    case "ButtonParam":
                        text = "InputButton Clicked";
                        break;

                    case "CheckBoxParam":
                        text = $"InputCheckBox: {(_form.inputCheckBox1.Checked ? "Checked" : "Unchecked")}";
                        break;

                    case "DatePickerParam":
                        text = $"InputDatePicker Value: {_form.inputDatePicker1.Value}";
                        break;

                    case "MaskedTextBoxParam":
                        text = $"InputMaskedTextBox Text: {_form.inputMaskedTextBox1.Text}";
                        break;

                    case "NumericEditParam":
                        text = $"InputNumericEdit Value: {_form.inputNumericBox1.Value}";
                        break;

                    case "RadioButtonParam1":
                        text = "InputRadioButton1 Selected";
                        break;

                    case "RadioButtonParam2":
                        text = "InputRadioButton2 Selected";
                        break;

                    case "SplitButtonParam":
                        text = "InputSplitButton Clicked";
                        break;

                    case "MenuParam":
                        text = "InputMenu Clicked";
                        break;

                    case "TextBoxParam":
                        text = $"InputTextBox Text: {_form.inputTextBox1.Text}";
                        break;

                    case "TimePickerParam":
                        text = $"InputTimePicker Value: {_form.inputTimePicker1.Value}";
                        break;

                    default:
                        var value = parameter as string;

                        if (value != null && value.StartsWith("SplitItem:"))
                        {
                            text = "InputSplitButton Item: " +
                                   value.Substring("SplitItem:".Length);
                        }
                        else if (value != null && value.StartsWith("MenuItem:"))
                        {
                            text = "InputMenu Item: " +
                                   value.Substring("MenuItem:".Length);
                        }
                        else
                        {
                            text = $"Unknown: {parameter}";
                        }

                        break;
                }

                _form.commandOutputlb.Text = text;
            }
            /// <summary>
            /// Occurs when changes affecting the result of
            /// <see cref="CanExecute(object)"/> occur.
            /// </summary>
            public event EventHandler CanExecuteChanged;
            /// <summary>
            /// Raises the <see cref="CanExecuteChanged"/> event.
            /// </summary>
            public void RaiseCanExecuteChanged() =>
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
