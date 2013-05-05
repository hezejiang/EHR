<%@ Page Title="系统日记表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.sys_Event.List" %>
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
                    BorderWidth="1px" DataKeyNames="EventID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="E_U_LoginName" HeaderText="用户名" SortExpression="E_U_LoginName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_UserID" HeaderText="操作时用户ID与sys_Use" SortExpression="E_UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_DateTime" HeaderText="事件发生的日期及时间" SortExpression="E_DateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_ApplicationID" HeaderText="所属应用程序ID与sys_Ap" SortExpression="E_ApplicationID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_A_AppName" HeaderText="所属应用名称" SortExpression="E_A_AppName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_M_Name" HeaderText="PageCode模块名称与sy" SortExpression="E_M_Name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_M_PageCode" HeaderText="发生事件时模块名称" SortExpression="E_M_PageCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_From" HeaderText="来源" SortExpression="E_From" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Type" HeaderText="日记类型,1:操作日记2:安全" SortExpression="E_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_IP" HeaderText="客户端IP地址" SortExpression="E_IP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="E_Record" HeaderText="详细描述" SortExpression="E_Record" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="EventID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="EventID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
