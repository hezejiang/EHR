<%@ Register TagPrefix="uc1" TagName="CopyRight" Src="../../Controls/copyright.ascx" %>
<%@ Page language="c#" Codebehind="treelist.aspx.cs" AutoEventWireup="True" Inherits="Maticsoft.Web.SysManage.treelist" %>
<%@ Register TagPrefix="uc1" TagName="CheckRight" Src="../../Controls/CheckRight.ascx" %>
<%@ Register TagPrefix="cc1" Namespace="LtpPageControl" Assembly="LtpPageControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>treelist</title>
		
		
		
		
		<LINK href="../../style.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<cc1:page01 id="Page011" runat="server" Page_Index="treelist.aspx" Page_Add="add.aspx" Page_Makesql="makesql.aspx"></cc1:page01>
			<table cellSpacing="0" cellPadding="5" width="700" align="center" border="0">
				<tr>
					<td bgColor='<%=Application[Session["Style"].ToString()+"xtable_bgcolor"]%>'><asp:datagrid id="grid" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="100%"
							DataKeyField="NodeID">
							<Columns>
								<asp:BoundColumn DataField="NodeID" ReadOnly="True" HeaderText="编号">
									<HeaderStyle Width="30px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="OrderID" HeaderText="同类排序">
									<HeaderStyle Width="55px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Text" ReadOnly="True" HeaderText="名称">
									<HeaderStyle Width="120px"></HeaderStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="comment" ReadOnly="True" HeaderText="描述"></asp:BoundColumn>
								<asp:BoundColumn DataField="Url" ReadOnly="True" HeaderText="链接"></asp:BoundColumn>
								<asp:HyperLinkColumn Text="详细" DataNavigateUrlField="NodeID" DataNavigateUrlFormatString="show.aspx?id={0}"
									HeaderText="详细">
									<HeaderStyle Width="30px"></HeaderStyle>
								</asp:HyperLinkColumn>
								<asp:HyperLinkColumn Text="修改" DataNavigateUrlField="NodeID" DataNavigateUrlFormatString="modify.aspx?id={0}"
									HeaderText="修改">
									<HeaderStyle Width="30px"></HeaderStyle>
								</asp:HyperLinkColumn>
								<asp:HyperLinkColumn Text="删除" DataNavigateUrlField="NodeID" DataNavigateUrlFormatString="delete.aspx?id={0}"
									HeaderText="删除">
									<HeaderStyle Width="30px"></HeaderStyle>
								</asp:HyperLinkColumn>
							</Columns>
							<PagerStyle Visible="False"></PagerStyle>
						</asp:datagrid></td>
				</tr>
			</table>
			<cc1:page02 id="Page021" runat="server" Page_Index="treelist.aspx"></cc1:page02>
			<uc1:CopyRight id="CopyRight1" runat="server"></uc1:CopyRight>
			<uc1:CheckRight id="CheckRight1" runat="server" PermissionID=2></uc1:CheckRight>
		</form>
	</body>
</HTML>
