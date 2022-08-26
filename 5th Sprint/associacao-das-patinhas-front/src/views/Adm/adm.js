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
            
        },
          
        
        deletarUsuario(){

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
