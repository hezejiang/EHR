<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthEducation.Document._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="健康知识文档管理" HeadTitleTxt="健康知识文档管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="健康知识文档" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New" ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="知识文档">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="文档编号" DataTextField="DocumentID" SortExpression="DocumentID" DataNavigateUrlFields="DocumentID"
                        DataNavigateUrlFormatString="InfoManager.aspx?DocumentID={0}&CMD=Edit" />
                    <asp:BoundField SortExpression="D_Name" HeaderText="文档名称" DataField="D_Name"/>
                    <asp:TemplateField SortExpression="D_UserID" HeaderText="上传者">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("D_UserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="D_DateTime" HeaderText="上传日期" DataField="D_DateTime" DataFormatString="{0:yyyy-MM-dd}"/>
                    <asp:TemplateField HeaderText="下载">
                        <ItemTemplate>
                            <a href='<%=Page.ResolveUrl("~/") %>Manager/Public/Document/<%# Eval("D_Url") %>' title="单击右键——另存为">点击下载</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        文档名称</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_Name" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        上传日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_DateTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
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

