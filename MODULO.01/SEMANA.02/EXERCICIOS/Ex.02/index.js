var idade = parseInt(prompt('Informe a idade: '));

if(idade >=0 && idade <=15) {
    alert('Jovens')
}else if(idade >= 16 && idade <=64){
    alert('Adulto')
}else if(idade >= 65) {
    alert('Idoso')
}else {
    alert('Valor inválido!')
}
