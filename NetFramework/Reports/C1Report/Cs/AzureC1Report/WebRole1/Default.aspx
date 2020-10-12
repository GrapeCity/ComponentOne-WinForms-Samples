<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebRole1._Default" %>

<%@ Register assembly="C1.Web.UI.Controls.C1Report.4" namespace="C1.Web.UI.Controls.C1Report" tagprefix="cc1" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Sample reports:
    </h2>
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','01: Alternating Background (Greenbar report)')">Greenbar report</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','02: Custom Paper Size')">Custom Paper Size</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','03: Unbound Images')">Unbound Images</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','04: Bound Images')">Bound Images</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','05: Watermark')">Watermark</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','06: CanGrow CanShrink')">CanGrow CanShrink</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','07: Force Page Breaks')">Force Page Breaks</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','08: Global Constant')">Global Constant</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','09: Dynamic Page Header')">Dynamic Page Header</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','10: Gutter')">Gutter</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','11: Charts')">Charts</a></span>&nbsp; <!-- -->
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','12: Custom Fields')">Custom Fields</a></span>&nbsp; <!-- -->
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','13: Subtotals and other Aggregates')">Subtotals and other Aggregates</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','14: Page Headers in Subreports')">Page Headers in Subreports</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','15: Retrieve Values from Subreports')">Retrieve Values from Subreports</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','16: Conditional Formatting')">Conditional Formatting</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','17: Running Sums')">Running Sums</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','18: Continued Headers')">Continued Headers</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','19: Sorting')">Sorting</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','20: Cross-tab Reports')">Cross-tab Reports</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','21: Suppress or Force Zeros')">Suppress or Force Zeros</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','22: Print Button')">Print Button</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','23: Mail Merge')">Mail Merge</a></span>&nbsp;
    <span><a href="javascript:changeReport('~/C1ReportXML/CommonTasksSQL.xml','24: Group Page Counts')">Group Page Counts</a></span>&nbsp;

    <p>

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <script language="javascript" type="text/javascript">
        function getReport() {
            return $find("<%=C1ReportViewer1.ClientID%>")
        }
        function changeReport(fileName, reportName) {
            var c1Report = getReport();
            c1Report.set_fileName(fileName);
            c1Report.set_reportName(reportName);
            c1Report.generate();
        }
    </script>
 
    <cc1:C1ReportViewer ID="C1ReportViewer1" runat="server" 
        FileName="~/C1ReportXML/CommonTasksSQL.xml" ReportName="01: Alternating Background (Greenbar report)"
      Width="822px">
    </cc1:C1ReportViewer>
<!-- FileName="~/C1ReportXML/sql_report_test.xml" ReportName="sqlexpress Employees"   -->


    </p>
    <p>
        &nbsp;</p>
</asp:Content>
