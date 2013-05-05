<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.record_UserBaseInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		用户ID号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		户籍地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Hometown" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		现住址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_CurrentAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档单位（居委会或者是医院部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_FilingUnits" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_FilingUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		责任医生
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_ResponsibilityUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		居(村)委会
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Committee" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_FlingTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		工作单位
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_WorkingUnits" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位联系人姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_WorkingContactName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位联系人电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_WorkingContactTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		血型 1:A型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_BloodType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		民族
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_NationID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		婚姻状态 1:未婚
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_MarriageStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		常住类型 1:户籍
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_PermanentType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		文化程度 1:文盲及半文盲
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Education" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		付费类型(可多选
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_PaymentType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社保号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_SocialNO" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		医保号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_MedicalNO" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_FamilyCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		与户主关系 1:父亲 2:母亲
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_RelationShip" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		档案状态
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Status" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




