import router from '@/router'

export default {
    data() {
        return {
            id: 0,
            usuario: null,
            senha: null,
            user: {}
        };
    },
    methods: {
        login() {
            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/Login?username=${this.usuario}&senha=${this.senha}`).then(resp => {
                if (resp.ok) {
                    resp.text().then(token => {
                        localStorage.setItem("token", token)
                        this.role();
                    });
                } else {
                    alert('Erro ao tentar realizar login');    
                }
                
            }).catch(err => {
                alert('Usuario ou senha incorretos');
            });
        },
        cadastrese() {
            router.push('/cadastro');
        },
        role() {
            const headers = new Headers();
            const token = localStorage.getItem("token")

            if (token) {
                headers.append("Authorization", `Bearer ${token}`)
            }

            let app = {
                method: 'GET',
                headers
            };

            fetch(`${import.meta.env.VITE_BASE_URL}api/Usuario/${this.id}`, app).then(resp => {
                resp.json().then(usuario => {
                    this.user = usuario;
                    if (this.user.role == 0) router.push('/adm')
                    if (this.user.role == 1) router.push('/perfil')
                });
            })
        },
    },
}