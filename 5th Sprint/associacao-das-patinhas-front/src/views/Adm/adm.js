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

            //Dados dos animais
            // {
            //     id: 0,
            //     nome: string,
            //     especie: 0,
            //     sexo: 0,
            //     idade: 0,
            //     porte: 0,
            //     descricao: string,
            //     vacinas: string,
            //     foto: string,
            //     localizacao: 0,
            //     microchip: true,
            //     castrado: true,
            //     deficiencia: true,
            //     disponibilidade: true,
            //     dataCadastro: 2022-08-25T14:56:52.718Z,
            //     usuario: {
            //       id: 0,
            //       username: string,
            //       role: 0,
            //       password: string,
            //       nome: string,
            //       sobrenome: string,
            //       localizacao: string,
            //       email: string,
            //       telefone: string,
            //       autorizacaoNotificacao: 0
            //     }
            //      listaAnimais: []
        };

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
            };

            fetch(`https://localhost:7288/api/Usuario`, app).then(resp => {
                resp.json().then(usuarios => {
                    this.listaUsuarios = usuarios;
                });
            })
        },

        // listarTodosAnimais() {

        //     const headers = new Headers();
        //     const token = localStorage.getItem("token")

        //     if (token) {
        //         headers.append("Authorization", `Bearer ${token}`)
        //     }

        //     let app = { method: 'GET',
        //        headers };

        //     fetch(`https://localhost:7288/api/Animal`, app).then(resp => {
        //         resp.json().then(animais => {
        //             this.listaAnimais=animais;
        //         });
        //      })
    },

    beforeMount() {

        const token = localStorage.getItem("token")

        if (token) {
            this.listarTodosUsuarios();
            // this.listarTodosAnimais();
        }
    }


}