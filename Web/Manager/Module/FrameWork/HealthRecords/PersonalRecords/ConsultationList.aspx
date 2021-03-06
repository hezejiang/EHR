﻿<%@ Page MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" Language="C#" AutoEventWireup="true" CodeBehind="ConsultationList.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords.ConsultationList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="会诊记录列表" HeadTitleTxt="会诊记录列表管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="信息登记列表">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="会诊流水号" DataTextField="ConsultationID" SortExpression="ConsultationID" DataNavigateUrlFields="ConsultationID"
                        DataNavigateUrlFormatString="ConsultationManager.aspx?ConsultationID={0}&CMD=Edit" />
                    <asp:TemplateField SortExpression="C_UserID" HeaderText="健康档案号">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("C_UserID"))).U_IDCard%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="C_Cause" HeaderText="会诊原因" DataField="C_Cause"/>
                    <asp:BoundField SortExpression="C_Comments" HeaderText="会诊意见" DataField="C_Comments"/>
                    <asp:TemplateField SortExpression="C_Dortor" HeaderText="会诊医生">
                        <ItemTemplate>
                            <%#getUserModelById(Convert.ToInt32(Eval("C_Dortor"))).U_CName%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="C_Time" HeaderText="会诊日期" DataField="C_Time" DataFormatString="{0:yyyy/MM/dd}"/>
                </Columns>
            </asp:GridView>
            <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="查询">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body table_body_NoWidth">
                        会诊原因</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="C_Cause" runat="server" CssClass="text_input"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        会诊意见</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="C_Comments" runat="server" CssClass="text_input"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                    会诊医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="C_Dortor" id="C_Dortor" value=""/>
                        <input runat="server" name="C_Dortor_input" id="C_Dortor_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID()"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                    <td class="table_body table_body_NoWidth">
                        会诊日期</td>
                    <td class="table_none table_none_NoWidth">
                        <input id="C_Time" runat="server" class="text_input" onfocus="javascript:HS_setDate(this);" style="margin-right:20px;"/>
                    </td>
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
                document.all.<%=this.C_Dortor.ClientID %>.value=ShValues[1];
                document.all.<%=this.C_Dortor_input.ClientID %>.value=ShValues[0];
	        }
	    }   
    }

    function ShowDepartID()
    {
        showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox2,true,true);
    }
    
    function ClearSelect()
    {
   	    document.all.<%=this.C_Dortor_input.ClientID %>.value="";
        document.all.<%=this.C_Dortor.ClientID %>.value="";
    }

    function AlertMessageBox2(file_name)
    {
	    if (file_name!=undefined){
	        var ShValues = file_name.split('||');
	        if (ShValues[1]!=0)
	        {
                onButtonEdit(ShValues[1]);
	        }
	    }
    }

    function ShowDepartID2()
    {
        showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox2,true,true);
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
                    document.all.<%=this.C_Dortor.ClientID %>.value=result[1];
                    document.all.<%=this.C_Dortor_input.ClientID %>.value=result[2];
                }
            }
        });            
    }

    </script>
</asp:Content>

