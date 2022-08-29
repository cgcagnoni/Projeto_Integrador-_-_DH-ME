import EstadosECidades from '/src/components/EstadosECidades/EstadosECidades.vue'
import router from '@/router'

export default {
    components: {
        'EstadosECidades': EstadosECidades
    },
    data() {
        return {
            estado: "",
            cidade: "",
            listaUF: [],
            listaCidades: {},
            cadastro: {}
        };
    },
    methods: {
        postCadastro() {
            let app = {
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                method: 'POST',
                body: JSON.stringify(this.cadastro),

            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario`, app).then(resp => {
                resp.json().then(cadastrousuario => {
                    if (resp.ok) {
                        this.cadastro = cadastrousuario;
                        router.push('/login');
                    } else {
                        alert('Erro ao tentar se cadastrar, confira seus dados');
                    }
                    
                });
            })
        },
    }
}
