namespace Princess_Connect.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Guild")]
    public partial class Guild
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Guild()
        {
            Characters = new HashSet<Characters>();
        }

        [StringLength(8)]
        public string GuildId { get; set; }

        [Required]
        [StringLength(50)]
        public string GuildName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Characters> Characters { get; set; }
    }
}
