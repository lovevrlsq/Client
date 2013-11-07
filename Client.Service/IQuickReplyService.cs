using Client.Service.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Client.Service
{
    /// <summary>
    /// 定义快捷服务的数据服务
    /// </summary>
    [ServiceContract]
    public interface IQuickReplyService
    {
        /// <summary>
        /// 获取快捷回复的列表
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>返回快捷回复的列表</returns>
        [OperationContract]
        List<QuickReplyRsult> GetQuickReplys(string username);

        /// <summary>
        /// 添加快捷回复
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="context">正文</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        [OperationContract]
        bool AddQuickReply(string username, string context);

        /// <summary>
        /// 修改快捷回复
        /// </summary>
        /// <param name="id">快捷回复的存储指针</param>
        /// <param name="context">正文</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        [OperationContract]
        bool UpdateQuickReply(int id, string context);

        /// <summary>
        /// 移除快捷回复
        /// </summary>
        /// <param name="id">快捷回复的存储指针</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        [OperationContract]
        bool RemoveQuickReply(int id);
    }
}
