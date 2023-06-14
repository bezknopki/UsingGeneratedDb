using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UsingGeneratedDb;

public partial class ObjectivesDbContext : DbContext
{
    public ObjectivesDbContext()
    {
    }

    public ObjectivesDbContext(DbContextOptions<ObjectivesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Objective> Objectives { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ObjectivesDB; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
