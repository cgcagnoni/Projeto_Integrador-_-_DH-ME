<template>
    <div id="pag-adm">
        <div class="container text-center">
            <div class="row">
                <div class="col">
                    <div class="adm-anim">
                        <h1>Animais</h1>
                        <RouterLink to="/alteracao-animal">
                            <button>
                                Alteração de cadastro
                            </button>
                        </RouterLink>

                        <RouterLink to="/busca">
                            <button>Buscar um animal</button>
                        </RouterLink>

                        <button type="button" v-on:click="listarTodosAnimais">
                            Lista de animais
                        </button>
        
                        <button>                             
                                Deletar um animal
                                
                        </button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-user">
                        <h1>Usuários</h1>
                        
                            <RouterLink to="alteracao-cadastro">
                                <button> Alteração de cadastro</button>
                            </RouterLink>                                
                            
                        <button v-on:click="listarTodosUsuarios()">
                            Lista de usuários
                        </button>
                        <button>                           
                                Deletar um usuário                                
                        </button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-ong">
                        <h1>Administração</h1>
                        <RouterLink to="/alteracao-cadastro">
                            <button> Alteração de cadastro</button>
                        </RouterLink>
                        <button>
                                Arrecadação
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="listas">
        <ul id="list-user">
            <li class="list-group" v-for="usuario in usuarios">
                <h1 id="listaDeUsers">Usuário {{ usuario.id }}</h1><br />
                Username: {{ usuario.username }} <br />
                Nome: {{ usuario.nome }}<br />
                Sobrenome: {{ usuario.sobrenome }}<br />
                Localizacao: {{ usuario.localizacao }}<br />
                E-mail: {{ usuario.email }}<br />
                Telefone: {{ usuario.telefone }}
                <hr>
            </li>
        </ul>
        <ul id="list-animais">
            <li class="list-group" v-for="animal in animais">
                <h1 id="lista-de-animais">Animal {{ animal.id }}</h1><br />
                Nome: {{ animal.nome }} <br />
                Espécie: {{ animal.especie }}<br />
                Localização: {{ animal.localizacao }}<br />
                Usuário: {{ animal.usuario.id }}<br />
            </li>
        </ul>
    </div>
</template>

<script src="./adm.js"></script>
<style src="./adm.css">
</style>