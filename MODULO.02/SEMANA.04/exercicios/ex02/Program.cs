using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ContaBancaria conta1 = new ContaBancaria(50, 0);

			// DEPÓSITO
			conta1.deposita(1000);
			// SAQUE
			conta1.saca(50);
			// VERIFICAR SALDO DISPONÍVEL
			Console.WriteLine($"Saldo Disponível: {conta1.getSaldo()}");
		}
	}
}