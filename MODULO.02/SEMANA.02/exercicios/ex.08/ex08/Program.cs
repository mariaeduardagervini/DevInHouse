internal class Program
{
	private static void Main(string[] args)
	{
		int[] numeros = new int[5];

		for (int i = 0; i < numeros.Length; i++) {
			Console.WriteLine("Digite um número inteiro: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
		Array.Sort(numeros);
		Console.WriteLine($"O maior número digitado é: {numeros[4]}");
	}	
}