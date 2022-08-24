<template>
    <div id="pag-adm">
        <div class="container text-center">
            <div class="row">
                <div class="col">
                    <div class="adm-anim">
                        <h1>Animais</h1>
                        <button> <a RouterLink="/4th Sprint/alteracao-de-animal.html">
                                Alteração de cadastro
                            </a></button>
                        <button>
                            <a RouterLink="/4th Sprint/busca.html">
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
                            <a RouterLink="/4th Sprint/alteracao-de-cadastro.html">
                                Alteração de cadastro
                            </a></button>
                        <button>
                            <a href="#">
                                Lista de usuários
                            </a></button>
                        <button>
                            <a href="#">
                                Deletar um usuário
                            </a></button>
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
</template>

<script src="./adm.js"></script>
<style src="./adm.css"></style>