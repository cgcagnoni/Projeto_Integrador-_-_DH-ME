<template>
    <div id="navbar" class="row">
        <div class="nav-logo col">
         <img class="navbar-logo" src="@/assets/images/Home/logo.png" alt="logo">
        </div>
        <div class="dropdown col">   
            <button v-if="logged" v-on:click="logout">Logout</button>  
            <button v-else v-on:click="login">Login</button>                    
            <button class="btn btn-lg dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false"><i
                    class="fa-solid fa-bars"></i> </button>
            <ul class="dropdown-menu">                
                <li><RouterLink class="dropdown-item" to="/">Página inicial</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/busca">Quero adotar</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/doacao-animal">Quero divulgar um animal para adoção</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/arrecadacao">Quero ajudar a ONG</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/cadastro">Cadastre-se</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/perfil">Meu perfil</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/sobre">Sobre nós</RouterLink></li>
                <li><RouterLink class="dropdown-item" to="/login">Login</RouterLink></li>
                <li>
                    <hr class="dropdown-divider">
                </li>
                <li><RouterLink class="dropdown-item" to="/contato">Entre em contato</RouterLink></li>
            </ul>
        </div>
    </div>
</template>
<script src="./Header.js"></script>
<style src="./Header.css"></style>