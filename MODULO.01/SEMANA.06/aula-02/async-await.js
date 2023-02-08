// Função Assíncrona
async function soma(a, b) {
  return a + b;
}

soma(1, 2).then((resultado) => {
  console.log(resultado);
});

//Arrow Function Assíncrona
const subtracao = async (a, b) => {
  return a - b;
};

subtracao(3, 2).then((resultado) => {
  console.log(resultado);
});
// Esperar
const promise1 = new Promise((resolve, reject) => {
  setTimeout(() => resolve('promise1'), 600);
});

const buscarDados = async () => {
  const resultado = await promise1;
  console.log(resultado);
};
buscarDados();
