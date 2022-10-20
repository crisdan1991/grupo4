import { createWebHistory, createRouter } from 'vue-router';

// import Vue from 'vue'
// import VueBodyClass from 'vue-body-class'
// import store from '@/store';

const routes = [
  {
    path: '/',
    name: 'login',
    component: () => import('@/views/Index.vue'),
    meta:{
      libre: true,
    }
  }
]

const router = createRouter({
  history:createWebHistory(import.meta.env.BASE_URL),
  routes
})

router.beforeEach((to, from, next) => {
  const data = sessionStorage.getItem("dataLoginUser")

  if (to.name !== 'login' && !data && !to.matched.some(record => record.meta.libre)) 
    next({ name: 'login' })
  else 
    next()
})

export default router
