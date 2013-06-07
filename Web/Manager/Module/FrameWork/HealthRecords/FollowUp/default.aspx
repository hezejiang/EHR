<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.FollowUp._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="特定随访工作计划" HeadTitleTxt="特定随访工作计划管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="特定随访工作计划" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New" ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="特定随访工作计划">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="工作计划编号" DataTextField="FollowUpID" SortExpression="FollowUpID" DataNavigateUrlFields="FollowUpID"
                        DataNavigateUrlFormatString="InfoManager.aspx?FollowUpID={0}&CMD=Edit" />
                    <asp:BoundField SortExpression="U_CName" HeaderText="姓名" DataField="U_CName"/>
                    <asp:TemplateField SortExpression="F_Type" HeaderText="随访类型">
                        <ItemTemplate>
                            <%#getTypeName(Convert.ToInt32(Eval("F_Type")))%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField SortExpression="U_Sex" HeaderText="性别">
                        <ItemTemplate>
                            <%#getSexName(Convert.ToInt32(Eval("U_Sex")))%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="电话" DataField="U_MobileNo"/>
                    <asp:TemplateField SortExpression="U_Committee" HeaderText="村委会">
                        <ItemTemplate>
                            <%#getGroupModelById(Convert.ToInt32(Eval("U_Committee"))).G_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField SortExpression="U_ResponsibilityUserID" HeaderText="责任医生">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("U_ResponsibilityUserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="F_Date" HeaderText="随访日期" DataField="F_Date" DataFormatString="{0:yyyy-MM-dd}"/>
                    <asp:TemplateField SortExpression="F_Status" HeaderText="状态">
                        <ItemTemplate>
                            <%#getStatusName(Convert.ToInt32(Eval("FollowUpID")), Convert.ToInt32(Eval("F_Status")))%>
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
                        姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_CName" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        随访类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Type">
                            <asp:ListItem Text="不限" Value="0" />
                            <asp:ListItem Text="高血压" Value="1" />
                            <asp:ListItem Text="糖尿病患者" Value="2" />
                            <asp:ListItem Text="儿童防疫" Value="3" />
                            <asp:ListItem Text="老年人保健" Value="4" />
                        </asp:DropDownList>    
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        责任医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="U_ResponsibilityUserID"/>
                        <input runat="server" id="U_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" id="button2" name="buttonselect" onclick="javascript:ShowDepartID(2)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                    <td class="table_body table_body_NoWidth">
                        下次到访日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_Date" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        状态</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Status">
                            <asp:ListItem Text="不限" Value="0" />
                            <asp:ListItem Text="未完成" Value="1" />
                            <asp:ListItem Text="已完成" Value="2" />
                            <asp:ListItem Text="已到期" Value="3" />
                        </asp:DropDownList>    
                    </td>
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
                    if(type == 1){ //选择居委会
                        
                    }else if(type == 2){ //选择责任医生
                        onButtonEdit(ShValues[1]);
                    }else if(type == 3){ //选择建档单位
                        
                    }else if(type == 4){ //选择建档人
                        onButtonEdit(ShValues[1]);
                    }
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
            if(t == 1){
   	            
            }else if(t == 2){
                document.all.<%=this.U_ResponsibilityUserID.ClientID %>.value="";
                document.all.<%=this.U_ResponsibilityUserID_input.ClientID %>.value="";
            }else if(t == 3){
               
            }else if(t == 4){
                
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
                            
                        }
                    }
                }
            });            
        }

    </script>
</asp:Content>

