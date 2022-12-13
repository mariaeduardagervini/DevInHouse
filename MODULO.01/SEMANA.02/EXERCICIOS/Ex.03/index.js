var numero = parseInt(prompt('Digite um número para saber sua tabuada: '));

if(isNaN(numero)) {
    alert('Número inválido!');
}else {
    var resultado = '';
    for (var i = 0; i <= 10; i++) {
        resultado += `${numero} X ${i} = ${numero * i} \n`;
    }
    alert(resultado);
}

