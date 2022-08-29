<template>
    <div id="estados" class="input-box">
        <label class="form-label" for="localizacao">Estado</label>
        <select id="UF" name="UF" :value="estado" @change="changeEstado">
            <option value="">Selecione</option>
            <option :value="item" v-for="item in listaUF">{{ item }}</option>
        </select>
    </div>
    <div class="input-box">
        <label class="form-label" for="localizacao">Cidade</label>
        <select id="UF" name="UF" :value="cidade" @change="changeCidade">
            <option value="">Selecione</option>
            <option :value="item" v-for="item in listaCidades[estado]">{{item}}</option>
        </select>
    </div>
</template>

<script src="./EstadosECidades.js"></script>