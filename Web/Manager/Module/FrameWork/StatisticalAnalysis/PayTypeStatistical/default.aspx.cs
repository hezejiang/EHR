using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FrameWork.Components;

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.PayTypeStatistical
{
    public partial class _default : System.Web.UI.Page
    {
        public string title; //统计图标题
        public string data; //统计图数据
        public string table_data; //表格数据
        public string[] categories;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        /// <summary>
        /// 绑定列表数据
        /// </summary>
        private void BindData()
        {
            categories = new string[]{"城镇职工基本医疗保险", "城镇居民基本医疗保险", "贫困扶助", "新型农村合作医疗", "商业医疗保险", "全公费", "全自费", "其他"};
            string GroupIDs = "", strWhere = "";
            int[] datas = new int[8];
            int sum = 0, temp;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "全国建档付费类型统计";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "建档付费类型统计";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
            }

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            if (GroupIDs != "")
            {
                for (int i = 0; i < datas.Length; i++)
                {
                    strWhere = "U_PaymentType={0} and U_Committee in ({1})";
                    datas[i] = temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, i+1, GroupIDs));
                    sum += temp;
                }
            }
            else
            {
                strWhere = "U_PaymentType={0}";
                for (int i = 0; i < datas.Length; i++)
                {
                    strWhere = "U_PaymentType={0}";
                    datas[i] = temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, i+1));
                    sum += temp;
                }
            }
            
            for (int i = 0; i < datas.Length; i++)
            {
                if (i != 0)
                        data = data + ",";
                float per = (float)Math.Round((decimal)datas[i] / sum * 100,1);
                data = data + "{" + string.Format("y: {0}, color: colors[{1}]", per, i) + "}";
                table_data = table_data + string.Format("<tr class='body'><td>{0}</td><td>{1}</td><td>{2}%</td></tr>", categories[i], datas[i], per);
            }
        }
    }
}
