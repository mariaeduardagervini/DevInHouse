namespace BancoFullStack
{
	public class PessoaFisica
	{
		public string CPF { get; set; }
		public string Nome { get; set; }
		public DateTime DataNqascimento { get; set; }

		public PessoaFisica()
		{

		}
		public PessoaFisica(int numeroConta, string endereco, string telefone, string cpf, string nome, DateTime dataNascimento):base(numeroConta, endereco, telefone);
	
	}
}