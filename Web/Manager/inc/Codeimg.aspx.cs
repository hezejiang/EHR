using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Drawing.Drawing2D;

using System.Drawing;
using System.Drawing.Imaging;

namespace FrameWork.web.inc
{
    public partial class Codeimg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //���ú�������֤������ͼƬ
            this.CreateCheckCodeImage(GenerateCheckCode());
        }

        private string GenerateCheckCode()
        {  //������λ������ַ���
            int number;
            string checkCode = String.Empty;


            for (int i = 0; i < rnd.Next(5,8); i++)
            {
                number = rnd.Next(0,26);
                checkCode += codestr.Substring(number, 1);
            }
            Session["CheckCode"] = checkCode;//���ڿͻ���У����Ƚ�

            return checkCode;
        }

        private void CreateCheckCodeImage(string checkCode)
        {  //����֤������ͼƬ��ʾ
            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;

            System.Drawing.Bitmap image = new System.Drawing.Bitmap(imgWidth, imgheight);
            Graphics g = Graphics.FromImage(image);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            try
            {
                //������������� 
                Random random = new Random();

                //���ͼƬ����ɫ 
                g.Clear(Color.White);

                StringFormat sf = new StringFormat(StringFormatFlags.NoClip);
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;


                //List<FontStyle> a = GetRndColor(checkCode.Length);
                FontStyle fontcolor= GetColorList[random.Next(0,GetColorList.Count)];
                //������
                int charX, CharY, charSize, charFontSize;

                //�Ƴ����
                int delwidth = 0;
                //��ת�Ƕ�
                int rotatefont = 0;
                Matrix mat = new Matrix();
                for (int i = 0; i < checkCode.Length; i++)
                {
                    if (i != 0)
                    {
                        delwidth = rnd.Next(fontsize/4, fontsize / 3);
                    }
                    rotatefont = random.Next(-30, 30);
                    charFontSize = rnd.Next(fontsize-5, fontsize);
                    charSize = (imgWidth - 5) / checkCode.Length;
                    charX = charSize * (i)+rnd.Next(2,15);
                    CharY = rnd.Next(1, imgheight - (charFontSize))-7;

                    mat.RotateAt(rotatefont, new PointF(charX, fontsize));
                    g.Transform = mat;

                    g.DrawString(checkCode[i].ToString(), new System.Drawing.Font("garamond", charFontSize, (System.Drawing.FontStyle.Bold)), new SolidBrush(fontcolor.FontColor), charX - delwidth, CharY);

                    mat.RotateAt(rotatefont*-1, new PointF(charX, fontsize));
                    g.Transform = mat;
                }

                g.Transform = new Matrix();

                //��ͼƬ�ı߿��� 
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Response.ClearContent();
                Response.ContentType = "image/x-png";
                Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }



        /// <summary>
        /// ��ȡ��ɫ�б�
        /// </summary>
        private List<FontStyle> GetColorList
        {
            get {
                List<FontStyle> a = new List<FontStyle>(15);
                a.Add(new FontStyle(Color.Red, fontsize));
                a.Add(new FontStyle(Color.Green, fontsize));
                a.Add(new FontStyle(Color.Blue, fontsize));
                a.Add(new FontStyle(Color.DarkOrange, fontsize));
                a.Add(new FontStyle(Color.Brown, fontsize));
                a.Add(new FontStyle(Color.DarkOliveGreen, fontsize));
                a.Add(new FontStyle(Color.Gold, fontsize));
                a.Add(new FontStyle(Color.DarkSlateBlue, fontsize));
                a.Add(new FontStyle(Color.GreenYellow, fontsize));
                a.Add(new FontStyle(Color.HotPink, fontsize));
                a.Add(new FontStyle(Color.Khaki, fontsize));
                a.Add(new FontStyle(Color.LightBlue, fontsize));
                a.Add(new FontStyle(Color.PaleGreen, fontsize));
                a.Add(new FontStyle(Color.SteelBlue, fontsize));
                a.Add(new FontStyle(Color.Tomato, fontsize));
                return a;
            }
        }

        /// <summary>
        /// ��������ɫ
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private List<FontStyle> GetRndColor(int num)
        {
            List<FontStyle> l = new List<FontStyle>(num);
            
            for (int i = 0; i < num; i++)
            {
                l.Add(GetColorList[rnd.Next(0, GetColorList.Count)]);
            }
            return l;

        }

        Random rnd = new Random();


        int imgWidth = 138;
        int imgheight = 35;
        int fontsize = 25;

        string codestr = "abcdefghijklimnopqrstuvwxyz";
        
    }
    

    /// <summary>
    /// ������
    /// </summary>
    public class FontStyle
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="FontColor">��ɫ</param>
        /// <param name="FontSize">�����С</param>
        public FontStyle(Color FontColor, int FontSize)
        {
            _FontColor = FontColor;
            _FontSize = FontSize;
        }
        #region "Private Variables"
        private Color _FontColor;
        private int _FontSize;
        #endregion

        #region "Public Variables"
        /// <summary>
        /// ������ɫ
        /// </summary>
        public Color FontColor
        {
            get {
                return _FontColor;
            }
            set {
                _FontColor = value;
            }
        }
        /// <summary>
        /// �����С
        /// </summary>
        public int FontSize
        {
            get {
                return _FontSize;
            }
            set {
                _FontSize = value;
            }
        }
        #endregion
    }
}