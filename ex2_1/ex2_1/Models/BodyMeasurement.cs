using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2_1.Models
{
    public class BodyMeasurement
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public int ClientId { get; set; }

        public virtual User Users { get; set; }
    }
}