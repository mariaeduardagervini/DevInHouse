internal class Program
{
	private static void Main(string[] args)
	{
		string frase = "A linguagem de programação C# é muito poderosa";
		string[] palavras = frase.Split(' ');

		Console.WriteLine(palavras[7]);		
	}
}