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
                <form v-on:submit="AlteracaoCadastro">
                    <div class="form-group row">
                        <h4 id="list-item-1">Alterar dados cadastrais</h4>
                        <label for="alterarNomeUsuario" class="col-sm-2 col-form-label">Nome</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" v-model="alteracao.nome" name="body"
                                id="alterarNomeUsuario" placeholder="Nome do usuário">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="alterarSobrenomeUsuario" class="col-sm-2 col-form-label">Sobrenome</label>
                        <div class="col-sm-10">
                            <input type="text" v-model="alteracao.sobrenome" name="body" class="form-control"
                                id="alterarSobrenomeUsuario" placeholder="Sobrenome do usuário">
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="alterarEmailUsuario" class="col-sm-2 col-form-label">E-mail</label>
                        <div class="col-sm-10">
                            <input type="email" v-model="alteracao.email" name="body" class="form-control"
                                id="alterarEmailUsuario" placeholder="E-mail do usuário">
                        </div>
                    </div>

                    <div class="form-group row">
                        <label for="alterarFonelUsuario" class="col-sm-2 col-form-label">Telefone</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" name="body" v-model="alteracao.telefone"
                                id="alterarTelefonelUsuario" placeholder="Telefone do usuário">
                        </div>
                    </div>
                    <EstadosECidades v-model:estado="alteracao.localizacao" v-model:cidade="alteracao.cidade"></EstadosECidades>
                    <br>
                    <div class="input-box">
                        <label class="form-label" for="localizacao">Autorizo receber contato por:</label>
                        <select  v-model="alteracao.autorizacaoNotificacao">
                            <option :value="0" > Email</option>
                            <option :value="1" > WhatsApp</option>
                            <option :value="2" > Email e WhatsApp</option>
                            <option :value="3" > Exibir no meu perfil</option>
                        </select>
                    </div>                  
                    <div class="Alterar-rodape">
                        <button v-on:click="AlteracaoCadastro" type="button" class="Altera-button">Alterar meus
                            dados</button>
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
