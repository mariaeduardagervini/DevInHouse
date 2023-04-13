internal class Program
{
	private static void Main(string[] args)
	{
	int numero;

	Console.WriteLine("Digite um número inteiro: ");
	numero = int.Parse(Console.ReadLine());

	if (numero % 2 == 0) 
	{
		Console.WriteLine("O número é par!");
	} else 
	{
		Console.WriteLine("O número é ímpar!");
	}
	}
}
