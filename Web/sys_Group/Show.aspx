<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.sys_Group.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		分类ID号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分类中文说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_CName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上级分类ID0:为最高级
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_ParentID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		显示顺序
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_ShowOrder" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前分类所在层数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_Level" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当???分类子分类数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_ChildCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否删除1:是0:否
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_Delete" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		行政代码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblG_Code" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




