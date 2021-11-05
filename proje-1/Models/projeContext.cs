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

        public virtual DbSet<Dadkhast1> Dadkhast1 { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<SabtSana1> SabtSana1 { get; set; }
        public virtual DbSet<Shekvaye1> Shekvaye1 { get; set; }

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
            modelBuilder.Entity<Dadkhast1>(entity =>
            {
                entity.HasKey(e => e.CodeDadkhast);

                entity.Property(e => e.CodeDadkhast)
                    .HasColumnName("Code dadkhast")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Khasteh).IsRequired();

                entity.Property(e => e.Mojavez).IsRequired();

                entity.Property(e => e.NationalcodeKhahan)
                    .IsRequired()
                    .HasColumnName("Nationalcode KHahan")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeKhande)
                    .IsRequired()
                    .HasColumnName("Nationalcode KHande")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeMotale)
                    .IsRequired()
                    .HasColumnName("Nationalcode motale")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeNamayande)
                    .IsRequired()
                    .HasColumnName("Nationalcode namayande")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeVakil)
                    .IsRequired()
                    .HasColumnName("Nationalcode vakil")
                    .HasMaxLength(10);

                entity.Property(e => e.SharheDadkhast)
                    .IsRequired()
                    .HasColumnName("Sharhe dadkhast");

                entity.HasOne(d => d.NationalcodeKhahanNavigation)
                    .WithMany(p => p.Dadkhast1NationalcodeKhahanNavigation)
                    .HasForeignKey(d => d.NationalcodeKhahan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast1_SabtSana1");

                entity.HasOne(d => d.NationalcodeKhandeNavigation)
                    .WithMany(p => p.Dadkhast1NationalcodeKhandeNavigation)
                    .HasForeignKey(d => d.NationalcodeKhande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast1_SabtSana11");

                entity.HasOne(d => d.NationalcodeMotaleNavigation)
                    .WithMany(p => p.Dadkhast1NationalcodeMotaleNavigation)
                    .HasForeignKey(d => d.NationalcodeMotale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast1_SabtSana12");

                entity.HasOne(d => d.NationalcodeNamayandeNavigation)
                    .WithMany(p => p.Dadkhast1NationalcodeNamayandeNavigation)
                    .HasForeignKey(d => d.NationalcodeNamayande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast1_SabtSana14");

                entity.HasOne(d => d.NationalcodeVakilNavigation)
                    .WithMany(p => p.Dadkhast1NationalcodeVakilNavigation)
                    .HasForeignKey(d => d.NationalcodeVakil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dadkhast1_SabtSana15");
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

            modelBuilder.Entity<SabtSana1>(entity =>
            {
                entity.HasKey(e => e.NationalCode);

                entity.Property(e => e.NationalCode)
                    .HasColumnName("National code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth)
                    .IsRequired()
                    .HasColumnName("Date of Birth")
                    .HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasColumnName("job")
                    .HasMaxLength(100);

                entity.Property(e => e.JobTypeId).HasColumnName("Job Type ID");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NamePdar)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RandomCode)
                    .HasColumnName("Random Code")
                    .HasMaxLength(5);

                entity.Property(e => e.ShomareSh)
                    .IsRequired()
                    .HasColumnName("SHomare SH")
                    .HasMaxLength(10);

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.SabtSana1)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SabtSana1_Job Type");
            });

            modelBuilder.Entity<Shekvaye1>(entity =>
            {
                entity.HasKey(e => e.CodeShekvaye);

                entity.ToTable("SHekvaye1");

                entity.Property(e => e.CodeShekvaye)
                    .HasColumnName("Code shekvaye")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Mojavez).IsRequired();

                entity.Property(e => e.Mozoe).IsRequired();

                entity.Property(e => e.NationalcodeKhahan)
                    .IsRequired()
                    .HasColumnName("Nationalcode KHahan")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeKhande)
                    .IsRequired()
                    .HasColumnName("[Nationalcode KHande")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeMotale)
                    .IsRequired()
                    .HasColumnName("Nationalcode motale")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeNamayande)
                    .IsRequired()
                    .HasColumnName("Nationalcode namayande")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalcodeVakil)
                    .IsRequired()
                    .HasColumnName("Nationalcode vakil")
                    .HasMaxLength(10);

                entity.Property(e => e.SharhShekayat)
                    .IsRequired()
                    .HasColumnName("Sharh shekayat");

                entity.HasOne(d => d.NationalcodeKhahanNavigation)
                    .WithMany(p => p.Shekvaye1NationalcodeKhahanNavigation)
                    .HasForeignKey(d => d.NationalcodeKhahan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHekvaye1_SabtSana1");

                entity.HasOne(d => d.NationalcodeKhandeNavigation)
                    .WithMany(p => p.Shekvaye1NationalcodeKhandeNavigation)
                    .HasForeignKey(d => d.NationalcodeKhande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHekvaye1_SabtSana11");

                entity.HasOne(d => d.NationalcodeMotaleNavigation)
                    .WithMany(p => p.Shekvaye1NationalcodeMotaleNavigation)
                    .HasForeignKey(d => d.NationalcodeMotale)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHekvaye1_SabtSana12");

                entity.HasOne(d => d.NationalcodeNamayandeNavigation)
                    .WithMany(p => p.Shekvaye1NationalcodeNamayandeNavigation)
                    .HasForeignKey(d => d.NationalcodeNamayande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHekvaye1_SabtSana13");

                entity.HasOne(d => d.NationalcodeVakilNavigation)
                    .WithMany(p => p.Shekvaye1NationalcodeVakilNavigation)
                    .HasForeignKey(d => d.NationalcodeVakil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SHekvaye1_SabtSana14");
            });
        }
    }
}
