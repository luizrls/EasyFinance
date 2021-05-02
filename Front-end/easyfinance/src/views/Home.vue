<template>
<div class='Home'>
    <div class="container">
        <h3>Saldo atual: <b>{{saldoAtual}}</b></h3>
        <h3>Receitas: <b>{{receitas}}</b></h3>
        <h3>Despesas: <b>{{despesas}}</b></h3>
        <br>
        <ul>
            <li v-for="(item, index) in transacoes" :key="index">
                <b>ID:</b>{{item.id}} | <b>Nome:</b> {{item.nome}} | <b>Valor:</b> {{item.valor}} 
                <button type="button" class="btn btn-primary" @click="_ExcTransacao(item.id)">excuir</button>
            </li>
        </ul>
        <button type="button" class="btn btn-primary" @click="_addTransacao()">Adicionar</button>
        <button type="button" class="btn btn-primary" @click="_getTransacoesByUsuarioId(usuario.id)">Atualizar</button>
    </div>
  <slot />
</div>
</template>

<script>
import {getTransacoesByUsuarioId, addTransacao, excTransacao} from '@/services/transacaoService.js'

export default {
name: 'Home',
methods: {
  _getTransacoesByUsuarioId(id){
    var retorno = getTransacoesByUsuarioId(id);
    console.log(retorno);
    var saldoAtual = 0;
    var receitas = 0;
    var despesas = 0;
    retorno.forEach(item => {
        saldoAtual = saldoAtual + item.valor;
        if(item.valor > 0){
            receitas = receitas + item.valor;
        }else{
            despesas = despesas + item.valor;
        }
    });
    console.log(this.saldoAtual);
    this.saldoAtual = saldoAtual;
    this.receitas = receitas;
    this.despesas = (despesas * -1);
    this.transacoes = retorno;
  },
  _addTransacao(){
      var transacao = {
        id: 4,
        nome: "Nova transacao",
        valor: -10,
        status: "Ativo",
        competencia: "2021-04",
        usuarioId: 1,
        usuario: null,
    }
    addTransacao(transacao);
    this._getTransacoesByUsuarioId(1);

  },
  _ExcTransacao(id){
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
        despesas: 3
        }
  },
}
</script>

<style scoped>

</style>