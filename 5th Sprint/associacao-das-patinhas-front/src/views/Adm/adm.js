import router from '@/router'

export default {
    el: "#list-user",

    data() {
        
        return {            
            usuarios: [],

            animais: []
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

            fetch(`https://localhost:7288/api/Usuario`, app).then(resp => {
                resp.json().then(usuario => {
                    this.usuarios = usuario;
                });
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

            fetch(`https://localhost:7288/api/Animal`, app).then(resp => {
                resp.json().then(animal => {
                    this.animais = animal;
                });
            })
        },

        
        deletarAnimal() {


            alert("Deletado com sucesso.")
        },
          
        
        deletarUsuario() {

            
            alert("Deletado com sucesso.")
        },

        alterarCadastroAnimal(){
            router.push('./Alteracao-animal')
        },

        buscarAnimal(){
            router.push('./Busca')
        },

        alterarCadastroUsuario(){
            router.push('./Alteracao-cadastro')
        },

        alterarCadastroAdm(){
            router.push('./Alteracao-cadastro')
        },

        arrecadacao(){
            router.push('./Arrecadacao')
        },        

        beforeMount() {

            const token = localStorage.getItem("token")

            if (token) {
                this.listarTodosUsuarios();
                this.listarTodosAnimais();
            }
        }


    }
}
