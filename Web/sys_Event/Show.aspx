<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.sys_Event.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		事件ID号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEventID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_U_LoginName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作时用户ID与sys_Use
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_UserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		事件发生的日期及时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_DateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用程序ID与sys_Ap
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_ApplicationID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_A_AppName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PageCode模块名称与sy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_M_Name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发生事件时模块名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_M_PageCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_From" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		日记类型,1:操作日记2:安全
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		客户端IP地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_IP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		详细描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblE_Record" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




