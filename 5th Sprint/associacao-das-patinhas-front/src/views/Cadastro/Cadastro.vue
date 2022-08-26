<template>
  <div class="fundo-form">
    <div id="form">
      <div id="img_form">
        <img src="@/assets/images/Cadastro/VACCINAR.png">
      </div>
      <div id="forms">
        <form action="#">
          <div id="titulo_forms">
            <h1>Cadastre-se</h1>
          </div>
          <div class="form-header">
            <div class="input-group">
              <div class="input-box">
                <label class="form-label" for="nome">Nome</label>
                <input class="form-control" required type="text" placeholder="Digite seu nome" />
              </div>
              <div class="input-box">
                <label class="form-label" for="sobrenome">Sobrenome</label>
                <input class="form-control" type="text" required placeholder="Digite seu sobrenome" />
              </div>
              <div class="input-box">
                <label class="form-label" for="email">Email</label>
                <input class="form-control" type="email" required placeholder="Digite seu email" />
              </div>
              <div class="input-box">
                <label class="form-label" for="telefone">Telefone</label>
                <input class="form-control" type="tel" placeholder="(xx) xxxxx-xxxx" />
                <div class="input-box">
                  <label class="form-label" for="localizacao">Estado</label>
                  <select id="UF" name="UF" v-model="estado">
                    <option value="">Selecione</option>
                    <option :value="item" v-for="item in listaUF">{{item}}</option>                    
                  </select>
                </div>
                <div class="input-box">
                  <label class="form-label" for="localizacao">Cidade</label>
                  <select id="UF" name="UF" v-model="cidade">
                    <option value="">Selecione</option>
                    <option :value="item" v-for="item in listaCidades[estado]">{{item}}</option>                    
                  </select>
                </div>
                <div class="input-box">
                  <label class="form-label" for="Senha">Senha</label>
                  <input class="form-control" type="password" placeholder="Digite sua senha" />
                </div>
                <div class="Cadastre-se-button botao">
                  <button><a href="#"> Cadastre-se</a></button>
                </div>
              </div>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</template>

<script src="./Cadastro.js"></script>
<style src="./Cadastro.css">
</style>
