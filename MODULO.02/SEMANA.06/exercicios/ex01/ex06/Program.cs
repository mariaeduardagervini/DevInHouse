internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Digite os números: ");

		List<int> lista = new List<int>() {2,6,7,9,1,-4,-3,888};
		int menor;
		int maior;

		for(int i = 0; i < lista.Count; i++)
		{
			Console.WriteLine("\n--------------------\n");
			foreach (var item in lista)
			{
				Console.WriteLine(item);
			}
			for (int j = i; j < lista.Count; j ++)
			{
				while(lista[i] > lista[j]){
					menor = lista[j];
					maior = lista[i];
					lista[i] = menor;
					lista[j] = maior;
				}
			}
		}
		foreach (var item in lista)
			{
				Console.WriteLine(item);
			}
		
	}
}
