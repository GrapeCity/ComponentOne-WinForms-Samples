<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="WebReportCallbacks._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-SIZE: small; font-FAMILY: Verdana">
    <form id="form1" runat="server">
    <div>
        <strong><span style="font-size: 14pt"></span></strong><p>
            <span style="font-size: 9pt"><strong><span style="font-size: 14pt">C1WebReport supports
                AJAX</span></strong></span></p>
        <p>
            <span style="font-size: 9pt"><strong><span style="font-size: 14pt"></span></strong>The .NET 2.0 version of <strong>C1WebReport </strong>control has a new property called
                <strong>EnableCallback</strong>. If you set this
                property to true, and page through
                the report, <strong>C1WebReport</strong> will use callbacks to refresh only the
                portion of the page that contains the control (as opposed to postbacks, which refresh
                the entire page).</span></p>
        <p>
            Two additional properties, <strong>CallbackWaitControlID </strong>and <strong>CallbackWaitImageUrl</strong>,
            allow you to customize the feedback shown to the user while the control refreshes
            its contents.</p>
        <p>
            <span style="font-size: 9pt">Check out the difference by looking at this text and the
                controls above the report while you preview different pages. You should see much
                smoother page transitions when <strong>EnableCallback</strong> is set to true.</span></p>
        <p>
            <span style="font-size: 9pt">
                <table style="width: 410px">
                    <tr>
                        <td>
        <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Text="EnableCallback" /></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            CallbackWaitControlID</td>
                        <td>
        <asp:DropDownList ID="DropDownList1" runat="server" Font-Names="Verdana">
            <asp:ListItem Selected="True" Value="Empty"></asp:ListItem>
            <asp:ListItem>LabelWait</asp:ListItem>
        </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td>
                            CallbackWaitImageUrl</td>
                        <td>
        <asp:DropDownList ID="DropDownList2" runat="server" Font-Names="Verdana">
            <asp:ListItem Selected="True" Value="DefaultSpinner">DefaultSpinner</asp:ListItem>
            <asp:ListItem>~/images/rotating_hourglass.gif</asp:ListItem>
        </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td>
        <asp:CheckBox ID="CheckBox2" runat="server" Checked="True" Text="Paged" /></td>
                        <td>
        <asp:Button ID="Button2" runat="server" Text="Apply" OnClick="Button2_Click" Font-Names="Verdana" /></td>
                    </tr>
                </table>
            </span>
        </p>
        <p>
        <asp:Label ID="LabelWait" runat="server" Text="Loading..." style="display: none" Font-Names="Tahoma" Font-Size="12pt" ForeColor="Blue"></asp:Label><br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" EnableCallback="True" 
            Height="342px" Width="700px">
            <NavigationBar Style-BackColor="Control" Align="Left" HasExportButton="True" HasGotoPageButton="True" />
        </cc1:C1WebReport>
            &nbsp;&nbsp;<br />
        <br />
        &nbsp;
        </p>
    </div>
    </form>
</body>
</html>
