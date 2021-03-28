using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhoneBook_DrinkCompany.Models
{
    public partial class PhoneBookContext : DbContext
    {
        public PhoneBookContext()
        {
        }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("PK__Clientes__71ABD08798A3971C");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cpnj)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneCelular)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneComercial)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneResidencial)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
