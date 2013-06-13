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
            decimal man_p, woman_p;
            int man, woman;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "ȫ�������Ա�ͳ��";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "�����Ա�ͳ��";
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
            data = string.Format("['����', {0}],['Ů��', {1}]",man_p, woman_p);
            table_data = string.Format("<tr class='body'><td>����</td><td>{0}</td><td>{1}%</td></tr><tr class='body'><td>Ů��</td><td>{2}</td><td>{3}%</td></tr>", man, (float)man_p * 100, woman, (float)woman_p * 100);
        }
    }
}
