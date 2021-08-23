<%@ WebHandler Language="C#" Class="C1ReportHttpHandler" %>
//C1ReportHttpHandler.ashx
using System;
using System.Web;
using System.Collections;

using C1.Web.UI.Controls.C1Report;

public class C1ReportHttpHandler : IHttpHandler
{
    
    

    #region IHttpHandler Members

    public void ProcessRequest(HttpContext context)
    {
        // list of common MIME types and their corresponding file extensions.
        // http://www.webmaster-toolkit.com/mime-types.shtml
        System.Collections.Specialized.NameValueCollection args = context.Request.Params;
        string command = args["command"];
        string reqid = args["reqid"];
        if (string.IsNullOrEmpty(command))
            command = "";
        if (string.IsNullOrEmpty(reqid))
            reqid = "";
        byte[] buffer;
        IC1WebReportService reportService;
        switch (command)
        {
            case "dialog_template":
                context.Response.ContentType = "text/x-html";
                context.Response.Write(GetDialogTemplateContent((string)args["name"]));
                context.Response.End();
                break;
            case "GetPageImagesMarkup":
                context.Response.ContentType = "application/json";
                reportService = C1.Web.UI.Controls.C1Report.ReportService.C1WebReportServiceHelper.MakeHelper((string)args["documentKey"]);
                object answer = reportService.GetPageImagesMarkup((string)args["documentKey"], int.Parse(args["dpi"]), int.Parse(args["zoom"]), (int[])((System.Collections.ArrayList)ToArrayList(args["pageIndices"])).ToArray(typeof(int)), bool.Parse(args["getImagesOnly"]));

                Hashtable result = new Hashtable();
                result["reqid"] = reqid;
                result["answer"] = answer;
                /*
                #if DEBUG
                            if (!string.IsNullOrEmpty(C1Report.__outputdebugstring))
                            {
                                result["__outputdebugstring"] = C1Report.__outputdebugstring;
                                C1Report.__outputdebugstring = "";
                            }
                #endif
                                */
                //string s = C1.Web.UI.Utils.Json.JsonHelper.ObjectToString(result, this, true);                                
                string s = C1.Web.UI.Utils.Json.JsonHelper.ObjectToString(result, null, true);
                context.Response.Write(s);
                context.Response.End();
                break;
            case "Export":
                /*
                Response.Buffer = false;
                Response.AppendHeader("Content-Type", "octet-stream");
                Response.AppendHeader("Content-Disposition", "attachment");
                Response.Flush();
                */
                string exportFormat = args["exportFormat"];
                
                reportService = C1.Web.UI.Controls.C1Report.ReportService.C1WebReportServiceHelper.MakeHelper((string)args["documentKey"]);
                string url = reportService.ExportToFile(args["documentKey"], exportFormat);
                context.Response.ContentType = "text/html";

                System.Text.StringBuilder htmlBuilder = new System.Text.StringBuilder();
                htmlBuilder.AppendLine("<html>");
                htmlBuilder.AppendLine("<header>");
                htmlBuilder.AppendLine("<title>Download " + exportFormat + "</title>");
                if (!url.StartsWith("error:"))
                    htmlBuilder.AppendLine("<meta http-equiv=\"REFRESH\" CONTENT=\"5; url=" + url + "\">");
                htmlBuilder.AppendLine("</header>");
                htmlBuilder.AppendLine("<body>");
                if (!url.StartsWith("error:"))
                {
                    htmlBuilder.AppendLine("<h1>");
                    htmlBuilder.AppendLine("Exported document download.");
                    htmlBuilder.AppendLine("</h1>");
                    htmlBuilder.AppendLine("<p>");
                    htmlBuilder.AppendLine("Your download should begin shortly. If your download does not start in approximately 10 seconds, you can ");
                    htmlBuilder.AppendLine("<a href=\"" + url + "\">");
                    htmlBuilder.AppendLine("click here");
                    htmlBuilder.AppendLine("</a>");
                    htmlBuilder.AppendLine(" to launch the download.</p>");

                    htmlBuilder.AppendLine("<div style=\"background-color:#cccccc;\">");
                    htmlBuilder.AppendLine("Download URL: " + "<a href=\"" + url + "\">" + url + "</a>");
                    htmlBuilder.AppendLine("<br />");
                    htmlBuilder.AppendLine("Export Format: " + exportFormat);
                    htmlBuilder.AppendLine("<br />");
                    htmlBuilder.AppendLine("Internal Document Key: " + args["documentKey"]);
                    htmlBuilder.AppendLine("</div>");                                        
                    
                }
                else
                {
                    htmlBuilder.AppendLine("<h2 style=\"color:red;\">" + url + "</h2>");
                }
                htmlBuilder.AppendLine("</body>");
                htmlBuilder.AppendLine("</html>");
                context.Response.Write(htmlBuilder.ToString());      
                context.Response.End();
                break;
            case "":
            default:
                context.Response.Clear();
                //image/png
                context.Response.ContentType = "image/png";
                reportService = C1.Web.UI.Controls.C1Report.ReportService.C1WebReportServiceHelper.MakeHelper((string)args["documentKey"]);
                bool printTarget = false;
                if (args["printTarget"] != null)
                    printTarget = bool.Parse(args["printTarget"]);
                buffer = reportService.GetPageImage(args["documentKey"], int.Parse(args["dpi"]), int.Parse(args["zoom"]), int.Parse(args["pageIndex"]), printTarget);
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.End();
                break;
        }


        //        context.Response.Flush();
        //context.Response.Write("Hello World");
    }
    string GetDialogTemplateContent(string dialogName)
    {
        string localPath = HttpContext.Current.Server.MapPath("~/C1ReportDialogs/" + dialogName + ".htm");
        if (System.IO.File.Exists(localPath))
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(localPath))
            {
                string s = reader.ReadToEnd();
                return s;
            }
        }
        return C1ReportViewer.GetDialogTemplateContent(dialogName);
    }

	System.Collections.ArrayList ToArrayList(string s)
	{
		int k;
		s = s.Trim(new char[] { '[', ']' });
		string[] indicesStrArr = s.Split(',');
		System.Collections.ArrayList arr = new System.Collections.ArrayList();
		for (int i = 0; i < indicesStrArr.Length; i++)
		{
			if (int.TryParse(indicesStrArr[i], out k))
			{
				arr.Add(k);
			}
		}
		return arr;
	}

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    #endregion

    /*
application/json
application/x-javascript
text/javascript
text/x-javascript
text/x-json
*/
    
}



                