using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Entities;
using ONGWebAPI.Models;
using ONGWebAPI.Services;
using System.Runtime.InteropServices;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityAnimalRepository : IAnimalRepository
    {
        private ONGContextFactory DbONGFactory;

        public EntityAnimalRepository(ONGContextFactory DbONGFactory)
        {
            this.DbONGFactory = DbONGFactory;
        }

        public void AdicionaNovoAnimal(Animal Animal)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var user = DbONG.Usuarios?.Find(Animal.Usuario.Id);
                Animal.Usuario = user;
                DbONG.Entry(Animal).State = EntityState.Added;
                DbONG.SaveChanges();
            }
        }

        public void ApagarAnimalPelaId(int Id)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Find(Id);
                DbONG.Entry(animal).State = EntityState.Deleted;
                DbONG.SaveChanges();
            }
        }

        public void AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            using (var DbONG = DbONGFactory.create())
            {
                Animal.Id = Id;
                DbONG.Entry(Animal).State = EntityState.Modified;
                if (Animal.Usuario != null) DbONG.Entry(Animal.Usuario).State = EntityState.Unchanged;//só autualiza a tabela animal e não o usuario, e resolve erros de FK
                DbONG.SaveChanges();
            }
        }

        public Animal ExibirPelaID(int Id)
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Animais?.Find(Id);
        }

        public List<Animal> ListarTodos()
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Animais?.Include(x => x.Usuario).ToList();
        }

        public List<Animal> SolicitarPelaEspecie(Especie especie)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Especie == especie);

                return animal.ToList();
            }


        }
        public List<Animal> SolicitarPelaLocalizacao(Localizacao localizacao)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Localizacao == localizacao);

                return animal.ToList();
            }
        }

        public List<Animal> SolicitarPeloPorte(Porte porte)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Porte == porte);

                return animal.ToList();
            }


        }

        public List<Animal> SolicitarPeloSexo(Sexo sexo)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Sexo == sexo);

                return animal.ToList();
            }
        }

        public List<Animal> SolicitarPelaIdade(Idade idade)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Idade == idade);

                return animal.ToList();
            }
        }


         public bool VerificarAnimal(int Id)
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Animais.Any(Coluna => Coluna.Id == Id);
        }

        public List<Animal> ListarAnimaisUsuario(int Id)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = DbONG.Animais?.Where(t => t.Usuario.Id == Id);

                return animal.ToList();
            }
        }
        public async Task<List<Animal>> ListarAnimaisDisponiveisUsuario(int Id)
        {
            using (var DbONG = DbONGFactory.create())
            {
                var animal = ListarAnimaisUsuario(Id);
                return animal.Where(t => t.Disponibilidade == true).ToList();
            }
        }

        public async Task<List<Animal>> ListarAnimaisDoadosUsuario(int Id)
        {

            using (var DbONG = DbONGFactory.create())
            {
                var animal = ListarAnimaisUsuario(Id);
                return animal.Where(t => t.Disponibilidade == false).ToList();
            }
        }

        public List<Animal> ListarAnimaisDisponiveis()
        {
            using (var DbONG = DbONGFactory.create()) return DbONG.Animais.Where(t => t.Disponibilidade == true).ToList();
        }

        public List<Animal> ListarAnimaisAdotados()
        {
            using (var DbONG = DbONGFactory.create())  return DbONG.Animais.Where(t => t.Disponibilidade == false).ToList();
        }


    }
}
