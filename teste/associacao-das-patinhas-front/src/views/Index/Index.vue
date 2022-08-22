<template>
  <div class="row homepage-princ" id="homepage">
    <div class="col-6 homepage-img">
      <img src="@/assets/images/Home/animal-2.jpg" alt="">
    </div>
    <div class="col-6 homepage-txt">
      <span>
        <h1 class=" homepage-txt-slog">Adotar é um ato de amor</h1>
        <h2 class=" homepage-txt-nome">Associação das patinhas</h2>
      </span>
      <span class="homepage-btn">
        <!-- //precisa arrumar os botões -->
        <RouterLink to="/busca"><button class="homepage-btn-item">Adotar</button></RouterLink>
        <RouterLink to="/arrecadacao"><button class="homepage-btn-item">Contribuir</button></RouterLink>
        <RouterLink to="/cadastro"><button class="homepage-btn-item">Cadastro</button></RouterLink>
      </span>
    </div>
  </div>

  <div id="homepage-catalog">
    <div class="col homepage-catalog-txt">
      <h3>Motivos para adotar</h3>
      <div class="box">Você não participa do mercado de animais</div>
      <div class="box">A adoção salva a vida de um animal</div>
      <div class="box">Quem vive com pets tem menos estresse</div>
    </div>
    <div class="col homepage-catalog-carousel">
      <h3>Animais disponíveis para adoção</h3>
      <div class="carousel carousel-dark slide" data-bs-ride="carousel">
        <div class="carousel-indicators">
          <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="0" class="active"
            aria-current="true" aria-label="Slide 1"></button>
          <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="1"
            aria-label="Slide 2"></button>
          <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="2"
            aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner">
          <div class="carousel-item active" data-bs-interval="10000">
            <img src="@/assets/images/Home/animal-5.jpg" class="d-block" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <p>Gato filhote</p>
              <p>Pedrinho</p>
            </div>
          </div>
          <div class="carousel-item" data-bs-interval="2000">
            <img src="@/assets/images/Home/animal-3.jpg" class="d-block" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <p>Lulu</p>
              <p>Cadela porte médio</p>
            </div>
          </div>
          <div class="carousel-item">
            <img src="@/assets/images/Home/animal-3.jpg" class="d-block" alt="...">
            <div class="carousel-caption d-none d-md-block">
              <p>Rajado</p>
              <p>Cachorro adulto</p>
            </div>
          </div>
        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="prev">
          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleDark" data-bs-slide="next">
          <span class="carousel-control-next-icon" aria-hidden="true"></span>
          <span class="visually-hidden">Next</span>
        </button>
      </div>
    </div>
  </div>
</template>

<script src="./Index.js"></script>
<style src="./Index.css">
</style>
