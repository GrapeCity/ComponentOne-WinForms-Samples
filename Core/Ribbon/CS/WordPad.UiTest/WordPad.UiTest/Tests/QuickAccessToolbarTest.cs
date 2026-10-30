// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;

namespace WordPad.UiTest.Tests
{
    internal class QuickAccessToolbarTest : BaseTest
    {
        [Test]
        public void QuickAccessToolbar_IsAvailable()
        {
            // Arrange
            AutomationElement quickAccessToolbar = UiLocator.FindRibbonElementByName(Window, "ribbonQat1");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(quickAccessToolbar.ControlType, Is.EqualTo(ControlType.Pane));
                Assert.That(quickAccessToolbar.IsEnabled, Is.True);
                Assert.That(quickAccessToolbar.Name, Is.EqualTo("ribbonQat1"));
            });
        }

        [TestCase("Save")]
        [TestCase("Undo")]
        [TestCase("Redo")]
        [TestCase("Customize Qat")]
        public void QuickAccessToolbar_ContainsQATButton(string buttonName)
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, buttonName);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Name, Is.EqualTo(buttonName));
            });
        }

        [Test]
        public void QuickAccessToolbar_SaveButton_CanBeInvoked()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "New").Click();
            UiLocator.FindTextEditorElementById(Window).Enter("C1Ribbon WordPad Sample");
            Button saveButton = UiLocator.FindButtonByName(Window, "Save");
            saveButton.Click();

            // Assert
            var dialogOpened = UiWaiter.Until(
                () => Window.FindFirstChild(cf => cf.ByClassName("#32770")) != null,
                timeout: TimeSpan.FromSeconds(2),
                interval: TimeSpan.FromMilliseconds(100));

            Assert.That(dialogOpened, Is.True);
            Keyboard.Press(VirtualKeyShort.ESCAPE);
        }

        [Test]
        public void QuickAccessToolbar_UndoButton_CanBeInvoked()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "New").Click();
            TextBox textEditor = UiLocator.FindTextEditorElementById(Window);
            string text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Empty);

            textEditor.Enter("C1Ribbon WordPad Sample");
            textEditor = UiLocator.FindTextEditorElementById(Window);
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Not.Empty);

            Button undoButton = UiLocator.FindButtonByName(Window, "Undo");
            undoButton.Click();
            textEditor = UiLocator.FindTextEditorElementById(Window);
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);

            // Assert         
            Assert.That(text, Is.Empty);
        }

        [Test]
        public void QuickAccessToolbar_RedoButton_CanBeInvoked()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "New").Click();
            TextBox textEditor = UiLocator.FindTextEditorElementById(Window);
            string text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Empty);

            textEditor.Enter("C1Ribbon WordPad Sample");
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Not.Empty);

            Button undoButton = UiLocator.FindButtonByName(Window, "Undo");
            undoButton.Click();
            textEditor = UiLocator.FindTextEditorElementById(Window);
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Empty);

            Button redoButton = UiLocator.FindButtonByName(Window, "Redo");
            redoButton.Click();
            textEditor = UiLocator.FindTextEditorElementById(Window);
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);

            // Assert         
            Assert.That(text, Is.Not.Empty);
        }

        [Test]
        public void QuickAccessToolbar_CustomizeQATButton_CanBeInvoked()
        {
            // Arrange
            Button customizeQATButton = UiLocator.FindButtonByName(Window, "Customize Qat");

            // Act
            customizeQATButton.Click();

            // Assert
            MenuItem showMenuItem = UiLocator.FindMenuItemByName(Window, "Show Below the Ribbon");
            MenuItem minimizeMenuItem = UiLocator.FindMenuItemByName(Window, "Minimize the Ribbon");
            Assert.Multiple(() =>
            {
                Assert.That(showMenuItem.IsOffscreen, Is.False);
                Assert.That(minimizeMenuItem.IsOffscreen, Is.False);
            });
        }
    }
}
