// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.Definitions;

namespace WordPad.UiTest.Tests
{
    internal class RibbonStylesGroupTest : BaseTest
    {
        private static readonly string[] _controls =
            [
            "styleGallery"
            ];

        [Test]
        public void Ribbon_StylesGroup_HasExpectedProperties()
        {
            // Arrange
            var stylesGroup = UiLocator.FindRibbonElementByName(Window, "Styles");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(stylesGroup.ControlType, Is.EqualTo(ControlType.Group));
                Assert.That(stylesGroup.IsEnabled, Is.True);
                Assert.That(stylesGroup.IsOffscreen, Is.False);
            });
        }

        [Test]
        public void Ribbon_StylesGroup_ContainsExpectedControls()
        {
            // Arrange
            var stylesGroup = UiLocator.FindRibbonElementByName(Window, "Styles");
            var children = stylesGroup.FindAllChildren();

            // Assert
            Assert.That(children.Select(c => c.Name), Is.EquivalentTo(_controls));
        }

        [Test]
        public void Ribbon_StyleGallery_HaveExpectedControlTypes()
        {
            // Arrange
            var gallery = UiLocator.FindRibbonElementByName(Window, "styleGallery");
            var children = gallery.FindAllChildren();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(children.Single(c => c.Name == "styleGallery").ControlType, Is.EqualTo(ControlType.List));
                Assert.That(children.Single(c => c.Name == "Open").ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(children.Single(c => c.Name == "Line up").ControlType, Is.EqualTo(ControlType.Button));
                Assert.That(children.Single(c => c.Name == "Line down").ControlType, Is.EqualTo(ControlType.Button));
            });
        }

        [Test]
        public void Ribbon_StyleGalleryList_ContainsListItems()
        {
            // Arrange
            var gallery = UiLocator.FindRibbonElementByName(Window, "styleGallery");
            var list = gallery.FindFirstChild(cf => cf.ByControlType(ControlType.List));

            // Act
            var items = list?.FindAllChildren();

            // Assert
            Assert.That(items, Is.Not.Empty);

            Assert.Multiple(() =>
            {
                foreach (var item in items)
                {
                    Assert.That(item.ControlType, Is.EqualTo(ControlType.ListItem));
                    Assert.That(item.Patterns.SelectionItem.Pattern, Is.Not.Null);
                }
            });
        }

        [Test]
        public void RibbonStyleGallery_WhenItemSelected_SelectionChanges()
        {
            // Arrange
            var gallery = UiLocator.FindRibbonElementByName(Window, "styleGallery");
            var list = gallery.FindFirstChild(cf => cf.ByControlType(ControlType.List));

            Assert.That(list, Is.Not.Null);

            var items = list!.FindAllChildren();
            Assert.That(items, Is.Not.Empty);

            var firstItem = items.First();

            // Act
            firstItem.Patterns.SelectionItem.Pattern.Select();

            // Assert
            Assert.That(
                firstItem.Patterns.SelectionItem.Pattern.IsSelected.Value,
                Is.True);
        }

        [Test]
        public void RibbonStyleGallery_WhenItemFocused_ItemReceivesFocus()
        {
            // Arrange
            var gallery = UiLocator.FindRibbonElementByName(Window, "styleGallery");
            var list = gallery.FindFirstChild(cf => cf.ByControlType(ControlType.List));

            Assert.That(list, Is.Not.Null);

            var item = list!.FindAllChildren().First();

            // Act
            item.Focus();

            // Assert
            Assert.That(item.IsEnabled, Is.True);
        }
    }
}
