//TAG NAME- RETORNA UM ARRAY
const titulos = document.getElementsByTagName('h1');
titulos[0].style.color = 'blue'; //Muda cor
titulos[0].innerHTML = 'Texto alterado'; // Muda texto

//ID
const titulo1 = document.getElementById('titulo1');
titulo1.style.color = 'red';

// GetByName
const tituloName = document.getElementsByName('titulo2');
tituloName[0].style.color = 'blue';

//GetByClass
const titulosErros = document.getElementsByClassName('erro');
for (let index = 0; index < titulosErros.length; index++) {
  titulosErros[index].style.fontSize = '12px';
}

//QuerySelector
const tituloSelector = document.querySelector('h1#titulo1');
tituloSelector.style.fontSize = '24px';

//QuerySelectorAll
const titulosSelectorAll = document.querySelectorAll('.erro');
titulosSelectorAll.forEach((element) => {
  element.style.fontSize = '36px';
  element.innerHTML = `${element.innerHTML} + texto novo`;
});

//Create Elements
const paragrafo = document.createElement('p');
paragrafo.innerHTML = 'Meu primeiro paragrafo';
paragrafo.style.color = 'green';

const paragrafo2 = document.createElement('p');
paragrafo2.innerHTML = 'Meu primeiro paragrafo2';
paragrafo2.style.color = 'purple';

//Adicionar elemento criado no html
//document.body.appendChild(paragrafo)
const container = document.getElementById('conteudo');
container.appendChild(paragrafo);

document.body.insertBefore(paragrafo2, container);

//Remover elemento HTML
const elementoParaRemover = document.getElementById('titulo1');
elementoParaRemover.remove();

//Remover o filho de um elemento
container.removeChild(paragrafo);

//Adicionar elemento dentro de outro criando no JS

const teste = document.getElementById('teste');

const div2 = document.createElement('div');
const span = document.createElement('img');
span.src = 'https://cdn-icons-png.flaticon.com/512/2920/2920072.png';
span.setAttribute('width', 100);

div2.appendChild(span);
teste.appendChild(div2);
