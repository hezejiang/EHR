<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.StatisticalAnalysis.SexStatistical._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/statistical.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="性别统计" HeadTitleTxt="性别统计">
    </FrameWorkWebControls:HeadMenuWebControls>
    <FrameWorkWebControls:TabOptionWebControls ID="TabOptionWebControls1" runat="server">
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem1" runat="server" Tab_Name="统计图">
            <div id="container" style="min-width: 400px; height: 400px; margin: 0 auto"></div>
        </FrameWorkWebControls:TabOptionItem>
        <FrameWorkWebControls:TabOptionItem ID="TabOptionItem2" runat="server" Tab_Name="统计表">
            <div class="wrap">
                <h2><%=title %>表</h2>
                <table border="0" cellpadding="0" cellspacing="1" style="width:100%; background-color: White;">
                    <tr class="head">
                        <th>性别</th>
                        <th>人数</th>
                        <th>百分比</th>
                    </tr>
                    <%=table_data%>
                </table>
            </div>
        </FrameWorkWebControls:TabOptionItem>
    </FrameWorkWebControls:TabOptionWebControls>
    
    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/highcharts/highcharts.js" type="text/javascript"></script>
    <script src="<%=Page.ResolveUrl("~/") %>Manager/js/highcharts/modules/exporting.src.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $('#container').highcharts({
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: null,
                    plotShadow: false
                },
                title: {
                    text: '<%=title %>图'
                },
                tooltip: {
                    pointFormat: '{series.name}: <b>{point.percentage}%</b>',
                    percentageDecimals: 1
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: true,
                            color: '#000000',
                            connectorColor: '#000000',
                            formatter: function () {
                                return '<b>' + this.point.name + '</b>: ' + Highcharts.numberFormat(this.percentage,1) + ' %';
                            }
                        }
                    }
                },
                series: [{
                    type: 'pie',
                    name: '性别比例',
                    data: [<%=data %>]
                }]
            });
        });
    </script>
</asp:Content>

