using C1.Win.Input;
using InputExplorer.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;

namespace InputExplorer.Samples
{
    public partial class CommandBinding : UserControl
    {
        private readonly ShowControlStateCommand _command;

        public CommandBinding()
        {
            InitializeComponent();
            _command = new ShowControlStateCommand(this);
            AddCommandBindings();
            SetText();
        }

        private void AddCommandBindings()
        {
            c1Button1.Command = _command;
            c1Button1.CommandParameter = "ButtonParam";

            c1CheckBox2.Command = _command;
            c1CheckBox2.CommandParameter = "CheckBoxParam";

            c1ComboBox1.Command = _command;
            c1ComboBox1.CommandParameter = "ComboBoxParam";

            c1DropDownControl1.Command = _command;
            c1DropDownControl1.CommandParameter = "DropDownClosedParam";
            c1DropDownControl1.DropDownOpened += (s, e) => _command.Execute("DropDownOpenedParam");
            c1DropDownControl1.TextChanged += (s, e) => _command.Execute("DropDownTextParam");

            c1MaskedTextBox1.Command = _command;
            c1MaskedTextBox1.CommandParameter = "MaskedTextBoxParam";

            c1NumericEdit1.Command = _command;
            c1NumericEdit1.CommandParameter = "NumericEditParam";

            c1RadioButton1.Command = _command;
            c1RadioButton1.CommandParameter = "RadioButtonParam1";

            c1RadioButton2.Command = _command;
            c1RadioButton2.CommandParameter = "RadioButtonParam2";

            c1RangeSlider1.Command = _command;
            c1RangeSlider1.CommandParameter = "RangeSliderParam";

            c1SplitButton1.Command = _command;
            c1SplitButton1.CommandParameter = "SplitButtonParam";
            void OnSplitItemClick(object s, EventArgs e) =>
                _command.Execute($"SplitItem:{((SplitButtonItem)s).Text}");
            Item1.Click += OnSplitItemClick;
            Item2.Click += OnSplitItemClick;
            Item3.Click += OnSplitItemClick;
            subItem1.Click += OnSplitItemClick;
            subItem2.Click += OnSplitItemClick;
            subItem3.Click += OnSplitItemClick;

            c1TextBox1.Command = _command;
            c1TextBox1.CommandParameter = "TextBoxParam";

            c1ToggleSwitch1.Command = _command;
            c1ToggleSwitch1.CommandParameter = "ToggleSwitchParam";
        }

        private void enableCommandsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _command.CanExecuteValue = enableCommandsCheckBox.Checked;
            _command.RaiseCanExecuteChanged();
        }

        private void SetText()
        {
            InputControlsPanelHeading.Text = Resources.Label_InputControlsPanelHeading;
            OutputPanelHeading.Text = Resources.Label_OutputPanelHeading;
            enableCommandsCheckBox.Text = Resources.CheckBox_EnableCommands;

            c1Buttonlb.Text = Resources.Label_C1Buttonlb;
            c1CheckBoxlb.Text = Resources.Label_C1CheckBoxlb;
            c1ComboBoxlb.Text = Resources.Label_C1ComboBoxlb;
            c1DropDownControllb.Text = Resources.Label_C1DropDownControllb;
            c1MaskedTextBoxlb.Text = Resources.Label_C1MaskedTextBoxlb;
            c1NumericEditlb.Text = Resources.Label_C1NumericEditlb;
            c1RadioButtonlb.Text = Resources.Label_C1RadioButtonlb;
            c1RangeSliderlb.Text = Resources.Label_C1RangeSliderlb;
            c1SplitButtonlb.Text = Resources.Label_C1SplitButtonlb;
            c1TextBoxlb.Text = Resources.Label_C1TextBoxlb;
            c1ToggleSwitchlb.Text = Resources.Label_C1ToggleSwitchlb;
            commandOutputlb.Text = Resources.Label_CommandOutputlb;


            c1Button1.Text = Resources.Button_C1Button;
            c1CheckBox2.Text = Resources.CheckBox_C1CheckBox;
            c1RadioButton1.Text = Resources.RadioButton_C1RadioButton1;
            c1RadioButton2.Text = Resources.RadioButton_C1RadioButton2;
            c1SplitButton1.Text = Resources.Button_C1SplitButton;
        }

        private class ShowControlStateCommand : ICommand
        {
            private readonly CommandBinding _userControl;

            public ShowControlStateCommand(CommandBinding userControl) => _userControl = userControl;

            public bool CanExecuteValue { get; set; } = true;

            public bool CanExecute(object parameter) => CanExecuteValue;

            public void Execute(object parameter)
            {
                if (parameter is "ComboBoxParam")
                {
                    _userControl.BeginInvoke(() =>
                        _userControl.commandOutputlb.Text = $"C1ComboBox Selected: {_userControl.c1ComboBox1.Text}");
                    return;
                }

                _userControl.commandOutputlb.Text = parameter switch
                {
                    "ButtonParam" => "C1Button Clicked",
                    "CheckBoxParam" => $"C1CheckBox: {(_userControl.c1CheckBox2.Checked ? "Checked" : "Unchecked")}",
                    "DropDownClosedParam" => "C1DropDownControl Closed",
                    "DropDownOpenedParam" => "C1DropDownControl Opened",
                    "DropDownTextParam" => $"C1DropDownControl Text: {_userControl.c1DropDownControl1.Text}",
                    "MaskedTextBoxParam" => $"C1MaskedTextBox Text: {_userControl.c1MaskedTextBox1.Text}",
                    "NumericEditParam" => $"C1NumericEdit Value: {_userControl.c1NumericEdit1.Value}",
                    "RadioButtonParam1" => $"C1RadioButton1 Selected",
                    "RadioButtonParam2" => $"C1RadioButton2 Selected",
                    "RangeSliderParam" => $"C1RangeSlider Range: {(int)_userControl.c1RangeSlider1.LowerValue} \u2013 {(int)_userControl.c1RangeSlider1.UpperValue}",
                    "SplitButtonParam" => "C1SplitButton Clicked",
                    "TextBoxParam" => $"C1TextBox Text: {_userControl.c1TextBox1.Text}",
                    "ToggleSwitchParam" => $"C1ToggleSwitch: {(_userControl.c1ToggleSwitch1.Value ? "On" : "Off")}",
                    string s when s.StartsWith("SplitItem:") => $"C1SplitButton Item: {s["SplitItem:".Length..]}",
                    _ => $"Unknown: {parameter}"
                };
            }

            public event EventHandler CanExecuteChanged;

            public void RaiseCanExecuteChanged() =>
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
