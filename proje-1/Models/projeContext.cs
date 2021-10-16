using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace proje_1.Models
{
    public partial class projeContext : DbContext
    {
        public projeContext()
        {
        }

        public projeContext(DbContextOptions<projeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dadkhast> Dadkhast { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<SabtSana> SabtSana { get; set; }
        public virtual DbSet<Shekvaye> Shekvaye { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=proje;User Id=sa;Password=qazwsx1111");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dadkhast>(entity =>
            {
                entity.HasKey(e => e.CodeDadkhast);

                entity.Property(e => e.CodeDadkhast)
                    .HasColumnName("Code dadkhast")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdKhahan).HasColumnName("ID khahan");

                entity.Property(e => e.IdKhande).HasColumnName("ID khande");

                entity.Property(e => e.IdMotale).HasColumnName("ID motale");

                entity.Property(e => e.IdVakil).HasColumnName("ID vakil]");

                entity.Property(e => e.Idnamayande).HasColumnName("IDnamayande]");

                entity.Property(e => e.Khasteh)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Mojavez).IsRequired();

                entity.Property(e => e.SharheDadkhast)
                    .IsRequired()
                    .HasColumnName("Sharhe dadkhast");

                entity.HasOne(d => d.IdKhahanNavigation)
                    .WithMany(p => p.DadkhastIdKhahanNavigation)
                    .HasForeignKey(d => d.IdKhahan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast_Sana");

                entity.HasOne(d => d.IdKhandeNavigation)
                    .WithMany(p => p.DadkhastIdKhandeNavigation)
                    .HasForeignKey(d => d.IdKhande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast_Sana1");

                entity.HasOne(d => d.IdMotaleNavigation)
                    .WithMany(p => p.DadkhastIdMotaleNavigation)
                    .HasForeignKey(d => d.IdMotale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast_Sana2");

                entity.HasOne(d => d.IdVakilNavigation)
                    .WithMany(p => p.DadkhastIdVakilNavigation)
                    .HasForeignKey(d => d.IdVakil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast_Sana3");

                entity.HasOne(d => d.IdnamayandeNavigation)
                    .WithMany(p => p.DadkhastIdnamayandeNavigation)
                    .HasForeignKey(d => d.Idnamayande)
                    .HasConstraintName("FK_Dadkhast_Sana4");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("Job Type");

                entity.Property(e => e.JobTypeId).HasColumnName("Job Type ID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnName("Job Title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SabtSana>(entity =>
            {
                entity.ToTable("Sabt Sana");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasColumnName("Date of Birth")
                    .HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JobTypeId).HasColumnName("Job Type ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last name")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NationalCode)
                    .IsRequired()
                    .HasColumnName("National Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RandomCode).HasColumnName("Random code");

                entity.Property(e => e.ShomareSh)
                    .IsRequired()
                    .HasColumnName("Shomare SH")
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.SabtSana)
                    .HasForeignKey<SabtSana>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sabt Sana_Job Type");
            });

            modelBuilder.Entity<Shekvaye>(entity =>
            {
                entity.HasKey(e => e.CodeShekvaye);

                entity.Property(e => e.CodeShekvaye)
                    .HasColumnName("Code shekvaye")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdKhahan).HasColumnName("ID khahan");

                entity.Property(e => e.IdKhande).HasColumnName("ID khande");

                entity.Property(e => e.IdMatale).HasColumnName("ID matale");

                entity.Property(e => e.IdNamayandeh).HasColumnName("ID namayandeh");

                entity.Property(e => e.IdVakil).HasColumnName("ID vakil");

                entity.Property(e => e.Mojavez).IsRequired();

                entity.Property(e => e.Mozoe).IsRequired();

                entity.Property(e => e.SharhShekayat)
                    .IsRequired()
                    .HasColumnName("Sharh shekayat]");

                entity.HasOne(d => d.IdKhahanNavigation)
                    .WithMany(p => p.ShekvayeIdKhahanNavigation)
                    .HasForeignKey(d => d.IdKhahan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shekvaye_Sabt Sana");

                entity.HasOne(d => d.IdKhandeNavigation)
                    .WithMany(p => p.ShekvayeIdKhandeNavigation)
                    .HasForeignKey(d => d.IdKhande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shekvaye_Sabt Sana1");

                entity.HasOne(d => d.IdMataleNavigation)
                    .WithMany(p => p.ShekvayeIdMataleNavigation)
                    .HasForeignKey(d => d.IdMatale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shekvaye_Sabt Sana2");

                entity.HasOne(d => d.IdNamayandehNavigation)
                    .WithMany(p => p.ShekvayeIdNamayandehNavigation)
                    .HasForeignKey(d => d.IdNamayandeh)
                    .HasConstraintName("FK_Shekvaye_Sabt Sana3");

                entity.HasOne(d => d.IdVakilNavigation)
                    .WithMany(p => p.ShekvayeIdVakilNavigation)
                    .HasForeignKey(d => d.IdVakil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shekvaye_Sabt Sana4");
            });
        }
    }
}
