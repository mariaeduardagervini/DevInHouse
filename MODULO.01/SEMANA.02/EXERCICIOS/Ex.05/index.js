var numdigitado = parseInt(prompt('Digite um número: '));

if (isNaN(numdigitado)){
    alert('Número iválido!');
}else {
    var pares = 0;
    var impares = 0;
    for(var i = 0; i <= numdigitado; i++) {
        if(i % 2 === 0) {
            pares+=1;
        }else {
            impares += 1;
        }
    }
    alert(`Existem ${pares} números pares e ${impares} números ímpares`)
}