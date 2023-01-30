const formulario = document.getElementById('form-cadastro');

const enviarFormulario = (event) => {
  event.preventDefault();

  const senha = event.target.senha.value;
  const confSenha = event.target.confSenha.value;

  if (senha !== confSenha) {
    alert('Senhas são conferem!');
    return;
  }

  // const cadastro = {
  //   conta: new Date().getTime(),
  //   nome: event.target.nome.value,
  //   cpf: event.target.cpf.value,
  //   celular: event.target.celular.value,
  //   senha: event.target.senha.value,
  //   concluida: false,
  // };
  // console.log(cadastro);
  //cadastros.push(cadastro);
};
formulario.addEventListener('submit', enviarFormulario);
