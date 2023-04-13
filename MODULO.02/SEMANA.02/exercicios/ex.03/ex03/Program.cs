internal class Program
{
	private static void Main(string[] args)
	{
		string nome;
		int idade;

		Console.WriteLine("Digite o nome do paciente: ");
		nome = Console.ReadLine();

		Console.WriteLine("Digite a idade do paciente: ");
		idade = int.Parse(Console.ReadLine());

		if(idade < 18) 
		{
			Console.WriteLine($"O paciente {nome} é MENOR de idade, pois tem {idade} anos");
		} else if (idade >= 60) {
			Console.WriteLine($"O paciente {nome} é IDOSO, pois tem {idade} anos");
		} else 
		{
			Console.WriteLine($"O paciente {nome} é MAIOR de idade, pois tem {idade} anos");
		}
	}
}
