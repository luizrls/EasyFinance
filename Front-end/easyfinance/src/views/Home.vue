<template>
  <b-container fuid="md">
    <b-row >
      <h3 id="T1">Bem Vindo!</h3>
    </b-row><br>
    <b-row fuid="md">
      <b-col cols="3" class="col-md-3" fluid="md" id="col1">
        <h3 id="txt-col1" fuid="md">ONDE ESTA O MEU DINHEIRO</h3>
      </b-col>
      <b-col cols="3" class="col-md-3" fluid="md" id="col2">
        <h3 id="txt-col2" fuid="md">Saldo atual</h3>
        <label id="saldo"
            >R$<b>{{ saldoAtual }}</b>
        </label>
      </b-col>
      <b-col cols="3" class="col-md-3" fluid="md" id="col3">
        <h3 id="txt-col3" fuid="md">Receitas</h3>
        <label id="receita"
            >R$<b>{{ receitas }}</b>
            </label>
      </b-col>
      <b-col cols="3" class="col-md-3" fluid="md" id="col4">
        <h3 id="txt-col4" fuid="md">Despesas</h3>
        <label id="despesa"
            >R$<b>{{ despesas }}</b></label
          >
      </b-col>
    </b-row>
    <br />

    <b-row fluid="md" align-h="around" class="row row-cols-2">

      <b-col cols="6" cols-md="12" fluid="md"  id="transacoes" >
        <h1 id="txtTransacoes">Transações</h1>
        <button
            id="atualizar"
            type="button"
            class="btn btn-primary"
            @click="_getTransacoesByUsuarioId(usuario.id)"
          >
            Atualizar
          </button>
        <div >
        <ul id="listaTransacoes">
         <li class="list-group-item d-flex justify-content-between align-items-center"
            v-for="(item, index) in transacoes"
            :key="index"
            
          >
           {{ item.nome }}
            <span class="badge badge-primary badge-pill" data-spy="scroll"><b>R$ </b> {{ item.valor }}</span>
            <button aria-label="Close"
              type="button"
              class="btn btn-primary"
              @click="_ExcTransacao(item.id)"
            >
              x
            </button>
          </li>    
        </ul>
        </div>
      </b-col>

      <b-col cols="6" cols-md="12" fluid="md" id="addTransacoes">
        <h1 id="txtAddTransacao">Adicionar transação</h1>
        <b-form>
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
            id="input-group-3"
            label="Data"
            label-for="input-2"
            class="text-justify"
          >
            <b-form-input
              id="input-3"
              v-model="form.date"
              placeholder="Data da Transação"
              required
            ></b-form-input>
          </b-form-group>
        </b-form>
        <button
          id="btnAdicionar"
          type="button"
          class="btn btn-primary"
        >
         <label for="txtAdicionar"><a @click="_addTransacao()">Adicionar</a></label>
        </button>
      </b-col>
    </b-row>
  </b-container>
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
     onSubmit(event) {
        event.preventDefault()
        alert(JSON.stringify(this.form))
      },
      onReset(event) {
        event.preventDefault()
        // Reset our form values
        this.form.email = ''
        this.form.name = ''
        this.form.food = null
        this.form.checked = []
        // Trick to reset/clear native browser form validation state
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
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
      
      form: {
        email: "",
        nome: "",
        data: "",
      },
    };
  },
};
</script>

