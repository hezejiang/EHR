<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.record_HealthCheck.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		健康体检ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHealthID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体温
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_BodyTemperature" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		脉率（次/min）
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_PulseRate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		呼吸频率（次/min）
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_RespiratoryRate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		左侧舒张压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_LeftDiastolic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		左侧收缩压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_LeftSystolic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		右侧舒张压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_RightDiastolic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		右侧收缩压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_RightSystolic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身高（cm）
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_Height" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体重（kg）
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_Weight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检结果
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_Result" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检建议
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_Suggestion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_CheckTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检机构
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_MedicalInstitutions" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检医生
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblH_CheckUserID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




