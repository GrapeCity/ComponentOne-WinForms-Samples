<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="GoToExport._Default" %>

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
            <span style="font-size: 14pt">Easy Export</span></h1>
        <p>The .NET 2.0 version of <strong>C1WebReport
        </strong>has an <strong>Export </strong>method that allows you to provide users with
            <strong>Pdf</strong>, <strong>Rtf</strong>, <strong>Xls</strong>, and <strong>Html</strong>
            versions of your report.</p>
            <p>The export functionality is exposed in the navigation bar. Set the <strong>HasExportButton
            </strong>property to true to enable this feature, and use the <strong>ExportFormats
            </strong>property to define which export formats you want to make available.</p>
        <p>
            You can also call the <strong>Export </strong>method directly from your code, and
            the user will receive the reports in the format you selected right in their browser.
            You can deploy reports using temporary files or the built-in http handler, depending
            on the setting of the <strong>ExportRenderMethod </strong>property.</p>
        <p>
            <table style="width: 708px" >
                <tr>
                    <td style="width: 275px">
            <asp:CheckBox ID="cbxUseCallback" runat="server" AutoPostBack="True" Text="EnableCallback" /></td>
                    <td style="width: 249px">
        <asp:CheckBox ID="cbxGoToPageButton" runat="server" Checked="True" Text="NavigationBar.HasGotoPageButton" /></td>
                </tr>
                <tr>
                    <td style="width: 275px">
        <asp:CheckBox ID="cbxFill" runat="server" Checked="True" Text="Fill Report" /></td>
                    <td style="width: 249px">
        <asp:CheckBox ID="cbxExportButton" runat="server" Checked="True" Text="NavigationBar.HasExportButton" /></td>
                </tr>
                <tr>
                    <td style="width: 275px">
                        Export
        Formats:<br />
        <asp:CheckBox ID="cbxPDF" runat="server" Checked="True" Text="PDF" />
        <asp:CheckBox ID="cbxHTML" runat="server" Checked="True" Text="HTML" />
        <asp:CheckBox ID="cbxXLS" runat="server" Checked="True" Text="XLS" />
        <asp:CheckBox ID="cbxRTF" runat="server" Checked="True" Text="RTF" />
                    </td>
                    <td style="width: 249px">
        ExportRenderMethod:
        <asp:DropDownList ID="drpExportMethod" runat="server">
            <asp:ListItem>File</asp:ListItem>
            <asp:ListItem>HttpHandler</asp:ListItem>
        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td style="width: 275px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Apply" Font-Names="Verdana" /></td>
                    <td style="width: 249px">
                    </td>
                </tr>
            </table>
        </p>
        <p>
        </p>
        <p>
            <span style="font-size: 9pt"></span>
        </p>
        <p>
            <span style="font-size: 9pt"></span>
        </p>
        <p>
            &nbsp;&nbsp;<br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="230px"
            Width="714px" Scrollable="False" ExportUri="Export" ExportDir="Export/" BorderColor="#C0C0FF" BorderStyle="Solid" BorderWidth="1px">
            <NavigationBar Align="Center" HasGotoPageButton="True" HasExportButton="True" Style-BackColor="#E0E0E0" Style-BorderColor="Silver" Style-BorderStyle="Solid" Style-BorderWidth="1px" Style-Font-Names="Tahoma" Style-Font-Size="10pt" />
            <Cache Enabled="False" />
        </cc1:C1WebReport>
        &nbsp;&nbsp;
        </p>
    </div>
    </form>
</body>
</html>
