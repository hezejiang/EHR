<%@ Page Title="record_FamilyBaseInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.record_FamilyBaseInfo.List" %>
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
                    BorderWidth="1px" DataKeyNames="FimaryID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="F_FimaryCode" HeaderText="家庭档案编号" SortExpression="F_FimaryCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_UserID" HeaderText="户主" SortExpression="F_UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_GroupID" HeaderText="村(居)委会ID" SortExpression="F_GroupID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_FimaryTel" HeaderText="F_FimaryTel" SortExpression="F_FimaryTel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_FimrayAddress" HeaderText="家庭地址" SortExpression="F_FimrayAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_HouseType" HeaderText="房屋类型 1:砖瓦平房" SortExpression="F_HouseType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_HouseArea" HeaderText="居住面积" SortExpression="F_HouseArea" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Ventilation" HeaderText="通风 1:好" SortExpression="F_Ventilation" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Humidity" HeaderText="湿度 1:潮湿" SortExpression="F_Humidity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Warm" HeaderText="保暖 1:好" SortExpression="F_Warm" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Lighting" HeaderText="采光 1:好" SortExpression="F_Lighting" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Sanitation" HeaderText="卫生 1:清洁" SortExpression="F_Sanitation" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Kitchen" HeaderText="厨房 1:合用" SortExpression="F_Kitchen" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Fuel" HeaderText="使用燃料 1：液化气" SortExpression="F_Fuel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_Water" HeaderText="饮水来源 1：自来水" SortExpression="F_Water" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_WasteDisposal" HeaderText="垃圾处理 1：垃圾处理" SortExpression="F_WasteDisposal" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_LivestockBar" HeaderText="禽畜栏 1：单设" SortExpression="F_LivestockBar" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_ToiletType" HeaderText="厕所类型 1：家庭卫生厕所：三格式粪池式" SortExpression="F_ToiletType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_ResponsibilityUserID" HeaderText="责任人" SortExpression="F_ResponsibilityUserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="F_FillingUserID" HeaderText="建档人" SortExpression="F_FillingUserID" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="FimaryID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="FimaryID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
