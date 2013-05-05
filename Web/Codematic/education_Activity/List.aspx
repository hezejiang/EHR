<%@ Page Title="education_Activity" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.education_Activity.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="ActivityID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="A_DateTime" HeaderText="活动时间" SortExpression="A_DateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Location" HeaderText="活动地点" SortExpression="A_Location" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Form" HeaderText="活动形式" SortExpression="A_Form" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Object" HeaderText="居委会ID" SortExpression="A_Object" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Crowd" HeaderText="参与人群" SortExpression="A_Crowd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Duration" HeaderText="持续时间（min）" SortExpression="A_Duration" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Organizers" HeaderText="主办单位" SortExpression="A_Organizers" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Partners" HeaderText="合作伙伴" SortExpression="A_Partners" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Missionary" HeaderText="宣教人" SortExpression="A_Missionary" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Number" HeaderText="参与人数" SortExpression="A_Number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="A_Theme" HeaderText="活动主题" SortExpression="A_Theme" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ActivityID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ActivityID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
