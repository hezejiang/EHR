<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.FollowUp.InfoManager" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="特定随访工作计划" HeadTitleTxt="特定随访工作计划管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="计划" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="特定随访工作计划">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body">
                        随访患者</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_PatientID_input" runat="server" Columns="30" title="请点击随访患者!" CssClass="text_input" ReadOnly></asp:TextBox>
                        <input type="hidden" id="F_PatientID" runat="server" />
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID()" class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                    <td class="table_body">
                        随访类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Type">
                            <asp:ListItem Text="高血压" Value="1" />
                            <asp:ListItem Text="糖尿病患者" Value="2" />
                            <asp:ListItem Text="儿童防疫" Value="3" />
                            <asp:ListItem Text="老年人保健" Value="4" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        随访日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_Date" runat="server" Columns="50" title="请输入随访日期!" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                    <td class="table_body table_body_NoWidth">
                        状态</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Status">
                            <asp:ListItem Text="未完成" Value="1" />
                            <asp:ListItem Text="已完成" Value="2" />
                            <asp:ListItem Text="已到期" Value="3" />
                        </asp:DropDownList>    
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
   	        document.all.<%=this.F_PatientID_input.ClientID %>.value="";
            document.all.<%=this.F_PatientID.ClientID %>.value="";
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
                        document.all.<%=this.F_PatientID.ClientID %>.value=result[1];
                        document.all.<%=this.F_PatientID_input.ClientID %>.value=result[2];
                    }
                }
            });            
        }
    </script>
</asp:Content>
