<template>
    <div id="pag-adm">
        <div class="container text-center">
            <div class="row">
                <div class="col">
                    <div class="adm-anim">
                        <h1>Animais</h1>
                        <a href="/4th Sprint/alteracao-de-animal.html"><button>
                                Alteração de cadastro
                        </a></button>
                        <a href="/4th Sprint/busca.html"><button>
                                Buscar um animal
                        </a></button>
                        <a href="#"><button type="button" v-on:click="criarListaAnimais">
                                Lista de animais
                        </a></button>
                        <a href="#"><button>
                                Deletar um animal
                        </a></button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-user">
                        <h1>Usuários</h1>
                        <a href="/4th Sprint/alteracao-de-cadastro.html"><button>
                                Alteração de cadastro
                        </a></button>
                        <a href="#"><button>
                                Lista de usuários
                        </a></button>
                        <a href="#"><button>
                                Deletar um usuário
                        </a></button>
                    </div>
                </div>
                <div class="col">
                    <div class="adm-ong">
                        <h1>Administração</h1>
                        <a href="/4th Sprint/alteracao-de-cadastro.html"><button>
                                Doações
                        </a></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>