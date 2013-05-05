<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.record_HealthCheck.Modify" Title="修改页" %>
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
		<asp:label id="lblHealthID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体温
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_BodyTemperature" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		脉率（次/min）
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_PulseRate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		呼吸频率（次/min）
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_RespiratoryRate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		左侧舒张压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_LeftDiastolic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		左侧收缩压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_LeftSystolic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		右侧舒张压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_RightDiastolic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		右侧收缩压(mmHg)
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_RightSystolic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		身高（cm）
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_Height" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体重（kg）
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_Weight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检结果
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_Result" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检建议
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_Suggestion" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtH_CheckTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检机构
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_MedicalInstitutions" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		体检医生
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtH_CheckUserID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

