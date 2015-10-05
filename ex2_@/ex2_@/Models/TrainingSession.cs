namespace ex2__
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrainingSession")]
    public partial class TrainingSession
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CoachId { get; set; }

        public virtual Coach Coach { get; set; }

        public virtual User User { get; set; }
    }
}
