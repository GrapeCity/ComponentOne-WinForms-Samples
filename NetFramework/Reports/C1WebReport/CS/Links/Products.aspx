<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Links.Products" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-family:Verdana;font-size:small">
    <form id="form1" runat="server">
    <div>
        Here are the products in the category you selected:<br />
        <br />
        <cc1:c1webreport id="C1WebReport1" runat="server" backcolor="Linen" height="446px"
            width="564px" Paged="False" Scrollable="False">
<ReportSource ReportName="Products" FileName="Links.xml"></ReportSource>

<NavigationBar Style-BackColor="Control"></NavigationBar>
</cc1:c1webreport>
    
    </div>
    </form>
</body>
</html>
