using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex06
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Retangulo retangulo = new Retangulo();

			retangulo.Largura = 5;
			retangulo.Altura = 10;

			double area = retangulo.CalcularArea();

			Console.WriteLine($"Área do retângulo: {area}");
		}
	}
}