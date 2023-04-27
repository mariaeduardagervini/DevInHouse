using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
	public class Contador
	{
		public static int Total { get; private set; }
		public Contador()
		{
			Total++;
		}
	}
}
