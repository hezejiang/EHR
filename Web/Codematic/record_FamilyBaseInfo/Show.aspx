<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.record_FamilyBaseInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		自增家庭ID号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFimaryID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭档案编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_FimaryCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		户主
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_UserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		村(居)委会ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_GroupID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		F_FimaryTel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_FimaryTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_FimrayAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		房屋类型 1:砖瓦平房
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_HouseType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		居住面积
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_HouseArea" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		通风 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Ventilation" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		湿度 1:潮湿
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Humidity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		保暖 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Warm" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		采光 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Lighting" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卫生 1:清洁
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Sanitation" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		厨房 1:合用
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Kitchen" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用燃料 1：液化气
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Fuel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		饮水来源 1：自来水
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_Water" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		垃圾处理 1：垃圾处理
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_WasteDisposal" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		禽畜栏 1：单设
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_LivestockBar" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		厕所类型 1：家庭卫生厕所：三格式粪池式
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_ToiletType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		责任人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_ResponsibilityUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblF_FillingUserID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




