// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.WindowsAPI;

namespace WordPad.UiTest.Tests
{
    internal class RibbonFontGroupTest : BaseTest
    {
        private static readonly string[] _controls =
            [
            "FontFaceComboBox",
            "FontSizeComboBox",
            "FontBoldButton",
            "FontItalicButton",
            "FontUnderlineButton",
            "Strikeout",
            "FontColorPicker",
            "BackColorPicker",
            "FontGroup Launcher"
            ];

        private static readonly string[] _buttons =
            [
            "FontBoldButton",
            "FontItalicButton",
            "FontUnderlineButton",
            "Strikeout",
            ];

        private static readonly string[] _comboBoxes =
            [
            "FontFaceComboBox",
            "FontSizeComboBox"
            ];

        private static readonly string[] _colorPickers =
            [
            "FontColorPicker",
            "BackColorPicker"
            ];

        [Test]
        public void Ribbon_FontGroup_HasExpectedProperties()
        {
            // Arrange
            var fontGroup = UiLocator.FindRibbonElementByName(Window, "Font");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(fontGroup.ControlType, Is.EqualTo(ControlType.Group));
                Assert.That(fontGroup.IsEnabled, Is.True);
                Assert.That(fontGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_FontGroup_ContainsExpectedControls()
        {
            // Arrange
            AutomationElement fontGroup = UiLocator.FindRibbonElementByName(Window, "Font");
            AutomationElement[] children = fontGroup.FindAllChildren();

            // Assert
            Assert.That(children.Select(c => c.Name), Is.EquivalentTo(_controls));
        }

        [TestCaseSource(nameof(_buttons))]
        public void Ribbon_FontButton_HasExpectedProperties(string name)
        {
            // Arrange
            AutomationElement button = UiLocator.FindRibbonElementByName(Window, name);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsEnabled, Is.True);
                Assert.That(button.IsOffscreen, Is.False);
                Assert.That(button.Patterns.Toggle.Pattern, Is.Not.Null);
            });
        }

        [TestCaseSource(nameof(_comboBoxes))]
        public void Ribbon_FontComboBox_HasExpectedProperties(string name)
        {
            // Arrange
            AutomationElement comboBox = UiLocator.FindRibbonElementByName(Window, name);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(comboBox.ControlType, Is.EqualTo(ControlType.ComboBox));
                Assert.That(comboBox.IsEnabled, Is.True);
                Assert.That(comboBox.IsOffscreen, Is.False);
                Assert.That(comboBox.Patterns.ExpandCollapse.Pattern, Is.Not.Null);
            });
        }

        [TestCaseSource(nameof(_colorPickers))]
        public void Ribbon_FontColorPicker_HasExpectedProperties(string name)
        {
            // Arrange
            var picker = UiLocator.FindRibbonElementByName(Window, name);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(picker.IsEnabled, Is.True);
                Assert.That(picker.IsOffscreen, Is.False);
                Assert.That(picker.Patterns.ExpandCollapse.Pattern, Is.Not.Null);
            });
        }

        [TestCaseSource(nameof(_buttons))]
        public void RibbonFontButton_WhenInvoked_TogglesState(string name)
        {
            // Arrange
            var button = UiLocator.FindRibbonElementByName(Window, name).AsButton();
            ToggleState toggleState = button.Patterns.Toggle.Pattern.ToggleState.Value;

            // Act
            button.Click();

            // Assert
            Assert.That(button.Patterns.Toggle.Pattern.ToggleState.Value, Is.Not.EqualTo(toggleState));
        }

        [Test]
        public void RibbonFontFaceComboBox_WhenSelectionChanged_UpdatesSelection()
        {
            // Arrange
            ComboBox combo = UiLocator.FindRibbonElementByName(Window, "FontFaceComboBox").AsComboBox();

            // Act
            combo.Select("Arial");
            AutomationElement arial = UiLocator.FindRibbonElementByName(Window, "Arial");
            arial.Patterns.SelectionItem.Pattern.Select();

            // Assert
            Assert.That(arial.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);
        }

        [Test]
        public void RibbonFontSizeComboBox_WhenSelectionChanged_UpdatesSelection()
        {
            // Arrange
            var combo = UiLocator.FindRibbonElementByName(Window, "FontSizeComboBox").AsComboBox();

            // Act
            combo.Select("20");
            AutomationElement fontSize = UiLocator.FindRibbonElementByName(Window, "20");
            fontSize.Patterns.SelectionItem.Pattern.Select();

            // Assert
            Assert.That(fontSize.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);
        }

        [Test]
        public void RibbonFontColorPicker_WhenExpanded_DoesNotThrow()
        {
            // Arrange
            var picker = UiLocator.FindRibbonElementByName(Window, "FontColorPicker");

            // Assert
            Assert.DoesNotThrow(() =>
                picker.Patterns.ExpandCollapse.Pattern.Expand());
        }

        [Test]
        public void RibbonBackColorPicker_WhenExpanded_DoesNotThrow()
        {
            // Arrange
            var picker = UiLocator.FindRibbonElementByName(Window, "BackColorPicker");

            // Assert
            Assert.DoesNotThrow(() =>
                picker.Patterns.ExpandCollapse.Pattern.Expand());
        }

        [Test]
        public void RibbonFontDialogLauncher_WhenInvoked_OpensFontDialog()
        {
            // Arrange
            var launcher = UiLocator.FindButtonByName(Window, "FontGroup Launcher");

            // Act
            launcher.Click();

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
