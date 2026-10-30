// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;
using Clipboard = System.Windows.Forms.Clipboard;

namespace WordPad.UiTest.Tests
{
    internal class RibbonClipboardGroupTest : BaseTest
    {
        private static readonly string[] _controls =
            [
            "PasteSplitButton",
            "Cut",
            "Copy",
            "Format Painter"
            ];

        [Test]
        public void Ribbon_ClipboardGroup_HasExpectedProperties()
        {
            // Arrange
            AutomationElement clipboardGroup = UiLocator.FindRibbonElementByName(Window, "Clipboard");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(clipboardGroup, Is.Not.Null);
                Assert.That(clipboardGroup.ControlType, Is.EqualTo(ControlType.Group));
                Assert.That(clipboardGroup.IsEnabled, Is.True);
                Assert.That(clipboardGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_ClipboardGroup_ContainsExpectedControls()
        {
            // Arrange
            AutomationElement clipboardGroup = UiLocator.FindRibbonElementByName(Window, "Clipboard");
            AutomationElement[] children = clipboardGroup.FindAllChildren();

            // Assert
            Assert.That(children.Select(c => c.Name), Is.EquivalentTo(_controls));
        }

        [Test]
        public void Ribbon_PasteSplitButton_HasExpectedProperties()
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, "PasteSplitButton");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.SplitButton));
                Assert.That(button.IsEnabled, Is.True);
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Patterns.ExpandCollapse.Pattern, Is.Not.Null);
            });
        }

        [Test]
        public void Ribbon_CutButton_HasExpectedProperties()
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, "Cut");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsEnabled, Is.False);
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Patterns.Invoke.Pattern, Is.Not.Null);
            });
        }

        [Test]
        public void Ribbon_CopyButton_HasExpectedProperties()
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, "Copy");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsEnabled, Is.False);
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Patterns.Invoke.Pattern, Is.Not.Null);
            });
        }

        [Test]
        public void Ribbon_FormatButton_HasExpectedProperties()
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, "Format Painter");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsEnabled, Is.True);
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Patterns.Invoke.Pattern, Is.Not.Null);
            });
        }

        [Test]
        public void RibbonCutButton_WhenInvoked_RemovesSelectedText()
        {
            // Arrange
            TextBox editor = UiLocator.FindTextEditorElementById(Window);
            editor.Enter("Hello World");
            editor.Text = "Hello World";
            editor.Focus();
            SelectAllTextAction();
            Button cut = UiLocator.FindButtonByName(Window, "Cut");

            // Act
            cut.AsButton().Invoke();

            // Assert
            Assert.That(string.IsNullOrWhiteSpace(editor.Text), Is.True);
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void RibbonCopyButton_WhenInvoked_CopiesSelectedText()
        {
            // Arrange
            TextBox editor = UiLocator.FindTextEditorElementById(Window);
            editor.Enter("Hello");
            editor.Focus();
            SelectAllTextAction();
            Button copy = UiLocator.FindButtonByName(Window, "Copy");

            // Act
            copy.Invoke();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(Clipboard.ContainsText(), Is.True);
                Assert.That(Clipboard.GetText(), Is.EqualTo("Hello"));
            });
        }

        [Test]
        [Apartment(ApartmentState.STA)]
        public void RibbonPasteButton_WhenInvoked_PastesClipboardText()
        {
            // Arrange
            Clipboard.SetText("Clipboard Text");
            TextBox editor = UiLocator.FindTextEditorElementById(Window);
            Button paste = UiLocator.FindButtonByName(Window, "PasteSplitButton");

            // Act
            editor.Focus();
            SelectAllTextAction();
            paste.Invoke();

            // Assert
            Assert.That(editor.Text, Does.Contain("Clipboard Text"));
        }

        #region private helper
        private static void SelectAllTextAction()
        {
            Keyboard.Press(VirtualKeyShort.CONTROL);
            Keyboard.Press(VirtualKeyShort.KEY_A);
            Keyboard.Release(VirtualKeyShort.KEY_A);
            Keyboard.Release(VirtualKeyShort.CONTROL);
        }
        #endregion
    }
}
