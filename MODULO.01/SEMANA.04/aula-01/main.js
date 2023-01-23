const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 44, 56];

//Obter o tamanho do array
console.log('Tamanho do array', numeros.length);

//Adicionar elemento ao final do array
const novoTamanho = numeros.push(45);
console.log('Array com push', novoTamanho);

// Remover último elemento do array
const elementoRemovido = numeros.pop();
console.log('Array pop', elementoRemovido);

// Remover o primeiro elemento do array
const primeiroElementoRemovido = numeros.shift();
console.log('Array shift', primeiroElementoRemovido);
