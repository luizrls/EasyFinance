import api from "./api.js";

const usuarioAPI = {
  logar: async (login, senha) =>
    await api
      .post("/Usuarios/Logar", {
        id: 0,
        nome: "string",
        login: login,
        senha: senha,
        status: "string",
        transacoes: [],
      })
      .then((obj) => obj.data)
      .catch((err) => console.error(err)),
  addUsuario: (usuario) => api.post("/Usuarios", usuario),
};

export default usuarioAPI;

/* const lista = [
  {
    id: 1,
    nome: "Usuario Teste 1",
    login: "login1",
    senha: "1234",
    status: "Ativo",
  },
  {
    id: 2,
    nome: "Usuario Teste 2",
    login: "login2",
    senha: "1234",
    status: "Ativo",
  },
  {
    id: 3,
    nome: "Usuario Teste 3",
    login: "login3",
    senha: "1234",
    status: "Inativo",
  },
];

export const logar = (login, senha) => {
  return lista.filter(
    (x) => x.login == login && x.login == senha && x.status == "Ativo"
  );
};

export const addUsuario = (usuario) => {
  lista.push(usuario);
  return usuario;
}; */
