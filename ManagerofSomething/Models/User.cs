using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagerofSomething.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}