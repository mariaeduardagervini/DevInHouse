// EXEMPLOS MÓDULOS

// alterar nome original
import { numero as outroNome } from './exemplo.js';
console.log(outroNome);

// para importar com um outro nome qualquer como abaixo, é preciso ter default no outro código
// import banana from "./exemplo.js"
// console.log(banana); //retorna o arquivo default do outro arq js

// o default fica fora das chaves {}
import Pessoa, { numero, texto } from './exemplo.js';

// Também é possível renomear os imports
// export default pode ser renomeado
import Ada from './exemplo.js';
// ‘Ada’ continúa sendo ‘Pessoa’
const al = new Ada('Lovelace');

// para renomear outros exports usamos ‘as’
import { numero as batata } from './exemplo.js';
// ‘batata’ continua sendo ‘numero’
console.log(batata); // 42
