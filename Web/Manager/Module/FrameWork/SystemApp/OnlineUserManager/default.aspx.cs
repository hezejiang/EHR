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

namespace FrameWork.web.Module.FrameWork.OnlineUserManager
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }



        private void BindData()
        {
            int RecordCount = 0;
            GridView1.DataSource = FrameWorkOnline.Instance().GetOnlineList(AspNetPager1.CurrentPageIndex, AspNetPager1.PageSize, out RecordCount);
            GridView1.DataBind();
            this.AspNetPager1.RecordCount = RecordCount;

        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            BindData();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "OutOnline")
            {
                FrameWorkPermission.CheckPermissionVoid(PopedomType.Delete);
                //FrameWorkPermission.UserOnlineList.RemoveUserName(e.CommandArgument.ToString().ToLower());
                FrameWorkOnline.Instance().OnlineRemove(e.CommandArgument.ToString().ToLower());
                MessageBox MBx = new MessageBox();
                MBx.M_Type = 2;
                MBx.M_Title = "ǿ���û��˳�!";
                MBx.M_IconType = Icon_Type.Error;
                MBx.M_Body = string.Format("ǿ���û�({0})�˳��ɹ���", e.CommandArgument.ToString());
                MBx.M_ButtonList.Add(new sys_NavigationUrl("����", Common.GetHomeBaseUrl("default.aspx"), "", UrlType.Href, true));
                EventMessage.MessageBox(MBx);

            }
        }
    }
}
