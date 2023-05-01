using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex06
{
	public class Retangulo
	{
		private double largura;
		private double altura;

		public double Largura
		{
			get { return largura; }
			set { largura = value >= 0 ? value : 0; }
		}
		public double Altura
		{
			get { return altura; }
			set { altura = value >= 0 ? value : 0; }
		}
		public double CalcularArea()
		{
			return Largura * Altura;
		}
	}
}