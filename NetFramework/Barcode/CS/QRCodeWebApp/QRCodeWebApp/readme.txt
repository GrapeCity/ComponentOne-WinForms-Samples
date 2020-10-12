QRCodeWebApp
------------------------------------------------------------------------------------------
Demonstrates how to use C1BarCode to create barcodes in web applications.

This sample uses the C1QRCode control to generate bar code images on the server, based 
on input provided by the user.

The barcode is generated in response to a regular http request. The url contains parameters 
that specify the text to be encoded.

The "GetBarCode.aspx" page parses the parameters, generates the image, and inserts the byte 
stream into the Response object, without any temporary files or custom http handlers.

Here is the barcode generation code (on the server side):

<code>
    protected void Page_Load(object sender, EventArgs e)
    {
        using (var bc = new C1.Win.C1BarCode.C1QRCode())
        {
            // get parameters
            var text = Request.Params["t"];

            // create image
            bc.Text = text;
            bc.SymbolSize = 2;
            bc.BackColor = System.Drawing.Color.Transparent;
            var img = bc.GetImage(System.Drawing.Imaging.ImageFormat.Png);

            // create response
            var ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            Response.BinaryWrite(ms.ToArray());
            Response.ContentType = "image/png";
        }
    }
</code>

Using this barcode generator is extremely easy. All you need to do is include an image
tag on your page and set the "SRC" parameter to "GetBarCode.aspx?t=TEXT_TO_ENCODE".

When the user enters some text and clicks the button, the following javascript method
is executed to build a new url containing the text to encode and assign it to the image's 
"SRC" property:

<code>
  <script type="text/javascript">
        $(document).ready(function () {

			// update the image when loading the page for the first time
            UpdateImage();

			// update the image when the user clicks the button
            $('#_btn').click(function () {
                UpdateImage();
            });
        });
        function UpdateImage() {

			// build URL to request barcode image
            var text = "GetBarCode.aspx?t=" + $('#_tbx').val();

			// assign the new URL to the IMG element on the page
            $('#_img').attr('src', text);
            $('#_img').attr('alt', text);
        }
    </script>
</code>