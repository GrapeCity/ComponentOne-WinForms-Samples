<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="ChartReport._Default" %>
<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-size: 9pt; font-family: Verdana" dir="ltr">
		<form id="Form1" method="post" runat="server">
			<p><font size="4"><strong>Chart Report</strong></font></p>
			<p>This sample shows a report with embedded charts, gradients, and bar code fields.</p>
			<p>There is no code behind the report. The charts, gradients, and bar 
				code&nbsp;were created with the Report Designer application and saved into a 
				regular report definition file.</p>
			<p>Starting with the Q3/2004 release, C1Report supports <strong>Custom Fields</strong>. 
				Custom fields are defined in separate assemblies that are registered with the 
				Report Designer. ComponentOne provides one such assembly with two custom 
				fields: the <strong>Chart </strong>and <strong>Gradient</strong>. The source 
				code is provided, and you can use it as a reference when writing your own 
				custom fields.</p>
			<p>
				<asp:Button id="Button1" runat="server" Text="Pdf Version" OnClick="Button1_Click"></asp:Button></p>
			<p>
				<cc1:C1WebReport id="C1WebReport1" runat="server" Width="100%" Height="300px" Scrollable="False" BorderStyle="None" BackColor="Ivory">
					<ReportSource ReportName="Sales by Category" 
                        FileName="nwindchart.xml"></ReportSource>
					<NavigationBar Style-font-Size="8pt" Style-font-Names="Tahoma" Style-font-Bold="True" Style-ForeColor="White" Style-BackColor="#0000C0" Text="&amp;nbsp;&amp;nbsp;&amp;nbsp;Page {0} of {1}&amp;nbsp;&amp;nbsp;&amp;nbsp;" Align="Left"></NavigationBar>
				</cc1:C1WebReport></p>
			<p>
                &nbsp;&nbsp;&nbsp;
            </p>
		</form>
	</body>
</html>
