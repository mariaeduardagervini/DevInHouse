const num = document.getElementById('numero');
const botaoVerificar = document.getElementById('botao-verificar');

const enviarFormulario = (event) => {
  new Promise((resolve, reject) => {
    if (num.value % 2 === 0) {
      setTimeout(() => {
        resolve('É par!');
      }, 1000);
    } else {
      setTimeout(() => {
        reject('É ímpar!');
      }, 1000);
    }
  })
    .then((res) => {
      const span = document.createElement('p');
      span.innerText = res;
      document.body.appendChild(span);
    })
    .catch((res) => {
      const span = document.createElement('p');
      span.innerText = res;
      document.body.appendChild(span);
    })
    .finally(() => {
      const span = document.createElement('p');
      span.innerText = 'Finalizado!';
      document.body.appendChild(span);
    });
};

botaoVerificar.addEventListener('click', enviarFormulario);
