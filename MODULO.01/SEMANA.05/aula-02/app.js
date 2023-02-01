console.log('Aula 02');

class Animal {
  som;
  nrPatas;
  constructor(som, nrPatas) {
    this.som = som;
    this.nrPatas = nrPatas;
  }

  falar() {
    console.log(this.som);
  }
}
// const animal0 = new Animal('Miau');
// const animal1 = new Animal('Auau');
// const animal2 = new Animal('Quaqua');

// console.log(animal0);
// console.log(animal1);
// console.log(animal2);

// animal0.falar();
// animal1.falar();
// animal2.falar();

class Mamifero extends Animal {
  constructor(som) {
    super(som, 4);
  }
  andar() {
    console.log('andou');
  }
}

class Gato extends Mamifero {
  constructor() {
    super('MIAU');
  }
}

const oliver = new Gato();

console.log(oliver);
oliver.falar();
oliver.andar();

// EXEMPLO SLIDE

class Retangulo {
  base;
  altura;

  constructor(b, a) {
    this.base = b;
    this.altura = a;
  }

  calculaArea() {
    return this.base * this.altura;
  }
}
class Quadrado extends Retangulo {
  constructor(a) {
    super(a, a); // base = altura
  }
}

const q = new Quadrado(4);

console.log(q.calculaArea());
// 16
