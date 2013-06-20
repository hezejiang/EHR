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

namespace FrameWork.web.Module.FrameWork.HealthRecords.DeathRegistration
{
    public partial class _default : System.Web.UI.Page
    {
        Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
        int groupID = UserData.GetUserDate.U_GroupID;
        string GroupIDs = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
            {
                BindData();
            }
        }
        /// <summary>
        /// 绑定列表数据
        /// </summary>
        private void BindData()
        {
            //排序
            string orderby = OrderType == 0 ? Orderfld + " asc" : Orderfld + " desc";
            //这一页开始的记录索引
            int startIndex = (this.AspNetPager1.CurrentPageIndex - 1) * this.AspNetPager1.PageSize + 1;
            //这一页结束的记录索引
            int endIndex = this.AspNetPager1.CurrentPageIndex * this.AspNetPager1.PageSize;
            //需要更改
            Maticsoft.BLL.record_DeathRegistration bll = new Maticsoft.BLL.record_DeathRegistration();

            //bll通过调用GetListByPage方法返回分页数据
            DataSet datas = bll.GetListByPage(SearchTerms, orderby, startIndex, endIndex);
            GridView1.DataSource = datas;
            GridView1.DataBind();
            //获取总记录数
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
        /// 点击查询（需要更改）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string D_DateTime_Value = Convert.ToString(Common.sink(D_DateTime.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string D_RegDate_Value = Convert.ToString(Common.sink(D_RegDate.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string D_UserID_Value = (string)Common.sink(D_UserID.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string D_Reason_Value = (string)Common.sink(D_Reason.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            string D_Location_Value = D_Location.Text;

            string SqlSearch = " ";
            if (UserData.GetUserDate.U_Type != 0)//如果不是超级管理员
            {
                SqlSearch = string.Format(" U_Committee in ({0}) and", GroupIDs);
            }
            if (D_DateTime_Value != "" || D_UserID_Value != "" || D_Location_Value != "" || D_Reason_Value != "")
            {
                if (D_DateTime_Value != "")
                {
                    SqlSearch = SqlSearch + " D_DateTime = '" + Common.inSQL(D_DateTime_Value) + "' and ";
                }

                if (D_RegDate_Value != "")
                {
                    SqlSearch = SqlSearch + " D_RegDate = '" + Common.inSQL(D_RegDate_Value) + "' and ";
                }

                if (D_Location_Value != "")
                {
                    SqlSearch = SqlSearch + " D_Location like '%" + Common.inSQL(D_Location_Value) + "%'" + " and ";
                }

                if (D_UserID_Value != "")
                {
                    SqlSearch = SqlSearch + " D_UserID = " + Common.inSQL(D_UserID_Value) + " and ";
                }

                if (D_Reason_Value != "")
                {
                    SqlSearch = SqlSearch + " D_Reason like '%" + Common.inSQL(D_Reason_Value) + "%'" + " and ";
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
                {
                    if (UserData.GetUserDate.U_Type == 0)//如果是超级管理员
                    {
                        ViewState["SearchTerms"] = " ";
                    }
                    else
                    {
                        ViewState["SearchTerms"] = string.Format(" U_Committee in ({0})", GroupIDs);
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

                    ViewState["sortOrderfld"] = "DeathID";

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
