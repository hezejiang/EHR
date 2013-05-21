<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.PersonalRecords.InfoManager" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />
    <style type="text/css">
        legend.big_title{ font-style:oblique; font-weight:bold;}
    </style>
    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="个人健康档案" HeadTitleTxt="个人健康档案管理">
        <FrameWorkWebControls:HeadMenuButtonItem ButtonName="个人健康档案" ButtonPopedom="List" ButtonUrl="Default.aspx"
            ButtonUrlType="Href" ButtonVisible="True" />
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="基本信息">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr id="TopTr" runat="server">
                    <td class="table_body">
                        个人健康档案编号（身份证）</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_IDCard_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_IDCard" runat="server" Columns="50" title="请填写个人身份证号" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_CName_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_CName" runat="server" Columns="50" title="请填真实姓名" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr1" runat="server">
                    <td class="table_body">
                        籍贯</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_Hometown_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_Hometown" runat="server" Columns="50" title="请填籍贯" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        现住址</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_CurrentAddress_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_CurrentAddress" runat="server" Columns="50" title="请填现住址" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr runat="server">
                    <td class="table_body">
                        性别</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_Sex_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_Sex" title="请选择性别">
                            <asp:ListItem Text="女" Value="0" />
                            <asp:ListItem Text="男" Value="1" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        民族</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_NationID_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_NationID" title="请选择民族">
                            <asp:ListItem Text="女" Value="0" />
                            <asp:ListItem Text="男" Value="1" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr2" runat="server">
                    <td class="table_body">
                        婚姻状态</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_MarriageStatus_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_MarriageStatus" title="请选择性别">
                            <asp:ListItem Text="未婚" Value="1" />
                            <asp:ListItem Text="已婚" Value="2" />
                            <asp:ListItem Text="丧偶" Value="3" />
                            <asp:ListItem Text="离婚" Value="4" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        血型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_BloodType_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_BloodType" title="请选择民族">
                            <asp:ListItem Text="A型" Value="1" />
                            <asp:ListItem Text="B型" Value="2" />
                            <asp:ListItem Text="AB型" Value="3" />
                            <asp:ListItem Text="O型" Value="4" />
                            <asp:ListItem Text="不详" Value="0" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr id="Tr3" runat="server">
                    <td class="table_body">
                        联系方式</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_MobileNo_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:TextBox ID="U_MobileNo" runat="server" Columns="50" title="请填写联系方式" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        居(村)委会</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_Committee_Txt" runat="server"></asp:Label>
                        <input type="hidden" runat="server" name="U_Committee" id="U_Committee" value=""/>
                        <input runat="server" name="U_Committee_input" id="U_Committee_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr id="Tr4" runat="server">
                    <td class="table_body">
                        常住类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_PermanentType_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_PermanentType" title="请选择常住类型">
                            <asp:ListItem Text="户籍" Value="1" />
                            <asp:ListItem Text="非户籍" Value="2" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        文化程度</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_Education_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_Education" title="请选择文化程度">
                            <asp:ListItem Text="文盲及半文盲" Value="1" />
                            <asp:ListItem Text="小学" Value="2" />
                            <asp:ListItem Text="中学" Value="3" />
                            <asp:ListItem Text="高中/技校/中专" Value="4" />
                            <asp:ListItem Text="大学专科" Value="5" />
                            <asp:ListItem Text="大学本科" Value="6" />
                            <asp:ListItem Text="研究生及以上" Value="7" />
                            <asp:ListItem Text="不详" Value="0" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        工作单位</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_WorkingUnits_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_WorkingUnits" runat="server" Columns="50" title="请输入工作单位" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        职位联系人姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_WorkingContactName_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_WorkingContactName" runat="server" Columns="50" title="请输入职位联系人姓名"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        职位联系人号码</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_WorkingContactTel_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_WorkingContactTel" runat="server" Columns="50" title="请输入职位联系人号码"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        付费类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_PaymentType_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_PaymentType" title="请选择付费类型">
                            <asp:ListItem Text="城镇职工基本医疗保险" Value="1" />
                            <asp:ListItem Text="城镇居民基本医疗保险" Value="2" />
                            <asp:ListItem Text="贫困扶助" Value="3" />
                            <asp:ListItem Text="新型农村合作医疗" Value="4" />
                            <asp:ListItem Text="商业医疗保险" Value="5" />
                            <asp:ListItem Text="全公费" Value="6" />
                            <asp:ListItem Text="全自费" Value="7" />
                            <asp:ListItem Text="其他" Value="8" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        社保号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_SocialNO_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_SocialNO" runat="server" Columns="50" title="请输入社保号"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        医保号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_MedicalNO_Txt" runat="server"></asp:Label>
                        <asp:TextBox ID="U_MedicalNO" runat="server" Columns="50" title="请输入医保号"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        家庭编号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_FamilyCode_Txt" runat="server"></asp:Label>
                        <input runat="server" id="U_FamilyCode" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(2)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                    <td class="table_body">
                        与户主关系</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_RelationShip_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_RelationShip" title="请选择与户主关系">
                            <asp:ListItem Text="户主" Value="0" />
                            <asp:ListItem Text="父亲" Value="1" />
                            <asp:ListItem Text="母亲" Value="2" />
                            <asp:ListItem Text="儿子" Value="3" />
                            <asp:ListItem Text="儿媳" Value="4" />
                            <asp:ListItem Text="女儿" Value="5" />
                            <asp:ListItem Text="女婿" Value="6" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        责任医生</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_ResponsibilityUserID_Txt" runat="server"></asp:Label>
                        <input type="hidden" runat="server" name="U_ResponsibilityUserID" id="U_ResponsibilityUserID" value=""/>
                        <input runat="server" name="U_ResponsibilityUserID_input" id="U_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(2)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                    <td class="table_body">
                        档案状态</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_AuditStatus_Txt" runat="server" CssClass="text_input"></asp:Label>
                        <asp:DropDownList runat="server" ID="U_AuditStatus" title="请选择档案状态">
                            <asp:ListItem Text="正常" Value="1" />
                            <asp:ListItem Text="审核中" Value="2" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        建档单位</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_FilingUnits_Txt" runat="server"></asp:Label>
                        <input type="hidden" runat="server" name="U_FilingUnits" id="U_FilingUnits" value=""/>
                        <input runat="server" name="U_FilingUnits_input" id="U_FilingUnits_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(3)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(3);" class="cbutton" />
                    </td>
                    <td class="table_body">
                        建档人</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="U_FilingUserID_Txt" runat="server"></asp:Label>
                        <input type="hidden" runat="server" name="U_FilingUserID" id="U_FilingUserID" value=""/>
                        <input runat="server" name="U_FilingUserID_input" id="U_FilingUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(4)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(4);" class="cbutton" />
                    </td>
                </tr>
                <tr id="SubmitTr" runat="server">
                    <td colspan="4" align="right">
                        <asp:Button ID="Button1" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
                        <input id="Reset1" class="button_bak" type="reset" value="重填" />&nbsp;
                    </td>
                </tr>
            </table>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="扩展信息">
            <fieldset>
               <legend class="big_title">既往史</legend>
               <fieldset>
                    <legend>疾病史</legend>

               </fieldset>
               <fieldset>
                    <legend>手术史</legend>

               </fieldset>
               <fieldset>
                    <legend>外伤史</legend>

               </fieldset>
               <fieldset>
                    <legend>输血史</legend>

               </fieldset>
               <fieldset>
                    <legend>遗传病史</legend>

               </fieldset>
               <fieldset>
                    <legend>残疾情况</legend>

               </fieldset>
            </fieldset>
            <fieldset>
               <legend class="big_title">家族史</legend>

            </fieldset>
            <fieldset>
               <legend class="big_title">生活环境</legend>

            </fieldset>
            <fieldset>
               <legend class="big_title">备注</legend>
               <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                    <tr runat="server">
                        <td class="table_body">
                            备注</td>
                        <td class="table_none">
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                            <textarea id="TextBox1" runat="server" title="请填备注" class="text_input" style="height:100px; width:100%;"></textarea>
                        </td>
                    </tr>
               </table>
            </fieldset>
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
                    document.all.<%=this.U_Committee.ClientID %>.value=ShValues[1];
                    document.all.<%=this.U_Committee_input.ClientID %>.value=ShValues[0];
                }else if(type == 2){ //选择责任医生
                    onButtonEdit(ShValues[1]);
                }else if(type == 3){ //选择建档单位
                    document.all.<%=this.U_FilingUnits.ClientID %>.value=ShValues[1];
                    document.all.<%=this.U_FilingUnits_input.ClientID %>.value=ShValues[0];
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
   	        document.all.<%=this.U_Committee_input.ClientID %>.value="";
            document.all.<%=this.U_Committee.ClientID %>.value="";
        }else if(t == 2){
            document.all.<%=this.U_ResponsibilityUserID.ClientID %>.value="";
            document.all.<%=this.U_ResponsibilityUserID_input.ClientID %>.value="";
        }else if(t == 3){
            document.all.<%=this.U_FilingUnits.ClientID %>.value="";
            document.all.<%=this.U_FilingUnits_input.ClientID %>.value="";
        }else if(t == 4){
            document.all.<%=this.U_FilingUserID.ClientID %>.value="";
            document.all.<%=this.U_FilingUserID_input.ClientID %>.value="";
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
                        document.all.<%=this.U_FilingUserID.ClientID %>.value=result[1];
                        document.all.<%=this.U_FilingUserID_input.ClientID %>.value=result[2];
                    }
                }
            }
        });            
    }

    </script>
</asp:Content>
