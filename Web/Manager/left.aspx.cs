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

namespace FrameWork.web
{
    public partial class left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindMenu();
        }

        #region "�����˵�"
        /// <summary>
        /// �����˵�
        /// </summary>
        private void BindMenu()
        {            
            LeftMenu.DataSource = BusinessFacade.sys_Module_List();
            LeftMenu.DataBind();
        }


        #endregion

        #region "���Ӳ˵�"
        /// <summary>
        /// ���Ӳ˵��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LeftMenu_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
            sys_ModuleTable s_Mt= (sys_ModuleTable)e.Item.DataItem;

            QueryParam qp = new QueryParam();
            qp.Orderfld = " M_OrderLevel ";
            qp.OrderType = 0;
            qp.Where =  string.Format("Where M_Close=0 and M_ParentID ={0}",s_Mt.ModuleID);
            int RecordCount = 0;
            ArrayList lst = BusinessFacade.sys_ModuleList(qp, out RecordCount);
            BusinessFacade.Remove_MenuNoPermission(lst);
            if (lst.Count > 0)
            {
                Repeater LeftSubID = (Repeater)e.Item.FindControl("LeftMenu_Sub");
                LeftSubID.DataSource = lst;
                LeftSubID.DataBind();
            }
            else {
                e.Item.Visible = false;
            }

        }


        #endregion
    }
}
