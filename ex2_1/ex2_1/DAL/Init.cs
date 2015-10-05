using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ex2_1.Models;

namespace ex2_1.DAL
{
    public class Init : DropCreateDatabaseIfModelChanges<GContext>
    {
        protected override void Seed(GContext context)
        {
            var userinfos = new List<UserInfo>
            {
                new UserInfo {Login = "login", Passwd = "pwd" }
            };
            userinfos.ForEach(s => context.UserInfos.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}