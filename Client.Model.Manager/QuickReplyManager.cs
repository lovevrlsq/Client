using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Model.Manager
{
    /// <summary>
    /// 快捷回复的管理者对象
    /// </summary>
    public class QuickReplyManager
    {
        /// <summary>
        /// 创建一个新的快捷回复
        /// </summary>
        /// <param name="username">所属用户的用户名（如为空则为公用）</param>
        /// <param name="context">正文</param>
        public static void Create(string username, string context)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                QuickReply qr = new QuickReply(username, context);
                db.PondOfQuickReply.Add(qr);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改快捷回复的信息
        /// </summary>
        /// <param name="id">目标快捷回复的存储指针</param>
        /// <param name="context">正文</param>
        public static void Update(int id, string context)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                QuickReply qr = db.PondOfQuickReply.FirstOrDefault(x => x.Id == id);
                if (qr == null) { return; }
                qr.Context = context;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// 移除快捷回复
        /// </summary>
        /// <param name="id">存储指针</param>
        public static void Remove(int id)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                QuickReply qr = db.PondOfQuickReply.FirstOrDefault(x => x.Id == id);
                if (qr == null) { return; }
                db.PondOfQuickReply.Remove(qr);
                db.SaveChanges();
            }
        }
    }
}
