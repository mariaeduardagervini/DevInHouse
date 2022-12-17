const ada = {
  nome: 'Ada',
  idade: 36,
  profissao: 'matemática',
};

const montaMensagem = ({ nome, idade, profissao }) => `Esta é ${nome}, tem ${idade} anos e é ${profissao}`;

const mensagem = montaMensagem(ada);

console.log(mensagem);
