<template>
  <!-- Conteúdo da Página -->

  <div id="sobre-nos">
    <!-- Imagem -->
    <div class="sobre-img">
      <img src="@/assets/images/Sobre/sobre.jpg" alt="sobre-ong" />
    </div>

    <!-- Texto  -->
    <div id="sobre-txt">
      <article>
        <header class="titulo">
          <h1>Quem somos nós</h1>
        </header>
        <section>
          <div class="descricao">
            <p>
              A associação das patinhas é uma ONG criada por pessoas apaixonadas
              por tecnologia e animais que uniram seus dois amores em um projeto
              incrível para divulgação e ajuda aos animaizinhos sem um lar.
            </p>
          </div>
        </section>

        <section class="link">
          <h2>Ficou interessado?</h2>
          <div class="links">
            <RouterLink to="/cadastro">Divulgue um animal</RouterLink><br />
            <RouterLink to="/busca">Adote um melhor amigo</RouterLink><br />
            <RouterLink to="/arrecadacao">Contribua com a ONG</RouterLink>
          </div>
        </section>
      </article>
    </div>
  </div>
</template>

<script src="./Sobre.js"></script>
<style src="./Sobre.css"></style>
