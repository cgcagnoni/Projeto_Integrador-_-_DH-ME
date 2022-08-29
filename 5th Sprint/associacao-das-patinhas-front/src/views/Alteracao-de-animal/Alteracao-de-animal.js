import EstadosECidades from '/src/components/EstadosECidades/EstadosECidades.vue'


export default {
    components: {
        'EstadosECidades': EstadosECidades
    },
    data() {
        return {
            alteracaoAnimal: {
                estado: "",
                cidade: "",
                usuario: {}
            }
        };
    },
    methods: {
        buscarAnimalPorId() {
            let app = {
                method: 'GET',

            };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/${this.$route.params.id}`, app).then(resp => {
                resp.json().then(animal => {
                    this.alteracaoAnimal = animal;
                });
            })
        },
        salvarAlteracaoAnimal() {
            const headers = new Headers();
            const token = localStorage.getItem("token")
            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }
            this.alteracaoAnimal.usuario.id = 0
            this.alteracaoAnimal.id = 0

            let app = {
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${token}`
                },
                method: 'PUT',
                body: JSON.stringify(this.alteracaoAnimal),

            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/${this.$route.params.id}`, app).then(resp => {
                if (resp.ok) {
                    alert("Alterado com suceso!")
                }
                else {
                    alert("Erro ao tentar alterar!")
                }
            })
        }

    },
    beforeMount(){
        this.buscarAnimalPorId()
    }
}