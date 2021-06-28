Feature_RenderTextJustifyChars
---------------------------------------------------
Demonstrates the style property JustifyChars

This sample demonstrates a special mode of horizontal text alignment set by the AlignHorzEnum.JustifyChars member of AlignHorzEnum enumeration.
In that mode, space is added between all characters in text rather than only between words when justifying text horizontally as in AlignHorzEnum.Justify mode.

Note that this feature works only if UseGdiPlusTextRendering on the C1PrintDocument is set to false, otherwise this property is interpreted as AlignHorzEnum.Justify.