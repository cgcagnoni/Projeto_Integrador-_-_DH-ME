import router from '@/router'

export default {
    data() {
        return {            
            usuario: null,
            senha: null
        };
    },
    methods: {
        login() {
            fetch(`https://localhost:7288/api/Usuario/Login?username=${this.usuario}&senha=${this.senha}`).then(resp => {
                resp.text().then(token => {                    
                    localStorage.setItem("token", token)
                    router.push('/perfil')
                });
            }).catch(err => {
                alert('Usuario ou senha incorretos');
            });
        },
    },
}