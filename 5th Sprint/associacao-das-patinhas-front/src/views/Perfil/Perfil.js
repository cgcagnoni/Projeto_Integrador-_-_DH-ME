import router from '@/router'

export default {
    data() {
        return {
            id: 0,
            nome: null,
            email: null,
            telefone: null,
            localizacao: null,
            animaisDisponiveis: [],
            animaisAdotados:[]
        };
    },
    methods: {
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
                    this.localizacao = usuario.localizacao;
                });
             })//.catch(err => {
            //     alert('Usuario ou senha incorretos');
            // });
        },
        listarAnimaisDisponiveis() {
            fetch(`https://localhost:7288/api/Animal/ListarAnimaisDisponiveisUsuario`, this.getOptions()).then(resp => {
                resp.json().then(animaisDisponiveis => {
                    this.animaisDisponiveis = animaisDisponiveis;
                })
            })
        },
        listarAnimaisAdotados() {
            fetch(`https://localhost:7288/api/Animal/ListarAnimaisDoadosUsuario`, this.getOptions()).then(resp => {
                resp.json().then(animaisAdotados => {
                    this.animaisAdotados = animaisAdotados;
                })
            })
        },        

    },
    beforeMount() {
        const token = localStorage.getItem("token")

        if (token) {            
            this.buscarUsuarioPorId();
            this.listarAnimaisDisponiveis();
            this.listarAnimaisAdotados();
        }
        else{
            router.push('/login')
        }
        
    }
}