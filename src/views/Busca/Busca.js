<script>
    //Criando uma variável para guardar a id da div que vamos inserir o catálogo
    var catalog = document.getElementById("catalog");

    //Função que recebe como argumento a classe da div que será criada e o código html da div
    function criaCard(catalogItem, html) {
      //extra html you want to store.
      return '<div class="' + catalogItem + '">' + html + "</div>";
    }

    //Loop para que sejam criadas várias divs com os cards dos animais
    //Incluir dados (nome, porte etc) e link para a página do animal
    for (var i = 0; i < 5; i++) {
      catalog.innerHTML += criaCard(
        "catalog-row",
        `
          <div class="row">
              <div class="catalog-card col">
                <a href="/4th Sprint/animal-perfil.html">
                <img src="./assets/images/busca/animal-4.jpg">
                <h1 class="catalog-name"> Belinha </h1>
                </a>
              </div>
              <div class="catalog-card col">
                <a href="/4th Sprint/animal-perfil.html">
                <img src="./assets/images/busca/animal-7.jpg">
                <h1 class="catalog-name"> Rajado </h1>
                </a>
              </div>
              <div class="catalog-card col">
                <a href="/4th Sprint/animal-perfil.html">
                <img src="./assets/images/busca/animal-6.jpg">
                <h1 class="catalog-name"> Dorothéia </h1>
                </a>
              </div>
          </div>
        
        `
      );
    }
  </script>