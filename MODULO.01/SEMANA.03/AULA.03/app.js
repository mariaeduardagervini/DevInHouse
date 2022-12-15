// Impede o uso de variáveis que não existem
// "use strict"
// Automaticamente presente  em script module
// usar var joga no escopo global - 
var minhaVariavel = "ConteudoDaVariavel"

function funcaoExemplo () {
    // Escopo de Função
    var varEscopoFunc = "NoEscopoDaFuncao"
}

if (minhaVariavel) {
    // Escopo de Bloco
    var varEscopoBlock = "NoEscopoBloco"
}

//Exemplo de escopo de função
function definirLargura() {
    var largura = 100
    console.log(largura)
}

definirLargura ()

console.log(largura)

// Como pode confundir?
var idade = 31;

if (idade > 12) {
  var idadeEmAnosCaninos = idade * 7;
  console.log(`Você tem ${idadeEmAnosCaninos} anos em idade canina!`);
}

// Continua acessível fora do bloco onde foi criada!
console.log(idadeEmAnosCaninos);

// Exemplo LET escopo de bloco

let pontos = 50;
let venceu = false;

if (pontos > 40) {
  console.log('Passei pelo if!');
  let venceu = true;
  console.log('Venceu:', venceu);
}

console.log('Venceu:', venceu);
// Venceu: false

// EXEMPLO CONST

const pessoa = {
    nome: 'Vitória',
    idade: 31
  };
  
  // O que vai acontecer nas ocasiões abaixo?
  //pessoa = { nome: 'Chinforínfola'};
  
  pessoa.idade = 40;

  console.log(pessoa);
  
  // Como impedir que propriedades sejam alteradas?
  const vitoria = Object.freeze(pessoa);

  function pegarPrompt() {
    const digitado = prompt("Digite algo: ")
    console.log(digitado)
  }
 pegarPrompt()
 pegarPrompt() 
 pegarPrompt()

 for(let i = 0; i < 3; i++){
    const digitado = prompt("Digite algo: ")
    console.log(digitado)
 }

 // Exemplo HOISTING de FUNCTION
 dahOi()
 function dahOi() {
    console.log('Oi!')
 }

 // Crie uma função que receba como parâmetro um objeto contendo 2
 // atributos, texto e termo, como o exemplo  e teste se o conteúdo
 // de texto contém o conteúdo do termo

 function procuraTermo() {

 }

 const testeA = procuraTermo({
    texto: "O rato roeu a roupa do rei de Roma.",
    termo: "rato"
 }) // Deve retornar true
