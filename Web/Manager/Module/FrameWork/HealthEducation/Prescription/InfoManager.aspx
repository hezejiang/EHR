<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="Maticsoft.Web.Manager.Module.FrameWork.HealthEducation.Prescription.InfoManager" %>


<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="健康教育活动" HeadTitleTxt="健康教育活动管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="活动" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="健康教育活动">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body">
                        活动时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_DateTime" runat="server" Columns="50" title="请选择活动时间!" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        活动地点</td>
                    <td class="table_none table_none_NoWidth">
                    <asp:TextBox ID="A_Location" runat="server" Columns="50" title="请选择活动地点!" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        活动对象</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Object_input" runat="server" Columns="30" title="请点击选择活动对象!" CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="A_Object" runat="server" />
                        <input type="button" value="选择" name="buttonselect" onClick="javascript:ShowDepartID()" class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                    <td class="table_body">
                        活动人群</td>
                    <td class="table_none table_none_NoWidth">
                    <asp:TextBox ID="A_Crowd" runat="server" Columns="50" title="请输入活动人群!" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        活动形式</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Form" runat="server" Columns="50" title="请输入活动形式!" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        持续时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Duration" runat="server" Columns="45" title="请输入持续时间!单位是分钟" CssClass="text_input"></asp:TextBox>&nbsp;&nbsp;min
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        主办单位</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Organizers" runat="server" Columns="50" title="请输入主办单位!" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        合作伙伴</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Partners" runat="server" Columns="50" title="请输入合作伙伴!" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        宣教人</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Missionary" runat="server" Columns="50" title="请输入宣教人!" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        参与人数</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="A_Number" runat="server" Columns="50" title="请输入参与人数" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        活动主题</td>
                    <td class="table_none" colspan="3">
                        <asp:TextBox ID="A_Theme" runat="server" title="请输入活动主题!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px; width:100%;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
                        <input id="Reset1" class="button_bak" type="reset" value="重填" />&nbsp;
                    </td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
        <!--Tab选项控件的第一个子选项 end-->
        <!--Tab选项控件的第二个子选项 start-->
            <!--如果有多Tab子选项就仿照第一个子选项的写法-->
        <!--Tab选项控件的第二个子选项 end-->
    </FrameWorkWebControls:TabOptionWebControls>
    <!--Tab选项控件 end-->
    <script language="javascript">
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
                    document.all.<%=this.A_Object_input.ClientID %>.value=ShValues[0];
                    document.all.<%=this.A_Object.ClientID %>.value=ShValues[1];
	            }
	        }   
        }

        function ShowDepartID()
        {
            showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox,true,true);
        }
       
        function ClearSelect()
        {
   	        document.all.<%=this.A_Object_input.ClientID %>.value="";
            document.all.<%=this.A_Object.ClientID %>.value="";
        }
    </script>
</asp:Content>
