<template>
    <!-- Conteúdo da Página -->
    <div class="row" id="profilecontent">
        <div class="col-4">
            <div id="list-example" class="list-group">
                <a class="list-group-item list-group-item-action" href="#list-item-1">Meu cadastro</a>
                <a class="list-group-item list-group-item-action" href="#list-item-2">Minhas adoções</a>
                <a class="list-group-item list-group-item-action" href="#list-item-3">Minha doações</a>
                <a class="list-group-item list-group-item-action" href="#list-item-4">Segurança</a>
            </div>
        </div>
        <div class="col-8">
            <div data-bs-spy="scroll" data-bs-target="#list-example" data-bs-smooth-scroll="true"
                class="scrollspy-example" tabindex="0">
                <nav>
                    <div>
                        <h4 id="list-item-1">Meu cadastro</h4>
                        <p>Nome:</p>
                        <p>E-mail:</p>
                        <p>Telefone:</p>
                        <p>Localização:</p>
                        <br>
                        <hr class="solid">
                    </div>

                    <div>
                        <h4 id="list-item-2">Minhas adoções</h4>
                        <p>Você ainda não adotou nenhum animalzinho!</p>
                        <br>
                        <hr class="solid">
                    </div>
                    <div>
                        <h4 id="list-item-3">Minhas doações</h4>
                        <p>Você ainda não doou nenhum animalzinho!</p>
                        <br>
                        <hr class="solid">
                    </div>
                    <div>
                        <h4 id="list-item-4">Segurança</h4>
                        <p>Trocar e-mail</p>
                        <p>Trocar senha</p>
                    </div>
                </nav>
            </div>
        </div>
    </div>
</template>