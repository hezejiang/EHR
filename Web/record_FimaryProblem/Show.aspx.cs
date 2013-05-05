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
using System.Text;
namespace Maticsoft.Web.record_FimaryProblem
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		Maticsoft.BLL.record_FimaryProblem bll=new Maticsoft.BLL.record_FimaryProblem();
		Maticsoft.Model.record_FimaryProblem model=bll.GetModel();
		this.lblF_FimaryCode.Text=model.F_FimaryCode;
		this.lblF_RecordTime.Text=model.F_RecordTime.ToString();
		this.lblF_StartTime.Text=model.F_StartTime.ToString();
		this.lblF_endTime.Text=model.F_endTime.ToString();
		this.lblF_OverviewProblem.Text=model.F_OverviewProblem;
		this.lblF_DetailProblem.Text=model.F_DetailProblem;
		this.lblF_FillingUserID.Text=model.F_FillingUserID.ToString();

	}


    }
}
