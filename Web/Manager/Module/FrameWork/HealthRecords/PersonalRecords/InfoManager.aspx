<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="InfoManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.PersonalRecords.InfoManager" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" /> 
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/base.css" />
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/jPaginate.css" />
    <style type="text/css">
        legend.big_title{ font-style:oblique;  font-size:18px; font-weight:bold;}
        legend.small_title{ font-style:italic; font-size:16px;}
        
        .w10{width:10%; text-align:center;}
        .w90{width:90%; text-align:center;}
        .w50{width:50%;}
        .w25{width:25%;}
        .border_right{ border-right:1px solid #ccc;}
        .border-bottom{ border-bottom:1px solid #ccc; }
        .mr5{margin:5px;}
        .ul50{width:50%; float:left;}
        .ul50 li{float:left;line-height: 30px;text-align: left; width:45%;}
        .float_left{float:left;}
        .ul100{width:100%; float:left;}
        .ul100 li{float:left;line-height: 30px;text-align: left; width:25%;}
        
        .add{width:100%;}
        .list{width:60%; overflow:hidden; border:1px solid #ccc;}
        .list .list_head{width:100%; height:25px;}
        .list .list_head li{float:left; width:15%; height:20px; line-height:20px; text-align:center;  font-weight:bold;}
        .list .list_body{width:100%;}
        .list .list_body ul{width:100%; height:20px;}
        .list .list_body ul:hover{background-color:#CADEE8;}
        .list .list_body ul li{float:left; width:15%;  height:20px; line-height:20px; text-align:center; }
        .list .list_body ul li a{color:Blue;}
        
        .extend_submit{width:100%; text-align:right; margin-top:2px;}
    </style>

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
                        <asp:TextBox ID="U_IDCard" runat="server" Columns="50" title="请填写个人身份证号" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_CName" runat="server" Columns="50" title="请填真实姓名" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr id="Tr1" runat="server">
                    <td class="table_body">
                        籍贯</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_Hometown" runat="server" Columns="50" title="请填籍贯" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        现住址</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_CurrentAddress" runat="server" Columns="50" title="请填现住址" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr runat="server">
                    <td class="table_body">
                        性别</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="U_Sex" title="请选择性别">
                            <asp:ListItem Text="女" Value="0" />
                            <asp:ListItem Text="男" Value="1" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        民族</td>
                    <td class="table_none table_none_NoWidth">
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
                        <asp:TextBox ID="U_MobileNo" runat="server" Columns="50" title="请填写联系方式" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        居(村)委会</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="U_Committee" id="U_Committee" value=""/>
                        <input runat="server" name="U_Committee_input" id="U_Committee_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(1,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(1);" class="cbutton" />
                    </td>
                </tr>
                <tr id="Tr4" runat="server">
                    <td class="table_body">
                        常住类型</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:DropDownList runat="server" ID="U_PermanentType" title="请选择常住类型">
                            <asp:ListItem Text="户籍" Value="1" />
                            <asp:ListItem Text="非户籍" Value="2" />
                        </asp:DropDownList>
                    </td>
                    <td class="table_body">
                        文化程度</td>
                    <td class="table_none table_none_NoWidth">
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
                        <asp:TextBox ID="U_WorkingUnits" runat="server" Columns="50" title="请输入工作单位" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        职位联系人姓名</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_WorkingContactName" runat="server" Columns="50" title="请输入职位联系人姓名"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        职位联系人号码</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_WorkingContactTel" runat="server" Columns="50" title="请输入职位联系人号码"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        付费类型</td>
                    <td class="table_none table_none_NoWidth">
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
                        <asp:TextBox ID="U_SocialNO" runat="server" Columns="50" title="请输入社保号"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        医保号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="U_MedicalNO" runat="server" Columns="50" title="请输入医保号"
                            CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        家庭编号</td>
                    <td class="table_none table_none_NoWidth">
                        <input runat="server" id="U_FamilyCode" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(2)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect();" class="cbutton" />
                    </td>
                    <td class="table_body">
                        与户主关系</td>
                    <td class="table_none table_none_NoWidth">
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
                        <input type="hidden" runat="server" name="U_ResponsibilityUserID" id="U_ResponsibilityUserID" value=""/>
                        <input runat="server" name="U_ResponsibilityUserID_input" id="U_ResponsibilityUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(2,1)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(2);" class="cbutton" />
                    </td>
                    <td class="table_body">
                        档案状态</td>
                    <td class="table_none table_none_NoWidth">
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
                        <input type="hidden" runat="server" name="U_FilingUnits" id="U_FilingUnits" value=""/>
                        <input runat="server" name="U_FilingUnits_input" id="U_FilingUnits_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(3,0)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(3);" class="cbutton" />
                    </td>
                    <td class="table_body">
                        建档人</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="U_FilingUserID" id="U_FilingUserID" value=""/>
                        <input runat="server" name="U_FilingUserID_input" id="U_FilingUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(4,0)"
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
                    <legend  class="small_title">疾病史</legend>
                    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center" class="table_check_wrap">
                        <tr>
                            <td class="w10 border_right"><input type="checkbox" id="DH_Type_0" runat="server" value="0" class="no" />无</td>
                            <td class="w90">
                                <input type="hidden" id="DiseaseHistory_data" runat="server" class="data DiseaseHistory_data"/>
                                <div style="width:100%;">
                                    <asp:Repeater runat="server" ID="DiseaseHistory_repeater">
                                        <ItemTemplate>
                                            <ul class="ul50">
                                                <li>
                                                    <input type="checkbox" id=DH_Type_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="yes mr5" value=<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> /><%#((Maticsoft.Model.commonDiseases)Container.DataItem).CD_Name%>
                                                </li>
                                                <li class=" w25">
                                                     确诊时间 <input id=DH_DiagnosisDate_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="text_input" onfocus="javascript:HS_setDate(this);"/>
                                                </li>
                                            </ul>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                        <ul class="ul50">
                                                <li>
                                                    <input type="checkbox" id="DH_Type_11" runat="server" class="mr5 yes" value="11" />其他
                                                    <input id="DH_Type_11_note" runat="server" class="other" style="border-color: #DDDDDD;border-width: 1px;color: #000000;height: 22px;padding: 3px 2px 2px;"/>
                                                </li>
                                                <li class=" w25">
                                                     确诊时间 <input id="DH_DiagnosisDate_11" runat="server" class="text_input" onfocus="javascript:HS_setDate(this);"/>
                                                </li>
                                            </ul>
                                </div>
                            </td>
                        </tr>
                    </table>
               </fieldset>
               <fieldset>
                    <legend class="small_title">手术史</legend>
                    <div style="width:100%" DO_Type="1" id="DO_Type_list1">
                        <div class="add">
                                手术名称<input runat="server" class="text_input DO_Name" style=" margin-left:2px; margin-right:10px;"/>
                               日期<input  runat="server" class="text_input DO_Date" style=" margin-left:2px; margin-right:10px;" onfocus="javascript:HS_setDate(this);"/>
                               <input type="button" class="addBtn" value="增加" />
                         </div>
                         <div class="list">
                            <ul class="list_head">
                                <li>编号</li>
                                <li style="width:50%;">手术名称</li>
                                <li>日期</li>
                                <li>操作</li>
                            </ul>
                            <div class="list_body">
                                
                            </div>
                         </div>
                         <div id="page1" style="width:60%;"></div>
                    </div>
               </fieldset>
               <fieldset>
                    <legend class="small_title">外伤史</legend>
                    <div style="width:100%" DO_Type="2" id="DO_Type_list2">
                        <div class="add">
                                外伤名称<input runat="server" class="text_input DO_Name" style=" margin-left:2px; margin-right:10px;"/>
                               日期<input runat="server" class="text_input DO_Date" style=" margin-left:2px; margin-right:10px;" onfocus="javascript:HS_setDate(this);"/>
                               <input type="button" class="addBtn" value="增加" />
                         </div>
                         <div class="list">
                            <ul class="list_head">
                                <li>编号</li>
                                <li style="width:50%;">外伤名称</li>
                                <li>日期</li>
                                <li>操作</li>
                            </ul>
                            <div class="list_body">
                                
                            </div>
                         </div>
                         <div id="page2" style="width:60%;"></div>
                    </div>
               </fieldset>
               <fieldset>
                    <legend class="small_title">输血史</legend>
                    <div style="width:100%" DO_Type="3" id="DO_Type_list3">
                        <div class="add">
                                输血名称<input runat="server" class="text_input DO_Name" style=" margin-left:2px; margin-right:10px;"/>
                               日期<input runat="server" class="text_input DO_Date" style=" margin-left:2px; margin-right:10px;" onfocus="javascript:HS_setDate(this);"/>
                               <input type="button" class="addBtn" value="增加" />
                         </div>
                         <div class="list">
                            <ul class="list_head">
                                <li>编号</li>
                                <li style="width:50%;">输血名称</li>
                                <li>日期</li>
                                <li>操作</li>
                            </ul>
                            <div class="list_body">
                                
                            </div>
                         </div>
                         <div id="page3" style="width:60%;"></div>
                    </div>
               </fieldset>
               <fieldset class="small_title">
                    <legend>遗传病史</legend>
                    <table width="100%" border="0" cellspacing="1" cellpadding="3" align="left" class="gendisease">
                        <tr>
                            <td class="w10 border_right"><input type="checkbox" id="GeneticDisease_none" runat="server" value="0" class="no" />无</td>
                            <td class="w90" style=" text-align:left;">
                                <input type="checkbox" id="GeneticDisease_check" runat="server" class="mr5 yes" />有&nbsp;&nbsp;&nbsp;&nbsp;
                                疾病名称: <input id="GD_Name" runat="server" class="text_input" />
                            </td>
                        </tr>
                    </table>
               </fieldset>
               <fieldset>
                    <legend class="small_title">残疾情况</legend>
                   <asp:CheckBoxList runat="server" ID="DisabilityList" RepeatDirection="Horizontal" CellPadding="10" CssClass="table_check_wrap float_left">
                       <asp:ListItem Text="无残疾" Value="0" />
                       <asp:ListItem Text="视力残疾" Value="1" />
                       <asp:ListItem Text="听力残疾" Value="2" />
                       <asp:ListItem Text="言语残疾" Value="3" />
                       <asp:ListItem Text="体残疾" Value="4" />
                       <asp:ListItem Text="智力残疾" Value="5" />
                       <asp:ListItem Text="精神残疾" Value="6" />
                       <asp:ListItem Text="其他" Value="7" />
                   </asp:CheckBoxList>
                   <input id="D_Note" runat="server" class="text_input" style="float:left; margin-top:5px;"/>
               </fieldset>
            </fieldset>
            <fieldset>
               <legend class="big_title">家族史</legend>
               <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                        <tr class="border-bottom family">
                            <td class="w10 border_right">父亲</td>
                            <td class="w90">
                                <input type="hidden" id="fatherDisease_data" runat="server"  class="data fatherDisease_data" />
                                <div style="width:100%;">
                                    <ul class="ul100">
                                    <asp:Repeater runat="server" ID="fatherDisease_repeater">
                                        <ItemTemplate>
                                                <li>
                                                    <input type="checkbox" id=father_FH_Type_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="yes mr5" value=<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> /><%#((Maticsoft.Model.commonDiseases)Container.DataItem).CD_Name%>
                                                </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                        <li>
                                            <input type="checkbox" id="father_FH_Type11" runat="server" class="mr5 yes other" value=11 />其他
                                            <input id="father_note" runat="server" class="text_input"/>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr  class="border-bottom family">
                            <td class="w10 border_right">母亲</td>
                            <td class="w90">
                                <input type="hidden" id="matherDisease_data" runat="server" class="data matherDisease_data" />
                                <div style="width:100%;">
                                    <ul class="ul100">
                                    <asp:Repeater runat="server" ID="matherDisease_repeater">
                                        <ItemTemplate>
                                                <li>
                                                    <input type="checkbox" id=mather_FH_Type_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="yes mr5" value=<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> /><%#((Maticsoft.Model.commonDiseases)Container.DataItem).CD_Name%>
                                                </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                        <li>
                                            <input type="checkbox" id="mather_FH_Type11" runat="server" class="mr5  yes other" value=11 />其他
                                            <input id="mather_note" runat="server" class="text_input"/>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr  class="border-bottom family">
                            <td class="w10 border_right">兄弟姐妹</td>
                            <td class="w90">
                                <input type="hidden" id="brothersDisease_data" runat="server"  class="data brothersDisease_data"/>
                                <div style="width:100%;">
                                    <ul class="ul100">
                                    <asp:Repeater runat="server" ID="brothersDisease_repeater">
                                        <ItemTemplate>
                                                <li>
                                                    <input type="checkbox" id=brothers_FH_Type_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="yes mr5" value=<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> /><%#((Maticsoft.Model.commonDiseases)Container.DataItem).CD_Name%>
                                                </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                        <li>
                                            <input type="checkbox" id=brothers_FH_Type11 runat="server" class="mr5 yes other" value=11 />其他
                                            <input id="brothers_note" runat="server" class="text_input"/>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                        <tr class="border-bottom family">
                            <td class="w10 border_right">子女</td>
                            <td class="w90">
                                <input type="hidden" id="childrenDisease_data" runat="server" class="data childrenDisease_data" />
                                <div style="width:100%;">
                                    <ul class="ul100">
                                    <asp:Repeater runat="server" ID="childrenDisease_repeater">
                                        <ItemTemplate>
                                                <li>
                                                    <input type="checkbox" id=children_FH_Type_<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> runat="server" class="yes mr5" value=<%#((Maticsoft.Model.commonDiseases)Container.DataItem).CommonDiseaseID%> /><%#((Maticsoft.Model.commonDiseases)Container.DataItem).CD_Name%>
                                                </li>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                        <li>
                                            <input type="checkbox" id="children_FH_Type11" runat="server" class="mr5 yes other" value=11 />其他
                                            <input id="children_note" runat="server" class="text_input"/>
                                        </li>
                                    </ul>
                                </div>
                            </td>
                        </tr>
                    </table>
            </fieldset>
            <fieldset>
               <legend class="big_title">生活环境</legend>
               <table width="100%" border="0" cellspacing="1" cellpadding="3" align="left">
                    <tr>
                        <td class="w10 border_right">厨房排风设施</td>
                            <td class="w90">
                                <asp:CheckBoxList ID="E_Kind1" runat="server" RepeatDirection="Horizontal" CellPadding="10">
                                   <asp:ListItem Text="无" Value="1" />
                                   <asp:ListItem Text="油烟机" Value="2" />
                                   <asp:ListItem Text="换气扇" Value="3" />
                                   <asp:ListItem Text="烟囱" Value="4" />
                               </asp:CheckBoxList>
                            </td>
                    </tr>
                    <tr>
                        <td class="w10 border_right">燃料类型</td>
                            <td class="w90">
                                <asp:CheckBoxList ID="E_Kind2" runat="server" RepeatDirection="Horizontal" CellPadding="10">
                                   <asp:ListItem Text="液化气" Value="1" />
                                   <asp:ListItem Text="煤气" Value="2" />
                                   <asp:ListItem Text="天然气" Value="3" />
                                   <asp:ListItem Text="沼气" Value="4" />
                                   <asp:ListItem Text="柴火" Value="5" />
                                   <asp:ListItem Text="其他" Value="6" />
                               </asp:CheckBoxList>
                            </td>
                    </tr>
                    <tr>
                        <td class="w10 border_right">饮水</td>
                            <td class="w90">
                                <asp:CheckBoxList ID="E_Kind3" runat="server" RepeatDirection="Horizontal" CellPadding="10">
                                   <asp:ListItem Text="自来水" Value="1" />
                                   <asp:ListItem Text="经净化过滤的水" Value="2" />
                                   <asp:ListItem Text="井水" Value="3" />
                                   <asp:ListItem Text="河湖水" Value="4" />
                                   <asp:ListItem Text="糖水" Value="5" />
                                   <asp:ListItem Text="其他" Value="6" />
                               </asp:CheckBoxList>
                            </td>
                    </tr>
                    <tr>
                        <td class="w10 border_right">厕所</td>
                            <td class="w90">
                                <asp:CheckBoxList ID="E_Kind4" runat="server" RepeatDirection="Horizontal" CellPadding="10">
                                   <asp:ListItem Text="卫生厕所" Value="1" />
                                   <asp:ListItem Text="一格或两格粪池式" Value="2" />
                                   <asp:ListItem Text="马桶" Value="3" />
                                   <asp:ListItem Text="露天粪坑" Value="4" />
                                   <asp:ListItem Text="简易棚厕" Value="5" />
                               </asp:CheckBoxList>
                            </td>
                    </tr>
                    <tr>
                        <td class="w10 border_right">禽畜栏</td>
                            <td class="w90">
                                <asp:CheckBoxList ID="E_Kind5" runat="server" RepeatDirection="Horizontal" CellPadding="10">
                                   <asp:ListItem Text="单设" Value="1" />
                                   <asp:ListItem Text="室内" Value="2" />
                                   <asp:ListItem Text="室外" Value="3" />
                               </asp:CheckBoxList>
                            </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset>
               <legend class="big_title">备注</legend>
               <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                    <tr>
                        <td  class="w10 border_right">备注</td>
                        <td  class="w90">
                            <textarea id="U_Note" runat="server" title="请填备注" class="text_input" style="height:100px; width:100%;"></textarea>
                        </td>
                    </tr>
               </table>
            </fieldset>
            <div class="extend_submit">
                    <asp:Button ID="extendBtn" runat="server" CssClass="button_bak" Text="确定" 
                        onclick="extendBtn_Click"/>
                    <input id="extendReset" class="button_bak" type="reset" value="重填" />&nbsp;
            </div>
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>
    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/date/dateFormat.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery.paginate.js"></script>
    <script type="text/javascript">
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

        function ShowDepartID(t, G_type)
        {
            type = t;
            showPopWin('选择部门','../../CommonModule/SelectGroup.aspx?'+rand(10000000)+"&G_type="+G_type, 215, 255, AlertMessageBox,true,true);
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

        function checkForm(obj){
            var returnVal = true;
            var data = "[";
            $(".table_check_wrap .yes").each(function(index){
                    if($(this).is(":checked")){
                        var ul50 = $(this).parents(".ul50");
                        var date_val = $(ul50).find(".text_input").val();
                        if(!date_val){
                            alert("疾病史有疾病未填写确诊日期");
                            if(returnVal)
                                returnVal = false;
                            return false;
                        }
                        date_val = date_val.replace(/\b(\w)\b/g, '0$1');
                        var dateObj = new Date(date_val.toString());
                        data = data + "{'type':" + $(this).val() +",'date':" + dateObj.getTime() + "},";
                    }
                });
                if(data.indexOf(",") > -1)
                    data = data.substr(0,data.length - 1);
                data = data + "]";
                $(".table_check_wrap").find(".data").val(data);
                $(".other").each(function(){
                    if($(this).is(":checked")){
                        if(!$(this).siblings(".text_input").val()){
                            alert("家族史选择了其他，但是没填写疾病名称");
                            if(returnVal)
                                returnVal = false;
                         }
                    }
                });
                return returnVal;
        }

        $(function(){
        $(".table_check_wrap .no").click(function(){
            $(this).parents(".table_check_wrap").find(".yes").attr("checked",false);
            $(this).parents(".table_check_wrap").find(".text_input").val("");
        });

        $(".table_check_wrap .yes").click(function(){
            $(this).parents(".table_check_wrap").find(".no").attr("checked",false);
        });

        $(".gendisease .no").click(function(){
            $(this).parents(".gendisease").find(".yes").attr("checked",false);
            $(this).parents(".gendisease").find(".text_input").val("");
        });

        $(".gendisease .yes").click(function(){
            $(this).parents(".gendisease").find(".no").attr("checked",false);
        });

       $(".table_check_wrap .yes").click(function(){
            /*var parent_w90 = $(this).parents(".w90");
            var data = "[";
            $(parent_w90).find(".yes").each(function(index){
                if($(this).is(":checked")){
                    var ul50 = $(this).parents(".ul50");
                    var date_val = $(ul50).find(".text_input").val();
                    date_val = date_val.replace(/\b(\w)\b/g, '0$1');
                    var dateObj = new Date(date_val.toString());
                    data = data + "{'type':" + $(this).val() +",'date':" + dateObj.getTime() + "},";
                }
            });
            if(data.indexOf(",") > -1)
                data = data.substr(0,data.length - 1);
            data = data + "]";
            $(parent_w90).find(".data").val(data);*/
            if(!$(this).is(":checked")){
                var ul50 = $(this).parents(".ul50");
                $(ul50).find(".text_input").val("");
            }
        });

        $(".family .yes").click(function(){
            var parent_w90 = $(this).parents(".w90");
            var data = "[";
            $(parent_w90).find(".yes").each(function(){
                if($(this).is(":checked")){
                    data = data + "{'type':" + $(this).val() +"},";
                }
            });
            if(data.indexOf(",") > -1)
                data = data.substr(0,data.length - 1);
            data = data + "]";
            $(parent_w90).find(".data").val(data);
        });

        $(".other").click(function(){
                if(!$(this).is(":checked")){
                    $(this).siblings(".text_input").val("");
                }
            });

        //疾病史
        var DiseaseHistory_data = $(".DiseaseHistory_data").val();
        var DiseaseHistory_data_jsonobject = eval("("+DiseaseHistory_data+")"); //转换为json对象
        $(DiseaseHistory_data_jsonobject).each(function( index ){
            var data = DiseaseHistory_data_jsonobject[index];
            $("#DH_Type_"+data.type).attr("checked",true);
            $("#DH_DiagnosisDate_"+data.type).val(toDate(data.date));
        });
        
        //家族史
        //父亲
        var fatherDisease_data = $(".fatherDisease_data").val();
        var fatherDisease_data_jsonobject = eval("("+fatherDisease_data+")"); //转换为json对象
        $(fatherDisease_data_jsonobject).each(function( index ){
            var data = fatherDisease_data_jsonobject[index];
            $("#father_FH_Type_"+data.type).attr("checked",true);
        });

         //母亲
        var matherDisease_data = $(".matherDisease_data").val();
        var matherDisease_data_jsonobject = eval("("+matherDisease_data+")"); //转换为json对象
        $(matherDisease_data_jsonobject).each(function( index ){
            var data = matherDisease_data_jsonobject[index];
            $("#mather_FH_Type_"+data.type).attr("checked",true);
        });

         //兄弟姐妹
        var brothersDisease_data = $(".brothersDisease_data").val();
        var brothersDisease_data_jsonobject = eval("("+brothersDisease_data+")"); //转换为json对象
        $(brothersDisease_data_jsonobject).each(function( index ){
            var data = brothersDisease_data_jsonobject[index];
            $("#brothers_FH_Type_"+data.type).attr("checked",true);
        });

         //子女
        var childrenDisease_data = $(".childrenDisease_data").val();
        var childrenDisease_data_jsonobject = eval("("+childrenDisease_data+")"); //转换为json对象
        $(childrenDisease_data_jsonobject).each(function( index ){
            var data = childrenDisease_data_jsonobject[index];
            $("#children_FH_Type_"+data.type).attr("checked",true);
        });

        //手术史
        jQuery.ajax({
            type: 'POST',
            url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
            data: {Op:'paging', Page: 1, DO_Type: 1, DO_UserID: <%=UserID %>},
            success: function (data) {
                if (data) {
                     $("#DO_Type_list1 .list_body").html(data);
                     var pagecount = parseInt($("#DO_Type_list1 .list_body").find(".page1_info").attr("page-count"));
                     if(pagecount > 1)
                     {
                            $("#page1").paginate({
                            count: pagecount,
                            start: 1,
                            display: 8,
                            border_color: '#BEF8B8',
                            text_color: '#68BA64',
                            background_color: '#E3F2E1',
                            border_hover_color: '#68BA64',
                            text_hover_color: 'black',
                            background_hover_color: '#CAE6C6',
                            rotate: false,
                            images: false,
                            mouse: 'press',
                            onChange: function (page) {
                                jQuery.ajax({
                                    type: 'POST',
                                    url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
                                    data: {Op:'paging', Page: page, DO_Type: 1, DO_UserID: <%=UserID %>},
                                    success: function (data) {
                                        if (data) {
                                              $("#DO_Type_list1 .list_body").html(data);
                                        }
                                    },
                                    dataType: 'html'
                                });
                            }
                        });
                    }
                }
            },
            dataType: 'html'
        });

        //外伤史
        jQuery.ajax({
            type: 'POST',
            url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
            data: {Op:'paging', Page: 1, DO_Type: 2, DO_UserID: <%=UserID %>},
            success: function (data) {
                if (data) {
                     $("#DO_Type_list2 .list_body").html(data);
                     var pagecount = parseInt($("#DO_Type_list2 .list_body").find(".page_info").attr("page-count"));
                     if(pagecount > 1)
                     {
                            $("#page2").paginate({
                            count: pagecount,
                            start: 1,
                            display: 8,
                            border_color: '#BEF8B8',
                            text_color: '#68BA64',
                            background_color: '#E3F2E1',
                            border_hover_color: '#68BA64',
                            text_hover_color: 'black',
                            background_hover_color: '#CAE6C6',
                            rotate: false,
                            images: false,
                            mouse: 'press',
                            onChange: function (page) {
                                jQuery.ajax({
                                    type: 'POST',
                                    url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
                                    data: {Op:'paging', Page: page, DO_Type: 2, DO_UserID: <%=UserID %>},
                                    success: function (data) {
                                        if (data) {
                                              $("#DO_Type_list2 .list_body").html(data);
                                        }
                                    },
                                    dataType: 'html'
                                });
                            }
                        });
                    }
                }
            },
            dataType: 'html'
        });

        //输血史
        jQuery.ajax({
            type: 'POST',
            url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
            data: {Op:'paging', Page: 1, DO_Type: 3, DO_UserID: <%=UserID %>},
            success: function (data) {
                if (data) {
                     $("#DO_Type_list3 .list_body").html(data);
                     var pagecount = parseInt($("#DO_Type_list3 .list_body").find(".page1_info").attr("page-count"));
                     if(pagecount > 1)
                     {
                            $("#page3").paginate({
                            count: pagecount,
                            start: 1,
                            display: 8,
                            border_color: '#BEF8B8',
                            text_color: '#68BA64',
                            background_color: '#E3F2E1',
                            border_hover_color: '#68BA64',
                            text_hover_color: 'black',
                            background_hover_color: '#CAE6C6',
                            rotate: false,
                            images: false,
                            mouse: 'press',
                            onChange: function (page) {
                                jQuery.ajax({
                                    type: 'POST',
                                    url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
                                    data: {Op:'paging', Page: page, DO_Type: 3, DO_UserID: <%=UserID %>},
                                    success: function (data) {
                                        if (data) {
                                              $("#DO_Type_list3 .list_body").html(data);
                                        }
                                    },
                                    dataType: 'html'
                                });
                            }
                        });
                    }
                }
            },
            dataType: 'html'
        });

        $('.addBtn').live('click',function () {
            var _this=this;
            var DO_Type = $(_this).parents(".add").parent().attr("DO_Type");
            var DO_Date = $(_this).siblings(".DO_Date").val();
            DO_Date = DO_Date.replace(/\b(\w)\b/g, '0$1');
            var dateObj = new Date(DO_Date.toString());
            var DO_Name = $(_this).siblings(".DO_Name").val();
            var DO_UserID = <%=UserID %>;
            jQuery.ajax({
                type: 'POST',
                url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
                data: {Op:'add',DO_Type:DO_Type , DO_Date:dateObj.getTime(), DO_Name:DO_Name, DO_UserID:DO_UserID},
                success: function (data) {
                    if (data) {
                        $(_this).parents(".add").find(".text_input").val("");
                        $(_this).parents(".add").siblings(".list").find(".list_body").html(data);
                    }
                }
            });
        });

        $('.delete').live('click',function () {
            var _this=this;
            var diseaseOtherID = $(this).parent().siblings('.first').html();
            var result = confirm("确定删除？");
            if (result) {
                jQuery.ajax({
                    type: 'POST',
                    url: '<%=Page.ResolveUrl("~/") %>Manager/Ajax/DiseaseOther.ashx',
                    data: {Op:'delete',DiseaseOtherID:diseaseOtherID},
                    success: function (data) {
                        if (data) {
                            var jsonData = eval("(" + data + ")"); //转换为json对象
                            if(jsonData['success']){
                                $(_this).parent().parent().remove();
                            }
                            else
                                alert(jsonData['fail']);
                        }
                    }
                });
            }
        });
    });
    </script>
</asp:Content>

