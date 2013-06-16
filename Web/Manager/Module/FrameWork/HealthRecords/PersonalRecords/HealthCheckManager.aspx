<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="HealthCheckManager.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords.HealthCheckManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />

    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/boot.js" type="text/javascript"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <!--通用头部 start-->
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server"
        HeadOPTxt="体检记录" HeadTitleTxt="体检记录管理">
    </FrameWorkWebControls:HeadMenuWebControls>
    <!--通用头部 end-->
    <!--Tab选项控件 start-->
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <!--Tab选项控件的第一个子选项 start-->
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="信息登记">
            <table width="100%" border="0" cellspacing="1" cellpadding="3" align="center">
                <tr>
                    <td class="table_body">
                        健康档案号</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:Label ID="H_UserID_Txt" runat="server"></asp:Label>
                    </td>
                    <td class="table_body">
                        体温</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_BodyTemperature" runat="server" Columns="50" title="请填体温！" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        呼吸频率（次/min）</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_RespiratoryRate" runat="server" Columns="50" title="请填呼吸频率（次/min）" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        脉率（次/min）</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_PulseRate" runat="server" Columns="50" title="请填脉率（次/min）" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        左侧舒张压(mmHg)</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_LeftDiastolic" runat="server" Columns="50" title="请填左侧舒张压(mmHg)" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        左侧收缩压(mmHg)</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_LeftSystolic" runat="server" Columns="50" title="请填左侧收缩压(mmHg)" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        右侧舒张压(mmHg)</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_RightDiastolic" runat="server" Columns="50" title="请填右侧舒张压(mmHg)" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                       右侧收缩压(mmHg)</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_RightSystolic" runat="server" Columns="50" title="请填右侧收缩压(mmHg)" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                       体重（kg）</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_Weight" runat="server" Columns="50" title="请填体重（kg）" CssClass="text_input"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        身高（cm）</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_Height" runat="server" Columns="50" title="请填身高（cm）" CssClass="text_input"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        体检结果</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_Result" runat="server" Columns="50" title="请输入体检结果!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px;"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        体检建议</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_Suggestion" runat="server" Columns="50" title="请输入体检建议!"
                            CssClass="text_input" TextMode="MultiLine" style="height:100px;"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        体检日期</td>
                    <td class="table_none table_none_NoWidth">
                        <asp:TextBox ID="H_CheckTime" runat="server" Columns="50" title="请选择体检日期!" CssClass="text_input" onfocus="javascript:HS_setDate(this);"></asp:TextBox>
                    </td>
                    <td class="table_body">
                        体检医生</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="H_CheckUserID" id="H_CheckUserID" value=""/>
                        <input runat="server" name="H_CheckUserID_input" id="H_CheckUserID_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(4)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(4);" class="cbutton" />
                    </td>
                </tr>
                <tr>
                    <td class="table_body">
                        体检机构</td>
                    <td class="table_none table_none_NoWidth">
                        <input type="hidden" runat="server" name="H_MedicalInstitutions" id="H_MedicalInstitutions" value=""/>
                        <input runat="server" name="H_MedicalInstitutions_input" id="H_MedicalInstitutions_input" size="15" value="" class="text_input" readonly/>
                        <input type="button" value="选择" name="buttonselect" onclick="javascript:ShowDepartID(3)"
                            class="cbutton"/>
                        <input type="button" value="清除" onclick="javascript:ClearSelect(3);" class="cbutton" />
                    </td>
                    <td colspan="2" align="right">
                        <asp:Button ID="Button2" runat="server" CssClass="button_bak" Text="确定" OnClick="Button1_Click" />
                        <input id="Reset2" class="button_bak" type="reset" value="重填" />&nbsp;
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
</asp:Content>

