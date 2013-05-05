<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.sys_User.Modify" Title="修改页" %>
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
		<asp:label id="lblUserID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登陆名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_LoginName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		密码md5加密字符
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Password" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中文姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_CName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		英文名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_EName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		部门ID号与sys_Group表中GroupID关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_GroupID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电子邮件
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Email" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户类型0:超级用户1:普通用
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前状态0:正常 1:禁止登陆
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户序列号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Licence" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		锁定机器硬件地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Mac" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Remark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身份证号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_IDCard" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别1:男0:女
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Sex" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出生日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_BirthDay" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		手机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_MobileNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		员工编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_UserNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		到职日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_WorkStartDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		离职日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_WorkEndDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		公司邮件地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_CompanyMail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		职称与应用字段关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Title" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分机号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_Extension" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家中电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_HomeTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户照片网址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_PhotoUrl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_DateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后访问IP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_LastIP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后访问时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtU_LastDateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		扩展字段
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_ExtendField" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		登入类型(为空系统认证,其它值
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_LoginType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		医院部门ID号与sys_Group表中GroupID关联
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtU_HospitalGroupID" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

