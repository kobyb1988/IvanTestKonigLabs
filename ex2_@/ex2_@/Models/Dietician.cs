namespace ex2__
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dietician")]
    public partial class Dietician
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int InfoId { get; set; }

        public virtual UserInfo UserInfo { get; set; }
    }
}
