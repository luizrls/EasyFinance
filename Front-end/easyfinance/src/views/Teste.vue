<template>
<b-container>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group class="text-justify"
        id="input-group-1"
        label="Nome" 
        label-for="input-1"
      >
        <b-form-input 
          id="input-1"
          v-model="form.name"
          type="Name"
          placeholder="Nome da Transação"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2" label="Valor" label-for="input-2" class="text-justify">
        <b-form-input
          id="input-2"
          v-model="form.value"
          placeholder="Valor da Transação"
          required
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2" label="Data" label-for="input-2" class="text-justify">
        <b-form-input
          id="input-2"
          v-model="form.date"
          placeholder="Data da Transação"
          required
        ></b-form-input>
      </b-form-group>

    </b-form>
  </div>
</b-container>
</template>

<script>
export default {
    data() {
      return {
        form: {
          email: '',
          name: '',
          food: null,
          checked: []
        },
        foods: [{ text: 'Select One', value: null }, 'Carrots', 'Beans', 'Tomatoes', 'Corn'],
        show: true
      }
    },
}

  


</script>

<style>

</style>