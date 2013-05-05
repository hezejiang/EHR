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

namespace FrameWork.web.Module.FrameWork.GroupManager
{
    public partial class GroupList : System.Web.UI.Page
    {
        int GroupID;
        protected void Page_Load(object sender, EventArgs e)
        {
            GroupID = (int)Common.sink("GroupID", MethodType.Get, 255, 0, DataType.Int);



            if (!Page.IsPostBack)
            {
                OnStart();
                ButtonBind();
            }
        }

        private void ButtonBind()
        {
            HeadMenuButtonItem bi0 = new HeadMenuButtonItem();
            bi0.ButtonPopedom = PopedomType.New;
            bi0.ButtonName = "����";
            bi0.ButtonUrl = string.Format("New.aspx?GroupID={0}", GroupID);
            HeadMenuWebControls1.ButtonList.Add(bi0);

            HeadMenuButtonItem bi1 = new HeadMenuButtonItem();
            bi1.ButtonPopedom = PopedomType.Orderby;
            bi1.ButtonName = "�Ӳ���";
            bi1.ButtonUrl = string.Format("Orderby.aspx?GroupID={0}",GroupID);
            HeadMenuWebControls1.ButtonList.Add(bi1);
            if (GroupID != 0)
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Edit;
                bi2.ButtonName = "����";
                bi2.ButtonUrl = string.Format("Edit.aspx?GroupID={0}", GroupID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                HeadMenuButtonItem bi3 = new HeadMenuButtonItem();
                bi3.ButtonIcon = "move.gif";
                bi3.ButtonName = "�ƶ�����";
                bi3.ButtonPopedom = PopedomType.Edit;
                bi3.ButtonUrlType = UrlType.JavaScript;
                bi3.ButtonUrl = string.Format("sMove('{0}&datetime={1}')",GroupID,DateTime.Now);
                HeadMenuWebControls1.ButtonList.Add(bi3);
            }
        }

        private void OnStart()
        {

            int RecordCount = 0;
            QueryParam qp = new QueryParam();
            qp.Orderfld = "G_Level,G_ShowOrder";
            qp.OrderType = 0;
            qp.Where = string.Format("Where G_ParentID ={0} and G_Delete=0 ",GroupID);
            ArrayList lst = BusinessFacade.sys_GroupList(qp, out RecordCount);

            CatCountTxt.Text = RecordCount.ToString();
            if (GroupID == 0)
                CatNameTxt.Text = "�����б�";
            else {
                CatNameTxt.Text = BusinessFacade.sys_GroupDisp(GroupID).G_CName;
            }

            SubGroup.DataSource = lst;
            SubGroup.DataBind();

            CatListTitle.Text = string.Format("<a href='GroupList.aspx'>�����б�</a>{0}", BusinessFacade.GetGroupTitle(GroupID));
        }
    }
}
