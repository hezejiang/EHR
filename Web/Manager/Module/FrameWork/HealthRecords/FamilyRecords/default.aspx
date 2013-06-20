<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.FamilyRecords._default"  %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="家庭健康档案列表" HeadTitleTxt="家庭健康档案列表管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="家庭健康档案列表">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="家庭档案编号" DataTextField="F_FamilyCode" SortExpression="F_FamilyCode" DataNavigateUrlFields="FamilyID"
                        DataNavigateUrlFormatString="InfoManager.aspx?FamilyID={0}&CMD=Edit" />
                    <asp:TemplateField SortExpression="F_UserID" HeaderText="户主">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("F_UserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="F_FamilyTel" HeaderText="家庭电话" DataField="F_FamilyTel"/>
                    <asp:BoundField SortExpression="F_FamilyAddress" HeaderText="家庭住址" DataField="F_FamilyAddress"/>
                    <asp:TemplateField SortExpression="F_ResponsibilityUserID" HeaderText="责任人">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("F_ResponsibilityUserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField SortExpression="F_FillingUserID" HeaderText="建档人">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("F_FillingUserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        家庭档案编号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_FamilyCode" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        户主</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="F_UserID" value=""/>
                        <input runat="server" id="F_UserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button4" name="buttonselect" onclick="javascript:ShowDepartID(1,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        责任人</td>
                   <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="F_ResponsibilityUserID"/>
                        <input runat="server" id="F_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button2" name="buttonselect" onclick="javascript:ShowDepartID(2,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                    <td class="table_body table_body_NoWidth">
                        家庭电话</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_FamilyTel" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        户主</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="F_FillingUserID" value=""/>
                        <input runat="server" id="F_FillingUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button3" name="buttonselect" onclick="javascript:ShowDepartID(4,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(4);" class="cbutton" />
                    </td>
                    <td colspan="2" align="right">
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
                    if(type == 1){ //选择户主
                        onButtonEdit(ShValues[1]);
                    }else if(type == 2){ //选择责任人
                        onButtonEdit(ShValues[1]);
                    }else if(type == 3){ //选择建档单位
                        
                    }else if(type == 4){ //选择建档人
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
   	            document.all.<%=this.F_UserID.ClientID %>.value="";
                document.all.<%=this.F_UserID_input.ClientID %>.value="";
            }else if(t == 2){
                document.all.<%=this.F_ResponsibilityUserID.ClientID %>.value="";
                document.all.<%=this.F_ResponsibilityUserID_input.ClientID %>.value="";
            }else if(t == 3){
               
            }else if(t == 4){
                document.all.<%=this.F_FillingUserID.ClientID %>.value="";
                document.all.<%=this.F_FillingUserID_input.ClientID %>.value="";
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
                            document.all.<%=this.F_FillingUserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_FillingUserID_input.ClientID %>.value=result[2];
                        }else if(type == 2){
                            document.all.<%=this.F_ResponsibilityUserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_ResponsibilityUserID_input.ClientID %>.value=result[2];
                        }else if(type == 4){
                            document.all.<%=this.F_FillingUserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_FillingUserID_input.ClientID %>.value=result[2];
                        }
                    }
                }
            });            
        }

    </script>
</asp:Content>
