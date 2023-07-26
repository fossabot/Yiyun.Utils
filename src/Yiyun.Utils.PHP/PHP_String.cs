using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yiyun.Utils.PHP
{
    public partial class PHP
    {
        #region 返回相对应于 ascii 所指定的单个字符
        /// <summary>
        /// 返回相对应于 ascii 所指定的单个字符
        /// </summary>
        /// <param name="ascii"></param>
        /// <returns></returns>
        public static char Chr(int ascii)
        {
            //char result = (char)ascii;
            byte[] array = new byte[1];
            array[0] = (byte)(Convert.ToInt32(ascii)); //ASCII码强制转换二进制
            char result = Convert.ToString(System.Text.Encoding.ASCII.GetString(array))[0];

            return result;
        }
        #endregion

        #region 返回字符串中第一个字符的 ASCII 值
        /// <summary>
        /// 返回字符串中第一个字符的 ASCII 值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int Ord(string str)
        {
            int result = (int)str[0];
            return result;
        }
        #endregion
    }
}
