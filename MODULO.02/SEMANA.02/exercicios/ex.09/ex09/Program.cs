internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Digite quantos números deseja para calcular a média: ");
		int quantidade = int.Parse(Console.ReadLine());

		int[] numeros = new int[quantidade];

		for (int i = 0; i < quantidade; i++) {
			Console.WriteLine($"Digite o {i + 1}º número: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
		int soma = 0;
		foreach (int numero in numeros)
		{
			soma += numero;
		}
		double media = (double)soma / quantidade;
		
		Console.WriteLine($"A média dos números digitados é: {media}");
	}	
}