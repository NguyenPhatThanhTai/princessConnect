using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Princess_Connect.Data.FrameWork
{
    public partial class Data : DbContext
    {
        public Data()
            : base("name=DBO")
        {
        }

        public virtual DbSet<SQL_Character> SQL_Character { get; set; }
        public virtual DbSet<SQL_Story> SQL_Story { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SQL_Character>()
                .Property(e => e.Character_Id)
                .IsUnicode(false);

            modelBuilder.Entity<SQL_Story>()
                .Property(e => e.Story_Id)
                .IsUnicode(false);

            modelBuilder.Entity<SQL_Story>()
                .Property(e => e.Character_Id)
                .IsUnicode(false);
        }
    }
}
