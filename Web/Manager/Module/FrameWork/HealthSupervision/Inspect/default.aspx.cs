﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FrameWork.web.Module.FrameWork.HealthSupervision.Inspect
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
            //排序
            string orderby = OrderType == 0 ? Orderfld + " asc" : Orderfld + " desc";
            //这一页开始的记录索引
            int startIndex = (this.AspNetPager1.CurrentPageIndex - 1) * this.AspNetPager1.PageSize + 1;
            //这一页结束的记录索引
            int endIndex = this.AspNetPager1.CurrentPageIndex * this.AspNetPager1.PageSize;
            //需要更改
            Maticsoft.BLL.supervision_Inspect bll = new Maticsoft.BLL.supervision_Inspect();

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
        /// 根据信息类型返回对应的信息名称（这个方法是在有下拉框的时候需要）
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getSuperisionNameByType(int superision_type)
        {
            string superision_name = "";
            switch (superision_type)
            {
                case 1:
                    superision_name = "食品安全";
                    break;
                case 2:
                    superision_name = "饮用水卫生";
                    break;
                case 3:
                    superision_name = "职业病安全";
                    break;
                case 4:
                    superision_name = "学校卫生";
                    break;
                case 5:
                    superision_name = "非法行医（采供血）";
                    break;
            }
            return superision_name;
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
            string I_Date_Value = Convert.ToString(Common.sink(I_Date.UniqueID, MethodType.Post, 20, 0, DataType.Dat));
            string I_Type_Value = I_Type.SelectedValue;
            string I_UserID_Value = (string)Common.sink(I_UserID.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string I_Content_Value = (string)Common.sink(I_Content.UniqueID, MethodType.Post, 0, 0, DataType.Str);
            string I_Location_Value = I_Location.Text;

            string SqlSearch = " ";
            if (UserData.GetUserDate.U_Type == 0)//如果是超级管理员
            {
                SqlSearch = " 1=1 ";
            }
            else
            {
                SqlSearch = string.Format("I_UserID={0} ", UserData.GetUserDate.UserID);
            }
            if (I_Date_Value != "" || I_Type_Value != "0" ||  I_UserID_Value != ""||I_Location_Value!="" || I_Content_Value != "")
            {
                if (I_Date_Value != "")
                {
                    SqlSearch = "and " + SqlSearch + " I_Date = '" + Common.inSQL(I_Date_Value) + "' ";
                }

                if (I_Type_Value != "0")
                {
                    SqlSearch = SqlSearch + " and "  + " I_Type = " + Common.inSQL(I_Type_Value) + " ";
                }

                if (I_Location_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " I_Location like '%" + Common.inSQL(I_Location_Value) + "%'" + " ";
                }

                if (I_UserID_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " I_UserID = " + Common.inSQL(I_UserID_Value) + " ";
                }

                if (I_Content_Value != "")
                {
                    SqlSearch = SqlSearch + " and "  + " I_Content like '%" + Common.inSQL(I_Content_Value) + "%'" + " ";
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
                        ViewState["SearchTerms"] = "";
                    }
                    else
                    {
                        ViewState["SearchTerms"] = string.Format("I_UserID={0} ", UserData.GetUserDate.UserID);
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

                    ViewState["sortOrderfld"] = "InspectID"; 

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