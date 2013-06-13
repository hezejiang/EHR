<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.DeathRegistration._default"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="死亡登记列表" HeadTitleTxt="死亡登记列表管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="死亡登记" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="死亡登记列表">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="死亡编号" DataTextField="DeathID" SortExpression="DeathID" DataNavigateUrlFields="DeathID"
                        DataNavigateUrlFormatString="InfoManager.aspx?DeathID={0}&CMD=Edit" />
                        <asp:BoundField SortExpression="D_Location" HeaderText="死亡地点" DataField="D_Location" 
                        HtmlEncode="false" />
                    <asp:BoundField SortExpression="D_DateTime" HeaderText="死亡时间" DataField="D_DateTime" DataFormatString="{0:yyyy/MM/dd}"/>
                    <asp:BoundField SortExpression="D_RegDate" HeaderText="登记日期" DataField="D_RegDate" DataFormatString="{0:yyyy/MM/dd}"/>
                    <asp:TemplateField SortExpression="D_UserID" HeaderText="登记人">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("D_UserID"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="D_Reason" HeaderText="死亡原因" DataField="D_Reason"/>
                </Columns>
            </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>

        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                       死亡时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_DateTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                     <td class="table_body table_body_NoWidth">
                       登记时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_RegDate" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        死亡地点</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_Location" runat="server" CssClass="text_input" ></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        登记人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="D_UserID" id="D_UserID" value=""/>
                        <input runat="server" name="D_UserID_input" id="D_UserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择登记人" id="button3" name="buttonselect" onclick="javascript:ShowDepartID()"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        死亡原因</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="D_Reason" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="查询" OnClick="Button1_Click" /></td>
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
   	        document.all.<%=this.D_UserID_input.ClientID %>.value="";
            document.all.<%=this.D_UserID.ClientID %>.value="";
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
                        document.all.<%=this.D_UserID.ClientID %>.value=result[1];
                        document.all.<%=this.D_UserID_input.ClientID %>.value=result[2];
                    }
                }
            });            
        }

    </script>
</asp:Content>
