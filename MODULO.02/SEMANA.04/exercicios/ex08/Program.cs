using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex08
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Cachorro cachorro = new Cachorro();

			cachorro.Nome = "Lily";
			cachorro.Idade = 4;
			cachorro.EmitirSom();

			Gato Gato = new Gato();

			Gato.Nome = "Bibi";
			Gato.Idade = 16;
			Gato.EmitirSom();

		}
	}
}