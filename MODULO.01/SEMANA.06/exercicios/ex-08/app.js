const obterUsuarios = async (qtd = 4) => {
  const url = `https://randomuser.me/api/?results=${qtd}`;

  try {
    const response = await fetch(url);
    const data = await response.json();

    return data;
  } catch (error) {
    console.log(error);
  }
};

window.addEventListener('load', async () => {
  const data = await obterUsuarios(6);
  const lista = document.getElementById('lista');
  data.results.forEach((usuario) => {
    const item = document.createElement('div');
    item.classList = 'user';
    const nome = document.createElement('h3');
    const email = document.createElement('p');
    const endereco = document.createElement('p');
    const imagem = document.createElement('img');

    const { title, first, last } = usuario.name;
    const { street, city, state, country } = usuario.location;

    nome.innerText = `${title} ${first} ${last}`;
    email.innerText = `E-mail: ${usuario.email}`;
    endereco.innerText = `Endereço: ${street.name} ${street.number} ${city} ${state} ${country}`;
    imagem.src = usuario.picture.large;
    imagem.alt = 'Imagem do usuário';

    item.appendChild(nome);
    item.appendChild(email);
    item.appendChild(endereco);
    item.appendChild(imagem);

    lista.appendChild(item);
  });
});
