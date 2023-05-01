using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	public class ContaBancaria
	{
		private int numero;
		private Cliente cliente;
		private Banco banco;

		public ContaBancaria(int numero, Cliente cliente, Banco banco)
		{
			this.numero = numero;
			this.cliente = cliente;
			this.banco = banco;
		}

		public void Depositar(double valor)
		{
			banco.depositar(valor);
		}
		public void Sacar(double valor)
		{
			banco.sacar(valor);
		}
		public void ExibirDados()
		{
			Console.WriteLine("Conta: " + numero);
			Console.WriteLine(cliente.ToString());
		}
		public override String ToString()
		{
			return "Conta: " + numero + ", " + cliente.ToString() + ", " + banco.ToString();
		}
	}
}
