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
        public string title; //ͳ��ͼ����
        public string data; //ͳ��ͼ����
        public string table_data; //�������
        public string[] categories;

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
            categories = new string[]{"����ְ������ҽ�Ʊ���", "����������ҽ�Ʊ���", "ƶ������", "����ũ�����ҽ��", "��ҵҽ�Ʊ���", "ȫ����", "ȫ�Է�", "����"};
            string GroupIDs = "", strWhere = "";
            int[] datas = new int[8];
            int sum = 0, temp;
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            int groupID = UserData.GetUserDate.U_GroupID;
            if (UserData.GetUserDate.U_Type == 0)
                title = "ȫ��������������ͳ��";
            else
            {
                title = sys_Group_bll.GetModel(groupID).G_CName + "������������ͳ��";
                GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID);
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
