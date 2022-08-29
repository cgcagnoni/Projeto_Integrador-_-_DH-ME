import EstadosECidades from '/src/components/EstadosECidades/EstadosECidades.vue'


export default {
  components: {
    'EstadosECidades': EstadosECidades,
  },
  data() {
    return {
      alteracao: {
        estado: "",
        cidade: "",
        autorizacaoNotificacao: 0
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

      return {
        method: 'GET',
        headers
      };
    },
    parseJwt(token) {
      try {
        return JSON.parse(atob(token.split('.')[1]));
      } catch (e) {
        return null;
      }
    },
    buscarUsuarioPorId() {
      fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/0`, this.getOptions()).then(resp => {
        resp.json().then(usuario => {
          this.alteracao = usuario;
        });
      })
    },
    AlteracaoCadastro() {
      const headers = new Headers();
      const token = localStorage.getItem("token")
      if (token) {
        headers.append("Authorization", `Bearer ${token}`)
      }
      this.alteracao.username = "fixed"
      this.alteracao.password = "fixed"

      let app = {
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}`
        },
        method: 'PUT',
        body: JSON.stringify(this.alteracao),

      };

      fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/`, app).then(resp => {
        if(resp.ok){
          alert("Alterado com suceso!")
        }
        else{
          alert("Erro ao tentar alterar!")
        }
      })
    },
  },
  beforeMount() {
    const token = localStorage.getItem("token")

    if (token) {
      this.buscarUsuarioPorId();
    }
    else {
      router.push('/login')
    }

  }
}
