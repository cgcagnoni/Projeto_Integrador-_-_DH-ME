<template>
    <article>
        <div id="animal-perfil" class="row animal-perfil-princ">
            <!-- INFOS PROVISORIAS, TROCAR PELA API DEPOIS -->
            <div class="col-5 animal-perfil-img">
                <img src="./assets/images/PaginaAnimal/animal-5.jpg" alt="imagem-animal-pretendido">

                <div class="col-5 tags-filtro">
                    <!--linkar aqui com a api as tags que estao registradas no animal -->
                    #macho
                    #dócil
                    #filhote
                </div>
            </div>

            <div class="col-7 descricao-animal">
                <h1 class="nome-animal"> PEDRINHO </h1>
                <p class="animal-txt"> Pedrinho veio de uma ninhada com outros seis gatinhos, encontrados
                    abandonados em
                    um terreno.
                    Tem o pelo rajadinho e os olhos azuis, muito dócil e carinhoso. Aparenta ter em torno de 4 a
                    5 meses
                    e está pronto para ter um lar!
                </p>

                <!-- redirecionar para modal alert -->
                <div class="adocao-btn">
                    <a href=""><button class="adocao-btn-item">VOU ADOTAR!</button></a>
                </div>
            </div>
        </div>
    </article>

    <aside>
        <div class="sugestoes">
            <h2>Outros peludinhos que também precisam de um lar</h2>

            <div class="outros-animais">
                <a href="busca.html" target="_blank">
                    <img src="./assets/images/PaginaAnimal/animal-1.jpg" alt="">
                    <p>Lulu</p>
                </a>
                <a href="busca.html" target="_blank">
                    <img src="./assets/images/PaginaAnimal/animal-6.jpg" alt="">
                    <p>Rajado</p>
                </a>
                <a href="busca.html" target="_blank">
                    <img src="./assets/images/PaginaAnimal/animal-7.jpg" alt="">
                    <p>Gigante</p>
                </a>
                <a href="busca.html" target="_blank">
                    <img src="./assets/images/PaginaAnimal/animal-8.jpg" alt="">
                    <p>Soneca</p>
                </a>
            </div>
        </div>
    </aside>
</template>

<script src="./Animal-Perfil.js"></script>
<style src="./Animal-Perfil.css">
</style>