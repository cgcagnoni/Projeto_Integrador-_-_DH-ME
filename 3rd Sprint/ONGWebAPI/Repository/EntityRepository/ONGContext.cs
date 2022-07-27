using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class ONGContext : DbContext
    {

        private bool inMemory;

        public DbSet<Animal>? Animais { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }


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
               
            }
        }
        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Animal>(Tabela =>
            {
                Tabela.HasKey(Propriedade => Propriedade.Id);
                // Tabela.Navigation(Propriedade => Propriedade.Usuario).AutoInclude();
            });

            Modelagem.Entity<Usuario>(Tabela =>
            {
                Tabela.HasMany(Propriedade => Propriedade.Animais);
            });

      
        }

    }
}
