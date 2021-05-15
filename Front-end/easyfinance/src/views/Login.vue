<template>
    <b-container fluid="md">
      <b-row fluid="md">
        <b-col cols="8" sm="12">
          <img
            src="@/assets/img/Logo.png"
            class="img-fluid max-width: 100% height: auto"
            alt="Responsive image"
            width="700"
            height="300"
          />
        </b-col>

        <b-col cols="4" sm="12" id="login-entrar">
          <div>
          <h2>Login</h2>
          <b-form @submit="onSubmit" @reset="onReset" v-if="show" >
            <b-form-group 
                  id="input-group-1"
                  label="Email"
                  label-for="InputEmail"
                  description="We'll never share your email with anyone else."
                  aria-describedby="emailHelp"
                >
                  <b-form-input
                    id="InputEmail"
                    v-model="form.email"
                    type="email"
                    placeholder="Digite seu E-mail"
                    required

              
                  >
              </b-form-input>
            </b-form-group>
            <!--  <small id="emailHelp" class="form-text text-muted"
                >Nunca compartilharemos seu email com ninguém.</small
              >-->
            <div class="form-group">
              <label for="InputPassword">Senha</label>
              <input
                type="password"
                class="form-control"
                id="InputPassword"
                placeholder="Digite sua Senha"
              />
            </div>
            <button type="submit" class="btn btn-primary" id="btnentrar">
              Entrar
            </button><br>
            <div class="text-center">  
              <label>Não tem Cadastro?<a href="/Cadastro>"> Cadastre-se </a>
              </label>
            </div>
          </b-form>
          </div>
        </b-col>
      </b-row>
    </b-container>
    
</template>

<script>
export default {
  name: "Login",

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
};
</script>

}
<style scoped>
.b-container {
  position: absolute;
  width: 1181px;
  height: 592px;

  background: linear-gradient(180deg, #cecece 99.23%, #e8f2ff 100%);
  border-radius: 30px;
}

#InputEmail {
  width: 296px;
  height: 62px;
  left: 829px;
  top: 260px;

  background: rgba(3, 115, 148, 0.42);
  border-radius: 10px;
}

#InputPassword{
  width: 296px;
  height: 62px;
  left: 829px;
  top: 334px;

  background: rgba(3, 115, 148, 0.42);
  border-radius: 10px;
}

#btnentrar {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 8px 12px;

  width: 296px;
  height: 43px;
  top: 424px;

  background: #037394;
  box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
  border-radius: 10px;
}

.img-fluid{
  position: absolute;
  width: 746px;
  height: 236px;
  left: 0px;
  top: 166px;
}

#login-entrar {
    position: absolute;
    width: 435px;
    height: 550px;
    left: 730px;
    top: 1px;
    background: #ffffff;
    border-radius: 7px;
    padding: 50px 50px 50px 50px;
    margin-left: 5px;
    margin-top: 5px;
    margin: 1em;

    display: flex;
    flex-direction: column;
    align-items: center;
    
}
</style>
