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

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.DiseaseStatistical
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
                title = "全国建档疾病人数统计";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "建档疾病人数统计";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID);
            }

            Maticsoft.BLL.commonDiseases commonDiseases_bll = new Maticsoft.BLL.commonDiseases();
            List<Maticsoft.Model.commonDiseases> list = commonDiseases_bll.GetModelList("");
            Maticsoft.Model.commonDiseases commonDiseases_model = new Maticsoft.Model.commonDiseases();
            datas = new int[list.Count];

            Maticsoft.BLL.extend_UserDisease extend_UserDisease_bll = new Maticsoft.BLL.extend_UserDisease();
            if (GroupIDs != "")
            {
                strWhere = "DH_Type={0} and U_Committee in ({1})";
                for (int i = 0; i < list.Count; i++)
                {
                    commonDiseases_model = (Maticsoft.Model.commonDiseases)list[i];
                    datas[i] = temp = extend_UserDisease_bll.GetRecordCount(string.Format(strWhere, commonDiseases_model.CommonDiseaseID, GroupIDs));
                    sum += temp;
                }
            }
            else
            {
                strWhere = "DH_Type={0}";
                for (int i = 0; i < list.Count; i++)
                {
                    commonDiseases_model = (Maticsoft.Model.commonDiseases)list[i];
                    datas[i] = temp = extend_UserDisease_bll.GetRecordCount(string.Format(strWhere, commonDiseases_model.CommonDiseaseID));
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
                data = data + "{" + string.Format("y: {0}, color: colors[{1}]", datas[i], i) + "}";
                commonDiseases_model = (Maticsoft.Model.commonDiseases)list[i];
                categories = categories + string.Format("'{0}'", commonDiseases_model.CD_Name);
                table_data = table_data + string.Format("<tr class='body'><td>{0}</td><td>{1}</td><td>{2}%</td></tr>", commonDiseases_model.CD_Name, datas[i], per);
            }
        }
    }
}
