<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthEducation.Prescription._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="健康教育处方管理" HeadTitleTxt="健康教育处方管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="健康教育处方" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New" ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="健康教育处方">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="健康处方ID" DataTextField="PrescriptionID" SortExpression="PrescriptionID" DataNavigateUrlFields="PrescriptionID"
                        DataNavigateUrlFormatString="InfoManager.aspx?PrescriptionID={0}&CMD=Edit" />
                    <asp:TemplateField HeaderText="处方对象">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("P_Object"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="P_Date" HeaderText="活动日期" DataField="P_Date" DataFormatString="{0:yyyy/MM/dd}"/>
                    <asp:BoundField HeaderText="处方名称" DataField="P_Name"/>
                    <asp:BoundField HeaderText="处方内容" DataField="P_Content"/>
                    <asp:TemplateField HeaderText="处方医生">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("P_Doctor"))).U_CName%>
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
                        处方日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="P_Date" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        处方名称</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="P_Name" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body">
                        处方对象</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="P_Object_input" runat="server" title="请点击选择处方对象!" CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="P_Object" runat="server" />
                        <input type="button" value="选择" name="buttonselect" onClick="javascript:ShowDepartID(1)" class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                    <td class="table_body">
                        处方医生</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="P_Doctor_input" runat="server" title="请点击选择处方医生!" CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="P_Doctor" runat="server" />
                        <input type="button" value="选择" name="buttonselect" onClick="javascript:ShowDepartID(2)" class="cbutton"/>
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

