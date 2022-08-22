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