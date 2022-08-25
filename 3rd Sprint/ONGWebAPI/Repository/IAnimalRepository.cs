﻿using ONGWebAPI.Entities;
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
        List<Animal> SolicitarPelaIdade(Idade idade);
        Animal ExibirPelaID(int Id);
        void AdicionaNovoAnimal(Animal Animal);
        void ApagarAnimalPelaId(int Id);
        void AtualizarInformacoesPelaId(int Id, Animal Animal);
        bool VerificarAnimal(int Id);        
        List<Animal> ListarAnimaisUsuario(int Id);
        Task<List<Animal>>ListarAnimaisDisponiveisUsuario(int Id);
        Task<List<Animal>> ListarAnimaisDoadosUsuario(int Id);
        List<Animal> ListarAnimaisDisponiveis();
        List<Animal> ListarAnimaisAdotados();       

    }
}
