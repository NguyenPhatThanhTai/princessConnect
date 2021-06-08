namespace Princess_Connect.Data.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SQL_Story
    {
        [Key]
        [StringLength(8)]
        public string Story_Id { get; set; }

        [StringLength(8)]
        public string Character_Id { get; set; }

        public string Character_Story { get; set; }

        [StringLength(100)]
        public string Character_Picture_Story { get; set; }

        public virtual SQL_Character SQL_Character { get; set; }
    }
}
