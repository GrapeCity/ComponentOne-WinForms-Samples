<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Tooltips._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-SIZE: small; font-FAMILY: Verdana">
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 14pt"><strong>Customizable
        Navigation Bar:</strong></span><p>
            <span style="font-size: 9pt">In addition to changing the navigation bar style, you can
                customize its images. There are three image collections that define the appearance
                of the buttons in their normal state, mouse over state, and disabled state. The
                image collections are exposed through properties: <strong>Images</strong>, <strong>MouseOverImages</strong>,
                and <strong>DisabledImages</strong>. </span>
        </p>
        <table>
            <tr>
                <td align="right" style="width: 90px">
        <asp:Label ID="lblFirst" runat="server" Text="First"></asp:Label></td>
                <td style="width: 158px">
        <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox></td>
                <td align="right" style="width: 90px">
        <asp:Label ID="Label4" runat="server" Text="Go To Page"></asp:Label></td>
                <td style="width: 158px">
        <asp:TextBox ID="txtGoto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 90px">
        <asp:Label ID="Label1" runat="server" Text="Prev"></asp:Label></td>
                <td style="width: 158px">
        <asp:TextBox ID="txtPrev" runat="server"></asp:TextBox></td>
                <td align="right" style="width: 90px">
        <asp:Label ID="Label5" runat="server" Text="Export"></asp:Label></td>
                <td style="width: 158px">
        <asp:TextBox ID="txtExport" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td align="right" style="width: 90px; height: 26px">
        <asp:Label ID="Label2" runat="server" Text="Next"></asp:Label></td>
                <td style="width: 158px; height: 26px">
        <asp:TextBox ID="txtNext" runat="server"></asp:TextBox></td>
                <td align="right" style="width: 90px; height: 26px">
                </td>
                <td style="width: 158px; height: 26px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 90px; height: 26px">
        <asp:Label ID="Label3" runat="server" Text="Last"></asp:Label></td>
                <td style="width: 158px; height: 26px">
        <asp:TextBox ID="txtLast" runat="server"></asp:TextBox></td>
                <td align="right" style="width: 90px; height: 26px">
                </td>
                <td style="width: 158px; height: 26px">
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" 
                        Font-Names="Verdana" Width="69px" /></td>
            </tr>
        </table>
        <br />
        <br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="316px" Width="673px" BorderColor="#C0C0FF" BorderStyle="Solid" BorderWidth="1px" EnableCallback="True">
            <NavigationBar Align="Center" Style-BackColor="#E0E0E0" Style-BorderColor="#C0C0FF" Style-BorderStyle="Solid" Style-BorderWidth="1px" HasExportButton="True" HasGotoPageButton="True" Style-Font-Bold="True" Style-Font-Names="Tahoma" Style-Font-Size="10pt" Style-ForeColor="Purple" />
        </cc1:C1WebReport>
    
    </div>
    </form>
</body>
</html>
