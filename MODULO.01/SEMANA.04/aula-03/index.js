const botao = document.createElement('button');
botao.innerHTML = 'Botão 2';
botao.onclick;
//Adicionando o elemento criado no DOM
document.body.appendChild(botao);

//Função para simular a busca de um CEP
const buscaCep = (event) => {
  alert(`CEP: ${event.target.value} Rua teste n 18`);
};

// Input para eventp de onblur
const inputCep = document.createElement('input');
inputCep.onblur = (event) => buscaCep(event.target.value);
inputCep.placeholder = 'Digite o CEP';
document.body.appendChild(inputCep);

//Evento de teclado
const inputKey = document.createElement('input');
inputKey.onkeyup = (evento) => {
  console.log(evento);
};
document.body.appendChild(inputKey);

//Evento de formulário
const cadastros = [];
const formCadastro = document.getElementById('cadastro');
formCadastro.onsubmit = (event) => {
  event.preventDefault();

  //document.getElementById ('nome')
  //Obtem os valores digitados nos inputs
  const nome = event.target.nome.value;
  const idade = event.target.idade.value;

  //Cria um list item para adicionar na lista
  const item = document.createElement('li');
  item.classList.add('listItem');
  //item.classList.remove('listItem')
  item.innerHTML = `${nome} - ${idade}`;

  item.onclick = function () {
    if (this.classList.contains('listItem')) {
      this.classList.remove('lisItem');
    } else {
      this.classList.add('listItem');
    }
  };
  //Adicionar o list item criando na lista no DOM
  const lista = document.getElementById('lista');
  lista.appendChild(item);

  console.log(nome, idade);
};
//Criar um h1 na tela
const criaH1 = () => {
  const h1 = document.createElement('h1');
  h1.innerHTML = 'Texto teste';
  document.body.appendChild(h1);
};

//Adicionar event listener
const buttonAddListener = document.createElement('button');
buttonAddListener.innerHTML = 'Add Listener';
buttonAddListener.addEventListener('click', criaH1);
buttonAddListener.body.appendChild(buttonAddListener);

//Remover event listener
const buttonRemoveListener = document.createElement('button');
buttonRemoveListener.innerHTML = 'Remove Listener';
buttonRemoveListener.addEventListener('click', () => {
  buttonAddListener.removeEventListener('click', criaH1);
});
buttonRemoveListener.body.appendChild(buttonRemoveListener);
