<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.sys_User.Show" Title="显示页" %>
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
		登陆名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_LoginName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码md5加密字符
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Password" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中文姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_CName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		英文名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_EName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门ID号与sys_Group表中GroupID关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_GroupID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电子邮件
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Email" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户类型0:超级用户1:普通用
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前状态0:正常 1:禁止登陆
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Status" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户序列号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Licence" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		锁定机器硬件地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Mac" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Remark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身份证号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_IDCard" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别1:男0:女
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Sex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出生日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_BirthDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_MobileNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		员工编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_UserNO" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		到职日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_WorkStartDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		离职日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_WorkEndDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		公司邮件地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_CompanyMail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职称与应用字段关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Title" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_Extension" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家中电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_HomeTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户照片网址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_PhotoUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_DateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后访问IP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_LastIP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后访问时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_LastDateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		扩展字段
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_ExtendField" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登入类型(为空系统认证,其它值
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_LoginType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		医院部门ID号与sys_Group表中GroupID关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblU_HospitalGroupID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




