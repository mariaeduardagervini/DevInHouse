var numero = parseInt(prompt('Informe um número: '));
var raiz = parseInt(prompt('Informe a raíz: '));

var soma = numero;
var resultado = numero.toString();

for (var i = 0; i < 9; i++) {
    soma += raiz;
    resultado += ', ' + soma;
}

alert('A P.A. é: '+ resultado);

