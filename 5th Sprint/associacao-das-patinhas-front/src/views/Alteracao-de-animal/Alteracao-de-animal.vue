<template>

    <div class="row" id="profilecontent">
        <div class="col-4">
            <div id="listaCadastro" class="list-group">
                <RouterLink class="list-group-item list-group-item-action" to="/perfil">Meu cadastro</RouterLink>
                <RouterLink class="list-group-item list-group-item-action" to="/perfil">Minhas adoções</RouterLink>
                <RouterLink class="list-group-item list-group-item-action" to="/perfil">Minha doações</RouterLink>
                <RouterLink class="list-group-item list-group-item-action" to="/perfil">Segurança</RouterLink>
                <RouterLink class="list-group-item list-group-item-action" to="/alteracao-cadastro">Alterar dados
                </RouterLink>
            </div>
        </div>

        <div class="col-8">
            <div data-bs-spy="scroll" data-bs-target="#listaCadastro" data-bs-smooth-scroll="true"
                class="scrollspy-example" tabindex="0">
                <form>
                    <div class="input-group row">
                        <div class="input-box">
                            <label for="nome">Nome :</label>
                            <div>
                                <input required type="text" v-model="alteracaoAnimal.nome" name="body"
                                    placeholder="Digite o nome do seu pet" />
                            </div>
                        </div>
                        <div class="input-select_porte">
                            <label for="idade">Idade :</label>
                            <div>
                                <select v-model="alteracaoAnimal.idade" name="idade" id="idade">
                                    <option value="" block>Selecione a idade</option>
                                    <option :value="0">Filhote</option>
                                    <option :value="1">Adulto</option>
                                    <option :value="2">Idoso</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class="input-select_porte">
                        <label for="porte">Porte :</label>
                        <div>
                            <select v-model="alteracaoAnimal.porte" name="porte" id="porte">
                                <option value="" block>Selecione o porte</option>
                                <option :value="0">Pequeno</option>
                                <option :value="1">Médio</option>
                                <option :value="2">Grande</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-select_especie">
                        <label for="especie">Especie :</label>
                        <div>
                            <select v-model="alteracaoAnimal.especie" name="especie" id="especie">
                                <option value="" block>Selecione a especie</option>
                                <option :value="0">Gato</option>
                                <option :value="1">Cachorro</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-select_sexo">
                        <label for="sexo">Sexo :</label>
                        <div>
                            <select v-model="alteracaoAnimal.sexo" name="sexo" id="sexo">
                                <option value="" block>Selecione o sexo</option>
                                <option :value="0">Macho</option>
                                <option :value="1">Fêmea</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-box">
                        <label for="vacina">
                            Seu pet é vacinado?Quais?</label>
                        <input v-model="alteracaoAnimal.vacinas" type="text" name="vacina" />
                    </div>

                    <div class="input-select_microchip">
                        <label for="microchip">Seu pet possui Microchip?</label>
                        <div>
                            <select v-model="alteracaoAnimal.microchip" name="microchip" id="microchip">
                                <option value="" block>Selecione a opcção</option>
                                <option :value="true">Sim</option>
                                <option :value="false">Não</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-select_castrado">
                        <label for="castrado">Seu pet possui Castrado?</label>
                        <div>
                            <select v-model="alteracaoAnimal.castrado" name="castrado" id="castrado">
                                <option value="" block>Selecione a opcção</option>
                                <option :value="true">Sim</option>
                                <option :value="false">Não</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-select_deficiencia">
                        <label for="deficiencia">Seu pet possui alguma deficiencia?</label>
                        <div>
                            <select v-model="alteracaoAnimal.deficiencia" name="deficiencia" id="deficiencia">
                                <option value="" block>Selecione a opcção</option>
                                <option :value="true">Sim</option>
                                <option :value="false">Não</option>
                            </select>
                        </div>
                    </div>

                    <div class="input-select_status">
                        <label for="disponibilidade">O animal ainda está disponível para adoção?</label>
                        <div>
                            <select v-model="alteracaoAnimal.disponibilidade" name="disponibilidade"
                                id="disponibilidade">
                                <option value="" block>Selecione a opcção</option>
                                <option :value="true">Sim</option>
                                <option :value="false">Não</option>
                            </select>
                        </div>
                    </div>
                    <EstadosECidades v-model:estado="alteracaoAnimal.localizacao"
                        v-model:cidade="alteracaoAnimal.cidade"></EstadosECidades>

                    <div class="Cadastre-se-button">

                        <div class="form-group row">
                            <button type="button" class="Altera-button" v-on:click="salvarAlteracaoAnimal"> Alterar
                                dados do pet </button>
                        </div>
                    </div>
                </form>

            </div>
        </div>

        <div class="col-8 ">
            <div data-bs-spy="scroll" data-bs-target="#listaCadastro" data-bs-smooth-scroll="true"
                class="scrollspy-example " tabindex="0">
                <nav>
                    <div>

                    </div>
                </nav>
            </div>
        </div>
    </div>

</template>
<script src="./Alteracao-de-animal.js"></script>
        <style src="./Alteracao-de-animal.css">
        </style>