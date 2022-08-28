import router from '@/router'

export default {
    data() {
        return {
            animaisDisponiveis: []
        };
    },
    methods: {
        listarAnimaisDisponiveis() {
            let app = { method: 'GET' };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/ListarAnimaisDisponiveis`, app).then(resp => {
                resp.json().then(animaisDisponiveis => {
                    this.animaisDisponiveis = animaisDisponiveis;
                });
            })
        }
    },
    beforeMount() {
        this.listarAnimaisDisponiveis();
    }
}