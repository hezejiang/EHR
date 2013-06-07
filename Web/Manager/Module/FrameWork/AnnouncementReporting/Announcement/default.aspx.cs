using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace FrameWork.web.Module.FrameWork.AnnouncementReporting.Announcement
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
        /// 绑定列表数据
        /// </summary>
        private void BindData()
        {
            string orderby = OrderType == 0 ? Orderfld + " asc" : Orderfld + " desc";
            int startIndex = (this.AspNetPager1.CurrentPageIndex - 1) * this.AspNetPager1.PageSize + 1;
            int endIndex = this.AspNetPager1.CurrentPageIndex * this.AspNetPager1.PageSize;
            Maticsoft.BLL.AR_Announcement bll = new Maticsoft.BLL.AR_Announcement();
            DataSet datas = bll.GetListByPage(SearchTerms, orderby, startIndex, endIndex);
            GridView1.DataSource = datas;
            GridView1.DataBind();
            this.AspNetPager1.RecordCount = bll.GetRecordCount(SearchTerms);
        }
        /// <summary>
        /// 跳转分页时调用的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// 获取随访类型
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getTypeName(int code)
        {
            string name = "";
            switch (code)
            {
                case 1:
                    name = "普通公告";
                    break;
                case 2:
                    name = "重大疫情公告";
                    break;
            }
            return name;
        }

        /// <summary>
        /// 通过用户id得到用户信息
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
        /// 通过部门id得到部门信息
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
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string A_Title_Value = A_Title.Text;
            string A_Content_Value = A_Content.Text;
            string A_DateTime_Value = Convert.ToString(Common.sink(A_DateTime.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string A_Type_Value = A_Type.SelectedValue;
            string A_ResponsibilityUserID_Value = A_ResponsibilityUserID.Value;
            
            string SqlSearch = " ";
            if (A_Title_Value != "" || A_Content_Value != "" || A_ResponsibilityUserID_Value != "" || A_DateTime_Value != "" || A_Type_Value != "0")
            {
                if (A_Title_Value != "")
                {
                    SqlSearch = SqlSearch + " A_Title like '%" + Common.inSQL(A_Title_Value) + "%' and ";
                }

                if (A_Content_Value != "")
                {
                    SqlSearch = SqlSearch + " A_Content like '%" + Common.inSQL(A_Content_Value) + "%' and ";
                }

                if (A_DateTime_Value != "")
                {
                    SqlSearch = SqlSearch + " A_DateTime = '" + Common.inSQL(A_DateTime_Value) + "' and ";
                }

                if (A_Type_Value != "0")
                {
                    SqlSearch = SqlSearch + " A_Type = " + Common.inSQL(A_Type_Value) + " and ";
                }

                if (A_ResponsibilityUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " A_ResponsibilityUserID = " + Common.inSQL(A_ResponsibilityUserID_Value) + " and ";
                }

                SqlSearch = SqlSearch.Substring(0, SqlSearch.Length - 4);
            }

            ViewState["SearchTerms"] = SqlSearch;
            AspNetPager1.CurrentPageIndex = 1;
            BindData();
            TabOptionWebControls1.SelectIndex = 0;
        }

        /// <summary>
        /// 查询条件
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

        #region "排序"
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
        /// 排序字段
        /// </summary>
        public string Orderfld
        {
            get
            {
                if (ViewState["sortOrderfld"] == null)

                    ViewState["sortOrderfld"] = "AnnouncementID";

                return (string)ViewState["sortOrderfld"];
            }
            set
            {
                ViewState["sortOrderfld"] = value;
            }
        }

        /// <summary>
        /// 排序类型 1:降序 0:升序
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
        /// 排序事件
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