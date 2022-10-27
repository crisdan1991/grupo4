import { createApp } from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify'
// import { loadFonts } from './plugins/webfontloader'

import router from './router'
import store from '@/store'

import HelperMixin from "../src/mixins/mixin.js";
import MixinRules from "../src/mixins/mixinRules.js";

const app = createApp(App)

app.mixin(HelperMixin)
app.mixin(MixinRules)

// loadFonts()

app
  .use(vuetify)
  .use(router)
  .use(store)
  .mount('#app')
