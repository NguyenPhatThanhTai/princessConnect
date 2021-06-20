using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Princess_Connect.Data
{
    public partial class DAO : DbContext
    {
        public DAO()
            : base("name=DAO")
        {
        }

        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Guild> Guild { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .Property(e => e.CardId)
                .IsUnicode(false);

            modelBuilder.Entity<Card>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<Card>()
                .Property(e => e.Card1)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.GuildId)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.BloodType)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.Card)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.Feedback)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.Skill)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.User)
                .WithMany(e => e.Characters)
                .Map(m => m.ToTable("Liking").MapLeftKey("CharId").MapRightKey("UserId"));

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.User1)
                .WithMany(e => e.Characters1)
                .Map(m => m.ToTable("Saved").MapLeftKey("CharId").MapRightKey("UserId"));

            modelBuilder.Entity<Feedback>()
                .Property(e => e.FeedId)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<Guild>()
                .Property(e => e.GuildId)
                .IsUnicode(false);

            modelBuilder.Entity<Guild>()
                .HasMany(e => e.Characters)
                .WithRequired(e => e.Guild)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.SkillId)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
