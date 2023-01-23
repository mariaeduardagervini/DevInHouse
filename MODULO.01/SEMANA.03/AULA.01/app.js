//const titulo = document.getElementById('titulo');
//console.log('Olá DEV!', titulo);
//0 é falso e 1 é verdadeiro (equivalente)
//string vazia = falso string com elemento é verdade

//Exemplo de Ternário

//const ehVerdade = true;

//if (ehVerdade) {
    //console.log('VERDADEIRO!');
//}else {
    //console.log('FALSO!');
//}

//ehVerdade ? console.log('VERDADEIRO') : console.log('FALSO');
/*EXEMPLO SWITCH
switch (numero) {
    case 0:
        console.log("ZERO");
        break;
    case 1:
        console.log("UM");
        break;
    case 2:
        console.log("DOIS");
        break;
    default:
        console.log("OUTRO")
}
*/
/*
const numA = 0;
const numB = numA || "AAAAAA";
const numC = numA ?? "AAAAAA"; //operador de coalescência nula 

console.log(numB,numC)
*/
//ARRAYS (vetores)

//Criando array vazio
const vetorA = [];

// Verificando se uma variável é array
const ehArray = Array.isArray(vetorA);
//console.log(ehArray);

//É possivel inicializar com valores pré definidos
const vetorB = [2, 4, "asd", null, NaN];

// É possivel acrescentar valores após definição
vetorB.push(234);
vetorB.push("CCCCCCCCC");

//substituindo um valor
vetorB[1] = 4444;

// Acessando um item
console.log(vetorB[2]);

//Acessando item fora do array
console.log(vetorB[111]);

//Como saber o tamanho do array
console.log(vetorB.length);

// Acessando o último item do array
console.log(vetorB[vetorB.length-1]);

// com número negativo começa de trás para frente.
console.log(vetorB.at(-1))

// OBJECTS

// Criando um objeto vazio
const objetoA = { };

// Criando objeto com chaves/valores predefinidos
const objetoB = { nome: "Maria", idade: 29};

// Acrescentando chave/valor após definição
objetoB.ocupacao = 'Programador';

// Alterando o valor de uma chave já existente
objetoB.nome = 'Isaac'

// "Congelando" um objeto
Object.freeze(objetoB);
objetoB.nome = 'BBBBBBBB'

// Criando um objeto já "congelado
const objetoC = Object.freeze({ nome: "Teste" });

console.log(objetoA.nome)
// se criar um nome de variável que não siga os critérios de nomes, ela deve ficar entre ' ' e para acessá-la no console em vez de .nome colocar []e ela dentro em ' ' 

// Exemplos de Arrays e objetos misturados

let numero = [6];

const obj = { n: numero }

numero[0] = 8;

console.log({ obj, numero });