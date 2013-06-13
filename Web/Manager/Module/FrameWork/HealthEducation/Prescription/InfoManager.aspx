<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.Web.Manager.Module.FrameWork.HealthEducation.Prescription.InfoManager" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="健康教育处方" HeadTitleTxt="健康教育处方管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="健康教育处方" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="健康教育处方">

            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr id="TopTr" runat="server">
                    <td class="table_body">
                        处方日期</td>
                    <td class="table_none">
                        <asp:TextBox ID="P_Date" runat="server" Columns="50" title="请选择处方日期!" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                </tr>
                <tr id="tr_username" runat="server">
                    <td class="table_body" >
                        处方对象</td>
                    <td class="table_none">
                        <asp:TextBox ID="P_Object_input" runat="server" Columns="50" title="请点击选择处方对象!"
                            CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="P_Object" runat="server" />
                        <input type=button value="选择处方对象" name="buttonselect" onClick="javascript:ShowDepartID(1)" class="cbutton">
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        处方名称</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="P_Name" runat="server" Columns="50" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body">
                        处方内容</td>
                    <td class="table_none">
                        <asp:TextBox ID="P_Content" runat="server" Columns="50" title="请输入信息内容!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px;"></asp:TextBox>
                    </td>
                </tr>
                <tr id="tr1" runat="server">
                    <td class="table_body" >
                        处方医生</td>
                    <td class="table_none">
                        <asp:TextBox ID="P_Doctor_input" runat="server" Columns="50" title="请点击选择处方医生!"
                            CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="P_Doctor" runat="server" />
                        <input type=button value="选择处方医生" name="buttonselect" onClick="javascript:ShowDepartID(2)" class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
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
        var type;

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

        function ShowDepartID(t)
        {
            type = t;
            showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox,true,true);
        }
       
        function ClearSelect(t)
        {
            type = t;
            if(type==1){
   	            document.all.<%=this.P_Object_input.ClientID %>.value="";
                document.all.<%=this.P_Object.ClientID %>.value="";
            }else if(type == 2){
                document.all.<%=this.P_Doctor_input.ClientID %>.value="";
                document.all.<%=this.P_Doctor.ClientID %>.value="";
            }
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
                        if(type == 1){
   	                        document.all.<%=this.P_Object_input.ClientID %>.value=result[2];
                            document.all.<%=this.P_Object.ClientID %>.value=result[1];
                        }else if(type == 2){
                            document.all.<%=this.P_Doctor_input.ClientID %>.value=result[2];
                            document.all.<%=this.P_Doctor.ClientID %>.value=result[1];
                        }
                    }
                }
            });            
        }
    </script>
</asp:Content>
