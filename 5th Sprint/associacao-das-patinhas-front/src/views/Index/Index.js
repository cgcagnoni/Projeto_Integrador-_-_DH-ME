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
            fetch(`https://localhost:7288/api/Animal/ListarAnimaisDisponiveis`, app).then(resp => {
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