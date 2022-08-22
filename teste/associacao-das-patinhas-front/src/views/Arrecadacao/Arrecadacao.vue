 <template>
  <!-- Conteúdo da Página -->

  <div id="arrecadacao">
    <!-- Imagem -->
    <div class="arrecadacao-img">
      <img src="./assets/images/QueroAjudar/ajudar.jpg" alt="arrecadacao-ong">
    </div>


    <!-- Texto  -->
    <div id="arrecadacao-txt">
      <article>
        <header class="titulo">
          <h1>Contribua para essa causa!</h1>
        </header>
        <section>
          <div class="descricao">
            <p>
              O Abrigo das patinhas tem como finalidade ajudar os animais sem um lar, portanto
              somos um projeto sem fins lucrativos, porém esses animais necessitam de cuidados
              até encontrarem uma família, <i>incluindo ração, produtos de limpeza e medicamentos.</i>
              Dependemos da contribuição de todos! Se você quer ajudar a ONG apadrinhe um dos nossos
              anjinhos hoje mesmo.
            </p>
          </div>
        </section>

        <section class="infos-arrecadacao">
          <!--  ADD O LINK DO PAGSEGURO-->
          <!-- INICIO FORMULARIO BOTAO PAGSEGURO -->
          <div id="pagseguro">
            <form action="https://pagseguro.uol.com.br/checkout/v2/donation.html" method="post">
              <!-- NÃO EDITE OS COMANDOS DAS LINHAS ABAIXO -->
              <input type="hidden" name="currency" value="BRL" />
              <input type="hidden" name="receiverEmail" value="assocdaspatinhas@gmail.com" />
              <input type="hidden" name="iot" value="button" />
              <input type="image"
                src="https://stc.pagseguro.uol.com.br/public/img/botoes/doacoes/209x48-doar-azul-assina.gif"
                name="submit" alt="Pague com PagSeguro - é rápido, grátis e seguro!" />
            </form>
          </div>
          <!-- FINAL FORMULARIO BOTAO PAGSEGURO --><br>
          <a><i class="ion-social-whatsapp"> Whatsapp - (16) 99738-2076</i></a>
        </section>
      </article>
    </div>

  </div>
</template>

    <script src="./Arrecadacao.js"></script>
    <style src="./Arrecadacao.css">
    </style>