using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;
using System.Runtime.Serialization;

namespace Client.Service.DataContract
{
    /// <summary>
    /// 快速回复
    /// </summary>
    [DataContract]
    public class QuickReplyRsult
    {
        #region 属性

        /// <summary>
        /// 快速回复的存储指针
        /// </summary>
        [DataMember]
        public int QuickReplyId { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        [DataMember]
        public string Context { get; set; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 实例化一个新的快速回复
        /// </summary>
        /// <param name="qr">快速回复的数据封装</param>
        public QuickReplyRsult(QuickReply qr)
        {
            this.QuickReplyId = qr.Id;
            this.Context = qr.Context;
        }

        #endregion
    }
}
