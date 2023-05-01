using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	public class Banco
	{
		private double saldo;

		public void depositar(double valor)
		{
			saldo += valor;
		}
		public void sacar(double valor)
		{
			saldo -= valor;
		}
		public override string ToString()
		{
			return "Saldo: " + saldo;
		}
	}
}

