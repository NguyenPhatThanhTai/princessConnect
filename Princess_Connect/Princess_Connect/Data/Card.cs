namespace Princess_Connect.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Card")]
    public partial class Card
    {
        [StringLength(8)]
        public string CardId { get; set; }

        [Required]
        [StringLength(8)]
        public string CharId { get; set; }

        [Column("Card")]
        [StringLength(100)]
        public string Card1 { get; set; }

        public virtual Characters Characters { get; set; }
    }
}
