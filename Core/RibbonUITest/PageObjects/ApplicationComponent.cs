using OpenQA.Selenium.Appium.Windows;

namespace RibbonUITest.PageObjects
{
    public class ApplicationComponent
    {
        private readonly WindowsDriver _driver;
        private readonly RibbonComponent _ribbonPage;
        private readonly EditorComponent _editorPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationComponent"/> class.
        /// </summary>
        /// <param name="driver">The WindowsDriver instance used to interact with the application UI.</param>
        public ApplicationComponent(WindowsDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            _ribbonPage = new RibbonComponent(driver);
            _editorPage = new EditorComponent(driver);
        }

        /// <summary>
        /// Selects all text in the editor and clicks a ribbon button based on its automation ID.
        /// </summary>
        public void SelectEditorAndClickRibbonButton(String buttonAccessId)
        {
            _editorPage.SelectAllTextInEditor();
            _ribbonPage.ClickRibbonButton(buttonAccessId);
        }
    }
}