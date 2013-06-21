<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthEducation.Activity._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="健康教育活动管理" HeadTitleTxt="健康教育活动管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="健康教育活动" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New" ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="健康教育活动">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="活动编号" DataTextField="ActivityID" SortExpression="ActivityID" DataNavigateUrlFields="ActivityID"
                        DataNavigateUrlFormatString="InfoManager.aspx?ActivityID={0}&CMD=Edit" />
                    <asp:BoundField SortExpression="A_DateTime" HeaderText="活动日期" DataField="A_DateTime" DataFormatString="{0:yyyy/MM/dd}"/>
                    <asp:BoundField SortExpression="A_Location" HeaderText="活动地点" DataField="A_Location"/>
                    <asp:TemplateField SortExpression="A_Object" HeaderText="活动对象">
                        <ItemTemplate>
                            <%#getGroupModelById(Convert.ToInt32(Eval("A_Object"))).G_CName%>民众
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="参与人群" DataField="A_Crowd"/>
                    <asp:BoundField HeaderText="活动主题" DataField="A_Theme"/>
                </Columns>
            </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        活动日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_DateTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        活动地点</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Location" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        参与人群</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Crowd" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        活动主题</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Theme" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="查询" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
        
    </FrameWorkWebControls:TabOptionWebControls>
    <script language="javascript">


    </script>
</asp:Content>
