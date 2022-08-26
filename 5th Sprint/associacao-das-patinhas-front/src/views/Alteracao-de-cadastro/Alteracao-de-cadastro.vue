<template>

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
                    <div class="form-group row">
                        <h4 id="list-item-1">Alterar dados cadastrais</h4>
                        <label for="alterarNomeUsuario" class="col-sm-2 col-form-label">Nome</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="alterarNomeUsuario"
                                placeholder="Nome do usuário">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="alterarSobrenomeUsuario" class="col-sm-2 col-form-label">Sobrenome</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="alterarSobrenomeUsuario"
                                placeholder="Sobrenome do usuário">
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="alterarEmailUsuario" class="col-sm-2 col-form-label">E-mail</label>
                        <div class="col-sm-10">
                            <input type="email" class="form-control" id="alterarEmailUsuario"
                                placeholder="E-mail do usuário">
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="alterarFonelUsuario" class="col-sm-2 col-form-label">Telefone</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="alterarTelefonelUsuario"
                                placeholder="Telefone do usuário">
                        </div>
                    </div>

                    <div>
                        <label for="estado" class="form-label">Estado</label>
                        <select id="UF" name="UF">
                            <option value="">Selecione</option>
                            <option value="AC">Acre</option>
                            <option value="AL">Alagoas</option>
                            <option value="AP">Amapá</option>
                            <option value="AM">Amazonas</option>
                            <option value="BA">Bahia</option>
                            <option value="CE">Ceará</option>
                            <option value="DF">Distrito Federal</option>
                            <option value="ES">Espirito Santo</option>
                            <option value="GO">Goiás</option>
                            <option value="MA">Maranhão</option>
                            <option value="MS">Mato Grosso do Sul</option>
                            <option value="MT">Mato Grosso</option>
                            <option value="MG">Minas Gerais</option>
                            <option value="PA">Pará</option>
                            <option value="PB">Paraíba</option>
                            <option value="PR">Paraná</option>
                            <option value="PE">Pernambuco</option>
                            <option value="PI">Piauí</option>
                            <option value="RJ">Rio de Janeiro</option>
                            <option value="RN">Rio Grande do Norte</option>
                            <option value="RS">Rio Grande do Sul</option>
                            <option value="RO">Rondônia</option>
                            <option value="RR">Roraima</option>
                            <option value="SC">Santa Catarina</option>
                            <option value="SP">São Paulo</option>
                            <option value="SE">Sergipe</option>
                            <option value="TO">Tocantins</option>
                        </select>
                    </div><br>
                    <div class="mb-3 form-check">
                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                        <label class="form-check-label" for="autorizacaoContatoEmail">Autorizo receber
                            contato através do meu e-mail</label>
                    </div>
                    <div class="mb-3 form-check">
                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                        <label class="form-check-label" for="autorizacaoContatoEmail">Autorizo receber
                            contato através do meu telefone</label>
                    </div>
                    <div class="mb-3 form-check">

                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                        <label class="form-check-label" for="autorizacaoContatoEmail" required>Concordo com
                            a política de doação e adoção de animais da Associação das Patinhas</label>
                    </div><br>
                    <div class="form-group row">
                        <label for="senhaUsuario" class="col-sm-2 col-form-label">Senha</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="senhaUsuario"
                                placeholder="Digite a sua senha">
                        </div>
                    </div>

                    <div class="Alterar-rodape">
                                <button type="submit" class="Altera-button">Alterar meus dados</button>
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

<script src="./Alteracao-de-cadastro.js"></script>
<style src="./Alteracao-de-cadastro.css">
</style>
