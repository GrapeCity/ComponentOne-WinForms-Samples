RendererDemo
-----------------------------------------------------------------------
Shows how you can use the Renderer property to implement custom Renderers.

The solution contains two projects:

1) GridRenderer: 
   Implements a custom renderer called GridRenderer that can be used with 
   any CFlexGrid control in any application.

2) GridRendererDemo:
   Sample that shows how to use the GridRenderer object.

The GridRenderer class contains an editor that can load, save, and modify 
palettes used to generate custom renderers for use with the C1FlexGrid.

You can use this sample to create a library of Visual Styles that can be
saved to files and reused across applications.

The renderers created with this sample are based on the GridRendererOffice2007
class that is included with the C1FlexGrid. The sample shows only how to 
customize the renderer colors, it does not take advantage of advanced renderer
capabilities such as OwnerDraw.
