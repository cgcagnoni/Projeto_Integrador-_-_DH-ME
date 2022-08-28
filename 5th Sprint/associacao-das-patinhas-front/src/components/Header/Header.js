import router from '@/router'

export default {
    data() {
        return {
            logged: false
        };
    },
    methods: {
        logout() {
            localStorage.removeItem("token");
            this.login();
        },
        isLogged() {
            if (localStorage.getItem("token")) {
                this.logged = true;
            }
            else {
                this.logged = false;
            }
        },
        login() {
            router.push('/login');
        }

    },
    beforeMount(){
        this.isLogged();
    }

}