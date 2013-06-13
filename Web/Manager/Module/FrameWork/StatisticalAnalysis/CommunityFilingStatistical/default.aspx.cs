using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FrameWork.Components;

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.CommunityFilingStatistical
{
    public partial class _default : System.Web.UI.Page
    {
        public string title; //统计图标题
        public string data; //统计图数据
        public string categories; //种类
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
            int sum = 0, temp = 0;
            int[] datas;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "全国社区建档统计";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "社区建档统计";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID);
            }

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            List<Maticsoft.Model.sys_Group> list = new List<Maticsoft.Model.sys_Group>();
            Maticsoft.Model.sys_Group sys_Group_model = new Maticsoft.Model.sys_Group();

            if (GroupIDs != "")
            {
                list = sys_Group_bll.GetModelList(string.Format("G_Level={0} and GroupID in ({1}) ", 5, GroupIDs));
                datas = new int[list.Count];
                strWhere = "U_Committee={0}";
                for (int i = 0; i < list.Count; i++)
                {
                    sys_Group_model = (Maticsoft.Model.sys_Group)list[i];
                    datas[i] = temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, sys_Group_model.GroupID));
                    sum += temp;
                }
            }
            else
            {
                list = sys_Group_bll.GetModelList(string.Format("G_Level={0} ", 5));
                datas = new int[list.Count];
                strWhere = "U_Committee={0}";
                for (int i = 0; i < list.Count; i++)
                {
                    sys_Group_model = (Maticsoft.Model.sys_Group)list[i];
                    datas[i] = temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, sys_Group_model.GroupID));
                    sum += temp;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i != 0)
                {
                    data = data + ",";
                    categories = categories + ",";
                }
                float per = (float)Math.Round((decimal)datas[i] / sum * 100, 1);
                data = data + string.Format("{0}", datas[i]);
                sys_Group_model = (Maticsoft.Model.sys_Group)list[i];
                categories = categories + string.Format("'{0}'", sys_Group_model.G_CName);
                table_data = table_data + string.Format("<tr class='body'><td>{0}</td><td>{1}</td><td>{2}%</td></tr>", sys_Group_model.G_CName, datas[i], per);
            }
        }
    }
}
