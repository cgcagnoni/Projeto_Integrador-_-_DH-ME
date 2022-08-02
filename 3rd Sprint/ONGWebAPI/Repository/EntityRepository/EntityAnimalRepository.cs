using Microsoft.EntityFrameworkCore;
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
            DbONG.Animais?.Add(Animal);
            DbONG.SaveChanges();
        }

        public void ApagarAnimalPelaId(int Id)
        {
            var user = DbONG.Animais?.Find(Id);
            DbONG.Animais?.Remove(user);
            DbONG.SaveChanges();
        }

        public void AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            DbONG.ChangeTracker.Clear();
            Animal.Id = Id;
            //DbONG.Entry(Animal).State = EntityState.Modified;
            DbONG.Update(Animal);
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

        public bool VerificarAnimal(int Id)
        {
            return DbONG.Animais.Any(Coluna => Coluna.Id == Id);
        }

        public List<Animal> ListarAnimaisUsuario(int Id)
        {
            var animal = DbONG.Animais?.Where(t => t.Usuario.Id == Id);

            return animal.ToList();

        }

        public List<Animal> ListarAnimaisAdocao(bool adocao)
        {                           
            if (adocao == true)
            {
                return DbONG.Animais.Where(t => t.Disponibilidade == true).ToList();
            }
            else
            {               
                return DbONG.Animais.Where(t => t.Disponibilidade == false).ToList();
            }
           
        }
        public List<Animal> ListarAnimaisDoacao()
        {        
            return DbONG.Animais.ToList();

        }
    }
}
