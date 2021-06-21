using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Princess_Connect.Models
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
        public virtual DbSet<Liking> Liking { get; set; }
        public virtual DbSet<Saved> Saved { get; set; }
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
                .HasMany(e => e.Liking)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.Saved)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Characters>()
                .HasMany(e => e.Skill)
                .WithRequired(e => e.Characters)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<Liking>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Liking>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<Liking>()
                .Property(e => e.LikeId)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.CharId)
                .IsUnicode(false);

            modelBuilder.Entity<Saved>()
                .Property(e => e.SaveId)
                .IsFixedLength();

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

            modelBuilder.Entity<User>()
                .HasMany(e => e.Liking)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Saved)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
