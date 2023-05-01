using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex05
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Pessoa pessoa1 = new Pessoa();
			pessoa1.Nome = "Maria";
			pessoa1.DefinirIdade(29);

			Console.WriteLine($"Nome: {pessoa1.Nome}" );
			Console.WriteLine($"Idade: {pessoa1.Idade} anos" );
		}
	}
}