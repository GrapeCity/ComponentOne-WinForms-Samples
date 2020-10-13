MultiGridPage
------------------------------------------------------------------------------
Shows how you can create a PrintDocument with several grids on a single page.

The sample loads two grids with Product Categories and Employees data, and
allows you to print a document containing both grids rendered on a single
page.

The sample handles printing by creating a PrintDocument object and rendering
the grids as images.

The grid images are created using the CreateImage method, which allows you 
to specify the portions of the grid you want to render (this is handy for
rendering large grids that span multiple pages, which is not the case in
this sample).

Once you have a grid image, can render it using the Graphics.DrawImage method,
which allows you to specify a rectangle where the image will be rendered.