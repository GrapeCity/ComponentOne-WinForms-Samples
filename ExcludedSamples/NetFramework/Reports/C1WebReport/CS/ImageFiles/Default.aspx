<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="ImageFiles._Default" %>

<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
	<body>
		<form id="Form1" method="post" runat="server">&nbsp;
            <cc1:C1WebReport id=C1WebReport1 
            style="Z-INDEX: 101; LEFT: 7px; POSITION: absolute; TOP: 9px; height: 601px;" 
            runat="server" Width="90%" Height="800px" BorderStyle="Double">
                <NavigationBar Align="Left"/>
            </cc1:C1WebReport>
		</form>
    </body>
</html>
