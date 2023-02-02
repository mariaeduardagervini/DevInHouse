export class Animal {
  nome;
  idade;
  som;
  constructor(nome, idade, som) {
    this.nome = nome;
    this.idade = idade;
    this.som = som;
  }
}

export class Cachorro extends Animal {
  constructor(nome, idade, som) {
    super(nome, idade, 'latido');
  }
}
export class Gato extends Animal {
  constructor(nome, idade, som) {
    super(nome, idade, 'miado');
  }
}
