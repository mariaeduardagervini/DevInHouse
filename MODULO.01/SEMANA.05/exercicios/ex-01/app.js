import Funcionario from './Funcionario.js';

const maria = new Funcionario('000.000.000-00', 'Maria da Silva', 1000);

console.log(maria.salario);
maria.promover(50);
console.log(maria.salario);
