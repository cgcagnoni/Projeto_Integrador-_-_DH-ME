<template>
<!-- Conteúdo da Página -->

    <div id="form_animal">
      <div id="forms_animal">
        <form action="#">
          <div id="titulo_forms_animal">
            <h1>Cadastre o seu animal</h1>
          </div>
          <div class="form-header_animal">
          <div class="input-group_animal">
            <div class="input-box">
              <label for="nome">Nome</label>
              <input requeired  type="text" placeholder="Digite o nome do seu pet">
            </div> 
            
            <div class="input-radio">
              <label for="especie">Especie</label>
              <input type="radio" name="espeie" value="Gato"> <label for="Gato">Gato</label>
              <input type="radio" name="espeie" value="Cachorro"><label for="Cachorro">Cachorro</label>
            </div>
            <label for="sexo">Sexo</label>
                <input type="radio" name="sexo" value="Macho"> <label for="Macho">Macho</label>
                <input type="radio" name="sexo" value="Fêmea"> <label for="Fêmea">Fêmea</label>
              
            <div class="input-box">
              <label for="idade">idade</label>
              <input type="text" required placeholder="Digite a idade do seu pet">
            </div>
            <div class="input-box">
              <label for="porte">Porte</label>
              <select name="porte" id="porte">
                <option value="" block>Selecione o porte</option>
                <option value="Pequeno">Pequeno</option>
                <option value="Médio">Médio</option>
                <option value="Grande">Grande</option>
              </select>
            </div>
            <div class="input-box">
              <label for="Foto"> Adicione uma foto do seu pet</label>
              <input for="Foto" type="file" placeholder="Adicione a Foto">
            </div>
            <input type="checkbox" name="vacina">
           <label for="vacina"> Seu pet é vacinado?</label>
           <input type="checkbox" name="Microchip">
           <label for="Microchip"> Seu pet possui Microchip?</label>
           <input type="checkbox" name="Castrado">
           <label for="Castrado"> Seu pet é castrado?</label>
           <input type="checkbox" name="deficiencia">
           <label for="deficiencia"> Seu pet possui alguma deficiencia?</label>
            
          <div class="Cadastre-se-button">
            <button><a href="#"> Salvar</a></button>
          </div>
            
        </form>
      </div>
    </div>
   </div>
  </div>
  </template>

  <script src="./Doacao-Animal.js"></script>
    <style src="./Doacao-Animal.css">
    </style>