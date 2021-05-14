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
        <h3 id="txtSaldoAtual">
          Saldo atual
          <label id="saldo"
            >R$<b>{{ saldoAtual }}</b></label
          >
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
    </div>
    <br />
    <div class="row row-cols-2">
      <div class="col-md-6 col-sm-12" id="transacoes">
        <h1 id="txtTransacoes">Transações</h1>
        <ul>
          <li
            v-for="(item, index) in transacoes"
            :key="index"
            id="listaTransacoes"
          >
            {{ item.nome }} | <b>R$ </b> {{ item.valor }}
            <button
              type="button"
              class="btn btn-primary"
              @click="_ExcTransacao(item.id)"
            >
              X
            </button>
          </li>
          <button
            type="button"
            class="btn btn-primary"
            @click="_getTransacoesByUsuarioId(usuario.id)"
          >
            Atualizar
          </button>
        </ul>
      </div>
      
      <div class="col-md-6 col-sm-12" id="addTransacoes">
        <h1 id="txtAddTransacao">Adicionar transação</h1>
        <div>
          <b-form @submit="onSubmit" @reset="onReset" v-if="show">
            <b-form-group
              class="text-justify"
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

            <b-form-group
              id="input-group-2"
              label="Valor"
              label-for="input-2"
              class="text-justify"
            >
              <b-form-input
                id="input-2"
                v-model="form.value"
                placeholder="Valor da Transação"
                required
              ></b-form-input>
            </b-form-group>

            <b-form-group
              id="input-group-2"
              label="Data"
              label-for="input-2"
              class="text-justify"
            >
              <b-form-input
                id="input-2"
                v-model="form.date"
                placeholder="Data da Transação"
                required
              ></b-form-input>
            </b-form-group>
          </b-form>
        </div>

        <button
          id="btnAdicionar"
          type="button"
          class="btn btn-primary"
          @click="_addTransacao()"
        >
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
      saldoAtual: "",
      receitas: 2,
      despesas: 3,
    };
  },

  data2() {
    return {
      form: {
        email: "",
        name: "",
        food: null,
        checked: [],
      },
      foods: [
        { text: "Select One", value: null },
        "Carrots",
        "Beans",
        "Tomatoes",
        "Corn",
      ],
      show: true,
    };
  },
};
</script>

<style scoped>
.container-lg {
  position: relative;
  width: 1200px;
  height: 655px;

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
  margin: 0 0 auto;
  overflow-y: scroll;
}
#addTransacoes {
  position: inherit;
  width: 538px;
  height: 414px;
  left: 612px;
  top: 145px;
  margin: 0 0 auto;
  background: #ffffff;
  border-radius: 10px;
}
#txtAddTransacao {
  position: relative;
  width: 200px;
  height: 43px;
  left: 13px;
  top: 13px;

  background: #95c4d2;
  border-radius: 10px;
  text-align: center;
  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 18px;
  line-height: 40px;
  text-align: center;

  color: #000000;
}
#txtTexto {
  position: absolute;
  width: 209px;
  height: 100px;
  left: 24px;
  top: 50px;

  background: #037394;
  border-radius: 30px 0px 0px 30px;
}
#txt {
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
#txtTransacoes {
  position: relative;
  width: 200px;
  height: 43px;
  left: 24px;
  top: 14px;

  background: #95c4d2;
  border-radius: 10px;

  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 18px;
  line-height: 40px;
  /* identical to box height */

  text-align: center;
  color: #000000;
}
#saldoAtual {
  position: absolute;
  width: 260px;
  height: 100px;
  left: 233px;
  top: 50px;

  background: #ffffff;
}
#receitas {
  position: absolute;
  width: 260px;
  height: 100px;
  left: 491px;
  top: 50px;

  background: #ffffff;
}
#despesas {
  position: flex;
  width: 260px;
  height: 100px;
  left: 746px;
  top: 9px;

  background: #ffffff;
  border-radius: 0px 30px 30px 0px;
}
#listaTransacoes {
  position: relative;
  width: 496px;
  height: 46px;
  left: 26px;
  top: 80px;

  background: #e1e1e1;
  border-radius: 10px;
}
#btnAdicionar {
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 8px 12px;

  position: relative;
  width: 318px;
  height: 43px;
  left: 220px;
  top: 312px;

  /* Style */

  background: #037394;
  box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
  border-radius: 10px;
}
#txtSaldoAtual {
  position: absolute;
  width: 140px;
  height: 20px;
  left: 12px;
  top: 8px;

  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 20px;
  line-height: 30px;
  display: flex;
  align-items: center;
  text-transform: capitalize;

  color: #037394;

  border: 1px solid #037394;
}
#saldo {
  position: absolute;
  width: 140px;
  height: 20px;
  left: 12px;
  top: 40px;

  font-family: Poppins;
  font-style: normal;
  font-weight: 500;
  font-size: 25px;
  line-height: 37px;
  display: flex;
  align-items: center;

  color: #037394;
}
</style>
