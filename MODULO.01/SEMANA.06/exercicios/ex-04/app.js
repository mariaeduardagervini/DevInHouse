const fakeTime = () => parseInt(Math.random() * 10000);
//Tranforma em número inteiro(intervalos aleatórios)

const retornoEmpresa1 = new Promise((resolve) => setTimeout(resolve, fakeTime(), 'Empresa 1'));

const retornoEmpresa2 = new Promise((resolve) => setTimeout(resolve, fakeTime(), 'Empresa 2'));

Promise.race([retornoEmpresa1, retornoEmpresa2])
  .then((res) => {
    console.log(res);
  })
  .catch((err) => {
    console.log(err);
  });
