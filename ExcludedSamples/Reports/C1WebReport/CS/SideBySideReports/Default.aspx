<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="SideBySideReports._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span style="font-family: Tahoma;"><strong>Side-by-side reports (Ajax-enabled)<br />
            <br />
        </strong><span style="font-size: 10pt">The reports below are separate <strong>C1WebReport
        </strong>controls in a table. Each report has its <strong>ReportSource </strong>property
            set to a different report. The reports are completely independent.<br />
            <br />
            Both <strong>C1WebReport </strong>controls have their <strong>EnableCallback </strong>
            property set to "true" for smooth paging.</span></span><br />
        <br />
        <table style="width: 920px; height: 371px">
            <tr>
                <td style="width: 100px">
                    <span style="font-family: Tahoma"><strong>Categories</strong></span></td>
                <td style="width: 100px">
                    <span style="font-family: Tahoma"><strong>Products</strong></span></td>
            </tr>
            <tr>
                <td style="width: 100px; height: 440px">
                    <cc1:C1WebReport ID="C1WebReport1" runat="server" EnableCallback="True" Height="425px"
                        Width="455px">
                        <ReportSource FileName="MyTest.xml" ReportName="Categories Report" />
                        <NavigationBar Style-BackColor="Control" Text="ページ {0} / {1}">
                        </NavigationBar>
                    </cc1:C1WebReport>
                </td>
                <td style="width: 100px; height: 440px">
                    <cc1:C1WebReport ID="C1WebReport2" runat="server" EnableCallback="True" Height="425px"
                        Width="455px">
                        <ReportSource FileName="MyTest.xml" ReportName="Products Report" />
                        <NavigationBar Style-BackColor="Control" Text="ページ {0} / {1}">
                        </NavigationBar>
                    </cc1:C1WebReport>
                </td>
            </tr>
        </table>
        &nbsp;
    
    </div>
    </form>
</body>
</html>
