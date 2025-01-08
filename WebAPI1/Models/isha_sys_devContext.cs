using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPI1.Entities;

namespace WebAPI1.Models;

public partial class isha_sys_devContext : DbContext
{
    public isha_sys_devContext(DbContextOptions<isha_sys_devContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<EnterpriseName> EnterpriseNames { get; set; }
    public virtual DbSet<CompanyName> CompanyNames { get; set; }
    public virtual DbSet<FactoryName> FactoryNames { get; set; }
    public virtual DbSet<UserInfoName> UserInfoNames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
        // EnterpriseName 與 CompanyName 關聯設定
        modelBuilder.Entity<EnterpriseName>()
            .HasMany(e => e.CompanyNames)
            .WithOne(c => c.Enterprise)
            .HasForeignKey(c => c.EnterpriseId)
            .OnDelete(DeleteBehavior.NoAction);

        // CompanyName 與 FactoryName 關聯設定
        modelBuilder.Entity<CompanyName>()
            .HasMany(c => c.FactoryNames)
            .WithOne(f => f.Company)
            .HasForeignKey(f => f.CompanyId)
            .OnDelete(DeleteBehavior.NoAction);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
