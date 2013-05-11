﻿<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.GroupManager.Edit"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="修改部门资料" HeadTitleTxt="部门资料管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="修改部门资料">
        <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
            <tr id="Tr1" runat="server">
                <td class="table_title" colspan="2">
                    <asp:Label ID="CatListTitle" runat="server"></asp:Label></td>
            </tr>
		<tr id="TopTr" runat="server">
			<td class="table_body">
                上级部门</td>
			<td class="table_none">
                <asp:Label ID="G_ParentID_Txt" runat="server"></asp:Label></td>
		</tr>
            <tr id="Tr2" runat="server">
                <td class="table_body" style="height: 25px">
                    部门名称</td>
                <td class="table_none" style="height: 25px">
                    <asp:TextBox ID="G_CName" title="请输入部门名称~50:!" runat="server" CssClass="text_input"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
            </tr>
            <tr id="Tr3" runat="server">
                <td class="table_body" style="height: 25px">
                    是否医院</td>
                <td class="table_none" style="height: 25px">
                    <asp:CheckBox ID="G_Type" title="如果是医院部门，请打钩!" Text="是" runat="server" CssClass="text_input"></asp:CheckBox>
                </td>
            </tr>
            <tr id="Tr4" runat="server">
                <td class="table_body" style="height: 25px">
                    行政代码</td>
                <td class="table_none" style="height: 25px">
                    <asp:TextBox ID="G_Code" title="请输入行政代码!" runat="server" CssClass="text_input"></asp:TextBox>
                </td>
            </tr>
		<tr id="SubmitTr" runat="server"><td colspan="2" align="right">
            <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
            <input id="Reset1" class="button_bak" type="reset" value="重填" />&nbsp;
		
		</td></tr>
		</table>        
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>
</asp:Content>
