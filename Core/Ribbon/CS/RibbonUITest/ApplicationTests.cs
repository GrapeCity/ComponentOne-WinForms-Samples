using OpenQA.Selenium.Appium.Windows;
using RibbonUITest.Drivers;
using RibbonUITest.PageObjects;
using RibbonUITest.Utils;
using Xunit.Abstractions;

namespace RibbonUITest
{
    public class ApplicationTests : IClassFixture<DriverFixture>
    {
        private readonly WindowsDriver _driver;
        private readonly RibbonComponent _ribbonComponent;
        private readonly EditorComponent _editorComponent;
        private readonly ApplicationComponent _applicationComponent;
        private readonly ITestOutputHelper _testOutputHelper;

        public ApplicationTests(DriverFixture fixture, ITestOutputHelper testOutputHelper)
        {
            _driver = fixture.DriverManager.GetDriver();
            _ribbonComponent = new RibbonComponent(_driver);
            _editorComponent = new EditorComponent(_driver);
            _applicationComponent = new ApplicationComponent(_driver);
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData("Bold", "Bold_Expected.png", "Bold_Actual.png", "Bold_Diff.png")]
        [InlineData("Italic", "Italic_Expected.png", "Italic_Actual.png", "Italic_Diff.png")]
        [InlineData("Underline", "Underline_Expected.png", "Underline_Actual.png", "Underline_Diff.png")]
        public void FontStyleButtonClick_ShouldApplyExpectedStyle_WhenButtonIsClicked(
            string fontStyle,
            string expectedImagePath,
            string actualImagePath,
            string diffImagePath)
        {
            // Arrange - Test setup is done in constructor

            // Act
            _applicationComponent.SelectEditorAndClickRibbonButton(fontStyle);
            TestUtility.CaptureScreenshotFromPercentage(_driver, actualImagePath, _testOutputHelper);
            _ribbonComponent.UndoPreviousAction(4);

            // Assert
            bool imagesMatch = TestUtility.CompareImages(expectedImagePath, actualImagePath, diffImagePath, _testOutputHelper);
            Assert.True(imagesMatch, $"The applied {fontStyle} style should match the expected visual style.");
        }

        [Theory]
        [InlineData("Arial", "Arial_Black_Expected.png", "Arial_Black_Actual.png", "Arial_Black_Diff.png")]
        public void FontFamily_ShouldChangeTextAppearance_WhenNewFontIsSelected(
            string fontFamily,
            string expectedImagePath,
            string actualImagePath,
            string diffImagePath)
        {
            // Arrange - Test setup is done in constructor

            // Act
            _ribbonComponent.SelectRibbonDropdownOption("Font", fontFamily);

            var fontDialog = _driver.FindElement("name", "");
            fontDialog.FindElement("name", "Open").Click();
            _driver.FindElement("name", "Arial").Click();

            TestUtility.CaptureScreenshotFromPercentage(_driver, actualImagePath, _testOutputHelper);

            // Assert
            Assert.True(
                TestUtility.CompareImages(expectedImagePath, actualImagePath, diffImagePath, _testOutputHelper),
                $"The text should appear in {fontFamily} font family as expected."
            );
            // Cleanup
            _ribbonComponent.UndoPreviousAction(2);
        }

        [Theory]
        [InlineData("RightAlign", "Right_Align_Expected.png", "Right_Align_Actual.png", "Right_Align_Diff.png")]
        [InlineData("LeftAlign", "Left_Align_Expected.png", "Left_Align_Actual.png", "Left_Align_Diff.png")]
        [InlineData("CenterAlign", "Center_Align_Expected.png", "Center_Align_Actual.png", "Center_Align_Diff.png")]
        public void TextAlignment_ShouldChangeParagraphLayout_WhenAlignmentIsChanged(
            string alignment,
            string expectedImagePath,
            string actualImagePath,
            string diffImagePath)
        {
            // Arrange - Test setup is done in constructor

            // Act
            _applicationComponent.SelectEditorAndClickRibbonButton(alignment);
            TestUtility.CaptureScreenshotFromPercentage(_driver, actualImagePath, _testOutputHelper);

            // Cleanup
            _ribbonComponent.UndoPreviousAction(2);

            // Assert
            bool imagesMatch = TestUtility.CompareImages(expectedImagePath, actualImagePath, diffImagePath, _testOutputHelper);
            Assert.True(imagesMatch, $"The text alignment should match the expected {alignment} layout.");
        }

        [Fact]
        public void CutOperation_ShouldRemoveSelectedText_WhenCutIsPerformed()
        {
            // Arrange
            string initialText = "Sample text for cut operation";
            _editorComponent.ClearText();
            _editorComponent.EnterTextInEditor(initialText);

            // Act
            _applicationComponent.SelectEditorAndClickRibbonButton("Cut");
            string editorText = _editorComponent.GetTextFromEditor();

            // Cleanup
            _ribbonComponent.UndoPreviousAction(2);

            // Assert
            Assert.True(string.IsNullOrEmpty(editorText), "The editor should be empty after performing the Cut operation.");
        }

        [Fact]
        public void CopyOperation_ShouldPreserveOriginalText_WhenTextIsCopied()
        {
            // Arrange
            string sampleText = "Copy Text Sample";
            _editorComponent.ClearText();
            _editorComponent.EnterTextInEditor(sampleText);

            // Act
            _applicationComponent.SelectEditorAndClickRibbonButton("Copy");
            string copiedText = _editorComponent.GetTextFromEditor();

            // Cleanup
            _ribbonComponent.UndoPreviousAction(4);

            // Assert
            Assert.Equal(sampleText, copiedText);
        }

        [Fact]
        public void PasteOperation_ShouldDuplicateText_WhenTextIsCopiedAndPasted()
        {
            // Arrange
            string sampleText = "Paste Test Sample";
            _editorComponent.ClearText();
            _editorComponent.EnterTextInEditor(sampleText);

            // Act
            _applicationComponent.SelectEditorAndClickRibbonButton("Copy");
            _ribbonComponent.SelectRibbonDropdownOption("Paste", "Paste");
            string pastedText = _editorComponent.GetTextFromEditor();

            // Cleanup
            _ribbonComponent.UndoPreviousAction(4);

            // Assert
            Assert.Equal(sampleText, pastedText);
        }
    }
}