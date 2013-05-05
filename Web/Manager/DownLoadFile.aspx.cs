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
using System.IO;

using FrameWork;

namespace FrameWork.web
{
    public partial class DownLoadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string a = Common.EncryptString("1�л����񹲺͹�", "aaaaabcaaaaaaaaa");
            //Response.Write(a);
            //string b = Common.DecryptString(a, "aaaaabcaaaaaaaaa");
            //Response.Write(b);
            //Response.End();


            string FileName = (string)Common.sink("FileName", MethodType.Get, 255, 1, DataType.Str);
            string Mkey = Common.DecryptString(FileName, FrameSystemInfo.GetSystemInfoTable.S_FrameWorkInfo.S_RegsionGUID);
            string FilePath = Server.MapPath(string.Format("{0}/{1}",Common.UpLoadDir,Mkey));

            FileInfo file = new FileInfo(FilePath);
            if (file.Exists)
            {
                //����ļ���չ���Ƿ���ȷ
                if (!Common.Check_Char_Is(file.Extension.Substring(1).ToLower(), FrameSystemInfo.GetSystemInfoTable.S_SystemConfigData.C_UploadFileExt.ToLower()))
                {
                    Response.Write(string.Format("�ļ���չ��������ϵͳ����:{0}", FrameSystemInfo.GetSystemInfoTable.S_SystemConfigData.C_UploadFileExt));
                    return;
                }
                if (file.Length / 1024 > FrameSystemInfo.GetSystemInfoTable.S_SystemConfigData.C_UploadSizeKb)
                {
                    Response.Write(string.Format("�ļ�����ϵͳ�����С:{0}K", FrameSystemInfo.GetSystemInfoTable.S_SystemConfigData.C_UploadSizeKb));
                    return;
                }

                //����ļ�������Ϣ
                Response.Clear();
                Response.ContentType = Common.GetFileMIME(file.Extension);
                if (Response.ContentType == "application/unknown")
                {
                    Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(file.Name, System.Text.Encoding.UTF8));
                }
                byte[] img;
                using (BinaryReader br = new BinaryReader(file.OpenRead()))
                {
                    
                    img = br.ReadBytes(Convert.ToInt32(file.Length));
                }
                Response.BinaryWrite(img);
                Response.Flush();
            }
            else {
                Response.Write("�ļ�������!");
            }
        }
    }
}
