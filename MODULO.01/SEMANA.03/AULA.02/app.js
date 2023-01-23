// Exemplo inserção e remoçao ao final do array
// const vetorExemplo = [];

// vetorExemplo.push(1);
// vetorExemplo.push('a');
// vetorExemplo.push('ultimo');

// const ultimo = vetorExemplo.pop();

// console.log(vetorExemplo, ultimo);

// class Pessoa {
//     nome
//     idade
//     #cpf
//     constructor(nome, idade, cpf) {
//         this.nome = nome;
//         this.idade = idade;
//         this.#cpf = cpf;
//     }
// }

// const p = new Pessoa('Maria', 29, '12345678900');

// console.log(p.nome);

// FUNÇÕES

// Exemplo com matemática
// f(x, y) = x**2 + y
// f(2,3) = 2**2 + 3

function f(x,y) {
    return x**2 + y
}

function funcaoExemplo(x,y) {
    // Exemplo de verificação de parâmetros
    if (typeof x !== 'number' || typeof y !== 'number') {
    }
        const resultado = x**2 + y;
    return resultado;
}

const resultadoA = funcaoExemplo(2,3);
const resultadoB = funcaoExemplo(5, 8);

console.log(resultadoA);
console.log(resultadoB);

// Função sem parãmetros nem retorno
/* 
function dahOi() {
    //....
    console.log('Oi!);
}
dahOi();
dahOi();
*/
// Exemplo com parâmetros e string
function olaNome (nome, idade) {
    console.log(`Olá, ${nome} ! Você tem ${idade} anos`);
}

olaNome('Batata', 29);

// Executa e depois some da memória - função anõnima
(function() {
    console.log("Sou uma função anônima!");
})();

// ARROW FUNCTION

// Arrow Function completa
const vArrowCompleta = (n) => {
    console.log(`Arrow completa ${n} !`);
}

// Caso apenas um parâmetro podemo omitir os parentesis
const vArrowSemParentesis = n => {
    console.log(`Arrow sem parentesis ${n} !`);
}

// Caso apenas uma expressão no corpo podemos omitir inclusive
// as chaves do bloco de função
const vArrowSemChaves = n => 
    console.log(`Arrow sem chaves ${n} !`);

// COMPARANDO FUNÇÕES
// Função Comum
function fComum(x) {
    return x * 10000;
}
// Arrow Function completa
const fArrowCompleta = (x) => {
    return x * 10000;
}
// Arrow Function sem parentesis
const fArrowSemParentesis = x => {
    return x * 10000;
}
// Arrow Function sem chaves
const fArrowSemChaves = x => x * 10000;

console.log(fComum(3));
console.log(fArrowCompleta(6));
console.log(fArrowSemParentesis(2));
console.log(fArrowSemChaves(7));

//Momento de criação - This em Arrow Function
//Momento de execução - This em Function completa

// Exemplo de diferenças de contexto this
const objeto = {
    nome: "Teste",
    nomeDaFuncao: function () {
          // este this é o objeto 
        console.log(this);
        console.log(window === this);
    },
    nomeDaArrow: () => {
        // este this é o contexto global window
        console.log(this);
        console.log(window === this);
    }
};

objeto.nomeDaFuncao();
objeto.nomeDaArrow();


const vetorB = ['A', 'B', 'C'];


console.log(vetorB);

for (let i = 0; i < vetorB.length; i++){
    console.log(`i: ${i} v: ${vetorB[i]}`);
}
// Exemplo de função comum como parâmetro
vetorB.forEach(function (valor, indice, vetor) {
    console.log(`i: ${indice} v: ${valor}`, vetor);
});

// Exemplo de Arrow Function como parâmetro
//Caso eu tenha um parâmetro só, posso omitir os parentesis e chaves
vetorB.forEach(valor => console.log(`v: ${valor}`));

function calculaPontoA (x, y, z) {
    const v = [x * 2, y * 2, z * 2]
    return v;
}
console.log(calculaPontoA(1,2,3));

const calculaPontoB = (x, y, z) => [x * 2, y * 2, z * 2];
console.log(calculaPontoB(1,2,3));