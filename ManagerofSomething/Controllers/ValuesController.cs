﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ManagerofSomething.Models;
using System.Data;
using System.Data.Entity;

namespace ManagerofSomething.Controllers
{
   
    public class ValuesController : ApiController
    {
        UserContext db = new UserContext();

        public IEnumerable<User> GetUsers()
        {
            return db.Users;
        }

        public User GetUser(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        [HttpPost]
        public void CreateUser([FromBody]User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditUser(int id, [FromBody]User user)
        {
            if (id == user.Id)
            {
                db.Entry(user).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}