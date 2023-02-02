// Se a quantidade não for positiva, ela deve ser indicada como 0 (zero).
// Se o preço por item não for positivo ele deve ser indicado como 0.

import Fatura from './Fatura.js';

const arroz = new Fatura(2, 'arroz', 5, 1.5);

const valor = arroz.obterValorTotal();

console.log(valor);
console.log(arroz.obterValorTotal);
