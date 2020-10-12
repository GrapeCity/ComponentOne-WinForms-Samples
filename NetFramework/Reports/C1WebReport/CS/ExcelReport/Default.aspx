<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="ExcelReport._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
	<body>
		<form id="Form1" method="post" runat="server">
			<p><font face="Tahoma" size="5"><strong>Alphabetical List of Products</strong></font></p>
            <p>
                <font face="Tahoma" size="5"><strong>
				<asp:Button id="Button1" runat="server" Width="200px" Height="32px" Text="Show Excel Version" OnClick="Button1_Click"></asp:Button></strong></font>&nbsp;</p>
			<p>
				<cc1:C1WebReport id="C1WebReport1" runat="server" Width="600px" 
                Height="280px" BorderStyle="Double">
					<ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>

<NavigationBar Style-BackColor="Control"></NavigationBar>
				</cc1:C1WebReport>
                &nbsp;</p>
            <p>
                &nbsp;</p>
			<p>
                &nbsp;</p>
			<p>
                &nbsp;&nbsp;
            </p>
		</form>
	</body>
</html>
