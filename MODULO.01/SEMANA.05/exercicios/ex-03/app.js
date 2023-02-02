import Personagem from './Personagem.js';

const harry = new Personagem('Harry');

console.log(harry.percentualVida);

harry.sofreuDano(50);

console.log(harry.percentualVida);

harry.usouKitMedico();

console.log(harry.percentualVida);
