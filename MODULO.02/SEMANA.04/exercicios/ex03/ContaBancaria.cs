using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	public class ContaBancaria
	{
		private string numero;
		private Cliente cliente;
		public ContaBancaria(string numero, Cliente cliente)
		{
			this.numero = numero;
			this.cliente = cliente;
		}
		public void ExibirDados()
		{
			Console.WriteLine($"Número da conta: {numero}");
			Console.WriteLine($"Nome do cliente: {cliente.nome}");
			Console.WriteLine($"CPF do cliente: {cliente.cpf}");
		}
			Banco banco1 = new Banco();

		public void Depositar(double valor)
		{
			banco1.depositar(valor);
		}
		public void Sacar(double valor)
		{
			banco1.sacar(valor);
		}
			public override string ToString()
		{
			return $"Dados da conta: \nConta: {numero} \n Nome: {cliente.nome}, CPF: {cliente.cpf}";
		}
	}
}