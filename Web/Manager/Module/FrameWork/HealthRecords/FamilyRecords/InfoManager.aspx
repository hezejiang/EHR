<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.FamilyRecords.InfoManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="家庭健康档案" HeadTitleTxt="家庭健康档案管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="信息" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="家庭健康档案登记">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr id="TopTr" runat="server">
                    <td class="table_body">
                        家庭健康档案编号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_FamilyCode" runat="server" Columns="50" title="无需填写！" CssClass="text_input" Enabled="false" Text="新增家庭档案时会自动生成"></asp:TextBox>
                    </td>
                     <td class="table_body">
                        户主</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="F_UserID" id="F_UserID" value=""/>
                        <input runat="server" name="F_UserID_input" id="F_UserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(1,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr id="Tr2" runat="server">
                    <td class="table_body">
                        家庭住址</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_FamilyAddress" runat="server" Columns="50" title="请填家庭住址！" CssClass="text_input"></asp:TextBox>
                    </td> 
                    <td class="table_body">
                        家庭电话</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_FamilyTel" runat="server" Columns="50" title="请填写家庭电话！" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr1" runat="server">
                    <td class="table_body">
                        厕所类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_ToiletType">
                            <asp:ListItem Text="家庭卫生厕所：三格式粪池式" Value="1" />
                            <asp:ListItem Text="家庭卫生厕所：双瓮漏斗式" Value="2" />
                            <asp:ListItem Text="家庭卫生厕所：三联沼气池式" Value="3" />
                            <asp:ListItem Text="家庭卫生厕所：粪尿分集式" Value="4" />
                            <asp:ListItem Text="家庭卫生厕所：完整下水道水冲式" Value="5" />
                            <asp:ListItem Text="家庭卫生厕所：双坑交替式" Value="6" />
                            <asp:ListItem Text="非卫生厕所：一格或两格粪池式" Value="7" />
                            <asp:ListItem Text="非卫生厕所：马桶" Value="8" />
                            <asp:ListItem Text="非卫生厕所：露天粪坑" Value="9" />
                            <asp:ListItem Text="非卫生厕所：简易棚厕" Value="10" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        房屋类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_HouseType">
                            <asp:ListItem Text="砖瓦平房" Value="1" />
                            <asp:ListItem Text="砖瓦楼房" Value="2" />
                            <asp:ListItem Text="土屋" Value="3" />
                            <asp:ListItem Text="茅屋" Value="4" />
                            <asp:ListItem Text="木屋" Value="5" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr3" runat="server">
                <td class="table_body">
                        居住面积</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_HouseArea" runat="server" Columns="50" title="请填居住面积！" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        通风条件</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Ventilation">
                            <asp:ListItem Text="好" Value="1" />
                            <asp:ListItem Text="一般" Value="2" />
                            <asp:ListItem Text="差" Value="3" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr4" runat="server">
                    <td class="table_body">
                        湿度</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Humidity">
                            <asp:ListItem Text="潮湿" Value="1" />
                            <asp:ListItem Text="干燥" Value="2" />
                            <asp:ListItem Text="一般" Value="3" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        保暖</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Warm">
                            <asp:ListItem Text="好" Value="1" />
                            <asp:ListItem Text="一般" Value="2" />
                            <asp:ListItem Text="差" Value="3" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr5" runat="server">
                    <td class="table_body">
                        采光</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Lighting">
                            <asp:ListItem Text="好" Value="1" />
                            <asp:ListItem Text="一般" Value="2" />
                            <asp:ListItem Text="差" Value="3" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        卫生</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Sanitation">
                            <asp:ListItem Text="好" Value="1" />
                            <asp:ListItem Text="一般" Value="2" />
                            <asp:ListItem Text="差" Value="3" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr6" runat="server">
                    <td class="table_body">
                        厨房</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Kitchen">
                            <asp:ListItem Text="合用" Value="1" />
                            <asp:ListItem Text="独用" Value="2" />
                            <asp:ListItem Text="无" Value="3" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        使用燃料</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Fuel">
                            <asp:ListItem Text="液化气" Value="1" />
                            <asp:ListItem Text="煤气" Value="2" />
                            <asp:ListItem Text="天然气" Value="3" />
                            <asp:ListItem Text="沼气" Value="4" />
                            <asp:ListItem Text="柴火" Value="5" />
                            <asp:ListItem Text="其他" Value="6" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr7" runat="server">
                    <td class="table_body">
                        垃圾处理</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_WasteDisposal">
                            <asp:ListItem Text="自行处理" Value="1" />
                            <asp:ListItem Text="垃圾箱" Value="2" />
                            <asp:ListItem Text="其他" Value="3" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        饮水来源</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_Water">
                            <asp:ListItem Text="自来水" Value="1" />
                            <asp:ListItem Text="经过滤净化的水" Value="2" />
                            <asp:ListItem Text="井水" Value="3" />
                            <asp:ListItem Text="河湖水" Value="4" />
                            <asp:ListItem Text="塘水口" Value="5" />
                            <asp:ListItem Text="桶装水" Value="6" />
                            <asp:ListItem Text="其他" Value="6" />
                        </asp:DropDownList>
                    </td>
                </tr>                <tr id="Tr8" runat="server">
                    <td class="table_body">
                        禽畜栏</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="F_LivestockBar">
                            <asp:ListItem Text="单设" Value="1" />
                            <asp:ListItem Text="室内" Value="2" />
                            <asp:ListItem Text="室外" Value="3" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        责任人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="F_ResponsibilityUserID" id="F_ResponsibilityUserID" value=""/>
                        <input runat="server" name="F_ResponsibilityUserID_input" id="F_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(2,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        建档人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="F_FillingUserID" id="F_FillingUserID" value=""/>
                        <input runat="server" name="F_FillingUserID_input" id="F_FillingUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(3,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(3);" class="cbutton" />
                    </td>
                    <td colspan="2" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
                        <input id="Reset1" class="button_bak" type="reset" value="重填" />&nbsp;
                    </td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>

        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="家庭主要问题">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr id="Tr9" runat="server">
                    <td class="table_body table_body_NoWidth">
                       记录时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_RecordTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr10" runat="server">
                <td class="table_body table_body_NoWidth">
                       发生时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_StartTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>                
                </tr>  
                <tr id="Tr100" runat="server">
                                    <td class="table_body table_body_NoWidth">
                       结束时间</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="F_endTime" runat="server" CssClass="text_input" onfocus="javascript:HS_setDate(this);" readonly></asp:TextBox>
                    </td>
                    </tr>
                <tr>
                    <td class="table_body">
                        问题概述</td>
                    <td class="table_none">
                        <asp:TextBox ID="F_OverviewProblem" runat="server" Columns="50" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        问题详述</td>
                    <td class="table_none">
                        <asp:TextBox ID="F_DetailProblem" runat="server" Columns="50" title="请输入问题详述!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px;"></asp:TextBox>
                    </td>
                </tr>              
                <tr>
                    <td class="table_body">
                        建档医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" id="F_FillingUserID2" value=""/>
                        <input runat="server" id="F_FillingUserID2_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(4,1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(4);" class="cbutton" />
                    </td>
                </tr>
                <tr id="Tr18" runat="server">
                    <td colspan="4" align="right">
                        <asp:Button ID="Button2" runat="server" CssClass="button_bak" Text="确定" 
                            onclick="Button2_Click" />
                        <input id="Reset2" class="button_bak" type="reset" value="重填" />&nbsp;
                    </td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>

    <!--Tab选项控件 end-->
    <script type="text/javascript">
        rnd.today=new Date(); 
        rnd.seed=rnd.today.getTime(); 
    
        function rnd() { 
　　　　    rnd.seed = (rnd.seed*9301+49297) % 233280; 
　　　　    return rnd.seed/(233280.0); 
        }

        function rand(number) { 
　　　　    return Math.ceil(rnd()*number); 
        }
    
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
   	            document.all.<%=this.F_UserID_input.ClientID %>.value="";
                document.all.<%=this.F_UserID.ClientID %>.value="";
            }else if(t == 2){
                document.all.<%=this.F_ResponsibilityUserID.ClientID %>.value="";
                document.all.<%=this.F_ResponsibilityUserID_input.ClientID %>.value="";
            }else if(t == 3){
                document.all.<%=this.F_FillingUserID.ClientID %>.value="";
                document.all.<%=this.F_FillingUserID_input.ClientID %>.value="";
            }else if(t == 4){
                document.all.<%=this.F_FillingUserID2.ClientID %>.value="";
                document.all.<%=this.F_FillingUserID2_input.ClientID %>.value="";
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
                    if (result[0] == "ok") 
                    {
                        if(type == 1){
   	                        document.all.<%=this.F_UserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_UserID_input.ClientID %>.value=result[2];
                        }else if(type == 2){
                            document.all.<%=this.F_ResponsibilityUserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_ResponsibilityUserID_input.ClientID %>.value=result[2];
                        }else if(type == 3){
                            document.all.<%=this.F_FillingUserID.ClientID %>.value=result[1];
                            document.all.<%=this.F_FillingUserID_input.ClientID %>.value=result[2];
                        }else if(type == 4){
                            document.all.<%=this.F_FillingUserID2.ClientID %>.value=result[1];
                            document.all.<%=this.F_FillingUserID2_input.ClientID %>.value=result[2];
                        }
                    }
                }
            });            
        }
        

    </script>
</asp:Content>
