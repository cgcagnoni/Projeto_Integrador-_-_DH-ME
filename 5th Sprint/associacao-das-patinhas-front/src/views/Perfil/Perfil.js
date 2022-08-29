import router from '@/router'

export default {
    data() {
        return {
            id: 0,
            nome: null,
            email: null,
            telefone: null,
            localizacao: null,
            animaisDisponiveisUsuario: [],
            animaisAdotados:[],
            interesseAdocao:[]
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
            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/${this.id}`, this.getOptions()).then(resp => {
                resp.json().then(usuario => {
                    this.nome = usuario.nome;
                    this.email = usuario.email;
                    this.telefone = usuario.telefone;
                    this.localizacao = usuario.localizacao
                    this.id = usuario.id;
                });
             })
        },
        ListarAnimaisDisponiveisUsuario() {
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisDisponiveisUsuario`, this.getOptions()).then(resp => {
                resp.json().then(animaisDisponiveisUsuario => {
                    this.animaisDisponiveisUsuario = animaisDisponiveisUsuario;
                })
            })
        },
        listarAnimaisAdotados() {
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisDoadosUsuario`, this.getOptions()).then(resp => {
                resp.json().then(animaisAdotados => {
                    this.animaisAdotados = animaisAdotados;
                })
            })
        },   
        listarInteressadosEmAdotar() {

            fetch(`${import.meta.env.VITE_BASE_URL}api/InteresseAdocao/InteressadosPorUsuario`, this.getOptions()).then(resp => {
                resp.json().then(interesse => {
                    this.interesseAdocao = interesse;
                })
            })
        },         
    },
    
    beforeMount() {
        const token = localStorage.getItem("token")

        if (token) {            
            this.buscarUsuarioPorId();
            this.ListarAnimaisDisponiveisUsuario();
            this.listarAnimaisAdotados();
            this.listarInteressadosEmAdotar();
        }
        else{
            router.push('/login')
        }
        
    }
}