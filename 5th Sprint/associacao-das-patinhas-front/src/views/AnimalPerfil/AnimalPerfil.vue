<template>
  <article>
    <div id="animal-perfil" class="animal-perfil-princ">
      <!-- INFOS PROVISORIAS, TROCAR PELA API DEPOIS -->
      <div class="animal-perfil-img">
        <img src="https://cataas.com/cat" alt="imagem-animal-pretendido" />

        <div class="tags-filtro">
          <!--linkar aqui com a api as tags que estao registradas no animal -->
          #{{ animal.sexoDesc }} #{{ animal.porteDesc }} #{{ animal.idadeDesc }}
        </div>
      </div>

      <div class="descricao-animal">
        <h1 class="nome-animal">{{ animal.nome }}</h1>
        <p class="animal-txt">
          Está em {{ animal.cidade }}, {{ animal.localizacao }} <br />
          A história de {{ animal.nome }} <br />
          {{ animal.descricao }}<br />
          Mais detalhes sobre {{ animal.nome }} <br />
          Vacinas: {{ animal.vacinas }} | Microchip: {{ animal.microchipDesc }} | Cadastrado: {{ animal.castradoDesc }} | Deficiência:
          {{ animal.deficienciaDesc }}       
        </p>

        <div class="container mt-5">
          <div class="row">
            <div class="adocao-btn">
              <button class="adocao-btn-item" data-bs-toggle="modal" data-bs-target="#postModal">VOU ADOTAR!</button>
            </div>
          </div>
          <div class="modal fade" id="postModal" tabindex="-1" aria-labelledby="postModalLabel" aria-hidden="true">
            <div class="modal-dialog">
              <div class="modal-content">
                <div class="modal-header">
                  <h5 class="modal-title" id="postModalLabel">Formulário de interesse de adoção!</h5>
                  <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                  <div class="mb-2">
                    <div class="form-header">
                      <div class="input-group">
                        <div class="input-box-interesse">
                          <label for="elementoNome" class="form-label">Nome</label>
                          <input v-model="interesse.nome" type="text" name="body" class="form-control" id="elementoNome"
                            placeholder="Digite o seu nome">
                        </div>
                        <div class="input-box-interesse">
                          <label for="elementoTelefone" class="form-label">Telefone</label>
                          <input v-model="interesse.telefone" type="text" name="body" class="form-control"
                            id="elementoTelefone" placeholder="Digite o seu telefone">
                        </div>
                        <div class="input-box-interesse">
                          <label for="elementoEmail" class="form-label">E-mail</label>
                          <input v-model="interesse.email" type="text" name="body" class="form-control"
                            id="elementoEmail" placeholder="Digite o seu e-mail">
                        </div>

                      </div>
                    </div>
                    <div class="modal-footer">


                      <button class="adocao-btn-enviar" type="button" data-bs-dismiss="modal"
                        v-on:click="postInteresseAdocacao">Enviar</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </article>

  <aside>
    <div class="sugestoes">
      <h2>Outros peludinhos que também precisam de um lar</h2>

      <div class="outros-animais">
        <RouterLink to="/busca">
          <img src="@/assets/images/PaginaAnimal/animal-1.jpg" alt="" />
          <p>Lulu</p>
        </RouterLink>
        <RouterLink to="/busca">
          <img src="@/assets/images/PaginaAnimal/animal-6.jpg" alt="" />
          <p>Rajado</p>
        </RouterLink>
        <RouterLink to="/busca">
          <img src="@/assets/images/PaginaAnimal/animal-7.jpg" alt="" />
          <p>Gigante</p>
        </RouterLink>
        <RouterLink to="/busca">
          <img src="@/assets/images/PaginaAnimal/animal-8.jpg" alt="" />
          <p>Soneca</p>
        </RouterLink>
      </div>
    </div>
  </aside>
</template>

<script src="./AnimalPerfil.js"></script>
<style src="./AnimalPerfil.css">
</style>