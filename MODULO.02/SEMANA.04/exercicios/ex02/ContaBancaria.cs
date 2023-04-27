using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex02
{
	public class ContaBancaria
	{
		private int numeroConta;
		private double saldo;
		public ContaBancaria(int numeroConta, double saldo)
		{
			this.numeroConta = numeroConta;
			this.saldo = saldo;
		}
		public void deposita(double valor)
		{
			this.saldo = valor;
		}
		public void saca(double valor)
		{
			if(valor <= saldo)
			{
				this.saldo -= valor;
			}
			else
			{
				Console.WriteLine("Saldo Insuficiente!");
			}
		}
		public double getSaldo()
		{
			return saldo;
		}
	}
}