using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Entities;
using ONGWebAPI.Models;

namespace ONGWebAPI.Repository.EntityRepository
{
    public class EntityAnimalRepository : IAnimalRepository
    {
        private ONGContext DbONG;

        public EntityAnimalRepository(ONGContext DbONG)
        {
            this.DbONG = DbONG;
        }

        public void AdicionaNovoAnimal(Animal Animal)
        {

            DbONG.ChangeTracker.Clear();
            var user = DbONG.Usuarios?.Find(Animal.Usuario.Id);
            Animal.Usuario = user;
            DbONG.Entry(Animal).State = EntityState.Added;
            DbONG.SaveChanges();
        }

        public void ApagarAnimalPelaId(int Id)
        {
            DbONG.ChangeTracker.Clear();
            var animal = DbONG.Animais?.Find(Id);
            DbONG.Entry(animal).State = EntityState.Deleted;
            DbONG.SaveChanges();
        }

        public void AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            DbONG.ChangeTracker.Clear();
            Animal.Id = Id;
            DbONG.Entry(Animal).State = EntityState.Modified;
            if (Animal.Usuario != null) DbONG.Entry(Animal.Usuario).State = EntityState.Unchanged;
            DbONG.SaveChanges();
        }

        public Animal ExibirPelaID(int Id)
        {
            return DbONG.Animais?.Find(Id);
        }

        public List<Animal> ListarTodos()
        {
            return DbONG.Animais?.Include(x => x.Usuario).ToList();
        }

        public List<Animal> SolicitarPelaEspecie(Especie especie)
        {

            var animal = DbONG.Animais?.Where(t => t.Especie == especie);

            return animal.ToList();

        }
        public List<Animal> SolicitarPelaLocalizacao(Localizacao localizacao)
        {

            var animal = DbONG.Animais?.Where(t => t.Localizacao == localizacao);

            return animal.ToList();

        }

        public List<Animal> SolicitarPeloPorte(Porte porte)
        {

            var animal = DbONG.Animais?.Where(t => t.Porte == porte);

            return animal.ToList();

        }

        public List<Animal> SolicitarPeloSexo(Sexo sexo)
        {

            var animal = DbONG.Animais?.Where(t => t.Sexo == sexo);

            return animal.ToList();

        }

        public bool VerificarAnimal(int Id)
        {
            return DbONG.Animais.Any(Coluna => Coluna.Id == Id);
        }

        public List<Animal> ListarAnimaisUsuario(int Id)
        {
            var animal = DbONG.Animais?.Where(t => t.Usuario.Id == Id);

            return animal.ToList();
        }
        public List<Animal> ListarAnimaisDisponiveisUsuario(int Id)
        {
            var animal = ListarAnimaisUsuario(Id);
            return animal.Where(t => t.Disponibilidade == true).ToList();
        }

        public List<Animal> ListarAnimaisDoadosUsuario(int Id)
        {
            var animal = ListarAnimaisUsuario(Id);
            return animal.Where(t => t.Disponibilidade == false).ToList();
        }

        public List<Animal> ListarAnimaisDisponiveis()
        {
            return DbONG.Animais.Where(t => t.Disponibilidade == true).ToList();
        }

            public List<Animal> ListarAnimaisAdotados()
        {
            return DbONG.Animais.Where(t => t.Disponibilidade == false).ToList();
        }

      
    }
}
