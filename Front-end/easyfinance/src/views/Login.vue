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

        <div class="col-md-4 col-sm-12 text-justify " id="login-entrar">
          <form >
            <div class="form-group" >
              <h2>Login</h2>
              <label for="InputEmail">E-mail</label>
              <input
                type="email"
                class="form-control"
                id="InputEmail"
                placeholder="Digite seu E-mail"
                aria-describedby="emailHelp"
              />
              <small id="emailHelp" class="form-text text-muted"
                >Nunca compartilharemos seu email com ninguém.</small
              >
            </div>
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
          </form>
        </div>
      </div>
    </div>
</template>

<script>
export default {
  name: "Login",
};
</script>

}
<style scoped>
.container-md {
  position: relative;
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
