<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.education_Activity.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		健康教育活动ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActivityID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		活动时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_DateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		活动地点
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Location" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		活动形式
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Form" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		居委会ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Object" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		参与人群
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Crowd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		持续时间（min）
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Duration" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		主办单位
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Organizers" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		合作伙伴
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Partners" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		宣教人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Missionary" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		参与人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		活动主题
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblA_Theme" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




