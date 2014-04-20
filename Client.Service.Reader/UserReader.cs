using Client.Service.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;
using System.Security.Cryptography;

namespace Client.Service.Reader
{
    /// <summary>
    /// 用户令牌的阅读者对象
    /// </summary>
    public class UserReader
    {
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static bool Login(string username, string password)
        {
            using (MainDatadbmlDataContext db = new MainDatadbmlDataContext())
            {
                return db.zwg_Author
                    .Any(x => x.Username == username && x.Password == EncryptByMd5(password));
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">需要进行md5加密的对象</param>
        /// <returns>返回一个md5加密后的32位字符串</returns>
        static string EncryptByMd5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] temp = System.Text.Encoding.Default.GetBytes(input);
            byte[] data = md5.ComputeHash(temp);
            md5.Clear();

            string result = "";
            data.ToList().ForEach(x =>
            {
                result += x.ToString("x").PadLeft(2, '0');
            });
            return result;
        }
    }
}
