<template>
<div class='SubComponente'>
  <ul>
      <li v-for="(item,index) in items" :key="index">{{item}}</li>
  </ul>
</div>
</template>

<script>
export default {
name: 'SubComponente',
props:{
    items: Array
}
}
</script>

<style scoped>

</style>