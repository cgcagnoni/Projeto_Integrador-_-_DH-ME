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
                            <button>
                                Buscar um animal
                            </button>
                        </RouterLink>
                        <RouterLink to="#">
                            <button type="button" v-on:click="criarListaAnimais">

                                Lista de animais
                            </button>
                        </RouterLink>
                        <RouterLink to="#">
                            <button>

                                Deletar um animal
                            </button>
                        </RouterLink>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-user">
                        <h1>Usuários</h1>
                        <RouterLink to="/alteracao-cadastro">
                            <button>

                                Alteração de cadastro
                            </button>
                        </RouterLink>
                        <RouterLink to="#">
                            <button>

                                Lista de usuários
                            </button>
                        </RouterLink>
                        <RouterLink to="#">
                            <button>

                                Deletar um usuário
                            </button>
                        </RouterLink>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-ong">
                        <h1>Administração</h1>
                        <RouterLink to="#">
                        <button>
                           
                                Doações
                            </button>
                            </RouterLink>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script src="./adm.js"></script>
<style src="./adm.css">
</style>