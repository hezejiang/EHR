﻿<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.GroupManager.New"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadTitleTxt="部门资料管理" HeadOPTxt="新增部门">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="新增部门">
        <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
            <tr runat="server">
                <td class="table_title" colspan="2">
                    <asp:Label ID="CatListTitle" runat="server"></asp:Label></td>
            </tr>
		    <tr id="TopTr" runat="server">
			    <td class="table_body">
                    上级部门</td>
			    <td class="table_none">
                    <asp:Label ID="G_ParentID_Txt" runat="server"></asp:Label></td>
		    </tr>
            <tr runat="server">
                <td class="table_body" style="height: 25px">
                    部门名称</td>
                <td class="table_none" style="height: 25px">
                    <asp:TextBox ID="G_CName" title="请输入部门名称~50:!" runat="server" CssClass="text_input"></asp:TextBox></td>
            </tr>
            <tr id="Tr3" runat="server">
                <td class="table_body" style="height: 25px">
                    是否医院</td>
                <td class="table_none" style="height: 25px">
                    <input type="checkbox"  ID="G_Type" title="如果是医院部门，请打钩!" runat="server" class="G_Type" />是
                </td>
            </tr>
            <tr id="Tr1" class="G_Code_tr" runat="server">
                <td class="table_body" style="height: 25px">
                    行政代码</td>
                <td class="table_none" style="height: 25px">
                    <asp:TextBox ID="G_Code" title="请输入行政代码!" runat="server" CssClass="text_input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
            </tr>
		    <tr id="SubmitTr" runat="server"><td colspan="2" align="right">
                <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
                <input id="Reset1" class="button_bak" type="reset" value="重填" />&nbsp;
		        </td>
            </tr>
		</table>
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>
        <script type="text/javascript">
            function type() {
                var isCheck = $(".G_Type").attr("checked");
                if (isCheck) {
                    $(".G_Code_tr").hide();
                } else {
                    $(".G_Code_tr").show();
                }
            }
            type();

            $(".G_Type").click(function () {
                type();
            });
    </script>
</asp:Content>
