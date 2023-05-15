using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoReact.Models;

public partial class GyfContext : DbContext
{
    public GyfContext()
    {
    }

    public GyfContext(DbContextOptions<GyfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("producto");

            entity.Property(e => e.Categoria)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("categoria");
            entity.Property(e => e.FechaCarga)
                .HasColumnType("date")
                .HasColumnName("fechaCarga");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
