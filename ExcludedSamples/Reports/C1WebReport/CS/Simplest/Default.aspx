<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Simplest._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-FAMILY: Verdana">
		<form id="Form1" method="post" runat="server">
			<p><strong><font size="4"><span style="font-size: 14pt">Simplest Report</span></font></strong></p>
			<p>
                <span style="font-size: 9pt">This is the simplest application for the <strong>C1WebReport</strong>
                    control. There's no code 
				behind the form except for the one-line event handlers attached to the&nbsp;PDF 
				buttons. The report definitions and all formatting are set at design time.</span></p>
			<p>
                <span style="font-size: 9pt">Here's our <em>Alphabetical List of Products</em> report. This is a paged report 
				with a visible navigation bar. (This is the built-in navigation bar. If you 
				don't like its appearance, you can customize it using the <strong>Text </strong>
				and <strong>Style </strong>properties, or just build your own -- it's easy.)</span></p>
			<p>
                <span style="font-size: 9pt">By default, the <strong>C1WebReport</strong> control caches rendered reports for 30 minutes (or 
				until there are changes to the report definition file on the server). Because 
				of this, you will notice that the updates are quick as you page through the 
				report.</span></p>
			<p>&nbsp;&nbsp;&nbsp;
				<asp:Button id="Button2" runat="server" BackColor="Gold" BorderWidth="4px" BorderStyle="Dashed" Width="160px" Font-Italic="True" Font-Bold="True" Text="PDF Version" Font-Names="Verdana" Font-Size="9pt"></asp:Button></p>
			<p>
				&nbsp;&nbsp;&nbsp;
				<cc1:C1WebReport id="_c1wrSales" runat="server" BackColor="Beige" BorderWidth="1px" BorderStyle="Solid" Height="372px" Width="72%" DrillDown="False" Font-Size="9pt" Scrollable="False">
					<ReportSource ReportName="Alphabetical List of Products" FileName="NWindEmbedPics.xml"></ReportSource>
					<NavigationBar Style-ForeColor="Beige" Style-BackColor="Black" Text="Page &lt;b&gt;{0}&lt;/b&gt; of {1}" Align="Left"></NavigationBar>
				</cc1:C1WebReport></p>
			<p>
                <span style="font-size: 9pt">Here's our <em>Sales by Quarter </em>report. This is a single-page report that 
				doesn't need a navigation bar.</span></p>
			<p>&nbsp;&nbsp;&nbsp;
				<asp:Button id="Button1" runat="server" BackColor="Gold" BorderWidth="4px" BorderStyle="Dashed" Width="160px" Font-Italic="True" Font-Bold="True" Text="PDF Version" Font-Names="Verdana" Font-Size="9pt"></asp:Button></p>
			<p>&nbsp;&nbsp;&nbsp;
				<cc1:C1WebReport id="_c1wrProducts" runat="server" Width="598px" Height="322px" BorderStyle="Solid" BorderWidth="1px" BackColor="Beige" Paged="False" Scrollable="False" Font-Size="9pt">
					<ReportSource ReportName="Summary of Sales by Quarter" FileName="NWindEmbedPics.xml"></ReportSource>
					<NavigationBar Style-Font-Size="XX-Small" Style-ForeColor="Beige" Style-BackColor="Black" Align="Left"></NavigationBar>
				</cc1:C1WebReport></p>
            <p>
                <span style="font-size: 9pt">This is the end of the page.</span></p>
			<p>
                &nbsp;&nbsp;</p>
		</form>
	</body>
</html>
