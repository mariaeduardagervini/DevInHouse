using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex08
{
	public class Cachorro : Animal
	{
		public override void EmitirSom()
		{
			Console.WriteLine("Au au");
		}
	}
}