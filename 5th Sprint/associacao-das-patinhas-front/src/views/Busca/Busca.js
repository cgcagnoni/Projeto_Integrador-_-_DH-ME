export default {
  data() {
    return {
      animais: [],
      especie: null,
      sexo: null,
      idade: null,
      porte: null,
      animaisFiltrados: []

    };
  },
  methods: {
    buscarAnimais() {
      //Buscando da API
      fetch(`https://localhost:7288/api/Animais/`).then(response => {
          response.json().then(animais => {
              this.animais = animais;
          })
      })

      // Testando sem acesso à API
      // this.animais = [
      //   {
      //     id: 0,
      //     nome: "string",
      //     especie: 1,
      //     sexo: 0,
      //     idade: 0,
      //     porte: 0,
      //     descricao: 'string',
      //     vacinas: 'string',
      //     foto: 'string',
      //     localizacao: 'string',
      //     cidade: 'string',
      //     microchip: true,
      //     castrado: true,
      //     deficiencia: true,
      //     disponibilidade: true,
      //     dataCadastro: '2022-08-27T15:32:13.759Z',

      //   }

      // ]

    },

    filtrarAnimais() {
      this.animaisFiltrados = this.animais.filter(this.filtrar);
      console.log(this.animaisFiltrados)
    },

    filtrar(animal) {
      if (animal.especie != this.especie) {
        return false
      }
      if (animal.sexo != this.sexo) {
        return false
      }
      if (animal.porte != this.porte) {
        return false
      }
      if (animal.idade != this.idade) {
        return false
      }

      return true

    }

  },


  beforeMount() {
    this.buscarAnimais();
  }
}