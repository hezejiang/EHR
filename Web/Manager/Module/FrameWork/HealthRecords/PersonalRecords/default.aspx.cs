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

namespace FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords
{
    public partial class _default : System.Web.UI.Page
    {
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
            /*string I_FindDate_Value = Convert.ToString(Common.sink(I_FindDate.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string I_Type_Value = I_Type.SelectedValue;
            string I_ReportDate_Value = Convert.ToString(Common.sink(I_ReportDate.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string I_ReportUserID_Value = (string)Common.sink(I_ReportUserID.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string I_Content_Value = (string)Common.sink(I_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);

            string SqlSearch = " ";
            if (I_FindDate_Value != "" || I_Type_Value != "" || I_ReportDate_Value != "" || I_ReportUserID_Value != "" || I_Content_Value != "")
            {
                if (I_FindDate_Value != "")
                {
                    SqlSearch = SqlSearch + " I_FindDate = '" + Common.inSQL(I_FindDate_Value) + "' and ";
                }

                if (I_Type_Value != "" && I_Type_Value !="0")
                {
                    SqlSearch = SqlSearch + " I_Type = " + Common.inSQL(I_Type_Value) + " and ";
                }

                if (I_ReportDate_Value != "")
                {
                    SqlSearch = SqlSearch + " I_ReportDate = '" + Common.inSQL(I_ReportDate_Value) + "' and ";
                }

                if (I_ReportUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " I_ReportUserID = " + Common.inSQL(I_ReportUserID_Value) + " and ";
                }

                if (I_Content_Value != "")
                {
                    SqlSearch = SqlSearch + " I_Content like '%" + Common.inSQL(I_Content_Value) + "%'" + " and ";
                }
                SqlSearch = SqlSearch.Substring(0, SqlSearch.Length - 4);
            }

            ViewState["SearchTerms"] = SqlSearch;*/
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
                    ViewState["SearchTerms"] = "";
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
