using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManagerofSomething.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User { Nickname = "John", Date = "2016-05-02", Time = "23:42"  });
            db.Users.Add(new User { Nickname = "Michael", Date = "2016-07-03", Time = "17:32" });
            db.Users.Add(new User { Nickname = "Squedral", Date = "2016-07-28", Time = "12:32" });

            base.Seed(db);
        }
    }
}