<style>
.container{
    position: relative;
    width: 1181px;
    height: 592px;
  
    background: linear-gradient(180deg, rgba(172, 172, 172, 0.4) 99.45%, #E8F2FF 100%);
    border-radius: 30px;
    box-sizing: content-box;
  }
  #T1{
    position: absolute;
    width: 170px;
    height: 42px;
    left: 37px;
    top: -1px;

    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 28px;
    line-height: 42px;
    /* identical to box height */

    display: flex;
    align-items: center;
  }
  #col1{
    position: absolute;
    width: 209px;
    height: 100px;
    left: 25px;
    top: 37px;
  
    background: #037394;
    border-radius: 30px 0px 0px 30px;
  }
  #txt-col1{
    position: absolute;
    width: 105px;
    height: 76px;
    left: 95px;
    top: 12px;
    
    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 18px;
    line-height: 27px;
    display: flex;
    align-items: center;
    
    color: rgba(0, 0, 0, 0.73);
  }
  #col2{
    position: absolute;
    width: 260px;
    height: 100px;
    left: 234px;
    top: 37px;

    background: #FFFFFF;
  }
  #txt-col2{
    position: absolute;
    width: 140px;
    height: 20px;
    left: 12px;
    top: 8px;

    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 20px;
    line-height: 30px;
    display: flex;
    align-items: center;
    text-transform: capitalize;

    color: #037394;
  }
  #saldo{
    position: absolute;
    width: 140px;
    height: 20px;
    left: 12px;
    top: 40px;
    
    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 25px;
    line-height: 37px;
    display: flex;
    align-items: center;
    
    color: #037394;
  }
  #col3{
    position: absolute;
    width: 260px;
    height: 100px;
    left: 492px;
    top: 37px;
    
    background: #FFFFFF;
  }
  #txt-col3{
    position: absolute;
    width: 101px;
    height: 20px;
    left: 12px;
    top: 8px;

    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 20px;
    line-height: 30px;
    display: flex;
    align-items: center;
    text-transform: capitalize;

    color: #1A5F31;
  }
  #receita{
    position: absolute;
    width: 140px;
    height: 20px;
    left: 12px;
    top: 40px;

    font-family: Poppins, sans-serif;
    font-style: normal;
    font-weight: 500;
    font-size: 25px;
    line-height: 37px;
    display: flex;
    align-items: center;

    color: #1A5F31;
  }
  #col4{
    position: absolute;
    width: 260px;
    height: 100px;
    left: 752px;
    top: 37px;
    
    background: #FFFFFF;
    border-radius: 0px 30px 30px 0px;
  }
  #txt-col4{
    position: absolute;
    width: 101px;
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

    color: #850D0D;

  }
  #despesa{
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

    color: #850D0D;
  }
  #transacoes{
    position: absolute;
    width: 538px;
    height: 414px;
    left: 15px;
    top: 145px;
    box-sizing: content-box;
    display: flex;
    background: #FFFFFF;
    border-radius: 10px;
  }
  #listaTransacoes{
    position: absolute;
    width: 496px;
    height: 46px;
    left: 20px;
    top: 80px;
    
    background: #E1E1E1;
    border-radius: 10px;
  }
  #addTransacoes{
    position: absolute;
    width: 538px;
    height: 414px;
    left: 590px;
    top: 145px;
    box-sizing: content-box;
    display: flex;
  
    background: #FFFFFF;
    border-radius: 10px;
  }
  #txtTransacoes{
    position: absolute;
    width: 172px;
    height: 43px;
    left: 24px;
    top: 14px;

    background: #95C4D2;
    border-radius: 10px;

    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 18px;
    line-height: 27px;
    /* identical to box height */

    display: flex;
    align-items: center;

    color: #000000;

  }
  #atualizar{
    flex-direction: row;
    align-items: center;
    padding: 8px 12px;
    
    position: absolute;
    width: 138px;
    height: 43px;
    left: 393px;
    top: 15px;
    
    /* Style */
    
    background: #037394;
    box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
    border-radius: 10px;
  }
  #txtAddTransacao{
    position: absolute;
    width: 251px;
    height: 43px;
    left: 13px;
    top: 13px;
    
    background: #95C4D2;
    border-radius: 10px;

    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 18px;
    line-height: 27px;
    display: flex;
    align-items: center;

    color: #000000;
  }
  #input-group-1{
    position: absolute;
    width: 514px;
    height: 62px;
    left: 13px;
    top: 86px;
    
    background: #E1E1E1;
    border-radius: 10px;
  }
  #input-1 .input-1{ 
    position: absolute;
    width: 268px;
    height: 62px;
    left: 27px;
    top: 87px;
    
    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 15px;
    line-height: 22px;
    display: flex;
    align-items: center;
    
    color: rgba(3, 3, 3, 0.46);
  }
  #input-group-2{
    position: absolute;
    width: 514px;
    height: 62px;
    left: 12px;
    top: 178px;
    
    background: #E1E1E1;
    border-radius: 10px;
  }
  #input-2 .input-2{
    position: absolute;
    width: 296px;
    height: 62px;
    left: 27px;
    top: 178px;
    
    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 13px;
    line-height: 19px;
    display: flex;
    align-items: center;
    
    color: #000000;
  }
  #input-group-3{
    position: absolute;
    width: 514px;
    height: 62px;
    left: 13px;
    top: 270px;
    
    background: #E1E1E1;
    border-radius: 10px;
  }
  #input-3 .input-3{
    position: absolute;
    width: 268px;
    height: 62px;
    left: 28px;
    top: 270px;
    
    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 15px;
    line-height: 22px;
    display: flex;
    align-items: center;
    
    color: rgba(3, 3, 3, 0.46);
  }
  #btnAdicionar{
    flex-direction: row;
    align-items: center;
    padding: 8px 12px;

    position: absolute;
    width: 117px;
    height: 43px;
    left: 209px;
    top: 361px;

    /* Style */

    background: #037394;
    box-shadow: 0px 10px 15px rgba(0, 0, 0, 0.06);
    border-radius: 10px;
  }
  #txtAdicionar{
    position: static;
    height: 27px;
    left: 10.26%;
    right: 10.26%;
    top: 8px;
    
    font-family: Poppins;
    font-style: normal;
    font-weight: 500;
    font-size: 18px;
    line-height: 27px;
    /* identical to box height */
    
    display: flex;
    align-items: flex-end;
    
    color: #FFFFFF;
    
    
    /* Inside Auto Layout */
    
    flex: none;
    order: 0;
    flex-grow: 0;
    margin: 0px 177px;
  }
</style>
