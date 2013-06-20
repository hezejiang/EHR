<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.ResponsibleDoctors._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="责任医生管理" HeadTitleTxt="责任医生管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="按指定档案更改">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="个人档案编号(身份证)" DataTextField="U_IDCard" SortExpression="U_IDCard" DataNavigateUrlFields="UserID"
                        DataNavigateUrlFormatString="InfoManager.aspx?UserID={0}&CMD=Edit" />
                    <asp:BoundField SortExpression="U_CName" HeaderText="姓名" DataField="U_CName"/>
                    <asp:BoundField HeaderText="现住址" DataField="U_CurrentAddress"/>
                    <asp:TemplateField HeaderText="居(村)委会">
                        <ItemTemplate>
                            <%#getGroupModelById(Convert.ToInt32(Eval("U_Committee"))).G_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="责任医生">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("U_ResponsibilityUserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="按医生批量更改">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        原责任医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="U_ResponsibilityUserID_Old"/>
                        <input runat="server" id="U_ResponsibilityUserID_Old_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button4" name="buttonselect" onclick="javascript:ShowDepartID(5,1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(5);" class="cbutton" />
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
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem3" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        身份证</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_IDCard" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_CName" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                   <td class="table_body table_body_NoWidth">
                        责任医生</td>
                   <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="U_ResponsibilityUserID"/>
                        <input runat="server" id="U_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button2" name="buttonselect" onclick="javascript:ShowDepartID(2,1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="查询" OnClick="Button1_Click" /></td>
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
                document.all.<%=this.U_ResponsibilityUserID.ClientID %>.value="";
                document.all.<%=this.U_ResponsibilityUserID_input.ClientID %>.value="";
            }else if(t == 3){
               
            }else if(t == 4){
                
            }else if(t == 5){
                document.all.<%=this.U_ResponsibilityUserID_Old.ClientID %>.value="";
                document.all.<%=this.U_ResponsibilityUserID_Old_input.ClientID %>.value="";
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
                            document.all.<%=this.U_ResponsibilityUserID.ClientID %>.value=result[1];
                            document.all.<%=this.U_ResponsibilityUserID_input.ClientID %>.value=result[2];
                        }else if(type == 4){
                            
                        }else if(type == 5){
                            document.all.<%=this.U_ResponsibilityUserID_Old.ClientID %>.value=result[1];
                            document.all.<%=this.U_ResponsibilityUserID_Old_input.ClientID %>.value=result[2];
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


