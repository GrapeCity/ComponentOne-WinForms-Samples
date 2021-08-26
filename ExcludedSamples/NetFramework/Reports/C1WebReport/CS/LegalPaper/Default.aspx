<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="LegalPaper._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
	<body dir="ltr">
		<form id="Form1" method="post" runat="server">
			<p><font face="Verdana"><strong>C1WebReport Sample: Legal Paper Size</strong></font></p>
			<p><font face="Verdana" size="2">Here's a report rendered on Legal paper. To do this, 
					the code sets the following properties on the report control:</font></p>
			<p><font face="Courier New" size="2"><strong>// force paper size to Legal:<br>
					</strong>_c1wr.Report.Layout.PaperSize = PaperKind.Legal;<br>
					_c1wr.Report.Layout.CustomWidth = 612 * 20;<br>
					_c1wr.Report.Layout.CustomHeight = 1008 * 20; </font>
			</p>
			<p><font face="Courier New" size="2">
					<asp:Button id="Button1" runat="server" Text="Show Pdf" OnClick="Button1_Click"></asp:Button></font></p>
			
			<p>
				<cc1:C1WebReport id="_c1wr" runat="server" Width="640px" Height="457px" 
                BorderStyle="Double">
					<ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>
                    <NavigationBar Align="Left" />
				</cc1:C1WebReport></p>
		</form>
	</body>
</html>
