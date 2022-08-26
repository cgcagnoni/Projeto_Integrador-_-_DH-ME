<template>

    <div id="container">
        <!-- Conteúdo da Página -->
        <div class="row" id="profilecontent">
            <div class="col-4">
                <div id="listaCadastro" class="list-group">
                    <a class="list-group-item list-group-item-action" href="./perfil">Meu cadastro</a>
                    <a class="list-group-item list-group-item-action" href="./perfil">Minhas adoções</a>
                    <a class="list-group-item list-group-item-action" href="./perfil">Minha doações</a>
                    <a class="list-group-item list-group-item-action" href="./perfil">Segurança</a>
                    <a class="list-group-item list-group-item-action" href="./alteracao-cadastro">Alterar dados</a>
                </div>
            </div>

            <div class="col-8">
                <div data-bs-spy="scroll" data-bs-target="#listaCadastro" data-bs-smooth-scroll="true"
                    class="scrollspy-example" tabindex="0">
                    <form>
                        <div class="input-group row">
                            <h1 id="list-item-1">Alterar dados do pet</h1>
                            <label for="alterarNomeAnimal" class="col-sm-2 col-form-label">
                                <h2 class="tituloAnimal">Nome do animal</h2>
                            </label>
                           <div>
                                <input type="text" class="form-control" id="alterarNomeAnimal"
                                    placeholder="Nome do animal" aria-label="Default" aria-describedby="inputGroup-sizing-default">
                            </div>
               </div>

                        <div class="form-group row">
                            <label for="alterarEspecie">
                                <h2 class="tituloAnimal">Espécie: </h2>
                            </label>
                            <div class="col-sm-10">
                                <input type="radio" name="especie" value="Gato">
                                <label for="Gato">Gato</label><br>
                                <input type="radio" name="especie" value="Cachorro">
                                <label for="Cachorro">Cachorro</label>
                            </div>
                        </div><hr>

                        <div class="form-group row">
                            <label for="alterarIdade">
                                <h2 class="tituloAnimal">Idade: </h2>
                            </label>
                            <div class="col-sm-10">
                                <input type="radio" name="idade" value="Filhote">
                                <label for="Filhote">Filhote</label><br />
                                <input type="radio" name="idade" value="Adulto">
                                <label for="Adulto">Adulto</label><br />
                                <input type="radio" name="idade" value="Idoso">
                                <label for="Idoso">Idoso</label><br />
                            </div>
                        </div><hr>

                        <div class="form-group row">
                            <div class="col-sm-10">
                                <label for="sexo">
                                    <h2 class="tituloAnimal">Sexo:</h2>
                                </label><br>
                                <input type="radio" name="sexo" value="Macho">
                                <label for="Macho">Macho</label><br>
                                <input type="radio" name="sexo" value="Fêmea">
                                <label for="Fêmea">Fêmea</label>
                            </div>
                        </div><hr>

                        <div class="form-group row">
                            <label for="alterarPorte">
                                <h2 class="tituloAnimal">Porte: </h2>
                            </label>
                            <div class="col-sm-10">
                                <input type="radio" name="porte" value="Pequeno">
                                <label for="Pequeno">Pequeno</label><br />
                                <input type="radio" name="porte" value="Médio">
                                <label for="Médio">Médio</label><br />
                                <input type="radio" name="porte" value="Grande">
                                <label for="Grande">Grande</label><br />
                            </div>
                        </div><hr>

                        <div class="input-box">
                            <label for="Foto">
                                <h2 class="tituloAnimal">Adicione uma foto do seu pet</h2>
                            </label>
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
            
                                    <button type="submit" class="Altera-button">Alterar dados do pet</button>
                              
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
<script src="./Alteracao-de-animal.js"></script>
        <style src="./Alteracao-de-animal.css">
        </style>