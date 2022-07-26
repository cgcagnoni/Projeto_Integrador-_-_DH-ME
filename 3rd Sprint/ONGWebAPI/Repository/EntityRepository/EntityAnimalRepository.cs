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
            var local = DbONG.Set<Animal>()
                .Local
                .FirstOrDefault(entry => entry.Id == Id);

            if (local != null)
            {
                // caso exista, remove do cache local para o entity coneguir atualizar
                DbONG.Entry(local).State = EntityState.Detached;
            }

            Animal.Id = Id;
            DbONG.Update(Animal);
            DbONG.SaveChanges(); ;
        }

        public Animal ExibirPelaID(int Id)
        {
            return DbONG.Animais?.Find(Id);
        }

        public List<Animal> ListarTodos()
        {
            return DbONG.Animais?.ToList();
        }

        public List<Animal> SolicitarPelaEspecie(string Especie)
        {
            var animal = DbONG.Animais?.Where(t => t.Especie == Especie);
               
            return animal.ToList();

        }

        public bool VerificarAnimal(int Id)
        {
            return DbONG.Animais.Any(Coluna => Coluna.Id == Id);
        }

    }
}
