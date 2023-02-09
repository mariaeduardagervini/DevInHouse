const KEY_TOKEN_USUARIO = 'ktu';

// Gravar um item no local storage
localStorage.setItem(KEY_TOKEN_USUARIO, '123');

// Obter item no local Storage
const valor = localStorage.getItem(KEY_TOKEN_USUARIO);
console.log(valor);

// Remover todas as chaves do local storage
localStorage.clear();

// Armazenar array ou ojeto
const aluno = {
  nome: 'João',
  numeroChamada: 12,
};

localStorage.setItem('aluno1', JSON.stringify(aluno));
console.log(localStorage.getItem('aluno1'));

//Obter array ou objeto
const alunoObtido = JSON.parse(localStorage.getItem('aluno1'));
console.log(alunoObtido);

//Armazenar número
localStorage.setItem('numero', 1);

// Obter numero
const numeroObtido = parseInt(localStorage.getItem('numero'));
console.log(typeof numeroObtido);
