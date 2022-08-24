import { createRouter, createWebHistory } from 'vue-router'
import IndexView from '../views/Index/Index.vue'
import AnimalPerfilView from '../views/AnimalPerfil/AnimalPerfil.vue'
import ArrecadacaoView from '../views/Arrecadacao/Arrecadacao.vue'
import BuscaView from '../views/Busca/Busca.vue'
import CadastroView from '../views/Cadastro/Cadastro.vue'
import ContatoView from '../views/Contato/Contato.vue'
import DoacaoAnimalView from '../views/DoacaoAnimal/DoacaoAnimal.vue'
import LoginView from '../views/Login/Login.vue'
import PerfilView from '../views/Perfil/Perfil.vue'
import admView from '../views/Adm/adm.vue'
import SobreView from '../views/Sobre/Sobre.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'index',
      component: IndexView
    },
    {
      path: '/animalperfil',
      name: 'animalperfil',
      component: AnimalPerfilView
    },
    {
      path: '/arrecadacao',
      name: 'arrecadacao',
      component: ArrecadacaoView
    },
    {
      path: '/busca',
      name: 'busca',
      component: BuscaView
    },
    {
      path: '/cadastro',
      name: 'cadastro',
      component: CadastroView
    },
    {
      path: '/contato',
      name: 'contato',
      component: ContatoView
    },
    {
      path: '/doacao-animal',
      name: 'doacao-animal',
      component: DoacaoAnimalView

    },    
    {
      path: '/login',
      name: 'login',
      component: LoginView
    },
    {
      path: '/perfil',
      name: 'perfil',
      component: PerfilView
    },
    {
      path: '/sobre',
      name: 'sobre',
      component: SobreView
      //component: () => import('../views/Login/Login.vue')
    },
    
    {
      path: '/adm',
      name: 'adm',
      component: admView
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
