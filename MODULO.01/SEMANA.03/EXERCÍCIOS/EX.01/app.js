const procuraMinMax = (numeros) => {
  if (Array.isArray(numeros) && numeros.length > 0) {
    let maior = numeros[0];
    let menor = numeros[0];

    for (let i = 1; i < numeros.length; i++) {
      if (numeros[i] > maior) {
        maior = numeros[i];
      }
      if (numeros[i] < menor) {
        menor = numeros[i];
      }
    }
    console.log(`Maior: ${maior} e Menor: ${menor}`);
  } else {
    console.log('Não é possível encontrar');
  }
};

procuraMinMax([56, 65, 64, -3, 23, 42, -15, 65, 14, 32, 78, 70, 47]);
procuraMinMax([]);
procuraMinMax([1]);
procuraMinMax([1, -1]);
procuraMinMax(null);
procuraMinMax([-2, -2, -2, -2]);
procuraMinMax([20, 10, 30]);
