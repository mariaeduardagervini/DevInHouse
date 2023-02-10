// Código Sincrono

function f1() {
  console.log('Função 1');
}

function f2() {
  console.log('Função 2');
}

f1();
console.log('Teste');
f2();

console.log('---------------');
//Codigo Assincrono
function f3() {
  console.log('Função 3');
}

function f4() {
  console.log('Função 4');
}
//em milesegundos (1)
setTimeout(() => f3(), 1000);
f4();
console.log('Fim async');

//EXEMPLO

function digaOlaPara(nome) {
  console.log(`Olá ${nome}`);
}

digaOlaPara('Maria');
setTimeout(digaOlaPara, 0, 'Ana');
digaOlaPara('Pedro');
setTimeout(digaOlaPara, 1, 'João');

//SetInterval
const repetir = setInterval(() => console.log('Olá'), 1000);

setTimeout(() => clearInterval(repetir), 7000);

// PROMISE

const minhaPromise = new Promise((resolve, reject) => {
  console.log('Promise');
  setTimeout(() => {
    resolve({ id: 1, nome: 'Maria' });
  }, 3000);
}).then((resultado) => {
  console.log(resultado);
});

// Promise rejeitada
new Promise((resolve, reject) => {
  setTimeout(() => reject('Erro'), 4000);
})
  .then((resultado) => {
    console.log(resultado);
  })
  .catch((err) => {
    console.log(err);
  });

// Tratar erro no .then
new Promise((resolve, reject) => {
  setTimeout(() => reject('Erro'), 4000);
}).then(
  (res) => {
    console.log('Sucesso', res);
  },
  (err) => {
    console.log('Erro', err);
  }
);

new Promise((res, rej) => {
  const num = Math.random();
  console.log(num);
  if (num > 0.5) {
    setTimeout(() => res('Sucesso'), 3000);
  } else {
    setTimeout(() => rej('Erro!'), 3000);
  }
})
  .then((resultado) => {
    console.log('.then', resultado);
  })
  .catch((reject) => {
    console.log('.catch', reject);
  });
