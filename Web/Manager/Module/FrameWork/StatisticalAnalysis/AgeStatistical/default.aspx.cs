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

namespace FrameWork.web.Module.FrameWork.StatisticalAnalysis.AgeStatistical
{
    public partial class _default : System.Web.UI.Page
    {
        public string title; //ͳ��ͼ����
        public string man_data; //����ͳ��ͼ����
        public string woman_data; //Ů��ͳ��ͼ����
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
            string GroupIDs = "", strWhere = "", manStr = "", womanStr ="", age_duration = "";
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            int man_temp = 0, woman_temp = 0;
            if (UserData.GetUserDate.U_Type == 0)
                title = "ȫ�����������Ա�ֲ�ͳ��";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "���������Ա�ֲ�ͳ��";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
            }
            int year = DateTime.Now.Year;

            Maticsoft.BLL.sys_UserInfo sys_UserInfo_bll = new Maticsoft.BLL.sys_UserInfo();
            if (GroupIDs != "")
            {
                strWhere = "U_Sex={0} and U_BirthDay>'{1}-12-31' and U_BirthDay<='{2}-12-31' and U_Committee in ({3})";
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 0)
                    {
                        manStr = manStr + ",";
                        womanStr = womanStr + ",";
                    }
                    man_temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1, year - (i + 1) * 10, year - i * 10, GroupIDs));
                    manStr = manStr + "-" + man_temp;
                    woman_temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0, year - (i + 1) * 10, year - i * 10, GroupIDs));
                    womanStr = womanStr + woman_temp;
                    if(i != 10)
                        age_duration = i * 10 + "-" + ((i + 1) * 10 - 1);
                    else
                        age_duration = "100+";
                    table_data = table_data + string.Format("<tr class='body'><td>{0}</td><td>{1}</td><td>{2}</td></tr>", age_duration, man_temp, woman_temp);
                }
            }
            else
            {
                strWhere = "U_Sex={0} and U_BirthDay>'{1}-12-31' and U_BirthDay<='{2}-12-31'";
                for (int i = 0; i <= 10; i++)
                {
                    if (i != 0)
                    {
                        manStr = manStr + ",";
                        womanStr = womanStr + ",";
                    }
                    man_temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 1, year - (i + 1) * 10, year - i * 10));
                    manStr = manStr + "-" + man_temp;
                    woman_temp = sys_UserInfo_bll.GetRecordCount(string.Format(strWhere, 0, year - (i + 1) * 10, year - i * 10));
                    womanStr = womanStr + woman_temp;
                    if (i != 10)
                        age_duration = i * 10 + "-" + ((i + 1) * 10 - 1);
                    else
                        age_duration = "100+";
                    table_data = table_data + string.Format("<tr class='body'><td>{0}</td><td>{1}</td><td>{2}</td></tr>", age_duration, man_temp, woman_temp);
                }
            }
            man_data = string.Format("[{0}]", manStr);
            woman_data = string.Format("[{0}]", womanStr);
        }
    }
}
