<template>
  <!-- Conteúdo da Página -->
  <div id="form">
    <div id="img_form">
      <img src="./assets/images/Cadastro/VACCINAR.png" />
    </div>

    <div id="forms">
      <form>
        <h1>Cadastre-se</h1>
        <label for="nome">Nome</label>
        <input requeired placeholder="Digite seu nome" />
        <br />
        <label for="sobrenime">Sobrenome</label>
        <input required placeholder="Digite seu sobrenome" />
        <br />
        <label for="email">Email</label>
        <input type="email" required placeholder="Digite seu email" />
        <br />
        <label for="localizacao">Estado</label>
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
        <br />
        <label for="telefone">Telefone</label>
        <input type="number" placeholder="Digite seu telefone" />
        <br />
        <label for="Senha">Senha</label>
        <input type="password" placeholder="Digite sua senha" />
      </form>
    </div>
  </div>
</template>

<script src="./Cadastro.js"></script>
<style src="./Cadastro.css"></style>
