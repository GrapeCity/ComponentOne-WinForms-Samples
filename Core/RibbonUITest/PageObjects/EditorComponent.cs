using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace RibbonUITest.PageObjects
{
    public class EditorComponent
    {
        private readonly CommonUIActions _uiActions;
        private readonly WindowsDriver _driver;
        private readonly string _editorAccessibilityName;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditorComponent"/> class.
        /// </summary>
        /// <param name="driver">The WindowsDriver instance used for interacting with UI elements.</param>
        /// <param name="editorAccessibilityName">The accessibility name of the editor element. Defaults to "RichEdit Control".</param>

        public EditorComponent(WindowsDriver driver, string editorAccessibilityName = "RichEdit Control")
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            _uiActions = new CommonUIActions(driver);
            _editorAccessibilityName = editorAccessibilityName;
        }

        /// <summary>
        /// Selects all text inside the editor.
        /// </summary>
        public void SelectAllTextInEditor()
        {
            _uiActions.SelectAllText(_editorAccessibilityName);
        }

        /// <summary>
        /// Enters the specified text into the editor.
        /// </summary>
        public void EnterTextInEditor(string text)
        {
            _uiActions.EnterText(_editorAccessibilityName, text);
        }

        /// <summary>
        /// Retrieves the current text from the editor.
        /// </summary>
        public string GetTextFromEditor()
        {
            return _uiActions.GetText(_editorAccessibilityName);
        }

        /// <summary>
        /// Clears all text from the editor by selecting and deleting it.
        /// </summary>
        public void ClearText()
        {
            var editor = _driver.FindElement("name",_editorAccessibilityName);
            _uiActions.Click(_editorAccessibilityName);
            editor?.SendKeys(Keys.Control + "a");  // Select all text
            editor?.SendKeys(Keys.Backspace);  // Delete selected text
        }
    }
}
