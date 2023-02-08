const buscarValorAprovado = async () => {
  return await new Promise((res) => setTimeout(() => res(Math.floor(Math.random() * 9000) + 10000), 2000));
};

const valor = document.getElementById('numero');
const botao = document.getElementById('botao');
const resultado = document.getElementById('resultado');

const verificaValor = async (valorSolicitado) => {
  resultado.innerText = 'Processando...';
  const valorAprovado = await buscarValorAprovado();
  resultado.innerText = valorAprovado >= valorSolicitado ? 'Valor Aprovado' : 'Valor Reprovado';
};

botao.addEventListener('click', () => {
  verificaValor(parseFloat(valor.value));
});
