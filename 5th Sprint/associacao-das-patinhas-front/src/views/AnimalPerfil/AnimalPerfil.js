export default {
    data() {
        return {
            animal: {},
            interesse: {},
            imagem: []
        };
    },
    methods: {
        buscarAnimalId() {
            let app = {
                method: 'GET',

            };
            fetch(`${import.meta.env.VITE_BASE_URL}api/Animal/${this.$route.params.id}`, app).then(resp => {
                resp.json().then(animal => {
                    this.interesse.animal = animal;

                    this.animal = animal;
                    if (this.animal.sexo == 0) this.animal.sexoDesc = "Macho"
                    if (this.animal.sexo == 1) this.animal.sexoDesc = "Fêmea"
                    if (this.animal.porte == 0) this.animal.porteDesc = "Pequeno"
                    if (this.animal.porte == 1) this.animal.porteDesc = "Médio"
                    if (this.animal.porte == 2) this.animal.porteDesc = "Grande"
                    if (this.animal.idade == 0) this.animal.idadeDesc = "Filhote"
                    if (this.animal.idade == 1) this.animal.idadeDesc = "Adulto"
                    if (this.animal.idade == 2) this.animal.idadeDesc = "Idoso"                    
                    if(this.animal.microchip == true) this.animal.microchipDesc = "Sim"
                    if(this.animal.microchip == false) this.animal.microchipDesc = "Não"
                    if(this.animal.castrado == true) this.animal.castradoDesc = "Sim"
                    if(this.animal.castrado == false) this.animal.castradoDesc = "Não"
                    if(this.animal.deficiencia == true) this.animal.deficienciaDesc = "Sim"
                    if(this.animal.deficiencia == false) this.animal.deficienciaDesc = "Não"
                    if (animal.especie == 0) this.imagem = 'https://cataas.com/cat' 
                });
            })
        },
        postInteresseAdocacao() {
            let app = {
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                method: 'POST',
                body: JSON.stringify(this.interesse),
                
            };
            
            fetch(`${import.meta.env.VITE_BASE_URL}api/InteresseAdocao`, app).then(resp => {
                resp.json().then(interesseAdocao => {
                    this.interesse = interesseAdocao;
                    
    
                });
            })
        },    
    },
    beforeMount() {
        this.buscarAnimalId();
    
    }
}