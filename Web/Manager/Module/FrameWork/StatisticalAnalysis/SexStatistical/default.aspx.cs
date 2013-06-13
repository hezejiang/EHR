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

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.SexStatistical
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
            decimal man_p, woman_p;
            int man, woman;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "全国建档性别统计";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "建档性别统计";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID);
            }

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            if (GroupIDs != "")
            {
                strWhere = "U_Sex={0} and U_Committee in ({1})";
                man = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1, GroupIDs));
                woman = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0, GroupIDs));
            }
            else
            {
                strWhere = "U_Sex={0}";
                man = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1));
                woman = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0));
            }
            man_p = Math.Round((decimal)man / (man + woman),3);
            woman_p = 1 - man_p;
            data = string.Format("['男性', {0}],['女性', {1}]",man_p, woman_p);
            table_data = string.Format("<tr class='body'><td>男性</td><td>{0}</td><td>{1}%</td></tr><tr class='body'><td>女性</td><td>{2}</td><td>{3}%</td></tr>", man, (float)man_p * 100, woman, (float)woman_p * 100);
        }
    }
}
