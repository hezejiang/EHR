<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectUser.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.CommonModule.SelectUser" %>

<html >
<head id="Head1">
    <title>选择用户</title>
<base target="_self"></base>
<link rel="stylesheet" href="<%=Page.ResolveClientUrl("~/")%>Manager/css/site_css.css" type="text/css">
<link rel="stylesheet" href='<%=Page.ResolveClientUrl("~/")%>Manager/css/table/<%=TableSink%>/Css.css' type="text/css">
<style type="text/css">
    .mini-toolbar
    {
        border:solid 1px #909aa6;
        padding:3px;   
        _padding-bottom:4px;
        background:#E7EAEE;
    }
    .mini-button
    {
        padding:0;
        border:1px solid #A9ACB5;
        background:#EBEDF2 url(images/button/button.png) repeat-x 0 0;
    
        font-size:9pt;
        font-family:Tahoma,Verdana,宋体;
    
        line-height:22px;
    
        text-decoration:none;
        text-align: center;
        display:inline-block;
        zoom:1;    
        cursor:pointer;
        -khtml-user-select: none;
        -moz-user-select:none;
        vertical-align:middle;          
        outline:none;
    }
    .mini-button, a.mini-button
    {
        color:#201F35;
    }
    body a:hover.mini-button
    {    
        padding:0;
        border:1px solid #A9ACB5;
        background:#dde6fe;      
        text-decoration:none;
    }
    .mini-button-text
    {   
        line-height:16px; 
	    padding:2px 8px 3px 8px;
	
        line-height:17px\9;
        vertical-align:top;
        display:inline-block;    
        padding:3px 8px 2px 8px\9;    
        +padding:3px 8px 2px 8px;  
        _padding:2px 8px 2px 8px;  
    }
    .mini-button .mini-button-icon
    {
        padding-left:25px;
        background-position: 6px 50%;        
        background-repeat:no-repeat;    
    }
    .mini-button .mini-button-iconOnly
    {
        padding-left:14px;    
        background-repeat:no-repeat;    
        background-position:50% 50%;
    }

</style>

</head>

<body>
    <form id="form1" runat="server">
    <div class="mini-toolbar" style="text-align:center;line-height:30px;" borderStyle="border:0;">
          <label >身份证号：</label>
          <input id="U_IDCard_key" class="mini-textbox" runat="server" style="width:150px;"/>
           <label >姓名：</label>
          <input id="U_CName_key" class="mini-textbox" runat="server" style="width:150px;"/>
           <label >手机号码：</label>
          <input id="U_MobileNo_key" class="mini-textbox" runat="server" style="width:150px;"/>
          <asp:Button CssClass="mini-button" ID="search" runat="server" Text="查询" 
              style="width:60px;" onclick="search_Click"/>
    </div>
    <asp:GridView ID="GridView1" runat="server" OnSorting="GridView1_Sorting" 
        OnRowCreated="GridView1_RowCreated">
        <Columns>
            <asp:TemplateField HeaderText="选择">
                        <ItemTemplate>
                            <input type="radio" class="selectIetm" name="selectIetm" UserID='<%#Eval("UserID") %>' U_CName='<%#Eval("U_CName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
            <asp:BoundField SortExpression="U_IDCard" HeaderText="身份证号" DataField="U_IDCard"/>
            <asp:BoundField SortExpression="U_CName" HeaderText="姓名" DataField="U_CName"/>
            <asp:BoundField SortExpression="U_MobileNo" HeaderText="手机号码" DataField="U_MobileNo"/>
        </Columns>
    </asp:GridView>
    <FrameWorkWebControls:AspNetPager ID="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged">
            </FrameWorkWebControls:AspNetPager>

    <div class="mini-toolbar" style="text-align:center;padding-top:8px;padding-bottom:8px;" borderStyle="border:0;">
        <a class="mini-button" style="width:60px;" onclick="onOk()">确定</a>
        <span style="display:inline-block;width:25px;"></span>
        <a class="mini-button" style="width:60px;" onclick="onCancel()">取消</a>
    </div>
    </form>
</body>
</html>
<script src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.9.1.min.js" type="text/javascript"></script>
<script type="text/javascript">
    //////////////////////////////////
    function CloseWindow(action) {
        if (window.CloseOwnerWindow) {
            var UserID = $(".selectIetm:checked").attr("UserID");
            var U_CName = $(".selectIetm:checked").attr("U_CName");
            return window.CloseOwnerWindow(action + "||" + UserID + "||" + U_CName);
        }
        else
            window.close();
    }

    function onOk() {
        CloseWindow("ok");
    }
    function onCancel() {
        CloseWindow("cancel");
    }
</script>