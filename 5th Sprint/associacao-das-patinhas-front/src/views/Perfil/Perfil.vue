<template>
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
      <div data-bs-spy="scroll" data-bs-target="#list-example" data-bs-smooth-scroll="true" class="scrollspy-example"
        tabindex="0">
        <nav>
          <div>
            <h4 id="list-item-1">Meu cadastro</h4>
            <p>Nome: &nbsp {{ nome }}</p>
            <p>E-mail: &nbsp {{ email }}</p>
            <p>Telefone: &nbsp {{ telefone }}</p>
            <p>Localização: &nbsp {{ localizacao }}</p>
            <a href="./Alteracao-cadastro">Alterar meus dados</a>
            <br />
            <hr class="solid" />
          </div>

          <div>
            <h4 id="list-item-2">Minhas adoções</h4>
            <p>{{ nome }}Você ainda não adotou nenhum animalzinho!</p>
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
            <h4 id="list-item-3">Meus animais colocados para adoção</h4>
            <p v-for="animal in animaisDisponiveisUsuario">
              {{ animal.nome }}</p>
            <br />
            <hr class="solid" />
          </div>
          <div>
            <h4 id="list-item-4">Segurança</h4>
            <a href="./Alteracao-cadastro">Alterar e-mail</a><br />
            <a href="./Alteracao-cadastro">Alterar senha</a>
          </div>
        </nav>
      </div>
    </div>
  </div>
</template>

<script src="./Perfil.js"></script>
<style src="./Perfil.css">
</style>
