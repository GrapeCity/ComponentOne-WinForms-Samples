<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="MultiReport._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-SIZE: xx-small; font-FAMILY: Verdana">
		<form id="Form1" method="post" runat="server">
			<p><font size="4"><strong><span style="font-size: 14pt">Multiple Reports</span></strong></font></p>
            <span style="font-size: 9pt">
				This page allows you to select any report from the NorthWind report definition 
				file to be rendered on the <strong>C1WebReport </strong>control. Keeping 
				related reports in a single file is convenient, especially when it is an 
				easy-to-manage XML file.</span><p>
                    <span style="font-size: 9pt">Select some options:</span><br/>
				&nbsp;&nbsp;&nbsp;
				<asp:CheckBoxList id="CheckBoxList1" runat="server" BorderWidth="1px" Width="520px" BackColor="MintCream" Font-Size="9pt" AutoPostBack="True" RepeatColumns="3" RepeatDirection="Horizontal" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
					<asp:ListItem Value="Paged" Selected="True">Paged</asp:ListItem>
					<asp:ListItem Value="Navigation Bar" Selected="True">Navigation Bar</asp:ListItem>
					<asp:ListItem Value="Cached" Selected="True">Cached</asp:ListItem>
					<asp:ListItem Value="Scrollable" Selected="True">Scrollable</asp:ListItem>
					<asp:ListItem Value="Drill Down" Selected="True">Drill Down</asp:ListItem>
				</asp:CheckBoxList></p>
			<p>
                <span style="font-size: 9pt">Select the report:<br/>
				&nbsp;&nbsp;&nbsp; </span>
				<asp:DropDownList id="DropDownList1" runat="server" Width="360px" BackColor="MintCream" Font-Names="Verdana" Font-Size="9pt" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br/>
				<br/>
                <span style="font-size: 9pt">&nbsp; &nbsp; </span>
				<asp:Button id="Button1" runat="server" Font-Size="9pt" BackColor="Gold" Width="160px" BorderWidth="4px" Font-Names="Verdana" Text="PDF Version" BorderStyle="Dashed" Font-Bold="True" Font-Italic="True" OnClick="Button1_Click"></asp:Button></p>
            <span style="font-size: 9pt"></span>
			<p>
                <span style="font-size: 9pt">
				Here's the report you selected:</span><br/>
				&nbsp;&nbsp;&nbsp;
				<cc1:C1WebReport id="_c1wr" runat="server" BorderWidth="1px" Width="650px" 
                Height="470px" BackColor="MintCream" Font-Size="9pt">
					<ReportSource FileName="NWindEmbedPics.xml"></ReportSource>
					<NavigationBar Style-Font-Size="Small" Style-BorderWidth="2px" Style-ForeColor="MintCream" Style-BorderColor="Black" Style-BackColor="Black" Text="Page &lt;b&gt;{0}&lt;/b&gt; of {1}" Align="Left"></NavigationBar>
				</cc1:C1WebReport></p>&nbsp;
		</form>
	</body>
</html>
