<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="AdHoc._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
	<body style="FONT-SIZE: xx-small; FONT-FAMILY: Verdana">
		<form id="Form1" method="post" runat="server">
			<p><font size="4"><strong><span style="font-size: 14pt">Parameterized&nbsp;Report</span></strong></font></p>
			<p>
                <span style="font-size: 8pt">This sample allows you to select parameters for the report.</span></p>
			<p>
                <span style="font-size: 8pt">The report shows NorthWind's <strong>Employee Sales by Country</strong>. As 
				honorary CEO in charge of the NorthWind Traders Corporation, you may select the 
				Sales Goal for each employee. The report will show who met the goal. (This is a 
				drill-down report, you can click the section headers to collapse the detail 
				away and see the bottom line).</span></p>
			<p>
                <span style="font-size: 8pt">
				When you find the ideal sales goal, click the 'send' button to email a copy of 
				the report (in rtf format) to Joe, the sales manager.</span></p>
			<p>
                <span style="font-size: 8pt">The most interesting part of this sample, besides being able to customize the 
				report on-the-fly, is the automatic caching provided by the C1WebReport 
				control. Each combination of parameters is automatically stored in a separate 
				slot in the cache and automatically re-utilized if the same parameters are used 
				again. The information in the cache is compressed, so the load on the server is 
				dramatically reduced.</span></p>
			<p>&nbsp;&nbsp;&nbsp;&nbsp;</p>
				<table id="Table1" style="WIDTH: 469px; HEIGHT: 60px" cellSpacing="0" 
                cellPadding="0" border="0">
					<tr>
						<td style="WIDTH: 178px; HEIGHT: 2px"><font size="1">&nbsp;&nbsp;&nbsp;<span style="font-size: 8pt"> Report for 
								Year:</span></font></TD>
						<td style="HEIGHT: 2px">
							<asp:DropDownList id="_lstYear" runat="server" Width="224px" Font-Names="Verdana" Font-Size="8pt">
								<asp:ListItem Value="All" Selected="True">All</asp:ListItem>
								<asp:ListItem Value="1994">1994</asp:ListItem>
								<asp:ListItem Value="1995">1995</asp:ListItem>
								<asp:ListItem Value="1996">1996</asp:ListItem>
							</asp:DropDownList><font size="1"></font></TD>
					</tr>
					<tr>
						<td style="WIDTH: 178px; HEIGHT: 15px"><font size="1">&nbsp;&nbsp;&nbsp;<span style="font-size: 8pt"> Sales 
								Goal:&nbsp;</span></font></TD>
						<td style="HEIGHT: 15px">
							<asp:TextBox id="_txtGoal" runat="server" Width="224px" Font-Names="Verdana" Font-Size="8pt">25000</asp:TextBox></TD>
					</tr>
				</table>
			<p>&nbsp;&nbsp;&nbsp;
				<asp:Button id="_btnRender" runat="server" Font-Names="Verdana" Text="Update Report" Font-Size="8pt" OnClick="_btnRender_Click"></asp:Button>
				<asp:Button id="_btnSend" runat="server" Font-Names="Verdana" Text="Send Report to Joe" Visible="False" Font-Size="8pt" OnClick="_btnSend_Click"></asp:Button>
				<asp:Label id="_lblErr" runat="server" Width="264px" EnableViewState="False" Font-Size="8pt"></asp:Label></p>
			<p>&nbsp;&nbsp;&nbsp;
				<asp:Button id="Button1" runat="server" Font-Size="11pt" Font-Names="Verdana" Width="160px" Text="PDF Version" BackColor="Gold" BorderWidth="4px" Font-Italic="True" Font-Bold="True" BorderStyle="Dashed" Visible="False" OnClick="Button1_Click"></asp:Button><BR>
				&nbsp;&nbsp;&nbsp;&nbsp;<br>
				<br>
				&nbsp;&nbsp;&nbsp;
				<cc1:C1WebReport id="_c1wr" runat="server" Width="95%" Height="400px" 
                BorderWidth="1px" BackColor="WhiteSmoke" Visible="False" Scrollable="False" 
                Font-Size="8pt">
					<ReportSource ReportName="Employee Sales by Country" FileName="NWindEmbedPics.xml"></ReportSource>
					<NavigationBar Style-Font-Size="X-Small" Style-ForeColor="WhiteSmoke" Style-BackColor="Black" Text="Page &lt;b&gt;{0}&lt;/b&gt; of {1}" Align="Left"></NavigationBar>
				</cc1:C1WebReport></p>
		</form>
	</body>
</html>
