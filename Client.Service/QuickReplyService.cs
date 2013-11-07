using Client.Service.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;
using Client.Model.Manager;
using Client.Service.Reader;

namespace Client.Service
{
    public class QuickReplyService : IQuickReplyService
    {
        /// <summary>
        /// 获取快捷回复的列表
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>返回快捷回复的列表</returns>
        public List<QuickReplyRsult> GetQuickReplys(string username)
        {
            try
            {
                return QuickReplyReader.ReadQuickReplys(username);
            }
            catch (Exception ex)
            {
                return new List<QuickReplyRsult>();
            }
        }

        /// <summary>
        /// 添加快捷回复
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="context">正文</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        public QuickReplyRsult AddQuickReply(string username, string context)
        {
            try
            {
                var qr = QuickReplyManager.Create(username, context);
                return new QuickReplyRsult(qr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 修改快捷回复
        /// </summary>
        /// <param name="id">快捷回复的存储指针</param>
        /// <param name="context">正文</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        public bool UpdateQuickReply(int id, string context)
        {
            try
            {
                QuickReplyManager.Update(id, context);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 移除快捷回复
        /// </summary>
        /// <param name="id">快捷回复的存储指针</param>
        /// <returns>返回一个布尔值 标识操作是否成功</returns>
        public bool RemoveQuickReply(int id)
        {
            try
            {
                QuickReplyManager.Remove(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
