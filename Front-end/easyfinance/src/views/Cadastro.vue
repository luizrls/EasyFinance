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
          <h2 id="txtCriarConta">Criar Conta</h2>
          <div class="form-group">
            <label for="InputName">Nome</label>
            <input
              type="text"
              class="form-control"
              id="InputName"
              placeholder="Digite seu nome"
            />
          </div>

          <div class="form-group">
            <label for="InputEmail">Email</label>
            <input
              type="email"
              class="form-control"
              id="InputEmail"
              placeholder="Digite seu e-mail"
            />
          </div>
          <div class="form-group">
            <label for="InputPassword">Senha</label>
            <input
              type="password"
              class="form-control"
              id="InputPassword"
              placeholder="Digite sua senha"
            />
          </div>
          <div class="form-group">
            <label for="InputPassword">Confirmar Senha</label>
            <input
              type="password"
              class="form-control"
              id="ConfirmPassword"
              placeholder="Confirme sua senha"
            />
          </div>
          <button type="submit" class="btn btn-primary text-center" id="btnCadastrar">
            Cadastrar
          </button>
        </form>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Cadastro",
};
</script>

<style>
.container-md {
  position: relative;
  width: 1181px;
  height: 592px;

  background: linear-gradient(180deg, #cecece 99.45%, #e8f2ff 100%);
  border-radius: 30px;
}

.img-fluid {
  position: absolute;
  width: 746px;
  height: 236px;
  left: 0px;
  top: 166px;
}
#form {
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
  padding: 0px;


}
#txtCriarConta{
    width: 164px;
    height: 42px;
    left: 818px;
    top: 90px;

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
#InputName{
    display: flex;
    flex-direction: row;
    align-items: center;
    padding: 10px 16px;

    width: 296px;
    height: 62px;
    left: 828px;
    top: 176px;

    background: #95C4D2;
    border: 1px solid #D4DFEF;
    box-sizing: border-box;
    border-radius: 10px;
}
#InputEmail{
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 0px;

    width: 296px;
    height: 62px;
    left: 828px;
    top: 264px;

    background: #95C4D2;
    border: 3px solid #95C4D2;
    box-sizing: border-box;
    border-radius: 10px;
}
#InputPassword{
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 0px;

    width: 296px;
    height: 62px;
    left: 828px;
    top: 352px;

    background: #95C4D2;
    border: 1px solid #95C4D2;
    box-sizing: border-box;
    border-radius: 10px;
}
#ConfirmPassword{
    display: flex;
    flex-direction: row;
    align-items: center;
    padding: 10px 16px;

    width: 296px;
    height: 62px;
    left: 824px;
    top: 356px;

    background: #95C4D2;
    border: 1px solid #D4DFEF;
    box-sizing: border-box;
    border-radius: 10px;
}
#btnCadastrar{
    
    flex-direction: row;
    align-items: center;
    padding: 8px 12px;
    text-align: center;
    width: 307px;
    height: 43px;
    left: 818px;
    top: 444px;

    /* Style */

    background: #037394;
    box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
    border-radius: 10px;
}


</style>
