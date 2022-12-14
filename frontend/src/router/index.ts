import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import FormView from '../views/FormView.vue'
import ContactView from '../views/ContactView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: "home",
      component: HomeView
    },
    {
      path: '/yhteystiedot',
      name: "contact",
      component: ContactView
    },
    {
      path: '/arvioi',
      name: "form",
      component: FormView
    },
  ]
})

export default router
