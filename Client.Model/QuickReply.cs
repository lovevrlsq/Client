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
        /// 所属用户的存储指针（如为0则为公用）
        /// </summary>
        public virtual int OwnerId { get; set; }

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
        /// <param name="ownerId">所属用户的存储指针（如为零则为公用）</param>
        /// <param name="context">正文</param>
        public QuickReply(int ownerId, string context)
        {
            this.OwnerId = ownerId;
            this.Context = context;
        }

        #endregion
    }
}
