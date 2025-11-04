// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.
using C1.Win.Input;

namespace ScrollBarAnnotations.Manager
{
    internal static class TooltipManager
    {
        /// <summary>
        /// Message to be shown in tooltip
        /// </summary>
        /// <param name="checkbox"></param>
        internal static void MessageShownInToolTip(C1CheckBox checkbox, ToolTip toolTip1)
        {
            // Configure tooltip appearance and behavior
            toolTip1.IsBalloon = true; // Display as a balloon-style tooltip
            toolTip1.ToolTipIcon = ToolTipIcon.Info; // Use an information icon

            // Dictionary mapping checkbox names to their tooltip descriptions
            var tooltipTexts = new Dictionary<string, string>
            {
                ["showAnnotationsCheckbox"] = Properties.Resource.ShowAnnotationsDescription,
                ["showErrorsCheckbox"] = Properties.Resource.ShowErrorsDescription,
                ["showSelectedRowCheckbox"] = Properties.Resource.ShowSelectedRowDescription,
                ["showFocusedRowCheckbox"] = Properties.Resource.ShowFocusedRowDescription,
                ["showHighlightedRowCheckbox"] = Properties.Resource.ShowHighlightedRowDescription,
                ["customAnnotation1Checkbox"] = Properties.Resource.CustomAnnotationDescription,
                ["hotKeysCheckbox"] = Properties.Resource.HotKeysDescription,
                ["showScrollTipCheckbox"] = Properties.Resource.ShowScrollTipDescription
            };

            // Attempt to get the tooltip text for the given checkbox name
            // If not found, use a default fallback message
            if (!tooltipTexts.TryGetValue(checkbox.Name, out string? tooltipText))
            {
                tooltipText = Properties.Resource.CheckToolTipMessage;
            }

            // Assign the determined tooltip text to the checkbox
            toolTip1.SetToolTip(checkbox, tooltipText);
        }
    }
}
