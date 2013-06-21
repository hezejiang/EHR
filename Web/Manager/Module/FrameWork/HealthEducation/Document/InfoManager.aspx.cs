using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;
using System.IO;

namespace FrameWork.web.Module.FrameWork.HealthEducation.Document
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int DocumentID = (int)Common.sink("DocumentID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "健康知识文档"; 
        string All_Title_Txt = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPagePermission(CMD);
            BindButton();
            if (!Page.IsPostBack)
            {
                OnStart();
            }
        }

        /// <summary>
        /// 绑定返回按钮(直接复制)
        /// </summary>
        private void BindButton()
        {
            HeadMenuButtonItem bi0 = new HeadMenuButtonItem();
            bi0.ButtonIcon = "back.gif";
            bi0.ButtonName = "返回";
            bi0.ButtonPopedom = PopedomType.List;
            bi0.ButtonUrl = string.Format("default.aspx");
            HeadMenuWebControls1.ButtonList.Add(bi0);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void OnStart()
        {
            if (CMD == "New")
            {
                
            }
            else if (CMD == "Edit")
            {
                HeadMenuButtonItem bi2 = new HeadMenuButtonItem();
                bi2.ButtonPopedom = PopedomType.Delete;
                bi2.ButtonUrlType = UrlType.JavaScript;
                bi2.ButtonUrl = string.Format("DelData('?CMD=Delete&DocumentID={0}')", DocumentID);
                HeadMenuWebControls1.ButtonList.Add(bi2);

                InputData();
            }
            else if (CMD == "Delete")
            {
                Maticsoft.BLL.education_Document bll = new Maticsoft.BLL.education_Document();
                Maticsoft.Model.education_Document model = bll.GetModel(DocumentID);
                bll.Delete(model.DocumentID);
                if (model.D_Url != "")
                    File.Delete(Server.MapPath("~/") + "Manager\\Public\\Document\\" + model.D_Url); //删除本地文件
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", DocumentID, "删除信息"), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
            }
        }

        /// <summary>
        /// 在编辑的时候将对应的值绑定到Label上
        /// </summary>
        private void InputData()
        {
            Maticsoft.BLL.education_Document education_Document_bll = new Maticsoft.BLL.education_Document();
            Maticsoft.Model.education_Document education_Document_model = education_Document_bll.GetModel(DocumentID);
            if (education_Document_model != null)
            {
                D_Name.Text = education_Document_model.D_Name;
                D_Url.Visible = false;
                D_Url_link.Visible = true;
                D_Url_link.HRef = Page.ResolveUrl("~/") + "Manager/Public/Document/" + education_Document_model.D_Url;
                D_Url_link.InnerText = education_Document_model.D_Url;
            }
        }

        /// <summary>
        /// 点击确定按钮执行的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.education_Document education_Document_bll = new Maticsoft.BLL.education_Document();
            Maticsoft.Model.education_Document education_Document_model = education_Document_bll.GetModel(DocumentID);
            if (education_Document_model == null)
            {
                education_Document_model = new Maticsoft.Model.education_Document();
            }

            education_Document_model.D_Name = D_Name.Text;
            education_Document_model.D_UserID = UserData.GetUserDate.UserID;
            education_Document_model.D_DateTime = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    FileUpLoadCommon fc = new FileUpLoadCommon(Common.UpLoadDir + "Document/", false);
                    bool flag = fc.SaveFile(D_Url, false);
                    if (flag)
                    {
                        education_Document_model.D_Url = fc.newFileName;
                        education_Document_model.DocumentID = education_Document_bll.Add(education_Document_model);
                    }
                    else
                    {
                        EventMessage.MessageBox(1, "操作失败", fc.errorMsg, Icon_Type.Error, Common.GetHomeBaseUrl("InfoManager.aspx?CMD=New"));
                    }
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    education_Document_bll.Update(education_Document_model);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", education_Document_model.DocumentID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}