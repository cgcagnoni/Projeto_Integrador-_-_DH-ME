export default {
    data() {
        return {
            animal: {}

        };
    },
    methods: {
        buscarAnimalId() {
            let app = {
                method: 'GET',
                
            };
            fetch(`https://localhost:7288/api/Animal/${this.$route.params.id}`, app).then(resp => {
                resp.json().then(animal => {
                   this.animal = animal;
                });
            })
        }
    },
    beforeMount(){
        this.buscarAnimalId();
    }
}