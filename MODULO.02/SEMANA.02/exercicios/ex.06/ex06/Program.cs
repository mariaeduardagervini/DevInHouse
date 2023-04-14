internal class Program
{
	private static void Main(string[] args)
	{
		string frase = "A linguagem de programação C# é muito poderosa";
		List<string> palavra = new List<string> (frase.Split(""));

		foreach (var item in palavra)
		{
			if(item == "poderosa") {
				Console.WriteLine(item);
			}
		}
		
	}
}