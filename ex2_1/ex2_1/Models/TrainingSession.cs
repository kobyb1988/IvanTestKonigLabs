using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2_1.Models
{
    public class TrainingSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoachId { get; set; }

        public virtual User Users { get; set; }
        public virtual Coach Coach { get; set; }
    }
}