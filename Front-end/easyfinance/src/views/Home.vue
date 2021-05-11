<template>
  <div class="container-lg">
    <div class="row">
      <div class="col-md-3 col-sm-12">
        <h3>Bem Vindo!</h3>
      </div>
    </div>
    <div class="row row-cols-4">
      <div class="col-md-3 col-sm-12" id="txtTexto">
        <h3 id="txt">ONDE ESTA O MEU DINHEIRO</h3>
      </div>
      <div class="col-md-3 col-sm-12" id="saldoAtual">
        <h3>
          Saldo atual: <b>{{ saldoAtual }}</b>
        </h3>
      </div>
      <div class="col-md-3 col-sm-12" id="receitas">
        <h3>
          Receitas: <b>{{ receitas }}</b>
        </h3>
      </div>
      <div class="col-md-3 col-sm-12" id="despesas">
        <h3>
          Despesas: <b>{{ despesas }}</b>
        </h3>
      </div>
    </div><br>
    <div class="row row-cols-2">
      <div class="col-md-6 col-sm-12" id="transacoes">
        <h1>Transações</h1>
        <button
          type="button"
          class="btn btn-primary"
          @click="_getTransacoesByUsuarioId(usuario.id)"
        >
          Atualizar
        </button>
        <ul>
          <li v-for="(item, index) in transacoes" :key="index">
            <b>ID:</b>{{ item.id }} | <b>Nome:</b> {{ item.nome }} |
            <b>Valor:</b> {{ item.valor }}
            <button
              type="button"
              class="btn btn-primary"
              @click="_ExcTransacao(item.id)"
            >
              excluir
            </button>
          </li>
        </ul>
      </div>

      <div class="col-md-6 col-sm-12" id="addTransacoes">
        <h1>Adicionar transação</h1>
        <button type="button" class="btn btn-primary" @click="_addTransacao()">
          Adicionar
        </button>
      </div>
    </div>
  </div>
</template>

<script>
import {
  getTransacoesByUsuarioId,
  addTransacao,
  excTransacao,
} from "@/services/transacaoService.js";

export default {
  name: "Home",
  methods: {
    _getTransacoesByUsuarioId(id) {
      var retorno = getTransacoesByUsuarioId(id);
      console.log(retorno);
      var saldoAtual = 0;
      var receitas = 0;
      var despesas = 0;
      retorno.forEach((item) => {
        saldoAtual = saldoAtual + item.valor;
        if (item.valor > 0) {
          receitas = receitas + item.valor;
        } else {
          despesas = despesas + item.valor;
        }
      });
      console.log(this.saldoAtual);
      this.saldoAtual = saldoAtual;
      this.receitas = receitas;
      this.despesas = despesas * -1;
      this.transacoes = retorno;
    },
    _addTransacao() {
      var transacao = {
        id: 4,
        nome: "Nova transacao",
        valor: -10,
        status: "Ativo",
        competencia: "2021-04",
        usuarioId: 1,
        usuario: null,
      };
      addTransacao(transacao);
      this._getTransacoesByUsuarioId(1);
    },
    _ExcTransacao(id) {
      excTransacao(id);
      this._getTransacoesByUsuarioId(1);
    },
  },
  data() {
    return {
      count: 4,
      usuario: {
        id: 1,
        nome: "Usuario Teste 1",
        login: "login1",
        senha: "1234",
        status: "Ativo",
      },
      transacoes: [],
      saldoAtual: 1,
      receitas: 2,
      despesas: 3,
    };
  },
};
</script>

<style scoped>
.container-lg{
  position: relative;
  width: 1181px;
  height: 592px;

  background: linear-gradient(180deg, #cecece 99.23%, #e8f2ff 100%);
  border-radius: 30px;
}

#transacoes {
  position: inherit;
  width: 538px;
  height: 414px;
  left: 37px;
  top: 145px;

  background: #ffffff;
  border-radius: 10px;
  margin-left: -2em;
  margin-right: 1em;
  
}

#addTransacoes {
  position: inherit;
  width: 538px;
  height: 414px;
  left: 612px;
  top: 145px;

  background: #ffffff;
  border-radius: 10px;
}

#txtTexto{
  position: absolute;
  width: 209px;
  height: 100px;
  left: 24px;
  top: 50px;

  background: #037394;
  border-radius: 30px 0px 0px 30px;
}
#txt{
  position: absolute;
  width: 105px;
  height: 76px;
  left: 95px;
  top: 12px;

  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 18px;
  line-height: 27px;
  display: flex;
  align-items: center;

  color: rgba(0, 0, 0, 0.73);
}

#saldoAtual{
  position: absolute;
  width: 260px;
  height: 100px;
  left: 233px;
  top: 50px;

  background: #FFFFFF;
}

#receitas{
 position: absolute;
  width: 260px;
  height: 100px;
  left: 491px;
  top: 50px;

  background: #FFFFFF;
}

#despesas{
  position:  flex;
  width: 260px;
  height: 100px;
  left: 746px;
  top: 9px;

  background: #FFFFFF;
  border-radius: 0px 30px 30px 0px;
}


</style>
