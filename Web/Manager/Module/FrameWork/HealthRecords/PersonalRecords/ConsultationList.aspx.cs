using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.PersonalRecords
{
    public partial class ConsultationList : System.Web.UI.Page
    {
        public int UserID = (int)Common.sink("UserID", MethodType.Get, 255, 0, DataType.Int);

        protected void Page_Load(object sender, EventArgs e)
        {
            BindButton();
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        /// <summary>
        /// 绑定返回按钮(直接复制)
        /// </summary>
        private void BindButton()
        {
            HeadMenuButtonItem bi0 = new HeadMenuButtonItem();
            bi0.ButtonIcon = "New.gif";
            bi0.ButtonName = "新增会诊记录";
            bi0.ButtonPopedom = PopedomType.New;
            bi0.ButtonUrl = string.Format("ConsultationManager.aspx?CMD=New&UserID={0}", UserID);
            HeadMenuWebControls1.ButtonList.Add(bi0);
        }

        /// <summary>
        /// 绑定列表数据
        /// </summary>
        private void BindData()
        {
            string orderby = OrderType == 0 ? Orderfld + " asc" : Orderfld + " desc";
            int startIndex = (this.AspNetPager1.CurrentPageIndex - 1) * this.AspNetPager1.PageSize + 1;
            int endIndex = this.AspNetPager1.CurrentPageIndex * this.AspNetPager1.PageSize;
            Maticsoft.BLL.record_Consultation bll = new Maticsoft.BLL.record_Consultation();
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
        /// 点击查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            string C_Cause_Value = Convert.ToString(Common.sink(C_Cause.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string C_Comments_Value = Convert.ToString(Common.sink(C_Comments.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string C_Dortor_Value = (string)Common.sink(C_Dortor.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            string C_Time_Value = Convert.ToString(Common.sink(C_Time.UniqueID, MethodType.Post, 20, 0, DataType.Dat));

            string SqlSearch = string.Format("C_UserID={0} ", UserID);
            if (C_Cause_Value != "" || C_Comments_Value != "" || C_Dortor_Value != "" || C_Time_Value != "")
            {
                if (C_Cause_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " C_Cause like '%" + Common.inSQL(C_Cause_Value) + "%'" + " ";
                }

                if (C_Comments_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " C_Comments like '%" + Common.inSQL(C_Comments_Value) + "%'" + " ";
                }

                if (C_Dortor_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " C_Dortor = " + Common.inSQL(C_Dortor_Value) + " ";
                }

                if (C_Time_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " C_Time = '" + Common.inSQL(C_Time_Value) + "' ";
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
                    ViewState["SearchTerms"] = string.Format("C_UserID={0} ", UserID);
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

                    ViewState["sortOrderfld"] = "ConsultationID";

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