<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="UserManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.UserManager.UserManager"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
        <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>

    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="用户资料" HeadTitleTxt="用户资料管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="用户" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="用户帐号">
        <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
		<tr>
			<td class="table_body table_body_NoWidth" style="height: 28px" >
                用户名</td>
			<td class="table_none table_none_NoWidth" style="height: 28px" >
                <asp:TextBox ID="U_LoginName" title="请输入用户名~20:!" runat="server" CssClass="text_input"></asp:TextBox>
                <asp:Label ID="U_LoginName_Value" runat="server"></asp:Label></td>
			<td class="table_body table_body_NoWidth" style="height: 28px" >
                密码</td>
			<td class="table_none table_none_NoWidth" style="height: 28px" >
                <asp:TextBox ID="U_Password" TextMode="Password" title="请输入密码~32:!" runat="server" CssClass="text_input"></asp:TextBox>
                <asp:Label ID="U_Password_Value" runat="server" ></asp:Label></td>            
		</tr>
            <tr>
                <td class="table_body table_body_NoWidth" >
                    用户类型</td>
                <td class="table_none table_none_NoWidth" >
                    <asp:DropDownList ID="U_Type" CssClass="U_Type" runat="server">
                    <asp:ListItem Value="1">普通用户</asp:ListItem>
                    <asp:ListItem Value="2" Enabled="false">管理员</asp:ListItem>
                    <asp:ListItem Value="0" Enabled="false">超级用户</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="U_Type_Value" runat="server"></asp:Label></td>
                <td class="table_body table_body_NoWidth" >
                    禁止登陆</td>
                <td class="table_none table_none_NoWidth" >
                    <asp:DropDownList ID="U_Status" runat="server">
                    <asp:ListItem Value="0">正常</asp:ListItem>
                    <asp:ListItem Value="1">禁止</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="U_Status_Value" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="table_body table_body_NoWidth">
                    用户角色</td>
                <td class="table_none table_none_NoWidth" colspan="3">
                    <asp:DropDownList runat="server" ID="dropDownList" DataTextField="R_RoleName" DataValueField="RoleID">
                        
                    </asp:DropDownList>
                    <asp:Label ID="Roles_Value" runat="server" Text=""></asp:Label>
                    (超级用户不受用户角色权限限制,默认所有权限.)
                    </td>
            </tr>
            <tr id="U_GroupID_tr">
                <td class="table_body table_body_NoWidth">
                    管理(所在)部门</td>
                    <td class="table_none table_none_NoWidth" colspan="3">
                        <span id="U_GroupID_Span" runat="server">
                        <input type="hidden" runat="server" name="U_GroupID" id="U_GroupID"><input runat=server name="U_GroupID_Txt" id="U_GroupID_Txt" class="text_input" readonly/>
                        <input type=button value="选择部门" id=button3 name="buttonselect" onClick="javascript:ShowDepartID()" class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                        </span>
                    <asp:Label ID="U_GroupID_Value" runat="server" Text=""></asp:Label></td>
            </tr>
		</table>      
        </FrameWorkWebControls:TabOptionItem>
        </FrameWorkWebControls:TabOptionWebControls>
    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center" id="PostButton" runat="server">
		<tr>
			<td align="right">
            <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
            <input id="Reset1" class="button_bak" type="reset" value="重填" />
            </td>
        </tr>
    </table>    
        <script language="javascript">
       var MaxImgUrl = "<%=MaxImgUrl %>"; 
        rnd.today=new Date(); 

    rnd.seed=rnd.today.getTime(); 

    function rnd() { 
　　　　rnd.seed = (rnd.seed*9301+49297) % 233280; 
　　　　return rnd.seed/(233280.0); 
    }; 

    function rand(number) { 
　　　　return Math.ceil(rnd()*number); 
    }; 
    
    
    function AlertMessageBox(file_name)
    {
	        if (file_name!=undefined){
	            var ShValues = file_name.split('||');
	            if (ShValues[1]!=0)
	            {
	                document.all.<%=this.U_GroupID_Txt.ClientID %>.value=ShValues[0];
	                document.all.<%=this.U_GroupID.ClientID %>.value=ShValues[1];
	            }            
	        }
    }
     function ShowDepartID()
    {
        showPopWin('选择部门','SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox,true,true)
    }
        
    function ClearSelect()
    {
   	    document.all.<%=this.U_GroupID_Txt.ClientID %>.value="";
        document.all.<%=this.U_GroupID.ClientID %>.value="";
    }

    function type(){
        var selectVal = $(".U_Type option:selected").val();
        if(selectVal){
            selectVal = parseInt(selectVal);
            if(selectVal == 2){
                $("#U_GroupID_tr").show();
            }else{
                $("#U_GroupID_tr").hide();
            }
        }
    }
    type();

    $(".U_Type").change(function(){
        type();
    });
    </script>
</asp:Content>
