using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex05
{
	public class Pessoa
	{
		private string nome;
		private int idade;

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public int Idade
		{
			get { return idade; }
			set { idade = value; }
		}

		public void DefinirIdade(int idade) 
		{
			if(idade >= 0)
			{
				Idade = idade;
			}
		}
	}
}