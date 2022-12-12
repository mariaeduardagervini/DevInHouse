// Caro Fulano(a)!

// Você está convidado(a) para o casamento de Beltrano(a) e Ciclano(a), a ser realizado no dia 05/12/2022, às 16 horas.

// Contamos com a sua presença!

//Atenciosamente,
//os noivo(a)s

var convidado = 'Thais';
var noivos = 'João e Maria';
var dataFormatada = '05/12/2022, às 16 horas';

var texto =
  'Caro(a) ' +
  convidado +
  ' ! \n Você está convidado(a) para o casamento de ' +
  noivos +
  ', a ser realizado no dia ' +
  dataFormatada +
  ' \n \n Contamos com a sua presença! \n \n Atenciosamente, \n os noivo(a)s';
console.log(texto);

//------------------------------------------------------------------------------------

//String
var nome = 'teste';

//Number
var idade = 28;
var decimal = 12.6;
var negativo = -3;

//Boolean
var verdadeiro = true;
var falso = false;

//Null
var nulo = null;
console.log(nulo);

//Undefined
var indefinido;
console.log(indefinido);

//Object
var pessoa = {
  nome: 'Maria',
  idade: 29,
  ativo: true,
  endereco: {
    rua: 'Avenida bbb',
    numero: 123,
    bairro: 'Centro',
  },
};
console.log(pessoa.nome);
console.log(pessoa['idade']); //se usa mais . do que []
console.log(pessoa.endereco.rua);

//Array
//0,1,2,3,4 (posições)
var lista = [1, 2, 3, 4, 5];
console.log(lista);
console.log(lista[0]);

var texto = 'aaaaa';
var numero = 123;
var boleano = false;
var objeto = { nome: 'teste' };
var lista = [{ nome: 'teste' }];

console.log(typeof texto);
console.log(typeof numero);
console.log(typeof boleano);
console.log(typeof objeto);
console.log(typeof lista);

//Operadores matemáticos - Number
console.log(1 + 1); //2
console.log(1 + '1'); //11 (concatenação)

console.log(1 - 1); //0
console.log(1 - '1'); //0

console.log(19 % 2);

//Operadores de atribuição
var soma = 1; //atribuição simples
console.log(soma);
soma += 20; //atribuição de soma
//soma = soma + 20
console.log(soma);

//Comparação
console.log(1 == 1); //igualdade simples
console.log(1 === 1); //igualdade estrita
console.log('1' == 1); //igualdade simples
console.log('1' === 1); //igualdade estrita

console.log('1' != 1); // diferença simples
console.log('1' !== 1); //diferença estrita

console.log(3 <= 3); //maior ou igual que

//Lógicos
var condicao1 = true;
var condicao2 = 1 == 2;
console.log(condicao1, condicao2);
console.log(condicao1 && condicao2); // e (os dois precisam ser verdadeiro para retornar verdadeiro)
console.log(condicao1 || condicao2); //ou (se uma for verdadeira retorna verdadeira)
console.log(!condicao1); //negação-inverte o valor
console.log(!condicao2); //negação-inverte o valor

var teste = '';

console.log(Boolean(teste));

//unario
var contador = 2;
console.log(contador);

//contador++ //contador = contador + 1
//contador-- //contador = contador - 1
