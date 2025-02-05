using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApproach.Models;

public partial class CapgeminiDbContext : DbContext
{
    public CapgeminiDbContext()
    {
    }

    public CapgeminiDbContext(DbContextOptions<CapgeminiDbContext> options)
        : base(options)
    {
    }

    
    public virtual DbSet<DeptTable> DeptTables { get; set; }

    public virtual DbSet<EmpTable> EmpTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=PHANI-PC\\SQLEXPRESS;Database=CapgeminiDb;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<DeptTable>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__DeptTabl__014881AE9A63BB3F");

            entity.ToTable("DeptTable");

            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpTable>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__EmpTable__AF2DBB99A05968AB");

            entity.ToTable("EmpTable");

            entity.Property(e => e.EmpId).ValueGeneratedNever();
            entity.Property(e => e.EmpAddress).HasMaxLength(50);
            entity.Property(e => e.EmpName).HasMaxLength(50);
            entity.Property(e => e.EmpSalary).HasColumnType("money");

            entity.HasOne(d => d.Dept).WithMany(p => p.EmpTables)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK__EmpTable__DeptId__5AEE82B9");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
