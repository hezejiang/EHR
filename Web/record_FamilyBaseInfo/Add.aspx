<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.record_FamilyBaseInfo.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		家庭档案编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_FimaryCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		户主
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_UserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		村(居)委会ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_GroupID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		F_FimaryTel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_FimaryTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		家庭地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_FimrayAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		房屋类型 1:砖瓦平房
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_HouseType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		居住面积
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_HouseArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		通风 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Ventilation" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		湿度 1:潮湿
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Humidity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		保暖 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Warm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		采光 1:好
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Lighting" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卫生 1:清洁
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Sanitation" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		厨房 1:合用
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Kitchen" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用燃料 1：液化气
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Fuel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		饮水来源 1：自来水
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_Water" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		垃圾处理 1：垃圾处理
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_WasteDisposal" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		禽畜栏 1：单设
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_LivestockBar" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		厕所类型 1：家庭卫生厕所：三格式粪池式
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_ToiletType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		责任人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_ResponsibilityUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		建档人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtF_FillingUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
