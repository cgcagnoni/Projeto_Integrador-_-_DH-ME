import { createRouter, createWebHistory } from 'vue-router'
import IndexView from '../views/Index/Index.vue'
import LoginView from '../views/Login/Login.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'index',
      component: IndexView
    },
    {
      path: '/busca',
      name: 'busca',
      component: LoginView
    },
    {
      path: '/doacao-animal',
      name: 'doacao-animal',
      component: LoginView
    },
    {
      path: '/arrecadacao',
      name: 'arrecadacao',
      component: LoginView
    },
    {
      path: '/cadastro',
      name: 'cadastro',
      component: LoginView
    },
    {
      path: '/perfil',
      name: 'perfil',
      component: LoginView
    },
    {
      path: '/sobre',
      name: 'sobre',
      component: () => import('../views/Login/Login.vue')
    },
    {
      path: '/Login',
      name: 'login',
      component: LoginView
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      
    }
  ]
})

export default router
