﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.sys_Event.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		用户名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_U_LoginName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作时用户ID与sys_Use
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_UserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		事件发生的日期及时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtE_DateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用程序ID与sys_Ap
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_ApplicationID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_A_AppName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PageCode模块名称与sy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_M_Name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发生事件时模块名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_M_PageCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		来源
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_From" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		日记类型,1:操作日记2:安全
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_Type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		客户端IP地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_IP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		详细描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtE_Record" runat="server" Width="200px"></asp:TextBox>
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
