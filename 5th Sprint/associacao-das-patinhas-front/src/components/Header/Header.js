import router from '@/router'

export default {
    data() {
        return {
        };
    },
    methods: {
        logout() {
            localStorage.removeItem("token");
            
            router.push('/login');
            
          }
    }
}