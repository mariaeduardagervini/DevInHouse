internal class Program
{
	private static void Main(string[] args)
	{
		int[] numeros = new int[4];

		for(int i = 0; i < numeros.Length; i++) {
		Console.Write("Digite um número inteiro: ");
		numeros[i] = int.Parse(Console.ReadLine());
		}
		Array.Sort(numeros);

	foreach (var item in numeros)
	{
		Console.Write($"{item} ");
	}
	}
}