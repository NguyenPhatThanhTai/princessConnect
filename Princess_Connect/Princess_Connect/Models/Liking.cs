namespace Princess_Connect.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Liking")]
    public partial class Liking
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string CharId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string LikeId { get; set; }

        public virtual Characters Characters { get; set; }

        public virtual User User { get; set; }
    }
}
