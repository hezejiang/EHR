<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.StatisticalAnalysis.PayTypeStatistical._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/statistical.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>
    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="付费类型统计" HeadTitleTxt="付费类型统计">
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
                        <th>付费类型</th>
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
            var colors = Highcharts.getOptions().colors,
            categories = ['城镇职工基本医疗保险', '城镇居民基本医疗保险', '贫困扶助', '新型农村合作医疗', '商业医疗保险', '全公费', '全自费', '其他'],
            name = 'Browser brands',
            data = [<%=data %>];

            function setChart(name, categories, data, color) {
                chart.xAxis[0].setCategories(categories, false);
                chart.series[0].remove(false);
                chart.addSeries({
                    name: name,
                    data: data,
                    color: color || 'white'
                }, false);
                chart.redraw();
            }

            var chart = $('#container').highcharts({
                chart: {
                    type: 'column'
                },
                title: {
                    text: '<%=title %>图'
                },
                xAxis: {
                    categories: categories
                },
                yAxis: {
                    title: {
                        text: '百分比'
                    }
                },
                plotOptions: {
                    column: {
                        cursor: 'pointer',
                        point: {
                            events: {
                                
                            }
                        },
                        dataLabels: {
                            enabled: true,
                            color: colors[0],
                            style: {
                                fontWeight: 'bold'
                            },
                            formatter: function () {
                                return this.y + '%';
                            }
                        }
                    }
                },
                tooltip: {
                    formatter: function () {
                        var point = this.point,
                        s = this.x + ':<b>' + this.y + '% </b>';
                        return s;
                    }
                },
                series: [{
                    name: name,
                    data: data,
                    color: 'white'
                }],
                exporting: {
                    enabled: true
                }
            })
        .highcharts(); // return chart

            $('.highcharts-legend').hide();
        });
    </script>
</asp:Content>

