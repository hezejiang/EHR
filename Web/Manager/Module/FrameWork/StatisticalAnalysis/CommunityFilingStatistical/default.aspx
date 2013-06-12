<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.StatisticalAnalysis.CommunityFilingStatistical._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/statistical.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="社区建档统计" HeadTitleTxt="社区建档统计">
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
                        <th>村(居)委会</th>
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
                    type: 'column',
                    margin: [50, 50, 100, 80]
                },
                title: {
                    text: '<%=title %>图'
                },
                xAxis: {
                    categories: [<%=categories %>],
                    labels: {
                        rotation: -45,
                        align: 'right',
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                },
                yAxis: {
                    min: 0,
                    title: {
                        text: '人数'
                    },
                    tickInterval:1
                },
                legend: {
                    enabled: false
                },
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.x + '</b><br/>' +
                        '人数: ' + this.y;
                    }
                },
                series: [{
                    name: '人数',
                    data: [<%=data %>],
                    dataLabels: {
                        enabled: true,
                        color: '#FFFFFF',
                        align: 'center',
                        x: 4,
                        y: 20,
                        style: {
                            fontSize: '13px',
                            fontFamily: 'Verdana, sans-serif'
                        }
                    }
                }]
            });
        });
    </script>
</asp:Content>
