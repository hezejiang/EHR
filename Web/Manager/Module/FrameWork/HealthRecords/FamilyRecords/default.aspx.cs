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
using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthRecords.FamilyRecords
{
    public partial class _default : System.Web.UI.Page
    {
        Maticsoft.BLL.sys_Group sys_Group_bll = new Maticsoft.BLL.sys_Group();
        int groupID = UserData.GetUserDate.U_GroupID;
        string GroupIDs = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            GroupIDs = sys_Group_bll.GetLowerLevelString_withSelf(groupID, false);
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
            bi0.ButtonName = "新增家庭健康档案";
            bi0.ButtonPopedom = PopedomType.New;
            bi0.ButtonUrl = string.Format("InfoManager.aspx?CMD=New");
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
            Maticsoft.BLL.record_FamilyBaseInfo bll = new Maticsoft.BLL.record_FamilyBaseInfo();
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
            string F_FamilyCode_Value = (string)Common.sink(F_FamilyCode.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string F_UserID_Value = F_UserID.Value;
            string F_FamilyTel_Value = (string)Common.sink(F_FamilyTel.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            string F_ResponsibilityUserID_Value = Convert.ToString(Common.sink(F_ResponsibilityUserID.UniqueID, MethodType.Post, 20, 0, DataType.Str));
            string F_FillingUserID_Value = Convert.ToString(Common.sink(F_FillingUserID.UniqueID, MethodType.Post, 20, 0, DataType.Str));

            string SqlSearch = " ";
            if (UserData.GetUserDate.U_Type == 0)//如果是超级管理员
            {
                SqlSearch = " 1= 1";
            }
            else
            {
                SqlSearch = string.Format(" U_Committee in ({0})", GroupIDs);
            }
            if (F_FamilyCode_Value != "" || F_UserID_Value != "" || F_FamilyTel_Value != "" || F_FillingUserID_Value != "" || F_ResponsibilityUserID_Value != "")
            {
                if (F_FamilyCode_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " F_FamilyCode like '%" + Common.inSQL(F_FamilyCode_Value) + "%' ";
                }

                if (F_UserID_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " F_UserID like '%" + Common.inSQL(F_UserID_Value) + "%' ";
                }

                if (F_FamilyTel_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " F_FamilyTel like '%" + Common.inSQL(F_FamilyTel_Value) + "%'" + " ";
                }

                if (F_ResponsibilityUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " F_ResponsibilityUserID = " + Common.inSQL(F_ResponsibilityUserID_Value) + " ";
                }

                if (F_FillingUserID_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " F_FillingUserID = " + Common.inSQL(F_FillingUserID_Value) + " ";
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

                    ViewState["sortOrderfld"] = "F_FamilyCode";

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
