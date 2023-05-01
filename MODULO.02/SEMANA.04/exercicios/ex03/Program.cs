using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Cliente cliente = new Cliente("Maria Eduarda Gervini", "123.456.789-00");

			ContaBancaria conta = new ContaBancaria(321, cliente, new Banco());

			Console.WriteLine("Dados da conta: ");
			conta.ExibirDados();
			Console.WriteLine();

			Console.WriteLine("Depósito de R$ 1.000,00");
			conta.Depositar(1000);
			Console.WriteLine(conta.ToString());
			Console.WriteLine();

			Console.WriteLine("Saque de R$ 500,00");
			conta.Sacar(500);
			Console.WriteLine(conta.ToString());
			Console.WriteLine();

		}
	}
}