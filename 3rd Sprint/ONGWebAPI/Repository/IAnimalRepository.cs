using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public interface IAnimalRepository
    {
        List<Animal> ListarTodos();
        List<Animal> SolicitarPelaEspecie(string Especie);
        Animal ExibirPelaID(int Id);
        void AdicionaNovoAnimal(Animal Animal);
        void ApagarAnimalPelaId(int Id);
        void AtualizarInformacoesPelaId(int Id, Animal Animal);
        bool VerificarAnimal(int Id);
        List<Animal> ListarAnimaisUsuario(int Id);

    }
}
