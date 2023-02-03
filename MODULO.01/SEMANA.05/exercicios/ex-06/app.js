import Juros from './Juros.js';

const aplicacao1 = new Juros(10000, 0.07, 24);
const aplicacao2 = new Juros(10000, 0.15, 10);

console.log(aplicacao1.calcularJurosSimples());
console.log(aplicacao1.calcularJurosCompostos());

console.log(aplicacao2.calcularJurosSimples());
console.log(aplicacao2.calcularJurosCompostos());
