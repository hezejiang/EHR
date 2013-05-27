<%@ WebHandler Language="C#" Class="hospital_manage" %>

using System;
using System.Web;
using System.Data;
using System.Text;
using System.Collections.Generic;
using Maticsoft.Common;

public class hospital_manage : IHttpHandler, System.Web.SessionState.IRequiresSessionState
{
    public void ProcessRequest(HttpContext context)
    {
        Maticsoft.BLL.extend_DiseaseOther extend_DiseaseOther_bll = new Maticsoft.BLL.extend_DiseaseOther();
        
        string op = context.Request.Form["Op"];
        if (op == "add")
        {
            Maticsoft.Model.extend_DiseaseOther extend_DiseaseOther_model = new Maticsoft.Model.extend_DiseaseOther();
            extend_DiseaseOther_model.DO_Type = Convert.ToInt32(context.Request.Form["DO_Type"]);
            long DO_Date = (long)Convert.ToDouble(context.Request.Form["DO_Date"]);
            extend_DiseaseOther_model.DO_Date = TimeParser.FROM_UNIXTIME(DO_Date);
            extend_DiseaseOther_model.DO_Name = context.Request.Form["DO_Name"].ToString();
            extend_DiseaseOther_model.DO_UserID = Convert.ToInt32(context.Request.Form["DO_UserID"]);
            extend_DiseaseOther_bll.Add(extend_DiseaseOther_model);
            page(context, 1);
        }
        else if (op == "delete")
        {
            int DiseaseOtherID = Convert.ToInt32(context.Request.Form["DiseaseOtherID"]);
            if (DiseaseOtherID != 0)
            {
                bool result = extend_DiseaseOther_bll.Delete(DiseaseOtherID);
                if (result)
                    HttpContext.Current.Response.Write("{'success':'删除成功'}");
                else
                    HttpContext.Current.Response.Write("{'fail':'删除失败'}");
            }
        }
        else if (op == "paging")
        {
            int pageIndex = Convert.ToInt32(context.Request.Form["Page"]);
            page(context, pageIndex);
        }
    }

    public void page(HttpContext context, int pageIndex)
    {
        Maticsoft.BLL.extend_DiseaseOther extend_DiseaseOther_bll = new Maticsoft.BLL.extend_DiseaseOther();
        
        int DO_Type = Convert.ToInt32(context.Request.Form["DO_Type"]);
        int DO_UserID = Convert.ToInt32(context.Request.Form["DO_UserID"]);
        int pageSize = 10;

        string orderby = "DiseaseOtherID desc";
        string strWhere = string.Format("DO_Type={0} and DO_UserID={1}", DO_Type, DO_UserID);
        int startIndex = (pageIndex - 1) * pageSize + 1;
        int endIndex = pageIndex * pageSize;
        DataSet ds = extend_DiseaseOther_bll.GetListByPage(strWhere, orderby, startIndex, endIndex);
        int pagecount = (int)Math.Ceiling(extend_DiseaseOther_bll.GetRecordCount(strWhere) / (double)pageSize);
        List<Maticsoft.Model.extend_DiseaseOther> list = extend_DiseaseOther_bll.DataTableToList(ds.Tables[0]);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < list.Count; i++)
        {
            sb.Append(string.Format("<ul><li class='first'>{0}</li><li style='width:50%;'>{1}</li><li>{2}</li><li><a class='delete'>删除</a></li></ul>", list[i].DiseaseOtherID, list[i].DO_Name, list[i].DO_Date.ToShortDateString()));
        }
        sb.Append(string.Format("<input type='hidden' class='page_info' page-count='{0}' page-index='{1}'/>", pagecount, pageIndex));
        HttpContext.Current.Response.Write(sb.ToString());
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }
}