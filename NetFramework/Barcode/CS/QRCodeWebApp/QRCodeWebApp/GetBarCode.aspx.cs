using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QRCodeWebApp
{
    public partial class GetBarCode : System.Web.UI.Page
    {
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
    }
}