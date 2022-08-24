<template>
  <div class="fundo-form">
    <div id="forms">
      <form action="#">
        <div id="titulo_forms">
          <h1>Cadastre-se</h1>
        </div>
        <div class="form-header">
          <div class="input-group">
            <div class="input-box">
              <label class="form-label" for="nome">Nome</label>
              <input
                class="form-control"
                required
                type="text"
                placeholder="Digite seu nome"
              />
            </div>
            <div class="input-box">
              <label class="form-label" for="sobrenome">Sobrenome</label>
              <input
                class="form-control"
                type="text"
                required
                placeholder="Digite seu sobrenome"
              />
            </div>
            <div class="input-box">
              <label class="form-label" for="email">Email</label>
              <input
                class="form-control"
                type="email"
                required
                placeholder="Digite seu email"
              />
            </div>
            <div class="input-box">
              <label class="form-label" for="telefone">Telefone</label>
              <input
                class="form-control"
                type="tel"
                placeholder="(xx) xxxxx-xxxx"
              />
              <div class="input-box">
                <label class="form-label" for="localizacao">Estado</label>
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
              </div>
              <div class="input-box">
                <label class="form-label" for="Senha">Senha</label>
                <input
                  class="form-control"
                  type="password"
                  placeholder="Digite sua senha"
                />
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
</template>

<script src="./Cadastro.js"></script>
<style src="./Cadastro.css"></style>
