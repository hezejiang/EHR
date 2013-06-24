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
using System.Text;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.CommonModule
{
    public partial class SelectUser : System.Web.UI.Page
    {
        public string TableSink = Common.TableSink;
        int U_GroupID = (int)Common.sink("GroupID", MethodType.Get, 255, 0, DataType.Int);
        string GroupIDs;

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
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(U_GroupID);
            GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(U_GroupID, false);

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
        /// 跳转分页时调用的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// 点击查询（需要更改）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void search_Click(object sender, EventArgs e)
        {
            string U_IDCard_Value = Convert.ToString(Common.sink(U_IDCard_key.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string U_CName_Value = Convert.ToString(Common.sink(U_CName_key.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string U_MobileNo_Value = (string)Common.sink(U_MobileNo_key.UniqueID, MethodType.Post, 20, 0, DataType.Str);

            string SqlSearch = "";
            Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
            Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(U_GroupID);
            if (sys_Group_model.G_Type == 0)
            {
                SqlSearch = string.Format(" U_Committee in({0}) and ", GroupIDs);
            }
            else
            {
                SqlSearch = string.Format(" (U_Committee={0} or U_GroupID={1}) and", U_GroupID,U_GroupID);
            }
            if (U_IDCard_Value != "" || U_CName_Value != "" || U_MobileNo_Value != "")
            {
                if (U_IDCard_Value != "")
                {
                    SqlSearch = SqlSearch + " U_IDCard like '%" + Common.inSQL(U_IDCard_Value) + "%'" + " and ";
                }

                if (U_CName_Value != "")
                {
                    SqlSearch = SqlSearch + " U_CName like '%" + Common.inSQL(U_CName_Value) + "%'" + " and ";
                }

                if (U_MobileNo_Value != "")
                {
                    SqlSearch = SqlSearch + " U_MobileNo like '%" + Common.inSQL(U_MobileNo_Value) + "%'" + " and ";
                }
                SqlSearch = SqlSearch.Substring(0, SqlSearch.Length - 4);
            }
            
            ViewState["SearchTerms"] = SqlSearch;
            AspNetPager1.CurrentPageIndex = 1;
            BindData();
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
                    Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
                    Maticsoft.Model.sys_Group sys_Group_model = sys_Group_bll.GetModel(U_GroupID);
                    if (sys_Group_model.G_Type == 0)
                    {
                        ViewState["SearchTerms"] = string.Format(" U_Committee in({0}) ", GroupIDs);
                    }
                    else
                    {
                        ViewState["SearchTerms"] = string.Format(" U_Committee={0} or U_GroupID={1}", U_GroupID, U_GroupID);
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

                    ViewState["sortOrderfld"] = "UserID"; //（需要更改）

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
