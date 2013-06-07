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

namespace FrameWork.web.Module.FrameWork.HealthRecords.FollowUp
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
            Maticsoft.BLL.record_FollowUp bll = new Maticsoft.BLL.record_FollowUp();
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
        /// 获取性别
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getSexName(int code)
        {
            string sexName = "";
            switch (code)
            {
                case 0:
                    sexName = "女";
                    break;
                case 1:
                    sexName = "男";
                    break;
            }
            return sexName;
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
                    name = "高血压";
                    break;
                case 2:
                    name = "糖尿病患者";
                    break;
                case 3:
                    name = "儿童防疫";
                    break;
                case 4:
                    name = "老年人保健";
                    break;
            }
            return name;
        }

        /// <summary>
        /// 获取状态
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getStatusName(int FollowUpID, int F_Status)
        {
            string name = "";
            switch (F_Status)
            {
                case 1:
                    name = "未完成";
                    Maticsoft.BLL.record_FollowUp record_FollowUp_bll = new Maticsoft.BLL.record_FollowUp();
                    Maticsoft.Model.record_FollowUp record_FollowUp_model = record_FollowUp_bll.GetModel(FollowUpID);
                    if (record_FollowUp_model !=null)
                    {
                        if (string.Compare(DateTime.Now.ToShortDateString(), record_FollowUp_model.F_Date.ToShortDateString()) == 1)
                        {
                            record_FollowUp_model.F_Status = 3; //未完成的项目已过期
                            record_FollowUp_bll.Update(record_FollowUp_model);
                            name = "已到期";
                        }
                    }
                    break;
                case 2:
                    name = "已完成";
                    break;
                case 3:
                    name = "已到期";
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
            string U_CName_Value = U_CName.Text;
            string F_Type_Value = F_Type.SelectedValue;
            string U_ResponsibilityUserID_Value = U_ResponsibilityUserID.Value;
            string F_Date_Value = Convert.ToString(Common.sink(F_Date.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string F_Status_Value = F_Status.SelectedValue;

            string SqlSearch = " ";
            if (U_CName_Value != "" || F_Type_Value != "0" || U_ResponsibilityUserID_Value != "" || F_Date_Value != "" || F_Status_Value !="0")
            {
                if (U_CName_Value != "")
                {
                    SqlSearch = SqlSearch + " U_CName like '%" + Common.inSQL(U_CName_Value) + "%' and ";
                }

                if (F_Type_Value != "0")
                {
                    SqlSearch = SqlSearch + " F_Type = " + Common.inSQL(F_Type_Value) + " and ";
                }

                if (U_ResponsibilityUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " U_ResponsibilityUserID = " + Common.inSQL(U_ResponsibilityUserID_Value) + " and ";
                }

                if (F_Date_Value != "")
                {
                    SqlSearch = SqlSearch + " F_Date = '" + Common.inSQL(F_Date_Value) + "' and ";
                }

                if (F_Status_Value != "0")
                {
                    SqlSearch = SqlSearch + " F_Status = " + Common.inSQL(F_Status_Value) + " and ";
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

                    ViewState["sortOrderfld"] = "FollowUpID";

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
