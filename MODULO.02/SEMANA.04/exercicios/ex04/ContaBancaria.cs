using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex04
{
	public class ContaBancaria
	{
		private decimal saldo;

		public decimal Saldo
		{
			get { return saldo; }
			set { saldo = value >= 0 ? value : 0; }
		}
		public void Depositar(decimal valor)
		{
			Saldo += valor;
		}
		public bool Sacar(decimal valor)
		{
			if(Saldo > valor && valor >= 0) 
			{
				Saldo -= valor;
				return true;
			}
			return false;
		}
	}
}