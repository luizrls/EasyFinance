var lista = [
  {
    id: 1,
    nome: "Conta de agua",
    valor: -10,
    status: "Ativo",
    competencia: "2021-04",
    usuarioId: 1,
    usuario: null,
  },
  {
    id: 2,
    nome: "Conta de luz",
    valor: -20,
    status: "Ativo",
    competencia: "2021-04",
    usuarioId: 1,
    usuario: null,
  },
  {
    id: 3,
    nome: "Pagamento mensal",
    valor: 30,
    status: "Ativo",
    competencia: "2021-04",
    usuarioId: 2,
    usuario: null,
  },
];

export const getTransacoesByUsuarioId = (id) => {
  return lista.filter((x) => x.usuarioId == id);
};

export const addTransacao = (transacao) => {
  lista.push(transacao);
  return true;
};

export const excTransacao = (id) => {
  console.log(id);
  lista = lista.filter((x) => x.id !== id);
  console.log(lista);
  return true;
};
