<template>

  <div class="container-md">
    <div class="row">
      <div class="col-md-8 col-sm-12">
        <img
          src="@/assets/img/Logo.png"
          class="img-fluid max-width: 100% height: auto"
          alt="Responsive image"
          width="700"
          height="300"
        />
      </div>

      <div class="col-md-4 col-sm-12 text-justify" id="form">
        <form>
          <h2 id="txtLogin">Login</h2>

          <img
          src="@/assets/img/logoPessoa.png"
          class="img-fluid max-width: 100% height: auto"
          alt="Responsive image"
          id="img-fluid-pessoa"
          />
          <div class="form-group">
            <label id="txtEmail" for="InputEmail">Email</label>
            <input
              type="email"
              class="form-control"
              id="Email"
              placeholder="Digite seu e-mail"
            />
          </div>
          <div class="form-group">
            <label id="txtSenha" for="InputPassword">Senha</label>
            <input
              type="password"
              class="form-control"
              id="Password"
              placeholder="Digite sua senha"
            />
          </div>
          <button type="submit" class="btn btn-primary" id="btnEntrar" >
          <a href="/Home"></a>Entrar</button
          ><br>
          <div class="text-center">
            <label id="Cadastre"
              >Não tem Cadastro?<a href="/Cadastro"> Cadastre-se </a>
            </label>
          </div>
        </form>

      </div>
    </div>
  </div>
</template>

<script>
import usuarioAPI from '@/services/usuarioService.js';
import storageService from '@/services/storageService.js';
export default {
  name: "Login",
  data() {
    return {
      login: "",
      senha: "",
      usuario:{},
      loginFail: false,
    }
  },
  methods: {
    async logar(){
      this.usuario = await usuarioAPI.logar(this.login, this.senha);
      if(this.usuario){
        storageService.setItem("token",this.usuario.login);
        this.$router.push('/');
        this.loginFail = false;
      }else{
        this.loginFail = true;
      }
    }
  },

};

</script>

<style>
#txtLogin {
  position: absolute;
  width: 75px;
  height: 42px;
  left: calc(50% - 75px / 2 + 16px);
  top: calc(50% - 42px / 2 - 129px);

  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 28px;
  line-height: 42px;
  /* identical to box height */

  display: flex;
  align-items: center;

  color: #000000;
}
#Email {
  position: absolute;
  width: 345px;
  height: 62px;
  left: 20px;
  top: 260px;

  background: rgba(3, 115, 148, 0.42);
  border-radius: 10px;
}
#txtEmail {
  position: absolute;
  height: 62px;
  left: 8.81%;
  right: 34.01%;
  top: 260px;

  font-family: Poppins;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  line-height: 27px;

  color: #000000;
}
#Password {
  position: absolute;
  width: 345px;
  height: 62px;
  left: 20px;
  top: 334px;

  background: rgba(3, 115, 148, 0.42);
  border-radius: 10px;
}
#txtSenha {
  position: absolute;
  height: 62px;
  left: 8.81%;
  right: 34.01%;
  top: 334px;

  font-family: Poppins;
  font-style: normal;
  font-weight: normal;
  font-size: 18px;
  line-height: 27px;

  color: #000000;
}
#btnEntrar {
  flex-direction: row;
  align-items: center;
  padding: 8px 12px;

  position: absolute;
  width: 100px;
  height: 43px;
  left: 150px;
  top: 424px;
  color: #e5e5e5;
  background: #037394;
  box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
  border-radius: 10px;
}
#Cadastre {
  position: absolute;
  height: 20px;
  left: 20.76%;
  right: 17.5%;
  top: 495px;

  font-family: Poppins;
  font-style: normal;
  font-weight: normal;
  font-size: 14px;
  line-height: 19px;
  /* identical to box height, or 137% */

  display: flex;
  align-items: center;

  color: #037394;

  border: 1px solid #e5e5e5;
}
#img-fluid-pessoa{
    position: absolute;
    width: 99px;
    height: 90px;
    display: flex;
    left: calc(50% - 95px / 2 + 16px);
    top: calc(50% - 207px / 2 - 129px);
}
</style>
