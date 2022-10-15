using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjetoOng_EF_DF
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=OngPetDF")
        {
        }

        public virtual DbSet<Adotante> Adotante { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adotante>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Adotante>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.Familia)
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.Raca)
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.Situacao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .HasMany(e => e.Adotante)
                .WithRequired(e => e.Pet)
                .HasForeignKey(e => e.ChipPet)
                .WillCascadeOnDelete(false);
        }
    }
}
