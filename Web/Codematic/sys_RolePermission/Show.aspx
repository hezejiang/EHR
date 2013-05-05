<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.sys_RolePermission.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		角色应用权限自动ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPermissionID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		角色ID与sys_Roles表
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblP_RoleID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		角色所属应用ID与sys_Ap
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblP_ApplicationID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		角色应用中页面权限代码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblP_PageCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		权限值
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblP_Value" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




