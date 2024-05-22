using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSystem.DataEntity;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CityDetail> CityDetails { get; set; }

    public virtual DbSet<Employeedetail> Employeedetails { get; set; }

    public virtual DbSet<StateDetail> StateDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-SLQ88AV;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CityDetail>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.Property(e => e.CityName).HasMaxLength(50);
        });

        modelBuilder.Entity<Employeedetail>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.Property(e => e.Contact).HasMaxLength(20);
            entity.Property(e => e.Dob).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .HasColumnName("FName");
            entity.Property(e => e.Gender)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .HasColumnName("LName");
        });

        modelBuilder.Entity<StateDetail>(entity =>
        {
            entity.HasKey(e => e.StateId);

            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
