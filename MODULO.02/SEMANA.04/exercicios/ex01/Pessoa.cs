using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex01
{
	public class Pessoa
	{
		private string nome;
		protected int idade { get; set; }
		public string endereco { get; set; }

	  	public Pessoa(string nome, int idade, string endereco)
    	{
      		this.nome = nome;
      		this.idade = idade;
      		this.endereco = endereco;
    	}
		public void saudacao()
		{
		Console.WriteLine($"Olá meu nome é {nome} e eu tenho {idade} anos");
		}
	}
}