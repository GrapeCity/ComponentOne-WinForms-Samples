// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;

namespace WordPad.UiTest.Tests
{
    internal class RibbonButtonTest : BaseTest
    {
        [TestCase("c1BackstageView1")]
        [TestCase("SimplifiedView")]
        public void Ribbon_WhenFileButtonLocated_HasExpectedProperties(string buttonName)
        {
            // Arrange
            Button backstage = UiLocator.FindButtonByName(Window, buttonName);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(backstage.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(backstage.IsEnabled, Is.True);
                Assert.That(backstage.Name, Is.EqualTo(buttonName));
                Assert.That(backstage.Patterns.Invoke.IsSupported, Is.True);
            });
        }

        [Test]
        public void Ribbon_WhenFileButtonInvoked_OpensBackstage()
        {
            // Arrange
            Button backstage = UiLocator.FindButtonByName(Window, "c1BackstageView1");

            // Act
            backstage.Patterns.Invoke.Pattern.Invoke();

            // Assert
            MenuItem newCommand = UiLocator.FindMenuItemByName(Window, "New");
            Assert.That(newCommand.IsEnabled, Is.True);
        }

        [Test]
        public void Ribbon_WhenSimplifiedViewInvoked_ChangesRibbonLayout()
        {
            // Arrange
            Button simplifiedView = UiLocator.FindButtonByName(Window, "SimplifiedView");
            AutomationElement clipboardGroup = UiLocator.FindRibbonElementByName(Window, "Clipboard");
            double heightWhenExpanded = clipboardGroup.ActualHeight;

            // Act
            simplifiedView.Patterns.Invoke.Pattern.Invoke();

            // Assert
            Assert.That(clipboardGroup.ActualHeight, Is.LessThan(heightWhenExpanded));
        }

        [Test]
        public void Ribbon_WhenThemeChanged_ThemeChanges()
        {
            // Arrange
            AutomationElement themeCombo = UiLocator.FindRibbonElementByName(Window, "ribbonStyleCombo");
            themeCombo.Click();

            AutomationElement office365White = UiLocator.FindRibbonElementByName(Window, "Office365White");
            AutomationElement expressionDark = UiLocator.FindRibbonElementByName(Window, "ExpressionDark");
            Assert.That(office365White.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);

            // Act
            expressionDark.Patterns.SelectionItem.Pattern.Select();
            Assert.That(expressionDark.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);
        }
    }
}
