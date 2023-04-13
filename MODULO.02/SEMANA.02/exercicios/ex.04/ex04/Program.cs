internal class Program
{
	private static void Main(string[] args)
	{
		string marca, modelo;
		double kmsRodados;

		Console.WriteLine("Digite a marca do veículo: ");
		marca = Console.ReadLine();

		Console.WriteLine("Digite o modelo do veículo: ");
		modelo = Console.ReadLine();
		
		Console.WriteLine("Digite a quantidade de quilometros rodados do veículo: ");
		kmsRodados = double.Parse(Console.ReadLine());

		Console.WriteLine($"\n - Marca do veículo: {marca}\n - Modelo do veículo: {modelo}\n - Quilometragem rodada: {kmsRodados}");

		if(kmsRodados > 10000) {
			Console.WriteLine("É necessário fazer a REVISÃO do veículo!");
		}

	}
}
