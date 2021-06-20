namespace Princess_Connect.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Characters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Characters()
        {
            Card = new HashSet<Card>();
            Feedback = new HashSet<Feedback>();
            Skill = new HashSet<Skill>();
            User = new HashSet<User>();
            User1 = new HashSet<User>();
        }

        [Key]
        [StringLength(8)]
        public string CharId { get; set; }

        [Required]
        [StringLength(8)]
        public string GuildId { get; set; }

        [Required]
        [StringLength(100)]
        public string CharName { get; set; }

        [StringLength(10)]
        public string Height { get; set; }

        [StringLength(10)]
        public string Weight { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(10)]
        public string BloodType { get; set; }

        [StringLength(50)]
        public string Race { get; set; }

        [StringLength(200)]
        public string Hobbies { get; set; }

        [StringLength(100)]
        public string VA { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Detail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Released { get; set; }

        public int? Likes { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Card> Card { get; set; }

        public virtual Guild Guild { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedback { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skill> Skill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }
    }
}
