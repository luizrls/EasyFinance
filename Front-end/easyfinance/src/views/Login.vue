<template>
    <div class="container" id="container">
      <div class="row">
        <div class="col-md-8 col-sm-12">
          <img
            src="@/assets/img/Logo.png"
            class="img-fluid"
            alt="Responsive image"
            width="700"
            height="300"
            id="logo"
          />
        </div>

        <div class="col-md-4 col-sm-12 text-justify" id="login-entrar">
          <form>
            <div class="form-group">
              <h2>Login</h2>
              <label for="exampleInputEmail1">E-mail</label>
              <input
                type="email"
                class="form-control"
                id="exampleInputEmail1"
                aria-describedby="emailHelp"
              />
              <small id="emailHelp" class="form-text text-muted"
                >Nunca compartilharemos seu email com ninguém.</small
              >
            </div>
            <div class="form-group">
              <label for="exampleInputPassword1">Senha</label>
              <input
                type="password"
                class="form-control"
                id="exampleInputPassword1"
              />
            </div>
            <button type="submit" class="btn btn-primary" id="btnentrar">
              Entrar
            </button>
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
#exampleInputEmail1 {
  width: 296px;
  height: 62px;
  left: 829px;
  top: 260px;

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

#container {
  position: relative;
  width: 1181px;
  height: 592px;

  background: linear-gradient(180deg, #cecece 99.23%, #e8f2ff 100%);
  border-radius: 30px;
}

#logo {
  position: absolute;
  width: 746px;
  height: 236px;
  left: 0px;
  top: 168px;
}

#login-entrar {
  position: absolute;
  width: 435px;
  height: 592px;
  left: 746px;
  top: 2px 100% auto;

  /* Color / @white */

  background: #ffffff;
  border-radius: 7px;
}
</style>
