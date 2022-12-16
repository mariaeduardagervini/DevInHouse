const entradaNome = document.getElementById('nome');
const botaoAcao = document.getElementById('acao');
const pMensagem = document.getElementById('msg');

console.log(entradaNome, botaoAcao, pMensagem);

const mensagemOla = (nome) => `Olá, ${nome}`;
const resultado = mensagemOla('Maria Eduarda');
console.log(resultado);

botaoAcao.addEventListener('click', () => {
  const nome = entradaNome.value;
  const msg = mensagemOla(nome);
  pMensagem.innerHTML = msg;
});
