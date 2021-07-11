<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="AlternateColor._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
    <body>
        <form id="Form1" method="post" runat="server">
            <p><font face="Verdana" size="4"><strong><span style="font-size: 14pt">C1WebReport Samples: AlternateColor</span></strong></font></p>
            <p><font face="Verdana" size="2"><span style="font-size: 9pt">This sample shows how you can use the <em>PrintSection</em>
                    event to change the formatting of report sections as the report is rendered. 
                    The <em>PrintSection</em> event is also present in the 
                <strong>C1Report</strong> component that is 
                    contained in the <strong>C1WebReport</strong>
                control.</span></font></p>
            <p><font face="Verdana" size="2"><span style="font-size: 9pt">In this sample, the <em>PrintSection</em>
                event handler 
                    toggles&nbsp;a variable and changes the background color of the detail section. 
                    Here is the report:</span></font></p>
            <p>
                <cc1:C1WebReport id="C1WebReport1" runat="server" Width="849px" 
                Height="424px" BorderStyle="Double" Paged="False" Scrollable="False" 
                OnPrintSection="C1WebReport1_PrintSection">
                    <ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>
                    <NavigationBar Visible="False" Align="Left"></NavigationBar>
                </cc1:C1WebReport></p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show PDF" Width="140px" />&nbsp;
        </form>
    </body>
</html>
