// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Themes.Shared;
using ScrollBarAnnotations.Enums;

namespace ScrollBarAnnotations.CustomAnnotations
{
    /// <summary>
    /// Represents a custom scrollbar annotation with a specific type and visual properties.
    /// </summary>
    public class CustomAnnotation : ScrollBarAnnotation
    {
        public CustomAnnotationType Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAnnotation"/> class.
        /// </summary>
        /// <param name="type">The type of the annotation.</param>
        /// <param name="text">The text displayed in the annotation.</param>
        /// <param name="position">The vertical position of the annotation in the scrollbar.</param>
        /// <param name="color">Optional color of the annotation.</param>
        /// <param name="alignment">Horizontal alignment of the text. Default is Center.</param>
        /// <param name="width">Width of the annotation. Default is 100.</param>
        /// <param name="height">Height of the annotation. Default is 2.</param>
        public CustomAnnotation(CustomAnnotationType type, string text, double position, Color? color = null,
            HorizontalAlignment alignment = HorizontalAlignment.Center, int width = 100, int height = 2)
            : base(text, position, color, alignment, width, height)
        {
            Type = type;
        }
    }
}
