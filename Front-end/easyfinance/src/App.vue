<template>
  <div id="app">
    <!-- <HelloWorld msg="Welcome to Your Vue.js App"/> -->
    <!-- <TesteComponente1 titulo="Novo titulo 2"/> -->
    <router-view />
  </div>
</template>

<script>
//import HelloWorld from './components/HelloWorld.vue'
//import TesteComponente1 from './components/TesteComponente1.vue'
export default {
  name: 'App', 
  components: {
    // HelloWorld
    //TesteComponente1
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
@viewport{
    zoom: 1.0;
    width: device-width;
}
</style>
