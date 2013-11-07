using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Model
{
    /// <summary>
    /// 快捷回复
    /// </summary>
    public class QuickReply : RecordingTimeModelBase
    {
        #region 属性

        /// <summary>
        /// 所属用户的用户名（如为空则为公用）
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        public string Context { get; set; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 实例化一个新的快捷回复
        /// </summary>
        public QuickReply()
        {
        }

        /// <summary>
        /// 实例化一个新的快捷回复
        /// </summary>
        /// <param name="username">所属用户的存储指针（如为零则为公用）</param>
        /// <param name="context">正文</param>
        public QuickReply(string username, string context)
        {
            this.Username = username;
            this.Context = context;
        }

        #endregion
    }
}
