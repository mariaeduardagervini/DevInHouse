const obterPersonagens = async () => {
  const url = 'https://rickandmortyapi.com/api/character';

  try {
    const response = await fetch(url);
    const data = await response.json();

    return data;
  } catch (error) {
    console.log(error);
  }
};

window.addEventListener('load', async () => {
  const data = await obterPersonagens();

  const lista = document.getElementById('lista');

  if (data) {
    data.results.forEach((element) => {
      const item = document.createElement('li');
      const titulo = document.createElement('h3');
      const imagem = document.createElement('img');

      titulo.innerText = element.name;
      imagem.src = element.image;

      item.classList.add('itemLista');

      item.appendChild(imagem);
      item.appendChild(titulo);
      lista.appendChild(item);
    });
    return;
  }

  const item = document.createElement('li');
  item.innerText = 'Falha ao obter dados';
  lista.appendChild(item);
});
