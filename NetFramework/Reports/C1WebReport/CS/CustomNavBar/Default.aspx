<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="CustomNavBar._Default" %>
<%@ Register Assembly="C1.Web.C1WebReport.2" Namespace="C1.Web.C1WebReport" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        #Button1
        {
            height: 26px;
            width: 136px;
        }
    </style>
</head>
    <body style="font-SIZE: xx-small; font-FAMILY: Verdana">
		<form id="Form1" method="post" runat="server">
			<p><font size="4"><strong><span style="font-size: 14pt">Custom Navigation Bar</span></strong></font></p>
			<p>
                <span style="font-size: 9pt">The <strong>C1WebReport </strong>control has a built-in navigation bar that you 
				can use with paged reports. Just set the <strong>NavigationBar.Visible</strong> property to 
				true, and customize its appearance with the <strong>NavigationBar.Style </strong>property.</span>
			</p>
			<p>
                <span style="font-size: 9pt">If the built-in navigation bar does not look or behave exactly the way you want 
				it to, you can make it invisible and create your own. This sample shows how.</span>
			</p>
			<p>
				&nbsp;<asp:Panel id="Panel1" runat="server" Width="80%" BorderStyle="Double" 
                Height="40px" BackColor="Khaki">
                <asp:ImageButton id="_btnFirst" runat="server" ImageAlign="Middle" ImageUrl="btn_first.png" EnableViewState="False" ToolTip="First Page" OnClick="_btnFirst_Click" Height="20px"></asp:ImageButton>
                <asp:ImageButton id="_btnPrev" runat="server" ImageAlign="Middle" ImageUrl="btn_prev.png" EnableViewState="False" ToolTip="Previous Page" OnClick="_btnPrev_Click" Height="20px"></asp:ImageButton>&nbsp; 
                <asp:Label id="_lblCurrent" runat="server" Font-Bold="True" Font-Size="9pt">This is page N of M</asp:Label>&nbsp; 
                <asp:ImageButton id="_btnNext" runat="server" ImageAlign="Middle" ImageUrl="btn_next.png" EnableViewState="False" ToolTip="Next Page" OnClick="_btnNext_Click" Height="20px"></asp:ImageButton>
                <asp:ImageButton id="_btnLast" runat="server" ImageAlign="Middle" ImageUrl="btn_last.png" EnableViewState="False" ToolTip="Last Page" OnClick="_btnLast_Click" Height="20px"></asp:ImageButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:ImageButton id="_btnJump" runat="server" ImageAlign="Middle" ImageUrl="btn_goto.png" EnableViewState="False" ToolTip="Jump to page" OnClick="_btnJump_Click" Height="20px"></asp:ImageButton>
                <asp:TextBox id="_txtPage" runat="server" Height="15px" Columns="8" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp; &nbsp; &nbsp;&nbsp;<asp:DropDownList ID="_cbxFormats" runat="server">
                        <asp:ListItem>HTML</asp:ListItem>
                        <asp:ListItem>PDF</asp:ListItem>
                        <asp:ListItem>RTF</asp:ListItem>
                        <asp:ListItem>XLS</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="_btnExport" runat="server" OnClick="_btnExport_Click" Text="Export" />&nbsp;<input 
                    id="Button1" onclick="jscript:window.print()" type="button" 
                    value="Print this page" />
                <br />
                    <br />
                    <br />
                    <br />
                    &nbsp; &nbsp;
                    <br /></asp:Panel><br />


				<cc1:C1WebReport id="_c1wr" runat="server" Width="80%" Height="302px" 
                BorderWidth="1px" Scrollable="False" Font-Size="9pt" 
                OnCurrentPageChanged="_c1wr_CurrentPageChanged" >
					<ReportSource ReportName="Casual Products Report" FileName="NWindEmbedPics.xml"></ReportSource>
                    <NavigationBar Align="Left" Visible="False" Style-BackColor="Control" />
				</cc1:C1WebReport></p>
		</form>
	    </body>
</html>
