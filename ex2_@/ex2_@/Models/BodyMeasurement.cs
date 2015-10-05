namespace ex2__
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BodyMeasurement")]
    public partial class BodyMeasurement
    {
        public int Id { get; set; }

        [Required]
        public string Info { get; set; }

        public int ClientId { get; set; }

        public virtual User User { get; set; }
    }
}
