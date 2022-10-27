import { createApp } from 'vue'
import { createStore } from 'vuex'
import router from '@/router'

// Vue.use(Vuex)

export default createStore({
  state: {
    layout: 'principal-layout',

    token: null,
    authUser: null,
    paginaActual: '',
    textoPaginacion: 'Mostrar',

    nombreUsuario: '',

    controlStyle:{
      variant: 'outlined',
      density: 'compact'
    },

    dataLogin: null
  },

  mutations: {
    SET_COMPONENT (state, newLayout) {
      state.activeComponent = newLayout
    },

    setDataLogin(state, dataLogin){
      state.dataLogin = dataLogin;
    }
  }
})
