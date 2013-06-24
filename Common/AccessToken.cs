using System;
using System.Collections.Generic;
using System.Text;

namespace Maticsoft.Common
{
    public class AccessToken
    {
        /// <summary>
        /// 产生随机数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GenerateRandomCode(int number)
        {
            string checkCode = String.Empty;
            string Vchar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            string[] VcArray = Vchar.Split(',');
            Random rand = new Random();
            for (int i = 1; i < number + 1; i++)
            {
                int t = rand.Next(VcArray.Length);
                checkCode += VcArray[t];
            }
            return checkCode;
        }
    }
}
