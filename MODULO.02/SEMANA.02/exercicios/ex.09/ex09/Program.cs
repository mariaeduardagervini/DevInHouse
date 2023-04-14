internal class Program
{
	private static void Main(string[] args)
	{
		int quantidade, soma;
		double media;

		Console.WriteLine("Digite a quantidade de números que você deseja para calcular a média aritmética: ");
		quantidade = int.Parse(Console.ReadLine());

		int[] numeros = new int(quantidade);

		for (int i = 0; i < numeros.Length; i++) {
			Console.WriteLine("Digite o número desejado: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
		foreach (var item in numero)
		{
			soma += item;
		}
		soma = double.Parse(Console.WriteLine());
		Console.WriteLine($"A média aritmética dos números digitados é: {media}");
	}	
}