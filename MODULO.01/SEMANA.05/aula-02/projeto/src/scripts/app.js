import Item from './Item.js';

const campoTitulo = document.getElementById('campo-titulo');
//const botaoSalvar = document.getElementById("botao-salvar");
const listaItens = document.getElementById('lista-itens');
const formulario = document.getElementById('formulario');

// TODO: Criar uma classe Tarefa extends Item
//       e sobrescreve criar elemento para acrescentar
//       um checkbox na criação do elemento

let vetorItens = [new Item('Item 0'), new Item('Outro item'), new Item('E mais um')];

function apagaItemPorId(idParaApagar) {
  console.log({ idParaApagar });
  vetorItens = vetorItens.filter((item) => item.id !== idParaApagar);
  atualizaTela();
}

function atualizaTela() {
  listaItens.innerHTML = '';

  vetorItens.forEach((item) => {
    const elemento = item.criaElemento(apagaItemPorId);
    listaItens.appendChild(elemento);
  });
}

function adicionaItem() {
  const titulo = campoTitulo.value;
  if (titulo) {
    const novoItem = new Item(titulo);
    console.log({ novoItem });
    vetorItens.push(novoItem);
    atualizaTela();
    campoTitulo.value = '';
  }
}

formulario.addEventListener('submit', (event) => {
  event.preventDefault();
  adicionaItem();
});

atualizaTela();
