//Formulário de Cadastro

let contas = [
  {
    nome: 'Thais Bertoldo',
    cpf: '999.999.999.99',
    celular: '(99) 99999-9999',
    senha: '1',
    conta: 1,
    saldo: 100,
  },
];

const formulario = document.getElementById('form-cadastro');

const enviarFormulario = (event) => {
  event.preventDefault();

  const senha = event.target.senha.value;
  const confSenha = event.target.confSenha.value;

  if (senha !== confSenha) {
    alert('Senhas são divergentes');
    return;
  }

  const nome = event.target.nome.value;
  const cpf = event.target.cpf.value;
  const celular = event.target.celular.value;
  const conta = new Date().getTime();
  const saldo = 0;

  const contaCriada = {
    conta,
    nome,
    cpf,
    celular,
    senha,
    saldo,
  };

  contas.push(contaCriada);

  alert(`Conta criada com sucesso. Número: ${conta}`);
};

formulario.addEventListener('submit', enviarFormulario);

//Formulário de Operações

const formOperacao = document.getElementById('form-operacao');

const sacar = (conta, valor) => {
  if (valor > 0) {
    if (conta.saldo >= valor) {
      const novoSaldo = conta.saldo - valor;
      conta.saldo = novoSaldo;

      alert(`Saque efetuado com sucesso! Novo saldo: ${novoSaldo}`);
      return;
    }

    alert('Saldo insuficiente');
    return;
  }

  alert('Não foi possível efetuar o saque.');
};

const depositar = (conta, valor) => {
  if (valor > 0) {
    const novoSaldo = conta.saldo + valor;
    conta.saldo = novoSaldo;

    alert(`Deposito efetuado com sucesso! Novo saldo: ${novoSaldo}`);
    return;
  }

  alert('Não foi possível efetuar o depósito.');
};

const consultarSaldo = (conta) => {
  alert(`Saldo atual: ${conta.saldo}`);
};

const enviarFormularioOperacao = (event) => {
  event.preventDefault();

  const conta = parseInt(event.target.conta.value);
  const operacao = event.target.operacao.value;
  const valor = parseFloat(event.target.valor.value);
  const senha = event.target.senhaOperacao.value;

  const contaAtual = contas.find((elemento) => elemento.conta === conta);

  if (!contaAtual) {
    alert('Conta inválida');
    return;
  }

  if (contaAtual.senha !== senha) {
    alert('Senha inválida');
    return;
  }

  switch (operacao) {
    case 'saque':
      sacar(contaAtual, valor);
      break;
    case 'deposito':
      depositar(contaAtual, valor);
      break;
    case 'saldo':
      consultarSaldo(contaAtual);
      break;
    default:
      alert('Operacão inválida');
      break;
  }
};

formOperacao.addEventListener('submit', enviarFormularioOperacao);

const operacao = document.getElementById('operacao');
operacao.addEventListener('change', (event) => {
  const inputValor = document.getElementById('valor');

  if (event.target.value === 'saldo') {
    inputValor.disabled = true;

    inputValor.value = '';
    return;
  }

  inputValor.disabled = false;
});
