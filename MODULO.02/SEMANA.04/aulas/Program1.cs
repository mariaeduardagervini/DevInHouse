using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
	internal class Program {

		private static void Main(string[] args) 
		{

		// PARTE 1

		// propriedade
		// pertence ao tipo e não a uma instância
		// serve como a "raiz", sempre fica na memória
		// Matematica matematica1 = new Matematica();

		// int resultadoSoma = Matematica.Soma(100, 23);
		// Console.WriteLine($"O resultado da soma é: {resultadoSoma} ");

		// PARTE 2

		Contador c1 = new Contador(); // instância objeto 1
		Contador c2 = new Contador(); // instância objeto 2

		int Total = Contador.Total;
		

		}
	}
}