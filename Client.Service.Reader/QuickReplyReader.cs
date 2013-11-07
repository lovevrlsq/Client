using Client.Service.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;

namespace Client.Service.Reader
{
    /// <summary>
    /// 快捷回复的阅读者对象
    /// </summary>
    public class QuickReplyReader
    {
        /// <summary>
        /// 读取快捷回复列表
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>返回快捷回复列表</returns>
        public static List<QuickReplyRsult> ReadQuickReplys(string username)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                List<QuickReplyRsult> result = new List<QuickReplyRsult>();
                var t1 = db.PondOfQuickReply.Where(x => x.Username == "").OrderBy(x => x.Id).ToList()
                    .ConvertAll(x => new QuickReplyRsult(x));
                var t2 = db.PondOfQuickReply.Where(x => x.Username == username).OrderBy(x => x.Id).ToList()
                    .ConvertAll(x => new QuickReplyRsult(x));
                result.AddRange(t1);
                result.AddRange(t2);

                return result;
            }
        }
    }
}
