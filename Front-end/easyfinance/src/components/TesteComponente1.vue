<template>
<div class='TesteComponente1'>
  <h3>{{titulo}}</h3>
  <SubComponente :items="items"/>
</div>
</template>

<script>
import SubComponente from './SubComponente.vue'
export default {
name: 'TesteComponente1',
components:{
    SubComponente
},
props:{
    titulo: String
},
data: ()=>{
    return {
        items: ["Novo item1", "Novo Item2", "Novo Item3", "Novo Item3", "Novo Item3", "Novo Item3", "Novo Item3", "Novo Item3"]
    }
}
}

</script>

<style scoped>
.TesteComponente1{
    background: black;
    color: brown;
}
</style>