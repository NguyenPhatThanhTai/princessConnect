namespace Princess_Connect.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skill")]
    public partial class Skill
    {
        [StringLength(8)]
        public string SkillId { get; set; }

        [Required]
        [StringLength(8)]
        public string CharId { get; set; }

        [StringLength(300)]
        public string UB { get; set; }

        [StringLength(300)]
        public string Skill1 { get; set; }

        [StringLength(300)]
        public string Skill2 { get; set; }

        [StringLength(300)]
        public string ExSkill { get; set; }

        [StringLength(300)]
        public string EnSkill { get; set; }

        [StringLength(300)]
        public string EnUB { get; set; }

        public virtual Characters Characters { get; set; }
    }
}
