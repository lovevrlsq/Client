using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;

namespace Client.Service.Reader
{
    /// <summary>
    /// 图片的阅读者对象
    /// </summary>
    public class PicReader
    {
        /// <summary>
        /// 读取图片的实体
        /// </summary>
        /// <param name="token">令牌</param>
        /// <returns>返回图片实体的byte数组</returns>
        public byte[] ReadPic(string token)
        {
            using (Model2DataContext db = new Model2DataContext())
            {
                Picture pic = db.PondOfPicture.First(x => x.Token == token);
                return pic.Content;
            }
        }
    }
}
