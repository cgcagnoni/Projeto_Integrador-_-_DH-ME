import EstadosECidades from '/src/components/EstadosECidades/EstadosECidades.vue'

      
export default {
  components: {
    'EstadosECidades': EstadosECidades,
  },
  data() {
    return {
      id: 0,
      nome: null,
      email: null,
      telefone: null,
      localizacao: null,
      alteracao: {
      }
    };
  },
  methods: {

    salvarAlteracaoUser() {

      
      alert("Cadastro atualizado!")
    },
    getOptions() {
      const headers = new Headers();
      const token = localStorage.getItem("token")

      if (token) {
          headers.append("Authorization", `Bearer ${token}`)
      }

      return { method: 'GET',
         headers };
  },
  buscarUsuarioPorId() {
      fetch(`https://localhost:7288/api/Usuario/${this.id}`, this.getOptions()).then(resp => {
          resp.json().then(usuario => {
              this.nome = usuario.nome;
              this.email = usuario.email;
              this.telefone = usuario.telefone;
              this.localizacao = usuario.localizacao
              this.id = usuario.id;
          });
       })
  },
    AlteracaoCadastro() {
      let app = {
          headers: {
              'Accept': 'application/json',
              'Content-Type': 'application/json'
          },
          method: 'PUT',
          body: JSON.stringify(this.alteracao),

      };

      fetch(`https://localhost:7288/api/Usuario/${this.id}`, app).then(resp => {
          resp.json().then(alteracaousuario => {
              this.alteracao = alteracaousuario;
          });
      })
  },
  },
  beforeMount() {
    const token = localStorage.getItem("token")

    if (token) {            
        this.buscarUsuarioPorId();
    }
    else{
        router.push('/login')
    }
    
}
}
