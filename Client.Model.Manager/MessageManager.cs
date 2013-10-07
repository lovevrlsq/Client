﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;

namespace Client.Model.Manager
{
    /// <summary>
    /// 聊天信息的管理者对象
    /// </summary>
    public class MessageManager
    {
        /// <summary>
        /// 发送一个新的聊天信息
        /// </summary>
        /// <param name="_from">发件人</param>
        /// <param name="_to">收件人</param>
        /// <param name="content">正文</param>
        /// <param name="isOfficial">一个布尔值 表示是否官方信息</param>
        /// <returns>返回被创建的聊天信息的封装</returns>
        public static Message Send(string _from, string _to, string content, bool isOfficial = false)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                Message message = new Message(_from, _to, content, isOfficial);
                db.Messages.Add(message);
                db.SaveChanges();

                return message;
            }
        }

        /// <summary>
        /// 声明已经阅读了某条
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="username"></param>
        public static void Read(int messageId, string username)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                string tokne = string.Format("[{0}]", username);
                Message message = db.Messages.FirstOrDefault(x => x.Id == messageId);
                if (message == null) { throw new Exception("消息不存在"); }
                if (message.Readed.Contains(tokne)) { return; }
                message.Readed += tokne;
                db.SaveChanges();
            }
        }
    }
}
