// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;

namespace WordPad.UiTest.Tests
{
    internal class RibbonTabsTest : BaseTest
    {
        [Test]
        public void Ribbon_IsAvailable()
        {
            // Arrange & Act
            AutomationElement ribbon = UiLocator.FindRibbonElementById(Window);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(ribbon.IsEnabled, Is.True);
                Assert.That(ribbon.Name, Is.EqualTo("Ribbon"));
                Assert.That(ribbon.ControlType, Is.EqualTo(ControlType.Pane));
            });
        }

        [TestCase("HomeTab")]
        [TestCase("ViewTab")]
        public void Ribbon_WhenTabLocated_HasExpectedProperties(string tabName)
        {
            AutomationElement tab = UiLocator.FindRibbonElementByName(Window, tabName);

            Assert.Multiple(() =>
            {
                Assert.That(tab.ControlType, Is.EqualTo(ControlType.TabItem));
                Assert.That(tab.Name, Is.EqualTo(tabName));
                Assert.That(tab.IsEnabled, Is.True);
                Assert.That(tab.Patterns.SelectionItem.IsSupported, Is.True);
            });
        }

        [Test]
        public void Ribbon_WhenFileButtonLocated_HasExpectedProperties()
        {
            // Arrange & Act
            Button backstage = UiLocator.FindButtonByName(Window, "c1BackstageView1");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(backstage.ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(backstage.Name, Is.EqualTo("c1BackstageView1"));
                Assert.That(backstage.IsEnabled, Is.True);
                Assert.That(backstage.Patterns.Invoke.IsSupported, Is.True);
            });
        }

        [Test]
        public void Ribbon_WhenHomeTabClicked_BecomesSelected()
        {
            // Arrange
            AutomationElement home = UiLocator.FindRibbonElementByName(Window, "HomeTab");

            // Act
            home.Click();
            AutomationElement clipboardGroup = UiLocator.FindRibbonElementByName(Window, "Clipboard");
            AutomationElement fontGroup = UiLocator.FindRibbonElementByName(Window, "Font");
            AutomationElement paragraphGroup = UiLocator.FindRibbonElementByName(Window, "Paragraph");
            AutomationElement stylesGroup = UiLocator.FindRibbonElementByName(Window, "Styles");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(home.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);
                Assert.That(clipboardGroup.IsOffscreen, Is.False);
                Assert.That(fontGroup.IsOffscreen, Is.False);
                Assert.That(paragraphGroup.IsOffscreen, Is.False);
                Assert.That(stylesGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_WhenViewTabClicked_BecomesSelected()
        {
            // Arrange
            AutomationElement view = UiLocator.FindRibbonElementByName(Window, "ViewTab");

            // Act
            view.Click();
            AutomationElement zoomGroup = UiLocator.FindRibbonElementByName(Window, "Zoom");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(view.Patterns.SelectionItem.Pattern.IsSelected.Value, Is.True);
                Assert.That(zoomGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_WhenFileButtonClicked_OpensBackstage()
        {
            // Arrange
            Button backstage = UiLocator.FindButtonByName(Window, "c1BackstageView1");

            // Act
            backstage.Patterns.Invoke.Pattern.Invoke();

            MenuItem newMenuItem = UiLocator.FindMenuItemByName(Window, "New");
            MenuItem openMenuItem = UiLocator.FindMenuItemByName(Window, "OpenDocumentTab");
            MenuItem saveMenuItem = UiLocator.FindMenuItemByName(Window, "Save");
            MenuItem saveAsMenuItem = UiLocator.FindMenuItemByName(Window, "SaveDocumentAsTab");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(newMenuItem.IsOffscreen, Is.False);
                Assert.That(openMenuItem.IsOffscreen, Is.False);
                Assert.That(saveMenuItem.IsOffscreen, Is.False);
                Assert.That(saveAsMenuItem.IsOffscreen, Is.False);
            });
        }
    }
}
