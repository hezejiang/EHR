<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.record_UserBaseInfo.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		户籍地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Hometown" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		现住址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_CurrentAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档单位（居委会或者是医院部门
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_FilingUnits" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_FilingUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		责任医生
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_ResponsibilityUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		居(村)委会
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Committee" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_FlingTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		工作单位
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_WorkingUnits" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位联系人姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_WorkingContactName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职位联系人电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_WorkingContactTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		血型 1:A型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_BloodType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		民族
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_NationID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		婚姻状态 1:未婚
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_MarriageStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		常住类型 1:户籍
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_PermanentType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		文化程度 1:文盲及半文盲
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Education" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		付费类型(可多选
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_PaymentType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		社保号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_SocialNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		医保号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_MedicalNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_FamilyCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		与户主关系 1:父亲 2:母亲
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_RelationShip" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		档案状态
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
