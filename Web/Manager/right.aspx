﻿<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="right.aspx.cs" Inherits="FrameWork.web.right"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="查看信息" HeadTitleTxt="系统信息">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="系统信息">
                <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">

                    <tr>
                        <td class="table_body">
                            系统名称</td>
                        <td class="table_none">
                            <asp:Label ID="SystemName" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="table_body">
                            框架版本</td>
                        <td class="table_none">
                            <asp:Label ID="FrameWorkVer" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="table_body">
                            官方网站</td>
                        <td class="table_none">
                            <asp:HyperLink ID="FrameWorkWeb" runat="server" Target="_blank"></asp:HyperLink></td>
                    </tr>                    
		</table>
        </FrameWorkWebControls:TabOptionItem>
        
    </FrameWorkWebControls:TabOptionWebControls>

</asp:Content>
