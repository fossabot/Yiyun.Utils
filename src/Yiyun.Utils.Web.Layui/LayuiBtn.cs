using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yiyun.Utils.Web.Layui
{
    #region 按钮主题
    /// <summary>
    /// 按钮主题
    /// </summary>
    public enum BtnTheme
    {
        /// <summary>
        /// 默认
        /// </summary>
        Default,
        /// <summary>
        /// 原始
        /// </summary>
        Primary,
        /// <summary>
        /// 百搭
        /// </summary>
        Normal,
        /// <summary>
        /// 暖色
        /// </summary>
        Warm,
        /// <summary>
        /// 警告
        /// </summary>
        Danger,
        /// <summary>
        /// 禁用
        /// </summary>
        Disabled
    }
    #endregion

    /// <summary>
    /// Layui按钮
    /// </summary>
    public class LayuiBtn
    {
        #region BtnTag
        private static string BtnTag(string className, string value, params object[] htmlAttributes)
        {
            string tag = string.Format("<button class=\"layui-btn{0}\">{1}</button>", className == null ? "" : " " + className, value);

            return tag;
        }
        #endregion

        #region ActionLinkTag
        private static string ActionLinkTag(string className, string value, string url, params object[] htmlAttributes)
        {
            string tag = string.Format("<a href=\"{0}\" class=\"layui-btn{1}\">{2}</a>", url, className == null ? "" : " " + className, value);

            return tag;
        }
        #endregion

        #region ActionLink
        public static string ActionLink(BtnTheme btnTheme, string value, string url, params object[] htmlAttributes)
        {
            string tag = string.Empty;

            return tag;
        }
        #endregion

        #region Button
        public static string Button(BtnTheme btnTheme, string value, params object[] htmlAttributes)
        {
            string tag = string.Empty;

            return tag;
        }
        #endregion
    }
}
