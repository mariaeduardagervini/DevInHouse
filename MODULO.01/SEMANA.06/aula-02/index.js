const promise1 = new Promise((resolve, reject) => {
  setTimeout(() => resolve('promise1'), 1000);
});

const promise2 = new Promise((resolve, reject) => {
  setTimeout(() => resolve({ nome: 'promise2' }), 500);
});

const promise3 = new Promise((resolve, reject) => {
  setTimeout(() => resolve({ nome: 'promise3' }), 1500);
});

//Promise resolvido
// Promise.all([promise1, promise2])
//   .then((result) => {
//     console.log('Sucesso:', result);
//   })
//   .catch((err) => {
//     console.log('Erros:', err);
//   });

// //Promise rejeitada
// Promise.all([promise1, promise2, promise3])
//   .then((result) => {
//     console.log('Sucesso:', result);
//   })
//   .catch((err) => {
//     console.log('Erro:', err);
//   });

//Promise AllSettled
Promise.allSettled([promise1, promise2, promise3]).then((result) => {
  console.log(result[0].value);
});
