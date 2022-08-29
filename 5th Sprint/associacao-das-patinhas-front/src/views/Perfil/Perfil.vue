<template>
  <!-- Conteúdo da Página -->
  <div class="row" id="profilecontent">
    <div class="col-4">
      <div id="listaCadastro" class="list-group">
        <a class="list-group-item list-group-item-action" href="#list-item-1">Meu cadastro</a>
        <a class="list-group-item list-group-item-action" href="#list-item-2">Minhas adoções</a>
        <a class="list-group-item list-group-item-action" href="#list-item-3">Minha doações</a>
        <a class="list-group-item list-group-item-action" href="#list-item-4">Meus animais colocados para adoção</a>
        <a class="list-group-item list-group-item-action" href="#list-item-5">Segurança</a>
        <RouterLink class="list-group-item list-group-item-action" to="/alteracao-cadastro">Alterar dados</RouterLink>
      </div>
    </div>
    <div class="col-8">
      <div data-bs-spy="scroll" data-bs-target="#list-example" data-bs-smooth-scroll="true" class="scrollspy-example"
        tabindex="0">
        <nav>
          <div>
            <h4 id="list-item-1">Meu cadastro</h4>
            <p>Nome: &nbsp {{ nome }}</p>
            <p>E-mail: &nbsp {{ email }}</p>
            <p>Telefone: &nbsp {{ telefone }}</p>
            <p>Localização: &nbsp {{ localizacao }}</p>
            <RouterLink class="link" to="/alteracao-cadastro">Alterar meus dados</RouterLink>
            <br />
            <hr class="solid" />
          </div>

          <div>
            <h4 id="list-item-2">Interessados em adotar</h4>
            <div v-for="interesse in interesseAdocao">
            <p>Nome: &nbsp {{ interesse.nome }}</p>
            <p>E-mail: &nbsp {{ interesse.email }}</p>
            <p>Telefone: &nbsp {{ interesse.telefone }}</p>
            <p>Localização: &nbsp {{ interesse.localizacao }}</p>
            <p>Cidade: &nbsp {{ interesse.cidade }}</p>
            <hr/>
            </div>
            
            
            <br />
            <hr class="solid" />
          </div>
          <div>
            <h4 id="list-item-3">Minhas doações</h4>
            <p v-if="animaisAdotados" v-for="animal in animaisAdotados">
              {{ animal.nome }}
            </p>
            <p v-else>
              Você ainda não doou nenhum animalzinho!
            </p>
            <br />
            <hr class="solid" />
          </div>
          <div>
            <h4 id="list-item-4">Meus animais colocados para adoção</h4>
            <p v-for="animal in animaisDisponiveisUsuario">
              {{animal.id}} - {{ animal.nome }}</p>
            <button v-on:click="clickAtualizarDados" class="Altera-button">Atualizar dados</button>
            <br />
            <hr class="solid" />
          </div>
          <div>
            <h4 id="list-item-5">Segurança</h4>
            <RouterLink class="link" to="./alteracao-cadastro">Alterar e-mail</RouterLink><br />
            <RouterLink class="link" to="./alteracao-cadastro">Alterar senha</RouterLink>
          </div>
        </nav>
      </div>
    </div>
  </div>
</template>

<script src="./Perfil.js"></script>
<style src="./Perfil.css">
</style>
