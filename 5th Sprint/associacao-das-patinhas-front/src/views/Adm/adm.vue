<template>
  <div id="pag-adm">
    <div class="container text-center">
      <div class="row">
        <div class="col">
          <div class="adm-anim">
            <h1>Animais</h1>
            <button class="button" type="button" v-on:click="buscarAnimal">Buscar um animal</button>
            <button class="button" type="button" v-on:click="listarTodosAnimais">Lista de animais</button>
            <button class="button" type="button" v-on:click="listarAnimaisDisponiveis">Lista de animais
              disponíveis</button>
            <button class="button" type="button" v-on:click="listarAnimaisAdotados">Lista de animais adotados</button>


            <!-- botao de deletar animal -->

            <button class="button" data-bs-toggle="modal" data-bs-target="#postModalAnimal">
              Deletar um animal
            </button>
          </div>
        </div>
        <div class="modal fade" id="postModalAnimal" tabindex="-1" aria-labelledby="postModalLabelAnimal"
          aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h5 class="modal-title" id="postModalLabelAnimal">
                  Deletar animal do banco de dados
                </h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
              </div>
              <div class="modal-body">
                <div class="mb-2">
                  <div class="form-header">
                    <div class="input-group">
                      <div class="input-box-interesse">
                        <label for="elementoIDAnimal" class="form-label">Informe o ID do animal</label>
                        <input v-model="idAnimal.id" type="text" name="body" class="form-control" id="elementoIDAnimal"
                          placeholder="Digite o ID" />
                      </div>
                    </div>
                  </div>
                  <div class="modal-footer">
                    <button class="deletar_animal-btn-enviar" type="button" data-bs-dismiss="modal"
                      v-on:click="deletarAnimal">
                      Deletar
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="col">
          <div class="adm-user">
            <h1>Usuários</h1>
            <button class="button" type="button" v-on:click="listarTodosUsuarios">Lista de usuários</button>

            <!-- botao de deletar usuario -->
            <button class="button" data-bs-toggle="modal" data-bs-target="#postModalUser">
              Deletar um usuário
            </button>
          </div>
        </div>
        <div class="modal fade" id="postModalUser" tabindex="-1" aria-labelledby="postModalLabelUser"
          aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h5 class="modal-title" id="postModalLabelUser">
                  Deletar usuário do banco de dados
                </h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
              </div>
              <div class="modal-body">
                <div class="mb-2">
                  <div class="form-header">
                    <div class="input-group">
                      <div class="input-box-interesse">
                        <label for="elementoIDUser" class="form-label">Informe o ID do usuário</label>
                        <input v-model="idUsuario.id" type="text" name="body" class="form-control" id="elementoIDUser"
                          placeholder="Digite o ID" />
                      </div>
                    </div>
                  </div>
                  <div class="modal-footer">
                    <button class="deletar_usuario-btn-enviar" type="button" data-bs-dismiss="modal"
                      v-on:click="deletarUsuario">
                      Deletar
                    </button>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="col">
          <div class="adm-ong">
            <h1>Administração</h1>

            <button class="button" type="button" v-on:click="alterarCadastroAdm">Alteração de cadastro</button>

            <button class="button" type="button" v-on:click="arrecadacao">Arrecadação</button>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div id="listas">
    <ul id="list-user">
      <li class="list-group" v-for="usuario in usuarios">
        <h1 id="listaDeUsers">Usuário {{  usuario.id  }}</h1>
        <br />
        Username: {{  usuario.username  }} <br />
        Nome: {{  usuario.nome  }}<br />
        Sobrenome: {{  usuario.sobrenome  }}<br />
        Cidade: {{  usuario.cidade  }}<br />
        Localizacao: {{  usuario.localizacao  }}<br />
        E-mail: {{  usuario.email  }}<br />
        Telefone: {{  usuario.telefone  }}
        <hr />
      </li>
    </ul>
    <ul id="list-animais">
      <li class="list-group" v-for="animal in animais">
        <RouterLink :to="{ name: 'alteracao-animal', params: { id: animal.id } }">
          <h1 id="lista-de-animais">Animal {{  animal.id  }}</h1>
        </RouterLink>
        <br />
        Nome: {{  animal.nome  }} <br />
        Espécie: {{  animal.especieDesc  }}<br />
        Cidade: {{  animal.cidade  }}<br />
        Localização: {{  animal.localizacao  }}<br />
        Usuário: {{  animal.usuario.id  }}<br />
        Disponibilidade: {{ animal.disponibilidade }}
      </li>
    </ul>
  </div>
</template>

<script src="./adm.js"></script>
<style src="./adm.css">
</style>
