using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	public class Cliente
	{
		private string Nome { 
			get { return nome; }
			}
		private string cpf;

		public Cliente(string nome, string cpf)
		{
			this.nome = nome;
			this.cpf = cpf;
		}
	}
}
