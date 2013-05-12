﻿<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthSupervision.Info._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="信息登记列表" HeadTitleTxt="信息登记列表管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="信息" ButtonPopedom="New" ButtonUrl="InfoManager.aspx?CMD=New"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="信息登记列表">
            <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
                OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:HyperLinkField HeaderText="信息编号" DataTextField="InfoID" SortExpression="InfoID" DataNavigateUrlFields="InfoID"
                        DataNavigateUrlFormatString="InfoManager.aspx?InfoID={0}&CMD=Edit" />
                    <asp:BoundField SortExpression="I_FindDate" HeaderText="发现时间" DataField="I_FindDate" DataFormatString="{0:yyyy/MM/dd}"/>
                    
                    <asp:TemplateField SortExpression="I_Type" HeaderText="信息类型">
                        <ItemTemplate>
                            <%#getSuperisionNameByType(Convert.ToInt32(Eval("I_Type")))%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField SortExpression="I_Content" HeaderText="信息内容" DataField="I_Content"/>
                    <asp:BoundField SortExpression="I_ReportDate" HeaderText="报告时间" DataField="I_ReportDate" DataFormatString="{0:yyyy/MM/dd}"
                        HtmlEncode="false" />
                    <asp:TemplateField SortExpression="I_ReportUserID" HeaderText="报告人">
                        <ItemTemplate>
                            <%#getUserNameById(Convert.ToInt32(Eval("I_ReportUserID"))).U_LoginName%>
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
                        发现时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="I_FindDate" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        信息类别</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="I_Type">
                            <asp:ListItem Text="无" Value="0" />
                            <asp:ListItem Text="食品安全" Value="1" />
                            <asp:ListItem Text="饮用水卫生" Value="2" />
                            <asp:ListItem Text="职业病安全" Value="3" />
                            <asp:ListItem Text="学校卫生" Value="4" />
                            <asp:ListItem Text="非法行医（采供血）" Value="5" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        报告时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="I_ReportDate" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox></td>
                    <td class="table_body table_body_NoWidth">
                        报告人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="I_ReportUserID" id="I_ReportUserID" value=""/>
                        <input runat="server" name="U_GroupID_Txt" id="I_ReportUserID_Txt" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择报告人" id="button3" name="buttonselect" onclick="javascript:ShowDepartID()"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body table_body_NoWidth">
                        信息内容</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="I_Content" runat="server" CssClass="text_input"></asp:TextBox></td>
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
    
    
    function AlertMessageBox(file_name)
    {

	    if (file_name!=undefined){
	        var ShValues = file_name.split('||');
	        if (ShValues[1]!=0)
	        {
                showPopWin('选择用户','SelectUser.aspx?rand='+rand(1000000), 215, 255, AlertMessageBox2,true,true);
	        }
	    }   
    }

    function AlertMessageBox2(file_name)
    {
	    if (file_name!=undefined){
	        var ShValues = file_name.split('||');
	        if (ShValues[1]!=0)
	        {
	            document.all.<%=this.I_ReportUserID_Txt.ClientID %>.value=ShValues[0];
	            document.all.<%=this.I_ReportUserID.ClientID %>.value=ShValues[1];
	        }          
	    }
    }

    function ShowDepartID()
    {
        showPopWin('选择部门','SelectGroup.aspx?'+rand(10000000), 215, 255, AlertMessageBox2,true,true);
    }
       
    function ClearSelect()
    {
   	    document.all.<%=this.I_ReportUserID_Txt.ClientID %>.value="";
        document.all.<%=this.I_ReportUserID.ClientID %>.value="";
    }
    </script>
</asp:Content>

