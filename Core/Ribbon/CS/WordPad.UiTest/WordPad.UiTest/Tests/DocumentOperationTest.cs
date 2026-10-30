// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;

namespace WordPad.UiTest.Tests
{
    internal class DocumentOperationTest : BaseTest
    {
        [Test]
        public void Document_WhenClickedNew_CreatesNewDocument()
        {
            // Arrange
            TextBox textEditor = UiLocator.FindTextEditorElementById(Window);
            string text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Not.Empty);

            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "New").Click();

            // Assert
            textEditor = UiLocator.FindTextEditorElementById(Window);
            text = textEditor.Patterns.Text.Pattern.DocumentRange.GetText(int.MaxValue);
            Assert.That(text, Is.Empty);
        }

        [Test]
        public void Document_WhenClickedOpen_OpensDocument()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "OpenDocumentTab").Click();
            UiLocator.FindElement(Window, cf => cf.ByAutomationId("tabButton1"), "Browse").Click();

            // Assert
            bool opened = UiWaiter.Until(
              () => Window.FindFirstChild(cf => cf.ByClassName("#32770")) != null,
              timeout: TimeSpan.FromSeconds(2),
              interval: TimeSpan.FromMilliseconds(100));

            Assert.That(opened, Is.True);
            Keyboard.Press(VirtualKeyShort.ESCAPE);
        }

        [Test]
        public void Document_WhenClickedSave_OpensSaveDialog()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "New").Click();
            UiLocator.FindTextEditorElementById(Window).Enter("C1Ribbon WordPad Sample");
            UiLocator.FindButtonByName(Window, "Save").Click();

            // Assert
            bool opened = UiWaiter.Until(
                () => Window.FindFirstChild(cf => cf.ByClassName("#32770")) != null,
                timeout: TimeSpan.FromSeconds(2),
                interval: TimeSpan.FromMilliseconds(100));

            Assert.That(opened, Is.True);
            Keyboard.Press(VirtualKeyShort.ESCAPE);
        }

        [Test]
        public void Document_WhenClickedSaveAs_OpensSaveDialog()
        {
            // Act
            UiLocator.FindButtonByName(Window, "c1BackstageView1").Click();
            UiLocator.FindMenuItemByName(Window, "SaveDocumentAsTab").Click();
            UiLocator.FindElement(Window, cf => cf.ByAutomationId("tabButton1"), "Browse").Click();

            // Assert
            bool opened = UiWaiter.Until(
               () => Window.FindFirstChild(cf => cf.ByClassName("#32770")) != null,
               timeout: TimeSpan.FromSeconds(2),
               interval: TimeSpan.FromMilliseconds(100));

            Assert.That(opened, Is.True);
            Keyboard.Press(VirtualKeyShort.ESCAPE);
        }
    }
}