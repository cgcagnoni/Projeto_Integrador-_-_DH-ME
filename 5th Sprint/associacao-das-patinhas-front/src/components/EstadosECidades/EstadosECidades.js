export default {
    data() {
        return {
            estado: "",
            cidade: "",
            listaUF: [],
            listaCidades: {}       
        };
    },
    methods: {
        getListaUF(){
            let app = {
                method: 'GET',
                
            };
            fetch(`https://servicodados.ibge.gov.br/api/v1/localidades/municipios`, app).then(resp => {
                resp.json().then(cidades => {
                   this.listaUF = cidades
                                    .map(x => x.microrregiao.mesorregiao.UF.sigla)
                                    .reduce((acumulador, item) => {
                                        if (!acumulador.find(x => x == item)) acumulador.push(item);
                                        return acumulador;
                                    }, [])
                                    .sort();

                    this.listaCidades = this.listaUF
                                                .map(x => { //item para cada linha da lista UF
                                                    return {
                                                        key: x,
                                                        cidades: cidades
                                                                    .filter(y => y.microrregiao.mesorregiao.UF.sigla == x)
                                                                    .map(x => x.nome)
                                                                    .sort()
                                                    }
                                                })
                                                .reduce((x, y) => {
                                                    x[y.key] = y.cidades;
                                                    return x
                                                }, {})

                //    for(let i =0; i < estados.length; i++) {
                //         let adicionar = true;
                //         for (let j = 0; j < this.listaUF.length; j++) {
                //             if (this.listaUF[j] == estados[i].microrregiao.mesorregiao.UF.sigla) {
                //                 adicionar = false;
                //             }
                //         }
                //         if (adicionar) {
                //             this.listaUF.push(estados[i].microrregiao.mesorregiao.UF.sigla)
                //         }
                //    }
                });
            })
        }
    },
    beforeMount(){
        this.getListaUF();
    }
}