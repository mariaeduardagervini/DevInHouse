internal class Program {

	private static void Main(string[] args) 
	{
		Console.WriteLine("Hello, World!");

		Exemplo exemplo01 = new Exemplo(); // Instanciando um objeto da classe Exemplo

		exemplo01.nome = "Maria";
		exemplo01.cpf = 123;

	}
}

// Encapsulamento

// Proteger dados de uma classe
// GET = Ler
// SET = Alterar

// Permissionar, impedir que sejam acessados diretamente