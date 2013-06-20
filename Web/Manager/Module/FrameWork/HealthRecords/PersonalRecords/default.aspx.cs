using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FrameWork.Components;

namespace FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords
{
    public partial class _default : System.Web.UI.Page
    {
        Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
        int groupID = UserData.GetUserDate.U_GroupID;
        string GroupIDs = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
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
            string orderby = OrderType == 0 ? Orderfld + " asc" : Orderfld + " desc";
            int startIndex = (this.AspNetPager1.CurrentPageIndex - 1) * this.AspNetPager1.PageSize + 1;
            int endIndex = this.AspNetPager1.CurrentPageIndex * this.AspNetPager1.PageSize;
            Maticsoft.BLL.sys_UserInfo bll = new Maticsoft.BLL.sys_UserInfo();
            DataSet datas = bll.GetListByPage(SearchTerms, orderby, startIndex, endIndex);
            GridView1.DataSource = datas;
            GridView1.DataBind();
            this.AspNetPager1.RecordCount = bll.GetRecordCount(SearchTerms);
        }
        /// <summary>
        /// ��ת��ҳʱ���õķ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// ��ȡ�Ա�
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getSexName(int code)
        {
            string sexName = "";
            switch (code)
            {
                case 0:
                    sexName = "Ů";
                    break;
                case 1:
                    sexName = "��";
                    break;
            }
            return sexName;
        }

        /// <summary>
        /// ͨ���û�id�õ��û���Ϣ
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_User getUserModelById(int userID)
        {
            Maticsoft.BLL.sys_User bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User model = bll.GetModel(userID);
            return model;
        }

        /// <summary>
        /// ͨ������id�õ�������Ϣ
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Maticsoft.Model.sys_Group getGroupModelById(int GroupID)
        {
            Maticsoft.BLL.sys_Group bll = new Maticsoft.BLL.sys_Group();
            Maticsoft.Model.sys_Group model = bll.GetModel(GroupID);
            return model;
        }

        /// <summary>
        /// �����ѯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string U_IDCard_Value = (string)Common.sink(U_IDCard.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_CName_Value = U_CName.Text;
            string U_Sex_Value = U_Sex.SelectedValue;
            string U_Committee_Value = (string)Common.sink(U_Committee.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_MobileNo_Value = (string)Common.sink(U_MobileNo.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            string U_ResponsibilityUserID_Value = Convert.ToString(Common.sink(U_ResponsibilityUserID.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string U_FilingUserID_Value = Convert.ToString(Common.sink(U_FilingUserID.UniqueID, MethodType.Post, 20, 0, DataType.Str));

            string SqlSearch = " ";
            if (UserData.GetUserDate.U_Type != 0)//������ǳ�������Ա
            {
                SqlSearch = string.Format(" U_Committee in ({0}) and", GroupIDs);
            }
            if (U_IDCard_Value != "" || U_CName_Value != "" || U_Sex_Value != "-1" || U_Committee_Value != "" || U_MobileNo_Value != "" || U_FilingUserID_Value != "" || U_ResponsibilityUserID_Value != "")
            {
                if (U_IDCard_Value != "")
                {
                    SqlSearch = SqlSearch + " U_IDCard like '%" + Common.inSQL(U_IDCard_Value) + "%' and ";
                }

                if (U_CName_Value != "")
                {
                    SqlSearch = SqlSearch + " U_CName like '%" + Common.inSQL(U_CName_Value) + "%' and ";
                }

                if (U_Sex_Value != "" && U_Sex_Value != "-1")
                {
                    SqlSearch = SqlSearch + " U_Sex = " + Common.inSQL(U_Sex_Value) + " and ";
                }

                if (U_Committee_Value != "")
                {
                    SqlSearch = SqlSearch + " U_Committee = " + Common.inSQL(U_Committee_Value) + " and ";
                }

                if (U_MobileNo_Value != "")
                {
                    SqlSearch = SqlSearch + " U_MobileNo like '%" + Common.inSQL(U_MobileNo_Value) + "%'" + " and ";
                }

                if (U_ResponsibilityUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " U_ResponsibilityUserID = " + Common.inSQL(U_ResponsibilityUserID_Value) + " and ";
                }

                if (U_FilingUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " U_FilingUserID = " + Common.inSQL(U_FilingUserID_Value) + " and ";
                }
                SqlSearch = SqlSearch.Substring(0, SqlSearch.Length - 4);
            }

            ViewState["SearchTerms"] = SqlSearch;
            AspNetPager1.CurrentPageIndex = 1;
            BindData();
            TabOptionWebControls1.SelectIndex = 0;
        }

        /// <summary>
        /// ��ѯ����
        /// </summary>
        private string SearchTerms
        {
            get
            {
                if (ViewState["SearchTerms"] == null)
                {
                    if (UserData.GetUserDate.U_Type == 0)//����ǳ�������Ա
                    {
                        ViewState["SearchTerms"] = " ";
                    }
                    else
                    {
                        ViewState["SearchTerms"] = string.Format(" U_Committee in ({0})",GroupIDs);
                    }
                }
                return (string)ViewState["SearchTerms"];
            }
            set { ViewState["SearchTerms"] = value; }
        }

        #region "����"
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            if (Orderfld == e.SortExpression)
            {
                if (OrderType == 0)
                {
                    OrderType = 1;
                }
                else
                {
                    OrderType = 0;
                }
            }
            Orderfld = e.SortExpression;
            BindData();
        }

        /// <summary>
        /// �����ֶ�
        /// </summary>
        public string Orderfld
        {
            get
            {
                if (ViewState["sortOrderfld"] == null)

                    ViewState["sortOrderfld"] = "UserID";

                return (string)ViewState["sortOrderfld"];
            }
            set
            {
                ViewState["sortOrderfld"] = value;
            }
        }

        /// <summary>
        /// �������� 1:���� 0:����
        /// </summary>
        public int OrderType
        {

            get
            {

                if (ViewState["sortOrderType"] == null)
                    ViewState["sortOrderType"] = 1;

                return (int)ViewState["sortOrderType"];


            }

            set { ViewState["sortOrderType"] = value; }

        }
        /// <summary>
        /// �����¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                foreach (TableCell var in e.Row.Cells)
                {
                    if (var.Controls.Count > 0 && var.Controls[0] is LinkButton)
                    {
                        string Colume = ((LinkButton)var.Controls[0]).CommandArgument;
                        if (Colume == Orderfld)
                        {

                            LinkButton l = (LinkButton)var.Controls[0];
                            l.Text += string.Format("<img src='{0}' border='0'>", (OrderType == 0) ? Page.ResolveUrl("~/Manager/images/sort_asc.gif") : Page.ResolveUrl("~/Manager/images/sort_desc.gif"));
                            //Image Img = new Image();
                            //SortDirection a = GridView1.SortDirection;
                            //Img.ImageUrl = (a == SortDirection.Ascending) ? "i_p_sort_asc.gif" : "i_p_sort_desc.gif";
                            //var.Controls.Add(Img);
                        }
                    }
                }
            }
        }
        #endregion
    }
}
