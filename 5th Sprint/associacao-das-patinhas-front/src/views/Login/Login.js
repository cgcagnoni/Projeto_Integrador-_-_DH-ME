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
                resp.text().then(token => {
                    localStorage.setItem("token", token)
                    this.role();
                    //router.push('/perfil')
                });
            }).catch(err => {
                alert('Usuario ou senha incorretos');
            });
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