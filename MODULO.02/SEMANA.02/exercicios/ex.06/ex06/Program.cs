internal class Program
{
	private static void Main(string[] args)
	{
		string frase = "A linguagem de programação C# é muito poderosa";
		List<string> palavra = new List<string> (frase.Split(""));

		foreach (string item in palavra)
		{
			if(item == "poderosa") {
				Console.Write(item);
			}
		}
		
	}
}