console.log('Aula 04');

import Animal from './Animal.js';

class Mamifero extends Animal {
  constructor() {
    super();
  }
  //Sobrescrevendo o método herdado
  caminha() {
    console.log('Executou caminha mamífero');
  }

  corre() {
    this.caminha();
    super.caminha();
  }
}

const cachorro = new Mamifero();

cachorro.corre();
//cachorro.caminha();
//Acessando método estático herdado
//Mamifero.caminha();
