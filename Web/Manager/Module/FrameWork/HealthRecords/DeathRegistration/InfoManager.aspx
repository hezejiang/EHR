<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master"  AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.DeathRegistration.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="死亡登记" HeadTitleTxt="死亡登记管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="死亡" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="死亡登记">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                       死亡时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_DateTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                    <td class="table_body table_body_NoWidth">
                        死亡用户</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="D_UserID" id="D_UserID" value=""/>
                        <input runat="server" name="D_UserID_input" id="D_UserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button2" name="buttonselect" onclick="javascript:ShowDepartID(1,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                       登记时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_RegDate" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                    <td class="table_body table_body_NoWidth">
                        死亡地点</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_Location" runat="server" CssClass="text_input" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        死亡原因</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_Reason" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        登记人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="D_RegUserID" id="D_RegUserID" value=""/>
                        <input runat="server" name="D_RegUserID_input" id="D_RegUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button3" name="buttonselect" onclick="javascript:ShowDepartID(2,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="查询" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>
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
    
        
        var type;
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

        function ShowDepartID(t, G_type)
        {
            type = t;
            showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000)+"&G_type="+G_type, 215, 255, AlertMessageBox,true,true);
        }

        function ClearSelect(t)
        {
            if(t == 1){
   	            document.all.<%=this.D_UserID_input.ClientID %>.value="";
                document.all.<%=this.D_UserID.ClientID %>.value="";
            }else if(t == 2){
                document.all.<%=this.D_RegUserID_input.ClientID %>.value="";
                document.all.<%=this.D_RegUserID.ClientID %>.value="";
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
                            document.all.<%=this.D_UserID.ClientID %>.value=result[1];
                            document.all.<%=this.D_UserID_input.ClientID %>.value=result[2];
                        }else if(type == 2){
                            document.all.<%=this.D_RegUserID.ClientID %>.value=result[1];
                            document.all.<%=this.D_RegUserID_input.ClientID %>.value=result[2];
                        }
                    }
                }
            });            
        }

    </script>
</asp:Content>
