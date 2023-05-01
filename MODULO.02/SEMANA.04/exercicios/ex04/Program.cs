using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex04
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ContaBancaria conta = new ContaBancaria();

			conta.Depositar(1000);

			Console.WriteLine("Saldo após o depósito: " + conta.Saldo);

			// Saque maior que o saldo disponivel
			bool saque1 = conta.Sacar(2000);
			Console.WriteLine("Saque de R$ 2000,00" + (saque1 ? " realizado com sucesso!" : " não foi possível realizar o saque"));

			//Saque menor que o saldo disponivel
			bool saque2 = conta.Sacar(500);
			Console.WriteLine("Saque de R$ 500,00" + (saque2 ? " realizado com sucesso!" : " não foi possível realizar o saque"));

			Console.WriteLine("Saldo após os saques: " + conta.Saldo);

		}
	}
}