import EstadosECidades from '/src/components/EstadosECidades/EstadosECidades.vue'
export default {
    components: {
        'EstadosECidades': EstadosECidades
    },
    data() {
        return {
            cadastroAnimal: {
                estado: "",
                cidade: "",
                usuario: {               
                    
                }     
            }
        };
    },
    methods: {
        postDoacaoAnimal() {
            const headers = new Headers();
            const token = localStorage.getItem("token")
            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }          
            this.cadastroAnimal.usuario.id = 0
            this.cadastroAnimal.disponibilidade = true

            let app = {
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${token}`
                },
                method: 'POST',
                body: JSON.stringify(this.cadastroAnimal),

            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal`, app).then(resp => {
                if (resp.ok) {
                    alert("Cadastrado com suceso!")
                }
                else {
                    alert("Erro ao tentar cadastrar!")
                }
            });

        }
    }

}