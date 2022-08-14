using ONGWebAPI.Entities;
using ONGWebAPI.Models;

namespace ONGWebAPI.Repository
{
    public interface IAnimalRepository
    {
        List<Animal> ListarTodos();
        List<Animal> SolicitarPelaEspecie(Especie especie);
        List<Animal> SolicitarPelaLocalizacao(Localizacao localizacao);
        List<Animal> SolicitarPeloPorte(Porte porte);
        List<Animal> SolicitarPeloSexo(Sexo sexo);
        Animal ExibirPelaID(int Id);
        void AdicionaNovoAnimal(Animal Animal);
        void ApagarAnimalPelaId(int Id);
        void AtualizarInformacoesPelaId(int Id, Animal Animal);
        bool VerificarAnimal(int Id);        
        List<Animal> ListarAnimaisUsuario(int Id);
        List<Animal> ListarAnimaisAdocao(bool adocao);
        List<Animal> ListarAnimaisDoacao();

    }
}
