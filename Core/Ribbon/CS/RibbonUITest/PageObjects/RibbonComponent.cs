using OpenQA.Selenium.Appium.Windows;

namespace RibbonUITest.PageObjects
{
    /// <summary>
    /// Represents the Ribbon UI component and provides methods to interact with buttons and dropdowns.
    /// </summary>
    public class RibbonComponent
    {
        private readonly CommonUIActions _uiActions;

        private readonly Dictionary<string, string> toggleButtons = new()
        {
            { "Bold", "FontBoldButton" },
            { "Italic", "FontItalicButton" },
            { "Underline", "FontUnderlineButton" }
        };

        private readonly Dictionary<string, string> generalButtons = new()
        {
            { "LeftAlign", "Align Left" },
            { "CenterAlign", "Align Center" },
            { "RightAlign", "Align Right" },
            { "Cut", "Cut" },
            { "Copy", "Copy" },
            { "Undo", "Undo" }

        };

        private readonly Dictionary<string, string> ribbonDropdowns = new()
        {
            { "Paste", "PasteSplitButton" },
            { "Font", "FontFaceComboBox" }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RibbonComponent"/> class.
        /// </summary>
        /// <param name="driver">The WindowsDriver instance used for UI interactions.</param>
        public RibbonComponent(WindowsDriver driver)
        {
            _uiActions = new CommonUIActions(driver ?? throw new ArgumentNullException(nameof(driver)));
        }

        /// <summary>
        /// Clicks a ribbon button based on the button name provided.
        /// </summary>
        /// <param name="buttonName">The name of the button to click.</param>
        /// <exception cref="ArgumentException">Thrown if the button name is not found.</exception>

        public void ClickRibbonButton(string buttonName)
        {
            if (toggleButtons.TryGetValue(buttonName, out var accessibilityName) ||
                generalButtons.TryGetValue(buttonName, out accessibilityName))
            {
                _uiActions.Click(accessibilityName);
            }
            else
            {
                throw new ArgumentException($"Ribbon button '{buttonName}' not found.", nameof(buttonName));
            }
        }
        /// <summary>
        /// Selects an option from a ribbon dropdown.
        /// </summary>
        /// <param name="dropdownName">The name of the dropdown.</param>
        public void SelectRibbonDropdownOption(string dropdownName, string valueToSelect)
        {
            if (string.IsNullOrEmpty(dropdownName) || string.IsNullOrEmpty(valueToSelect))
                throw new ArgumentException("Dropdown name and value cannot be null or empty.");

            if (ribbonDropdowns.TryGetValue(dropdownName, out var dropdownAccessibilityName))
            {
                _uiActions.SelectDropdownOption(dropdownAccessibilityName, valueToSelect);
            }
            else
            {
                throw new ArgumentException($"Ribbon dropdown '{dropdownName}' not found.", nameof(dropdownName));
            }
        }
        /// <summary>
        /// Resets all toggle buttons in the ribbon to their default (off) state.
        /// </summary>
        public void ResetAllRibbonButtons()
        {
            foreach (var (buttonName, accessibilityName) in toggleButtons)
            {
                if (_uiActions.IsButtonToggled(accessibilityName))
                {
                    _uiActions.Click(accessibilityName);
                }
            }
            _uiActions.Click(generalButtons["LeftAlign"]);
        }
        /// <summary>
        /// Undoes the previous action in the editor a specified number of times.
        /// </summary>

        public void UndoPreviousAction(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                _uiActions.Click(generalButtons["Undo"]);

            }
        }
    }
}