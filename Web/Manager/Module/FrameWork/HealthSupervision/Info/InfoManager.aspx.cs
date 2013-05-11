using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using FrameWork;
using FrameWork.Components;
using FrameWork.WebControls;

namespace FrameWork.web.Module.FrameWork.HealthSupervision.Info
{
    public partial class InfoManager : System.Web.UI.Page
    {
        int RoleID = (int)Common.sink("RoleID", MethodType.Get, 255, 0, DataType.Int);
        int InfoID = (int)Common.sink("InfoID", MethodType.Get, 255, 0, DataType.Int);
        string CMD = (string)Common.sink("CMD", MethodType.Get, 50, 0, DataType.Str);
        string CMD_Txt = "查看";
        string App_Txt = "角色";
        string All_Title_Txt = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            FrameWorkPermission.CheckPagePermission(CMD);
            if (!Page.IsPostBack)
            {
                
            }
        }

        private void OnStart()
        {
            if (CMD != "Look")
            {
                tr_username.Visible = false;
            }
            else
            {


            }

            //InputData();

            //Button1.Attributes.Add("Onclick", "javascript:return checkForm(aspnetForm);");
            //Button2.Attributes.Add("Onclick", "javascript:return checkForm(aspnetForm);");
        }

        private void InputData()
        {
            Maticsoft.BLL.supervision_Info supervision = new Maticsoft.BLL.supervision_Info();
            Maticsoft.Model.supervision_Info supervision_Info = supervision.GetModel(InfoID);

            this.I_FindDate.Text = this.I_FindDate_Txt.Text = supervision_Info.I_FindDate.ToString();
            this.I_Type.SelectedIndex = supervision_Info.I_Type;
            this.I_Type_Txt.Text = getSuperisionNameByType(supervision_Info.I_Type);
            this.I_Content.Text = this.I_Content_Txt.Text = supervision_Info.I_Content;
            this.I_ReportDate.Text = this.I_FindDate_Txt.Text = supervision_Info.I_ReportDate.ToString();
            Maticsoft.BLL.sys_User user_bll = new Maticsoft.BLL.sys_User();
            Maticsoft.Model.sys_User user_model = user_bll.GetModel(supervision_Info.I_ReportUserID);
            this.I_ReportUserID.Text = user_model.U_CName;
        }

        /// <summary>
        /// 根据信息类型返回对应的信息名称
        /// </summary>
        /// <param name="superision_type"></param>
        /// <returns></returns>
        public string getSuperisionNameByType(int superision_type){
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

        private void HiddenDisp()
        {

            //this.R_Description_Txt.Visible = false;
            //this.R_RoleName_Txt.Visible = false;
        }
        private void HiddenInput()
        {
            //this.R_Description.Visible = false;
            //this.R_RoleName.Visible = false;
            this.SubmitTr.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.supervision_Info supervision = new Maticsoft.BLL.supervision_Info();
            Maticsoft.Model.supervision_Info supervision_Info = supervision.GetModel(InfoID);
            if (supervision_Info == null)
            {
                supervision_Info = new Maticsoft.Model.supervision_Info();
            }

            supervision_Info.I_Content = I_Content_Txt.Text;
            supervision_Info.I_Content = (string)Common.sink(this.I_Content_Txt.UniqueID, MethodType.Get, 0, 0, DataType.Str);
            supervision_Info.I_FindDate = (DateTime)Common.sink(this.I_FindDate_Txt.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            supervision_Info.I_Type = this.I_Type.SelectedIndex;
            
            supervision_Info.I_ReportDate = (DateTime)Common.sink(this.I_ReportDate_Txt.UniqueID, MethodType.Post, 255, 0, DataType.Dat);
            supervision_Info.I_ReportUserID = 2; //暂且设为2

            int result = 0;

            switch (CMD)
            {
                case "New":
                    CMD_Txt = "增加";
                    result = supervision.Add(supervision_Info);
                    break;
                case "Edit":
                    CMD_Txt = "修改";
                    supervision.Update(supervision_Info);
                    break;
            }
            All_Title_Txt = CMD_Txt + App_Txt;
            if(result > 0)
                EventMessage.MessageBox(1, "操作成功", string.Format("{1}ID({0})成功!", RoleID, All_Title_Txt), Icon_Type.OK, Common.GetHomeBaseUrl("default.aspx"));
        }
    }
}