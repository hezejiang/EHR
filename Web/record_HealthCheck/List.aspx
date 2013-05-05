<%@ Page Title="record_HealthCheck" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.record_HealthCheck.List" %>
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
                    BorderWidth="1px" DataKeyNames="HealthID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="H_BodyTemperature" HeaderText="体温" SortExpression="H_BodyTemperature" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_PulseRate" HeaderText="脉率（次/min）" SortExpression="H_PulseRate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_RespiratoryRate" HeaderText="呼吸频率（次/min）" SortExpression="H_RespiratoryRate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_LeftDiastolic" HeaderText="左侧舒张压(mmHg)" SortExpression="H_LeftDiastolic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_LeftSystolic" HeaderText="左侧收缩压(mmHg)" SortExpression="H_LeftSystolic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_RightDiastolic" HeaderText="右侧舒张压(mmHg)" SortExpression="H_RightDiastolic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_RightSystolic" HeaderText="右侧收缩压(mmHg)" SortExpression="H_RightSystolic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_Height" HeaderText="身高（cm）" SortExpression="H_Height" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_Weight" HeaderText="体重（kg）" SortExpression="H_Weight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_Result" HeaderText="体检结果" SortExpression="H_Result" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_Suggestion" HeaderText="体检建议" SortExpression="H_Suggestion" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_CheckTime" HeaderText="体检时间" SortExpression="H_CheckTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_MedicalInstitutions" HeaderText="体检机构" SortExpression="H_MedicalInstitutions" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="H_CheckUserID" HeaderText="体检医生" SortExpression="H_CheckUserID" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="HealthID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="HealthID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
