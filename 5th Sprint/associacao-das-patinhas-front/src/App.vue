<script setup>
import { RouterLink, RouterView } from 'vue-router'
import Header from '@/components/Header/Header.vue'
import Footer from '@/components/Footer/Footer.vue'
</script>

<template>
  <div id="container">
    <Header></Header>

    <RouterView />

    <Footer></Footer>
  </div>
</template>

<style scoped>
html{
    height: 100%;
    box-sizing: border-box;
}

body {
    position: relative;
    margin: 0;
    padding-bottom:0%
  }

template {
    position: relative;
    margin: 0;
    padding-bottom:0%
  }

#container{
  margin: 0 auto;
  height: 100%;
  width: 100%;
  align-items: center;
}

</style>