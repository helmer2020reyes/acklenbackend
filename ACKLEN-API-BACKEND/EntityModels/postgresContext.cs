using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ACKLEN_API_BACKEND.EntityModels
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=melacomotoda1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasAnnotation("Relational:Collation", "Spanish_Mexico.1252");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("book");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("author");

                entity.Property(e => e.Coverurl)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("coverurl");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("date")
                    .HasColumnName("dateadded");

                entity.Property(e => e.Dateread)
                    .HasColumnType("date")
                    .HasColumnName("dateread");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("description");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("genre");

                entity.Property(e => e.Isread).HasColumnName("isread");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
