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

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.UserManager
{
    public partial class Default : System.Web.UI.Page
    {

        public string U_GroupID_ID ="";
        public string U_GroupID_Txt_ID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {

            U_GroupID_ID = U_GroupID.UniqueID;
            U_GroupID_Txt_ID = U_GroupID_Txt.UniqueID;

            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            QueryParam qp = new QueryParam();
            qp.Where = SearchTerms;
            qp.PageIndex = AspNetPager1.CurrentPageIndex;
            qp.PageSize = AspNetPager1.PageSize;
            qp.Orderfld = Orderfld;
            qp.OrderType = OrderType;
            int RecordCount = 0;
            ArrayList lst = BusinessFacade.sys_UserList(qp, out RecordCount);
            GridView1.DataSource = lst;
            GridView1.DataBind();
            this.AspNetPager1.RecordCount = RecordCount;
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        /// <summary>
        /// ͨ���û�id�õ��û���Ϣ
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public string getUserRoleById(int userID)
        {
            string role = "";
            ArrayList lst = BusinessFacade.sys_UserRolesDisp(userID);
            if (lst.Count != 0)
            {
                foreach (sys_UserRolesTable var in lst)
                {
                    role = BusinessFacade.sys_RolesDisp(var.R_RoleID).R_RoleName;
                }
            }
            return role;
        }

        #region "������"
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="U_GroupID"></param>
        /// <returns></returns>
        public string Get_U_GroupID(int U_GroupID)
        {
            if (U_GroupID == 0)
                return "";
            return BusinessFacade.sys_GroupDisp(U_GroupID).G_CName;
        }

        /// <summary>
        /// �û�����
        /// </summary>
        /// <param name="U_Type"></param>
        /// <returns></returns>
        public string Get_U_Type(int U_Type)
        {
            if (U_Type == 0)
            {
                return "�����û�";
            }
            else
                return "��ͨ�û�";
        }

        /// <summary>
        /// ��ȡ�û�״̬
        /// </summary>
        /// <param name="U_Status"></param>
        /// <returns></returns>
        public string GetStat(int U_Status)
        {
            if (U_Status == 0)
            {
                return "����";
            }
            else {
                return "��ֹ";
            }
        }
        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            string U_GroupID_Value = (string)Common.sink(U_GroupID.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            string U_CName_Value = (string)Common.sink(U_CName.UniqueID, MethodType.Post, 20, 0, DataType.Str);
            string U_Type_Value = (string)Common.sink(U_Type.UniqueID, MethodType.Post, 255, 0, DataType.Str);
            string U_Status_Value = (string)Common.sink(U_Status.UniqueID, MethodType.Post, 255, 0, DataType.Str);

            string SqlSearch = " Where U_Status<>2 ";

            if (U_GroupID_Value != "")
            {
                SqlSearch = SqlSearch + " and U_GroupID = " + Common.inSQL(U_GroupID_Value);
            }

            if (U_CName_Value != "")
            {
                SqlSearch = SqlSearch + " and U_CName like '%" + Common.inSQL(U_CName_Value) + "%'";
            }

            if (U_Type_Value != "")
            {
                SqlSearch = SqlSearch + " and U_Type=" + Common.inSQL(U_Type_Value);
            }

            if (U_Status_Value != "")
            {
                SqlSearch = SqlSearch + " and U_Status=" + Common.inSQL(U_Status_Value);
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
                    ViewState["SearchTerms"] = " Where U_Status<>2";
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
