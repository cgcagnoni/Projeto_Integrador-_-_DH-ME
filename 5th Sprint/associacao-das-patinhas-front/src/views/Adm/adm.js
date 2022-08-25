export default {
    el: "#list-user",

    data() {
        return {
            id: 0,
            username: null,
            role: 0,
            password: null,
            nome: null,
            sobrenome: null,
            localizacao: null,
            email: null,
            telefone: null,
            autorizacaoNotificacao: 0,
            listaUsuarios: [

            ]
        };

    },

    methods: {

        listarTodosUsuarios() {
            
            const headers = new Headers();
            const token = localStorage.getItem("token")

            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = { method: 'GET',
               headers };

            fetch(`https://localhost:7288/api/Usuario`, app).then(resp => {
                resp.json().then(usuarios => {
                    this.listaUsuarios=usuarios;
                });
             })
        },

        beforeMount() {   
            
            const token = localStorage.getItem("token")

            if (token) {            
                this.listarTodosUsuarios();
            }             
       }   
       

    }
    
}