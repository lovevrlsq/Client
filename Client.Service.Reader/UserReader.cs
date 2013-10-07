﻿using Client.Service.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.Model;

namespace Client.Service.Reader
{
    public class UserReader
    {
        public static List<UserInfoResult> ReadFriends(string username)
        {
            using (MainDatadbmlDataContext db = new MainDatadbmlDataContext())
            {
                List<UserInfoResult> result = new List<UserInfoResult>();

                UserInfo u = db.UserInfo.First(x => x.UserID == username);
                UserInfo tu = db.UserInfo.FirstOrDefault(x => x.ID.ToString() == u.ParentUID);
                if (tu != null)
                {
                    UserInfoResult t1 = new UserInfoResult(tu.UserID, UserInfoType.上级);
                    result.Add(t1);
                }

                db.UserInfo.Where(x => x.ParentUID == u.ID.ToString())
                    .ToList().ForEach(x =>
                        {
                            UserInfoResult t = new UserInfoResult(x.UserID, UserInfoType.下级);
                            result.Add(t);
                        });

                return result;
            }
        }
    }
}
