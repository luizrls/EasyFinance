import Home from "@/views/Home.vue";
import Login from "@/views/Login.vue";
import SobreNos from "@/views/SobreNos.vue";
import PageNotFound from "@/views/PageNotFound.vue";

const routes = [
  {
    name: "Home",
    path: "/",
    component: Home,
  },
  {
    name: "Login",
    path: "/Login",
    component: Login,
  },
  {
    name: "SobreNos",
    path: "/SobreNos",
    component: SobreNos,
  },
  { path: "*", component: PageNotFound },
];

export default routes;
