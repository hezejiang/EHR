<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.record_DeathRegistration.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		DeathID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeathID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		D_DateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_DateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		D_Location
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_Location" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		疾病icd10编码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_Icd10ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		死亡说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_Note" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登记人,与sys_User表的
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_UserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登记日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblD_RegDate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




