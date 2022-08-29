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
            <div class="input-select_idade">
              <label for="idade">Idade :</label>
              <div>
                <select v-model="cadastroAnimal.idade" name="idade" id="idade">
                  <option value="" block>Selecione a idade</option>
                  <option :value="0">Filhote</option>
                  <option :value="1">Adulto</option>
                  <option :value="2">Idoso</option>
                </select>
              </div>
            </div>
          
            <div class="input-select_porte">
              <label for="porte">Porte :</label>
              <div>
                <select v-model="cadastroAnimal.porte" name="porte" id="porte">
                  <option value="" block>Selecione o porte</option>
                  <option :value="0">Pequeno</option>
                  <option :value="1">Médio</option>
                  <option :value="2">Grande</option>
                </select>
              </div>
            </div>

            <div class="input-select_especie">
              <label for="especie">Especie :</label>
              <div>
                <select v-model="cadastroAnimal.especie" name="especie" id="especie">
                  <option value="" block>Selecione a especie</option>
                  <option  :value="0">Gato</option>
                  <option :value="1">Cachorro</option>          
                </select>
              </div>
            </div>

            <div class="input-select_sexo">
              <label for="sexo">Sexo :</label>
              <div>
                <select v-model="cadastroAnimal.sexo" name="sexo" id="sexo">
                  <option value="" block>Selecione o sexo</option>
                  <option  :value="0">Macho</option>
                  <option :value="1">Fêmea</option>          
                </select>
              </div>
            </div>        
            
            <div class="input-box">
              <label for="vacina" class="label-check">
                Seu pet é vacinado?</label>
              <input v-model="cadastroAnimal.vacinas" type="text" name="vacina"  />              
            </div>

            <div class="input-select_microchip">
              <label for="microchip">Seu pet possui Microchip?</label>
              <div>
                <select v-model="cadastroAnimal.microchip" name="microchip" id="microchip">
                  <option value="" block>Selecione a opcção</option>
                  <option  :value="true">Sim</option>
                  <option :value="false">Não</option>          
                </select>
              </div>
            </div> 

            <div class="input-select_castrado">
              <label for="castrado">Seu pet possui Castrado?</label>
              <div>
                <select v-model="cadastroAnimal.castrado" name="castrado" id="castrado">
                  <option value="" block>Selecione a opcção</option>
                  <option  :value="true">Sim</option>
                  <option :value="false">Não</option>          
                </select>
              </div>
            </div> 

            <div class="input-select_deficiencia">
              <label for="deficiencia">Seu pet possui alguma deficiencia?</label>
              <div>
                <select v-model="cadastroAnimal.deficiencia" name="deficiencia" id="deficiencia">
                  <option value="" block>Selecione a opcção</option>
                  <option  :value="true">Sim</option>
                  <option :value="false">Não</option>          
                </select>
              </div>
            </div>             
              <EstadosECidades v-model:estado="cadastroAnimal.localizacao" v-model:cidade="cadastroAnimal.cidade"></EstadosECidades>
            
            <div class="Cadastre-se-button">
              <button v-on:click="postDoacaoAnimal"  type="button"> Salvar</button>
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
