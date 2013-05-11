<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthSupervision.Info._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="信息登记列表" HeadTitleTxt="信息登记列表管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="信息" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New"
            ButtonUrlType="Href" ButtonVisible="True" />
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="信息" ButtonPopedom="Edit" ButtonUrl="Orderby.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
</asp:Content>

