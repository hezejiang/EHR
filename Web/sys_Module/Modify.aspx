<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.sys_Module.Modify" Title="修改页" %>
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
		<asp:label id="lblModuleID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属应用程序ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblM_ApplicationID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属父级模块ID与Module
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_ParentID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块编码Parent为0,则为
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblM_PageCode" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块/栏目名称当ParentI
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_CName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块/栏目???录名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_Directory" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前所在排序级别支持双层99级
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_OrderLevel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否为系统模块1:是0:否如为
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_IsSystem" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否关闭1:是0:否
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_Close" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块Icon
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_Icon" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtM_Info" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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

