<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="CustomPaper._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
		<form id="Form1" method="post" runat="server">
			<p><font face="Verdana" size="4"><strong><span style="font-size: 14pt">C1WebReport Samples: CustomPaper</span></strong></font></p>
			<p><font face="Verdana" size="2"><span style="font-size: 9pt">This sample shows how you can render a web report 
					using a custom paper size.</span></font></p>
			<p><font face="Verdana" size="2"><span style="font-size: 9pt">This is useful because most web servers don't have (or 
					don't expose) printer drivers used by the control to get a list of available 
					paper sizes. By using a custom size, you can bypass the printer driver 
					altogether.</span></font></p>
			<p><font face="Verdana" size="2">
					<asp:Button id="Button1" runat="server" Text="Show Pdf" OnClick="Button1_Click"></asp:Button></font></p>
			<p>
				<cc1:C1WebReport id="C1WebReport1" runat="server" Width="600px" 
                Height="216px" BorderStyle="Double" Scrollable="False">
					<ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>
					<NavigationBar Visible="False"></NavigationBar>
				</cc1:C1WebReport></p>
		</form>
	</body>
</html>
