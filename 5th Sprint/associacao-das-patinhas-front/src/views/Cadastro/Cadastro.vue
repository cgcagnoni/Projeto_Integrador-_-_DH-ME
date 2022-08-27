<template>
  <div class="fundo-form">
    <div id="form">
      <div id="img_form">
        <img src="@/assets/images/Cadastro/VACCINAR.png">
      </div>
      <div id="forms">
        <div id="titulo_forms">
          <h1>Cadastre-se</h1>
        </div>
        <form v-on:submit="postCadastro">
          <div class="form-header">
            <div class="input-group">

              <div class="input-box">
                <label class="form-label" for="nome">Nome</label>
                <input class="form-control" v-model="cadastro.nome" id="nome" required type="text"
                  placeholder="Digite seu nome" name="body" />
              </div>
              <div class="input-box">
                <label class="form-label" for="sobrenome">Sobrenome</label>
                <input class="form-control" v-model="cadastro.sobrenome" id="sobrenome" type="text" required
                  placeholder="Digite seu sobrenome" name="body" />
              </div>
              <div class="input-box">
                <label class="form-label" for="username">Username</label>
                <input class="form-control" v-model="cadastro.username" id="username" required type="text"
                  placeholder="Digite seu nome" name="body" />
              </div>
              <div class="input-box">
                <label class="form-label" for="email">Email</label>
                <input class="form-control" v-model="cadastro.email" id="email" type="email" required
                  placeholder="Digite seu email" name="body" />
              </div>
              <div class="input-box">
                <label class="form-label" for="telefone">Telefone</label>
                <input class="form-control" v-model="cadastro.telefone" id="telefone" type="tel"
                  placeholder="(xx) xxxxx-xxxx" name="body" />
                <div class="input-box">
                  <label class="form-label" for="localizacao">Estado</label>
                  <select id="UF" name="UF" v-model="estado">
                    <option value="">Selecione</option>
                    <option :value="item" v-for="item in listaUF">{{ item }}</option>
                  </select>
                </div>
                <div class="input-box">
                  <label class="form-label" for="localizacao">Cidade</label>
                  <select id="UF" name="UF" v-model="cidade">
                    <option value="">Selecione</option>
                    <option :value="item" v-for="item in listaCidades[estado]">{{ item }}</option>
                  </select>
                </div>
                <div class="input-box">
                  <label class="form-label" for="password">Senha</label>
                  <input class="form-control" v-model="cadastro.password" id="password" type="password"
                    placeholder="Digite sua senha" name="body" />
                </div>
                <div class="Cadastre-se-button botao">
                  <button type="submit"> Cadastre-se </button>
                </div>
              </div>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script src="./Cadastro.js">
</script>
<style src="./Cadastro.css">
</style>
