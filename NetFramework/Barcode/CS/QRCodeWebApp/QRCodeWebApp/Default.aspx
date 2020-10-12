<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QRCodeWebApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Script/jquery-1.5.2.min.js" type="text/javascript" ></script>
    <style type="text/css">
        body
        {
        	font-family: "Tahoma";
        	font-size: 11pt;
        }
    </style>

    <script type="text/javascript">
        $(document).ready(function () {
            UpdateImage();

            $('#_btn').click(function () {
                UpdateImage();
            });
        });
        function UpdateImage() {
            var text = "GetBarCode.aspx?t=" + $('#_tbx').val();
            $('#_img').attr('src', text);
            $('#_img').attr('alt', text);
        }
    </script>
</head>
<body>
    <h1>C1BarCode</h1>

    <p>This sample uses the <b>C1BarCode</b> control to generate bar code images on the server, 
    based on input provided by the user.</p>

    <p>Enter the text you want to encode in the text box below, then click the "Generate" button
    to see the barcode image on the page.</p>

    <p>This sample uses the <b>C1BarCode (V2/2011)</b> to create QR codes, which can be scanned 
    with most smart phones. To test it, grab your phone, start the free scanner app, and point the 
    camera at the image below.</p>

    <form id="form1" runat="server" style='background-color:#d0d0d0'>
        <table>
            <tr>
                <td>Text to encode: </td>
                <td><input id="_tbx" type="text" value="C1BarCode" style='width:400px' /></td>
                <td><input id="_btn" type="button" value="Generate" /></td>
            </tr>
            <tr>
                <td>QR Code: </td>
                <td><img id="_img" /></td>
            </tr>
        </table>
    </form>

    <p><b>Implementation Notes</b>: The barcode is generated in response to a regular http 
    request. The url contains parameters that specify the text to be encoded. The 
    "GetBarCode.aspx" page parses the parameters, generates the image, and inserts the byte 
    stream into the <b>Response</b> object. There are no temporary files or custom http handlers.</p>

    <p>Using the barcode generator is extremely easy. All you need to do is include an image
    tag on your page and set the "SRC" parameter to "GetBarCode.aspx?t=TEXT_TO_ENCODE".</p>

    <p>For example, the image below was created with this HTML snippet:</p>

    <pre>&lt;img src='GetBarCode.aspx?t=C1BarCode' /&gt;:</pre>

    <p><img src="GetBarCode.aspx?t=C1BarCode" /></p>
</body>
</html>
