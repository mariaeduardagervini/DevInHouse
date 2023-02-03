import CalculadoraDeArea from './CalculadoraDeArea.js';

const quadA = new CalculadoraDeArea('quadrado', 6, 6);
const areaQA = quadA.calcular();
console.log(areaQA);

const triangB = new CalculadoraDeArea('triangulo', 8, 7);
const areaTB = triangB.calcular();
console.log(areaTB);
