<template>
  <!-- Conteúdo da Página -->

  <div id="busca">
    <div class="container-busca text-center row">
      <div class="col-11 input-busca">
        <input
          type="text"
          class="form-control"
          id="busca-input"
          placeholder="Busque por porte, idade ou sexo do animal"
        />
      </div>
      <div class="col-1">
        <p for="busca-input" class="busca-icon">
          <i class="fa-solid fa-magnifying-glass fa-2x"></i>
        </p>
      </div>
    </div>
  </div>

  <!-- Catálogo -->
  <div id="catalog"></div>

  <!-- Criar paginação -->
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
<style src="./Busca.css"></style>
