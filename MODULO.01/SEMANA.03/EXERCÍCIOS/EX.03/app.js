function concatena(arrayA, arrayB) {
  const novoArray = [...arrayA, ...arrayB];
  return novoArray;
}

const novoArray = concatena([1, 2, 3], [4, 5, 6]);

console.log(novoArray);
