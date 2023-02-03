import Funcionario from './Funcionario.js';

const maria = new Funcionario('042.256.130-46', 'Maria da Silva', 1000);

console.log(maria.salario);
maria.promover(50);
console.log(maria.salario);
