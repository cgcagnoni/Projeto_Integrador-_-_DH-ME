using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ONGWebAPI.Entities;
using ONGWebAPI.Models;
using System.Diagnostics;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class ONGContext : DbContext
    {

        private bool inMemory;

        public DbSet<Animal>? Animais { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<InteresseAdocao>? InteresseAdocao { get; set; }


        public ONGContext(bool inMemory)
        {
            this.inMemory = inMemory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder Configurar)
        {

            if (inMemory)
            {
                Configurar.UseInMemoryDatabase("ong");
            }
            else
            {
                string credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ONG;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                Configurar.UseSqlServer(credencial);
                Configurar.EnableSensitiveDataLogging();
                Configurar.LogTo((log) => Debug.WriteLine(log));               
            }
        }

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Animal>(Tabela =>
            {
                Tabela.Property(p => p.Especie)
                    .HasConversion(
                        p => p.ToString(),
                        p => (Especie)Enum.Parse(typeof(Especie), p)
                    );
                Tabela.Property(p => p.Sexo)
                   .HasConversion(
                       p => p.ToString(),
                       p => (Sexo)Enum.Parse(typeof(Sexo), p)
                   );
                Tabela.Property(p => p.Porte)
                   .HasConversion(
                       p => p.ToString(),
                       p => (Porte)Enum.Parse(typeof(Porte), p)
                   );
                Tabela.Property(p => p.Localizacao)
                   .HasConversion(
                       p => p.ToString(),
                       p => (Localizacao)Enum.Parse(typeof(Localizacao), p)
                   );
                Tabela.Property(p => p.Idade)
                   .HasConversion(
                       p => p.ToString(),
                       p => (Idade)Enum.Parse(typeof(Idade), p)
                   );

                Tabela.HasKey(Propriedade => Propriedade.Id);
                Tabela.HasOne(Propriedade => Propriedade.Usuario)
                    .WithMany(Propriedade => Propriedade.Animais)
                    .HasForeignKey(Propriedade => Propriedade.UsuarioId);
                Tabela.Navigation(Propriedade => Propriedade.Usuario).AutoInclude();
            });

            Modelagem.Entity<Usuario>(Tabela =>
            {
                // Tabela.HasMany(Propriedade => Propriedade.Animais);
                Tabela.Property(p => p.Username)
                    .IsUnicode(true);

                Tabela.Property(p => p.AutorizacaoNotificacao)
                  .HasConversion(
                      p => p.ToString(),
                      p => (AutorizacaoNotificacao)Enum.Parse(typeof(AutorizacaoNotificacao), p)
                  );
            });            

            Modelagem.Entity<InteresseAdocao>(Tabela =>
            {
                Tabela.HasOne(Propriedade => Propriedade.Animal)
                    .WithMany()
                    .HasForeignKey(Propriedade => Propriedade.AnimalId);

                Tabela.Navigation(Propriedade => Propriedade.Animal).AutoInclude();
            });




        }

    }
}
