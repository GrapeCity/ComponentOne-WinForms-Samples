// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;

namespace WordPad.UiTest.Tests
{
    internal class RibbonParagraphGroupTest : BaseTest
    {
        private static readonly string[] _controls =
            [
            "Decrease Indent",
            "Increase Indent",
            "Align Left",
            "Align Center",
            "Align Right"
            ];

        [Test]
        public void Ribbon_ParagraphGroup_HasExpectedProperties()
        {
            // Arrange
            var paragraphGroup = UiLocator.FindRibbonElementByName(Window, "Paragraph");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(paragraphGroup.ControlType, Is.EqualTo(ControlType.Group));
                Assert.That(paragraphGroup.IsEnabled, Is.True);
                Assert.That(paragraphGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_ParagraphGroup_ContainsExpectedControls()
        {
            // Arrange
            var paragraphGroup = UiLocator.FindRibbonElementByName(Window, "Paragraph");
            var children = paragraphGroup.FindAllChildren();

            // Assert
            Assert.That(children.Select(c => c.Name), Is.EquivalentTo(_controls));
        }

        [TestCase("Decrease Indent", false)]
        [TestCase("Increase Indent", false)]
        [TestCase("Align Left", true)]
        [TestCase("Align Center", true)]
        [TestCase("Align Right", true)]
        public void Ribbon_ParagraphButton_HasExpectedProperties(string name, bool supportsToggle)
        {
            // Arrange
            var button = UiLocator.FindRibbonElementByName(Window, name);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(button.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(button.IsEnabled, Is.True);
                Assert.That(button.IsOffscreen, Is.False);

                if (supportsToggle)
                {
                    Assert.That(button.Patterns.Toggle.Pattern, Is.Not.Null);
                }
                else
                {
                    Assert.That(button.Patterns.Invoke.Pattern, Is.Not.Null);
                }
            });
        }

        [TestCase("Decrease Indent")]
        [TestCase("Increase Indent")]
        public void RibbonIndentButton_WhenInvoked_DoesNotThrow(string name)
        {
            // Arrange
            var button = UiLocator.FindRibbonElementByName(Window, name).AsButton();

            // Assert
            Assert.DoesNotThrow(() => button.Invoke());
        }

        [TestCase("Align Left")]
        [TestCase("Align Center")]
        [TestCase("Align Right")]
        public void RibbonAlignmentButton_WhenInvoked_TogglesSelection(string name)
        {
            // Arrange
            Button button = UiLocator.FindButtonByName(Window, name);

            // Act
            button.Click();

            // Assert
            Assert.That(button.Patterns.Toggle.Pattern.ToggleState.Value, Is.EqualTo(ToggleState.On));
        }
    }
}
