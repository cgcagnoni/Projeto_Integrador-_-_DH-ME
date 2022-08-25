<template>
    <div id="pag-adm">
        <div class="container text-center">
            <div class="row">
                <div class="col">
                    <div class="adm-anim">
                        <h1>Animais</h1>
                        <button> <a href="/alteracao-animal">
                         Alteração de cadastro       
                            </a></button>
                        <button>
                            <a href="/busca">
                                Buscar um animal
                            </a></button>
                        <button type="button" v-on:click="criarListaAnimais">
                            <a href="#">
                                Lista de animais
                            </a></button>
                        <button>
                            <a href="#">
                                Deletar um animal
                            </a></button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-user">
                        <h1>Usuários</h1>
                        <button>
                            <a href="alteracao-cadastro">
                                Alteração de cadastro
                            </a></button>
                        <button v-on:click="listarTodosUsuarios()">
                                Lista de usuários
                        </button>
                        <button>
                            <a href="#">
                                Deletar um usuário
                            </a>
                        </button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-ong">
                        <h1>Administração</h1>
                        <button>
                            <a RouterLink="/4th Sprint/alteracao-de-cadastro.html">
                                Doações
                            </a></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="listas">
        <ul id="list-user">
            
            <li class="list-group" v-for="usuario in listaUsuarios">
            <h1 id="listaDeUsers">Usuário {{ usuario.id }}</h1><br/>
                Username: {{ usuario.username }} <br/>
                Nome: {{ usuario.nome }}<br/>
                Sobrenome: {{ usuario.sobrenome }}<br/>
                Localizacao: {{ usuario.localizacao }}<br/>
                E-mail: {{ usuario.email }}<br/>
                Telefone: {{ usuario.telefone }}<hr>
            </li>
        </ul>
    </div>
</template>

<script src="./adm.js"></script>
<style src="./adm.css"></style>