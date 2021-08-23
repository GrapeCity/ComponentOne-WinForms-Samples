<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="CustomNavBar3._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-SIZE: small; font-FAMILY: Verdana">
    <form id="form1" runat="server">
    <div>
        <h1>
            <span style="font-size: 14pt">Customizable Navigation Bar:</span></h1>
<p>
    <span style="font-size: 9pt">In addition to changing the navigation bar style, you can
        customize its images. There are three image collections that define the appearance
        of the buttons in their normal state, mouse over state, and disabled state. The
        image collections are exposed through properties: <strong>Images</strong>, <strong>MouseOverImages</strong>,
        and <strong>DisabledImages</strong>. </span>
</p>
        <p>
            You can also customize the content of the toltips associated with each element in
            the navigation bar. This is done using the <strong>ToolTips </strong>property.</p>
        <p>
        </p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="39px" Width="306px">
            <asp:ListItem Selected="True">Default Images</asp:ListItem>
            <asp:ListItem>Custom Images</asp:ListItem>
        </asp:RadioButtonList><asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Font-Names="Verdana" /><br />
        <br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="330px" Width="678px" 
            BorderColor="#C0C0FF" BorderStyle="Solid" BorderWidth="1px" 
            style="margin-right: 0px">
            <NavigationBar Align="Center" Style-BackColor="#E0E0E0" Style-BorderColor="#C0C0FF" Style-BorderStyle="Solid" Style-BorderWidth="1px" HasExportButton="True" HasGotoPageButton="True" Style-Font-Bold="True" Style-Font-Names="Tahoma" Style-Font-Size="10pt" Style-ForeColor="Purple" />
        </cc1:C1WebReport>
    
    </div>
    </form>
</body>
</html>
