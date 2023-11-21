using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbContext.Models;

public partial class UsuariosContext : DbContext
{
    public UsuariosContext()
    {
    }

    public UsuariosContext(DbContextOptions<UsuariosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-LQP5L7TD\\LOCALHOST2;Database=Usuarios;Trusted_Connection=True; Encrypt=False;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
