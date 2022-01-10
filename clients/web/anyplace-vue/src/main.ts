import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'


// DEPENDENCIES:
import 'bootstrap'; // js library

import '@fortawesome/fontawesome-free/css/all.css'
import '@fortawesome/fontawesome-free/js/all.js'


createApp(App).use(store).use(router).mount('#app')
export const SCREEN_SIZE_MEDIUM=process.env.VUE_APP_SCREEN_SIZE_MEDIUM
import '@/assets/js/global.js' // AVOID using JavaScript (just use TypeScript)
import '@/assets/ts/global.ts'