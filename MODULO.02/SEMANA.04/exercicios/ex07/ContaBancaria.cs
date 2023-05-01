using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex07
{
	public class ContaBancaria
	{
		public int NumeroConta { get; set; }
		public const decimal SaldoMaximo = 5000;
		private decimal Saldo { get; set; }

		public void Depositar(decimal valor)
		{
			if(valor > 0 && valor <= SaldoMaximo)
			{
				Saldo += valor;
				Console.WriteLine("Depósito realizado com sucesso!. Saldo atual de: " + Saldo);
			}else
			{
				{
					Console.WriteLine("Valor inválido para depósito!");
				}
			}
		}
		public void Sacar(decimal valor)
		{
			if(valor > 0 && Saldo > valor)
			{
				Saldo -= valor;
				Console.WriteLine("Saque realizado com sucesso!. Saldo atual de: " + Saldo);
			}else
			{
				{
					Console.WriteLine("Valor inválido para saque!");
				}
			}
		}
	}
}