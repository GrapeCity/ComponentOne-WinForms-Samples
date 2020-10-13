<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Links._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-family:Verdana;font-size:small">
    <form id="form1" runat="server">
    <div style="height: 645px">
        <strong><span style="font-size: 14pt">
        C1WebReport: Linked reports<br />
        </span></strong>
        <br />
        This report shows product categories. The fields in the first column have their
        <strong>LinkTarget </strong>property set so that when they are clicked, a second window appears showing
        a report with the products in that category.<br />
        <br />
        The value of the <strong>LinkTarget </strong>property is this:<br />
        <br />
        <span style="font-family: Courier New"><strong>"javascript:window.open('Products.aspx?categoryID="
            &amp; CategoryID &amp; "')"<br />
        </strong></span>
        <br />
        This opens a new browser window and directs it to the <strong>Products.aspx </strong>
        page, passing the <strong>CategoryID</strong> of the item that was clicked as a
        parameter. The products page uses that parameter to filter the data and report only
        products in the selected category.<br />
        <br />
        <br />
        <cc1:C1WebReport ID="C1WebReport1" runat="server" Height="423px" Width="582px" Paged="False" Scrollable="False">
            <ReportSource FileName="Links.xml"
                ReportName="Categories" />
            <NavigationBar Style-BackColor="Control">
            </NavigationBar>
        </cc1:C1WebReport>
    
    </div>
    </form>
</body>
</html>
