<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="PdfNewWindow._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
    <body>
        <form id="Form1" method="post" runat="server">
            <p><font face="Verdana" size="4"><strong>C1WebReport Samples: Pdf in&nbsp;a New Window</strong></font></p>
            <p><font face="Verdana" size="2">C1WebReport has a <strong>ShowPDF </strong>method that 
                    allows you to display the report as a PDF document in the browser. When you 
                    call <strong>ShowPDF</strong>, the new Pdf document replaces the current 
                    content of the page (provided you have the Adobe Acrobat Viewer properly 
                    configured).</font></p>
            <p><font face="Verdana" size="2">In some cases, it may be convenient to show the Pdf 
                    report in a new window. This sample shows an easy way to do that. The 
                    client-side button below runs the following script:</font></p>
                <pre>	window.open(window.location.href + '?pdf=true')</pre>
                <input style="WIDTH: 300px; HEIGHT: 40px" 
                onclick="window.open(window.location.href + '?pdf=true')" type="button" 
                value="Show Pdf Report (in a new window)">
            <p><font face="Verdana" size="2">The script opens a new browser window that points at 
                    the current URL (this page) and adds a 'pdf=true' parameter. This parameter is 
                    causes the Page_Load event handler&nbsp;to call the <strong>ShowPDF</strong> method, 
                    which then displays the Pdf version of the report in the new window. </font>
            </p>
            <p><font face="Verdana" size="2">Here's the HTML version of the report:</p>
            <p>
                </font></p>
            <p><font face="Verdana" size="2">
                    <cc1:C1WebReport id="C1WebReport1" runat="server" Width="896px" Height="588px" BorderStyle="Double">
                        <ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>
                    </cc1:C1WebReport>&nbsp;&nbsp;</font></p>
            <p>
                &nbsp;</p>
        </form>
    </body></html>
