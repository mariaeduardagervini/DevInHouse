using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex03
{
	public class Cliente
	{
		private String nome;
		private String cpf;

		public Cliente(string nome, string cpf)
		{
			this.nome = nome;
			this.cpf = cpf;
		}
		public override string ToString()
		{
			return "Nome: " + nome + ", CPF: " + cpf;
		}
	}
}

