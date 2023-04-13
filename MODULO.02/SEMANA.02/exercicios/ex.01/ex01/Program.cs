	internal class Program
{
	private static void Main(string[] args)
	{
	int numero1, numero2, soma;
		Console.WriteLine("Digite o primeiro número: ");
		numero1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o segundo número: ");
		numero2 = int.Parse(Console.ReadLine());

		soma = numero1 + numero2;

		Console.WriteLine($"A soma dos números é: {soma}");

	}
}
