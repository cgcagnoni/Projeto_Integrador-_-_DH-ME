<template>
  <div class="main-login">
    <div class="left-login">
      <h1>Para doar ou adotar um animalzinho, é necessário efetuar o cadastro.</h1>
      <img src="@/assets/images/Login/Foto-Cachorro-e-Gato-PNG.png" class="left-login-img" alt="Animacao">
    </div>
    <div class="right-login">
      <div class="card-login">
        <h1>LOGIN</h1>
        <div class="textfield">
          <label for="usuario">Usuário</label>
          <input v-model="usuario" type="text" name="usuario" placeholder="Username">
        </div>
        <div class="textfield">
          <label for="senha">Senha</label>
          <input v-model="senha" type="password" name="senha" placeholder="Senha">
        </div>
        <button class="btn-login" v-on:click="login">Login</button>
        <button class="btn-cadastro">Cadastre-se</button><br/>
        <button class="btn-cadastro">Esqueceu sua senha?</button>
      </div>
    </div>
  </div>
</template>

<script src="./Login.js"></script>
<style src="./Login.css"></style>
