<%@ Page Language="C#" MasterPageFile="~/Manager/MasterPage/PageTemplate.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FrameWork.web.Module.FrameWork.StatisticalAnalysis.AgeStatistical._default"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/css/subModal.css" />
    <link rel="stylesheet" type="text/css" href="<%=Page.ResolveUrl("~/") %>Manager/Css/statistical.css" />

    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/common.js"></script>
    <script type="text/javascript" src="<%=Page.ResolveUrl("~/") %>Manager/inc/FineMessBox/js/subModal.js"></script>

    <FrameWorkWebControls:HeadMenuWebControls ID="HeadMenuWebControls1" runat="server" HeadOPTxt="年龄统计" HeadTitleTxt="年龄统计">
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
                        <th>年龄阶段</th>
                        <th>男性人数</th>
                        <th>女性人数</th>
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
            var chart,
            categories = ['0-9', '10-19',
            '20-29', '30-39', '40-49', '50-59', '60-69',
            '70-79', '80-89', '90-99', '100 +'];
            $(document).ready(function () {
                $('#container').highcharts({
                    chart: {
                        type: 'bar'
                    },
                    title: {
                        text: '<%=title %>图'
                    },
                    xAxis: [{
                        categories: categories,
                        reversed: false
                    }, { // mirror axis on right side
                        opposite: true,
                        reversed: false,
                        categories: categories,
                        linkedTo: 0
                    }],
                    yAxis: {
                        title: {
                            text: null
                        },
                        labels: {
                            formatter: function () {
                                //return (Math.abs(this.value) / 1000000) + 'M';
                                return (Math.abs(this.value) / 1000) + 'T';
                            }
                        }
                    },

                    plotOptions: {
                        series: {
                            stacking: 'normal'
                        }
                    },

                    tooltip: {
                        formatter: function () {
                            return '<b>' + this.series.name + ', 年龄 ' + this.point.category + '</b><br/>' +
                        '人数: ' + Highcharts.numberFormat(Math.abs(this.point.y), 0);
                        }
                    },

                    series: [{
                        name: '男性',
                        data: <%=man_data %>
                    }, {
                        name: '女性',
                        data: <%=woman_data %>
                    }]
                });
            });
        });
    </script>
</asp:Content>
