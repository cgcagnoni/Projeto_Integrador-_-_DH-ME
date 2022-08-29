import router from '@/router'

export default {
    el: "#list-user",

    data() {

        return {
            usuarios: [],
            animais: [],
            animaisDisponiveis: [],
            animaisAdotados: [],
            idAnimal: {},
            idUsuario: {}
        }
    },

    methods: {

        listarTodosUsuarios() {

            const headers = new Headers();
            const token = localStorage.getItem("token")

            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'GET',
                headers
            }

            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario`, app).then(resp => {
                resp.json().then(usuario => {
                    this.usuarios = usuario;
                });
            })
        },
        parseEspecie(animais){
            animais.forEach(x => {
                if (x.especie == 0) x.especieDesc = "Gato"
                if (x.especie == 1) x.especieDesc = "Cachorro"
            })
        },
        listarTodosAnimais() {

            const headers = new Headers();
            const token = localStorage.getItem("token")

            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'GET',
                headers
            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal`, app).then(resp => {
                resp.json().then(animal => {
                    this.animais = animal;
                    this.parseEspecie(this.animais);
                });
            })
        },
        listarAnimaisDisponiveis() {
            let app = { method: 'GET' };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisDisponiveis`, app).then(resp => {
                resp.json().then(animaisDisp => {
                    this.animais = animaisDisp;
                    this.parseEspecie(this.animais);
                });
            })
        },
        listarAnimaisAdotados() {
            const headers = new Headers();
            const token = localStorage.getItem("token")

            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'GET',
                headers
            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisAdotados`, app).then(resp => {
                resp.json().then(animalAdot => {
                    this.animais = animalAdot;
                    this.parseEspecie(this.animais);                  
                });
            })
        },


        deletarAnimal() {
            const headers = new Headers();
            const token = localStorage.getItem("token")
            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'DELETE',
                headers
            };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/${this.idAnimal.id}`, app).then(resp => {
                if (resp.ok) {
                    alert("Deletado com sucesso!")
                }
                else {
                    alert("Animal nao encontrado!")
                }
            });
        },


        deletarUsuario() {
            const headers = new Headers();
            const token = localStorage.getItem("token")
            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'DELETE',
                headers
            };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/${this.idUsuario.id}`, app).then(resp => {
                if (resp.ok) {
                    alert("Deletado com sucesso!")
                }
                else {
                    alert("Animal n�o encontrado!")
                }
            });

        },

        alterarCadastroAnimal() {
            const token = localStorage.getItem("token")
            if (token){
                router.push('alteracao-animal')
            }
        },

        buscarAnimal() {
            router.push('./Busca')
        },

        alterarCadastroUsuario() {
           
            
        },

        alterarCadastroAdm() {
            const token = localStorage.getItem("token")
            if (token){
                router.push('./Alteracao-cadastro')
            }
        },

        arrecadacao() {
            router.push('./Arrecadacao')
        },

        beforeMount() {

            const token = localStorage.getItem("token")

            if (token) {
                this.listarTodosUsuarios();
                this.listarTodosAnimais();
                this.listarAnimaisDisponiveis();
                this.listarAnimaisAdotados();
            }
        }


    }
}
