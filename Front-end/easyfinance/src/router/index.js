import Vue from "vue";
import Router from "vue-router";
import routes from "./routes";

Vue.use(Router);

const router = new Router({
  routes,
  mode: "history",
  history: true,
  base: process.env.BASE_URL,
});

export default router;
