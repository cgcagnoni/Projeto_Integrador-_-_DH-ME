<template>
  <div id="pag-adm">
    <div class="container text-center">
      <div class="row">
        <div class="col">
          <div class="adm-anim">
            <h1>Animais</h1>
            <RouterLink to="/alteracao-animal">
              <button>Alteração de cadastro</button>
            </RouterLink>

            <RouterLink to="/busca">
              <button>Buscar um animal</button>
            </RouterLink>

            <button type="button" v-on:click="listarTodosAnimais">
              Lista de animais
            </button>

            <!-- botao de deletar animal -->
            <div class="container mt-5">
              <div class="row">
                <div class="deletar_animal-btn">
                  <button
                    class="deletar_animal-btn-item"
                    data-bs-toggle="modal"
                    data-bs-target="#postModal"
                  >
                    Deletar um animal
                  </button>
                </div>
              </div>
              <div
                class="modal fade"
                id="postModal"
                tabindex="-1"
                aria-labelledby="postModalLabel"
                aria-hidden="true"
              >
                <div class="modal-dialog">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="postModalLabel">
                        Deletar animal do banco de dados
                      </h5>
                      <button
                        type="button"
                        class="btn-close"
                        data-bs-dismiss="modal"
                        aria-label="Close"
                      ></button>
                    </div>
                    <div class="modal-body">
                      <div class="mb-2">
                        <div class="form-header">
                          <div class="input-group">
                            <div class="input-box-interesse">
                              <label for="elementoNome" class="form-label"
                                >Informe o ID do animal</label
                              >
                              <input
                                type="text"
                                name="body"
                                class="form-control"
                                id="elementoNome"
                                placeholder="Digite o ID"
                              />
                            </div>
                          </div>
                        </div>
                        <div class="modal-footer">
                          <button
                            class="deletar_animal-btn-enviar"
                            type="button"
                            data-bs-dismiss="modal"
                            v-on:click="deletarAnimal"
                          >
                            Deletar
                          </button>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="col">
          <div class="adm-user">
            <h1>Usuários</h1>

            <RouterLink to="alteracao-cadastro">
              <button>Alteração de cadastro</button>
            </RouterLink>

            <button v-on:click="listarTodosUsuarios()">
              Lista de usuários
            </button>

            <!-- botao de deletar usuario -->
            <div class="container mt-5">
              <div class="row">
                <div class="deletar_usuario-btn">
                  <button
                    class="deletar_usuario-btn-item"
                    data-bs-toggle="modal"
                    data-bs-target="#postModal"
                  >
                    Deletar um usuário
                  </button>
                </div>
              </div>
              <div
                class="modal fade"
                id="postModal"
                tabindex="-1"
                aria-labelledby="postModalLabel"
                aria-hidden="true"
              >
                <div class="modal-dialog">
                  <div class="modal-content">
                    <div class="modal-header">
                      <h5 class="modal-title" id="postModalLabel">
                        Deletar usuário do banco de dados
                      </h5>
                      <button
                        type="button"
                        class="btn-close"
                        data-bs-dismiss="modal"
                        aria-label="Close"
                      ></button>
                    </div>
                    <div class="modal-body">
                      <div class="mb-2">
                        <div class="form-header">
                          <div class="input-group">
                            <div class="input-box-interesse">
                              <label for="elementoNome" class="form-label"
                                >Informe o ID do usuário</label
                              >
                              <input
                                type="text"
                                name="body"
                                class="form-control"
                                id="elementoNome"
                                placeholder="Digite o ID"
                              />
                            </div>
                          </div>
                        </div>
                        <div class="modal-footer">
                          <button
                            class="deletar_usuario-btn-enviar"
                            type="button"
                            data-bs-dismiss="modal"
                            v-on:click="deletarUsuario"
                          >
                            Deletar
                          </button>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="col">
          <div class="adm-ong">
            <h1>Administração</h1>
            <RouterLink to="/alteracao-cadastro">
              <button>Alteração de cadastro</button>
            </RouterLink>
            <button>Arrecadação</button>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div id="listas">
    <ul id="list-user">
      <li class="list-group" v-for="usuario in usuarios">
        <h1 id="listaDeUsers">Usuário {{ usuario.id }}</h1>
        <br />
        Username: {{ usuario.username }} <br />
        Nome: {{ usuario.nome }}<br />
        Sobrenome: {{ usuario.sobrenome }}<br />
        Localizacao: {{ usuario.localizacao }}<br />
        E-mail: {{ usuario.email }}<br />
        Telefone: {{ usuario.telefone }}
        <hr />
      </li>
    </ul>
    <ul id="list-animais">
      <li class="list-group" v-for="animal in animais">
        <h1 id="lista-de-animais">Animal {{ animal.id }}</h1>
        <br />
        Nome: {{ animal.nome }} <br />
        Espécie: {{ animal.especie }}<br />
        Localização: {{ animal.localizacao }}<br />
        Usuário: {{ animal.usuario.id }}<br />
        Disponibilidade: {{ animal.status}}<br />
      </li>
    </ul>
  </div>
</template>

<script src="./adm.js"></script>
<style src="./adm.css"></style>
