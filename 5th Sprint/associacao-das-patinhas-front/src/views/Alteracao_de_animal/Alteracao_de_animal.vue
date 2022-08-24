<template>

    <div id="container">
        <!-- Conteúdo da Página -->
        <div class="row" id="profilecontent">
            <div class="col-4">
                <div id="listaCadastro" class="list-group">
                    <a class="list-group-item list-group-item-action" href="./perfil.html">Meu cadastro</a>
                    <a class="list-group-item list-group-item-action" href="./perfil.html">Minhas adoções</a>
                    <a class="list-group-item list-group-item-action" href="./perfil.html">Minha doações</a>
                    <a class="list-group-item list-group-item-action" href="./perfil.html">Segurança</a>
                    <a class="list-group-item list-group-item-action" href="./perfil.html">Alterar dados</a>
                </div>
            </div>

            <div class="col-8">
                <div data-bs-spy="scroll" data-bs-target="#listaCadastro" data-bs-smooth-scroll="true"
                    class="scrollspy-example" tabindex="0">
                    <form>
                        <div class="form-group row">
                            <h4 id="list-item-1">Alterar dados do pet</h4>
                            <label for="alterarNomeAnimal" class="col-sm-2 col-form-label">Nome do animal</label>
                            <div class="col-sm-10">
                                <input type="text" class="form-control" id="alterarNomeAnimal"
                                    placeholder="Nome do animal">
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="alterarEspecie">Espécie: </label>
                            <div class="col-sm-10">
                                <input type="radio" name="especie" value="Gato">
                                <label for="Gato">Gato</label><br>
                                <input type="radio" name="especie" value="Cachorro">
                                <label for="Cachorro">Cachorro</label>
                            </div>
                        </div><br>

                        <div class="form-group row">
                            <div class="col-sm-10">
                                <label for="sexo">Sexo: </label><br>
                                <input type="radio" name="sexo" value="Macho">
                                <label for="Macho">Macho</label><br>
                                <input type="radio" name="sexo" value="Fêmea">
                                <label for="Fêmea">Fêmea</label>
                            </div>
                        </div>

                        <div class="form-group row">
                            <label for="alterarIdade" class="col-sm-2 col-form-label">Idade</label>
                            <div class="col-sm-10">

                                <input id="alterarIdade" type="text" class="form-control" required
                                    placeholder="Digite a idade do seu pet">

                            </div>
                        </div>

                        <div class="form-group row">
                            <div class="col-sm-10">
                                <select name="alterarPorte" id="alterarPorte">
                                    <option value="" block>Selecione o porte</option>
                                    <option value="Pequeno">Pequeno</option>
                                    <option value="Médio">Médio</option>
                                    <option value="Grande">Grande</option>
                                </select>
                            </div>
                        </div><br>

                        <div class="input-box">
                            <label for="Foto"> Adicione uma foto do seu pet</label>
                            <input for="Foto" type="file" placeholder="Adicione a Foto">
                        </div><br>
                        <div>
                            <input type="checkbox" name="vacina">
                            <label for="vacina"> Seu pet é vacinado?</label>
                        </div>
                        <div>
                            <input type="checkbox" name="Microchip">
                            <label for="Microchip"> Seu pet possui Microchip?</label>
                        </div>
                        <div>
                            <input type="checkbox" name="Castrado">
                            <label for="Castrado"> Seu pet é castrado?</label>
                        </div>
                        <div>
                            <input type="checkbox" name="deficiencia">
                            <label for="deficiencia"> Seu pet possui alguma deficiencia?</label>
                        </div><br>

                        <div class="Cadastre-se-button">

                            <div class="form-group row">
                                <div class="col-sm-10">
                                    <button type="submit" class="btn btn-primary">Alterar dados do pet</button>
                                </div>
                            </div>
                        </div>
                    </form>

                </div>
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