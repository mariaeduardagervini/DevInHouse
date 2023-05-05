namespace BancoFullStack.Model
{
	public abstract class Cliente
	{
		

		public int NumeroConta { get; set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
		public decimal Saldo { get; set; }

		public string ResumoCliente()
		{
			return $"Número Conta: {NumeroConta} | Endereço: {Endereco} | Telefone: {Telefone} | Saldo: {Saldo}";
		}
		public Cliente()
		{

		}
		public Cliente(int numeroConta, string endereco, string telefone, decimal saldo)
		{
			NumeroConta = numeroConta;
			Endereco = endereco;
			Telefone = telefone;
			Saldo = 0;
		}
	}
}