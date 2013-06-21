<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.ResponsibleDoctors.InfoManager"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="责任医生管理" HeadTitleTxt="责任医生管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="按指定档案更改">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        身份证</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_IDCard" runat="server" />
                    </td>
                    <td class="table_body table_body_NoWidth">
                        姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_CName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        原责任医生</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_ResponsibilityUserID" runat="server" />
                    </td>
                    <td class="table_body table_body_NoWidth">
                        新责任医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="U_ResponsibilityUserID_New"/>
                        <input runat="server" id="U_ResponsibilityUserID_New_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button5" name="buttonselect" onclick="javascript:ShowDepartID(6,1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(6);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="save" runat="server" CssClass="button_bak" Text="保存" 
                            onclick="save_Click" /></td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
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
    
        var type;

        function AlertMessageBox(file_name)
        {
	        if (file_name!=undefined){
	            var ShValues = file_name.split('||');
	            if (ShValues[1]!=0)
	            {
                    if(type == 1){ //选择居委会
                        
                    }else if(type == 2){ //选择责任医生
                        onButtonEdit(ShValues[1]);
                    }else if(type == 3){ //选择建档单位
                        
                    }else if(type == 4){ //选择建档人
                        onButtonEdit(ShValues[1]);
                    }else if(type == 5){ //选择原责任医生
                        onButtonEdit(ShValues[1]);
                    }else if(type == 6){ //选择新责任医生
                        onButtonEdit(ShValues[1]);
                    }
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
   	            
            }else if(t == 2){
                
            }else if(t == 3){
               
            }else if(t == 4){
                
            }else if(t == 5){
                
            }else if(t == 6){
                document.all.<%=this.U_ResponsibilityUserID_New.ClientID %>.value="";
                document.all.<%=this.U_ResponsibilityUserID_New_input.ClientID %>.value="";
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
                        if(type == 2){
                            
                        }else if(type == 4){
                            
                        }else if(type == 5){
                            
                        }else if(type == 6){
                            document.all.<%=this.U_ResponsibilityUserID_New.ClientID %>.value=result[1];
                            document.all.<%=this.U_ResponsibilityUserID_New_input.ClientID %>.value=result[2];
                        }
                    }
                }
            });            
        }

    </script>
</asp:Content>


