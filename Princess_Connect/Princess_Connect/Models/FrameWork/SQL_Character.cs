namespace Princess_Connect.Data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SQL_Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SQL_Character()
        {
            SQL_Story = new HashSet<SQL_Story>();
        }

        [Key]
        [StringLength(8)]
        public string Character_Id { get; set; }

        [StringLength(100)]
        public string Character_Name { get; set; }

        [StringLength(100)]
        public string Character_Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SQL_Story> SQL_Story { get; set; }
    }
}
