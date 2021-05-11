import Vue from "vue";
import App from "./App.vue";

import router from "@/router";
import { BootstrapVue, IconsPlugin } from "bootstrap-vue";

import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";

// Isso importa todos os componentes de layout, como <b-container>, <b-row>, <b-col>
import {LayoutPlugin} from 'bootstrap-vue';
Vue.use (LayoutPlugin)

Vue.config.productionTip = false;

// Make BootstrapVue available throughout your project
Vue.use(BootstrapVue);
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin);

new Vue({
  render: (h) => h(App),
  router,
}).$mount("#app");
