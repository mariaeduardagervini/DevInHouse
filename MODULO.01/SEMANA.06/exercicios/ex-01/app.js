const valor = document.getElementById('val');
const botaoEnviar = document.getElementById('botao-enviar');

function sleep(valor) {
  return new Promise((res, rej) => {
    setTimeout(() => res(valor), 3000);
  })
    .then((resultado) => {
      msg.innerHTML = `<p> Você digitou o número: ${resultado} </p>`;
    })
    .catch((err) => {
      console.log(err);
    });
}

botaoEnviar.addEventListener('click', () => {
  sleep(valor.value);
});
