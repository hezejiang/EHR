<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthSupervision.Info.InfoManager" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="信息登记" HeadTitleTxt="信息登记管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="信息" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="信息登记">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr id="TopTr" runat="server">
                    <td class="table_body">
                        发现时间</td>
                    <td class="table_none">
                        <asp:Label ID="I_FindDate_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="I_FindDate" runat="server" Columns="50" title="请选择发现时间!" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                </tr>
                <tr runat="server">
                    <td class="table_body">
                        信息类别</td>
                    <td class="table_none">
                        <asp:Label ID="I_Type_Txt" runat="server" title="请选择信息类别!" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="I_Type">
                            <asp:ListItem Text="食品安全" Value="1" />
                            <asp:ListItem Text="饮用水卫生" Value="2" />
                            <asp:ListItem Text="职业病安全" Value="3" />
                            <asp:ListItem Text="学校卫生" Value="4" />
                            <asp:ListItem Text="非法行医（采供血）" Value="5" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        信息内容</td>
                    <td class="table_none">
                        <asp:Label ID="I_Content_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="I_Content" runat="server" Columns="50" title="请输入信息内容!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        报告时间</td>
                    <td class="table_none">
                        <asp:Label ID="I_ReportDate_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="I_ReportDate" runat="server" Columns="50" title="请输入报告时间!"
                            CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                </tr>
                <tr id="tr_username" runat="server">
                    <td class="table_body" >
                        报告人</td>
                    <td class="table_none">
                        <asp:Label ID="I_ReportUserID_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="I_ReportUserID_input" runat="server" Columns="50" title="请点击选择报告人!"
                            CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="I_ReportUserID" runat="server" />
                        <input type=button value="选择报告人" name="buttonselect" onClick="javascript:ShowDepartID()" class="cbutton">
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                </tr>
                <tr id="SubmitTr" runat="server">
                    <td colspan="2" align="right">
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
                onButtonEdit(ShValues[1]);
	        }
	    }   
    }

    function ShowDepartID()
    {
        showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox,true,true);
    }
       
    function ClearSelect()
    {
   	    document.all.<%=this.I_ReportUserID_input.ClientID %>.value="";
        document.all.<%=this.I_ReportUserID.ClientID %>.value="";
    }

    mini.parse();

    function onButtonEdit(id) {
        mini.open({
            url: "../../CommonModule/SelectUser.aspx?"+rand(10000000)+"&GroupID="+id,
            title: "选择列表",
            width: 800,
            height: 380,
            ondestroy: function (action) {
                //if (action == "close") return false;
                var result = action.split("||");
                if (result[0] == "ok") {
                    document.all.<%=this.I_ReportUserID.ClientID %>.value=result[1];
                    document.all.<%=this.I_ReportUserID_input.ClientID %>.value=result[2];
                }
            }
        });            
    }

    </script>
</asp:Content>
