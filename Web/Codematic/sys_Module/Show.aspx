<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.sys_Module.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		功能模块ID号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModuleID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用程序ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_ApplicationID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属父级模块ID与Module
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_ParentID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块编码Parent为0,则为
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_PageCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块/栏目名称当ParentI
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_CName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块/栏目???录名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_Directory" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前所在排序级别支持双层99级
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_OrderLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否为系统模块1:是0:否如为
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_IsSystem" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否关闭1:是0:否
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_Close" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块Icon
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_Icon" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblM_Info" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




