<%@ Page Title="用户表" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.sys_User.List" %>
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
                            
		<asp:BoundField DataField="U_LoginName" HeaderText="登陆名" SortExpression="U_LoginName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Password" HeaderText="密码md5加密字符" SortExpression="U_Password" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_CName" HeaderText="中文姓名" SortExpression="U_CName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_EName" HeaderText="英文名" SortExpression="U_EName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_GroupID" HeaderText="部门ID号与sys_Group表中GroupID关联" SortExpression="U_GroupID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Email" HeaderText="电子邮件" SortExpression="U_Email" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Type" HeaderText="用户类型0:超级用户1:普通用" SortExpression="U_Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Status" HeaderText="当前状态0:正常 1:禁止登陆" SortExpression="U_Status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Licence" HeaderText="用户序列号" SortExpression="U_Licence" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Mac" HeaderText="锁定机器硬件地址" SortExpression="U_Mac" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Remark" HeaderText="备注说明" SortExpression="U_Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_IDCard" HeaderText="身份证号码" SortExpression="U_IDCard" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Sex" HeaderText="性别1:男0:女" SortExpression="U_Sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_BirthDay" HeaderText="出生日期" SortExpression="U_BirthDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_MobileNo" HeaderText="手机号" SortExpression="U_MobileNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_UserNO" HeaderText="员工编号" SortExpression="U_UserNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_WorkStartDate" HeaderText="到职日期" SortExpression="U_WorkStartDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_WorkEndDate" HeaderText="离职日期" SortExpression="U_WorkEndDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_CompanyMail" HeaderText="公司邮件地址" SortExpression="U_CompanyMail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Title" HeaderText="职称与应用字段关联" SortExpression="U_Title" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_Extension" HeaderText="分机号" SortExpression="U_Extension" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_HomeTel" HeaderText="家中电话" SortExpression="U_HomeTel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_PhotoUrl" HeaderText="用户照片网址" SortExpression="U_PhotoUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_DateTime" HeaderText="操作时间" SortExpression="U_DateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_LastIP" HeaderText="最后访问IP" SortExpression="U_LastIP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_LastDateTime" HeaderText="最后访问时间" SortExpression="U_LastDateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_ExtendField" HeaderText="扩展字段" SortExpression="U_ExtendField" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_LoginType" HeaderText="登入类型(为空系统认证,其它值" SortExpression="U_LoginType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="U_HospitalGroupID" HeaderText="医院部门ID号与sys_Group表中GroupID关联" SortExpression="U_HospitalGroupID" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
