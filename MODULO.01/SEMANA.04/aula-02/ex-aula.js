const lista = document.getElementById('lista');

const dados = [
  {
    nome: 'Maria Eduarda',
    imagem: 'https://cdn-icons-png.flaticon.com/512/2920/2920072.png',
    frase: 'Aula',
  },
  {
    nome: 'Mariah',
    imagem: 'https://cdn-icons-png.flaticon.com/512/2920/2920072.png',
    frase: 'DEV',
  },
];
dados.forEach((element) => {
  const item = document.createElement('li');
  const imagem = document.createElement('img');
  const span = document.createElement('p');
  const frase = document.createElement('p');

  imagem.src = 'https://cdn-icons-png.flaticon.com/512/2920/2920072.png';
  imagem.width = 50;
  span.innerHTML = element.nome;
  frase.innerHTML = element.frase;
  item.appendChild(imagem);
  item.appendChild(span);
  item.appendChild(frase);
  lista.appendChild(item);
});
