<template>
  <!-- Conteúdo da Página -->
  <div id="form_doacao">
    <div id="img_form_doacao">
      <img src="@/assets/images/DoacaoAnimal/cão-e-gato.jpg" />
    </div>
    <div id="forms_doacao">
      <div id="titulo_forms_doacao">
        <h1>Cadastre o seu animal</h1>
          <hr class="solid" />
        </div>
          <form v-on:submit="postCadastroAnimal">
        <div class="form-header_doacao">
          <div class="input-group">
            <div class="input-box">
              <label for="nome">Nome :</label>
              <div>
                <input required type="text" v-model="cadastroAnimal.nome" name="body" placeholder="Digite o nome do seu pet" />
              </div>
            </div>
            <div class="input-box">
              <label for="idade">Idade :</label>
              <div>
                <input type="text" v-model="cadastroAnimal.idade" required placeholder="Digite a idade do seu pet" />
              </div>
            </div>
            <div class="input-select_porte">
              <label for="porte">Porte :</label>
              <div>
                <select v-model="cadastroAnimal.porte" name="porte" id="porte">
                  <option value="" block>Selecione o porte</option>
                  <option  value="0">Pequeno</option>
                  <option value="1">Médio</option>
                  <option value="2">Grande</option>
                </select>
              </div>
            </div>
            <div class="inputs-radio_doacao">
              <div class="input-radio">
                <h6>Especie :</h6>
                <div>
                  <input v-model="cadastroAnimal.especie" type="radio" name="especie" value="Gato" />
                  <label for="Gato">Gato</label>
                  <input v-model="cadastroAnimal.especie" type="radio" name="espeie" value="Cachorro" /><label for="Cachorro">Cachorro</label>
                </div>
              </div>
            </div>
            <div class="input-box">
              <label for="Foto"> Adicione uma foto do seu pet</label>
              <div>
                <input for="Foto" type="file" placeholder="Adicione a Foto" />
              </div>
            </div>
            <div class="inputs-radio_doacao">
              <h6>Sexo :</h6>
              <div>
                <input v-model="cadastroAnimal.sexo" type="radio" name="sexo" value="Macho" />
                <label for="Macho">Macho</label>
                <input v-model="cadastroAnimal.sexo" type="radio" name="sexo" value="Fêmea" />
                <label for="Fêmea">Fêmea</label>
              </div>
            </div>
            <div class="input-checkbox">
              <input v-model="cadastroAnimal.vacina" type="checkbox" name="vacina" />
              <label for="vacina" class="label-check">
                Seu pet é vacinado?</label>
            </div>
            <div class="input-checkbox">
              <input v-model="cadastroAnimal.microchip" type="checkbox" name="Microchip" />
              <label for="Microchip" class="label-check">
                Seu pet possui Microchip?</label>
            </div>
            <div class="input-checkbox">
              <input v-model="cadastroAnimal.castrado" type="checkbox" name="Castrado" />
              <label for="Castrado" class="label-check">
                Seu pet é castrado?</label>
            </div>
            <div class="input-checkbox">
              <input type="checkbox" v-model="cadastroAnimal.deficiencia" name="deficiencia" />
              <label for="deficiencia" class="label-check">
                Seu pet possui alguma deficiencia?</label>
            </div>

            <div class="Cadastre-se-button">
              <button type="submit"> Salvar</button>
            </div>
          </div>
        </div>
      </form>
    </div>
  </div>
</template>

<script src="./DoacaoAnimal.js"></script>
<style src="./DoacaoAnimal.css">
</style>

<!-- backup caso precise para outros metodos 

<template>
  <div id="form">
    <div id="img_form">
      <img src="@/assets/images/DoacaoAnimal/cão-e-gato.jpg" />
    </div>
    <div id="forms">
      <form action="#">
        <div id="titulo_forms">
          <h1>Cadastre o seu animal</h1>
        </div>
        <div class="form-header">
          <div class="input-group">
            <div class="input-box">
              <label for="nome">Nome :</label>
              <input
                requeired
                type="text"
                placeholder="Digite o nome do seu pet"
              />
            </div>
            <div class="input-box">
              <label for="idade">Idade :</label>
              <input
                type="text"
                required
                placeholder="Digite a idade do seu pet"
              />
            </div>
            <div class="input-select">
              <label for="porte">Porte :</label>
              <select name="porte" id="porte">
                <option value="" block>Selecione o porte</option>
                <option value="Pequeno">Pequeno</option>
                <option value="Médio">Médio</option>
                <option value="Grande">Grande</option>
              </select>
            </div>
            <div class="inputs-radio">
              <div class="input-radio">
                <h6>Especie :</h6>
                <input type="radio" name="espeie" value="Gato" />
                <label for="Gato">Gato</label>
                <input type="radio" name="espeie" value="Cachorro" /><label
                  for="Cachorro"
                  >Cachorro</label
                >
              </div>
            </div>
            <div class="input-box">
              <label for="Foto"> Adicione uma foto do seu pet</label>
              <input for="Foto" type="file" placeholder="Adicione a Foto" />
            </div>
            <div class="input-radio">
              <h6>Sexo :</h6>
              <input type="radio" name="sexo" value="Macho" />
              <label for="Macho">Macho</label>
              <input type="radio" name="sexo" value="Fêmea" />
              <label for="Fêmea">Fêmea</label>
            </div>
            <div class="input-checkbox">
              <input type="checkbox" name="vacina" />
              <label for="vacina" class="label-check">
                Seu pet é vacinado?</label
              >
            </div>
            <div class="input-checkbox">
              <input type="checkbox" name="Microchip" />
              <label for="Microchip" class="label-check">
                Seu pet possui Microchip?</label
              >
            </div>
            <div class="input-checkbox">
              <input type="checkbox" name="Castrado" />
              <label for="Castrado" class="label-check">
                Seu pet é castrado?</label
              >
            </div>
            <div class="input-checkbox">
              <input type="checkbox" name="deficiencia" />
              <label for="deficiencia" class="label-check">
                Seu pet possui alguma deficiencia?</label
              >
            </div>

            <div class="Cadastre-se-button">
              <button><a href="#"> Salvar</a></button>
            </div>
          </div>
        </div>
      </form>
    </div>
  </div>
</template>
-->
