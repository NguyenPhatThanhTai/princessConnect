namespace Princess_Connect.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [StringLength(8)]
        public string FeedId { get; set; }

        [Required]
        [StringLength(8)]
        public string CharId { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }

        [Required]
        [StringLength(100)]
        public string GuestName { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Created { get; set; }

        public virtual Characters Characters { get; set; }
    }
}
