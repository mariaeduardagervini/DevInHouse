internal class Program
{
	private static void Main(string[] args)
	{
		// Variáveis
		String? nome; // Tipo de dado "texto"
		int numero1, numero2; // Declaração de duas variáveis do tipo inteiro
		//Mensagens instrucionais ao usuário
		Console.WriteLine("Olá mundo! Digite o seu nome: ");

		// Entradas - Inserção de dados
		nome = Console.ReadLine(); // Aguardando o usuário digitar 

		Console.WriteLine("Olá " + nome + ", digite um número: ");
		numero1 = Console.Read();
		// Processamentos - cálculos, regras de negócio

		//Saídas: mostrar resultados em tela
		Console.WriteLine("Olá " + nome + "! Seja bem-vindo ao C#!"); // + está concatenando 
	}
}


