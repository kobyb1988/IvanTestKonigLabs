using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2_1.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}