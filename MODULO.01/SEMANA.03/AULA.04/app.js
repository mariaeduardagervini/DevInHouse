console.log("Aula 04")

// EXEMPLO REST

//function somaTudo(a, b, c ...vetor) {
// const somaTudo = (a, b, c, vetor) => {    
//     console.log({ a, b, vetor }) 
//     let total = 0

//     for(let i = 0; i < vetor.length; i++){
//         total += vetor[i]
//     }

//     return total
// }
// qualquer coisa que eu passar pela const abaixo vai virar
// um elemeneto do meu vetor lá na função somaTudo
//const resultado = somaTudo (1, 2, 3, 4, 5, 6);
// console.log({ resultado })

// EXEMPLO SPREAD (PARÂMETROS) - espalha itens com parametros

const vetorA = [1, 2, 3, 4, 5, 6]

function multiplicaTudo(a, b, c, d, e) {
    console.log({ a, b, c, d, e })
}

// multiplicaTudo(55, ...vetor, 999)

// EXEMPLO SPREAD (ARRAY)
const vetorB = [11, 22, ...vetorA, 33]

//console.log(vetorB)

// EXEMPLO concatenação de arrays com SPREAD
const vetorC = [...vetorB, ...vetorA]
console.log(vetorC)

// EXEMPLO SPREAD (objeto)
// se eu quero ter como prioridade os itens do segundo objetivo- colocar spread na frente
// se for prioridade o primeiro objeto, colocar a spread ao final
const objA = { a: 1, b:2, c: 3 }

const objB = { a: 44, b: 55, c: 66, ...objA}

// console.log(objB)

// EXEMPLO destructuring (array)
const vetorD = ["Maria", 29, "informação", "extra"]

const [nome, idade, ...info] = vetorD

//console.log({ nome, idade, info})

// se os ... tiver no lado esquerdo é REST
// no lado direito é SPREAD

