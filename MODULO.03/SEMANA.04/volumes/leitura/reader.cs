using System.IO;
using System;


class Program
{
	static void Main()
	{
		string caminho = "/app/data/escrita.txt";
		
		string conteudo = File.ReadAllText(caminho);
		
		Console.WriteLine($"O conteúdo do arquivo é: {conteudo}");
	}


}