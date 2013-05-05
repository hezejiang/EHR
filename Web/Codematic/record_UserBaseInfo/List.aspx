<%@ Page Title="record_UserBaseInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.record_UserBaseInfo.List" %>
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
                    BorderWidth="1px" DataKeyNames="UserID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="U_Hometown" HeaderText="户籍地址" SortExpression="U_Hometown" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_CurrentAddress" HeaderText="现住址" SortExpression="U_CurrentAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_FilingUnits" HeaderText="建档单位（居委会或者是医院部门" SortExpression="U_FilingUnits" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_FilingUserID" HeaderText="建档人" SortExpression="U_FilingUserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_ResponsibilityUserID" HeaderText="责任医生" SortExpression="U_ResponsibilityUserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Committee" HeaderText="居(村)委会" SortExpression="U_Committee" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_FlingTime" HeaderText="建档日期" SortExpression="U_FlingTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_WorkingUnits" HeaderText="工作单位" SortExpression="U_WorkingUnits" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_WorkingContactName" HeaderText="职位联系人姓名" SortExpression="U_WorkingContactName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_WorkingContactTel" HeaderText="职位联系人电话" SortExpression="U_WorkingContactTel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_BloodType" HeaderText="血型 1:A型" SortExpression="U_BloodType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_NationID" HeaderText="民族" SortExpression="U_NationID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_MarriageStatus" HeaderText="婚姻状态 1:未婚" SortExpression="U_MarriageStatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_PermanentType" HeaderText="常住类型 1:户籍" SortExpression="U_PermanentType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Education" HeaderText="文化程度 1:文盲及半文盲" SortExpression="U_Education" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_PaymentType" HeaderText="付费类型(可多选" SortExpression="U_PaymentType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_SocialNO" HeaderText="社保号" SortExpression="U_SocialNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_MedicalNO" HeaderText="医保号" SortExpression="U_MedicalNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_FamilyCode" HeaderText="家庭编号" SortExpression="U_FamilyCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_RelationShip" HeaderText="与户主关系 1:父亲 2:母亲" SortExpression="U_RelationShip" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Status" HeaderText="档案状态" SortExpression="U_Status" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="UserID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="UserID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
