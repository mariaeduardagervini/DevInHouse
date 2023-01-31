console.log('AULA 01');

// const paragrafo = document.getElementById('mensagem');
// const btnAperta = document.getElementById('aperta');

// const vetor = [2, 3, 4, 6, 7];

// if (Array.isArray(vetor)) {
//   paragrafo.innerText = 'É vetor!';
// } else {
//   paragrafo.innerHTML = 'Não é vetor!';
// }

// vetor.forEach((n) => console.log(n));

// console.log(vetor.filter((n) => n % 2 === 0));

// function apertou() {
//   console.log('Apertou o botão!');
// }

// function apertouDenovo() {
//   console.log('Apertou o botão denovo!');
// }

// btnAperta.addEventListener('click', apertou);
// btnAperta.addEventListener('click', apertouDenovo);

// EXEMPLOS CLASSES

const vetor = new Array();
const vetorB = new Array();
vetor.push(3);
console.log(vetor);

// CRIANDO UMA CLASSE
// # antes do parâmetro para ser exclusivo dentro da classe. Deve ser declarado abaixo de class
class Retangulo {
  constructor(base, altura) {
    this.base = base;
    this.altura = altura;

    //console.log('Executou o constructor');
  }
  calculaArea() {
    const area = this.base * this.altura;
    console.log(area);
  }
}
const r1 = new Retangulo(4, 6);
const r2 = new Retangulo(5, 3);

console.log(r1);
console.log(r2);

r1.calculaArea();
r2.calculaArea();

class Pessoa {
  constructor(nome, rg, endereco) {
    this.nome = nome;
    this.rg = rg;
    this.endereco = endereco;
  }
}

class Endereco {
  constructor(logradouro, numero) {
    this.logradouro = logradouro;
    this.numero = numero;
  }
}
const endrA = new Endereco('Rua Xis', '455');
const romeu = new Pessoa('Romeu', '025465485', new Endereco('Rua Xis', '455'));

console.log(`${romeu.nome} mora em ${romeu.endereco.logradouro}`);
