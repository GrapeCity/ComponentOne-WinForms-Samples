using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using RibbonUITest.Utils;

namespace RibbonUITest.PageObjects
{
    /// <summary>
    /// Provides reusable UI interaction methods for Windows application testing.
    /// </summary>
    public class CommonUIActions
    {
        private readonly WindowsDriver _driver;
        private const string ToggleStateOn = "1";

        /// <summary>
        /// Initializes a new instance of the <see cref="UIActions"/> class.
        /// </summary>
        public CommonUIActions(WindowsDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        /// <summary>
        /// Clicks an element using its accessibility name.
        /// </summary>
        public void Click(string accessId)
        {
            var element = _driver.FindElement("name", accessId); 
            element.Click();
            TestUtility.Wait(2);
        }

        /// <summary>
        /// Enters text into an input field.
        /// </summary>
        public void EnterText(string elementName, string text, bool clearBeforeTyping = true)
        {
            var element = _driver.FindElement("name", elementName); 

            if (clearBeforeTyping)
                element.Clear();
            TestUtility.Wait(2);

            element.SendKeys(text);
            TestUtility.Wait(2);

        }

        /// <summary>
        /// Gets the visible text from a UI element.
        /// </summary>
        public string GetText(string elementName)
        {
            var element = _driver.FindElement("name", elementName); 
            return element.Text;
        }

        /// <summary>
        /// Selects an option from a dropdown (ComboBox) element.
        /// </summary>
        public void SelectDropdownOption(string dropdownName, string optionToSelect)
        {
            var dropdown = _driver.FindElement("name", dropdownName); 
            dropdown.Click(); // Open dropdown
            TestUtility.Wait(2);

            var option = _driver.FindElement("name", optionToSelect); 
            option.Click(); // Select option
            TestUtility.Wait(2);
        }

        /// <summary>
        /// Checks whether a button element is in a toggled (ON) state.
        /// </summary>
        public bool IsButtonToggled(string accessId)
        {
            
            var element = _driver.FindElement("name", accessId);
            var toggleState = element?.GetAttribute("Toggle.ToggleState");
            TestUtility.Wait(2);
            return toggleState == ToggleStateOn; // ON
        }

        /// <summary>
        /// Selects all text in a specified editor or text field.
        /// </summary>
        public void SelectAllText(string editorName)
        {
            var element = _driver.FindElement("name", editorName);
            element.SendKeys(Keys.Control + "a");
            TestUtility.Wait(2);
        }
    }
}
