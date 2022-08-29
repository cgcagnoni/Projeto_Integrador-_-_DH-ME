export default {
  data() {
    return {
      animais: [],
      especie: null,
      sexo: null,
      idade: null,
      porte: null,
      animaisFiltrados: [],
      Gatos: []

    };
  },
  methods: {
    buscarAnimais() {
      //Buscando da API
      fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisDisponiveis`).then(response => {
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

    ListarGatos() {
      fetch(`https://localhost:7288/api/Animal/PorEspecie?especie=0`, this.getOptions()).then(resp => {
          resp.json().then(Gatos => {
              this.Gatos = Gatos;
          })
      })
  },
  },


  beforeMount() {
    this.buscarAnimais();
  }
}