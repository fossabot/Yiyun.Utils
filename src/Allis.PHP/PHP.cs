using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Allis.PHP
{
    public partial class PHP
    {
        #region 指定字符串是否存在于字符串数组中
        /// <summary>
        /// 指定字符串是否存在于字符串数组中
        /// </summary>
        /// <param name="search">要搜索的字符串</param>
        /// <param name="array">字符串数组</param>
        /// <param name="ignoreCase">是否忽略大小写</param>
        /// <returns></returns>
        public static bool in_array(string search, string[] array, bool ignoreCase = false)
        {
            if (ignoreCase)
            {
                foreach (string str in array)
                {
                    if (str.Equals(search, StringComparison.InvariantCultureIgnoreCase)) return true;
                }
            }
            else
            {
                foreach (string str in array)
                {
                    if (str.Equals(search)) return true;
                }
            }
            return false;
        }
        #endregion

        #region 将一个字典内的所有值均UrlEncode，且拼接为Url格式参数
        /// <summary>
        /// 普通类型： 将一个字典内的所有值均UrlEncode，且拼接为Url格式参数
        /// 普通类型： key=value&  返回拼接后的字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string http_build_query(Dictionary<string, object> data)
        {
            if (data != null && data.Count == 0)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            // 标记是否是 简单类型: key1=value1&key2=value2&
            foreach (string key in data.Keys)
            {
                // .NET Standard2.0 的 System.Web.HttpUtility 依赖于 Microsoft.AspNetCore.WebUtilities
                sb.Append(key + "=" + System.Web.HttpUtility.UrlEncode(data[key].ToString()) + "&");
            }
            string rtn = sb.ToString();

            return rtn;
        }
        #endregion
    }
}
