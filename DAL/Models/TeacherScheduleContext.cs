using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class TeacherScheduleContext : DbContext
{
    public TeacherScheduleContext()
    {
    }

    public TeacherScheduleContext(DbContextOptions<TeacherScheduleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=desktop-dckkug1;Database=TeacherSchedule;Trusted_Connection=True;trustserverCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK_Classes");

            entity.Property(e => e.ClassId).ValueGeneratedNever();
            entity.Property(e => e.ClassName).HasMaxLength(10);

            entity.HasOne(d => d.School).WithMany(p => p.Groups)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Groups_Schools");

            entity.HasOne(d => d.Topic).WithMany(p => p.Groups)
                .HasForeignKey(d => d.TopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Classes_Topics");
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.Property(e => e.SchoolId).ValueGeneratedNever();
            entity.Property(e => e.SchoolName).HasMaxLength(20);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.Property(e => e.SubjectId).ValueGeneratedNever();
            entity.Property(e => e.SubjectName).HasMaxLength(20);

            entity.HasOne(d => d.User).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Subjects_Users");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.Property(e => e.TopicId).ValueGeneratedNever();
            entity.Property(e => e.TeachingDurationTeachingDurationDurationDurationDuration).HasColumnName("TeachingDuration\r\nTeaching_Duration\r\nDuration\r\nduration\r\nduration]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]");
            entity.Property(e => e.TopicName).HasMaxLength(10);

            entity.HasOne(d => d.Subject).WithMany(p => p.Topics)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Topics_Subjects");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.LoginName, "IX_Users").IsUnique();

            entity.Property(e => e.ALevel).HasColumnName("A_Level");
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.LoginName).HasMaxLength(20);
            entity.Property(e => e.Mail)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
