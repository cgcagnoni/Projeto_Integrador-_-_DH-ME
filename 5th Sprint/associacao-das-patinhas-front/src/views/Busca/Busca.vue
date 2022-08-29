<template>
  <!-- Filtros -->
  <div id="busca">
    <div id="Especie" class="form-group row">
      <label for="rEspecie">
        <h2 class="tituloAnimal">Espécie: </h2>
      </label>
      <div class="tituloAnimal-inputs col-sm-10">
        <input v-model="especie" type="radio" name="especie" value="0">
        <label for="Gato">Gato</label><br>
        <input v-model='especie' type="radio" name="especie" value="1">
        <label for="Cachorro">Cachorro</label>
      </div>
    </div>
    <hr>

    <div id="Idade" class="form-group row">
      <label for="alterarIdade">
        <h2 class="tituloAnimal">Idade: </h2>
      </label>
      <div class="col-sm-10">
        <input v-model="idade" type="radio" name="idade" value="0">
        <label for="Filhote">Filhote</label><br />
        <input v-model="idade" type="radio" name="idade" value="1">
        <label for="Adulto">Adulto</label><br />
        <input v-model="idade" type="radio" name="idade" value="2">
        <label for="Idoso">Idoso</label><br />
      </div>
    </div>
    <hr>
     <div id="Sexo" class="form-group row">
      <label for="alterarEspecie">
        <h2 class="tituloAnimal">Sexo: </h2>
      </label>
      <div class="tituloAnimal-inputs col-sm-10">
        <input v-model="sexo" type="radio" name="sexo" value="0">
        <label for="Macho">Macho</label><br>
        <input v-model="sexo" type="radio" name="sexo" value="1">
        <label for="Fêmea">Fêmea</label>
      </div>
    </div>
    <hr>

    <div id="Porte" class="form-group row">
      <label for="alterarPorte">
        <h2 class="tituloAnimal">Porte: </h2>
      </label>
      <div class="col-sm-10">
        <input v-model="porte" type="radio" name="porte" value="0">
        <label for="Pequeno">Pequeno</label><br />
        <input v-model="porte" type="radio" name="porte" value="1">
        <label for="Médio">Médio</label><br />
        <input v-model="porte" type="radio" name="porte" value="2">
        <label for="Grande">Grande</label><br />
      </div>
    </div>
    <hr>
  <div class="btn-busca">
    <button v-on:click="filtrarAnimais">
      Buscar animal
    </button>
  </div>
  </div>



  <!-- Catálogo -->
  <div class="title-busca">
   <h1>Animais disponíveis para adoção</h1>
  </div>
    <div id="catalog" v-for="animal in animais">
        <div v-if="animal.especie==0" class="card">
            <img src="https://cataas.com/cat" alt="imagem-animal"/>
            <div class="cardanimal">
                <RouterLink :to="{ name: 'animalperfil', params: { id: animal.id } }">
                    <h2>{{ animal.nome }}</h2>
                  </RouterLink>
            </div>
        </div>
        <div v-if="animal.especie==1" class="card">
            <img src="https://placedog.net/640/480?random" alt="imagem-animal"/>
            <div class="cardanimal">
                <RouterLink :to="{ name: 'animalperfil', params: { id: animal.id } }">
                    <h2>{{ animal.nome }}</h2>
                  </RouterLink>
            </div>
        </div>
    </div>

  <!-- Paginação -->
  <div id="pag">
    <nav>
      <ul class="pagination">
        <li class="page-item">
          <a class="page-link" href="#" aria-label="Previous">
            <span aria-hidden="true">&laquo;</span>
          </a>
        </li>
        <li class="page-item"><a class="page-link" href="#">1</a></li>
        <li class="page-item"><a class="page-link" href="#">2</a></li>
        <li class="page-item"><a class="page-link" href="#">3</a></li>
        <li class="page-item">
          <a class="page-link" href="#" aria-label="Next">
            <span aria-hidden="true">&raquo;</span>
          </a>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script src="./Busca.js"></script>
<style src="./Busca.css">
</style>
