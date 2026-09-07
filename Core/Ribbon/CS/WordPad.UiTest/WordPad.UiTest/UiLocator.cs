// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Tools;

namespace WordPad.UiTest
{
    internal static class UiLocator
    {
        private static readonly TimeSpan _retryTimeout = TimeSpan.FromSeconds(2);

        internal static AutomationElement FindElement(AutomationElement parent, Func<ConditionFactory, ConditionBase> condition, string elementName) =>
            Retry.WhileNull(
                () => parent.FindFirstDescendant(condition), timeout: _retryTimeout).Result
                ?? throw new InvalidOperationException($"Unable to find element: {elementName}");

        internal static AutomationElement FindRibbonElementByName(Window window, string name) =>
            FindElement(FindRibbonElementById(window), cf => cf.ByName(name), name);

        internal static Button FindButtonByName(Window window, string name) =>
            FindRibbonElementByName(window, name).AsButton();

        internal static MenuItem FindMenuItemByName(Window window, string name) =>
            FindRibbonElementByName(window, name).AsMenuItem();

        internal static AutomationElement FindRibbonElementById(Window window) =>
            FindElement(window, cf => cf.ByAutomationId("c1Ribbon1"), "Ribbon");

        internal static TextBox FindTextEditorElementById(Window window) =>
            FindElement(window, cf => cf.ByAutomationId("richTextBox1"), "Text editor").AsTextBox();
    }
}
