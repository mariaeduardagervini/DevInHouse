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

		// Contador c1 = new Contador(); // instância objeto 1
		// Contador c2 = new Contador(); // instância objeto 2

		// int Total = Contador.Total;

		// PARTE 3

		// Modificador de acesso static para Classes
		// Ao definir uma classe como static, não tem a necessidade de criar instâncias dessa classe
		// Não pode ser instanciada, uma classe estática
		// Declara uma classe como estática, todos os membros da classe devem ser também estáticos

		int resultadoSoma = Calculadora.Soma(10,5);
		int resultadoSubtracao = Calculadora.Subtracao(10,5);

		Console.WriteLine($"O resultado de soma é {resultadoSoma}, e o da subtração é: {resultadoSubtracao}");

		// Não é possível devido a classe Calculadora ser ESTÁTICA
		// Calculadora cal1 = new Calculadora();
		// Não permite HERANÇA



		}
	}
}