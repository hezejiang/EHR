<%@ Page Title="功能模块" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.sys_Module.List" %>
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
                    BorderWidth="1px" DataKeyNames="ModuleID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="M_ApplicationID" HeaderText="所属应用程序ID" SortExpression="M_ApplicationID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_ParentID" HeaderText="所属父级模块ID与Module" SortExpression="M_ParentID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_PageCode" HeaderText="模块编码Parent为0,则为" SortExpression="M_PageCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_CName" HeaderText="模块/栏目名称当ParentI" SortExpression="M_CName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_Directory" HeaderText="模块/栏目???录名" SortExpression="M_Directory" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_OrderLevel" HeaderText="当前所在排序级别支持双层99级" SortExpression="M_OrderLevel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_IsSystem" HeaderText="是否为系统模块1:是0:否如为" SortExpression="M_IsSystem" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_Close" HeaderText="是否关闭1:是0:否" SortExpression="M_Close" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_Icon" HeaderText="模块Icon" SortExpression="M_Icon" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="M_Info" HeaderText="模块说明" SortExpression="M_Info" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ModuleID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ModuleID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
