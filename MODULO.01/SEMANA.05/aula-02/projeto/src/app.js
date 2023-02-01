const campoTitulo = document.getElementById('campo-titulo');
const botaoSalvar = document.getElementById('botao-salvar');
const listaItens = document.getElementById('lista-itens');
const formulario = document.getElementById('formulario');

const vetorItens = ['Item 0', 'Item 1', 'Item 2'];
function atualizaTela() {
  listaItens.innerHTML = '';

  vetorItens.forEach((item) => {
    const li = document.createElement('li');
    li.innerHTML = item;
    listaItens.appendChild(li);
  });
}
function adicionaItem() {
  const titulo = campoTitulo.value;
  vetorItens.push(titulo);
  atualizaTela();
  campoTitulo.value = '';
}

formulario.addEventListener('submit', (event) => {
  event.preventDefault();
  adicionaItem();
});
atualizaTela();
