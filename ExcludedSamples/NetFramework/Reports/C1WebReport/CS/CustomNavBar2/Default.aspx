<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="CustomNavBar2._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-SIZE: small; font-FAMILY: Verdana">
    <form id="form1" runat="server">
    <div>
        <span style="font-size: 9pt"><strong><span style="font-size: 14pt">Custom Navigation
            Bar<br />
        </span></strong>
            <br />
            The <strong>C1WebReport </strong>control has a built-in navigation bar that you
            can use with paged reports. Just set the <strong>NavigationBar.Visible</strong>
            property to true, and customize its appearance with the <strong>NavigationBar.Style
            </strong>property.</span><p>
            </p>
        <p>
            <span style="font-size: 9pt">If the built-in navigation bar does not look or behave
                exactly the way you want it to, you can make it invisible and create your own. This
                sample creates a navigation bar inside a table cell.</span></p>
        <p>
            <span style="font-size: 9pt">Custom navigation bars can also use callbacks to take advantage
                of Ajax. To do this, the page adds an <strong>onclick</strong> attribute to each
                button containing a javascript call that causes the callback.</span></p>
        <p>
            <span style="font-size: 9pt"></span>
        <asp:CheckBox ID="cbxUseCallback" runat="server" AutoPostBack="True" Text="Use Callbacks" />&nbsp;</p>
        <p>
            <br />
        <strong><span style="font-family: Tahoma"> </span></strong>
        <table border="0" cellpadding="0" cellspacing="0" 
                style="width: 717px; height: 425px">
            <tr>
                <td bgcolor="#cccccc" style="width: 74px; height: 178px" align="center" valign="top">
                    <strong><span style="font-family: Tahoma">Page </span></strong>
        <asp:Label ID="lblPage" runat="server" Text="Label"></asp:Label><strong><span style="font-family: Tahoma"><br />
            of </span></strong>
        <asp:Label ID="lblCount" runat="server" Text="Label"></asp:Label>
                    <hr />
                    <asp:Button ID="btnFirst" runat="server" Text="First Page" Font-Names="Verdana" Width="120px" /><br />
                    <asp:Button ID="btnPrev" runat="server" Text="Previous Page" Font-Names="Verdana" Width="120px" /><br />
                    <hr />
                    <asp:TextBox ID="txtGoTo" runat="server" Width="46px" onkeypress="if ((event.which && event.which == 13) || (event.keyCode && event.keyCode == 13)) { document.getElementById('btnGoTo').click(); return false;}"></asp:TextBox><br />
                    <asp:Button ID="btnGoTo" runat="server" Text="Go" Font-Names="Verdana" Width="47px" />
                    <hr />
                    <asp:Button ID="btnNext" runat="server" Text="Next Page" Font-Names="Verdana" Width="120px" /><br />
                    <asp:Button ID="btnLast" runat="server" Text="Last Page" Font-Names="Verdana" Width="120px" />
                    <hr />
                    <asp:DropDownList ID="cbxFormats" runat="server">
                        <asp:ListItem Selected="True" Value="html">HTML</asp:ListItem>
                        <asp:ListItem Value="pdf">PDF</asp:ListItem>
                        <asp:ListItem Value="rtf">RTF</asp:ListItem>
                        <asp:ListItem Value="xls">XLS</asp:ListItem>
                    </asp:DropDownList><br />
                    <asp:Button ID="btnExport" runat="server" Text="Export" Width="73px" /></td>
                <td style="width: 100px; height: 178px" valign="top">
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="379px"
            Width="569px" Scrollable="False" ExportUri="Export" ExportDir="Export/" ExportFolder="Export" OnCurrentPageChanged="C1WebReport1_CurrentPageChanged" BorderColor="#C0C0FF" BorderStyle="Solid" BorderWidth="1px">
            <NavigationBar Align="Right" HasGotoPageButton="True" HasExportButton="True" Style-BackColor="#E0E0E0" Style-BorderColor="Silver" Style-BorderStyle="Solid" Style-BorderWidth="1px" Style-Font-Names="Tahoma" Style-Font-Size="14pt" Visible="False" />
            <Cache Enabled="False" />
        </cc1:C1WebReport>
                </td>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;
        </p>
    </div>
    </form>
</body>
</html>
