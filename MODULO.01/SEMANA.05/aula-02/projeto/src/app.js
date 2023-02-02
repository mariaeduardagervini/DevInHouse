const campoTitulo = document.getElementById('campo-titulo');
const botaoSalvar = document.getElementById('botao-salvar');
const listaItens = document.getElementById('lista-itens');
const formulario = document.getElementById('formulario');

let vetorItens = [
  {
    id: 0,
    label: 'item 0',
  },
  {
    id: 1,
    label: 'outro item',
  },
  {
    id: 2,
    label: 'e mais um',
  },
];

function apagaItemPorId(idParaApagar) {
  vetorItens = vetorItens.filter((item) => item.id !== idParaApagar);
  atualizaTela();
}

function criaElementoItem(item) {
  const { id, label } = item;
  const li = document.createElement('li');
  li.innerHTML = label;
  const botaoApagar = document.createElement('button');
  botaoApagar.innerHTML = 'x';
  botaoApagar.addEventListener('click', () => {
    apagaItemPorId(id);
  });
  li.appendChild(botaoApagar);
  return li;
}

function atualizaTela() {
  listaItens.innerHTML = '';

  vetorItens.forEach((item) => {
    const elemento = criaElementoItem(item);
    listaItens.appendChild(elemento);
  });
}

function adicionaItem() {
  const titulo = campoTitulo.value;
  if (titulo) {
    vetorItens.push({
      id: Date.now(),
      label: titulo,
    });
    // TODO: Implementar Classe Item
    // vetorItens.push(new Item(titulo));
    atualizaTela();
    campoTitulo.value = '';
  }
}

formulario.addEventListener('submit', (event) => {
  event.preventDefault();
  adicionaItem();
});

atualizaTela();
