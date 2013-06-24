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

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.NationTypeStatistical
{
    public partial class _default : System.Web.UI.Page
    {
        public string title; //ͳ��ͼ����
        public string data; //ͳ��ͼ����
        public string table_data; //�������
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        /// <summary>
        /// ���б�����
        /// </summary>
        private void BindData()
        {
            string GroupIDs = "", strWhere = "";
            decimal han_p, other_p;
            int han, other;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "ȫ��������������ͳ��";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "������������ͳ��";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
            }

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            if (GroupIDs != "")
            {
                strWhere = "U_NationID={0} and U_Committee in ({1})";
                han = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1, GroupIDs));
                other = sys_UserInfo_bll.GetRecordCount(string.Format("U_NationID<>{0} and U_Committee in ({1})", 1,GroupIDs));
            }
            else
            {
                strWhere = "U_NationID={0}";
                han = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1));
                other = sys_UserInfo_bll.GetRecordCount(string.Format("U_NationID<>{0}", 1));
            }
            han_p = Math.Round((decimal)han/(han + other), 3);
            other_p = 1 - han_p;
            data = string.Format("['����', {0}],['����', {1}]", han_p, other_p);
            table_data = string.Format("<tr class='body'><td>����</td><td>{0}</td><td>{1}%</td></tr><tr class='body'><td>����</td><td>{2}</td><td>{3}%</td></tr>", han, (float)han_p * 100, other, (float)other_p * 100);
        }
    }
}
