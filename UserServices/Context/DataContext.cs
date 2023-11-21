using Microsoft.EntityFrameworkCore;
using UserServices.Models;

namespace UserServices.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public  DbSet<Personas> Personas { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
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
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();
                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
                entity.Property(e => e.Password)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

        }
    }
}
