using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace FrameWork.web.Module.FrameWork.AnnouncementReporting.Reporting.Emergencies
{
    public partial class _default : System.Web.UI.Page
    {
        Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
        int groupID = UserData.GetUserDate.U_GroupID;
        string GroupIDs = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, true);
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
            Maticsoft.BLL.AR_Report bll = new Maticsoft.BLL.AR_Report();
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
            string R_Title_Value = R_Title.Text;
            string R_Content_Value = R_Content.Text;
            string R_DateTime_Value = Convert.ToString(Common.sink(R_DateTime.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            //string R_Type_Value = 2 + "";
            string R_ResponsibilityUserID_Value = R_ResponsibilityUserID.Value;

            string SqlSearch = "";
            if (UserData.GetUserDate.U_Type == 0)//如果是超级管理员
            {
                SqlSearch = string.Format("R_Type={0}", 2);
            }
            else
            {
                SqlSearch = string.Format("R_Type={0} and R_GroupID in ({1})", 2, GroupIDs);
            }
            if (R_Title_Value != "" || R_Content_Value != "" || R_ResponsibilityUserID_Value != "" || R_DateTime_Value != "")
            {
                if (R_Title_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " R_Title like '%" + Common.inSQL(R_Title_Value) + "%' ";
                }

                if (R_Content_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " R_Content like '%" + Common.inSQL(R_Content_Value) + "%' ";
                }

                if (R_DateTime_Value != "")
                {
                    SqlSearch =  SqlSearch + " and "  + " R_DateTime = '" + Common.inSQL(R_DateTime_Value) + "' ";
                }

                if (R_ResponsibilityUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " R_ResponsibilityUserID = " + Common.inSQL(R_ResponsibilityUserID_Value) + " ";
                }
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
                {
                    if (UserData.GetUserDate.U_Type == 0)//如果是超级管理员
                    {
                        ViewState["SearchTerms"] = string.Format("R_Type={0}", 2);
                    }
                    else
                    {
                        ViewState["SearchTerms"] = string.Format("R_Type={0} and R_GroupID in ({1})", 2, GroupIDs);
                    }
                }
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

                    ViewState["sortOrderfld"] = "R_DateTime";

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