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

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.UsualTypeStatistical
{
    public partial class _default : System.Web.UI.Page
    {
        public string title; //统计图标题
        public string data; //统计图数据
        public string table_data; //表格数据

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
            string GroupIDs = "", strWhere = "";
            decimal main_p, other_p;
            int main, other;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "全国建档常住类型统计";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "建档常住类型统计";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
            }

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            if (GroupIDs != "")
            {
                strWhere = "U_PermanentType={0} and U_Committee in ({1})";
                main = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1, GroupIDs));
                other = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0, GroupIDs));
            }
            else
            {
                strWhere = "U_PermanentType={0}";
                main = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1));
                other = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0));
            }
            main_p = Math.Round((decimal)main / (main + other), 3);
            other_p = 1 - main_p;
            data = string.Format("['户籍', {0}],['非户籍', {1}]", main_p, other_p);
            table_data = string.Format("<tr class='body'><td>户籍</td><td>{0}</td><td>{1}%</td></tr><tr class='body'><td>非户籍</td><td>{2}</td><td>{3}%</td></tr>", main, (float)main_p * 100, other, (float)other_p * 100);
        }
    }
}
