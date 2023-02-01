console.log('Aula 03');
// GETTER - Criar um método (get) de um classe e tratá-lo como atributo
class Retangulo {
  base;
  #altura;

  constructor(b, a) {
    this.base = b;
    this.#altura = a;
  }

  calculaArea() {
    return this.base * this.altura;
  }

  get altura() {
    return this.#altura;
  }

  get alturaDobro() {
    return this.#altura * 2;
  }
  set definirAltura(novoValor) {
    this.#altura = novoValor;
  }
}

const quad = new Retangulo(4, 5);
quad.definirAltura = 2;
console.log(quad.altura);

console.log(quad.alturaDobro);

console.log(quad.calculaArea());

//EXEMPLO de Getter em objeto comum
const objetoComum = {
  valorInterno: 42,

  get valor() {
    return this.valorInterno;
  },
};

console.log(objetoComum.valorInterno);
console.log(objetoComum.valor);
//Ex 02
import Fatura from './Fatura.js';

const melao = new Fatura(123, 'Melão', 2, 3);

const valor = melao.obterValorTotal();

console.log(valor);
console.log(melao.valorTotal);
