namespace Princess_Connect.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Liking = new HashSet<Liking>();
            Saved = new HashSet<Saved>();
        }

        [StringLength(8)]
        public string UserId { get; set; }

        public bool Role { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Avatar { get; set; }

        public bool? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liking> Liking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saved> Saved { get; set; }
    }
}
